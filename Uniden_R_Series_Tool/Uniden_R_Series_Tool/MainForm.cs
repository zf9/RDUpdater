using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Win32;
using Uniden_R_Series_Tool.Properties;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000011 RID: 17
	public partial class MainForm : Form
	{
		// Token: 0x06000099 RID: 153
		[DllImport("gdi32.dll")]
		private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

		// Token: 0x0600009A RID: 154 RVA: 0x0000AAA8 File Offset: 0x00008CA8
		public MainForm()
		{
			this.InitializeComponent();
			base.FormClosing += this.MainForm_Closing;
			this.SetDownloadingFromURLTimer();
			this.SetSize();
			this.FormInitUS();
			this.autoConnectThread = new Thread(new ThreadStart(this.AutoConnect));
			this.connectionCheckThread = new Thread(new ThreadStart(this.ConnectionCheck));
			try
			{
				this.SetOption(MainForm.downloadFilePath);
				this.SetOpenFilePath();
			}
			catch
			{
				MainForm.CreateDirectoryAndInitFile();
				this.SetOption(MainForm.downloadFilePath);
				this.SetOpenFilePath();
			}
			this.currentMenu = MainForm.MenuStatus.UPDATE;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000ABAC File Offset: 0x00008DAC
		private float getScalingFactor()
		{
			return (float)int.Parse((string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ThemeManager", "LastLoadedDPI", "96")) / 96f;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		private void SetSize()
		{
			float num = 1f;
			this.MinimumSize = new Size((int)(621f * num), (int)(451f * num));
			this.MaximumSize = new Size((int)(621f * num), (int)(451f * num));
			base.Size = new Size((int)(621f * num), (int)(451f * num));
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000AC38 File Offset: 0x00008E38
		private void FormInitUS()
		{
			this.GPSDataSettingButton.Visible = false;
			this.firmwareFileOpenDialog.Filter = "bin files(*.bin) | *.bin";
			this.Text = string.Concat(new object[]
			{
				this.toolName,
				" v",
				this.toolVersion / 100,
				".",
				(this.toolVersion % 100).ToString().PadLeft(2, '0')
			});
			this.ToolVersionLabel.Text = string.Concat(new object[]
			{
				"v",
				this.toolVersion / 100,
				".",
				(this.toolVersion % 100).ToString().PadLeft(2, '0')
			});
			this.TitleLabel.Text = this.Text;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000AD1C File Offset: 0x00008F1C
		private void FormInitNZ()
		{
			this.DownloadFilesButton_Click(null, null);
			this.DownloadFilesButton.Location = new Point(this.DownloadFilesButton.Location.X, this.DownloadFilesButton.Location.Y - 40);
			this.MenuStatusDloadFiles.Location = new Point(this.MenuStatusDloadFiles.Location.X, this.MenuStatusDloadFiles.Location.Y - 40);
			this.OptionButton.Location = new Point(this.OptionButton.Location.X, this.OptionButton.Location.Y - 80);
			this.MenuStatusOption.Location = new Point(this.MenuStatusOption.Location.X, this.MenuStatusOption.Location.Y - 80);
			this.UpdatesButton.Location = new Point(this.UpdatesButton.Location.X, this.UpdatesButton.Location.Y - 80);
			this.MenuStatusUpdates.Location = new Point(this.MenuStatusUpdates.Location.X, this.MenuStatusUpdates.Location.Y - 80);
			this.UpdateButton.Visible = false;
			this.MenuStatusUpdate.Visible = false;
			this.UserSettingButton.Visible = false;
			this.GPSDataSettingButton.Visible = false;
			this.firmwareFileOpenDialog.Filter = "bin files(*.bin) | *.bin";
			this.Text = string.Concat(new object[]
			{
				this.toolName,
				" v",
				this.toolVersion / 100,
				".",
				(this.toolVersion % 100).ToString().PadLeft(2, '0'),
				" NZ"
			});
			this.ToolVersionLabel.Text = string.Concat(new object[]
			{
				"v",
				this.toolVersion / 100,
				".",
				(this.toolVersion % 100).ToString().PadLeft(2, '0')
			});
			this.TitleLabel.Text = this.Text;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000AF18 File Offset: 0x00009118
		private void SetDarkMode(bool isDarkMode)
		{
			if (isDarkMode)
			{
				this.UpTilePanel.BackColor = Color.FromArgb(0, 0, 0);
				this.LeftMenuPanel.BackColor = Color.FromArgb(0, 0, 0);
				this.LogoPictureBox.Image = Resources.uniden_logo2;
				this.UpTilePanel.ForeColor = SystemColors.ButtonFace;
				this.LeftMenuPanel.ForeColor = SystemColors.ButtonFace;
				this.UpdateButton.ForeColor = SystemColors.ButtonFace;
				this.DownloadFilesButton.ForeColor = SystemColors.ButtonFace;
				this.UserSettingButton.ForeColor = SystemColors.ButtonFace;
				this.GPSDataSettingButton.ForeColor = SystemColors.ButtonFace;
				this.OptionButton.ForeColor = SystemColors.ButtonFace;
				this.UpdatesButton.ForeColor = SystemColors.ButtonFace;
				this.UpdatesTab.BackColor = Color.FromArgb(30, 30, 30);
				this.ApplyUpdatesTheme(true);
				this.CloseButton.ForeColor = SystemColors.ButtonFace;
				this.UpdatePanel.BackColor = Color.FromArgb(30, 30, 30);
				this.label1.BackColor = Color.FromArgb(150, 150, 150);
				this.constLabel1.ForeColor = SystemColors.ButtonFace;
				this.label2.ForeColor = SystemColors.ButtonFace;
				this.constLabel10.ForeColor = SystemColors.ButtonFace;
				this.constLabel11.ForeColor = SystemColors.ButtonFace;
				this.MainVersionLabel.ForeColor = SystemColors.ButtonFace;
				this.ModelNameLabel.ForeColor = SystemColors.ButtonFace;
				this.LatestVersionLabel.ForeColor = SystemColors.ButtonFace;
				this.LatestColonLable.ForeColor = SystemColors.ButtonFace;
				this.MainFileVersionLabel.ForeColor = SystemColors.ButtonFace;
				this.ReadVersionSTSLabel1.ForeColor = SystemColors.ButtonFace;
				this.ReadVersionSTSLabel2.ForeColor = SystemColors.ButtonFace;
				this.DownloadFilesPanel.BackColor = Color.FromArgb(30, 30, 30);
				this.groupBox1.BackColor = Color.FromArgb(30, 30, 30);
				this.groupBox1.ForeColor = SystemColors.ButtonFace;
				this.groupBox2.BackColor = Color.FromArgb(30, 30, 30);
				this.groupBox2.ForeColor = SystemColors.ButtonFace;
				this.FilePathRichTextBox.BackColor = Color.FromArgb(30, 30, 30);
				this.FilePathRichTextBox.ForeColor = SystemColors.ButtonFace;
				this.DetailConnectedModelLabel.ForeColor = SystemColors.ButtonFace;
				this.label3.ForeColor = SystemColors.ButtonFace;
				this.ConnectedVersionLabel.ForeColor = SystemColors.ButtonFace;
				this.DetailFileModelLabel.ForeColor = SystemColors.ButtonFace;
				this.label4.ForeColor = SystemColors.ButtonFace;
				this.FWFileVersionLabel.ForeColor = SystemColors.ButtonFace;
				this.RecoveryMode.ForeColor = SystemColors.ButtonFace;
				this.OptionPenal.BackColor = Color.FromArgb(30, 30, 30);
				this.DarkModeCheckBox.ForeColor = SystemColors.ButtonFace;
				this.AutoConnectEnableCheckBox.ForeColor = Color.White;
				this.ToolVersionLabel.ForeColor = SystemColors.ButtonFace;
				this.UpdateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				this.DownloadFilesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				this.UserSettingButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				this.GPSDataSettingButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				this.OptionButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				this.UpdatesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				this.MenuStatusUpdates.BackColor = this.currentMenu == MainForm.MenuStatus.UPDATES ? Color.FromArgb(90, 90, 90) : Color.Black;
				this.CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				this.MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				this.UpCloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				switch (this.currentMenu)
				{
				case MainForm.MenuStatus.UPDATE:
					this.MenuStatusUpdate.BackColor = Color.FromArgb(90, 90, 90);
					this.MenuStatusDloadFiles.BackColor = Color.Black;
					this.MenuStatusOption.BackColor = Color.Black;
					break;
				case MainForm.MenuStatus.DOWNLOAD_FILES:
					this.MenuStatusUpdate.BackColor = Color.Black;
					this.MenuStatusDloadFiles.BackColor = Color.FromArgb(90, 90, 90);
					this.MenuStatusOption.BackColor = Color.Black;
					break;
				case MainForm.MenuStatus.OPTION:
					this.MenuStatusUpdate.BackColor = Color.Black;
					this.MenuStatusDloadFiles.BackColor = Color.Black;
					this.MenuStatusOption.BackColor = Color.FromArgb(90, 90, 90);
					break;
				case MainForm.MenuStatus.UPDATES:
					this.MenuStatusUpdate.BackColor = Color.Black;
					this.MenuStatusDloadFiles.BackColor = Color.Black;
					this.MenuStatusOption.BackColor = Color.Black;
					break;
				}
				this.SimpleStartUpdateButton.FlatStyle = FlatStyle.Flat;
				this.ReadVersionButton.FlatStyle = FlatStyle.Flat;
				this.FileOpenButton.FlatStyle = FlatStyle.Flat;
				this.DetailStartUpdateButton.FlatStyle = FlatStyle.Flat;
				return;
			}
			this.UpTilePanel.BackColor = Color.FromArgb(234, 235, 235);
			this.LeftMenuPanel.BackColor = Color.FromArgb(234, 235, 235);
			this.LogoPictureBox.Image = Resources.uniden_logo1;
			this.UpTilePanel.ForeColor = Color.Black;
			this.LeftMenuPanel.ForeColor = Color.Black;
			this.UpdateButton.ForeColor = Color.Black;
			this.DownloadFilesButton.ForeColor = Color.Black;
			this.UserSettingButton.ForeColor = Color.Black;
			this.GPSDataSettingButton.ForeColor = Color.Black;
			this.OptionButton.ForeColor = Color.Black;
			this.UpdatesButton.ForeColor = Color.Black;
			this.UpdatesTab.BackColor = Color.White;
			this.ApplyUpdatesTheme(false);
			this.CloseButton.ForeColor = Color.Black;
			this.UpdatePanel.BackColor = Color.White;
			this.label1.BackColor = Color.Black;
			this.constLabel1.ForeColor = Color.Black;
			this.label2.ForeColor = Color.Black;
			this.constLabel10.ForeColor = Color.Black;
			this.constLabel11.ForeColor = Color.Black;
			this.MainVersionLabel.ForeColor = Color.Black;
			this.ModelNameLabel.ForeColor = Color.Black;
			this.LatestVersionLabel.ForeColor = Color.Black;
			this.LatestColonLable.ForeColor = Color.Black;
			this.MainFileVersionLabel.ForeColor = Color.Black;
			this.ReadVersionSTSLabel1.ForeColor = Color.Black;
			this.ReadVersionSTSLabel2.ForeColor = Color.Black;
			this.DownloadFilesPanel.BackColor = Color.White;
			this.groupBox1.BackColor = Color.White;
			this.groupBox1.ForeColor = Color.Black;
			this.groupBox2.BackColor = Color.White;
			this.groupBox2.ForeColor = Color.Black;
			this.FilePathRichTextBox.BackColor = Color.White;
			this.FilePathRichTextBox.ForeColor = Color.Black;
			this.DetailConnectedModelLabel.ForeColor = Color.Black;
			this.label3.ForeColor = Color.Black;
			this.ConnectedVersionLabel.ForeColor = Color.Black;
			this.DetailFileModelLabel.ForeColor = Color.Black;
			this.label4.ForeColor = Color.Black;
			this.FWFileVersionLabel.ForeColor = Color.Black;
			this.RecoveryMode.ForeColor = Color.Black;
			this.OptionPenal.BackColor = Color.White;
			this.DarkModeCheckBox.ForeColor = Color.Black;
			this.AutoConnectEnableCheckBox.ForeColor = Color.Black;
			this.ToolVersionLabel.ForeColor = Color.Black;
			this.UpdateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
			this.DownloadFilesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
			this.UserSettingButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
			this.GPSDataSettingButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
			this.OptionButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
			this.UpdatesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
			this.MenuStatusUpdates.BackColor = this.currentMenu == MainForm.MenuStatus.UPDATES ? Color.FromArgb(195, 195, 195) : Color.FromArgb(234, 235, 235);
			this.CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
			this.MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
			this.UpCloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 195, 195);
			switch (this.currentMenu)
			{
			case MainForm.MenuStatus.UPDATE:
				this.MenuStatusUpdate.BackColor = Color.FromArgb(195, 195, 195);
				this.MenuStatusDloadFiles.BackColor = Color.FromArgb(234, 235, 235);
				this.MenuStatusOption.BackColor = Color.FromArgb(234, 235, 235);
				break;
			case MainForm.MenuStatus.DOWNLOAD_FILES:
				this.MenuStatusUpdate.BackColor = Color.FromArgb(234, 235, 235);
				this.MenuStatusDloadFiles.BackColor = Color.FromArgb(195, 195, 195);
				this.MenuStatusOption.BackColor = Color.FromArgb(234, 235, 235);
				break;
			case MainForm.MenuStatus.OPTION:
				this.MenuStatusUpdate.BackColor = Color.FromArgb(234, 235, 235);
				this.MenuStatusDloadFiles.BackColor = Color.FromArgb(234, 235, 235);
				this.MenuStatusOption.BackColor = Color.FromArgb(195, 195, 195);
				break;
			case MainForm.MenuStatus.UPDATES:
				this.MenuStatusUpdate.BackColor = Color.FromArgb(234, 235, 235);
				this.MenuStatusDloadFiles.BackColor = Color.FromArgb(234, 235, 235);
				this.MenuStatusOption.BackColor = Color.FromArgb(234, 235, 235);
				break;
			}
			this.SimpleStartUpdateButton.FlatStyle = FlatStyle.System;
			this.ReadVersionButton.FlatStyle = FlatStyle.System;
			this.FileOpenButton.FlatStyle = FlatStyle.System;
			this.DetailStartUpdateButton.FlatStyle = FlatStyle.System;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007F1C File Offset: 0x0000611C
		private void MainForm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000B91B File Offset: 0x00009B1B
		private void MainForm_Closing(object sender, FormClosingEventArgs e)
		{
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005237 File Offset: 0x00003437
		private void CloseButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005207 File Offset: 0x00003407
		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000B928 File Offset: 0x00009B28
		private async void UserSettingButton_Click(object sender, EventArgs e)
		{
			this.ActiveControl = this.TitleLabel;
			if (this.connectedModelInfo.isConnected)
			{
				RDInfo rdInfo = this.connectedModelInfo;
				if (rdInfo.modelName == ModelName.R3_PLUS)
				{
					rdInfo.SetModel(ModelName.R3);
				}
				if (rdInfo.modelName == ModelName.R3_NZK_PLUS)
				{
					rdInfo.SetModel(ModelName.R3_NZK);
				}
				int minSupportedVer = UserSettingConfig.GetMinSupportedVer(rdInfo.modelName);
				if (minSupportedVer != -1 && minSupportedVer <= this.connectedModelInfo.versionUI)
				{
					await this.StopAutoConnect();
					await this.StopConnectionCheck();
					new UserSettingForm(this.uart, rdInfo, this.DarkModeCheckBox.Checked).ShowDialog();
					this.StartConnectionCheck();
				}
				else
				{
					SafetyControl.MessageBoxShowSync(this, (minSupportedVer != -1) ? ("This feature is supported in v" + minSupportedVer.ToString() + "(UI) and later.") : ("This feature is not supported in " + RDInfo.GetModelNameStr(this.connectedModelInfo.modelName) + "."), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000B964 File Offset: 0x00009B64
		private async void GPSDataSettingButton_Click(object sender, EventArgs e)
		{
			this.ActiveControl = this.TitleLabel;
			if (this.connectedModelInfo.isConnected)
			{
				await this.StopAutoConnect();
				await this.StopConnectionCheck();
				new GPSDataSettingForm(this.uart, this.connectedModelInfo, this.DarkModeCheckBox.Checked).ShowDialog();
				this.StartConnectionCheck();
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		private void Update_Click(object sender, EventArgs e)
		{
			base.ActiveControl = this.TitleLabel;
			this.MenuTabPanel.SelectedTab = this.UpdateTab;
			this.MenuStatusUpdate.BringToFront();
			this.MenuStatusDloadFiles.SendToBack();
			this.MenuStatusOption.SendToBack();
			this.MenuStatusUpdates.SendToBack();
			this.MenuStatusUpdates.BackColor = this.DarkModeCheckBox.Checked ? Color.Black : Color.FromArgb(234, 235, 235);
			if (this.DarkModeCheckBox.Checked)
			{
				this.MenuStatusUpdate.BackColor = Color.FromArgb(90, 90, 90);
				this.MenuStatusDloadFiles.BackColor = Color.Black;
				this.MenuStatusOption.BackColor = Color.Black;
			}
			else
			{
				this.MenuStatusUpdate.BackColor = Color.FromArgb(195, 195, 195);
				this.MenuStatusDloadFiles.BackColor = Color.FromArgb(234, 235, 235);
				this.MenuStatusOption.BackColor = Color.FromArgb(234, 235, 235);
			}
			this.currentMenu = MainForm.MenuStatus.UPDATE;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000BA94 File Offset: 0x00009C94
		private void DownloadFilesButton_Click(object sender, EventArgs e)
		{
			base.ActiveControl = this.TitleLabel;
			this.MenuTabPanel.SelectedTab = this.DownloadFilesTab;
			this.MenuStatusDloadFiles.BringToFront();
			this.MenuStatusUpdate.SendToBack();
			this.MenuStatusOption.SendToBack();
			this.MenuStatusUpdates.SendToBack();
			this.MenuStatusUpdates.BackColor = this.DarkModeCheckBox.Checked ? Color.Black : Color.FromArgb(234, 235, 235);
			if (this.DarkModeCheckBox.Checked)
			{
				this.MenuStatusDloadFiles.BackColor = Color.FromArgb(90, 90, 90);
				this.MenuStatusUpdate.BackColor = Color.Black;
				this.MenuStatusOption.BackColor = Color.Black;
			}
			else
			{
				this.MenuStatusDloadFiles.BackColor = Color.FromArgb(195, 195, 195);
				this.MenuStatusUpdate.BackColor = Color.FromArgb(234, 235, 235);
				this.MenuStatusOption.BackColor = Color.FromArgb(234, 235, 235);
			}
			this.currentMenu = MainForm.MenuStatus.DOWNLOAD_FILES;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000BB88 File Offset: 0x00009D88
		private void OptionButton_Click(object sender, EventArgs e)
		{
			base.ActiveControl = this.TitleLabel;
			this.MenuTabPanel.SelectedTab = this.OptionTab;
			this.MenuStatusOption.BringToFront();
			this.MenuStatusUpdate.SendToBack();
			this.MenuStatusDloadFiles.SendToBack();
			this.MenuStatusUpdates.SendToBack();
			this.MenuStatusUpdates.BackColor = this.DarkModeCheckBox.Checked ? Color.Black : Color.FromArgb(234, 235, 235);
			if (this.DarkModeCheckBox.Checked)
			{
				this.MenuStatusOption.BackColor = Color.FromArgb(90, 90, 90);
				this.MenuStatusUpdate.BackColor = Color.Black;
				this.MenuStatusDloadFiles.BackColor = Color.Black;
			}
			else
			{
				this.MenuStatusOption.BackColor = Color.FromArgb(195, 195, 195);
				this.MenuStatusUpdate.BackColor = Color.FromArgb(234, 235, 235);
				this.MenuStatusDloadFiles.BackColor = Color.FromArgb(234, 235, 235);
			}
			this.currentMenu = MainForm.MenuStatus.OPTION;
		}

		private void UpdatesButton_Click(object sender, EventArgs e)
		{
			base.ActiveControl = this.TitleLabel;
			this.MenuTabPanel.SelectedTab = this.UpdatesTab;
			this.MenuStatusUpdates.BringToFront();
			this.MenuStatusUpdate.SendToBack();
			this.MenuStatusDloadFiles.SendToBack();
			this.MenuStatusOption.SendToBack();
			if (this.DarkModeCheckBox.Checked)
			{
				this.MenuStatusUpdates.BackColor = Color.FromArgb(90, 90, 90);
				this.MenuStatusUpdate.BackColor = Color.Black;
				this.MenuStatusDloadFiles.BackColor = Color.Black;
				this.MenuStatusOption.BackColor = Color.Black;
			}
			else
			{
				this.MenuStatusUpdates.BackColor = Color.FromArgb(195, 195, 195);
				this.MenuStatusUpdate.BackColor = Color.FromArgb(234, 235, 235);
				this.MenuStatusDloadFiles.BackColor = Color.FromArgb(234, 235, 235);
				this.MenuStatusOption.BackColor = Color.FromArgb(234, 235, 235);
			}
			this.currentMenu = MainForm.MenuStatus.UPDATES;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000BC7C File Offset: 0x00009E7C
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

		// Token: 0x060000AA RID: 170 RVA: 0x0000BCD4 File Offset: 0x00009ED4
		private void FormMouseMove(object sender, MouseEventArgs e)
		{
			if (this.TagMove)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.MValX, Control.MousePosition.Y - this.MValY);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000BD17 File Offset: 0x00009F17
		private void FormMouseUp(object sender, MouseEventArgs e)
		{
			this.TagMove = false;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000BD20 File Offset: 0x00009F20
		private void SetDownloadingFromURLTimer()
		{
			MainForm.downloadingFromURLTimer = new System.Timers.Timer();
			MainForm.downloadingFromURLTimer.AutoReset = true;
			MainForm.downloadingFromURLTimer.Interval = (double)FWDloadFormat.time500msec;
			MainForm.downloadingFromURLTimer.Elapsed += this.DownloadingTextTimerTick;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000BD60 File Offset: 0x00009F60
		private void FileOpenButton_Click(object sender, EventArgs e)
		{
			FWFileInfo fwfileInfo = new FWFileInfo();
			if (this.firmwareFileOpenDialog.ShowDialog() == DialogResult.OK)
			{
				fwfileInfo.filePath = this.firmwareFileOpenDialog.FileName;
				if (this.ReadFWFileInfoAndDisplay(fwfileInfo, true))
				{
					this.openFileInfo = fwfileInfo;
				}
				else
				{
					this.openFileInfo = new FWFileInfo();
					MessageBox.Show("Invalid file.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				this.firmwareFileOpenDialog.InitialDirectory = this.firmwareFileOpenDialog.FileName;
				string[] array = this.firmwareFileOpenDialog.FileName.Split(new char[]
				{
					'\\'
				});
				this.FilePathRichTextBox.Text = array[array.Length - 1];
				this.firmwareFileOpenDialog.FileName = "";
				this.WriteOpenFilePathInitFile(MainForm.downloadFilePath, this.firmwareFileOpenDialog.InitialDirectory);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000BE34 File Offset: 0x0000A034
		private async void SimpleStartUpdateButton_Click(object sender, EventArgs e)
		{
			this.ActiveControl = this.constLabel1;
			if (this.backgroundDownloadThread != null && this.backgroundDownloadThread.IsAlive)
			{
				MessageBox.Show("Please wait for downloading files via internet.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				if (MainForm.downloadingFromURLTimer.Enabled)
				{
					MainForm.downloadingFromURLTimer.Stop();
					SafetyControl.SetText(this.MainFileVersionLabel, "");
				}
				RDInfo modelInfo;
				if (this.connectedModelInfo.isConnected)
				{
					modelInfo = this.connectedModelInfo;
				}
				else
				{
					modelInfo = new RDInfo();
				}
				await this.StopAutoConnect();
				await this.StopConnectionCheck();
				this.CheckLogOptionFormInitFile();
				new UpdateForm(this, this.uart, modelInfo, this.latestFileInfo, false, this.DarkModeCheckBox.Checked).ShowDialog();
				if (this.connectedModelInfo.isConnected)
				{
					this.StartConnectionCheck();
				}
				else
				{
					this.SetDisconnectedDisplay();
					if (this.AutoConnectEnableCheckBox.Checked)
					{
						this.StartAutoConnect();
					}
					else
					{
						this.ReadVersionButton_Click(null, null);
					}
				}
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000BE70 File Offset: 0x0000A070
		private async void DetailStartUpdateButton_Click(object sender, EventArgs e)
		{
			this.ActiveControl = this.constLabel1;
			if (this.openFileInfo.filePath.Equals(""))
			{
				MessageBox.Show("File does not exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				RDInfo modelInfo;
				if (this.connectedModelInfo.isConnected)
				{
					modelInfo = this.connectedModelInfo;
				}
				else
				{
					modelInfo = new RDInfo();
				}
				this.openFileInfo.recoveryModeFlag = this.RecoveryMode.Checked;
				await this.StopAutoConnect();
				await this.StopConnectionCheck();
				this.CheckLogOptionFormInitFile();
				new UpdateForm(this, this.uart, modelInfo, this.openFileInfo, true, this.DarkModeCheckBox.Checked).ShowDialog();
				if (this.connectedModelInfo.isConnected)
				{
					this.StartConnectionCheck();
				}
				else
				{
					this.SetDisconnectedDisplay();
					if (this.AutoConnectEnableCheckBox.Checked)
					{
						this.StartAutoConnect();
					}
					else
					{
						this.ReadVersionButton_Click(null, null);
					}
				}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000BEAC File Offset: 0x0000A0AC
		private async void ReadVersionButton_Click(object sender, EventArgs e)
		{
			await this.StopAutoConnect();
			await this.StopConnectionCheck();
			SafetyControl.SetText(this.DetailConnectedModelLabel, "");
			SafetyControl.SetText(this.ConnectedVersionLabel, "");
			this.SetAllButtonEnable(false);
			new UpdateForm(this, this.uart, this.connectedModelInfo).ShowDialog();
			if (this.connectedModelInfo.isConnected)
			{
				SafetyControl.SetFront(this.ReadVersionSTSLabel1, false);
				SafetyControl.SetText(this.ReadVersionSTSLabel1, "");
				if (this.latestFileInfo.filePath.Equals(""))
				{
					this.backgroundDownloadThread = new Thread(new ParameterizedThreadStart(this.BackgroundDownloadFromURL));
					this.backgroundDownloadThread.Start(this.connectedModelInfo);
				}
				this.StartConnectionCheck();
			}
			else
			{
				this.SetDisconnectedDisplay();
				SafetyControl.SetFront(this.ReadVersionSTSLabel1, true);
				SafetyControl.SetText(this.ReadVersionSTSLabel1, "Model not found !");
				if (this.DarkModeCheckBox.Checked)
				{
					SafetyControl.SetColor(this.ReadVersionSTSLabel2, SystemColors.ButtonFace);
				}
				else
				{
					SafetyControl.SetColor(this.ReadVersionSTSLabel2, Color.Black);
				}
				SafetyControl.SetText(this.ReadVersionSTSLabel2, "Model not found !");
				if (this.AutoConnectEnableCheckBox.Checked)
				{
					this.StartAutoConnect();
				}
			}
			this.SetAllButtonEnable(true);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
		private async void AutoConnectEnableCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.AutoConnectEnableCheckBox.Enabled = false;
			await this.StopAutoConnect();
			string writeValue;
			if (this.AutoConnectEnableCheckBox.Checked)
			{
				if (!this.connectedModelInfo.isConnected)
				{
					this.StartAutoConnect();
				}
				writeValue = "True";
			}
			else
			{
				writeValue = "False";
			}
			this.WriteOptionInitFile(MainForm.downloadFilePath, MainForm.OptionMenu.AUTO_CONNECT, writeValue);
			this.AutoConnectEnableCheckBox.Enabled = true;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000BF24 File Offset: 0x0000A124
		private void DarkModeCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			string writeValue;
			if (this.DarkModeCheckBox.Checked)
			{
				this.SetDarkMode(true);
				writeValue = "True";
			}
			else
			{
				this.SetDarkMode(false);
				writeValue = "False";
			}
			this.WriteOptionInitFile(MainForm.downloadFilePath, MainForm.OptionMenu.DARK_MODE, writeValue);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000BF67 File Offset: 0x0000A167
		private void StartAutoConnect()
		{
			this.autoConnectEndFlag = false;
			this.autoConnectThread = new Thread(new ThreadStart(this.AutoConnect));
			this.autoConnectThread.Start();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000BF94 File Offset: 0x0000A194
		private void StartConnectionCheck()
		{
			this.connectionCheckEndFlag = false;
			this.connectionCheckThread = new Thread(new ThreadStart(this.ConnectionCheck));
			this.connectionCheckThread.Start();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000BFC4 File Offset: 0x0000A1C4
		private async Task StopAutoConnect()
		{
			if (this.autoConnectThread != null && this.autoConnectThread.IsAlive)
			{
				await Task.Run(delegate()
				{
					this.autoConnectEndFlag = true;
				});
				if (!this.autoConnectThread.Join(FWDloadFormat.time5sec))
				{
					await Task.Run(delegate()
					{
						this.autoConnectThread.Join();
					});
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000C00C File Offset: 0x0000A20C
		private async Task StopConnectionCheck()
		{
			if (this.connectionCheckThread != null && this.connectionCheckThread.IsAlive)
			{
				await Task.Run(delegate()
				{
					this.connectionCheckEndFlag = true;
				});
				if (!this.connectionCheckThread.Join(FWDloadFormat.time5sec))
				{
					await Task.Run(delegate()
					{
						this.connectionCheckThread.Join();
					});
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000C054 File Offset: 0x0000A254
		private static bool CreateDirectoryAndInitFile()
		{
			string text = MainForm.downloadFilePath;
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			File.WriteAllText(text + "\\init.ini", "Option=False,True\nOpenPath=0," + MainForm.downloadFilePath + "\nLog=False");
			return true;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000C09C File Offset: 0x0000A29C
		public void SetOption(string filePath)
		{
			if (MainForm.ReadOptionFromInitFile(filePath, MainForm.OptionMenu.DARK_MODE).Equals("True"))
			{
				this.DarkModeCheckBox.Checked = true;
			}
			else
			{
				this.DarkModeCheckBox.Checked = false;
			}
			if (MainForm.ReadOptionFromInitFile(filePath, MainForm.OptionMenu.AUTO_CONNECT).Equals("True"))
			{
				this.AutoConnectEnableCheckBox.Checked = true;
				return;
			}
			this.AutoConnectEnableCheckBox.Checked = false;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000C104 File Offset: 0x0000A304
		private void SetOpenFilePath()
		{
			if (this.ReadOpenFileFirstTimeFlagInitFile(MainForm.downloadFilePath))
			{
				this.openFileInfo.filePath = this.ReadOpenFilePathFormInitFile(MainForm.downloadFilePath);
				string[] array = this.openFileInfo.filePath.Split(new char[]
				{
					'\\'
				});
				SafetyControl.SetText(this.FilePathRichTextBox, array[array.Length - 1]);
				this.firmwareFileOpenDialog.InitialDirectory = this.openFileInfo.filePath.Substring(0, this.openFileInfo.filePath.Length - array[array.Length - 1].Length);
				this.ReadFWFileInfoAndDisplay(this.openFileInfo, true);
			}
			this.firmwareFileOpenDialog.FileName = "";
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000C1BC File Offset: 0x0000A3BC
		private void CheckLogOptionFormInitFile()
		{
			string text = File.ReadAllText(MainForm.downloadFilePath + "\\init.ini");
			if (text.Split(new char[]
			{
				'\n'
			})[2].Split(new char[]
			{
				'='
			})[1] == "True")
			{
				LogClass.logEnable = true;
			}
			if (text.Split(new char[]
			{
				'\n'
			})[2].Split(new char[]
			{
				'='
			})[1] == "False")
			{
				LogClass.logEnable = false;
			}
			LogClass.InitLogFile();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000C254 File Offset: 0x0000A454
		public static string ReadOptionFromInitFile(string initFilePath, MainForm.OptionMenu option)
		{
			string result;
			try
			{
				result = File.ReadAllText(initFilePath + "\\init.ini").Split(new char[]
				{
					'\n'
				})[0].Split(new char[]
				{
					'='
				})[1].Split(new char[]
				{
					','
				})[(int)option];
			}
			catch
			{
				MainForm.CreateDirectoryAndInitFile();
				if (option != MainForm.OptionMenu.DARK_MODE)
				{
					if (option != MainForm.OptionMenu.AUTO_CONNECT)
					{
						result = null;
					}
					else
					{
						result = "Ture";
					}
				}
				else
				{
					result = "False";
				}
			}
			return result;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000C2E0 File Offset: 0x0000A4E0
		private void WriteOptionInitFile(string writeFilePath, MainForm.OptionMenu option, string writeValue)
		{
			try
			{
				string[] array = File.ReadAllText(writeFilePath + "\\init.ini").Split(new char[]
				{
					'\n'
				});
				string[] array2 = array[0].Split(new char[]
				{
					'='
				});
				string[] array3 = array2[1].Split(new char[]
				{
					','
				});
				array3[(int)option] = writeValue;
				string text = array2[0] + "=";
				for (int i = 0; i < array3.Length; i++)
				{
					text += array3[i];
					if (i != array3.Length - 1)
					{
						text += ",";
					}
				}
				text = string.Concat(new string[]
				{
					text,
					"\n",
					array[1],
					"\n",
					array[2]
				});
				File.WriteAllText(writeFilePath + "\\init.ini", text);
			}
			catch
			{
				MainForm.CreateDirectoryAndInitFile();
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		private bool ReadOpenFileFirstTimeFlagInitFile(string initFilePath)
		{
			bool result;
			try
			{
				result = !(File.ReadAllText(initFilePath + "\\init.ini").Split(new char[]
				{
					'\n'
				})[1].Split(new char[]
				{
					'='
				})[1].Split(new char[]
				{
					','
				})[0] == "0");
			}
			catch
			{
				MainForm.CreateDirectoryAndInitFile();
				result = false;
			}
			return result;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000C458 File Offset: 0x0000A658
		private string ReadOpenFilePathFormInitFile(string initFilePath)
		{
			string result;
			try
			{
				result = File.ReadAllText(initFilePath + "\\init.ini").Split(new char[]
				{
					'\n'
				})[1].Split(new char[]
				{
					'='
				})[1].Split(new char[]
				{
					','
				})[1];
			}
			catch
			{
				MainForm.CreateDirectoryAndInitFile();
				result = "";
			}
			return result;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		private void WriteOpenFilePathInitFile(string writeFilePath, string inputFilePath)
		{
			try
			{
				string[] array = File.ReadAllText(writeFilePath + "\\init.ini").Split(new char[]
				{
					'\n'
				});
				string[] array2 = array[1].Split(new char[]
				{
					'='
				});
				string[] array3 = array2[1].Split(new char[]
				{
					','
				});
				array3[0] = "1";
				array3[1] = inputFilePath;
				string text = array[0] + "\n";
				text = text + array2[0] + "=";
				text = string.Concat(new string[]
				{
					text,
					array3[0],
					",",
					array3[1],
					"\n"
				});
				text += array[2];
				File.WriteAllText(writeFilePath + "\\init.ini", text);
			}
			catch
			{
				MainForm.CreateDirectoryAndInitFile();
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		protected override void WndProc(ref Message m)
		{
			uint num = 537U;
			uint num2 = 32768U;
			uint num3 = 32772U;
			uint num4 = 161U;
			if ((long)m.Msg == (long)((ulong)num4))
			{
				return;
			}
			if ((long)m.Msg == (long)((ulong)num))
			{
				long num5 = (long)m.WParam.ToInt32();
				ulong num6 = (ulong)num2;
			}
			if ((long)m.Msg == (long)((ulong)num) && (long)m.WParam.ToInt32() == (long)((ulong)num3) && this.connectionCheckThread.IsAlive)
			{
				this.CheckDisconnectDeviceAndRefresh();
			}
			base.WndProc(ref m);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000C640 File Offset: 0x0000A840
		public void CheckDisconnectDeviceAndRefresh()
		{
			foreach (string value in SerialPort.GetPortNames())
			{
				if (this.uart.PortName().Equals(value))
				{
					return;
				}
			}
			this.uart.Close();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000C684 File Offset: 0x0000A884
		private void ConnectionCheck()
		{
			while (this.autoConnectThread.IsAlive)
			{
			}
			try
			{
				Thread.Sleep(100);
				if (this.uart.Init(this.connectedModelInfo.serialPortName, 4800))
				{
					while (this.connectedModelInfo.isConnected && !this.connectionCheckEndFlag)
					{
						if (!this.uart.CheckConnection())
						{
							break;
						}
						Thread.Sleep(FWDloadFormat.time500msec);
					}
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				try
				{
					this.uart.Close();
				}
				catch
				{
				}
				if (!this.connectionCheckEndFlag)
				{
					this.lastConnectedCOMPort = this.connectedModelInfo.serialPortName;
					this.SetDisconnectedDisplay();
					if (SafetyControl.GetChecked(this.AutoConnectEnableCheckBox))
					{
						this.StartAutoConnect();
					}
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000C768 File Offset: 0x0000A968
		private void AutoConnect()
		{
			while (this.connectionCheckThread.IsAlive)
			{
			}
			for (;;)
			{
				try
				{
					while (!this.autoConnectEndFlag)
					{
						Thread.Sleep(FWDloadFormat.time1sec);
						string[] portNames = SerialPort.GetPortNames();
						string[] array;
						if (this.lastConnectedCOMPort != string.Empty && portNames.Contains(this.lastConnectedCOMPort))
						{
							int num = 0;
							array = new string[portNames.Length];
							array[num++] = this.lastConnectedCOMPort;
							for (int i = 0; i < portNames.Length; i++)
							{
								if (!portNames[i].Equals(this.lastConnectedCOMPort))
								{
									array[num++] = portNames[i];
								}
							}
						}
						else
						{
							array = portNames;
						}
						for (int i = 0; i < array.Length; i++)
						{
							if (this.AutoSearch(this.connectedModelInfo, array[i], true))
							{
								return;
							}
						}
					}
				}
				catch (Exception)
				{
					this.SetDisconnectedDisplay();
					continue;
				}
				finally
				{
					try
					{
						this.uart.Close();
					}
					catch
					{
					}
					if (this.connectedModelInfo.isConnected)
					{
						this.StartConnectionCheck();
					}
					if (!this.autoConnectEndFlag)
					{
						this.SetAllButtonEnable(true);
					}
				}
				break;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000C898 File Offset: 0x0000AA98
		public bool AutoSearch(RDInfo modelInfo, string portName, bool displayFlag)
		{
			if (!this.uart.BeaconComm(portName, FWDloadFormat.time500msec, false))
			{
				return false;
			}
			this.SetAllButtonEnable(false);
			if (this.ReadVersionAndDisplay(modelInfo, this.uart, true))
			{
				return true;
			}
			this.SetDisconnectedDisplay();
			return false;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		public bool ReadVersionAndDisplay(RDInfo modelInfo, UARTCommUtils uart, bool urlDloadFlag)
		{
			int[] array = new int[8];
			int[] array2 = new int[2];
			int[] array3 = new int[2];
			ModelName modelName = ModelName.UNKNOWN;
			modelInfo.serialPortName = uart.PortName();
			for (int i = 0; i < 3; i++)
			{
				array2 = ReadRDVersionInfo.GetUIVersion(uart, modelInfo);
				if (array2[0] == -1)
				{
					modelInfo.serialPortName = string.Empty;
					return false;
				}
				modelName = (ModelName)array2[0];
				if (modelName != ModelName.UNKNOWN)
				{
					break;
				}
			}
			array[0] = array2[0];
			array[1] = array2[1];
			modelInfo.SetModel(modelName);
			this.SetConnectedDisplay(modelName);
			modelInfo.versionUI = array[1];
			if (modelInfo.versionUI != -1)
			{
				SafetyControl.SetText(this.MainVersionLabel, modelInfo.versionUI.ToString());
				SafetyControl.SetText(this.ConnectedVersionLabel, modelInfo.versionUI.ToString());
			}
			else
			{
				SafetyControl.SetText(this.MainVersionLabel, "___");
				SafetyControl.SetText(this.ConnectedVersionLabel, "___");
			}
			ModelName modelName2 = modelInfo.modelName;
			if (modelName2 != ModelName.R3)
			{
				if (modelName2 == ModelName.R3_NZK)
				{
					byte[] mcuid = ReadRDVersionInfo.GetMCUID(uart, modelInfo, FWDloadFormat.Step.UI);
					if (mcuid == null)
					{
						return false;
					}
					if (mcuid.SequenceEqual(FWDloadFormat.downloadCmdUIMCUIDNu2La_R3))
					{
						modelInfo.SetModel(ModelName.R3_NZK_PLUS);
					}
				}
			}
			else
			{
				byte[] mcuid = ReadRDVersionInfo.GetMCUID(uart, modelInfo, FWDloadFormat.Step.UI);
				if (mcuid == null)
				{
					return false;
				}
				if (mcuid.SequenceEqual(FWDloadFormat.downloadCmdUIMCUIDNu2La_R3))
				{
					modelInfo.SetModel(ModelName.R3_PLUS);
				}
			}
			array[2] = ReadRDVersionInfo.GetDSPVersion(uart, modelInfo);
			modelInfo.versionDSP = array[2];
			if (modelInfo.versionDSP != -1)
			{
				SafetyControl.AddText(this.MainVersionLabel, ".  " + modelInfo.versionDSP.ToString());
				SafetyControl.AddText(this.ConnectedVersionLabel, ".  " + modelInfo.versionDSP.ToString());
			}
			else
			{
				SafetyControl.AddText(this.MainVersionLabel, ".  ___");
				SafetyControl.AddText(this.ConnectedVersionLabel, ".  ___");
			}
			if (modelName != ModelName.R1)
			{
				array[3] = ReadRDVersionInfo.GetGPSVersion(uart, modelInfo);
				modelInfo.versionGPS = array[3];
				if (modelInfo.versionGPS != -1)
				{
					SafetyControl.AddText(this.MainVersionLabel, ".  " + modelInfo.versionGPS.ToString());
					SafetyControl.AddText(this.ConnectedVersionLabel, ".  " + modelInfo.versionGPS.ToString());
				}
				else
				{
					SafetyControl.AddText(this.MainVersionLabel, ".  ___");
					SafetyControl.AddText(this.ConnectedVersionLabel, ".  ___");
				}
				array[5] = ReadRDVersionInfo.GetGPSDBVersion(uart, modelInfo);
				modelInfo.versionGPSDB = array[5];
				if (modelInfo.versionGPSDB != -1)
				{
					try
					{
						if (modelInfo.modelName != ModelName.R3_NZ && modelInfo.modelName != ModelName.R3_NZK && modelInfo.modelName != ModelName.R3_NZK_PLUS && modelInfo.modelName != ModelName.R7_NZ && modelInfo.modelName != ModelName.R4_NZ && modelInfo.modelName != ModelName.R8_NZ)
						{
							SafetyControl.AddText(this.MainVersionLabel, string.Concat(new string[]
							{
								".  ",
								modelInfo.versionGPSDB.ToString().Substring(0, 4),
								"/",
								modelInfo.versionGPSDB.ToString().Substring(4, 2),
								"/",
								modelInfo.versionGPSDB.ToString().Substring(6, 2)
							}));
							SafetyControl.AddText(this.ConnectedVersionLabel, string.Concat(new string[]
							{
								".  ",
								modelInfo.versionGPSDB.ToString().Substring(0, 4),
								"/",
								modelInfo.versionGPSDB.ToString().Substring(4, 2),
								"/",
								modelInfo.versionGPSDB.ToString().Substring(6, 2)
							}));
						}
						else
						{
							SafetyControl.AddText(this.MainVersionLabel, ".  " + modelInfo.versionGPSDB.ToString());
							SafetyControl.AddText(this.ConnectedVersionLabel, ".  " + modelInfo.versionGPSDB.ToString());
						}
						goto IL_40A;
					}
					catch
					{
						SafetyControl.AddText(this.MainVersionLabel, ".  ________");
						SafetyControl.AddText(this.ConnectedVersionLabel, ".  ________");
						goto IL_40A;
					}
				}
				SafetyControl.AddText(this.MainVersionLabel, ".  ________");
				SafetyControl.AddText(this.ConnectedVersionLabel, ".  ________");
			}
			IL_40A:
			array3 = ReadRDVersionInfo.GetSoundDBVersion(uart, modelInfo);
			modelInfo.voiceICType = (FWDloadFormat.VOICE_IC)array3[0];
			array[4] = array3[1];
			modelInfo.versionSoundDB = array[4];
			if (modelInfo.versionSoundDB != -1)
			{
				SafetyControl.AddText(this.MainVersionLabel, ".  " + modelInfo.versionSoundDB.ToString());
				SafetyControl.AddText(this.ConnectedVersionLabel, ".  " + modelInfo.versionSoundDB.ToString());
			}
			else
			{
				SafetyControl.AddText(this.MainVersionLabel, ".  ___");
				SafetyControl.AddText(this.ConnectedVersionLabel, ".  ___");
			}
			if (modelInfo.supportBT || modelInfo.supportWIFI)
			{
				array[6] = ReadRDVersionInfo.GetBLEVersion(uart, modelInfo);
				modelInfo.versionBLE = array[6];
				if (modelInfo.versionBLE != -1)
				{
					SafetyControl.AddText(this.MainVersionLabel, ".  " + modelInfo.versionBLE.ToString());
					SafetyControl.AddText(this.ConnectedVersionLabel, ".  " + modelInfo.versionBLE.ToString());
				}
				else
				{
					SafetyControl.AddText(this.MainVersionLabel, ".  ___");
					SafetyControl.AddText(this.ConnectedVersionLabel, ".  ___");
				}
			}
			this.ConnectionStatusLabel.ForeColor = Color.DodgerBlue;
			SafetyControl.SetText(this.ConnectionStatusLabel, "CONNECTED");
			this.ConnectionStatus2Label.ForeColor = Color.DodgerBlue;
			SafetyControl.SetText(this.ConnectionStatus2Label, "CONNECTED");
			modelInfo.isConnected = true;
			if (urlDloadFlag && modelInfo.modelName != ModelName.UNKNOWN)
			{
				this.backgroundDownloadThread = new Thread(new ParameterizedThreadStart(this.BackgroundDownloadFromURL));
				this.backgroundDownloadThread.Start(modelInfo);
			}
			if (UserSettingConfig.GetMinSupportedVer(modelInfo.modelName) != -1)
			{
				this.SetUserSettingMenuEnable(true);
			}
			else
			{
				this.SetUserSettingMenuEnable(false);
			}
			return true;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		public void BackgroundDownloadFromURL(object obj)
		{
			try
			{
				RDInfo rdinfo = (RDInfo)obj;
				SafetyControl.SetText(this.MainFileVersionLabel, "");
				SafetyControl.SetVisible(this.MainFileVersionLabel, false);
				SafetyControl.SetText(this.LatestVersionLabel, "");
				SafetyControl.SetVisible(this.LatestVersionLabel, false);
				SafetyControl.SetText(this.LatestColonLable, "");
				SafetyControl.SetVisible(this.LatestColonLable, false);
				SafetyControl.SetText(this.DloadInternetSTSLabel, "Downloading files    ");
				SafetyControl.SetVisible(this.DloadInternetSTSLabel, true);
				MainForm.downloadingFromURLTimer.Start();
				string text;
				bool flag;
				if (!FWFileDloadURL.Download(rdinfo.modelName, MainForm.downloadFilePath, out text))
				{
					flag = false;
					SafetyControl.SetVisible(this.DloadInternetSTSLabel, true);
					SafetyControl.SetText(this.DloadInternetSTSLabel, "Server is not responding");
				}
				else
				{
					flag = true;
					SafetyControl.SetVisible(this.DloadInternetSTSLabel, false);
					SafetyControl.SetText(this.DloadInternetSTSLabel, "");
				}
				SafetyControl.SetText(this.MainFileVersionLabel, "");
				MainForm.downloadingFromURLTimer.Stop();
				if (!this.ReadOpenFileFirstTimeFlagInitFile(MainForm.downloadFilePath))
				{
					this.SetOpenFile(rdinfo, text);
				}
				SafetyControl.SetText(this.LatestVersionLabel, "Latest File");
				SafetyControl.SetVisible(this.LatestColonLable, true);
				SafetyControl.SetText(this.LatestColonLable, ":");
				SafetyControl.SetVisible(this.LatestVersionLabel, true);
				if (this.SetLatestFile(rdinfo, text))
				{
					if (this.latestFileInfo.uiNuFileVersion != -1)
					{
						SafetyControl.AddText(this.MainFileVersionLabel, this.latestFileInfo.uiNuFileVersion.ToString());
					}
					else
					{
						SafetyControl.AddText(this.MainFileVersionLabel, "___");
					}
					if (this.latestFileInfo.dspNuFileVersion != -1)
					{
						SafetyControl.AddText(this.MainFileVersionLabel, ".  " + this.latestFileInfo.dspNuFileVersion.ToString());
					}
					else
					{
						SafetyControl.AddText(this.MainFileVersionLabel, ".  ___");
					}
					if (this.latestFileInfo.modelName != ModelName.R1)
					{
						if (this.latestFileInfo.gpsNuFileVersion != -1)
						{
							SafetyControl.AddText(this.MainFileVersionLabel, ".  " + this.latestFileInfo.gpsNuFileVersion.ToString());
						}
						else
						{
							SafetyControl.AddText(this.MainFileVersionLabel, ".  ___");
						}
						if (this.latestFileInfo.gpsDBFileVersion != -1)
						{
							SafetyControl.AddText(this.MainFileVersionLabel, string.Concat(new string[]
							{
								".  ",
								this.latestFileInfo.gpsDBFileVersion.ToString().Substring(0, 4),
								"/",
								this.latestFileInfo.gpsDBFileVersion.ToString().Substring(4, 2),
								"/",
								this.latestFileInfo.gpsDBFileVersion.ToString().Substring(6, 2)
							}));
						}
						else
						{
							SafetyControl.AddText(this.MainFileVersionLabel, ".  ________");
						}
					}
					SafetyControl.SetVisible(this.MainFileVersionLabel, true);
					if (this.latestFileInfo.soundDBNuFileVersion != -1)
					{
						SafetyControl.AddText(this.MainFileVersionLabel, ".  " + this.latestFileInfo.soundDBNuFileVersion.ToString());
					}
					else if (this.latestFileInfo.soundDBLa1FileVersion != -1)
					{
						SafetyControl.AddText(this.MainFileVersionLabel, ".  " + this.latestFileInfo.soundDBLa1FileVersion.ToString());
					}
					else if (this.latestFileInfo.soundDBLa2FileVersion != -1)
					{
						SafetyControl.AddText(this.MainFileVersionLabel, ".  " + this.latestFileInfo.soundDBLa2FileVersion.ToString());
					}
					else
					{
						SafetyControl.AddText(this.MainFileVersionLabel, ".  ___");
					}
					if (RDInfo.isSupportBT(this.latestFileInfo.modelName) || RDInfo.isSupportWIFI(this.latestFileInfo.modelName))
					{
						if (this.latestFileInfo.bleFileVersion != -1)
						{
							SafetyControl.AddText(this.MainFileVersionLabel, ".  " + this.latestFileInfo.bleFileVersion.ToString());
						}
						else
						{
							SafetyControl.AddText(this.MainFileVersionLabel, ".  ___");
						}
					}
					if (text == null || !text.Equals(this.latestFileInfo.filePath))
					{
						SafetyControl.AddText(this.MainFileVersionLabel, " (Local)");
						if (flag)
						{
							SafetyControl.SetVisible(this.DloadInternetSTSLabel, true);
							SafetyControl.SetText(this.DloadInternetSTSLabel, "Downloaded file is invalid");
						}
					}
				}
				else
				{
					if (flag)
					{
						SafetyControl.SetVisible(this.DloadInternetSTSLabel, true);
						SafetyControl.SetText(this.DloadInternetSTSLabel, "Downloaded file is invalid");
					}
					SafetyControl.SetVisible(this.MainFileVersionLabel, true);
					SafetyControl.SetText(this.MainFileVersionLabel, "File does not exist");
				}
			}
			catch
			{
				SafetyControl.SetVisible(this.MainFileVersionLabel, true);
				SafetyControl.SetText(this.MainFileVersionLabel, "File does not exist");
				SafetyControl.SetVisible(this.DloadInternetSTSLabel, true);
				SafetyControl.SetText(this.DloadInternetSTSLabel, "Unknown error");
				this.latestFileInfo.DataClear();
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000D38C File Offset: 0x0000B58C
		private void SetUserSettingMenuEnable(bool enableFlag)
		{
			if (enableFlag)
			{
				SafetyControl.SetLocation(this.OptionButton, 0, 220);
				SafetyControl.SetLocation(this.MenuStatusOption, 0, 220);
				SafetyControl.SetLocation(this.UpdatesButton, 0, 260);
				SafetyControl.SetLocation(this.MenuStatusUpdates, 0, 260);
				SafetyControl.SetVisible(this.UserSettingButton, true);
				SafetyControl.SetLocation(this.UserSettingButton, 0, 180);
				return;
			}
			SafetyControl.SetLocation(this.OptionButton, 0, 180);
			SafetyControl.SetLocation(this.MenuStatusOption, 0, 180);
			SafetyControl.SetLocation(this.UpdatesButton, 0, 220);
			SafetyControl.SetLocation(this.MenuStatusUpdates, 0, 220);
			SafetyControl.SetVisible(this.UserSettingButton, false);
			SafetyControl.SetLocation(this.UserSettingButton, 0, 220);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000D41C File Offset: 0x0000B61C
		private void SetConnectedDisplay(ModelName modelName)
		{
			SafetyControl.SetText(this.ModelNameLabel, RDInfo.GetModelNameStr(modelName));
			SafetyControl.SetText(this.DetailConnectedModelLabel, RDInfo.GetModelNameStr(modelName));
			SafetyControl.SetLocation(this.ConnectionStatusLabel, 46, 215);
			SafetyControl.SetFront(this.ReadVersionSTSLabel1, false);
			SafetyControl.SetText(this.ReadVersionSTSLabel1, "");
			SafetyControl.SetText(this.ReadVersionSTSLabel2, "");
			switch (modelName)
			{
			case ModelName.R1:
				this.RDPictureBox.Image = Resources.r1_;
				SafetyControl.SetText(this.currentVersionPeriLabel, "(UI.  DSP.  Sound)");
				return;
			case (ModelName)2:
			case (ModelName)6:
			case (ModelName)10:
			case (ModelName)11:
			case (ModelName)12:
			case (ModelName)13:
			case (ModelName)22:
			case (ModelName)23:
			case (ModelName)25:
			case (ModelName)26:
			case (ModelName)27:
				goto IL_1CE;
			case ModelName.R3:
			case ModelName.R3_NZ:
			case ModelName.R3_NZK:
				break;
			case ModelName.R7:
			case ModelName.R7_NZ:
			case ModelName.R7_IL:
				this.RDPictureBox.Image = Resources.r7_;
				SafetyControl.SetText(this.currentVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound)");
				return;
			case ModelName.R4:
			case ModelName.R4_NZ:
			case ModelName.R4_IL:
			case ModelName.R4_EU:
				this.RDPictureBox.Image = Resources.r4_;
				SafetyControl.SetText(this.currentVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound.  BT)");
				return;
			case ModelName.R8:
			case ModelName.R8_NZ:
			case ModelName.R8_IL:
			case ModelName.R8_EU:
				this.RDPictureBox.Image = Resources.r8_;
				SafetyControl.SetText(this.currentVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound.  BT)");
				return;
			case ModelName.R4W:
				this.RDPictureBox.Image = Resources.r4_;
				SafetyControl.SetText(this.currentVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound.  BT/Wi-Fi)");
				return;
			case ModelName.R8W:
				this.RDPictureBox.Image = Resources.r8_;
				SafetyControl.SetText(this.currentVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound.  BT/Wi-Fi)");
				return;
			default:
				if (modelName != ModelName.R3_PLUS && modelName != ModelName.R3_NZK_PLUS)
				{
					goto IL_1CE;
				}
				break;
			}
			this.RDPictureBox.Image = Resources.r3_;
			SafetyControl.SetText(this.currentVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound)");
			return;
			IL_1CE:
			this.RDPictureBox.Image = null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000D604 File Offset: 0x0000B804
		private string[] GetFileNameArrayInDownloadFilePath(RDInfo modelInfo)
		{
			string modelNameStr = RDInfo.GetModelNameStr(modelInfo.modelName);
			int num = 0;
			FileInfo[] files = new DirectoryInfo(MainForm.downloadFilePath + "\\" + modelNameStr).GetFiles();
			int i = 0;
			int j = 0;
			while (i < files.Length)
			{
				if (files[i].Name.Length == modelNameStr.Length + 13 && int.TryParse(files[i].Name.Substring(files[i].Name.Length - 12, 8), out num))
				{
					j++;
				}
				i++;
			}
			if (j == 0)
			{
				return null;
			}
			string[] array = new string[j];
			i = 0;
			j = 0;
			while (i < files.Length)
			{
				if (files[i].Name.Length == modelNameStr.Length + 13 && int.TryParse(files[i].Name.Substring(files[i].Name.Length - 12, 8), out num))
				{
					array[j++] = string.Concat(new string[]
					{
						MainForm.downloadFilePath,
						"\\",
						modelNameStr,
						"\\",
						files[i].Name
					});
				}
				i++;
			}
			for (i = 0; i < array.Length; i++)
			{
				for (j = i; j < array.Length; j++)
				{
					int num2 = int.Parse(array[i].Substring(array[i].Length - 12, 8));
					int num3 = int.Parse(array[j].Substring(array[j].Length - 12, 8));
					if (num2 < num3)
					{
						string text = array[i];
						array[i] = array[j];
						array[j] = text;
					}
				}
			}
			return array;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000D7A8 File Offset: 0x0000B9A8
		private bool SetLatestFile(RDInfo modelInfo, string latestFilePath)
		{
			bool result;
			try
			{
				if (latestFilePath != null)
				{
					this.latestFileInfo.filePath = latestFilePath;
					if (this.ReadFWFileInfoAndDisplay(this.latestFileInfo, false))
					{
						return true;
					}
				}
				string[] fileNameArrayInDownloadFilePath = this.GetFileNameArrayInDownloadFilePath(modelInfo);
				if (fileNameArrayInDownloadFilePath == null)
				{
					result = false;
				}
				else
				{
					for (int i = 0; i < fileNameArrayInDownloadFilePath.Length; i++)
					{
						this.latestFileInfo.filePath = fileNameArrayInDownloadFilePath[i];
						if (this.ReadFWFileInfoAndDisplay(this.latestFileInfo, false))
						{
							return true;
						}
					}
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000D830 File Offset: 0x0000BA30
		private bool SetOpenFile(RDInfo modelInfo, string latestFilePath)
		{
			string modelNameStr = RDInfo.GetModelNameStr(modelInfo.modelName);
			bool result;
			try
			{
				if (latestFilePath != null)
				{
					this.openFileInfo.filePath = latestFilePath;
					if (this.ReadFWFileInfoAndDisplay(this.openFileInfo, true))
					{
						string[] array = this.openFileInfo.filePath.Split(new char[]
						{
							'\\'
						});
						SafetyControl.SetText(this.FilePathRichTextBox, array[array.Length - 1]);
						this.firmwareFileOpenDialog.InitialDirectory = MainForm.downloadFilePath + "\\" + modelNameStr;
						this.firmwareFileOpenDialog.FileName = "";
						return true;
					}
				}
				string[] fileNameArrayInDownloadFilePath = this.GetFileNameArrayInDownloadFilePath(modelInfo);
				if (fileNameArrayInDownloadFilePath == null)
				{
					result = false;
				}
				else
				{
					for (int i = 0; i < fileNameArrayInDownloadFilePath.Length; i++)
					{
						this.openFileInfo.filePath = fileNameArrayInDownloadFilePath[i];
						if (this.ReadFWFileInfoAndDisplay(this.openFileInfo, true))
						{
							string[] array = this.openFileInfo.filePath.Split(new char[]
							{
								'\\'
							});
							SafetyControl.SetText(this.FilePathRichTextBox, array[array.Length - 1]);
							this.firmwareFileOpenDialog.InitialDirectory = MainForm.downloadFilePath + "\\" + modelNameStr;
							this.firmwareFileOpenDialog.FileName = "";
							return true;
						}
					}
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000D990 File Offset: 0x0000BB90
		private async void SetDisconnectedDisplay()
		{
			if (MainForm.downloadingFromURLTimer.Enabled)
			{
				MainForm.downloadingFromURLTimer.Stop();
			}
			if (this.backgroundDownloadThread != null && this.backgroundDownloadThread.IsAlive)
			{
				await Task.Run(delegate()
				{
					this.backgroundDownloadThread.Interrupt();
				});
				await Task.Run(delegate()
				{
					this.backgroundDownloadThread.Join();
				});
			}
			this.ConnectionStatusLabel.ForeColor = Color.Silver;
			SafetyControl.SetText(this.ConnectionStatusLabel, "DISCONNECTED");
			SafetyControl.SetLocation(this.ConnectionStatusLabel, 46, 120);
			this.ConnectionStatus2Label.ForeColor = Color.Silver;
			SafetyControl.SetText(this.ConnectionStatus2Label, "DISCONNECTED");
			SafetyControl.SetText(this.ModelNameLabel, "");
			SafetyControl.SetText(this.DetailConnectedModelLabel, "");
			SafetyControl.SetText(this.ConnectedVersionLabel, "");
			SafetyControl.SetText(this.MainVersionLabel, "");
			SafetyControl.SetText(this.ReadVersionSTSLabel2, "");
			SafetyControl.SetText(this.MainFileVersionLabel, "");
			SafetyControl.SetVisible(this.MainFileVersionLabel, false);
			SafetyControl.SetText(this.LatestVersionLabel, "");
			SafetyControl.SetVisible(this.LatestVersionLabel, false);
			SafetyControl.SetText(this.LatestColonLable, "");
			SafetyControl.SetVisible(this.LatestColonLable, false);
			SafetyControl.SetText(this.DloadInternetSTSLabel, "");
			SafetyControl.SetVisible(this.DloadInternetSTSLabel, false);
			SafetyControl.SetText(this.currentVersionPeriLabel, "");
			this.SetUserSettingMenuEnable(false);
			this.RDPictureBox.Image = null;
			this.latestFileInfo = new FWFileInfo();
			this.connectedModelInfo = new RDInfo();
			this.connectedModelInfo.isConnected = false;
			this.SetAllButtonEnable(true);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000D9CC File Offset: 0x0000BBCC
		private void SetAllButtonEnable(bool flag)
		{
			SafetyControl.SetEnable(this.ReadVersionButton, flag);
			SafetyControl.SetEnable(this.FileOpenButton, flag);
			SafetyControl.SetEnable(this.AutoConnectEnableCheckBox, flag);
			SafetyControl.SetEnable(this.SimpleStartUpdateButton, flag);
			SafetyControl.SetEnable(this.RecoveryMode, flag);
			SafetyControl.SetEnable(this.DetailStartUpdateButton, flag);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000DA24 File Offset: 0x0000BC24
		public bool ReadFWFileInfoAndDisplay(FWFileInfo fileInfo, bool labelSetFlag)
		{
			if (FWFileInfo.ReadFWFileInfo(fileInfo))
			{
				if (labelSetFlag)
				{
					if (fileInfo.modelName != ModelName.UNKNOWN)
					{
						SafetyControl.SetText(this.DetailFileModelLabel, RDInfo.GetModelNameStr(fileInfo.modelName));
					}
					else
					{
						SafetyControl.SetText(this.DetailFileModelLabel, "");
					}
					if (fileInfo.modelName == ModelName.DB_US || fileInfo.modelName == ModelName.DB_IL || fileInfo.modelName == ModelName.DB_NZ || fileInfo.modelName == ModelName.DB_EU)
					{
						if (fileInfo.gpsDBFileVersion != -1)
						{
							if (fileInfo.modelName != ModelName.R3_NZ && fileInfo.modelName != ModelName.R3_NZK && fileInfo.modelName != ModelName.R7_NZ && fileInfo.modelName != ModelName.R4_NZ && fileInfo.modelName != ModelName.R8_NZ && fileInfo.modelName != ModelName.DB_NZ)
							{
								SafetyControl.SetText(this.FWFileVersionLabel, string.Concat(new string[]
								{
									fileInfo.gpsDBFileVersion.ToString().Substring(0, 4),
									"/",
									fileInfo.gpsDBFileVersion.ToString().Substring(4, 2),
									"/",
									fileInfo.gpsDBFileVersion.ToString().Substring(6, 2)
								}));
							}
							else
							{
								SafetyControl.SetText(this.FWFileVersionLabel, ((float)fileInfo.gpsDBFileVersion / 100f).ToString("0.00") ?? "");
							}
						}
						else
						{
							SafetyControl.SetText(this.FWFileVersionLabel, "________");
						}
					}
					else
					{
						if (fileInfo.uiNuFileVersion != -1)
						{
							SafetyControl.SetText(this.FWFileVersionLabel, fileInfo.uiNuFileVersion.ToString());
						}
						else
						{
							SafetyControl.SetText(this.FWFileVersionLabel, ".  ___");
						}
						if (fileInfo.dspNuFileVersion != -1)
						{
							SafetyControl.AddText(this.FWFileVersionLabel, ".  " + fileInfo.dspNuFileVersion.ToString());
						}
						else
						{
							SafetyControl.AddText(this.FWFileVersionLabel, ".  ___");
						}
						if (fileInfo.modelName != ModelName.R1)
						{
							if (fileInfo.gpsNuFileVersion != -1)
							{
								SafetyControl.AddText(this.FWFileVersionLabel, ".  " + fileInfo.gpsNuFileVersion.ToString());
							}
							else
							{
								SafetyControl.AddText(this.FWFileVersionLabel, ".  ___");
							}
							if (fileInfo.gpsDBFileVersion != -1)
							{
								if (fileInfo.modelName != ModelName.R3_NZ && fileInfo.modelName != ModelName.R3_NZK && fileInfo.modelName != ModelName.R7_NZ && fileInfo.modelName != ModelName.R4_NZ && fileInfo.modelName != ModelName.R8_NZ && fileInfo.modelName != ModelName.DB_NZ)
								{
									SafetyControl.AddText(this.FWFileVersionLabel, string.Concat(new string[]
									{
										".  ",
										fileInfo.gpsDBFileVersion.ToString().Substring(0, 4),
										"/",
										fileInfo.gpsDBFileVersion.ToString().Substring(4, 2),
										"/",
										fileInfo.gpsDBFileVersion.ToString().Substring(6, 2)
									}));
								}
								else
								{
									SafetyControl.AddText(this.FWFileVersionLabel, ".  " + fileInfo.gpsDBFileVersion.ToString());
								}
							}
							else
							{
								SafetyControl.AddText(this.FWFileVersionLabel, ".  ________");
							}
						}
						if (fileInfo.soundDBNuFileVersion != -1)
						{
							SafetyControl.AddText(this.FWFileVersionLabel, ".  " + fileInfo.soundDBNuFileVersion.ToString());
						}
						else if (fileInfo.soundDBLa1FileVersion != -1)
						{
							SafetyControl.AddText(this.FWFileVersionLabel, ".  " + fileInfo.soundDBLa1FileVersion.ToString());
						}
						else if (fileInfo.soundDBLa2FileVersion != -1)
						{
							SafetyControl.AddText(this.FWFileVersionLabel, ".  " + fileInfo.soundDBLa2FileVersion.ToString());
						}
						else
						{
							SafetyControl.AddText(this.FWFileVersionLabel, ".  ___");
						}
						if (RDInfo.isSupportBT(fileInfo.modelName) || RDInfo.isSupportWIFI(fileInfo.modelName))
						{
							if (fileInfo.bleFileVersion != -1)
							{
								SafetyControl.AddText(this.FWFileVersionLabel, ".  " + fileInfo.bleFileVersion.ToString());
							}
							else
							{
								SafetyControl.AddText(this.FWFileVersionLabel, ".  ___");
							}
						}
					}
					ModelName modelName = fileInfo.modelName;
					if (modelName <= ModelName.R3_PLUS)
					{
						switch (modelName)
						{
						case ModelName.R1:
							SafetyControl.SetText(this.downloadFileVersionPeriLabel, "(UI.  DSP.  Sound)");
							return true;
						case (ModelName)2:
						case (ModelName)6:
						case (ModelName)10:
						case (ModelName)11:
						case (ModelName)12:
						case (ModelName)13:
						case (ModelName)22:
						case (ModelName)23:
						case (ModelName)25:
						case (ModelName)26:
						case (ModelName)27:
							return true;
						case ModelName.R3:
						case ModelName.R3_NZ:
						case ModelName.R3_NZK:
							break;
						case ModelName.R7:
						case ModelName.R7_NZ:
						case ModelName.R7_IL:
							SafetyControl.SetText(this.downloadFileVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound)");
							return true;
						case ModelName.R4:
						case ModelName.R4_NZ:
						case ModelName.R4_IL:
						case ModelName.R4_EU:
							SafetyControl.SetText(this.downloadFileVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound.  BT)");
							return true;
						case ModelName.R8:
						case ModelName.R8_NZ:
						case ModelName.R8_IL:
						case ModelName.R8_EU:
							SafetyControl.SetText(this.downloadFileVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound.  BT)");
							return true;
						case ModelName.R4W:
							SafetyControl.SetText(this.downloadFileVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound.  BT/Wi-Fi)");
							return true;
						case ModelName.R8W:
							SafetyControl.SetText(this.downloadFileVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound.  BT/Wi-Fi)");
							return true;
						default:
							if (modelName != ModelName.R3_PLUS)
							{
								return true;
							}
							break;
						}
					}
					else if (modelName != ModelName.R3_NZK_PLUS)
					{
						switch (modelName)
						{
						case ModelName.DB_EU:
						case ModelName.DB_IL:
						case ModelName.DB_US:
						case ModelName.DB_NZ:
							SafetyControl.SetText(this.downloadFileVersionPeriLabel, "(DB)");
							return true;
						default:
							return true;
						}
					}
					SafetyControl.SetText(this.downloadFileVersionPeriLabel, "(UI.  DSP.  GPS.  DB.  Sound)");
				}
				return true;
			}
			if (labelSetFlag)
			{
				SafetyControl.SetText(this.DetailFileModelLabel, "");
				SafetyControl.SetText(this.FWFileVersionLabel, "");
			}
			return false;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		private void DownloadingTextTimerTick(object sender, ElapsedEventArgs e)
		{
			if (this.downloadingCounter == 0)
			{
				SafetyControl.SetText(this.DloadInternetSTSLabel, "Downloading files.   ");
				this.downloadingCounter++;
				return;
			}
			if (this.downloadingCounter == 1)
			{
				SafetyControl.SetText(this.DloadInternetSTSLabel, "Downloading files..  ");
				this.downloadingCounter++;
				return;
			}
			if (this.downloadingCounter == 2)
			{
				SafetyControl.SetText(this.DloadInternetSTSLabel, "Downloading files... ");
				this.downloadingCounter++;
				return;
			}
			if (this.downloadingCounter == 3)
			{
				SafetyControl.SetText(this.DloadInternetSTSLabel, "Downloading files....");
				this.downloadingCounter++;
				return;
			}
			if (this.downloadingCounter == 4)
			{
				SafetyControl.SetText(this.DloadInternetSTSLabel, "Downloading files    ");
				this.downloadingCounter = 0;
			}
		}

		// Token: 0x040000CA RID: 202
		public string toolName = "Uniden R Series Tools";

		// Token: 0x040000CB RID: 203
		public int toolVersion = 223;

		// Token: 0x040000CC RID: 204
		public int supportedFileFormatVer = 108;

		// Token: 0x040000CD RID: 205
		public static string downloadFilePath = "C:\\Uniden R Series Update Files";

		// Token: 0x040000CE RID: 206
		private UARTCommUtils uart = new UARTCommUtils();

		// Token: 0x040000CF RID: 207
		private volatile bool autoConnectEndFlag;

		// Token: 0x040000D0 RID: 208
		private volatile bool connectionCheckEndFlag;

		// Token: 0x040000D1 RID: 209
		private Thread autoConnectThread;

		// Token: 0x040000D2 RID: 210
		private Thread connectionCheckThread;

		// Token: 0x040000D3 RID: 211
		private Thread backgroundDownloadThread;

		// Token: 0x040000D4 RID: 212
		private static System.Timers.Timer downloadingFromURLTimer;

		// Token: 0x040000D5 RID: 213
		private int downloadingCounter;

		// Token: 0x040000D6 RID: 214
		public RDInfo connectedModelInfo = new RDInfo();

		// Token: 0x040000D7 RID: 215
		private FWFileInfo latestFileInfo = new FWFileInfo();

		// Token: 0x040000D8 RID: 216
		private FWFileInfo openFileInfo = new FWFileInfo();

		// Token: 0x040000D9 RID: 217
		public string lastConnectedCOMPort = string.Empty;

		// Token: 0x040000DA RID: 218
		private bool TagMove;

		// Token: 0x040000DB RID: 219
		private int MValX;

		// Token: 0x040000DC RID: 220
		private int MValY;

		// Token: 0x040000DD RID: 221
		private MainForm.MenuStatus currentMenu;

		// Token: 0x02000038 RID: 56
		public enum OptionMenu
		{
			// Token: 0x04000407 RID: 1031
			DARK_MODE,
			// Token: 0x04000408 RID: 1032
			AUTO_CONNECT
		}

		// Token: 0x02000039 RID: 57
		public enum MenuStatus
		{
			// Token: 0x0400040A RID: 1034
			UPDATE,
			// Token: 0x0400040B RID: 1035
			DOWNLOAD_FILES,
			// Token: 0x0400040C RID: 1036
			OPTION,
			UPDATES
		}

		// Token: 0x0200003A RID: 58
		public enum DeviceCap
		{
			// Token: 0x0400040E RID: 1038
			VERTRES = 10,
			// Token: 0x0400040F RID: 1039
			DESKTOPVERTRES = 117
		}
	}
}
