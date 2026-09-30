using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Uniden_R_Series_Tool
{
    [DataContract]
    internal sealed class UpdateCatalog
    {
        [DataMember(Name = "firmware", IsRequired = true)]
        public UpdateDownload Firmware { get; set; }

        [DataMember(Name = "gps", IsRequired = true)]
        public UpdateDownload Gps { get; set; }
    }

    [DataContract]
    internal sealed class UpdateDownload
    {
        [DataMember(Name = "downloadUrl", IsRequired = true)]
        public string DownloadUrl { get; set; }

        [DataMember(Name = "lastUpdated", IsRequired = true)]
        public string LastUpdated { get; set; }
    }

    internal sealed class UpdateDownloadProgress
    {
        public long BytesReceived { get; set; }
        public long? TotalBytes { get; set; }
    }

    // Internet-only downloads. This class never accesses UART or flash/update logic.
    internal static class UpdateCatalogClient
    {
        internal static string GetDetector(RDInfo info, out string error)
        {
            error = null;
            if (info == null || !info.isConnected)
            {
                error = "Please connect your radar detector before fetching updates.";
                return null;
            }
            if (info.modelName == ModelName.R4_NZ) return "R4NZ";
            if (info.modelName == ModelName.R8_NZ) return "R8NZ";
            error = "Detector not supported. Updates are currently available for R4NZ and R8NZ only.";
            return null;
        }

        internal static Uri GetCatalogUri(string detector)
        {
            if (detector != "R4NZ" && detector != "R8NZ")
                throw new ArgumentException("Detector not supported.", "detector");
            return new Uri("https://uniden.rdr2acc69.workers.dev/?detector=" + detector);
        }

        internal static HttpClient CreateClient()
        {
            // .NET 4.5.2 may otherwise default to TLS 1.0. Retain existing protocols.
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
            return new HttpClient(new HttpClientHandler { AllowAutoRedirect = false })
            {
                Timeout = TimeSpan.FromSeconds(30)
            };
        }

        internal static Uri ValidateDownload(UpdateDownload item)
        {
            Uri uri;
            if (item == null || string.IsNullOrWhiteSpace(item.LastUpdated) ||
                item.LastUpdated.Length > 32 || item.LastUpdated.IndexOfAny(new[] { '\r', '\n' }) >= 0 ||
                !Uri.TryCreate(item.DownloadUrl, UriKind.Absolute, out uri) ||
                uri.Scheme != Uri.UriSchemeHttps || !string.IsNullOrEmpty(uri.UserInfo))
                throw new InvalidDataException("The update server returned invalid download details.");
            return uri;
        }

        internal static string GetFileName(UpdateDownload item, string fallback)
        {
            Uri uri = ValidateDownload(item);
            string name = Path.GetFileName(Uri.UnescapeDataString(uri.AbsolutePath));
            foreach (char invalid in Path.GetInvalidFileNameChars()) name = name.Replace(invalid, '_');
            return string.IsNullOrWhiteSpace(name) || name == "." || name == ".." ? fallback : name;
        }

        internal static UpdateCatalog ParseCatalog(Stream stream)
        {
            UpdateCatalog catalog = (UpdateCatalog)new DataContractJsonSerializer(typeof(UpdateCatalog)).ReadObject(stream);
            if (catalog == null) throw new InvalidDataException("The update server returned an empty response.");
            ValidateDownload(catalog.Firmware);
            ValidateDownload(catalog.Gps);
            return catalog;
        }

        private static async Task<HttpResponseMessage> GetResponseAsync(HttpClient client, Uri uri, CancellationToken token)
        {
            // Follow HTTPS redirects explicitly so a server cannot downgrade a download to HTTP.
            for (int redirects = 0; redirects <= 5; redirects++)
            {
                token.ThrowIfCancellationRequested();
                HttpResponseMessage response = await client.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead, token).ConfigureAwait(false);
                int code = (int)response.StatusCode;
                if (code == 301 || code == 302 || code == 303 || code == 307 || code == 308)
                {
                    Uri location = response.Headers.Location;
                    response.Dispose();
                    if (location == null) throw new InvalidDataException("The server returned an invalid redirect.");
                    uri = location.IsAbsoluteUri ? location : new Uri(uri, location);
                    if (uri.Scheme != Uri.UriSchemeHttps || !string.IsNullOrEmpty(uri.UserInfo))
                        throw new InvalidDataException("The server redirected to an insecure address.");
                    continue;
                }
                try { response.EnsureSuccessStatusCode(); }
                catch { response.Dispose(); throw; }
                return response;
            }
            throw new InvalidDataException("The server returned too many redirects.");
        }

        internal static async Task<UpdateCatalog> FetchAsync(HttpClient client, string detector, CancellationToken token)
        {
            using (HttpResponseMessage response = await GetResponseAsync(client, GetCatalogUri(detector), token).ConfigureAwait(false))
            using (Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
            using (token.Register(() => stream.Dispose()))
            using (MemoryStream json = new MemoryStream())
            {
                byte[] buffer = new byte[4096];
                int count;
                while ((count = await stream.ReadAsync(buffer, 0, buffer.Length, token).ConfigureAwait(false)) != 0)
                {
                    if (json.Length + count > 65536) throw new InvalidDataException("The update server response is too large.");
                    json.Write(buffer, 0, count);
                }
                token.ThrowIfCancellationRequested();
                json.Position = 0;
                return ParseCatalog(json);
            }
        }

        internal static async Task DownloadAsync(HttpClient client, UpdateDownload item, string destination,
            bool overwriteAllowed, IProgress<UpdateDownloadProgress> progress, CancellationToken token)
        {
            Uri uri = ValidateDownload(item);
            destination = Path.GetFullPath(destination);
            // Same-directory temporary file: an interrupted transfer cannot corrupt the saved file.
            string temporary = Path.Combine(Path.GetDirectoryName(destination), ".uniden-" + Guid.NewGuid().ToString("N") + ".download");
            try
            {
                using (HttpResponseMessage response = await GetResponseAsync(client, uri, token).ConfigureAwait(false))
                using (Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (token.Register(() => stream.Dispose()))
                using (FileStream file = new FileStream(temporary, FileMode.CreateNew, FileAccess.Write, FileShare.None, 81920, true))
                {
                    long? total = response.Content.Headers.ContentLength;
                    long received = 0;
                    int lastPercent = -1;
                    DateTime lastReport = DateTime.MinValue;
                    byte[] buffer = new byte[81920];
                    int count;
                    while ((count = await stream.ReadAsync(buffer, 0, buffer.Length, token).ConfigureAwait(false)) != 0)
                    {
                        await file.WriteAsync(buffer, 0, count, token).ConfigureAwait(false);
                        received += count;
                        int percent = total.HasValue && total.Value > 0 ? (int)Math.Min(100, received * 100.0 / total.Value) : -1;
                        if (progress != null && (percent != lastPercent || (DateTime.UtcNow - lastReport).TotalMilliseconds >= 200))
                        {
                            progress.Report(new UpdateDownloadProgress { BytesReceived = received, TotalBytes = total });
                            lastPercent = percent;
                            lastReport = DateTime.UtcNow;
                        }
                    }
                    if (received == 0 || (total.HasValue && received != total.Value))
                        throw new InvalidDataException("The download is empty or incomplete. Please try again.");
                    await file.FlushAsync(token).ConfigureAwait(false);
                }
                token.ThrowIfCancellationRequested();
                if (File.Exists(destination))
                {
                    if (!overwriteAllowed) throw new IOException("A file now exists at the selected location. Please choose another name.");
                    File.Replace(temporary, destination, null);
                }
                else File.Move(temporary, destination);
            }
            finally
            {
                // Do not mask a network/file error if temporary-file cleanup itself fails.
                try { if (File.Exists(temporary)) File.Delete(temporary); }
                catch (IOException) { }
                catch (UnauthorizedAccessException) { }
            }
        }
    }
}
