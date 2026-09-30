using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000002 RID: 2
	public partial class GPSDataSettingAddMuteMemForm : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public GPSDataSettingAddMuteMemForm(bool darkMode)
		{
			this.InitializeComponent();
			this.isDarkMode = darkMode;
			if (darkMode)
			{
				this.SetDarkMode();
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002070 File Offset: 0x00000270
		private void SetDarkMode()
		{
			this.UpTilePanel.BackColor = Color.Black;
			this.UpCloseButton.BackColor = Color.Black;
			this.UpCloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
			this.TitleLabel.ForeColor = SystemColors.ButtonFace;
			this.UpCloseButton.ForeColor = SystemColors.ButtonFace;
			this.MainPanel.BackColor = Color.FromArgb(30, 30, 30);
			this.bandLabel.ForeColor = SystemColors.ButtonFace;
			this.freqLabel.ForeColor = SystemColors.ButtonFace;
			this.ghzLabel.ForeColor = SystemColors.ButtonFace;
			this.bandComboBox.ForeColor = SystemColors.ButtonFace;
			this.freqTextBox.ForeColor = SystemColors.ButtonFace;
			this.bandComboBox.BackColor = Color.FromArgb(20, 20, 20);
			this.freqTextBox.BackColor = Color.FromArgb(20, 20, 20);
			this.addButton.FlatStyle = FlatStyle.Flat;
			this.cancelButton.FlatStyle = FlatStyle.Flat;
			this.addButton.ForeColor = SystemColors.ButtonFace;
			this.cancelButton.ForeColor = SystemColors.ButtonFace;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021A4 File Offset: 0x000003A4
		private void addButton_Click(object sender, EventArgs e)
		{
			double num;
			if (!double.TryParse(this.freqTextBox.Text.ToString(), out num))
			{
				SafetyControl.MessageBoxShowSync(this, "Invalid value of frequency.\r\n(valid value : 0 ~ 65.535)");
				return;
			}
			if (num < 0.0 || num > 65.535)
			{
				SafetyControl.MessageBoxShowSync(this, "Invalid value of frequency.\r\n(valid value : 0 ~ 65.535)");
				return;
			}
			this.freq = (int)(num * 1000.0);
			if (this.bandComboBox.SelectedItem.ToString().Equals("MRCD"))
			{
				this.freq += 500;
			}
			base.DialogResult = DialogResult.Yes;
			base.Close();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002247 File Offset: 0x00000447
		private void cancelButton_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002258 File Offset: 0x00000458
		public void FormMouseDown(object sender, MouseEventArgs e)
		{
			this.TagMove = true;
			this.MValX = e.X;
			this.MValY = e.Y + 1;
			if (sender.Equals(this.TitleLabel))
			{
				this.MValX += 25;
				this.MValY += 7;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022B4 File Offset: 0x000004B4
		private void FormMouseMove(object sender, MouseEventArgs e)
		{
			if (this.TagMove)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.MValX, Control.MousePosition.Y - this.MValY);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022F7 File Offset: 0x000004F7
		private void FormMouseUp(object sender, MouseEventArgs e)
		{
			this.TagMove = false;
		}

		// Token: 0x04000001 RID: 1
		public int freq;

		// Token: 0x04000002 RID: 2
		private bool TagMove;

		// Token: 0x04000003 RID: 3
		private int MValX;

		// Token: 0x04000004 RID: 4
		private int MValY;

		// Token: 0x04000005 RID: 5
		private bool isDarkMode;
	}
}
