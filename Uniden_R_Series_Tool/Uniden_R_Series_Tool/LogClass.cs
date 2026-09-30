using System;
using System.IO;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200001B RID: 27
	public static class LogClass
	{
		// Token: 0x06000166 RID: 358 RVA: 0x000190C0 File Offset: 0x000172C0
		public static void InitLogFile()
		{
			if (LogClass.logEnable)
			{
				LogClass.logFile = MainForm.downloadFilePath + "\\Dload_Log_" + DateTime.Now.ToString("yyyyMMdd_HH.mm.ss") + ".txt";
				new FileStream(LogClass.logFile, FileMode.Create).Close();
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00019110 File Offset: 0x00017310
		public static void WriteLog(string s)
		{
			if (LogClass.logEnable)
			{
				try
				{
					StreamWriter streamWriter = File.AppendText(LogClass.logFile);
					streamWriter.Write(string.Concat(new string[]
					{
						"[",
						DateTime.Now.ToString("yyyy-MM-dd, HH:mm:ss.fff"),
						"]\t",
						s,
						"\r\n"
					}));
					streamWriter.Close();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x04000208 RID: 520
		private static string logFile;

		// Token: 0x04000209 RID: 521
		public static bool logEnable;
	}
}
