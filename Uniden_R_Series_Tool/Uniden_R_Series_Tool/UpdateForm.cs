using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using CustomControls;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200000E RID: 14
	public partial class UpdateForm : Form
	{
		// Token: 0x06000074 RID: 116
		[DllImport("user32.dll")]
		private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000075 RID: 117
		[DllImport("user32.dll")]
		private static extern bool SetForegroundWindow(IntPtr hWnd);

		// Token: 0x06000076 RID: 118
		[DllImport("user32.dll")]
		private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

		// Token: 0x06000077 RID: 119 RVA: 0x00008F11 File Offset: 0x00007111
		public UpdateForm(MainForm mainForm, UARTCommUtils uart, RDInfo modelInfo)
		{
			this.InitializeComponent();
			this.mainForm = mainForm;
			this.uart = uart;
			this.mModelInfo = modelInfo;
			this.readOnly = true;
			base.Opacity = 0.0;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00008F4C File Offset: 0x0000714C
		public UpdateForm(MainForm mainForm, UARTCommUtils uart, RDInfo modelInfo, FWFileInfo fileInfo, bool specificUpdateFlag, bool darkModeFlag)
		{
			this.InitializeComponent();
			UpdateForm.remainingTimeTimer = new System.Timers.Timer();
			UpdateForm.remainingTimeTimer.AutoReset = true;
			UpdateForm.remainingTimeTimer.Interval = (double)FWDloadFormat.time1sec;
			UpdateForm.remainingTimeTimer.Elapsed += this.RemainingTimeTick;
			this.mainForm = mainForm;
			this.uart = uart;
			this.mModelInfo = modelInfo;
			this.fileInfo = fileInfo;
			this.specificUpdateFlag = specificUpdateFlag;
			this.readOnly = false;
			this.isDarkMode = darkModeFlag;
			if (darkModeFlag)
			{
				this.SetDarkMode();
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00008FE0 File Offset: 0x000071E0
		private void SetDarkMode()
		{
			this.UpTilePanel.BackColor = Color.FromArgb(0, 0, 0);
			this.UpTilePanel.ForeColor = SystemColors.ButtonFace;
			this.BackColor = Color.FromArgb(30, 30, 30);
			this.StatusLabel.ForeColor = SystemColors.ButtonFace;
			this.percentLabel.ForeColor = SystemColors.ButtonFace;
			this.RemainingTimeLabel.ForeColor = SystemColors.ButtonFace;
			this.CancelButton.FlatStyle = FlatStyle.Flat;
			this.simpleDownloadProgressBar.SetDarkMode();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00009068 File Offset: 0x00007268
		private void UpdateForm_Load(object sender, EventArgs e)
		{
			base.ActiveControl = this.StatusLabel;
			if (this.readOnly)
			{
				base.Visible = false;
				this.updateThread = new Thread(new ThreadStart(this.ReadVersionProc));
			}
			else
			{
				this.updateThread = new Thread(new ThreadStart(this.UpdateProc));
			}
			this.updateThread.IsBackground = true;
			this.updateThread.Priority = ThreadPriority.Highest;
			this.updateThread.Start();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000090E3 File Offset: 0x000072E3
		private void UpdateForm_Closing(object sender, FormClosingEventArgs e)
		{
			while (this.updateThread.IsAlive)
			{
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000090F4 File Offset: 0x000072F4
		private async void CancelButton_Click(object sender, EventArgs e)
		{
			if (UpdateForm.remainingTimeTimer.Enabled)
			{
				UpdateForm.remainingTimeTimer.Stop();
			}
			this.updateThread.Abort();
			await Task.Run(delegate()
			{
				while (this.updateThread.IsAlive)
				{
				}
			});
			this.Close();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00009130 File Offset: 0x00007330
		private void RemainingTimeTick(object sender, ElapsedEventArgs e)
		{
			this.totalTimeSec++;
			if (this.fileInfo.totalSendCnt == 0)
			{
				return;
			}
			int num = this.totalTimeSec * this.fileInfo.totalDownloadCnt / this.fileInfo.totalSendCnt - this.totalTimeSec;
			int num2 = num / 60;
			int num3 = num % 60;
			string text = num2.ToString("00") + ":" + num3.ToString("00");
			SafetyControl.SetText(this.RemainingTimeLabel, text);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000091B8 File Offset: 0x000073B8
		private void PrintLabel(string printString, Color color)
		{
			SafetyControl.SetFront(this.StatusLabel, true);
			SafetyControl.SetSize(this.StatusLabel, 480, 63);
			SafetyControl.SetTextAlign(this.StatusLabel, ContentAlignment.MiddleLeft);
			SafetyControl.SetColor(this.StatusLabel, color);
			SafetyControl.SetFontSize(this.StatusLabel, 15);
			SafetyControl.SetVisible(this.percentLabel, false);
			SafetyControl.SetText(this.StatusLabel, printString);
			SafetyControl.SetText(this.CancelButton, "Ok");
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00009231 File Offset: 0x00007431
		private void PrintLabelFailReason(string printString)
		{
			if (this.isDarkMode)
			{
				this.PrintLabel(printString, Color.OrangeRed);
				return;
			}
			this.PrintLabel(printString, Color.Red);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00009254 File Offset: 0x00007454
		private void PrintLabelNotify(string printString)
		{
			if (this.isDarkMode)
			{
				this.PrintLabel(printString, Color.White);
				return;
			}
			this.PrintLabel(printString, Color.Black);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00009278 File Offset: 0x00007478
		private void PrintUpdateCompleted()
		{
			if (this.isDarkMode)
			{
				SafetyControl.SetColor(this.RemainingTimeLabel, Color.DodgerBlue);
			}
			else
			{
				SafetyControl.SetColor(this.RemainingTimeLabel, Color.Blue);
			}
			SafetyControl.SetFocus(this, this.CancelButton);
			SafetyControl.SetFront(this.RemainingTimeLabel, true);
			SafetyControl.SetFontSize(this.RemainingTimeLabel, 15);
			SafetyControl.SetText(this.RemainingTimeLabel, "Update Completed !");
			SafetyControl.SetText(this.CancelButton, "Ok");
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000092F4 File Offset: 0x000074F4
		private void PrintUpdateFailed()
		{
			if (this.isDarkMode)
			{
				SafetyControl.SetColor(this.RemainingTimeLabel, Color.OrangeRed);
			}
			else
			{
				SafetyControl.SetColor(this.RemainingTimeLabel, Color.Red);
			}
			SafetyControl.SetFront(this.RemainingTimeLabel, true);
			SafetyControl.SetFontSize(this.RemainingTimeLabel, 15);
			SafetyControl.SetText(this.RemainingTimeLabel, "Update Failed !");
			SafetyControl.SetText(this.CancelButton, "Ok");
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00009364 File Offset: 0x00007564
		private void ReadVersionProc()
		{
			try
			{
				this.mModelInfo.isConnected = false;
				SafetyControl.SetText(this.StatusLabel, "Checking Version.");
				if (this.TimeoutConnect())
				{
					this.mainForm.connectedModelInfo = this.mModelInfo;
				}
			}
			catch
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
				SafetyControl.CloseForm(this);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000093F0 File Offset: 0x000075F0
		private void UpdateProc()
		{
			FileStream fileStream = null;
			try
			{
				SafetyControl.SetText(this.StatusLabel, "Checking version.");
				if (this.mModelInfo.isConnected)
				{
					if (!this.uart.Init(this.mModelInfo.serialPortName, 4800))
					{
						return;
					}
					if (!this.ReadVersion(this.mModelInfo))
					{
						this.PrintLabelFailReason("Model not found !");
						return;
					}
				}
				else
				{
					if (!this.TimeoutConnect())
					{
						this.PrintLabelFailReason("Model not found !");
						return;
					}
					this.mainForm.connectedModelInfo = this.mModelInfo;
				}
				this.mainForm.connectedModelInfo.isConnected = true;
				if (!this.specificUpdateFlag)
				{
					if (this.mModelInfo.modelName == ModelName.UNKNOWN)
					{
						this.PrintLabelFailReason("Retry again using manual update(Download Files menu).");
						return;
					}
					if (this.fileInfo.filePath.Equals(""))
					{
						SafetyControl.SetText(this.StatusLabel, "Searching and downloading " + RDInfo.GetModelNameStr(this.mModelInfo.modelName) + " S/W file.");
						this.mainForm.BackgroundDownloadFromURL(this.mModelInfo);
					}
				}
				if (!this.mainForm.ReadFWFileInfoAndDisplay(this.fileInfo, this.specificUpdateFlag))
				{
					this.PrintLabelFailReason("Invalid or corrupted file.");
				}
				else if (this.mainForm.supportedFileFormatVer < this.fileInfo.fileFormatVer)
				{
					this.PrintLabelFailReason("Please use latest Uniden R Series tool.");
				}
				else
				{
					bool flag = FWUpdate.DloadCheckAvailableModel(this.mModelInfo, this.fileInfo);
					bool flag2 = FWUpdate.DloadCheckDownloadStep(this.mModelInfo, ref this.fileInfo);
					if (!flag)
					{
						this.PrintLabelFailReason("Connected model and file to download are not matched.");
					}
					else
					{
						if (this.fileInfo.modelName == ModelName.DB_US || this.fileInfo.modelName == ModelName.DB_NZ || this.fileInfo.modelName == ModelName.DB_IL || this.fileInfo.modelName == ModelName.DB_EU)
						{
							switch (FWUpdate.DloadCheckAvailableGPSDB(this.mModelInfo, this.fileInfo))
							{
							case FWDloadFormat.DB_CHECK.ERROR_IS_NOT_OLD_ENC_DB:
								this.PrintLabelFailReason("Please use the unified DB File.");
								break;
							case FWDloadFormat.DB_CHECK.ERROR_IS_NOT_AES128_DB:
								this.PrintLabelFailReason("Please use the unified DB File.");
								break;
							case FWDloadFormat.DB_CHECK.OKAY_IS_VALID_DB:
							case FWDloadFormat.DB_CHECK.OKAY_DB_NOT_EXIST:
								goto IL_22E;
							}
							return;
						}
						IL_22E:
						if (this.fileInfo.modelName != ModelName.DB_US && this.fileInfo.modelName != ModelName.DB_NZ && this.fileInfo.modelName != ModelName.DB_IL && this.fileInfo.modelName != ModelName.DB_EU)
						{
							FWDloadFormat.DLOAD_RESULT dload_RESULT = FWUpdate.DloadCheckValidMCUID(this.uart, this.mModelInfo, this.fileInfo);
							if (dload_RESULT == FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE)
							{
								this.PrintLabelFailReason("H/W revision cannot support this rollback version.");
								return;
							}
							if (dload_RESULT != FWDloadFormat.DLOAD_RESULT.OKAY)
							{
							}
						}
						if (this.specificUpdateFlag)
						{
							if (!flag2)
							{
								this.PrintLabelNotify("No update needed.");
								return;
							}
						}
						else
						{
							this.UpForm();
							UpdateCheckForm childForm = new UpdateCheckForm(this.mModelInfo, this.fileInfo, flag2, this.isDarkMode);
							UpdateCheckForm.Result result = (UpdateCheckForm.Result)SafetyControl.FormShowDialogSync(this, childForm);
							if (result == UpdateCheckForm.Result.Cancel)
							{
								SafetyControl.CloseForm(this);
								return;
							}
							if (result == UpdateCheckForm.Result.RecoveryUpdate)
							{
								this.fileInfo.recoveryModeFlag = true;
							}
							else
							{
								this.fileInfo.recoveryModeFlag = false;
							}
							int[] uiversion = ReadRDVersionInfo.GetUIVersion(this.uart, this.mModelInfo);
							if (uiversion[0] == -1)
							{
								this.PrintLabelFailReason("Model not found !");
								return;
							}
							ModelName modelName = (ModelName)uiversion[0];
							if (modelName != ModelName.R3)
							{
								if (modelName == ModelName.R3_NZK)
								{
									byte[] mcuid = ReadRDVersionInfo.GetMCUID(this.uart, this.mModelInfo, FWDloadFormat.Step.UI);
									if (mcuid == null)
									{
										this.PrintLabelFailReason("Model not found !");
										return;
									}
									if (mcuid.SequenceEqual(FWDloadFormat.downloadCmdUIMCUIDNu2La_R3))
									{
										modelName = ModelName.R3_NZK_PLUS;
									}
								}
							}
							else
							{
								byte[] mcuid = ReadRDVersionInfo.GetMCUID(this.uart, this.mModelInfo, FWDloadFormat.Step.UI);
								if (mcuid == null)
								{
									this.PrintLabelFailReason("Model not found !");
									return;
								}
								if (mcuid.SequenceEqual(FWDloadFormat.downloadCmdUIMCUIDNu2La_R3))
								{
									modelName = ModelName.R3_PLUS;
								}
							}
							this.mModelInfo.SetModel(modelName);
							if (!FWUpdate.DloadCheckAvailableModel(this.mModelInfo, this.fileInfo))
							{
								this.PrintLabelFailReason("Connected model and file to download are not matched.");
								return;
							}
							FWUpdate.DloadCheckDownloadStep(this.mModelInfo, ref this.fileInfo);
						}
						this.mainForm.connectedModelInfo.isConnected = false;
						this.totalTimeSec = 0;
						UpdateForm.remainingTimeTimer.Start();
						SafetyControl.SetText(this.RemainingTimeLabel, "--:--");
						fileStream = new FileStream(this.fileInfo.filePath, FileMode.Open, FileAccess.Read);
						FWDloadFormat.DLOAD_RESULT dload_RESULT2 = FWUpdate.StartUpdate(fileStream, this.uart, this.mModelInfo, this.fileInfo, this.simpleDownloadProgressBar, this.StatusLabel, this.percentLabel);
						UpdateForm.remainingTimeTimer.Stop();
						this.UpForm();
						if (dload_RESULT2 != FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE)
						{
							if (dload_RESULT2 == FWDloadFormat.DLOAD_RESULT.OKAY)
							{
								this.PrintUpdateCompleted();
							}
							else
							{
								this.PrintUpdateFailed();
							}
						}
						else
						{
							this.PrintLabelFailReason("Download failed! not supported version.\r\nPlease download latest version.");
						}
					}
				}
			}
			catch (ThreadAbortException)
			{
				this.mainForm.connectedModelInfo.isConnected = false;
			}
			catch
			{
				SafetyControl.SetColor(this.StatusLabel, Color.Red);
				SafetyControl.SetText(this.StatusLabel, "Unknown error !");
				SafetyControl.SetText(this.CancelButton, "Ok");
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
				try
				{
					this.uart.Close();
				}
				catch
				{
				}
				Thread.Sleep(100);
				this.UpForm();
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000998C File Offset: 0x00007B8C
		private void UpForm()
		{
			IntPtr intPtr = UpdateForm.FindWindow(null, this.Text);
			IntPtr intPtr2 = UpdateForm.FindWindow(null, this.mainForm.Text);
			if (!intPtr2.Equals(IntPtr.Zero))
			{
				UpdateForm.ShowWindowAsync(intPtr2, 1);
				UpdateForm.SetForegroundWindow(intPtr2);
			}
			if (!intPtr.Equals(IntPtr.Zero))
			{
				UpdateForm.ShowWindowAsync(intPtr, 1);
				UpdateForm.SetForegroundWindow(intPtr);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000099FC File Offset: 0x00007BFC
		private bool TimeoutConnect()
		{
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount < FWDloadFormat.time5sec)
			{
				Thread.Sleep(FWDloadFormat.time1sec);
				string[] portNames = SerialPort.GetPortNames();
				string[] array;
				if (this.mainForm.lastConnectedCOMPort != string.Empty && portNames.Contains(this.mainForm.lastConnectedCOMPort))
				{
					int num = 0;
					array = new string[portNames.Length];
					array[num++] = this.mainForm.lastConnectedCOMPort;
					for (int i = 0; i < portNames.Length; i++)
					{
						if (!portNames[i].Equals(this.mainForm.lastConnectedCOMPort))
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
					if (this.ConnectProc(this.mModelInfo, array[i]))
					{
						this.mModelInfo.isConnected = true;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00009AE1 File Offset: 0x00007CE1
		private bool ConnectProc(RDInfo modelInfo, string portName)
		{
			return this.uart.BeaconComm(portName, FWDloadFormat.time500msec, false) && this.mainForm.ReadVersionAndDisplay(modelInfo, this.uart, false);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00009B14 File Offset: 0x00007D14
		private bool ReadVersion(RDInfo modelInfo)
		{
			int[] array = new int[8];
			int[] array2 = new int[2];
			int[] array3 = new int[2];
			ModelName modelName = ModelName.UNKNOWN;
			modelInfo.serialPortName = this.uart.PortName();
			for (int i = 0; i < 3; i++)
			{
				array2 = ReadRDVersionInfo.GetUIVersion(this.uart, modelInfo);
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
			if (modelName != ModelName.R3)
			{
				if (modelName == ModelName.R3_NZK)
				{
					byte[] mcuid = ReadRDVersionInfo.GetMCUID(this.uart, modelInfo, FWDloadFormat.Step.UI);
					if (mcuid == null)
					{
						return false;
					}
					if (mcuid.SequenceEqual(FWDloadFormat.downloadCmdUIMCUIDNu2La_R3))
					{
						modelName = ModelName.R3_NZK_PLUS;
					}
				}
			}
			else
			{
				byte[] mcuid = ReadRDVersionInfo.GetMCUID(this.uart, modelInfo, FWDloadFormat.Step.UI);
				if (mcuid == null)
				{
					return false;
				}
				if (mcuid.SequenceEqual(FWDloadFormat.downloadCmdUIMCUIDNu2La_R3))
				{
					modelName = ModelName.R3_PLUS;
				}
			}
			array[0] = array2[0];
			array[1] = array2[1];
			if (modelInfo.modelName != modelName)
			{
				modelInfo.SetModel(modelName);
			}
			if (modelName != ModelName.UNKNOWN)
			{
				modelInfo.versionUI = array[1];
				array[2] = ReadRDVersionInfo.GetDSPVersion(this.uart, modelInfo);
				modelInfo.versionDSP = array[2];
				if (modelName != ModelName.R1)
				{
					array[3] = ReadRDVersionInfo.GetGPSVersion(this.uart, modelInfo);
					modelInfo.versionGPS = array[3];
					array[5] = ReadRDVersionInfo.GetGPSDBVersion(this.uart, modelInfo);
					modelInfo.versionGPSDB = array[5];
				}
				array3 = ReadRDVersionInfo.GetSoundDBVersion(this.uart, modelInfo);
				modelInfo.voiceICType = (FWDloadFormat.VOICE_IC)array3[0];
				array[4] = array3[1];
				modelInfo.versionSoundDB = array[4];
				if (modelName == ModelName.R4 || modelName == ModelName.R4_NZ || modelName == ModelName.R4_IL || modelName == ModelName.R4_EU || modelName == ModelName.R8 || modelName == ModelName.R8_NZ || modelName == ModelName.R8_IL || modelName == ModelName.R8_EU || modelName == ModelName.R4W || modelName == ModelName.R8W)
				{
					array[6] = ReadRDVersionInfo.GetBLEVersion(this.uart, modelInfo);
					modelInfo.versionBLE = array[6];
				}
			}
			modelInfo.isConnected = true;
			return true;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00009CE8 File Offset: 0x00007EE8
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

		// Token: 0x0600008A RID: 138 RVA: 0x00009D40 File Offset: 0x00007F40
		private void FormMouseMove(object sender, MouseEventArgs e)
		{
			if (this.TagMove)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.MValX, Control.MousePosition.Y - this.MValY);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00009D83 File Offset: 0x00007F83
		private void FormMouseUp(object sender, MouseEventArgs e)
		{
			this.TagMove = false;
		}

		// Token: 0x04000090 RID: 144
		private const int SW_SHOWNORMAL = 1;

		// Token: 0x04000091 RID: 145
		private const int SW_SHOWMINIMIZED = 2;

		// Token: 0x04000092 RID: 146
		private const int SW_SHOWMAXIMIZED = 3;

		// Token: 0x04000093 RID: 147
		public MainForm mainForm;

		// Token: 0x04000094 RID: 148
		private Thread updateThread;

		// Token: 0x04000095 RID: 149
		private RDInfo mModelInfo;

		// Token: 0x04000096 RID: 150
		private FWFileInfo fileInfo;

		// Token: 0x04000097 RID: 151
		private static System.Timers.Timer remainingTimeTimer;

		// Token: 0x04000098 RID: 152
		private int totalTimeSec;

		// Token: 0x04000099 RID: 153
		private bool specificUpdateFlag;

		// Token: 0x0400009A RID: 154
		private bool readOnly;

		// Token: 0x0400009B RID: 155
		private UARTCommUtils uart;

		// Token: 0x0400009C RID: 156
		private bool TagMove;

		// Token: 0x0400009D RID: 157
		private int MValX;

		// Token: 0x0400009E RID: 158
		private int MValY;

		// Token: 0x0400009F RID: 159
		private bool isDarkMode;
	}
}
