namespace Uniden_R_Series_Tool
{
	// Token: 0x02000004 RID: 4
	// DECOMPILE-FIX: Type attributes are already declared in GPSDataSettingForm.cs;
	// keep one copy of ComVisible and the FullTrust demand, as in the original assembly.
	public partial class GPSDataSettingForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000052E8 File Offset: 0x000034E8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005308 File Offset: 0x00003508
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Uniden_R_Series_Tool.GPSDataSettingForm));
			this.SaveFileDialog = new global::System.Windows.Forms.SaveFileDialog();
			this.OpenFileDialog = new global::System.Windows.Forms.OpenFileDialog();
			this.MainPanel = new global::System.Windows.Forms.Panel();
			this.BrowserPanel = new global::System.Windows.Forms.Panel();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.TabPanel = new global::System.Windows.Forms.Panel();
			this.TabScrollBar = new global::CustomControls.CustomScrollbar();
			this.ButtonPanel = new global::System.Windows.Forms.Panel();
			this.NoDataLabel = new global::System.Windows.Forms.Label();
			this.MuteMemoryTabPanel = new global::System.Windows.Forms.Panel();
			this.UserMarkTabPanel = new global::System.Windows.Forms.Panel();
			this.panel11 = new global::System.Windows.Forms.Panel();
			this.MuteMemoryTabButton = new global::System.Windows.Forms.Button();
			this.UserMarkTabButton = new global::System.Windows.Forms.Button();
			this.panel9 = new global::System.Windows.Forms.Panel();
			this.ControlPanel = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.LoadingProgressBar = new global::CustomControls.ProgressAsync();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.CloseButton = new global::System.Windows.Forms.Button();
			this.GPSDataSaveFileButton = new global::System.Windows.Forms.Button();
			this.GPSDataOpenFileButton = new global::System.Windows.Forms.Button();
			this.GPSDataStoreToUnitButton = new global::System.Windows.Forms.Button();
			this.GPSDataLoadFromUnitButton = new global::System.Windows.Forms.Button();
			this.UpTilePanel = new global::System.Windows.Forms.Panel();
			this.MinimizeButton = new global::System.Windows.Forms.Button();
			this.MaximizeButton = new global::System.Windows.Forms.Button();
			this.UpCloseButton = new global::System.Windows.Forms.Button();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.MainPanel.SuspendLayout();
			this.panel5.SuspendLayout();
			this.TabPanel.SuspendLayout();
			this.ButtonPanel.SuspendLayout();
			this.panel11.SuspendLayout();
			this.ControlPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.UpTilePanel.SuspendLayout();
			base.SuspendLayout();
			this.OpenFileDialog.FileName = "openFileDialog1";
			this.MainPanel.BackColor = global::System.Drawing.Color.White;
			this.MainPanel.Controls.Add(this.BrowserPanel);
			this.MainPanel.Controls.Add(this.panel5);
			this.MainPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new global::System.Drawing.Point(1, 30);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Padding = new global::System.Windows.Forms.Padding(5, 5, 5, 0);
			this.MainPanel.Size = new global::System.Drawing.Size(997, 524);
			this.MainPanel.TabIndex = 3;
			this.BrowserPanel.BackColor = global::System.Drawing.Color.Transparent;
			this.BrowserPanel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.BrowserPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.BrowserPanel.Location = new global::System.Drawing.Point(205, 5);
			this.BrowserPanel.Name = "BrowserPanel";
			this.BrowserPanel.Size = new global::System.Drawing.Size(787, 519);
			this.BrowserPanel.TabIndex = 6;
			this.panel5.BackColor = global::System.Drawing.Color.Transparent;
			this.panel5.Controls.Add(this.TabPanel);
			this.panel5.Controls.Add(this.panel9);
			this.panel5.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new global::System.Drawing.Point(5, 5);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(200, 519);
			this.panel5.TabIndex = 3;
			this.TabPanel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TabPanel.Controls.Add(this.TabScrollBar);
			this.TabPanel.Controls.Add(this.ButtonPanel);
			this.TabPanel.Controls.Add(this.panel11);
			this.TabPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TabPanel.Location = new global::System.Drawing.Point(0, 0);
			this.TabPanel.Name = "TabPanel";
			this.TabPanel.Size = new global::System.Drawing.Size(195, 519);
			this.TabPanel.TabIndex = 4;
			this.TabPanel.SizeChanged += new global::System.EventHandler(this.TabPanel_SizeChanged);
			this.TabScrollBar.ArrowColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.TabScrollBar.BorderColor = global::System.Drawing.SystemColors.Control;
			this.TabScrollBar.ButtonFaceColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.TabScrollBar.ChannelColor = global::System.Drawing.SystemColors.Control;
			this.TabScrollBar.LargeChange = 10;
			this.TabScrollBar.Location = new global::System.Drawing.Point(175, 36);
			this.TabScrollBar.Maximum = 100;
			this.TabScrollBar.Minimum = 0;
			this.TabScrollBar.MinimumSize = new global::System.Drawing.Size(18, 100);
			this.TabScrollBar.Name = "TabScrollBar";
			this.TabScrollBar.Size = new global::System.Drawing.Size(18, 481);
			this.TabScrollBar.SmallChange = 1;
			this.TabScrollBar.TabIndex = 0;
			this.TabScrollBar.ThumbColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.TabScrollBar.Value = 0;
			this.TabScrollBar.Visible = false;
			this.ButtonPanel.Controls.Add(this.NoDataLabel);
			this.ButtonPanel.Controls.Add(this.MuteMemoryTabPanel);
			this.ButtonPanel.Controls.Add(this.UserMarkTabPanel);
			this.ButtonPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonPanel.Location = new global::System.Drawing.Point(0, 36);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new global::System.Drawing.Size(193, 481);
			this.ButtonPanel.TabIndex = 1;
			this.NoDataLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.NoDataLabel.ForeColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.NoDataLabel.Location = new global::System.Drawing.Point(0, 0);
			this.NoDataLabel.Name = "NoDataLabel";
			this.NoDataLabel.Size = new global::System.Drawing.Size(193, 481);
			this.NoDataLabel.TabIndex = 0;
			this.NoDataLabel.Text = "No Data\r\n";
			this.NoDataLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.MuteMemoryTabPanel.AutoScroll = true;
			this.MuteMemoryTabPanel.BackColor = global::System.Drawing.Color.Transparent;
			this.MuteMemoryTabPanel.Location = new global::System.Drawing.Point(0, 0);
			this.MuteMemoryTabPanel.Name = "MuteMemoryTabPanel";
			this.MuteMemoryTabPanel.Size = new global::System.Drawing.Size(193, 481);
			this.MuteMemoryTabPanel.TabIndex = 2;
			this.UserMarkTabPanel.AutoScroll = true;
			this.UserMarkTabPanel.BackColor = global::System.Drawing.Color.Transparent;
			this.UserMarkTabPanel.Location = new global::System.Drawing.Point(0, 0);
			this.UserMarkTabPanel.Name = "UserMarkTabPanel";
			this.UserMarkTabPanel.Size = new global::System.Drawing.Size(193, 481);
			this.UserMarkTabPanel.TabIndex = 1;
			this.panel11.Controls.Add(this.MuteMemoryTabButton);
			this.panel11.Controls.Add(this.UserMarkTabButton);
			this.panel11.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel11.Location = new global::System.Drawing.Point(0, 0);
			this.panel11.Name = "panel11";
			this.panel11.Size = new global::System.Drawing.Size(193, 36);
			this.panel11.TabIndex = 0;
			this.MuteMemoryTabButton.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.MuteMemoryTabButton.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.MuteMemoryTabButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.MuteMemoryTabButton.FlatAppearance.BorderSize = 0;
			this.MuteMemoryTabButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.White;
			this.MuteMemoryTabButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.White;
			this.MuteMemoryTabButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.MuteMemoryTabButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.MuteMemoryTabButton.ForeColor = global::System.Drawing.Color.Black;
			this.MuteMemoryTabButton.Location = new global::System.Drawing.Point(98, 0);
			this.MuteMemoryTabButton.Name = "MuteMemoryTabButton";
			this.MuteMemoryTabButton.Size = new global::System.Drawing.Size(95, 36);
			this.MuteMemoryTabButton.TabIndex = 43;
			this.MuteMemoryTabButton.Text = "Mute Memory";
			this.MuteMemoryTabButton.UseVisualStyleBackColor = false;
			this.MuteMemoryTabButton.Click += new global::System.EventHandler(this.MuteMemoryTabButton_Click);
			this.UserMarkTabButton.BackColor = global::System.Drawing.Color.White;
			this.UserMarkTabButton.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.UserMarkTabButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.UserMarkTabButton.FlatAppearance.BorderSize = 0;
			this.UserMarkTabButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.White;
			this.UserMarkTabButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.White;
			this.UserMarkTabButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.UserMarkTabButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.UserMarkTabButton.ForeColor = global::System.Drawing.Color.Black;
			this.UserMarkTabButton.Location = new global::System.Drawing.Point(0, 0);
			this.UserMarkTabButton.Name = "UserMarkTabButton";
			this.UserMarkTabButton.Size = new global::System.Drawing.Size(95, 36);
			this.UserMarkTabButton.TabIndex = 42;
			this.UserMarkTabButton.Text = "User Mark";
			this.UserMarkTabButton.UseVisualStyleBackColor = false;
			this.UserMarkTabButton.Click += new global::System.EventHandler(this.UserMarkTabButton_Click);
			this.panel9.BackColor = global::System.Drawing.Color.Transparent;
			this.panel9.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panel9.Location = new global::System.Drawing.Point(195, 0);
			this.panel9.Name = "panel9";
			this.panel9.Size = new global::System.Drawing.Size(5, 519);
			this.panel9.TabIndex = 3;
			this.ControlPanel.BackColor = global::System.Drawing.Color.White;
			this.ControlPanel.Controls.Add(this.panel3);
			this.ControlPanel.Controls.Add(this.panel4);
			this.ControlPanel.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.ControlPanel.Location = new global::System.Drawing.Point(1, 554);
			this.ControlPanel.Name = "ControlPanel";
			this.ControlPanel.Padding = new global::System.Windows.Forms.Padding(6, 0, 6, 6);
			this.ControlPanel.Size = new global::System.Drawing.Size(997, 50);
			this.ControlPanel.TabIndex = 3;
			this.panel3.Controls.Add(this.LoadingProgressBar);
			this.panel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new global::System.Drawing.Point(6, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(274, 44);
			this.panel3.TabIndex = 1;
			this.LoadingProgressBar.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.LoadingProgressBar.Location = new global::System.Drawing.Point(4, 15);
			this.LoadingProgressBar.Name = "LoadingProgressBar";
			this.LoadingProgressBar.Size = new global::System.Drawing.Size(263, 22);
			this.LoadingProgressBar.TabIndex = 0;
			this.panel4.Controls.Add(this.CloseButton);
			this.panel4.Controls.Add(this.GPSDataSaveFileButton);
			this.panel4.Controls.Add(this.GPSDataOpenFileButton);
			this.panel4.Controls.Add(this.GPSDataStoreToUnitButton);
			this.panel4.Controls.Add(this.GPSDataLoadFromUnitButton);
			this.panel4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new global::System.Drawing.Point(280, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(711, 44);
			this.panel4.TabIndex = 1;
			this.CloseButton.BackColor = global::System.Drawing.Color.Black;
			this.CloseButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.CloseButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.CloseButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.CloseButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.CloseButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.CloseButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.CloseButton.Location = new global::System.Drawing.Point(576, 13);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new global::System.Drawing.Size(130, 26);
			this.CloseButton.TabIndex = 41;
			this.CloseButton.TabStop = false;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new global::System.EventHandler(this.CloseButton_Click);
			this.GPSDataSaveFileButton.BackColor = global::System.Drawing.Color.Black;
			this.GPSDataSaveFileButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.GPSDataSaveFileButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.GPSDataSaveFileButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.GPSDataSaveFileButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.GPSDataSaveFileButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.GPSDataSaveFileButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.GPSDataSaveFileButton.Location = new global::System.Drawing.Point(424, 13);
			this.GPSDataSaveFileButton.Name = "GPSDataSaveFileButton";
			this.GPSDataSaveFileButton.Size = new global::System.Drawing.Size(130, 26);
			this.GPSDataSaveFileButton.TabIndex = 40;
			this.GPSDataSaveFileButton.TabStop = false;
			this.GPSDataSaveFileButton.Text = "Save file";
			this.GPSDataSaveFileButton.UseVisualStyleBackColor = false;
			this.GPSDataSaveFileButton.Click += new global::System.EventHandler(this.GPSDataSaveFileButton_Click);
			this.GPSDataOpenFileButton.BackColor = global::System.Drawing.Color.Black;
			this.GPSDataOpenFileButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.GPSDataOpenFileButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.GPSDataOpenFileButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.GPSDataOpenFileButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.GPSDataOpenFileButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.GPSDataOpenFileButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.GPSDataOpenFileButton.Location = new global::System.Drawing.Point(288, 13);
			this.GPSDataOpenFileButton.Name = "GPSDataOpenFileButton";
			this.GPSDataOpenFileButton.Size = new global::System.Drawing.Size(130, 26);
			this.GPSDataOpenFileButton.TabIndex = 39;
			this.GPSDataOpenFileButton.TabStop = false;
			this.GPSDataOpenFileButton.Text = "Open file";
			this.GPSDataOpenFileButton.UseVisualStyleBackColor = false;
			this.GPSDataOpenFileButton.Click += new global::System.EventHandler(this.GPSDataOpenFileButton_Click);
			this.GPSDataStoreToUnitButton.BackColor = global::System.Drawing.Color.Black;
			this.GPSDataStoreToUnitButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.GPSDataStoreToUnitButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.GPSDataStoreToUnitButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.GPSDataStoreToUnitButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.GPSDataStoreToUnitButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.GPSDataStoreToUnitButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.GPSDataStoreToUnitButton.Location = new global::System.Drawing.Point(152, 13);
			this.GPSDataStoreToUnitButton.Name = "GPSDataStoreToUnitButton";
			this.GPSDataStoreToUnitButton.Size = new global::System.Drawing.Size(130, 26);
			this.GPSDataStoreToUnitButton.TabIndex = 37;
			this.GPSDataStoreToUnitButton.TabStop = false;
			this.GPSDataStoreToUnitButton.Text = "Store to unit";
			this.GPSDataStoreToUnitButton.UseVisualStyleBackColor = false;
			this.GPSDataStoreToUnitButton.Click += new global::System.EventHandler(this.GPSDataStoreToUnitButton_Click);
			this.GPSDataLoadFromUnitButton.BackColor = global::System.Drawing.Color.Black;
			this.GPSDataLoadFromUnitButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.GPSDataLoadFromUnitButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.GPSDataLoadFromUnitButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.GPSDataLoadFromUnitButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.GPSDataLoadFromUnitButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.GPSDataLoadFromUnitButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.GPSDataLoadFromUnitButton.Location = new global::System.Drawing.Point(16, 13);
			this.GPSDataLoadFromUnitButton.Name = "GPSDataLoadFromUnitButton";
			this.GPSDataLoadFromUnitButton.Size = new global::System.Drawing.Size(130, 26);
			this.GPSDataLoadFromUnitButton.TabIndex = 3;
			this.GPSDataLoadFromUnitButton.TabStop = false;
			this.GPSDataLoadFromUnitButton.Text = "Load from unit";
			this.GPSDataLoadFromUnitButton.UseVisualStyleBackColor = false;
			this.GPSDataLoadFromUnitButton.Click += new global::System.EventHandler(this.GPSDataLoadFromUnitButton_Click);
			this.UpTilePanel.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.UpTilePanel.Controls.Add(this.MinimizeButton);
			this.UpTilePanel.Controls.Add(this.MaximizeButton);
			this.UpTilePanel.Controls.Add(this.UpCloseButton);
			this.UpTilePanel.Controls.Add(this.TitleLabel);
			this.UpTilePanel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.UpTilePanel.ForeColor = global::System.Drawing.Color.Black;
			this.UpTilePanel.Location = new global::System.Drawing.Point(1, 1);
			this.UpTilePanel.Name = "UpTilePanel";
			this.UpTilePanel.Size = new global::System.Drawing.Size(997, 29);
			this.UpTilePanel.TabIndex = 20;
			this.UpTilePanel.DoubleClick += new global::System.EventHandler(this.MaximizeButton_Click);
			this.UpTilePanel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.UpTilePanel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.UpTilePanel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.MinimizeButton.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.MinimizeButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.MinimizeButton.FlatAppearance.BorderSize = 0;
			this.MinimizeButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.MinimizeButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.MinimizeButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.MinimizeButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.MinimizeButton.Location = new global::System.Drawing.Point(901, 0);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.MinimizeButton.Size = new global::System.Drawing.Size(32, 29);
			this.MinimizeButton.TabIndex = 2;
			this.MinimizeButton.TabStop = false;
			this.MinimizeButton.Text = "─";
			this.MinimizeButton.UseVisualStyleBackColor = true;
			this.MinimizeButton.Click += new global::System.EventHandler(this.MinimizeButton_Click);
			this.MaximizeButton.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.MaximizeButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.MaximizeButton.FlatAppearance.BorderSize = 0;
			this.MaximizeButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.MaximizeButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.MaximizeButton.Font = new global::System.Drawing.Font("Microsoft Tai Le", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.MaximizeButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.MaximizeButton.Location = new global::System.Drawing.Point(933, 0);
			this.MaximizeButton.Name = "MaximizeButton";
			this.MaximizeButton.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.MaximizeButton.Size = new global::System.Drawing.Size(32, 29);
			this.MaximizeButton.TabIndex = 3;
			this.MaximizeButton.TabStop = false;
			this.MaximizeButton.Text = "□";
			this.MaximizeButton.UseVisualStyleBackColor = true;
			this.MaximizeButton.Click += new global::System.EventHandler(this.MaximizeButton_Click);
			this.UpCloseButton.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.UpCloseButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.UpCloseButton.FlatAppearance.BorderSize = 0;
			this.UpCloseButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.UpCloseButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.UpCloseButton.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f);
			this.UpCloseButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.UpCloseButton.Location = new global::System.Drawing.Point(965, 0);
			this.UpCloseButton.Name = "UpCloseButton";
			this.UpCloseButton.Size = new global::System.Drawing.Size(32, 29);
			this.UpCloseButton.TabIndex = 1;
			this.UpCloseButton.TabStop = false;
			this.UpCloseButton.Text = "X";
			this.UpCloseButton.UseVisualStyleBackColor = true;
			this.UpCloseButton.Click += new global::System.EventHandler(this.CloseButton_Click);
			this.TitleLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.TitleLabel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TitleLabel.Location = new global::System.Drawing.Point(24, 7);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new global::System.Drawing.Size(260, 16);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Point Editor";
			this.TitleLabel.DoubleClick += new global::System.EventHandler(this.MaximizeButton_Click);
			this.TitleLabel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.TitleLabel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.TitleLabel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			base.ClientSize = new global::System.Drawing.Size(999, 605);
			base.Controls.Add(this.MainPanel);
			base.Controls.Add(this.ControlPanel);
			base.Controls.Add(this.UpTilePanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(999, 605);
			base.Name = "GPSDataSettingForm";
			base.Padding = new global::System.Windows.Forms.Padding(1);
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Point Editor";
			base.Load += new global::System.EventHandler(this.GPSDataSetting_Load);
			this.MainPanel.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.TabPanel.ResumeLayout(false);
			this.ButtonPanel.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.ControlPanel.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.UpTilePanel.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400002D RID: 45
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400002E RID: 46
		public global::System.Windows.Forms.Panel MainPanel;

		// Token: 0x0400002F RID: 47
		public global::System.Windows.Forms.Panel ControlPanel;

		// Token: 0x04000030 RID: 48
		public global::CustomControls.ProgressAsync LoadingProgressBar;

		// Token: 0x04000031 RID: 49
		public global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000032 RID: 50
		public global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000033 RID: 51
		public global::System.Windows.Forms.SaveFileDialog SaveFileDialog;

		// Token: 0x04000034 RID: 52
		public global::System.Windows.Forms.Panel UpTilePanel;

		// Token: 0x04000035 RID: 53
		public global::System.Windows.Forms.Button MinimizeButton;

		// Token: 0x04000036 RID: 54
		public global::System.Windows.Forms.Button UpCloseButton;

		// Token: 0x04000037 RID: 55
		public global::System.Windows.Forms.Label TitleLabel;

		// Token: 0x04000038 RID: 56
		public global::System.Windows.Forms.Button MaximizeButton;

		// Token: 0x04000039 RID: 57
		public global::System.Windows.Forms.Panel panel5;

		// Token: 0x0400003A RID: 58
		public global::System.Windows.Forms.Button UserMarkTabButton;

		// Token: 0x0400003B RID: 59
		public global::System.Windows.Forms.Button MuteMemoryTabButton;

		// Token: 0x0400003C RID: 60
		public global::System.Windows.Forms.Panel TabPanel;

		// Token: 0x0400003D RID: 61
		public global::System.Windows.Forms.Panel UserMarkTabPanel;

		// Token: 0x0400003E RID: 62
		public global::System.Windows.Forms.Panel panel11;

		// Token: 0x0400003F RID: 63
		public global::System.Windows.Forms.Panel panel9;

		// Token: 0x04000040 RID: 64
		public global::System.Windows.Forms.Panel MuteMemoryTabPanel;

		// Token: 0x04000041 RID: 65
		public global::CustomControls.CustomScrollbar TabScrollBar;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Button GPSDataLoadFromUnitButton;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button GPSDataStoreToUnitButton;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Button GPSDataOpenFileButton;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Button GPSDataSaveFileButton;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Button CloseButton;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label NoDataLabel;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.OpenFileDialog OpenFileDialog;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Panel ButtonPanel;

		// Token: 0x0400004A RID: 74
		public global::System.Windows.Forms.Panel BrowserPanel;
	}
}
