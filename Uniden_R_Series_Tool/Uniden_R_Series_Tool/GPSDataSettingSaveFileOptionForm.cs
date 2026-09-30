using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000009 RID: 9
	public partial class GPSDataSettingSaveFileOptionForm : Form
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00006E1B File Offset: 0x0000501B
		public GPSDataSettingSaveFileOptionForm(bool darkMode)
		{
			this.InitializeComponent();
			this.isDarkMode = darkMode;
			if (darkMode)
			{
				this.SetDarkMode();
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006E3C File Offset: 0x0000503C
		private void SetDarkMode()
		{
			this.UpTilePanel.BackColor = Color.Black;
			this.UpCloseButton.BackColor = Color.Black;
			this.UpCloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
			this.TitleLabel.ForeColor = SystemColors.ButtonFace;
			this.UpCloseButton.ForeColor = SystemColors.ButtonFace;
			this.MainPanel.BackColor = Color.FromArgb(30, 30, 30);
			this.UserMarkCheckBox.ForeColor = SystemColors.ButtonFace;
			this.MuteMemoryCheckBox.ForeColor = SystemColors.ButtonFace;
			this.addButton.FlatStyle = FlatStyle.Flat;
			this.cancelButton.FlatStyle = FlatStyle.Flat;
			this.addButton.ForeColor = SystemColors.ButtonFace;
			this.cancelButton.ForeColor = SystemColors.ButtonFace;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002247 File Offset: 0x00000447
		private void cancelButton_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006F14 File Offset: 0x00005114
		private void FormMouseDown(object sender, MouseEventArgs e)
		{
			this.TagMove = true;
			this.MValX = e.X;
			this.MValY = e.Y;
			if (sender.Equals(this.TitleLabel))
			{
				this.MValX += 25;
				this.MValY += 8;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006F6B File Offset: 0x0000516B
		private void okayButton_Click(object sender, EventArgs e)
		{
			this.userMarkSave = this.UserMarkCheckBox.Checked;
			this.muteMemorySave = this.MuteMemoryCheckBox.Checked;
			base.DialogResult = DialogResult.Yes;
			base.Close();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006F9C File Offset: 0x0000519C
		private void FormMouseMove(object sender, MouseEventArgs e)
		{
			if (this.TagMove)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.MValX, Control.MousePosition.Y - this.MValY);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006FDF File Offset: 0x000051DF
		private void FormMouseUp(object sender, MouseEventArgs e)
		{
			this.TagMove = false;
		}

		// Token: 0x04000058 RID: 88
		private bool TagMove;

		// Token: 0x04000059 RID: 89
		private int MValX;

		// Token: 0x0400005A RID: 90
		private int MValY;

		// Token: 0x0400005B RID: 91
		private bool isDarkMode;

		// Token: 0x0400005C RID: 92
		public bool userMarkSave;

		// Token: 0x0400005D RID: 93
		public bool muteMemorySave;
	}
}
