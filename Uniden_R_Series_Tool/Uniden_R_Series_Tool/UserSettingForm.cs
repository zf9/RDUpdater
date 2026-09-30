using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using CustomControls;
using Uniden_R_Series_Tool.Properties;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000028 RID: 40
	public partial class UserSettingForm : Form
	{
		// Token: 0x0600018F RID: 399 RVA: 0x0001BC6C File Offset: 0x00019E6C
		public UserSettingForm(UARTCommUtils uart, RDInfo modelInfo, bool darkMode)
		{
			this.InitializeComponent();
			base.FormClosed += new FormClosedEventHandler(this.UserSetting_Closed);
			this.uart = uart;
			this.modelInfo = modelInfo;
			this.isDarkMode = darkMode;
			if (darkMode)
			{
				this.SetDarkMode();
			}
			this.userSettingData = new UserSettingController(modelInfo, this.UserSettingGridView, this.DataGridScrollBar, this.MenuNameLabel, this.MenuDescriptionLabel, this.hwRevisionPanel, this.hwRevisionLabel, this.isDarkMode);
			this.MenuDescriptionLabel.SizeChanged += this.MenuDescriptionLabel_SizeChanged;
			this.MenuDescriptionLabel.MouseWheel += this.MenuDescription_MouseWheel;
			this.MenuNameLabel.MouseWheel += this.MenuDescription_MouseWheel;
			this.MenuDescriptionPanel.MouseWheel += this.MenuDescription_MouseWheel;
			this.MenuDescriptionScrollbar.Scroll += this.MenuDescriptionScrollBar_Scroll;
			this.modelNameLabel.Text = RDInfo.GetModelNameStr(modelInfo.modelName) + " SSID";
			ModelName modelName = modelInfo.modelName;
			if (modelName == ModelName.R1)
			{
				this.GPSButton.Visible = false;
				this.WifiButton.Visible = false;
				Size size = this.UserPreferenceButton.Size;
				size.Width += 50;
				this.UserPreferenceButton.Size = size;
				size = this.BandSettingButton.Size;
				size.Width += 50;
				this.BandSettingButton.Size = size;
				size = this.SoundButton.Size;
				size.Width += 50;
				this.SoundButton.Size = size;
				size = this.DisplayButton.Size;
				size.Width += 50;
				this.DisplayButton.Size = size;
				this.wifiSupport = false;
				return;
			}
			if (modelName != ModelName.R4W && modelName != ModelName.R8W)
			{
				this.WifiButton.Visible = false;
				Size size = this.UserPreferenceButton.Size;
				size.Width += 20;
				this.UserPreferenceButton.Size = size;
				size = this.BandSettingButton.Size;
				size.Width += 20;
				this.BandSettingButton.Size = size;
				size = this.GPSButton.Size;
				size.Width += 20;
				this.GPSButton.Size = size;
				size = this.SoundButton.Size;
				size.Width += 20;
				this.SoundButton.Size = size;
				size = this.DisplayButton.Size;
				size.Width += 20;
				this.DisplayButton.Size = size;
				this.wifiSupport = false;
				return;
			}
			this.WifiButton.Visible = true;
			this.wifiSupport = true;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001BF50 File Offset: 0x0001A150
		private void SetDarkMode()
		{
			this.UpTilePanel.BackColor = Color.Black;
			this.UpCloseButton.BackColor = Color.Black;
			this.TitleLabel.ForeColor = SystemColors.ButtonFace;
			this.UpCloseButton.ForeColor = SystemColors.ButtonFace;
			this.UpCloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
			this.UserSettingPenal.BackColor = Color.FromArgb(30, 30, 30);
			this.panel2.BackColor = Color.FromArgb(50, 50, 50);
			this.MenuDescriptionPanel.BackColor = Color.FromArgb(30, 30, 30);
			this.UserSettingGridView.BackgroundColor = Color.FromArgb(30, 30, 30);
			this.wifiPanel.BackColor = Color.FromArgb(30, 30, 30);
			this.hwRevisionConstLabel.ForeColor = SystemColors.ButtonFace;
			this.hwRevisionLabel.ForeColor = SystemColors.ButtonFace;
			this.UserPreferenceButton.BackColor = Color.FromArgb(50, 50, 50);
			this.UserPreferenceButton.ForeColor = SystemColors.ButtonFace;
			this.UserPreferenceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
			this.UserPreferenceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
			this.BandSettingButton.BackColor = Color.FromArgb(10, 10, 10);
			this.BandSettingButton.ForeColor = SystemColors.ButtonFace;
			this.BandSettingButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
			this.BandSettingButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
			this.GPSButton.BackColor = Color.FromArgb(10, 10, 10);
			this.GPSButton.ForeColor = SystemColors.ButtonFace;
			this.GPSButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
			this.GPSButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
			this.SoundButton.BackColor = Color.FromArgb(10, 10, 10);
			this.SoundButton.ForeColor = SystemColors.ButtonFace;
			this.SoundButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
			this.SoundButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
			this.DisplayButton.BackColor = Color.FromArgb(10, 10, 10);
			this.DisplayButton.ForeColor = SystemColors.ButtonFace;
			this.DisplayButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
			this.DisplayButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
			this.WifiButton.BackColor = Color.FromArgb(10, 10, 10);
			this.WifiButton.ForeColor = SystemColors.ButtonFace;
			this.WifiButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
			this.WifiButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
			this.label2.BackColor = Color.FromArgb(30, 30, 30);
			this.MenuNameLabel.BackColor = Color.FromArgb(30, 30, 30);
			this.MenuNameLabel.ForeColor = SystemColors.ButtonFace;
			this.MenuDescriptionLabel.ForeColor = SystemColors.ButtonFace;
			this.UserSettingLoadButton.FlatStyle = FlatStyle.Flat;
			this.UserSettingSaveButton.FlatStyle = FlatStyle.Flat;
			this.LoadFileButton.FlatStyle = FlatStyle.Flat;
			this.SaveFileButton.FlatStyle = FlatStyle.Flat;
			this.CloseButton.FlatStyle = FlatStyle.Flat;
			this.DataGridScrollBar.ArrowColor = Color.White;
			this.DataGridScrollBar.ButtonFaceColor = Color.FromArgb(60, 60, 60);
			this.DataGridScrollBar.BorderColor = Color.FromArgb(130, 130, 130);
			this.DataGridScrollBar.ChannelColor = Color.FromArgb(130, 130, 130);
			this.DataGridScrollBar.ThumbColor = Color.FromArgb(60, 60, 60);
			this.MenuDescriptionScrollbar.ArrowColor = Color.White;
			this.MenuDescriptionScrollbar.ButtonFaceColor = Color.FromArgb(60, 60, 60);
			this.MenuDescriptionScrollbar.BorderColor = Color.FromArgb(130, 130, 130);
			this.MenuDescriptionScrollbar.ChannelColor = Color.FromArgb(130, 130, 130);
			this.MenuDescriptionScrollbar.ThumbColor = Color.FromArgb(60, 60, 60);
			this.modelLabelPanel.BackColor = (this.UserPreferenceButton.BackColor = Color.FromArgb(50, 50, 50));
			this.settingLabelPanel.BackColor = (this.UserPreferenceButton.BackColor = Color.FromArgb(50, 50, 50));
			this.passwordEyeButton.BackgroundImage = Resources.hide_darkmode;
			this.settingLabel.ForeColor = Color.FromArgb(180, 180, 180);
			this.modelNameLabel.ForeColor = Color.FromArgb(180, 180, 180);
			this.currentSSIDLabel.ForeColor = Color.FromArgb(180, 180, 180);
			this.setSSIDLabel.ForeColor = Color.FromArgb(180, 180, 180);
			this.setPasswordLabel.ForeColor = Color.FromArgb(180, 180, 180);
			this.saveWIFIInfoButton.FlatStyle = FlatStyle.Flat;
			this.wifiSSIDTextBox.BackColor = Color.FromArgb(30, 30, 30);
			this.wifiSSIDTextBox.ForeColor = Color.FromArgb(180, 180, 180);
			this.wifiPasswordTextBox.BackColor = Color.FromArgb(30, 30, 30);
			this.wifiPasswordTextBox.ForeColor = Color.FromArgb(180, 180, 180);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001C554 File Offset: 0x0001A754
		private void MenuDescriptionLabel_SizeChanged(object sender, EventArgs e)
		{
			if (this.MenuDescriptionLabel.Size.Height > 59)
			{
				this.MenuDescriptionScrollbar.Visible = true;
				this.MenuDescriptionScrollbar.Minimum = 0;
				this.MenuDescriptionScrollbar.Maximum = 20 + this.MenuDescriptionLabel.Size.Height;
				this.MenuDescriptionScrollbar.LargeChange = 79 - 79 * ((this.MenuDescriptionScrollbar.Maximum - 79) / this.MenuDescriptionScrollbar.Maximum);
				this.MenuDescriptionScrollbar.SmallChange = 15;
				this.MenuDescriptionScrollbar.Value = 0;
				return;
			}
			this.MenuDescriptionScrollbar.Visible = false;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001C604 File Offset: 0x0001A804
		private void MenuDescription_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta < 0)
			{
				if (this.MenuDescriptionScrollbar.Value + 15 + this.MenuDescriptionScrollbar.LargeChange < this.MenuDescriptionScrollbar.Maximum)
				{
					this.MenuDescriptionScrollbar.Value += 15;
				}
				else
				{
					this.MenuDescriptionScrollbar.Value = this.MenuDescriptionScrollbar.Maximum - this.MenuDescriptionScrollbar.LargeChange;
				}
			}
			else if (this.MenuDescriptionScrollbar.Value - 15 > 0)
			{
				this.MenuDescriptionScrollbar.Value -= 15;
			}
			else
			{
				this.MenuDescriptionScrollbar.Value = 0;
			}
			this.MenuDescriptionScrollBar_Scroll(null, null);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001C6B6 File Offset: 0x0001A8B6
		private void MenuDescriptionScrollBar_Scroll(object sender, EventArgs e)
		{
			this.MenuDescriptionPanel.AutoScrollPosition = new Point(0, this.MenuDescriptionScrollbar.Value);
			this.MenuDescriptionScrollbar.Invalidate();
			Application.DoEvents();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001C6E4 File Offset: 0x0001A8E4
		private void UserSetting_Load(object sender, EventArgs e)
		{
			this.hwRevisionPanel.VisibleChanged += this.hwRevisionPanel_VisibleChanged;
			this.hwRevisionPanel.Visible = false;
			this.userSettingThread = new Thread(new ThreadStart(this.UserSettingLoad));
			this.userSettingThread.Start();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001C736 File Offset: 0x0001A936
		private void UserSetting_Closed(object sender, EventArgs e)
		{
			if (this.userSettingThread != null && this.userSettingThread.IsAlive)
			{
				this.userSettingThread.Abort();
			}
			this.uart.Close();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001C764 File Offset: 0x0001A964
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
			base.WndProc(ref m);
			if ((long)m.Msg == (long)((ulong)num))
			{
				long num5 = (long)m.WParam.ToInt32();
				ulong num6 = (ulong)num2;
			}
			if ((long)m.Msg == (long)((ulong)num) && (long)m.WParam.ToInt32() == (long)((ulong)num3))
			{
				this.CheckDisconnectDeviceAndRefresh();
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001C7E0 File Offset: 0x0001A9E0
		public void CheckDisconnectDeviceAndRefresh()
		{
			foreach (string value in SerialPort.GetPortNames())
			{
				if (this.modelInfo.serialPortName.Equals(value))
				{
					return;
				}
			}
			this.modelInfo.isConnected = false;
			this.uart.Close();
			SafetyControl.MessageBoxShowSync(this, "Connection error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			SafetyControl.CloseForm(this);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001C84C File Offset: 0x0001AA4C
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

		// Token: 0x06000199 RID: 409 RVA: 0x0001C8A4 File Offset: 0x0001AAA4
		private void FormMouseMove(object sender, MouseEventArgs e)
		{
			if (this.TagMove)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.MValX, Control.MousePosition.Y - this.MValY);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001C8E7 File Offset: 0x0001AAE7
		private void FormMouseUp(object sender, MouseEventArgs e)
		{
			this.TagMove = false;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001C8F0 File Offset: 0x0001AAF0
		private void UpCloseButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			this.uart.Close();
			base.Close();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001C90C File Offset: 0x0001AB0C
		private void UserSettingLoadButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			this.userSettingThread = new Thread(new ThreadStart(this.UserSettingLoad));
			this.userSettingThread.Start();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001C93C File Offset: 0x0001AB3C
		private void SaveFileButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			this.SaveFileDialog.FileName = "";
			this.SaveFileDialog.Filter = "bin files|*.bin";
			if (this.SaveFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			if (this.userSettingData.SaveUserSettingFile(this.SaveFileDialog.FileName))
			{
				SafetyControl.MessageBoxShowSync(this, "Completed to save file.", "File save", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			SafetyControl.MessageBoxShowSync(this, "failed to save file.", "File save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001C9C0 File Offset: 0x0001ABC0
		private void LoadFileButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			this.LoadFileDialog.FileName = "";
			this.LoadFileDialog.Filter = "bin files|*.bin";
			if (this.LoadFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			switch (this.userSettingData.LoadUserSettingFile(this.LoadFileDialog.FileName, this.modelInfo))
			{
			case UserSettingController.FILE_OPEN_RESULT.SUCCESS:
				SafetyControl.MessageBoxShowSync(this, "Completed to open file.", "File load", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			case UserSettingController.FILE_OPEN_RESULT.SUCCESS_SOME_SETTING_ARE_NOT_SET:
				SafetyControl.MessageBoxShowSync(this, "Completed to open file.\r\n(This setting file is incompatible, so some settings may not apply)", "File load", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			SafetyControl.MessageBoxShowSync(this, "Failed to open file.", "File load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001CA74 File Offset: 0x0001AC74
		private void UserSettingLoad()
		{
			SafetyControl.SetUseWaitCursor(this, true);
			this.threadRunFlag = true;
			try
			{
				if (this.modelInfo.isConnected && this.modelInfo.modelName != ModelName.UNKNOWN)
				{
					if (this.wifiSupport)
					{
						string wifiInfo = ReadRDVersionInfo.GetWifiInfo(this.uart, this.modelInfo);
						if (wifiInfo != string.Empty)
						{
							SafetyControl.SetText(this.currentSSIDLabel, wifiInfo);
						}
					}
					if (!this.userSettingData.ReadUserSetting(this.uart, this.modelInfo))
					{
						SafetyControl.MessageBoxShowSync(this, "Failed to load.", "Load from unit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						SafetyControl.MessageBoxShowSync(this, "Completed to load.", "Load from unit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
			}
			finally
			{
				this.uart.Close();
				this.threadRunFlag = false;
				this.TagMove = false;
				SafetyControl.SetUseWaitCursor(this, false);
				if (this.userSettingData.setting.receivedNVData == null)
				{
					SafetyControl.CloseForm(this);
				}
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001CB70 File Offset: 0x0001AD70
		private void saveWIFIInfoButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			this.userSettingThread = new Thread(new ThreadStart(this.WifiInfoSave));
			this.userSettingThread.Start();
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001CBA0 File Offset: 0x0001ADA0
		private void WifiInfoSave()
		{
			SafetyControl.SetUseWaitCursor(this, true);
			this.threadRunFlag = true;
			try
			{
				if (this.modelInfo.isConnected)
				{
					if (this.wifiSSIDTextBox.Text != string.Empty)
					{
						string text = SafetyControl.GetText(this.wifiSSIDTextBox);
						string text2 = SafetyControl.GetText(this.wifiPasswordTextBox);
						if (!ReadRDVersionInfo.SetWifiInfo(this.uart, this.modelInfo, text, text2))
						{
							SafetyControl.MessageBoxShowSync(this, "Failed to Wifi Setting.", "Save to Wifi Setting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
						else
						{
							text = ReadRDVersionInfo.GetWifiInfo(this.uart, this.modelInfo);
							if (text != string.Empty)
							{
								SafetyControl.SetText(this.currentSSIDLabel, text);
							}
							SafetyControl.MessageBoxShowSync(this, "Completed to Setting.", "Save to Wifi Setting", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}
					}
					else
					{
						SafetyControl.MessageBoxShowSync(this, "Failed to Wifi Setting.", "Save to Wifi Setting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
			}
			finally
			{
				this.uart.Close();
				this.threadRunFlag = false;
				this.TagMove = false;
				SafetyControl.SetUseWaitCursor(this, false);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001CCAC File Offset: 0x0001AEAC
		private void UserSettingSaveButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			this.userSettingThread = new Thread(new ThreadStart(this.UserSettingSave));
			this.userSettingThread.Start();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001CCDC File Offset: 0x0001AEDC
		private void UserSettingSave()
		{
			SafetyControl.SetUseWaitCursor(this, true);
			this.threadRunFlag = true;
			try
			{
				if (this.modelInfo.isConnected && this.modelInfo.modelName != ModelName.UNKNOWN)
				{
					if (!this.userSettingData.WriteUserSetting(this.uart, this.modelInfo))
					{
						this.userSettingData.ReadUserSetting(this.uart, this.modelInfo);
						SafetyControl.MessageBoxShowSync(this, "Failed to store.", "Store to unit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						this.userSettingData.ReadUserSetting(this.uart, this.modelInfo);
						SafetyControl.MessageBoxShowSync(this, "Completed to store.", "Store to unit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
			}
			finally
			{
				this.uart.Close();
				this.threadRunFlag = false;
				this.TagMove = false;
				SafetyControl.SetUseWaitCursor(this, false);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
		private void UserPreferenceButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			if (this.isDarkMode)
			{
				this.UserPreferenceButton.BackColor = Color.FromArgb(50, 50, 50);
				this.BandSettingButton.BackColor = Color.FromArgb(10, 10, 10);
				this.GPSButton.BackColor = Color.FromArgb(10, 10, 10);
				this.SoundButton.BackColor = Color.FromArgb(10, 10, 10);
				this.DisplayButton.BackColor = Color.FromArgb(10, 10, 10);
				this.WifiButton.BackColor = Color.FromArgb(10, 10, 10);
			}
			else
			{
				this.UserPreferenceButton.BackColor = Color.White;
				this.BandSettingButton.BackColor = Color.Transparent;
				this.GPSButton.BackColor = Color.Transparent;
				this.SoundButton.BackColor = Color.Transparent;
				this.DisplayButton.BackColor = Color.Transparent;
				this.WifiButton.BackColor = Color.Transparent;
			}
			this.settingPanel.Visible = true;
			this.wifiPanel.Visible = false;
			this.userSettingData.ShowUserPreMenu();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001CEEC File Offset: 0x0001B0EC
		private void BandSettingButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			if (this.isDarkMode)
			{
				this.BandSettingButton.BackColor = Color.FromArgb(50, 50, 50);
				this.UserPreferenceButton.BackColor = Color.FromArgb(10, 10, 10);
				this.GPSButton.BackColor = Color.FromArgb(10, 10, 10);
				this.SoundButton.BackColor = Color.FromArgb(10, 10, 10);
				this.DisplayButton.BackColor = Color.FromArgb(10, 10, 10);
				this.WifiButton.BackColor = Color.FromArgb(10, 10, 10);
			}
			else
			{
				this.BandSettingButton.BackColor = Color.White;
				this.UserPreferenceButton.BackColor = Color.Transparent;
				this.GPSButton.BackColor = Color.Transparent;
				this.SoundButton.BackColor = Color.Transparent;
				this.DisplayButton.BackColor = Color.Transparent;
				this.WifiButton.BackColor = Color.Transparent;
			}
			this.settingPanel.Visible = true;
			this.wifiPanel.Visible = false;
			this.userSettingData.ShowBandSettingMenu();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001D018 File Offset: 0x0001B218
		private void GPSButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			if (this.isDarkMode)
			{
				this.GPSButton.BackColor = Color.FromArgb(50, 50, 50);
				this.UserPreferenceButton.BackColor = Color.FromArgb(10, 10, 10);
				this.BandSettingButton.BackColor = Color.FromArgb(10, 10, 10);
				this.SoundButton.BackColor = Color.FromArgb(10, 10, 10);
				this.DisplayButton.BackColor = Color.FromArgb(10, 10, 10);
				this.WifiButton.BackColor = Color.FromArgb(10, 10, 10);
			}
			else
			{
				this.GPSButton.BackColor = Color.White;
				this.BandSettingButton.BackColor = Color.Transparent;
				this.UserPreferenceButton.BackColor = Color.Transparent;
				this.SoundButton.BackColor = Color.Transparent;
				this.DisplayButton.BackColor = Color.Transparent;
				this.WifiButton.BackColor = Color.Transparent;
			}
			this.settingPanel.Visible = true;
			this.wifiPanel.Visible = false;
			this.userSettingData.ShowGPSMenu();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001D144 File Offset: 0x0001B344
		private void VoiceButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			if (this.isDarkMode)
			{
				this.SoundButton.BackColor = Color.FromArgb(50, 50, 50);
				this.UserPreferenceButton.BackColor = Color.FromArgb(10, 10, 10);
				this.BandSettingButton.BackColor = Color.FromArgb(10, 10, 10);
				this.GPSButton.BackColor = Color.FromArgb(10, 10, 10);
				this.DisplayButton.BackColor = Color.FromArgb(10, 10, 10);
				this.WifiButton.BackColor = Color.FromArgb(10, 10, 10);
			}
			else
			{
				this.SoundButton.BackColor = Color.White;
				this.BandSettingButton.BackColor = Color.Transparent;
				this.GPSButton.BackColor = Color.Transparent;
				this.UserPreferenceButton.BackColor = Color.Transparent;
				this.DisplayButton.BackColor = Color.Transparent;
				this.WifiButton.BackColor = Color.Transparent;
			}
			this.settingPanel.Visible = true;
			this.wifiPanel.Visible = false;
			this.userSettingData.ShowVoiceMenu();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001D270 File Offset: 0x0001B470
		private void DisplayButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			if (this.isDarkMode)
			{
				this.DisplayButton.BackColor = Color.FromArgb(50, 50, 50);
				this.UserPreferenceButton.BackColor = Color.FromArgb(10, 10, 10);
				this.BandSettingButton.BackColor = Color.FromArgb(10, 10, 10);
				this.GPSButton.BackColor = Color.FromArgb(10, 10, 10);
				this.SoundButton.BackColor = Color.FromArgb(10, 10, 10);
				this.WifiButton.BackColor = Color.FromArgb(10, 10, 10);
			}
			else
			{
				this.DisplayButton.BackColor = Color.White;
				this.BandSettingButton.BackColor = Color.Transparent;
				this.GPSButton.BackColor = Color.Transparent;
				this.SoundButton.BackColor = Color.Transparent;
				this.UserPreferenceButton.BackColor = Color.Transparent;
				this.WifiButton.BackColor = Color.Transparent;
			}
			this.settingPanel.Visible = true;
			this.wifiPanel.Visible = false;
			this.userSettingData.ShowDisplayMenu();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001D39C File Offset: 0x0001B59C
		private void WifiButton_Click(object sender, EventArgs e)
		{
			if (this.threadRunFlag)
			{
				return;
			}
			if (this.isDarkMode)
			{
				this.WifiButton.BackColor = Color.FromArgb(50, 50, 50);
				this.UserPreferenceButton.BackColor = Color.FromArgb(10, 10, 10);
				this.BandSettingButton.BackColor = Color.FromArgb(10, 10, 10);
				this.GPSButton.BackColor = Color.FromArgb(10, 10, 10);
				this.SoundButton.BackColor = Color.FromArgb(10, 10, 10);
				this.DisplayButton.BackColor = Color.FromArgb(10, 10, 10);
			}
			else
			{
				this.WifiButton.BackColor = Color.White;
				this.BandSettingButton.BackColor = Color.Transparent;
				this.GPSButton.BackColor = Color.Transparent;
				this.SoundButton.BackColor = Color.Transparent;
				this.UserPreferenceButton.BackColor = Color.Transparent;
				this.DisplayButton.BackColor = Color.Transparent;
			}
			this.settingPanel.Visible = false;
			this.wifiPanel.Visible = true;
			this.userSettingData.ShowDisplayMenu();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001D4C8 File Offset: 0x0001B6C8
		private void hwRevisionPanel_VisibleChanged(object sender, EventArgs e)
		{
			if (this.hwRevisionPanel.Visible)
			{
				this.MinimumSize = new Size(base.Size.Width, base.Size.Height + 20);
				this.MaximumSize = new Size(base.Size.Width, base.Size.Height + 20);
				return;
			}
			this.MinimumSize = new Size(base.Size.Width, base.Size.Height - 20);
			this.MaximumSize = new Size(base.Size.Width, base.Size.Height - 20);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001D58C File Offset: 0x0001B78C
		private void passwordEyeButton_Click(object sender, EventArgs e)
		{
			if (!this.isDarkMode)
			{
				if (this.passwordShow)
				{
					this.passwordShow = false;
					this.passwordEyeButton.BackgroundImage = Resources.hide;
					this.wifiPasswordTextBox.PasswordChar = '*';
					return;
				}
				this.passwordShow = true;
				this.passwordEyeButton.BackgroundImage = Resources.show;
				this.wifiPasswordTextBox.PasswordChar = '\0';
				return;
			}
			else
			{
				if (this.passwordShow)
				{
					this.passwordShow = false;
					this.passwordEyeButton.BackgroundImage = Resources.hide_darkmode;
					this.wifiPasswordTextBox.PasswordChar = '*';
					return;
				}
				this.passwordShow = true;
				this.passwordEyeButton.BackgroundImage = Resources.show_darkmode;
				this.wifiPasswordTextBox.PasswordChar = '\0';
				return;
			}
		}

		// Token: 0x04000336 RID: 822
		private UARTCommUtils uart;

		// Token: 0x04000337 RID: 823
		private RDInfo modelInfo;

		// Token: 0x04000338 RID: 824
		private UserSettingController userSettingData;

		// Token: 0x04000339 RID: 825
		private Thread userSettingThread;

		// Token: 0x0400033A RID: 826
		private bool threadRunFlag;

		// Token: 0x0400033B RID: 827
		private bool TagMove;

		// Token: 0x0400033C RID: 828
		private int MValX;

		// Token: 0x0400033D RID: 829
		private int MValY;

		// Token: 0x0400033E RID: 830
		private bool isDarkMode;

		// Token: 0x0400033F RID: 831
		private bool wifiSupport;

		// Token: 0x04000340 RID: 832
		private bool passwordShow;
	}
}
