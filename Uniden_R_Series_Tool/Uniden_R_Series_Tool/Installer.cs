using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200000F RID: 15
	[RunInstaller(true)]
	// DECOMPILE-FIX: Qualify the framework base type; the exported short name resolves to this class.
	public class Installer : System.Configuration.Install.Installer
	{
		// Token: 0x06000090 RID: 144 RVA: 0x0000A728 File Offset: 0x00008928
		public Installer()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000A758 File Offset: 0x00008958
		private Installer.OSVersion getOSVersion()
		{
			Installer.OSVersion result = Installer.OSVersion.UNKNOWN;
			RegistryKey registryKey = Registry.LocalMachine;
			registryKey = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
			if (registryKey != null)
			{
				string text = (string)registryKey.GetValue("CurrentVersion");
				uint num = DecompileStringHash.ComputeStringHash(text);
				if (num <= 3236114161U)
				{
					if (num != 3185781304U)
					{
						if (num != 3219336542U)
						{
							if (num == 3236114161U)
							{
								if (text == "5.1")
								{
									result = Installer.OSVersion.WINDOWS_XP;
								}
							}
						}
						else if (text == "5.0")
						{
							result = Installer.OSVersion.WINDOWS_2000;
						}
					}
					else if (text == "5.2")
					{
						result = Installer.OSVersion.WINDOWS_2003;
					}
				}
				else if (num <= 4235161167U)
				{
					if (num != 4218383548U)
					{
						if (num == 4235161167U)
						{
							if (text == "6.0")
							{
								result = Installer.OSVersion.WINDOWS_VISTA;
							}
						}
					}
					else if (text == "6.1")
					{
						result = Installer.OSVersion.WINDOWS_7;
					}
				}
				else if (num != 4251938786U)
				{
					if (num == 4268716405U)
					{
						if (text == "6.2")
						{
							result = Installer.OSVersion.WINDOWS_8;
						}
					}
				}
				else if (text == "6.3")
				{
					object value = registryKey.GetValue("CurrentMajorVersionNumber");
					object value2 = registryKey.GetValue("CurrentMinorVersionNumber");
					if (value != null && (int)value == 10 && value2 != null && (int)value2 == 0)
					{
						result = Installer.OSVersion.WINDOWS_10;
					}
					else
					{
						result = Installer.OSVersion.WINDOWS_8_1;
					}
				}
			}
			return result;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		private void USBDriverInstall()
		{
			try
			{
				Installer.OSVersion osversion = this.getOSVersion();
				string text;
				if (osversion == Installer.OSVersion.WINDOWS_7 || osversion == Installer.OSVersion.WINDOWS_8 || osversion == Installer.OSVersion.WINDOWS_8_1)
				{
					text = this.srcFilePath + "\\CP210x_VCP_Windows7,8,8.1";
				}
				else
				{
					if (osversion != Installer.OSVersion.WINDOWS_10)
					{
						return;
					}
					text = this.srcFilePath + "\\CP210x_VCP_Windows10";
				}
				if ((Environment.Is64BitOperatingSystem ? 64 : 32) == 64)
				{
					text += "\\CP210xVCPInstaller_x64.exe";
				}
				else
				{
					text += "\\CP210xVCPInstaller_x86.exe";
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				process.StartInfo.UseShellExecute = false;
				process.EnableRaisingEvents = true;
				process.Start();
				while (!process.HasExited)
				{
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000A984 File Offset: 0x00008B84
		private void CreatDownloadFileDirectory()
		{
			if (!Directory.Exists(this.downloadFilePath))
			{
				Directory.CreateDirectory(this.downloadFilePath);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000A9A0 File Offset: 0x00008BA0
		private void CopyFolder(string sourceFolder, string destFolder)
		{
			if (Directory.Exists(destFolder))
			{
				Directory.Delete(destFolder, true);
			}
			Directory.CreateDirectory(destFolder);
			string[] files = Directory.GetFiles(sourceFolder);
			string[] directories = Directory.GetDirectories(sourceFolder);
			foreach (string text in files)
			{
				string fileName = Path.GetFileName(text);
				string destFileName = Path.Combine(destFolder, fileName);
				File.Copy(text, destFileName);
			}
			foreach (string text2 in directories)
			{
				string fileName2 = Path.GetFileName(text2);
				string destFolder2 = Path.Combine(destFolder, fileName2);
				this.CopyFolder(text2, destFolder2);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000AA2B File Offset: 0x00008C2B
		protected override void OnAfterInstall(IDictionary savedState)
		{
			this.CreatDownloadFileDirectory();
			this.USBDriverInstall();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000AA3C File Offset: 0x00008C3C
		protected override void OnBeforeUninstall(IDictionary savedState)
		{
			try
			{
				if (Directory.Exists(this.downloadFilePath))
				{
					new DirectoryInfo(this.downloadFilePath).Delete(true);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000AA7C File Offset: 0x00008C7C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000AA9B File Offset: 0x00008C9B
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x040000AC RID: 172
		private const int WINDOW32 = 32;

		// Token: 0x040000AD RID: 173
		private const int WINDOW64 = 64;

		// Token: 0x040000AE RID: 174
		private string downloadFilePath = "C:\\Uniden R Series Update Files";

		// Token: 0x040000AF RID: 175
		private string srcFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Uniden America\\Uniden R Series Tool";

		// Token: 0x040000B0 RID: 176
		private IContainer components;

		// Token: 0x02000037 RID: 55
		private enum OSVersion
		{
			// Token: 0x040003F7 RID: 1015
			WINDOWS_95,
			// Token: 0x040003F8 RID: 1016
			WINDOWS_98,
			// Token: 0x040003F9 RID: 1017
			WINDOWS_98_SE,
			// Token: 0x040003FA RID: 1018
			WINDOWS_ME,
			// Token: 0x040003FB RID: 1019
			WINDOWS_NT_3_51,
			// Token: 0x040003FC RID: 1020
			WINDOWS_NT_4_0,
			// Token: 0x040003FD RID: 1021
			WINDOWS_2000,
			// Token: 0x040003FE RID: 1022
			WINDOWS_XP,
			// Token: 0x040003FF RID: 1023
			WINDOWS_2003,
			// Token: 0x04000400 RID: 1024
			WINDOWS_VISTA,
			// Token: 0x04000401 RID: 1025
			WINDOWS_7,
			// Token: 0x04000402 RID: 1026
			WINDOWS_8,
			// Token: 0x04000403 RID: 1027
			WINDOWS_8_1,
			// Token: 0x04000404 RID: 1028
			WINDOWS_10,
			// Token: 0x04000405 RID: 1029
			UNKNOWN
		}
	}
}
