using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200000D RID: 13
	public partial class UpdateCheckForm : Form
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00007A60 File Offset: 0x00005C60
		public UpdateCheckForm(RDInfo modelInfo, FWFileInfo fileInfo, bool versionCheck, bool isDarkMode)
		{
			this.InitializeComponent();
			this.modelInfo = modelInfo;
			this.fileInfo = fileInfo;
			this.isDarkMode = isDarkMode;
			if (isDarkMode)
			{
				this.SetDarkMode();
			}
			string text = "";
			text += ((modelInfo.versionUI == -1) ? "___" : modelInfo.versionUI.ToString());
			text += ((modelInfo.versionDSP == -1) ? ". ___" : (". " + modelInfo.versionDSP.ToString()));
			if (modelInfo.modelName != ModelName.R1)
			{
				text += ((modelInfo.versionGPS == -1) ? ". ___" : (". " + modelInfo.versionGPS.ToString()));
				text += ((modelInfo.versionGPSDB == -1) ? ". _______" : string.Concat(new string[]
				{
					". ",
					modelInfo.versionGPSDB.ToString().Substring(0, 4),
					"/",
					modelInfo.versionGPSDB.ToString().Substring(4, 2),
					"/",
					modelInfo.versionGPSDB.ToString().Substring(6, 2)
				}));
			}
			text += ((modelInfo.versionSoundDB == -1) ? ". ___" : (". " + modelInfo.versionSoundDB.ToString()));
			if (modelInfo.supportBT || modelInfo.supportWIFI)
			{
				text += ((modelInfo.versionBLE == -1) ? ". ___" : (". " + modelInfo.versionBLE.ToString()));
			}
			string text2 = "";
			text2 += ((fileInfo.uiNuFileVersion == -1) ? "___" : fileInfo.uiNuFileVersion.ToString());
			text2 += ((fileInfo.dspNuFileVersion == -1) ? ". ___" : (". " + fileInfo.dspNuFileVersion.ToString()));
			if (modelInfo.modelName != ModelName.R1)
			{
				text2 += ((fileInfo.gpsNuFileVersion == -1) ? ". ___" : (". " + fileInfo.gpsNuFileVersion.ToString()));
				text2 += ((fileInfo.gpsDBFileVersion == -1) ? ". _______" : string.Concat(new string[]
				{
					". ",
					fileInfo.gpsDBFileVersion.ToString().Substring(0, 4),
					"/",
					fileInfo.gpsDBFileVersion.ToString().Substring(4, 2),
					"/",
					fileInfo.gpsDBFileVersion.ToString().Substring(6, 2)
				}));
			}
			if (fileInfo.soundDBNuFileVersion != -1)
			{
				text2 = text2 + ". " + fileInfo.soundDBNuFileVersion.ToString();
			}
			else if (fileInfo.soundDBLa1FileVersion != -1)
			{
				text2 = text2 + ". " + fileInfo.soundDBLa1FileVersion.ToString();
			}
			else if (fileInfo.soundDBLa2FileVersion != -1)
			{
				text2 = text2 + ". " + fileInfo.soundDBLa2FileVersion.ToString();
			}
			else
			{
				text2 += ". ___";
			}
			if (RDInfo.isSupportBT(fileInfo.modelName) || RDInfo.isSupportWIFI(fileInfo.modelName))
			{
				text2 += ((fileInfo.bleFileVersion == -1) ? ". ___" : (". " + fileInfo.bleFileVersion.ToString()));
			}
			this.ModelNameLabel.Text = RDInfo.GetModelNameStr(modelInfo.modelName);
			this.ConnectedModelVersionLabel.Text = text;
			this.FileVersionLabel.Text = text2;
			if (!versionCheck)
			{
				this.UpdateButton.Enabled = false;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007E00 File Offset: 0x00006000
		private void SetDarkMode()
		{
			this.UpTilePanel.BackColor = Color.Black;
			this.TitleLabel.ForeColor = SystemColors.ButtonFace;
			this.BackColor = Color.FromArgb(30, 30, 30);
			this.groupBox1.BackColor = Color.FromArgb(30, 30, 30);
			this.groupBox1.ForeColor = SystemColors.ButtonFace;
			this.label3.ForeColor = SystemColors.ButtonFace;
			this.AAConnectedVersionLabel.ForeColor = SystemColors.ButtonFace;
			this.label2.ForeColor = SystemColors.ButtonFace;
			this.const2Label.ForeColor = SystemColors.ButtonFace;
			this.ModelNameLabel.ForeColor = SystemColors.ButtonFace;
			this.ConnectedModelVersionLabel.ForeColor = SystemColors.ButtonFace;
			this.AAFileVersionLabel.ForeColor = SystemColors.ButtonFace;
			this.const3Label.ForeColor = SystemColors.ButtonFace;
			this.FileVersionLabel.ForeColor = SystemColors.ButtonFace;
			this.RecoveryModeCheckBox.ForeColor = SystemColors.ButtonFace;
			this.UpdateButton.FlatStyle = FlatStyle.Flat;
			this.CancelButton.FlatStyle = FlatStyle.Flat;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007F1C File Offset: 0x0000611C
		private void UpdateCheckForm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007F1E File Offset: 0x0000611E
		private void UpdateButton_Click(object sender, EventArgs e)
		{
			if (this.RecoveryModeCheckBox.Checked)
			{
				base.DialogResult = DialogResult.Yes;
			}
			else
			{
				base.DialogResult = DialogResult.OK;
			}
			base.Close();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002247 File Offset: 0x00000447
		private void CancelButton_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00007F44 File Offset: 0x00006144
		private void RecoveryModeCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.RecoveryModeCheckBox.Checked)
			{
				if (this.ConnectedModelVersionLabel.Text.Equals(this.FileVersionLabel.Text))
				{
					this.UpdateButton.Enabled = true;
					return;
				}
			}
			else if (this.ConnectedModelVersionLabel.Text.Equals(this.FileVersionLabel.Text))
			{
				this.UpdateButton.Enabled = false;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00007FB4 File Offset: 0x000061B4
		private void FormMouseDown(object sender, MouseEventArgs e)
		{
			this.TagMove = true;
			this.MValX = e.X;
			this.MValY = e.Y;
			if (sender.Equals(this.TitleLabel))
			{
				this.MValX += 4;
				this.MValY += 6;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000800C File Offset: 0x0000620C
		private void FormMouseMove(object sender, MouseEventArgs e)
		{
			if (this.TagMove)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.MValX, Control.MousePosition.Y - this.MValY);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000804F File Offset: 0x0000624F
		private void FormMouseUp(object sender, MouseEventArgs e)
		{
			this.TagMove = false;
		}

		// Token: 0x04000076 RID: 118
		private RDInfo modelInfo;

		// Token: 0x04000077 RID: 119
		private FWFileInfo fileInfo;

		// Token: 0x04000078 RID: 120
		private bool isDarkMode;

		// Token: 0x04000079 RID: 121
		private bool TagMove;

		// Token: 0x0400007A RID: 122
		private int MValX;

		// Token: 0x0400007B RID: 123
		private int MValY;

		// Token: 0x02000035 RID: 53
		public enum Result
		{
			// Token: 0x040003EF RID: 1007
			Cancel = 2,
			// Token: 0x040003F0 RID: 1008
			Update = 1,
			// Token: 0x040003F1 RID: 1009
			RecoveryUpdate = 6
		}
	}
}
