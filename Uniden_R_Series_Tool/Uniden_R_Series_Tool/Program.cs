using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200001F RID: 31
	internal static class Program
	{
		// Token: 0x06000178 RID: 376 RVA: 0x0001A314 File Offset: 0x00018514
		[STAThread]
		private static void Main()
		{
			if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName.ToUpper()).Length > 1)
			{
				MessageBox.Show("This program is already running.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoadingForm());
			Application.Run(new MainForm());
		}
	}
}
