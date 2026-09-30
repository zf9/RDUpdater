using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
    public partial class MainForm
    {
        private Button updatesFetchButton;
        private Button updatesCancelButton;
        private Button updatesFirmwareDownloadButton;
        private Button updatesGpsDownloadButton;
        private Label updatesHeading;
        private Label updatesDescription;
        private Label updatesFirmwareDate;
        private Label updatesGpsDate;
        private Label updatesStatus;
        private Panel updatesFirmwareCard;
        private Panel updatesGpsCard;
        private ProgressBar updatesProgress;
        private UpdateCatalog updatesCatalog;
        private string updatesDetector;
        private CancellationTokenSource updatesOperation;
        private string updatesSaveDirectory;

        private void InitializeUpdatesPage()
        {
            this.updatesHeading = new Label { Name = "UpdatesHeading", Text = "Detector updates", TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(24, 20, 377, 30), Font = new Font("Calibri", 18f, FontStyle.Bold), Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
            this.updatesDescription = new Label { Name = "UpdatesDescription", Text = "Fetch available firmware and GPS files\r\nfor your connected R4NZ or R8NZ.", TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(24, 57, 377, 38), Font = new Font("Calibri", 10f), Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
            this.updatesFetchButton = CreateUpdatesButton("UpdatesFetchButton", "Fetch", new Rectangle(142, 195, 140, 36));
            this.updatesFetchButton.Click += this.UpdatesFetchButton_Click;
            this.updatesCancelButton = CreateUpdatesButton("UpdatesCancelButton", "Cancel", new Rectangle(313, 105, 88, 34));
            this.updatesCancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.updatesCancelButton.Visible = false;
            this.updatesCancelButton.Click += delegate { if (this.updatesOperation != null) this.updatesOperation.Cancel(); };
            this.updatesFirmwareCard = CreateUpdatesCard("UpdatesFirmwareCard", "Firmware", 151, out this.updatesFirmwareDate, out this.updatesFirmwareDownloadButton);
            this.updatesGpsCard = CreateUpdatesCard("UpdatesGpsCard", "GPS database", 249, out this.updatesGpsDate, out this.updatesGpsDownloadButton);
            this.updatesFirmwareDownloadButton.Click += async delegate { await this.DownloadUpdateAsync(true); };
            this.updatesGpsDownloadButton.Click += async delegate { await this.DownloadUpdateAsync(false); };
            this.updatesStatus = new Label { Name = "UpdatesStatus", Text = "Files are saved only. Nothing is installed automatically.", TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(24, 349, 377, 36), Font = new Font("Calibri", 9f), Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
            this.updatesProgress = new ProgressBar { Name = "UpdatesProgress", Bounds = new Rectangle(24, 393, 377, 10), Visible = false,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
            this.UpdatesTab.Controls.AddRange(new Control[] { this.updatesHeading, this.updatesDescription, this.updatesFetchButton, this.updatesCancelButton,
                this.updatesFirmwareCard, this.updatesGpsCard, this.updatesStatus, this.updatesProgress });
            this.UpdatesTab.Resize += delegate
            {
                this.updatesFetchButton.Left = (this.UpdatesTab.ClientSize.Width - this.updatesFetchButton.Width) / 2;
                if (this.updatesCatalog == null && this.updatesOperation == null)
                    this.updatesFetchButton.Top = (this.UpdatesTab.ClientSize.Height - this.updatesFetchButton.Height) / 2;
            };
            this.UpdatesTab.Disposed += delegate { if (this.updatesOperation != null) this.updatesOperation.Cancel(); };
            this.ApplyUpdatesTheme(false);
        }

        private static Button CreateUpdatesButton(string name, string text, Rectangle bounds)
        {
            Button button = new Button { Name = name, Text = text, Bounds = bounds, Font = new Font("Calibri", 10f), FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand, UseVisualStyleBackColor = false };
            button.FlatAppearance.BorderSize = 1;
            return button;
        }

        private static Panel CreateUpdatesCard(string name, string title, int top, out Label date, out Button download)
        {
            Panel card = new Panel { Name = name, Bounds = new Rectangle(24, top, 377, 88), BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, Visible = false };
            Label heading = new Label { Text = title, Bounds = new Rectangle(16, 13, 215, 24), Font = new Font("Calibri", 12f, FontStyle.Bold),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
            date = new Label { Name = name + "Date", Text = "Last updated: —", Bounds = new Rectangle(16, 43, 230, 22), Font = new Font("Calibri", 9.5f),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
            download = CreateUpdatesButton(name + "Download", "Download…", new Rectangle(255, 26, 104, 34));
            download.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            download.Enabled = false;
            card.Controls.AddRange(new Control[] { heading, date, download });
            return card;
        }

        private void ApplyUpdatesTheme(bool dark)
        {
            if (this.updatesFetchButton == null) return;
            Color text = dark ? SystemColors.ButtonFace : Color.FromArgb(35, 35, 35);
            Color muted = dark ? Color.FromArgb(185, 185, 185) : Color.FromArgb(100, 100, 100);
            Color surface = dark ? Color.FromArgb(40, 40, 40) : Color.FromArgb(247, 247, 247);
            this.UpdatesTab.ForeColor = text;
            this.updatesHeading.ForeColor = text;
            this.updatesDescription.ForeColor = muted;
            this.updatesStatus.ForeColor = muted;
            foreach (Panel card in new[] { this.updatesFirmwareCard, this.updatesGpsCard })
            {
                card.BackColor = surface;
                card.ForeColor = text;
            }
            this.updatesFirmwareDate.ForeColor = muted;
            this.updatesGpsDate.ForeColor = muted;
            foreach (Button button in new[] { this.updatesFirmwareDownloadButton, this.updatesGpsDownloadButton, this.updatesCancelButton })
            {
                button.BackColor = surface;
                button.ForeColor = text;
                button.FlatAppearance.BorderColor = dark ? Color.FromArgb(85, 85, 85) : Color.FromArgb(195, 195, 195);
                button.FlatAppearance.MouseOverBackColor = dark ? Color.FromArgb(65, 65, 65) : Color.FromArgb(230, 230, 230);
            }
            this.updatesFetchButton.BackColor = dark ? Color.FromArgb(220, 220, 220) : Color.FromArgb(45, 45, 45);
            this.updatesFetchButton.ForeColor = dark ? Color.Black : Color.White;
            this.updatesFetchButton.FlatAppearance.BorderColor = this.updatesFetchButton.BackColor;
            this.updatesFetchButton.FlatAppearance.MouseOverBackColor = dark ? Color.White : Color.FromArgb(70, 70, 70);
        }

        private void ClearUpdateCatalog()
        {
            this.updatesCatalog = null;
            this.updatesDetector = null;
            this.updatesFirmwareCard.Visible = false;
            this.updatesGpsCard.Visible = false;
            this.updatesFirmwareDownloadButton.Enabled = false;
            this.updatesGpsDownloadButton.Enabled = false;
            this.updatesDescription.Text = "Fetch available firmware and GPS files\r\nfor your connected R4NZ or R8NZ.";
        }

        private void ShowUpdateCatalog(UpdateCatalog catalog, string detector)
        {
            this.updatesCatalog = catalog;
            this.updatesDetector = detector;
            this.updatesDescription.Text = detector + " · Available downloads\r\nChoose Download to select a save location.";
            this.updatesFirmwareDate.Text = "Last updated: " + catalog.Firmware.LastUpdated;
            this.updatesGpsDate.Text = "Last updated: " + catalog.Gps.LastUpdated;
            this.updatesFirmwareCard.Visible = true;
            this.updatesGpsCard.Visible = true;
            this.updatesFetchButton.Top = 104;
        }

        private void SetUpdatesBusy(bool busy)
        {
            this.updatesFetchButton.Enabled = !busy;
            this.updatesFetchButton.Text = busy && this.updatesCatalog == null ? "Fetching…" : "Fetch";
            this.updatesFirmwareDownloadButton.Enabled = !busy && this.updatesCatalog != null;
            this.updatesGpsDownloadButton.Enabled = !busy && this.updatesCatalog != null;
            this.updatesCancelButton.Visible = busy;
            this.updatesProgress.Visible = busy;
            this.updatesProgress.Style = ProgressBarStyle.Marquee;
            this.updatesProgress.Value = 0;
            this.updatesFetchButton.Top = busy || this.updatesCatalog != null ? 104 : (this.UpdatesTab.ClientSize.Height - this.updatesFetchButton.Height) / 2;
        }

        private bool CheckUpdateDetector(out string detector)
        {
            string error;
            detector = UpdateCatalogClient.GetDetector(this.connectedModelInfo, out error);
            if (detector != null) return true;
            this.ClearUpdateCatalog();
            this.SetUpdatesBusy(false);
            MessageBox.Show(this, error, "Updates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private async void UpdatesFetchButton_Click(object sender, EventArgs e)
        {
            if (this.updatesOperation != null) return;
            string detector;
            if (!this.CheckUpdateDetector(out detector)) return;
            RDInfo connection = this.connectedModelInfo;
            this.ClearUpdateCatalog();
            CancellationTokenSource operation = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            this.updatesOperation = operation;
            this.SetUpdatesBusy(true);
            this.updatesStatus.Text = "Fetching available updates for " + detector + "…";
            try
            {
                using (HttpClient client = UpdateCatalogClient.CreateClient())
                {
                    UpdateCatalog catalog = await UpdateCatalogClient.FetchAsync(client, detector, operation.Token);
                    if (this.IsDisposed || this.Disposing) return;
                    string error;
                    if (!object.ReferenceEquals(connection, this.connectedModelInfo) ||
                        UpdateCatalogClient.GetDetector(this.connectedModelInfo, out error) != detector)
                    {
                        this.updatesStatus.Text = "Detector connection changed. Please fetch again.";
                        MessageBox.Show(this, this.updatesStatus.Text, "Updates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    this.ShowUpdateCatalog(catalog, detector);
                    this.updatesStatus.Text = "Files are saved only. Nothing is installed automatically.";
                }
            }
            catch (Exception exception)
            {
                if (!this.IsDisposed && !this.Disposing)
                {
                    this.updatesStatus.Text = "No update information loaded.";
                    string message = operation.IsCancellationRequested ? "Fetch cancelled or timed out. Please try again." :
                        "Unable to fetch updates. Please check your internet connection and try again.\r\n\r\n" + exception.Message;
                    MessageBox.Show(this, message, "Updates", MessageBoxButtons.OK, operation.IsCancellationRequested ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                }
            }
            finally
            {
                this.updatesOperation = null;
                operation.Dispose();
                if (!this.IsDisposed && !this.Disposing) this.SetUpdatesBusy(false);
            }
        }

        private async Task DownloadUpdateAsync(bool firmware)
        {
            if (this.updatesOperation != null) return;
            string detector;
            if (!this.CheckUpdateDetector(out detector)) return;
            if (this.updatesCatalog == null || this.updatesDetector != detector)
            {
                this.ClearUpdateCatalog();
                this.SetUpdatesBusy(false);
                MessageBox.Show(this, "The detector has changed. Please fetch its updates first.", "Updates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UpdateDownload item = firmware ? this.updatesCatalog.Firmware : this.updatesCatalog.Gps;
            string kind = firmware ? "firmware" : "GPS database";
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Save " + detector + " " + kind;
                dialog.FileName = UpdateCatalogClient.GetFileName(item, detector + (firmware ? "_firmware.zip" : "_GPS.zip"));
                dialog.Filter = "ZIP archives (*.zip)|*.zip|All files (*.*)|*.*";
                dialog.DefaultExt = Path.GetExtension(dialog.FileName).TrimStart('.');
                dialog.FilterIndex = string.Equals(dialog.DefaultExt, "zip", StringComparison.OrdinalIgnoreCase) ? 1 : 2;
                dialog.AddExtension = true;
                dialog.OverwritePrompt = true;
                if (!string.IsNullOrEmpty(this.updatesSaveDirectory) && Directory.Exists(this.updatesSaveDirectory))
                    dialog.InitialDirectory = this.updatesSaveDirectory;
                else if (Directory.Exists(MainForm.downloadFilePath)) dialog.InitialDirectory = MainForm.downloadFilePath;
                if (dialog.ShowDialog(this) != DialogResult.OK) return;
                // A device can change while the Save As dialog is open.
                if (!this.CheckUpdateDetector(out detector)) return;
                if (this.updatesDetector != detector)
                {
                    this.ClearUpdateCatalog();
                    this.SetUpdatesBusy(false);
                    MessageBox.Show(this, "The detector has changed. Please fetch its updates first.", "Updates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.updatesSaveDirectory = Path.GetDirectoryName(dialog.FileName);
                bool overwriteAllowed = File.Exists(dialog.FileName);
                CancellationTokenSource operation = new CancellationTokenSource(TimeSpan.FromMinutes(15));
                this.updatesOperation = operation;
                this.SetUpdatesBusy(true);
                this.updatesStatus.Text = "Downloading " + detector + " " + kind + "…";
                Progress<UpdateDownloadProgress> progress = new Progress<UpdateDownloadProgress>(value =>
                {
                    if (this.IsDisposed || this.Disposing || this.updatesOperation != operation) return;
                    if (value.TotalBytes.HasValue && value.TotalBytes.Value > 0)
                    {
                        this.updatesProgress.Style = ProgressBarStyle.Continuous;
                        this.updatesProgress.Value = (int)Math.Min(100, value.BytesReceived * 100.0 / value.TotalBytes.Value);
                        this.updatesStatus.Text = "Downloading " + kind + "… " + this.updatesProgress.Value + "%";
                    }
                    else this.updatesStatus.Text = "Downloading " + kind + "… " + (value.BytesReceived / 1048576.0).ToString("0.0") + " MB";
                });
                try
                {
                    using (HttpClient client = UpdateCatalogClient.CreateClient())
                        await UpdateCatalogClient.DownloadAsync(client, item, dialog.FileName, overwriteAllowed, progress, operation.Token);
                    if (this.IsDisposed || this.Disposing) return;
                    this.updatesStatus.Text = detector + " " + kind + " saved successfully.";
                    MessageBox.Show(this, "Download complete.\r\n\r\nSaved to:\r\n" + dialog.FileName +
                        "\r\n\r\nNo update has been installed on your detector.", "Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    if (!this.IsDisposed && !this.Disposing)
                    {
                        this.updatesStatus.Text = "Download not saved.";
                        string message = operation.IsCancellationRequested ? "Download cancelled or timed out. No partial download was saved." :
                            "Unable to download the file. Please check your internet connection and save location.\r\n\r\n" + exception.Message;
                        MessageBox.Show(this, message, "Updates", MessageBoxButtons.OK, operation.IsCancellationRequested ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    this.updatesOperation = null;
                    operation.Dispose();
                    if (!this.IsDisposed && !this.Disposing) this.SetUpdatesBusy(false);
                }
            }
        }
    }
}
