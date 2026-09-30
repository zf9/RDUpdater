namespace Uniden_R_Series_Tool
{
	// Token: 0x02000011 RID: 17
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x0000E07C File Offset: 0x0000C27C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000E09C File Offset: 0x0000C29C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Uniden_R_Series_Tool.MainForm));
			this.firmwareFileOpenDialog = new global::System.Windows.Forms.OpenFileDialog();
			this.UpTilePanel = new global::System.Windows.Forms.Panel();
			this.MinimizeButton = new global::System.Windows.Forms.Button();
			this.UpCloseButton = new global::System.Windows.Forms.Button();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.LeftMenuPanel = new global::System.Windows.Forms.Panel();
			this.GPSDataSettingButton = new global::System.Windows.Forms.Button();
			this.UserSettingButton = new global::System.Windows.Forms.Button();
			this.MenuStatusUpdate = new global::System.Windows.Forms.Label();
			this.OptionButton = new global::System.Windows.Forms.Button();
			this.DownloadFilesButton = new global::System.Windows.Forms.Button();
			this.CloseButton = new global::System.Windows.Forms.Button();
			this.UpdateButton = new global::System.Windows.Forms.Button();
			this.LogoPictureBox = new global::System.Windows.Forms.PictureBox();
			this.MenuStatusOption = new global::System.Windows.Forms.Label();
			this.MenuStatusDloadFiles = new global::System.Windows.Forms.Label();
			this.UpdatePanel = new global::System.Windows.Forms.Panel();
			this.ReadVersionSTSLabel1 = new global::System.Windows.Forms.Label();
			this.LatestColonLable = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.SimpleStartUpdateButton = new global::System.Windows.Forms.Button();
			this.MainFileVersionLabel = new global::System.Windows.Forms.Label();
			this.constLabel1 = new global::System.Windows.Forms.Label();
			this.LatestVersionLabel = new global::System.Windows.Forms.Label();
			this.ConnectionStatusLabel = new global::System.Windows.Forms.Label();
			this.ModelNameLabel = new global::System.Windows.Forms.Label();
			this.constLabel11 = new global::System.Windows.Forms.Label();
			this.constLabel10 = new global::System.Windows.Forms.Label();
			this.MainVersionLabel = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.RDPictureBox = new global::System.Windows.Forms.PictureBox();
			this.DloadInternetSTSLabel = new global::System.Windows.Forms.Label();
			this.DownloadFilesPanel = new global::System.Windows.Forms.Panel();
			this.ConnectionStatus2Label = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.ConnectedVersionLabel = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.ReadVersionSTSLabel2 = new global::System.Windows.Forms.Label();
			this.currentVersionPeriLabel = new global::System.Windows.Forms.Label();
			this.ReadVersionButton = new global::System.Windows.Forms.Button();
			this.DetailConnectedModelLabel = new global::System.Windows.Forms.Label();
			this.DetailStartUpdateButton = new global::System.Windows.Forms.Button();
			this.RecoveryMode = new global::System.Windows.Forms.CheckBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.downloadFileVersionPeriLabel = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.DetailFileModelLabel = new global::System.Windows.Forms.Label();
			this.FilePathRichTextBox = new global::System.Windows.Forms.RichTextBox();
			this.FileOpenButton = new global::System.Windows.Forms.Button();
			this.FWFileVersionLabel = new global::System.Windows.Forms.Label();
			this.OptionPenal = new global::System.Windows.Forms.Panel();
			this.DarkModeCheckBox = new global::System.Windows.Forms.CheckBox();
			this.AutoConnectEnableCheckBox = new global::System.Windows.Forms.CheckBox();
			this.ToolVersionLabel = new global::System.Windows.Forms.Label();
			this.line1 = new global::System.Windows.Forms.Label();
			this.line2 = new global::System.Windows.Forms.Label();
			this.line3 = new global::System.Windows.Forms.Label();
			this.line4 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.MenuTabPanel = new global::System.Windows.Forms.TabControl();
			this.UpdateTab = new global::System.Windows.Forms.TabPage();
			this.DownloadFilesTab = new global::System.Windows.Forms.TabPage();
			this.OptionTab = new global::System.Windows.Forms.TabPage();
			this.UpdatesButton = new global::System.Windows.Forms.Button();
			this.MenuStatusUpdates = new global::System.Windows.Forms.Label();
			this.UpdatesTab = new global::System.Windows.Forms.TabPage();
			this.UpTilePanel.SuspendLayout();
			this.LeftMenuPanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
			this.UpdatePanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.RDPictureBox).BeginInit();
			this.DownloadFilesPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.OptionPenal.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.MenuTabPanel.SuspendLayout();
			this.UpdateTab.SuspendLayout();
			this.DownloadFilesTab.SuspendLayout();
			this.OptionTab.SuspendLayout();
			this.UpdatesTab.SuspendLayout();
			base.SuspendLayout();
			this.firmwareFileOpenDialog.FileName = "firmwareFileOpenDialog";
			this.UpTilePanel.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.UpTilePanel.Controls.Add(this.MinimizeButton);
			this.UpTilePanel.Controls.Add(this.UpCloseButton);
			this.UpTilePanel.Controls.Add(this.TitleLabel);
			componentResourceManager.ApplyResources(this.UpTilePanel, "UpTilePanel");
			this.UpTilePanel.ForeColor = global::System.Drawing.Color.Black;
			this.UpTilePanel.Name = "UpTilePanel";
			this.UpTilePanel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.UpTilePanel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.UpTilePanel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			componentResourceManager.ApplyResources(this.MinimizeButton, "MinimizeButton");
			this.MinimizeButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.MinimizeButton.FlatAppearance.BorderSize = 0;
			this.MinimizeButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.TabStop = false;
			this.MinimizeButton.UseVisualStyleBackColor = true;
			this.MinimizeButton.Click += new global::System.EventHandler(this.MinimizeButton_Click);
			componentResourceManager.ApplyResources(this.UpCloseButton, "UpCloseButton");
			this.UpCloseButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.UpCloseButton.FlatAppearance.BorderSize = 0;
			this.UpCloseButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.UpCloseButton.Name = "UpCloseButton";
			this.UpCloseButton.TabStop = false;
			this.UpCloseButton.UseVisualStyleBackColor = true;
			this.UpCloseButton.Click += new global::System.EventHandler(this.CloseButton_Click);
			componentResourceManager.ApplyResources(this.TitleLabel, "TitleLabel");
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.TitleLabel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.TitleLabel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.LeftMenuPanel.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.LeftMenuPanel.Controls.Add(this.GPSDataSettingButton);
			this.LeftMenuPanel.Controls.Add(this.UserSettingButton);
			this.LeftMenuPanel.Controls.Add(this.MenuStatusUpdate);
			this.LeftMenuPanel.Controls.Add(this.OptionButton);
			this.LeftMenuPanel.Controls.Add(this.UpdatesButton);
			this.LeftMenuPanel.Controls.Add(this.MenuStatusUpdates);
			this.LeftMenuPanel.Controls.Add(this.DownloadFilesButton);
			this.LeftMenuPanel.Controls.Add(this.CloseButton);
			this.LeftMenuPanel.Controls.Add(this.UpdateButton);
			this.LeftMenuPanel.Controls.Add(this.LogoPictureBox);
			this.LeftMenuPanel.Controls.Add(this.MenuStatusOption);
			this.LeftMenuPanel.Controls.Add(this.MenuStatusDloadFiles);
			componentResourceManager.ApplyResources(this.LeftMenuPanel, "LeftMenuPanel");
			this.LeftMenuPanel.ForeColor = global::System.Drawing.Color.Black;
			this.LeftMenuPanel.Name = "LeftMenuPanel";
			this.GPSDataSettingButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.GPSDataSettingButton.FlatAppearance.BorderSize = 0;
			this.GPSDataSettingButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			componentResourceManager.ApplyResources(this.GPSDataSettingButton, "GPSDataSettingButton");
			this.GPSDataSettingButton.ForeColor = global::System.Drawing.Color.Black;
			this.GPSDataSettingButton.Name = "GPSDataSettingButton";
			this.GPSDataSettingButton.TabStop = false;
			this.GPSDataSettingButton.UseVisualStyleBackColor = true;
			this.GPSDataSettingButton.Click += new global::System.EventHandler(this.GPSDataSettingButton_Click);
			this.UserSettingButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.UserSettingButton.FlatAppearance.BorderSize = 0;
			this.UserSettingButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			componentResourceManager.ApplyResources(this.UserSettingButton, "UserSettingButton");
			this.UserSettingButton.ForeColor = global::System.Drawing.Color.Black;
			this.UserSettingButton.Name = "UserSettingButton";
			this.UserSettingButton.TabStop = false;
			this.UserSettingButton.UseVisualStyleBackColor = true;
			this.UserSettingButton.Click += new global::System.EventHandler(this.UserSettingButton_Click);
			this.MenuStatusUpdate.BackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			componentResourceManager.ApplyResources(this.MenuStatusUpdate, "MenuStatusUpdate");
			this.MenuStatusUpdate.Name = "MenuStatusUpdate";
			this.OptionButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.OptionButton.FlatAppearance.BorderSize = 0;
			this.OptionButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			componentResourceManager.ApplyResources(this.OptionButton, "OptionButton");
			this.OptionButton.ForeColor = global::System.Drawing.Color.Black;
			this.OptionButton.Name = "OptionButton";
			this.OptionButton.TabStop = false;
			this.OptionButton.UseVisualStyleBackColor = true;
			this.OptionButton.Click += new global::System.EventHandler(this.OptionButton_Click);
			componentResourceManager.ApplyResources(this.UpdatesButton, "OptionButton");
			this.UpdatesButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.UpdatesButton.FlatAppearance.BorderSize = 0;
			this.UpdatesButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.UpdatesButton.ForeColor = global::System.Drawing.Color.Black;
			this.UpdatesButton.Location = new global::System.Drawing.Point(this.OptionButton.Left, this.OptionButton.Bottom);
			this.UpdatesButton.Name = "UpdatesButton";
			this.UpdatesButton.Text = "      Updates";
			this.UpdatesButton.TabStop = false;
			this.UpdatesButton.UseVisualStyleBackColor = true;
			this.UpdatesButton.Click += new global::System.EventHandler(this.UpdatesButton_Click);
			this.DownloadFilesButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.DownloadFilesButton.FlatAppearance.BorderSize = 0;
			this.DownloadFilesButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			componentResourceManager.ApplyResources(this.DownloadFilesButton, "DownloadFilesButton");
			this.DownloadFilesButton.ForeColor = global::System.Drawing.Color.Black;
			this.DownloadFilesButton.Name = "DownloadFilesButton";
			this.DownloadFilesButton.TabStop = false;
			this.DownloadFilesButton.UseVisualStyleBackColor = true;
			this.DownloadFilesButton.Click += new global::System.EventHandler(this.DownloadFilesButton_Click);
			componentResourceManager.ApplyResources(this.CloseButton, "CloseButton");
			this.CloseButton.FlatAppearance.BorderSize = 0;
			this.CloseButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.CloseButton.ForeColor = global::System.Drawing.Color.Black;
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.TabStop = false;
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new global::System.EventHandler(this.CloseButton_Click);
			this.UpdateButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.UpdateButton.FlatAppearance.BorderSize = 0;
			this.UpdateButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			componentResourceManager.ApplyResources(this.UpdateButton, "UpdateButton");
			this.UpdateButton.ForeColor = global::System.Drawing.Color.Black;
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.TabStop = false;
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new global::System.EventHandler(this.Update_Click);
			componentResourceManager.ApplyResources(this.LogoPictureBox, "LogoPictureBox");
			this.LogoPictureBox.Image = global::Uniden_R_Series_Tool.Properties.Resources.uniden_logo1;
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.LogoPictureBox.TabStop = false;
			componentResourceManager.ApplyResources(this.MenuStatusOption, "MenuStatusOption");
			this.MenuStatusOption.Name = "MenuStatusOption";
			componentResourceManager.ApplyResources(this.MenuStatusUpdates, "MenuStatusOption");
			this.MenuStatusUpdates.Location = new global::System.Drawing.Point(this.MenuStatusOption.Left, this.MenuStatusOption.Top + this.OptionButton.Height);
			this.MenuStatusUpdates.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.MenuStatusUpdates.Name = "MenuStatusUpdates";
			componentResourceManager.ApplyResources(this.MenuStatusDloadFiles, "MenuStatusDloadFiles");
			this.MenuStatusDloadFiles.Name = "MenuStatusDloadFiles";
			this.UpdatePanel.BackColor = global::System.Drawing.Color.White;
			this.UpdatePanel.Controls.Add(this.ReadVersionSTSLabel1);
			this.UpdatePanel.Controls.Add(this.LatestColonLable);
			this.UpdatePanel.Controls.Add(this.label1);
			this.UpdatePanel.Controls.Add(this.SimpleStartUpdateButton);
			this.UpdatePanel.Controls.Add(this.MainFileVersionLabel);
			this.UpdatePanel.Controls.Add(this.constLabel1);
			this.UpdatePanel.Controls.Add(this.LatestVersionLabel);
			this.UpdatePanel.Controls.Add(this.ConnectionStatusLabel);
			this.UpdatePanel.Controls.Add(this.ModelNameLabel);
			this.UpdatePanel.Controls.Add(this.constLabel11);
			this.UpdatePanel.Controls.Add(this.constLabel10);
			this.UpdatePanel.Controls.Add(this.MainVersionLabel);
			this.UpdatePanel.Controls.Add(this.label2);
			this.UpdatePanel.Controls.Add(this.RDPictureBox);
			this.UpdatePanel.Controls.Add(this.DloadInternetSTSLabel);
			componentResourceManager.ApplyResources(this.UpdatePanel, "UpdatePanel");
			this.UpdatePanel.Name = "UpdatePanel";
			this.ReadVersionSTSLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.ReadVersionSTSLabel1.ForeColor = global::System.Drawing.SystemColors.AppWorkspace;
			componentResourceManager.ApplyResources(this.ReadVersionSTSLabel1, "ReadVersionSTSLabel1");
			this.ReadVersionSTSLabel1.Name = "ReadVersionSTSLabel1";
			componentResourceManager.ApplyResources(this.LatestColonLable, "LatestColonLable");
			this.LatestColonLable.ForeColor = global::System.Drawing.Color.Black;
			this.LatestColonLable.Name = "LatestColonLable";
			this.label1.BackColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.SimpleStartUpdateButton.BackColor = global::System.Drawing.Color.Black;
			this.SimpleStartUpdateButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.SimpleStartUpdateButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			componentResourceManager.ApplyResources(this.SimpleStartUpdateButton, "SimpleStartUpdateButton");
			this.SimpleStartUpdateButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.SimpleStartUpdateButton.Name = "SimpleStartUpdateButton";
			this.SimpleStartUpdateButton.TabStop = false;
			this.SimpleStartUpdateButton.UseVisualStyleBackColor = false;
			this.SimpleStartUpdateButton.Click += new global::System.EventHandler(this.SimpleStartUpdateButton_Click);
			componentResourceManager.ApplyResources(this.MainFileVersionLabel, "MainFileVersionLabel");
			this.MainFileVersionLabel.ForeColor = global::System.Drawing.Color.Black;
			this.MainFileVersionLabel.Name = "MainFileVersionLabel";
			componentResourceManager.ApplyResources(this.constLabel1, "constLabel1");
			this.constLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.constLabel1.Name = "constLabel1";
			componentResourceManager.ApplyResources(this.LatestVersionLabel, "LatestVersionLabel");
			this.LatestVersionLabel.ForeColor = global::System.Drawing.Color.Black;
			this.LatestVersionLabel.Name = "LatestVersionLabel";
			componentResourceManager.ApplyResources(this.ConnectionStatusLabel, "ConnectionStatusLabel");
			this.ConnectionStatusLabel.ForeColor = global::System.Drawing.Color.Silver;
			this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
			componentResourceManager.ApplyResources(this.ModelNameLabel, "ModelNameLabel");
			this.ModelNameLabel.ForeColor = global::System.Drawing.Color.Black;
			this.ModelNameLabel.Name = "ModelNameLabel";
			componentResourceManager.ApplyResources(this.constLabel11, "constLabel11");
			this.constLabel11.ForeColor = global::System.Drawing.Color.Black;
			this.constLabel11.Name = "constLabel11";
			componentResourceManager.ApplyResources(this.constLabel10, "constLabel10");
			this.constLabel10.ForeColor = global::System.Drawing.Color.Black;
			this.constLabel10.Name = "constLabel10";
			componentResourceManager.ApplyResources(this.MainVersionLabel, "MainVersionLabel");
			this.MainVersionLabel.ForeColor = global::System.Drawing.Color.Black;
			this.MainVersionLabel.Name = "MainVersionLabel";
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.ForeColor = global::System.Drawing.Color.Black;
			this.label2.Name = "label2";
			componentResourceManager.ApplyResources(this.RDPictureBox, "RDPictureBox");
			this.RDPictureBox.Name = "RDPictureBox";
			this.RDPictureBox.TabStop = false;
			this.DloadInternetSTSLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.DloadInternetSTSLabel.ForeColor = global::System.Drawing.SystemColors.AppWorkspace;
			componentResourceManager.ApplyResources(this.DloadInternetSTSLabel, "DloadInternetSTSLabel");
			this.DloadInternetSTSLabel.Name = "DloadInternetSTSLabel";
			this.DownloadFilesPanel.BackColor = global::System.Drawing.Color.White;
			this.DownloadFilesPanel.Controls.Add(this.ConnectionStatus2Label);
			this.DownloadFilesPanel.Controls.Add(this.groupBox1);
			this.DownloadFilesPanel.Controls.Add(this.DetailStartUpdateButton);
			this.DownloadFilesPanel.Controls.Add(this.RecoveryMode);
			this.DownloadFilesPanel.Controls.Add(this.groupBox2);
			componentResourceManager.ApplyResources(this.DownloadFilesPanel, "DownloadFilesPanel");
			this.DownloadFilesPanel.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.DownloadFilesPanel.Name = "DownloadFilesPanel";
			componentResourceManager.ApplyResources(this.ConnectionStatus2Label, "ConnectionStatus2Label");
			this.ConnectionStatus2Label.ForeColor = global::System.Drawing.Color.Silver;
			this.ConnectionStatus2Label.Name = "ConnectionStatus2Label";
			this.groupBox1.Controls.Add(this.ConnectedVersionLabel);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.ReadVersionSTSLabel2);
			this.groupBox1.Controls.Add(this.currentVersionPeriLabel);
			this.groupBox1.Controls.Add(this.ReadVersionButton);
			this.groupBox1.Controls.Add(this.DetailConnectedModelLabel);
			componentResourceManager.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.ForeColor = global::System.Drawing.Color.Black;
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			componentResourceManager.ApplyResources(this.ConnectedVersionLabel, "ConnectedVersionLabel");
			this.ConnectedVersionLabel.Name = "ConnectedVersionLabel";
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			componentResourceManager.ApplyResources(this.ReadVersionSTSLabel2, "ReadVersionSTSLabel2");
			this.ReadVersionSTSLabel2.Name = "ReadVersionSTSLabel2";
			componentResourceManager.ApplyResources(this.currentVersionPeriLabel, "currentVersionPeriLabel");
			this.currentVersionPeriLabel.Name = "currentVersionPeriLabel";
			this.ReadVersionButton.BackColor = global::System.Drawing.Color.Black;
			this.ReadVersionButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.ReadVersionButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			componentResourceManager.ApplyResources(this.ReadVersionButton, "ReadVersionButton");
			this.ReadVersionButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.ReadVersionButton.Name = "ReadVersionButton";
			this.ReadVersionButton.TabStop = false;
			this.ReadVersionButton.UseVisualStyleBackColor = false;
			this.ReadVersionButton.Click += new global::System.EventHandler(this.ReadVersionButton_Click);
			componentResourceManager.ApplyResources(this.DetailConnectedModelLabel, "DetailConnectedModelLabel");
			this.DetailConnectedModelLabel.Name = "DetailConnectedModelLabel";
			this.DetailStartUpdateButton.BackColor = global::System.Drawing.Color.Black;
			this.DetailStartUpdateButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.DetailStartUpdateButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			componentResourceManager.ApplyResources(this.DetailStartUpdateButton, "DetailStartUpdateButton");
			this.DetailStartUpdateButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.DetailStartUpdateButton.Name = "DetailStartUpdateButton";
			this.DetailStartUpdateButton.TabStop = false;
			this.DetailStartUpdateButton.UseVisualStyleBackColor = false;
			this.DetailStartUpdateButton.Click += new global::System.EventHandler(this.DetailStartUpdateButton_Click);
			componentResourceManager.ApplyResources(this.RecoveryMode, "RecoveryMode");
			this.RecoveryMode.ForeColor = global::System.Drawing.Color.Black;
			this.RecoveryMode.Name = "RecoveryMode";
			this.RecoveryMode.TabStop = false;
			this.RecoveryMode.UseVisualStyleBackColor = true;
			this.groupBox2.Controls.Add(this.downloadFileVersionPeriLabel);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.DetailFileModelLabel);
			this.groupBox2.Controls.Add(this.FilePathRichTextBox);
			this.groupBox2.Controls.Add(this.FileOpenButton);
			this.groupBox2.Controls.Add(this.FWFileVersionLabel);
			componentResourceManager.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.ForeColor = global::System.Drawing.Color.Black;
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			componentResourceManager.ApplyResources(this.downloadFileVersionPeriLabel, "downloadFileVersionPeriLabel");
			this.downloadFileVersionPeriLabel.Name = "downloadFileVersionPeriLabel";
			componentResourceManager.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			componentResourceManager.ApplyResources(this.DetailFileModelLabel, "DetailFileModelLabel");
			this.DetailFileModelLabel.Name = "DetailFileModelLabel";
			this.FilePathRichTextBox.BackColor = global::System.Drawing.Color.White;
			this.FilePathRichTextBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			componentResourceManager.ApplyResources(this.FilePathRichTextBox, "FilePathRichTextBox");
			this.FilePathRichTextBox.ForeColor = global::System.Drawing.Color.Black;
			this.FilePathRichTextBox.Name = "FilePathRichTextBox";
			this.FilePathRichTextBox.ReadOnly = true;
			this.FileOpenButton.BackColor = global::System.Drawing.Color.Black;
			this.FileOpenButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.FileOpenButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			componentResourceManager.ApplyResources(this.FileOpenButton, "FileOpenButton");
			this.FileOpenButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.FileOpenButton.Name = "FileOpenButton";
			this.FileOpenButton.TabStop = false;
			this.FileOpenButton.UseVisualStyleBackColor = false;
			this.FileOpenButton.Click += new global::System.EventHandler(this.FileOpenButton_Click);
			componentResourceManager.ApplyResources(this.FWFileVersionLabel, "FWFileVersionLabel");
			this.FWFileVersionLabel.Name = "FWFileVersionLabel";
			this.OptionPenal.BackColor = global::System.Drawing.Color.White;
			this.OptionPenal.Controls.Add(this.DarkModeCheckBox);
			this.OptionPenal.Controls.Add(this.AutoConnectEnableCheckBox);
			this.OptionPenal.Controls.Add(this.ToolVersionLabel);
			componentResourceManager.ApplyResources(this.OptionPenal, "OptionPenal");
			this.OptionPenal.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.OptionPenal.Name = "OptionPenal";
			componentResourceManager.ApplyResources(this.DarkModeCheckBox, "DarkModeCheckBox");
			this.DarkModeCheckBox.ForeColor = global::System.Drawing.Color.Black;
			this.DarkModeCheckBox.Name = "DarkModeCheckBox";
			this.DarkModeCheckBox.TabStop = false;
			this.DarkModeCheckBox.UseVisualStyleBackColor = true;
			this.DarkModeCheckBox.CheckedChanged += new global::System.EventHandler(this.DarkModeCheckBox_CheckedChanged);
			componentResourceManager.ApplyResources(this.AutoConnectEnableCheckBox, "AutoConnectEnableCheckBox");
			this.AutoConnectEnableCheckBox.ForeColor = global::System.Drawing.Color.Black;
			this.AutoConnectEnableCheckBox.Name = "AutoConnectEnableCheckBox";
			this.AutoConnectEnableCheckBox.TabStop = false;
			this.AutoConnectEnableCheckBox.UseVisualStyleBackColor = true;
			this.AutoConnectEnableCheckBox.CheckedChanged += new global::System.EventHandler(this.AutoConnectEnableCheckBox_CheckedChanged);
			this.ToolVersionLabel.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			componentResourceManager.ApplyResources(this.ToolVersionLabel, "ToolVersionLabel");
			this.ToolVersionLabel.Name = "ToolVersionLabel";
			this.line1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			componentResourceManager.ApplyResources(this.line1, "line1");
			this.line1.Name = "line1";
			this.line2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			componentResourceManager.ApplyResources(this.line2, "line2");
			this.line2.Name = "line2";
			this.line3.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			componentResourceManager.ApplyResources(this.line3, "line3");
			this.line3.Name = "line3";
			this.line4.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			componentResourceManager.ApplyResources(this.line4, "line4");
			this.line4.Name = "line4";
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.LeftMenuPanel);
			this.panel1.Controls.Add(this.UpTilePanel);
			componentResourceManager.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			this.panel2.Controls.Add(this.MenuTabPanel);
			componentResourceManager.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
			this.MenuTabPanel.Controls.Add(this.UpdateTab);
			this.MenuTabPanel.Controls.Add(this.DownloadFilesTab);
			this.MenuTabPanel.Controls.Add(this.OptionTab);
			this.MenuTabPanel.Controls.Add(this.UpdatesTab);
			componentResourceManager.ApplyResources(this.MenuTabPanel, "MenuTabPanel");
			this.MenuTabPanel.Multiline = true;
			this.MenuTabPanel.Name = "MenuTabPanel";
			this.MenuTabPanel.SelectedIndex = 0;
			this.MenuTabPanel.TabStop = false;
			this.UpdateTab.Controls.Add(this.UpdatePanel);
			componentResourceManager.ApplyResources(this.UpdateTab, "UpdateTab");
			this.UpdateTab.Name = "UpdateTab";
			this.UpdateTab.UseVisualStyleBackColor = true;
			this.DownloadFilesTab.Controls.Add(this.DownloadFilesPanel);
			componentResourceManager.ApplyResources(this.DownloadFilesTab, "DownloadFilesTab");
			this.DownloadFilesTab.Name = "DownloadFilesTab";
			this.DownloadFilesTab.UseVisualStyleBackColor = true;
			this.OptionTab.Controls.Add(this.OptionPenal);
			componentResourceManager.ApplyResources(this.OptionTab, "OptionTab");
			this.OptionTab.Name = "OptionTab";
			this.OptionTab.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.UpdatesTab, "OptionTab");
			this.UpdatesTab.Name = "UpdatesTab";
			this.UpdatesTab.Text = "Updates";
			this.UpdatesTab.BackColor = global::System.Drawing.Color.White;
			this.UpdatesTab.UseVisualStyleBackColor = false;
			this.InitializeUpdatesPage();
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			componentResourceManager.ApplyResources(this, "$this");
			this.BackColor = global::System.Drawing.SystemColors.MenuBar;
			base.ControlBox = false;
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.line4);
			base.Controls.Add(this.line3);
			base.Controls.Add(this.line2);
			base.Controls.Add(this.line1);
			this.Cursor = global::System.Windows.Forms.Cursors.Default;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.Name = "MainForm";
			base.Load += new global::System.EventHandler(this.MainForm_Load);
			this.UpTilePanel.ResumeLayout(false);
			this.LeftMenuPanel.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
			this.UpdatePanel.ResumeLayout(false);
			this.UpdatePanel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.RDPictureBox).EndInit();
			this.DownloadFilesPanel.ResumeLayout(false);
			this.DownloadFilesPanel.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.OptionPenal.ResumeLayout(false);
			this.OptionPenal.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.MenuTabPanel.ResumeLayout(false);
			this.UpdateTab.ResumeLayout(false);
			this.DownloadFilesTab.ResumeLayout(false);
			this.OptionTab.ResumeLayout(false);
			this.UpdatesTab.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000DE RID: 222
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.OpenFileDialog firmwareFileOpenDialog;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.Panel OptionPenal;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.CheckBox DarkModeCheckBox;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.Label ToolVersionLabel;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.CheckBox AutoConnectEnableCheckBox;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.Panel DownloadFilesPanel;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Label ConnectionStatus2Label;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.Button ReadVersionButton;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Label DetailConnectedModelLabel;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.Label ConnectedVersionLabel;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.Button DetailStartUpdateButton;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.CheckBox RecoveryMode;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040000EE RID: 238
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000EF RID: 239
		private global::System.Windows.Forms.Label DetailFileModelLabel;

		// Token: 0x040000F0 RID: 240
		private global::System.Windows.Forms.RichTextBox FilePathRichTextBox;

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Forms.Button FileOpenButton;

		// Token: 0x040000F2 RID: 242
		private global::System.Windows.Forms.Label FWFileVersionLabel;

		// Token: 0x040000F3 RID: 243
		private global::System.Windows.Forms.Panel UpdatePanel;

		// Token: 0x040000F4 RID: 244
		private global::System.Windows.Forms.Button SimpleStartUpdateButton;

		// Token: 0x040000F5 RID: 245
		private global::System.Windows.Forms.Label MainFileVersionLabel;

		// Token: 0x040000F6 RID: 246
		private global::System.Windows.Forms.Label constLabel1;

		// Token: 0x040000F7 RID: 247
		private global::System.Windows.Forms.Label ConnectionStatusLabel;

		// Token: 0x040000F8 RID: 248
		private global::System.Windows.Forms.Label ModelNameLabel;

		// Token: 0x040000F9 RID: 249
		private global::System.Windows.Forms.Label constLabel11;

		// Token: 0x040000FA RID: 250
		private global::System.Windows.Forms.Label constLabel10;

		// Token: 0x040000FB RID: 251
		private global::System.Windows.Forms.Label MainVersionLabel;

		// Token: 0x040000FC RID: 252
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Forms.PictureBox RDPictureBox;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.Panel UpTilePanel;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.Label TitleLabel;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.Button MinimizeButton;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.Button UpCloseButton;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.Panel LeftMenuPanel;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.Button OptionButton;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.Button DownloadFilesButton;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.Button UpdateButton;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.PictureBox LogoPictureBox;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.Label MenuStatusOption;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.Label MenuStatusDloadFiles;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.Label MenuStatusUpdate;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.Label LatestVersionLabel;

		// Token: 0x0400010C RID: 268
		public global::System.Windows.Forms.Label DloadInternetSTSLabel;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.Label LatestColonLable;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.Button CloseButton;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.Label line1;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.Label line2;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.Label line3;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.Label line4;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000114 RID: 276
		public global::System.Windows.Forms.Label ReadVersionSTSLabel2;

		// Token: 0x04000115 RID: 277
		public global::System.Windows.Forms.Label ReadVersionSTSLabel1;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.Button UserSettingButton;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.Button GPSDataSettingButton;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.TabControl MenuTabPanel;

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Forms.TabPage UpdateTab;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.TabPage DownloadFilesTab;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.TabPage OptionTab;

		private global::System.Windows.Forms.Button UpdatesButton;

		private global::System.Windows.Forms.Label MenuStatusUpdates;

		private global::System.Windows.Forms.TabPage UpdatesTab;

		// Token: 0x0400011D RID: 285
		public global::System.Windows.Forms.Label currentVersionPeriLabel;

		// Token: 0x0400011E RID: 286
		public global::System.Windows.Forms.Label downloadFileVersionPeriLabel;
	}
}
