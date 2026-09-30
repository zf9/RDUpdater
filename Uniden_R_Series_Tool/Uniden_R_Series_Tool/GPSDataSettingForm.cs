using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CustomControls;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000004 RID: 4
	[ComVisible(true)]
	[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
	public partial class GPSDataSettingForm : Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002C86 File Offset: 0x00000E86
		private uint MAKELPARAM(int p_1, int p_2)
		{
			return (uint)(p_2 << 16 | (p_1 & 65535));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002C94 File Offset: 0x00000E94
		public GPSDataSettingForm(UARTCommUtils uart, RDInfo modelInfo, bool isDarkMode)
		{
			this.InitializeComponent();
			base.MaximizedBounds = Screen.FromHandle(base.Handle).WorkingArea;
			this.isDarkMode = isDarkMode;
			string uriString;
			if (isDarkMode)
			{
				this.SetDarkMode();
				uriString = "file:///C:/Uniden R Series Update Files/Point Editor/Uniden_R_Tool_Map_Dark.html";
			}
			else
			{
				uriString = "file:///C:/Uniden R Series Update Files/Point Editor/Uniden_R_Tool_Map.html";
			}
			base.FormBorderStyle = FormBorderStyle.None;
			this.DoubleBuffered = true;
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.FormClosed += new FormClosedEventHandler(this.GPSDataSetting_Closed);
			this.uart = uart;
			this.modelInfo = modelInfo;
			this.browser = new WebBrowser();
			this.browser.Dock = DockStyle.Fill;
			this.BrowserPanel.Controls.Add(this.browser);
			Uri url = new Uri(uriString);
			this.browser.Navigate(url);
			this.UserMarkTabPanel.MouseWheel += this.TabPanel_ScrollChanged;
			this.MuteMemoryTabPanel.MouseWheel += this.TabPanel_ScrollChanged;
			this.TabScrollBar.Scroll += this.CustomScrollBar_ScrollChanged;
			this.SetControlEntered(this);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002DAC File Offset: 0x00000FAC
		public void SetControlEntered(Control parent)
		{
			for (int i = 0; i < parent.Controls.Count; i++)
			{
				parent.Controls[i].Enter += this.Control_Enter;
				this.SetControlEntered(parent.Controls[i]);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002DFE File Offset: 0x00000FFE
		private void Control_Enter(object sender, EventArgs e)
		{
			if (!sender.Equals(this.browser))
			{
				if (sender.GetType().Equals(typeof(Button)))
				{
					((Button)sender).PerformClick();
				}
				SafetyControl.SetActiveControl(this, this.browser);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002E3C File Offset: 0x0000103C
		protected override void OnPaint(PaintEventArgs e)
		{
			Brush brush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
			e.Graphics.FillRectangle(brush, this.Top);
			e.Graphics.FillRectangle(brush, this.Left);
			e.Graphics.FillRectangle(brush, this.Right);
			e.Graphics.FillRectangle(brush, this.Bottom);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002EA0 File Offset: 0x000010A0
		private new Rectangle Top
		{
			get
			{
				return new Rectangle(0, 0, base.ClientSize.Width, 7);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002EC4 File Offset: 0x000010C4
		private new Rectangle Left
		{
			get
			{
				return new Rectangle(0, 0, 7, base.ClientSize.Height);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002EE8 File Offset: 0x000010E8
		private new Rectangle Bottom
		{
			get
			{
				return new Rectangle(0, base.ClientSize.Height - 7, base.ClientSize.Width, 7);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002F1C File Offset: 0x0000111C
		private new Rectangle Right
		{
			get
			{
				return new Rectangle(base.ClientSize.Width - 7, 0, 7, base.ClientSize.Height);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002F4E File Offset: 0x0000114E
		private Rectangle TopLeft
		{
			get
			{
				return new Rectangle(0, 0, 7, 7);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002F5C File Offset: 0x0000115C
		private Rectangle TopRight
		{
			get
			{
				return new Rectangle(base.ClientSize.Width - 7, 0, 7, 7);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002F84 File Offset: 0x00001184
		private Rectangle BottomLeft
		{
			get
			{
				return new Rectangle(0, base.ClientSize.Height - 7, 7, 7);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002FAC File Offset: 0x000011AC
		private Rectangle BottomRight
		{
			get
			{
				return new Rectangle(base.ClientSize.Width - 7, base.ClientSize.Height - 7, 7, 7);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002FE0 File Offset: 0x000011E0
		protected override void WndProc(ref Message message)
		{
			base.WndProc(ref message);
			if (message.Msg == 132)
			{
				if (base.WindowState == FormWindowState.Maximized)
				{
					return;
				}
				Point pt = base.PointToClient(Cursor.Position);
				Point point = new Point(pt.X, pt.Y);
				if (this.TopLeft.Location.X <= point.X && this.TopLeft.Size.Width >= point.X && this.TopLeft.Location.Y <= point.Y && this.TopLeft.Size.Height >= point.Y)
				{
					message.Result = (IntPtr)13;
					return;
				}
				if (this.TopRight.Contains(pt))
				{
					message.Result = (IntPtr)14;
					return;
				}
				if (this.BottomLeft.Contains(pt))
				{
					message.Result = (IntPtr)16;
					return;
				}
				if (this.BottomRight.Contains(pt))
				{
					message.Result = (IntPtr)17;
					return;
				}
				if (this.Top.Contains(pt))
				{
					message.Result = (IntPtr)12;
					return;
				}
				if (this.Left.Contains(pt))
				{
					message.Result = (IntPtr)10;
					return;
				}
				if (this.Right.Contains(pt))
				{
					message.Result = (IntPtr)11;
					return;
				}
				if (this.Bottom.Contains(pt))
				{
					message.Result = (IntPtr)15;
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003194 File Offset: 0x00001394
		public void SetDarkMode()
		{
			this.UpTilePanel.BackColor = Color.Black;
			this.UpCloseButton.BackColor = Color.Black;
			this.MinimizeButton.BackColor = Color.Black;
			this.MaximizeButton.BackColor = Color.Black;
			this.UpCloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
			this.MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
			this.MaximizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
			this.TitleLabel.ForeColor = SystemColors.ButtonFace;
			this.UpCloseButton.ForeColor = SystemColors.ButtonFace;
			this.MinimizeButton.ForeColor = SystemColors.ButtonFace;
			this.MaximizeButton.ForeColor = SystemColors.ButtonFace;
			this.MainPanel.BackColor = Color.FromArgb(30, 30, 30);
			this.ControlPanel.BackColor = Color.FromArgb(30, 30, 30);
			this.TabPanel.BackColor = Color.FromArgb(50, 50, 50);
			this.UserMarkTabButton.BackColor = Color.FromArgb(50, 50, 50);
			this.MuteMemoryTabButton.BackColor = Color.Black;
			this.UserMarkTabButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
			this.UserMarkTabButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
			this.MuteMemoryTabButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
			this.MuteMemoryTabButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
			this.UserMarkTabButton.ForeColor = SystemColors.ButtonFace;
			this.MuteMemoryTabButton.ForeColor = SystemColors.ButtonFace;
			this.TabScrollBar.ArrowColor = Color.White;
			this.TabScrollBar.ButtonFaceColor = Color.FromArgb(60, 60, 60);
			this.TabScrollBar.BorderColor = Color.FromArgb(130, 130, 130);
			this.TabScrollBar.ChannelColor = Color.FromArgb(130, 130, 130);
			this.TabScrollBar.ThumbColor = Color.FromArgb(60, 60, 60);
			this.GPSDataLoadFromUnitButton.FlatStyle = FlatStyle.Flat;
			this.GPSDataStoreToUnitButton.FlatStyle = FlatStyle.Flat;
			this.GPSDataOpenFileButton.FlatStyle = FlatStyle.Flat;
			this.GPSDataSaveFileButton.FlatStyle = FlatStyle.Flat;
			this.CloseButton.FlatStyle = FlatStyle.Flat;
			this.LoadingProgressBar.SetDarkMode();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003427 File Offset: 0x00001627
		public void GPSDataSetting_Load(object sender, EventArgs e)
		{
			this.browser.ObjectForScripting = this;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003435 File Offset: 0x00001635
		public void GPSDataSetting_Closed(object sender, EventArgs e)
		{
			if (this.loadingThread != null)
			{
				this.loadingThread.Abort();
			}
			base.Dispose();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003450 File Offset: 0x00001650
		public void ShowUserMarkTab()
		{
			if (this.userMark.Count > 0)
			{
				int num = this.userMark.Count * 40 - SafetyControl.GetHeight(this.TabPanel) - 38;
				if (num > 0)
				{
					SafetyControl.SetVisible(this.TabScrollBar, true);
					this.TabScrollBar.Height = SafetyControl.GetHeight(this.TabPanel) - 38;
					SafetyControl.CustomScrollSetParam(this.TabScrollBar, SafetyControl.GetHeight(this.TabPanel) - 38, SafetyControl.GetVerticalScrollMinimum(this.UserMarkTabPanel), SafetyControl.GetVerticalScrollMaximum(this.UserMarkTabPanel), SafetyControl.GetVerticalScrollLargeChange(this.UserMarkTabPanel), SafetyControl.GetVerticalScrollSmallChange(this.UserMarkTabPanel), SafetyControl.GetVerticalScrollValue(this.UserMarkTabPanel));
				}
				SafetyControl.BringToFront(this.UserMarkTabPanel);
				if (num <= 0)
				{
					SafetyControl.SetVisible(this.TabScrollBar, false);
				}
			}
			else
			{
				SafetyControl.BringToFront(this.NoDataLabel);
				SafetyControl.SetVisible(this.TabScrollBar, false);
			}
			this.currentTab = BUTTON_TAB.USER_MARK_TAB;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003540 File Offset: 0x00001740
		public void ShowMuteMemoryTab()
		{
			if (this.muteMemory.Count > 0)
			{
				int num = this.muteMemory.Count * 40 - SafetyControl.GetHeight(this.TabPanel) - 38;
				if (num > 0)
				{
					SafetyControl.SetVisible(this.TabScrollBar, true);
					SafetyControl.CustomScrollSetParam(this.TabScrollBar, SafetyControl.GetHeight(this.TabPanel) - 38, SafetyControl.GetVerticalScrollMinimum(this.MuteMemoryTabPanel), SafetyControl.GetVerticalScrollMaximum(this.MuteMemoryTabPanel), SafetyControl.GetVerticalScrollLargeChange(this.MuteMemoryTabPanel), SafetyControl.GetVerticalScrollSmallChange(this.MuteMemoryTabPanel), SafetyControl.GetVerticalScrollValue(this.MuteMemoryTabPanel));
				}
				SafetyControl.BringToFront(this.MuteMemoryTabPanel);
				if (num <= 0)
				{
					SafetyControl.SetVisible(this.TabScrollBar, false);
				}
			}
			else
			{
				SafetyControl.BringToFront(this.NoDataLabel);
				SafetyControl.SetVisible(this.TabScrollBar, false);
			}
			this.currentTab = BUTTON_TAB.MUTE_MEMORY_TAB;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003618 File Offset: 0x00001818
		public void TabPanel_SizeChanged(object sender, EventArgs e)
		{
			this.ButtonPanel.Height = this.TabPanel.Size.Height - 38;
			this.UserMarkTabPanel.Height = this.TabPanel.Size.Height - 38;
			this.MuteMemoryTabPanel.Height = this.TabPanel.Size.Height - 38;
			this.NoDataLabel.Height = this.TabPanel.Size.Height - 38;
			BUTTON_TAB button_TAB = this.currentTab;
			if (button_TAB != BUTTON_TAB.USER_MARK_TAB)
			{
				if (button_TAB != BUTTON_TAB.MUTE_MEMORY_TAB)
				{
					return;
				}
				if (this.muteMemory == null)
				{
					return;
				}
				if (this.muteMemory.Count * 40 - this.MuteMemoryTabPanel.Size.Height > 0)
				{
					SafetyControl.SetVisible(this.TabScrollBar, true);
					SafetyControl.CustomScrollSetParam(this.TabScrollBar, SafetyControl.GetHeight(this.TabPanel) - 38, SafetyControl.GetVerticalScrollMinimum(this.MuteMemoryTabPanel), SafetyControl.GetVerticalScrollMaximum(this.MuteMemoryTabPanel), SafetyControl.GetVerticalScrollLargeChange(this.MuteMemoryTabPanel), SafetyControl.GetVerticalScrollSmallChange(this.MuteMemoryTabPanel), SafetyControl.GetVerticalScrollValue(this.MuteMemoryTabPanel));
				}
			}
			else
			{
				if (this.muteMemory == null)
				{
					return;
				}
				if (this.muteMemory.Count * 40 - this.UserMarkTabPanel.Size.Height > 0)
				{
					SafetyControl.SetVisible(this.TabScrollBar, true);
					SafetyControl.CustomScrollSetParam(this.TabScrollBar, SafetyControl.GetHeight(this.TabPanel) - 38, SafetyControl.GetVerticalScrollMinimum(this.UserMarkTabPanel), SafetyControl.GetVerticalScrollMaximum(this.UserMarkTabPanel), SafetyControl.GetVerticalScrollLargeChange(this.UserMarkTabPanel), SafetyControl.GetVerticalScrollSmallChange(this.UserMarkTabPanel), SafetyControl.GetVerticalScrollValue(this.UserMarkTabPanel));
					return;
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000037D4 File Offset: 0x000019D4
		public void TabPanel_ScrollChanged(object sender, MouseEventArgs e)
		{
			BUTTON_TAB button_TAB = this.currentTab;
			if (button_TAB == BUTTON_TAB.USER_MARK_TAB)
			{
				this.TabScrollBar.Value = this.UserMarkTabPanel.VerticalScroll.Value;
				return;
			}
			if (button_TAB != BUTTON_TAB.MUTE_MEMORY_TAB)
			{
				return;
			}
			this.TabScrollBar.Value = this.MuteMemoryTabPanel.VerticalScroll.Value;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003828 File Offset: 0x00001A28
		public void CustomScrollBar_ScrollChanged(object sender, EventArgs e)
		{
			BUTTON_TAB button_TAB = this.currentTab;
			if (button_TAB == BUTTON_TAB.USER_MARK_TAB)
			{
				this.UserMarkTabPanel.VerticalScroll.Value = this.TabScrollBar.Value;
				return;
			}
			if (button_TAB != BUTTON_TAB.MUTE_MEMORY_TAB)
			{
				return;
			}
			this.MuteMemoryTabPanel.VerticalScroll.Value = this.TabScrollBar.Value;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000387B File Offset: 0x00001A7B
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			return (base.ActiveControl is Button && ((keyData & Keys.Left) == Keys.Left || (keyData & Keys.Right) == Keys.Right || (keyData & Keys.Up) == Keys.Up || (keyData & Keys.Down) == Keys.Down)) || base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000038B4 File Offset: 0x00001AB4
		public void UserMarkTabButton_Click(object sender, EventArgs e)
		{
			if (!this.activateFlag)
			{
				return;
			}
			if (this.isDarkMode)
			{
				this.UserMarkTabButton.BackColor = Color.FromArgb(50, 50, 50);
				this.MuteMemoryTabButton.BackColor = Color.FromArgb(10, 10, 10);
			}
			else
			{
				this.UserMarkTabButton.BackColor = Color.White;
				this.MuteMemoryTabButton.BackColor = Color.FromArgb(234, 235, 235);
			}
			this.ShowUserMarkTab();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003938 File Offset: 0x00001B38
		public void MuteMemoryTabButton_Click(object sender, EventArgs e)
		{
			if (!this.activateFlag)
			{
				return;
			}
			if (this.isDarkMode)
			{
				this.MuteMemoryTabButton.BackColor = Color.FromArgb(50, 50, 50);
				this.UserMarkTabButton.BackColor = Color.FromArgb(10, 10, 10);
			}
			else
			{
				this.MuteMemoryTabButton.BackColor = Color.White;
				this.UserMarkTabButton.BackColor = Color.FromArgb(234, 235, 235);
			}
			this.ShowMuteMemoryTab();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000039BC File Offset: 0x00001BBC
		public void loadingProc()
		{
			this.activateFlag = false;
			this.userMark = new List<UserMarkPoint>();
			this.muteMemory = new List<MuteMemoryPoint>();
			UserMark[] array = ReadRDVersionInfo.UserMarkRead(this.uart, this.modelInfo, this.LoadingProgressBar);
			SafetyControl.SetValue(this.LoadingProgressBar, 0);
			MuteMemory[] array2 = ReadRDVersionInfo.MuteMemoryRead(this.uart, this.modelInfo, this.LoadingProgressBar);
			SafetyControl.SetValue(this.LoadingProgressBar, 0);
			MuteMemory[] array3 = ReadRDVersionInfo.AutoMuteMemoryRead(this.uart, this.modelInfo, this.LoadingProgressBar);
			SafetyControl.SetValue(this.LoadingProgressBar, 0);
			SafetyControl.SetVisible(this.LoadingProgressBar, false);
			if (array != null)
			{
				this.userMarkConfig(array);
			}
			if (array2 != null && array3 != null)
			{
				this.muteMemoryConfig(array2, array3);
			}
			BUTTON_TAB button_TAB = this.currentTab;
			if (button_TAB != BUTTON_TAB.USER_MARK_TAB)
			{
				if (button_TAB == BUTTON_TAB.MUTE_MEMORY_TAB)
				{
					this.ShowMuteMemoryTab();
				}
			}
			else
			{
				this.ShowUserMarkTab();
			}
			this.activateFlag = true;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003A9C File Offset: 0x00001C9C
		public void muteMemoryConfig(MuteMemory[] loadedMuteMemory, MuteMemory[] loadedAutoMuteMemory)
		{
			foreach (MuteMemory muteMemory in loadedMuteMemory)
			{
				MuteMemoryPoint muteMemoryPoint = new MuteMemoryPoint(muteMemory, this.isDarkMode);
				this.muteMemory.Add(muteMemoryPoint);
				muteMemoryPoint.Click += this.MuteMemoryButton_Click;
				SafetyControl.invokeScript(this.browser, "addMuteMemory", new object[]
				{
					muteMemory.lat,
					muteMemory.lng,
					muteMemory.band,
					muteMemory.freq
				});
			}
			foreach (MuteMemory muteMemory2 in loadedAutoMuteMemory)
			{
				MuteMemoryPoint muteMemoryPoint2 = new MuteMemoryPoint(muteMemory2, this.isDarkMode);
				this.muteMemory.Add(muteMemoryPoint2);
				muteMemoryPoint2.Click += this.MuteMemoryButton_Click;
				SafetyControl.invokeScript(this.browser, "addAutoMuteMemory", new object[]
				{
					muteMemory2.lat,
					muteMemory2.lng,
					muteMemory2.band,
					muteMemory2.freq,
					muteMemory2.autoMuteCnt
				});
			}
			base.SuspendLayout();
			SafetyControl.ControlAdd(this.MuteMemoryTabPanel, this.muteMemory.ToArray());
			base.ResumeLayout(false);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003C00 File Offset: 0x00001E00
		public void userMarkConfig(UserMark[] loadedUserMark)
		{
			foreach (UserMark userMark in loadedUserMark)
			{
				this.userMark.Add(new UserMarkPoint(userMark, this.isDarkMode));
				SafetyControl.invokeScript(this.browser, "addUserMark", new object[]
				{
					userMark.lat,
					userMark.lng
				});
			}
			foreach (UserMarkPoint userMarkPoint in this.userMark)
			{
				userMarkPoint.Click += this.UserMarkButton_Click;
			}
			SafetyControl.ControlAdd(this.UserMarkTabPanel, this.userMark.ToArray());
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public void InitMap()
		{
			this.loadingThread = new Thread(new ThreadStart(this.loadingProc));
			this.loadingThread.Start();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003CF4 File Offset: 0x00001EF4
		public void UnSelectMuteMemoryPoint(object index)
		{
			this.MuteMemoryTabButton_Click(null, null);
			SafetyControl.SetActiveControl(this, this.muteMemory[(int)index]);
			this.muteMemory[(int)index].BackColor = Color.Transparent;
			if (this.isDarkMode)
			{
				this.muteMemory[(int)index].FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				this.muteMemory[(int)index].FlatAppearance.MouseDownBackColor = Color.FromArgb(110, 110, 110);
			}
			this.muteMemory[(int)index].isSelected = false;
			this.TabScrollBar.Value = SafetyControl.GetVerticalScrollValue(this.MuteMemoryTabPanel);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003DBC File Offset: 0x00001FBC
		public void SelectMuteMemoryPoint(object index)
		{
			this.MuteMemoryTabButton_Click(null, null);
			SafetyControl.SetActiveControl(this, this.muteMemory[(int)index]);
			this.muteMemory[(int)index].BackColor = Color.Green;
			if (this.isDarkMode)
			{
				this.muteMemory[(int)index].FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 130, 0);
				this.muteMemory[(int)index].FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 110, 0);
			}
			this.muteMemory[(int)index].isSelected = true;
			this.TabScrollBar.Value = SafetyControl.GetVerticalScrollValue(this.MuteMemoryTabPanel);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003E84 File Offset: 0x00002084
		public void UnSelectUserMarkPoint(object index)
		{
			this.UserMarkTabButton_Click(null, null);
			SafetyControl.SetActiveControl(this, this.userMark[(int)index]);
			this.userMark[(int)index].BackColor = Color.Transparent;
			if (this.isDarkMode)
			{
				this.userMark[(int)index].FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				this.userMark[(int)index].FlatAppearance.MouseDownBackColor = Color.FromArgb(110, 110, 110);
			}
			this.userMark[(int)index].isSelected = true;
			this.TabScrollBar.Value = SafetyControl.GetVerticalScrollValue(this.UserMarkTabPanel);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003F4C File Offset: 0x0000214C
		public void ClickUserMarkPoint(object index)
		{
			this.UserMarkTabButton_Click(null, null);
			SafetyControl.SetActiveControl(this, this.userMark[(int)index]);
			this.userMark[(int)index].BackColor = Color.Green;
			if (this.isDarkMode)
			{
				this.userMark[(int)index].FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 130, 0);
				this.userMark[(int)index].FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 110, 0);
			}
			this.userMark[(int)index].isSelected = true;
			this.TabScrollBar.Value = SafetyControl.GetVerticalScrollValue(this.UserMarkTabPanel);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004014 File Offset: 0x00002214
		public void ClickUserAddMuteMemoryPoint(object lat, object lng)
		{
			float lat2 = (float)((double)lat);
			float lng2 = (float)((double)lng);
			GPSDataSettingAddMuteMemForm gpsdataSettingAddMuteMemForm = new GPSDataSettingAddMuteMemForm(this.isDarkMode);
			if (SafetyControl.FormShowDialogSync(this, gpsdataSettingAddMuteMemForm) == DialogResult.Yes)
			{
				MuteMemory muteMemory = new MuteMemory(lat2, lng2, gpsdataSettingAddMuteMemForm.freq);
				MuteMemoryPoint muteMemoryPoint = new MuteMemoryPoint(muteMemory, this.isDarkMode);
				this.muteMemory.Add(new MuteMemoryPoint(muteMemory, this.isDarkMode));
				muteMemoryPoint.Click += this.MuteMemoryButton_Click;
				SafetyControl.invokeScript(this.browser, "addMuteMemory", new object[]
				{
					muteMemory.lat,
					muteMemory.lng,
					muteMemory.band,
					muteMemory.freq
				});
				SafetyControl.ControlAddSync(this.MuteMemoryTabPanel, muteMemoryPoint);
				SafetyControl.BringToFront(muteMemoryPoint);
				this.MuteMemoryButton_Click(muteMemoryPoint, null);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000040F8 File Offset: 0x000022F8
		public void ClickUserAddUserMarkPoint(object lat, object lng)
		{
			float lat2 = (float)((double)lat);
			float lng2 = (float)((double)lng);
			UserMark userMark = new UserMark(lat2, lng2);
			UserMarkPoint userMarkPoint = new UserMarkPoint(userMark, this.isDarkMode);
			SafetyControl.invokeScript(this.browser, "addUserMark", new object[]
			{
				userMark.lat,
				userMark.lng
			});
			this.userMark.Add(userMarkPoint);
			userMarkPoint.Click += this.UserMarkButton_Click;
			SafetyControl.ControlAddSync(this.UserMarkTabPanel, userMarkPoint);
			SafetyControl.BringToFront(userMarkPoint);
			this.UserMarkButton_Click(userMarkPoint, null);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004194 File Offset: 0x00002394
		public void ClickDeleteMuteMemoryPoint(object index)
		{
			SafetyControl.ControlRemoveSync(this.MuteMemoryTabPanel, this.muteMemory[(int)index]);
			this.muteMemory.Remove(this.muteMemory[(int)index]);
			if (this.muteMemory.Count * 40 - this.MuteMemoryTabPanel.Size.Height > 0)
			{
				SafetyControl.SetVisible(this.TabScrollBar, true);
				this.TabScrollBar.Height = this.MuteMemoryTabPanel.Size.Height;
				this.TabScrollBar.Minimum = this.MuteMemoryTabPanel.VerticalScroll.Minimum;
				this.TabScrollBar.Maximum = this.MuteMemoryTabPanel.VerticalScroll.Maximum;
				this.TabScrollBar.LargeChange = this.MuteMemoryTabPanel.VerticalScroll.LargeChange;
				this.TabScrollBar.SmallChange = this.MuteMemoryTabPanel.VerticalScroll.SmallChange;
				this.TabScrollBar.Value = this.MuteMemoryTabPanel.VerticalScroll.Value;
				return;
			}
			SafetyControl.SetVisible(this.TabScrollBar, false);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000042C0 File Offset: 0x000024C0
		public void ClickDeleteUserMarkPoint(object index)
		{
			SafetyControl.ControlRemoveSync(this.UserMarkTabPanel, this.userMark[(int)index]);
			this.userMark.Remove(this.userMark[(int)index]);
			if (this.userMark.Count * 40 - this.UserMarkTabPanel.Size.Height > 0)
			{
				SafetyControl.SetVisible(this.TabScrollBar, true);
				this.TabScrollBar.Height = this.UserMarkTabPanel.Size.Height;
				this.TabScrollBar.Minimum = this.UserMarkTabPanel.VerticalScroll.Minimum;
				this.TabScrollBar.Maximum = this.UserMarkTabPanel.VerticalScroll.Maximum;
				this.TabScrollBar.LargeChange = this.UserMarkTabPanel.VerticalScroll.LargeChange;
				this.TabScrollBar.SmallChange = this.UserMarkTabPanel.VerticalScroll.SmallChange;
				this.TabScrollBar.Value = this.UserMarkTabPanel.VerticalScroll.Value;
				return;
			}
			SafetyControl.SetVisible(this.TabScrollBar, false);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000043EC File Offset: 0x000025EC
		private void PointMergeProc(object args)
		{
			SafetyControl.SetUseWaitCursor(this, true);
			this.activateFlag = false;
			// DECOMPILE-FIX: Preserve the original unused newarr/pop; the existing _ field prevents a discard.
			object[] unusedAllocation = new object[3];
			Array array = (Array)args;
			UserMark[] readUsrMrk = (UserMark[])array.GetValue(0);
			MuteMemory[] readMuteMem = (MuteMemory[])array.GetValue(1);
			bool usrMrkMergeFlag = (bool)array.GetValue(2);
			bool muteMemMergeFlag = (bool)array.GetValue(3);
			bool onlyMergeAutoMuteCnt = (bool)array.GetValue(4);
			bool rangeOverlapMergeFlag = (bool)array.GetValue(5);
			this.MergeFilePoint(readUsrMrk, readMuteMem, usrMrkMergeFlag, muteMemMergeFlag, onlyMergeAutoMuteCnt, rangeOverlapMergeFlag);
			BUTTON_TAB button_TAB = this.currentTab;
			if (button_TAB != BUTTON_TAB.USER_MARK_TAB)
			{
				if (button_TAB == BUTTON_TAB.MUTE_MEMORY_TAB)
				{
					this.ShowMuteMemoryTab();
				}
			}
			else
			{
				this.ShowUserMarkTab();
			}
			this.activateFlag = true;
			SafetyControl.SetUseWaitCursor(this, false);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000044A0 File Offset: 0x000026A0
		private double distance(double lat1, double lon1, double lat2, double lon2)
		{
			double deg = lon1 - lon2;
			double num = Math.Sin(this.deg2rad(lat1)) * Math.Sin(this.deg2rad(lat2)) + Math.Cos(this.deg2rad(lat1)) * Math.Cos(this.deg2rad(lat2)) * Math.Cos(this.deg2rad(deg));
			num = Math.Acos(num);
			num = this.rad2deg(num);
			num = num * 60.0 * 1.1515;
			return num * 1609.344;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004525 File Offset: 0x00002725
		private double deg2rad(double deg)
		{
			return deg * 3.141592653589793 / 180.0;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000453C File Offset: 0x0000273C
		private double rad2deg(double rad)
		{
			return rad * 180.0 / 3.141592653589793;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004554 File Offset: 0x00002754
		public void MergeFilePoint(UserMark[] readUsrMrk, MuteMemory[] readMuteMem, bool usrMrkMergeFlag, bool MuteMemMergeFlag, bool onlyMergeAutoMuteCnt3, bool rangeOverlapMergeFlag)
		{
			int count = this.userMark.Count;
			int count2 = this.muteMemory.Count;
			SafetyControl.SetVisible(this.LoadingProgressBar, true);
			ProgressBarAsync progressBarAsync = new ProgressBarAsync(this.LoadingProgressBar, 0, 1000, readUsrMrk.Length + readMuteMem.Length, null);
			progressBarAsync.Start();
			if (readUsrMrk != null && readUsrMrk.Length != 0 && usrMrkMergeFlag)
			{
				for (int i = 0; i < readUsrMrk.Length; i++)
				{
					UserMarkPoint userMarkPoint = new UserMarkPoint(readUsrMrk[i], this.isDarkMode);
					this.userMark.Add(userMarkPoint);
					userMarkPoint.Click += this.UserMarkButton_Click;
					SafetyControl.invokeScript(this.browser, "addUserMark", new object[]
					{
						userMarkPoint.info.lat,
						userMarkPoint.info.lng
					});
					SafetyControl.ControlAddSync(this.UserMarkTabPanel, userMarkPoint);
					progressBarAsync.SetSendCnt(1, true);
				}
			}
			if (readMuteMem != null && readMuteMem.Length != 0 && MuteMemMergeFlag)
			{
				foreach (MuteMemory muteMemory in readMuteMem)
				{
					bool flag = false;
					if (muteMemory.isAutoMuteMemory && muteMemory.autoMuteCnt < 3 && onlyMergeAutoMuteCnt3)
					{
						flag = true;
					}
					if (rangeOverlapMergeFlag)
					{
						foreach (MuteMemoryPoint muteMemoryPoint in this.muteMemory)
						{
							if (Math.Abs(this.distance((double)muteMemory.lat, (double)muteMemory.lng, (double)muteMemoryPoint.info.lat, (double)muteMemoryPoint.info.lng)) <= 200.0 && Math.Abs(muteMemory.freq - muteMemoryPoint.info.freq) <= 10)
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						progressBarAsync.SetSendCnt(1, true);
					}
					else
					{
						MuteMemoryPoint muteMemoryPoint2 = new MuteMemoryPoint(muteMemory, this.isDarkMode);
						this.muteMemory.Add(muteMemoryPoint2);
						muteMemoryPoint2.Click += this.MuteMemoryButton_Click;
						if (muteMemory.isAutoMuteMemory)
						{
							SafetyControl.invokeScript(this.browser, "addAutoMuteMemory", new object[]
							{
								muteMemory.lat,
								muteMemory.lng,
								muteMemory.band,
								muteMemory.freqStr,
								muteMemory.autoMuteCnt
							});
						}
						else
						{
							SafetyControl.invokeScript(this.browser, "addMuteMemory", new object[]
							{
								muteMemory.lat,
								muteMemory.lng,
								muteMemory.band,
								muteMemory.freqStr
							});
						}
						SafetyControl.ControlAddSync(this.MuteMemoryTabPanel, muteMemoryPoint2);
						progressBarAsync.SetSendCnt(1, true);
					}
				}
			}
			progressBarAsync.Stop();
			SafetyControl.SetVisible(this.LoadingProgressBar, false);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000485C File Offset: 0x00002A5C
		public void MuteMemoryButton_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.muteMemory.Count; i++)
			{
				if (sender.Equals(this.muteMemory[i]))
				{
					SafetyControl.invokeScript(this.browser, "setCameraMuteMemory", new object[]
					{
						i,
						this.muteMemory[i].info.lat,
						this.muteMemory[i].info.lng
					});
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000048F4 File Offset: 0x00002AF4
		public void UserMarkButton_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.userMark.Count; i++)
			{
				if (sender.Equals(this.userMark[i]))
				{
					SafetyControl.invokeScript(this.browser, "setCameraUserMark", new object[]
					{
						i,
						this.userMark[i].info.lat,
						this.userMark[i].info.lng
					});
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000498C File Offset: 0x00002B8C
		private void GPSDataLoadFromUnitButton_Click(object sender, EventArgs e)
		{
			if (!this.activateFlag)
			{
				return;
			}
			if (this.userMark != null)
			{
				foreach (UserMarkPoint childControl in this.userMark)
				{
					SafetyControl.ControlRemove(this.UserMarkTabPanel, childControl);
				}
			}
			if (this.muteMemory != null)
			{
				foreach (MuteMemoryPoint childControl2 in this.muteMemory)
				{
					SafetyControl.ControlRemove(this.MuteMemoryTabPanel, childControl2);
				}
			}
			SafetyControl.SetVisible(this.TabScrollBar, false);
			SafetyControl.invokeScript(this.browser, "allPointDelAndReload", new object[0]);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004A68 File Offset: 0x00002C68
		private void GPSDataStoreToUnitButton_Click(object sender, EventArgs e)
		{
			bool flag = this.activateFlag;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004A74 File Offset: 0x00002C74
		private void GPSDataOpenFileButton_Click(object sender, EventArgs e)
		{
			UserMark[] array = null;
			MuteMemory[] array2 = null;
			if (!this.activateFlag)
			{
				return;
			}
			this.OpenFileDialog.Filter = "txt files|*.txt";
			this.OpenFileDialog.FileName = "";
			if (this.OpenFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string[] array3 = File.ReadAllText(this.OpenFileDialog.FileName).Split(new string[]
			{
				"\r\n"
			}, StringSplitOptions.None);
			try
			{
				for (int i = 0; i < array3.Length; i++)
				{
					string[] array4 = array3[i].Split(new char[]
					{
						','
					});
					if (array4[0].Equals("User Mark"))
					{
						array = new UserMark[int.Parse(array4[1])];
						int j;
						for (j = 0; j < array.Length; j++)
						{
							string[] array5 = array3[i + j + 1].Split(new char[]
							{
								','
							});
							array[j] = new UserMark(float.Parse(array5[0]), float.Parse(array5[1]));
						}
						i += j;
					}
					else
					{
						if (!array4[0].Equals("Mute Memory"))
						{
							break;
						}
						array2 = new MuteMemory[int.Parse(array4[1])];
						int j;
						for (j = 0; j < array2.Length; j++)
						{
							string[] array5 = array3[i + j + 1].Split(new char[]
							{
								','
							});
							string text = array5[0];
							float lat = float.Parse(array5[1]);
							float lng = float.Parse(array5[2]);
							int num = int.Parse(array5[3]);
							bool flag = bool.Parse(array5[4]);
							if (text.Equals("MRCD"))
							{
								num += 5000;
							}
							if (flag)
							{
								int autoMuteCnt = int.Parse(array5[5]);
								array2[j] = new MuteMemory(lat, lng, num, flag, autoMuteCnt);
							}
							else
							{
								array2[j] = new MuteMemory(lat, lng, num);
							}
						}
						i += j;
					}
					if (i == array3.Length - 1)
					{
						object parameter = new object[]
						{
							array,
							array2,
							true,
							true,
							false,
							false
						};
						this.pointMergeThread = new Thread(new ParameterizedThreadStart(this.PointMergeProc));
						this.pointMergeThread.Start(parameter);
						return;
					}
				}
				SafetyControl.MessageBoxShowSync(this, "Invalid file", "File open error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			catch
			{
				SafetyControl.MessageBoxShowSync(this, "Invalid file", "File open error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004CF0 File Offset: 0x00002EF0
		private void GPSDataSaveFileButton_Click(object sender, EventArgs e)
		{
			if (!this.activateFlag)
			{
				return;
			}
			GPSDataSettingSaveFileOptionForm gpsdataSettingSaveFileOptionForm = new GPSDataSettingSaveFileOptionForm(this.isDarkMode);
			if (SafetyControl.FormShowDialogSync(this, gpsdataSettingSaveFileOptionForm) == DialogResult.Yes)
			{
				this.SaveFileDialog.Filter = "txt files|*.txt";
				this.SaveFileDialog.FileName = "";
				if (this.SaveFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				FileStream fileStream = new FileStream(this.SaveFileDialog.FileName, FileMode.Create, FileAccess.Write);
				if (gpsdataSettingSaveFileOptionForm.userMarkSave)
				{
					fileStream.Write(Encoding.UTF8.GetBytes("User Mark"), 0, "User Mark".Length);
					fileStream.Write(Encoding.UTF8.GetBytes("," + this.userMark.Count.ToString()), 0, this.userMark.Count.ToString().Length + 1);
					fileStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, 2);
					for (int i = 0; i < this.userMark.Count; i++)
					{
						fileStream.Write(Encoding.UTF8.GetBytes(string.Format("{0}", this.userMark[i].info.lat)), 0, string.Format("{0}", this.userMark[i].info.lat).Length);
						fileStream.Write(Encoding.UTF8.GetBytes("," + string.Format("{0}", this.userMark[i].info.lng)), 0, string.Format("{0}", this.userMark[i].info.lng).Length + 1);
						if (i != this.muteMemory.Count - 1)
						{
							fileStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, 2);
						}
					}
				}
				if (gpsdataSettingSaveFileOptionForm.muteMemorySave)
				{
					fileStream.Write(Encoding.UTF8.GetBytes("Mute Memory"), 0, "Mute Memory".Length);
					fileStream.Write(Encoding.UTF8.GetBytes("," + this.muteMemory.Count.ToString()), 0, this.muteMemory.Count.ToString().Length + 1);
					fileStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, 2);
					for (int i = 0; i < this.muteMemory.Count; i++)
					{
						fileStream.Write(Encoding.UTF8.GetBytes(this.muteMemory[i].info.band), 0, this.muteMemory[i].info.band.Length);
						fileStream.Write(Encoding.UTF8.GetBytes("," + string.Format("{0}", this.muteMemory[i].info.lat)), 0, string.Format("{0}", this.muteMemory[i].info.lat).Length + 1);
						fileStream.Write(Encoding.UTF8.GetBytes("," + string.Format("{0}", this.muteMemory[i].info.lng)), 0, string.Format("{0}", this.muteMemory[i].info.lng).Length + 1);
						fileStream.Write(Encoding.UTF8.GetBytes("," + this.muteMemory[i].info.freq.ToString()), 0, this.muteMemory[i].info.freq.ToString().Length + 1);
						fileStream.Write(Encoding.UTF8.GetBytes("," + this.muteMemory[i].info.isAutoMuteMemory.ToString()), 0, this.muteMemory[i].info.isAutoMuteMemory.ToString().Length + 1);
						if (this.muteMemory[i].info.isAutoMuteMemory)
						{
							fileStream.Write(Encoding.UTF8.GetBytes("," + this.muteMemory[i].info.autoMuteCnt.ToString()), 0, this.muteMemory[i].info.autoMuteCnt.ToString().Length + 1);
						}
						if (i != this.muteMemory.Count - 1)
						{
							fileStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, 2);
						}
					}
				}
				fileStream.Close();
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005207 File Offset: 0x00003407
		public void MinimizeButton_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005210 File Offset: 0x00003410
		public void MaximizeButton_Click(object sender, EventArgs e)
		{
			if (this.togleMaximizeFlag)
			{
				base.WindowState = FormWindowState.Maximized;
				this.togleMaximizeFlag = false;
				return;
			}
			base.WindowState = FormWindowState.Normal;
			this.togleMaximizeFlag = true;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005237 File Offset: 0x00003437
		public void CloseButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005240 File Offset: 0x00003440
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

		// Token: 0x0600003E RID: 62 RVA: 0x0000529C File Offset: 0x0000349C
		public void FormMouseMove(object sender, MouseEventArgs e)
		{
			if (this.TagMove)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.MValX, Control.MousePosition.Y - this.MValY);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000052DF File Offset: 0x000034DF
		public void FormMouseUp(object sender, MouseEventArgs e)
		{
			this.TagMove = false;
		}

		// Token: 0x04000015 RID: 21
		public Thread loadingThread;

		// Token: 0x04000016 RID: 22
		public Thread pointMergeThread;

		// Token: 0x04000017 RID: 23
		public bool activateFlag;

		// Token: 0x04000018 RID: 24
		private UARTCommUtils uart;

		// Token: 0x04000019 RID: 25
		private RDInfo modelInfo;

		// Token: 0x0400001A RID: 26
		public List<MuteMemoryPoint> muteMemory;

		// Token: 0x0400001B RID: 27
		public List<UserMarkPoint> userMark;

		// Token: 0x0400001C RID: 28
		public bool TagMove;

		// Token: 0x0400001D RID: 29
		public int MValX;

		// Token: 0x0400001E RID: 30
		public int MValY;

		// Token: 0x0400001F RID: 31
		public bool isDarkMode;

		// Token: 0x04000020 RID: 32
		public BUTTON_TAB currentTab;

		// Token: 0x04000021 RID: 33
		public WebBrowser browser;

		// Token: 0x04000022 RID: 34
		private const int HTLEFT = 10;

		// Token: 0x04000023 RID: 35
		private const int HTRIGHT = 11;

		// Token: 0x04000024 RID: 36
		private const int HTTOP = 12;

		// Token: 0x04000025 RID: 37
		private const int HTTOPLEFT = 13;

		// Token: 0x04000026 RID: 38
		private const int HTTOPRIGHT = 14;

		// Token: 0x04000027 RID: 39
		private const int HTBOTTOM = 15;

		// Token: 0x04000028 RID: 40
		private const int HTBOTTOMLEFT = 16;

		// Token: 0x04000029 RID: 41
		private const int HTBOTTOMRIGHT = 17;

		// Token: 0x0400002A RID: 42
		private const int _ = 7;

		// Token: 0x0400002B RID: 43
		private const int WM_NCHITTEST = 132;

		// Token: 0x0400002C RID: 44
		public bool togleMaximizeFlag = true;
	}
}
