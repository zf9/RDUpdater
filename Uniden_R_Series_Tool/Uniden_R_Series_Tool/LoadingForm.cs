using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Uniden_R_Series_Tool.Properties;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200001E RID: 30
	public partial class LoadingForm : Form
	{
		// Token: 0x06000170 RID: 368 RVA: 0x0001A074 File Offset: 0x00018274
		public LoadingForm()
		{
			this.InitializeComponent();
			base.Shown += this.LoadingForm_Activated;
			LoadingForm.waitTimer = new Timer();
			LoadingForm.waitTimer.Interval = 2000;
			LoadingForm.waitTimer.Tick += this.OnTimedEvent;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001A0CE File Offset: 0x000182CE
		private void LoadingForm_Load(object sender, EventArgs e)
		{
			LoadingForm.waitTimer.Enabled = true;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0001A0DC File Offset: 0x000182DC
		private void setOpacitySafe(Form form, double percent)
		{
			if (form.InvokeRequired)
			{
				form.Invoke(new MethodInvoker(delegate()
				{
					form.Opacity = percent;
				}));
				return;
			}
			form.Opacity = percent;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005237 File Offset: 0x00003437
		private void OnTimedEvent(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00007F1C File Offset: 0x0000611C
		private void LoadingForm_Activated(object sender, EventArgs e)
		{
		}

		// Token: 0x0400030C RID: 780
		private static Timer waitTimer;

		// Token: 0x0400030D RID: 781
		public static string downloadFilePath = "C:\\Uniden R Series Update Files";
	}
}
