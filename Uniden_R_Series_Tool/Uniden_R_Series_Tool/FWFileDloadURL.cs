using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using HtmlAgilityPack;
using Ionic.Zip;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000016 RID: 22
	public class FWFileDloadURL
	{
		// Token: 0x06000113 RID: 275 RVA: 0x0001317C File Offset: 0x0001137C
		public static bool IsInternetConnected()
		{
			try
			{
				if (new WebClient().DownloadString("http://www.msftncsi.com/ncsi.txt") != "Microsoft NCSI")
				{
					return false;
				}
				IPHostEntry hostEntry = Dns.GetHostEntry("dns.msftncsi.com");
				if (hostEntry.AddressList.Count<IPAddress>() < 0 || hostEntry.AddressList[0].ToString() != "131.107.255.255")
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000131F8 File Offset: 0x000113F8
		public static bool Download(ModelName modelName, string downloadFilePath, out string downloadedFilePath)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			int num = 1;
			downloadedFilePath = null;
			string text4;
			switch (modelName)
			{
			case ModelName.R1:
				text4 = "1";
				goto IL_DF;
			case (ModelName)2:
			case ModelName.R3_NZ:
			case ModelName.R3_NZK:
			case (ModelName)6:
			case ModelName.R7_NZ:
			case ModelName.R7_IL:
			case (ModelName)10:
			case (ModelName)11:
			case (ModelName)12:
			case (ModelName)13:
			case ModelName.R4_NZ:
			case ModelName.R4_IL:
			case ModelName.R4_EU:
			case ModelName.R8_NZ:
			case ModelName.R8_IL:
			case ModelName.R8_EU:
			case (ModelName)22:
			case (ModelName)23:
			case (ModelName)25:
			case (ModelName)26:
			case (ModelName)27:
				return false;
			case ModelName.R3:
				break;
			case ModelName.R7:
				text4 = "7";
				goto IL_DF;
			case ModelName.R4:
				text4 = "4";
				goto IL_DF;
			case ModelName.R8:
				text4 = "8";
				goto IL_DF;
			case ModelName.R4W:
				text4 = "4W";
				goto IL_DF;
			case ModelName.R8W:
				text4 = "8W";
				goto IL_DF;
			default:
				if (modelName != ModelName.R3_PLUS)
				{
					if (modelName != ModelName.R3_NZK_PLUS)
					{
						return false;
					}
					return false;
				}
				break;
			}
			text4 = "3";
			IL_DF:
			bool result;
			try
			{
				string html = new WebClient
				{
					Encoding = Encoding.UTF8
				}.DownloadString("https://www.uniden.info/download/index.cfm?s=R" + text4);
				HtmlDocument htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(html);
				string[] separator = new string[]
				{
					"./files/R" + text4 + "_"
				};
				string[] array = htmlDocument.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
				array[0] = null;
				for (int i = 1; i < array.Length; i++)
				{
					array[i] = "https://www.uniden.info/download/files/R" + text4 + "_" + array[i].Substring(0, 12);
				}
				for (int i = 1; i < array.Length; i++)
				{
					int num2;
					if (!int.TryParse(array[num].Substring(array[num].Length - 12, 8), out num2))
					{
						num2 = 0;
					}
					int num3;
					if (!int.TryParse(array[i].Substring(array[i].Length - 12, 8), out num3))
					{
						num3 = 0;
					}
					if (num2 <= num3)
					{
						num = i;
					}
				}
				WebClient webClient = new WebClient();
				text = downloadFilePath + "\\R" + text4;
				text2 = array[num].Substring(array[num].Length - 15, 11) + ".zip";
				text3 = text + "\\" + text2.Substring(0, text2.Length - 4);
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				if (!new FileInfo(text3 + ".bin").Exists)
				{
					Directory.CreateDirectory(text3);
					webClient.DownloadFile(array[num], text + "\\" + text2);
					FWFileDloadURL.ExtractZipByIonic(text + "\\" + text2, text + "\\" + text2.Substring(0, text2.Length - 4));
					File.Delete(text + "\\" + text2);
					FileInfo[] files = new DirectoryInfo(text3).GetFiles();
					for (int i = 0; i < files.Length; i++)
					{
						if (files[i].Name.Substring(0, 1 + text4.Length).Equals("R" + text4))
						{
							File.Copy(text3 + "\\" + files[i].Name, text3 + ".bin");
						}
						files[i].Delete();
					}
					Directory.Delete(text3);
				}
				downloadedFilePath = text3 + ".bin";
				result = true;
			}
			catch (WebException)
			{
				result = false;
			}
			catch (ThreadAbortException)
			{
				result = false;
			}
			catch (ThreadInterruptedException)
			{
				throw new ThreadInterruptedException();
			}
			catch
			{
				result = false;
			}
			finally
			{
				if (text != string.Empty && text2 != string.Empty && text3 != string.Empty)
				{
					if (Directory.Exists(text3))
					{
						Directory.Delete(text3, true);
					}
					if (File.Exists(text + "\\" + text2))
					{
						File.Delete(text + "\\" + text2);
					}
				}
			}
			return result;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00013640 File Offset: 0x00011840
		private static void ExtractZipByIonic(string zipPath, string destinationPath)
		{
			if (!Directory.Exists(destinationPath))
			{
				Directory.CreateDirectory(destinationPath);
			}
			using (ZipFile zipFile = new ZipFile(zipPath))
			{
				zipFile.ExtractAll(destinationPath);
			}
		}

		// Token: 0x02000047 RID: 71
		public enum DownloadResult
		{
			// Token: 0x04000452 RID: 1106
			Download_Failed_Latest_File_Is_Not_Exist_In_Server,
			// Token: 0x04000453 RID: 1107
			Download_Failed_Server_Is_Not_Responding,
			// Token: 0x04000454 RID: 1108
			Download_Failed_UnKnown_Error,
			// Token: 0x04000455 RID: 1109
			Download_OK
		}
	}
}
