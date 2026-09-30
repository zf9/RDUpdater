namespace Uniden_R_Series_Tool
{
	// Token: 0x02000028 RID: 40
	public partial class UserSettingForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060001AC RID: 428 RVA: 0x0001D642 File Offset: 0x0001B842
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001D664 File Offset: 0x0001B864
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Uniden_R_Series_Tool.UserSettingForm));
			this.line3 = new global::System.Windows.Forms.Label();
			this.line4 = new global::System.Windows.Forms.Label();
			this.line1 = new global::System.Windows.Forms.Label();
			this.line2 = new global::System.Windows.Forms.Label();
			this.UpTilePanel = new global::System.Windows.Forms.Panel();
			this.UpCloseButton = new global::System.Windows.Forms.Button();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.SaveFileDialog = new global::System.Windows.Forms.SaveFileDialog();
			this.LoadFileDialog = new global::System.Windows.Forms.OpenFileDialog();
			this.UserSettingLoadButton = new global::System.Windows.Forms.Button();
			this.UserSettingSaveButton = new global::System.Windows.Forms.Button();
			this.CloseButton = new global::System.Windows.Forms.Button();
			this.LoadFileButton = new global::System.Windows.Forms.Button();
			this.SaveFileButton = new global::System.Windows.Forms.Button();
			this.UserSettingGridView = new global::System.Windows.Forms.DataGridView();
			this.UserPreferenceButton = new global::System.Windows.Forms.Button();
			this.BandSettingButton = new global::System.Windows.Forms.Button();
			this.DisplayButton = new global::System.Windows.Forms.Button();
			this.SoundButton = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.settingPanel = new global::System.Windows.Forms.Panel();
			this.DataGridScrollBar = new global::CustomControls.CustomScrollbar();
			this.MenuDescriptionScrollbar = new global::CustomControls.CustomScrollbar();
			this.label1 = new global::System.Windows.Forms.Label();
			this.MenuDescriptionPanel = new global::System.Windows.Forms.Panel();
			this.MenuDescriptionLabel = new global::System.Windows.Forms.Label();
			this.MenuNameLabel = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.WifiButton = new global::System.Windows.Forms.Button();
			this.GPSButton = new global::System.Windows.Forms.Button();
			this.UserSettingPenal = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.panel7 = new global::System.Windows.Forms.Panel();
			this.panel6 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.wifiPanel = new global::System.Windows.Forms.Panel();
			this.panel8 = new global::System.Windows.Forms.Panel();
			this.currentSSIDLabel = new global::System.Windows.Forms.Label();
			this.panel10 = new global::System.Windows.Forms.Panel();
			this.modelLabelPanel = new global::System.Windows.Forms.Panel();
			this.modelNameLabel = new global::System.Windows.Forms.Label();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.panel9 = new global::System.Windows.Forms.Panel();
			this.settingLabelPanel = new global::System.Windows.Forms.Panel();
			this.settingLabel = new global::System.Windows.Forms.Label();
			this.setSSIDLabel = new global::System.Windows.Forms.Label();
			this.saveWIFIInfoButton = new global::System.Windows.Forms.Button();
			this.passwordEyeButton = new global::System.Windows.Forms.Panel();
			this.setPasswordLabel = new global::System.Windows.Forms.Label();
			this.wifiSSIDTextBox = new global::System.Windows.Forms.TextBox();
			this.wifiPasswordTextBox = new global::System.Windows.Forms.TextBox();
			this.hwRevisionPanel = new global::System.Windows.Forms.Panel();
			this.hwRevisionConstLabel = new global::System.Windows.Forms.Label();
			this.hwRevisionLabel = new global::System.Windows.Forms.Label();
			this.UpTilePanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.UserSettingGridView).BeginInit();
			this.panel1.SuspendLayout();
			this.settingPanel.SuspendLayout();
			this.MenuDescriptionPanel.SuspendLayout();
			this.UserSettingPenal.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel2.SuspendLayout();
			this.wifiPanel.SuspendLayout();
			this.panel8.SuspendLayout();
			this.modelLabelPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.settingLabelPanel.SuspendLayout();
			this.hwRevisionPanel.SuspendLayout();
			base.SuspendLayout();
			this.line3.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.line3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line3.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line3.Location = new global::System.Drawing.Point(0, 0);
			this.line3.Name = "line3";
			this.line3.Size = new global::System.Drawing.Size(625, 1);
			this.line3.TabIndex = 25;
			this.line3.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.line4.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.line4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line4.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line4.Location = new global::System.Drawing.Point(1, 677);
			this.line4.Name = "line4";
			this.line4.Size = new global::System.Drawing.Size(624, 1);
			this.line4.TabIndex = 27;
			this.line4.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.line1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.line1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line1.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line1.Location = new global::System.Drawing.Point(0, 1);
			this.line1.Name = "line1";
			this.line1.Size = new global::System.Drawing.Size(1, 677);
			this.line1.TabIndex = 26;
			this.line1.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.line2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.line2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line2.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line2.Location = new global::System.Drawing.Point(624, 1);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 676);
			this.line2.TabIndex = 28;
			this.line2.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.UpTilePanel.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.UpTilePanel.Controls.Add(this.UpCloseButton);
			this.UpTilePanel.Controls.Add(this.TitleLabel);
			this.UpTilePanel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.UpTilePanel.ForeColor = global::System.Drawing.Color.Black;
			this.UpTilePanel.Location = new global::System.Drawing.Point(1, 1);
			this.UpTilePanel.Name = "UpTilePanel";
			this.UpTilePanel.Size = new global::System.Drawing.Size(623, 29);
			this.UpTilePanel.TabIndex = 29;
			this.UpTilePanel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.UpTilePanel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.UpTilePanel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.UpCloseButton.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.UpCloseButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.UpCloseButton.FlatAppearance.BorderSize = 0;
			this.UpCloseButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.UpCloseButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.UpCloseButton.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f);
			this.UpCloseButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.UpCloseButton.Location = new global::System.Drawing.Point(591, 0);
			this.UpCloseButton.Name = "UpCloseButton";
			this.UpCloseButton.Size = new global::System.Drawing.Size(32, 29);
			this.UpCloseButton.TabIndex = 33;
			this.UpCloseButton.TabStop = false;
			this.UpCloseButton.Text = "X";
			this.UpCloseButton.UseVisualStyleBackColor = true;
			this.UpCloseButton.Click += new global::System.EventHandler(this.UpCloseButton_Click);
			this.TitleLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TitleLabel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TitleLabel.Location = new global::System.Drawing.Point(3, 5);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new global::System.Drawing.Size(260, 16);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "      User Setting";
			this.TitleLabel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.TitleLabel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.TitleLabel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.LoadFileDialog.FileName = "openFileDialog1";
			this.UserSettingLoadButton.BackColor = global::System.Drawing.Color.Black;
			this.UserSettingLoadButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.UserSettingLoadButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.UserSettingLoadButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.UserSettingLoadButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.UserSettingLoadButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.UserSettingLoadButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.UserSettingLoadButton.Location = new global::System.Drawing.Point(9, 0);
			this.UserSettingLoadButton.Name = "UserSettingLoadButton";
			this.UserSettingLoadButton.Size = new global::System.Drawing.Size(100, 45);
			this.UserSettingLoadButton.TabIndex = 0;
			this.UserSettingLoadButton.TabStop = false;
			this.UserSettingLoadButton.Text = "Load from \r\nunit";
			this.UserSettingLoadButton.UseVisualStyleBackColor = false;
			this.UserSettingLoadButton.Click += new global::System.EventHandler(this.UserSettingLoadButton_Click);
			this.UserSettingSaveButton.BackColor = global::System.Drawing.Color.Black;
			this.UserSettingSaveButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.UserSettingSaveButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.UserSettingSaveButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.UserSettingSaveButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.UserSettingSaveButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.UserSettingSaveButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.UserSettingSaveButton.Location = new global::System.Drawing.Point(115, 0);
			this.UserSettingSaveButton.Name = "UserSettingSaveButton";
			this.UserSettingSaveButton.Size = new global::System.Drawing.Size(100, 45);
			this.UserSettingSaveButton.TabIndex = 36;
			this.UserSettingSaveButton.TabStop = false;
			this.UserSettingSaveButton.Text = "Store to \r\nunit";
			this.UserSettingSaveButton.UseVisualStyleBackColor = false;
			this.UserSettingSaveButton.Click += new global::System.EventHandler(this.UserSettingSaveButton_Click);
			this.CloseButton.BackColor = global::System.Drawing.Color.Black;
			this.CloseButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.CloseButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.CloseButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.CloseButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.CloseButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.CloseButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.CloseButton.Location = new global::System.Drawing.Point(10, 3);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new global::System.Drawing.Size(100, 45);
			this.CloseButton.TabIndex = 37;
			this.CloseButton.TabStop = false;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new global::System.EventHandler(this.UpCloseButton_Click);
			this.LoadFileButton.BackColor = global::System.Drawing.Color.Black;
			this.LoadFileButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.LoadFileButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.LoadFileButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.LoadFileButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.LoadFileButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.LoadFileButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.LoadFileButton.Location = new global::System.Drawing.Point(221, 0);
			this.LoadFileButton.Name = "LoadFileButton";
			this.LoadFileButton.Size = new global::System.Drawing.Size(100, 45);
			this.LoadFileButton.TabIndex = 38;
			this.LoadFileButton.TabStop = false;
			this.LoadFileButton.Text = "Open file";
			this.LoadFileButton.UseVisualStyleBackColor = false;
			this.LoadFileButton.Click += new global::System.EventHandler(this.LoadFileButton_Click);
			this.SaveFileButton.BackColor = global::System.Drawing.Color.Black;
			this.SaveFileButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.SaveFileButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.SaveFileButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.SaveFileButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.SaveFileButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.SaveFileButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.SaveFileButton.Location = new global::System.Drawing.Point(327, 0);
			this.SaveFileButton.Name = "SaveFileButton";
			this.SaveFileButton.Size = new global::System.Drawing.Size(100, 45);
			this.SaveFileButton.TabIndex = 39;
			this.SaveFileButton.TabStop = false;
			this.SaveFileButton.Text = "Save file";
			this.SaveFileButton.UseVisualStyleBackColor = false;
			this.SaveFileButton.Click += new global::System.EventHandler(this.SaveFileButton_Click);
			this.UserSettingGridView.AllowUserToAddRows = false;
			this.UserSettingGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			this.UserSettingGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.UserSettingGridView.BackgroundColor = global::System.Drawing.Color.White;
			this.UserSettingGridView.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.UserSettingGridView.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Tahoma", 9f);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.UserSettingGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.UserSettingGridView.ColumnHeadersHeight = 18;
			this.UserSettingGridView.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Tahoma", 9f);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.UserSettingGridView.DefaultCellStyle = dataGridViewCellStyle3;
			this.UserSettingGridView.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UserSettingGridView.EnableHeadersVisualStyles = false;
			this.UserSettingGridView.Location = new global::System.Drawing.Point(0, 0);
			this.UserSettingGridView.MultiSelect = false;
			this.UserSettingGridView.Name = "UserSettingGridView";
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.UserSettingGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.Font = new global::System.Drawing.Font("Tahoma", 9f);
			this.UserSettingGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.UserSettingGridView.RowTemplate.Height = 23;
			this.UserSettingGridView.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.UserSettingGridView.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.UserSettingGridView.Size = new global::System.Drawing.Size(578, 409);
			this.UserSettingGridView.TabIndex = 40;
			this.UserSettingGridView.TabStop = false;
			this.UserPreferenceButton.BackColor = global::System.Drawing.Color.White;
			this.UserPreferenceButton.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.UserPreferenceButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.UserPreferenceButton.FlatAppearance.BorderSize = 0;
			this.UserPreferenceButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.White;
			this.UserPreferenceButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.White;
			this.UserPreferenceButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.UserPreferenceButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.UserPreferenceButton.ForeColor = global::System.Drawing.Color.Black;
			this.UserPreferenceButton.Location = new global::System.Drawing.Point(0, 0);
			this.UserPreferenceButton.Name = "UserPreferenceButton";
			this.UserPreferenceButton.Size = new global::System.Drawing.Size(100, 40);
			this.UserPreferenceButton.TabIndex = 0;
			this.UserPreferenceButton.TabStop = false;
			this.UserPreferenceButton.Text = "User Preference";
			this.UserPreferenceButton.UseVisualStyleBackColor = false;
			this.UserPreferenceButton.Click += new global::System.EventHandler(this.UserPreferenceButton_Click);
			this.BandSettingButton.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.BandSettingButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.BandSettingButton.FlatAppearance.BorderSize = 0;
			this.BandSettingButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.White;
			this.BandSettingButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.White;
			this.BandSettingButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BandSettingButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.BandSettingButton.ForeColor = global::System.Drawing.Color.Black;
			this.BandSettingButton.Location = new global::System.Drawing.Point(100, 0);
			this.BandSettingButton.Name = "BandSettingButton";
			this.BandSettingButton.Size = new global::System.Drawing.Size(100, 40);
			this.BandSettingButton.TabIndex = 42;
			this.BandSettingButton.TabStop = false;
			this.BandSettingButton.Text = "Band Setting";
			this.BandSettingButton.UseVisualStyleBackColor = true;
			this.BandSettingButton.Click += new global::System.EventHandler(this.BandSettingButton_Click);
			this.DisplayButton.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.DisplayButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.DisplayButton.FlatAppearance.BorderSize = 0;
			this.DisplayButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.White;
			this.DisplayButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.White;
			this.DisplayButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.DisplayButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.DisplayButton.ForeColor = global::System.Drawing.Color.Black;
			this.DisplayButton.Location = new global::System.Drawing.Point(400, 0);
			this.DisplayButton.Name = "DisplayButton";
			this.DisplayButton.Size = new global::System.Drawing.Size(100, 40);
			this.DisplayButton.TabIndex = 44;
			this.DisplayButton.TabStop = false;
			this.DisplayButton.Text = "Display";
			this.DisplayButton.UseVisualStyleBackColor = true;
			this.DisplayButton.Click += new global::System.EventHandler(this.DisplayButton_Click);
			this.SoundButton.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.SoundButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.SoundButton.FlatAppearance.BorderSize = 0;
			this.SoundButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.White;
			this.SoundButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.White;
			this.SoundButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.SoundButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.SoundButton.ForeColor = global::System.Drawing.Color.Black;
			this.SoundButton.Location = new global::System.Drawing.Point(300, 0);
			this.SoundButton.Name = "SoundButton";
			this.SoundButton.Size = new global::System.Drawing.Size(100, 40);
			this.SoundButton.TabIndex = 45;
			this.SoundButton.TabStop = false;
			this.SoundButton.Text = "Sound";
			this.SoundButton.UseVisualStyleBackColor = true;
			this.SoundButton.Click += new global::System.EventHandler(this.VoiceButton_Click);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.panel1.Controls.Add(this.WifiButton);
			this.panel1.Controls.Add(this.DisplayButton);
			this.panel1.Controls.Add(this.SoundButton);
			this.panel1.Controls.Add(this.GPSButton);
			this.panel1.Controls.Add(this.BandSettingButton);
			this.panel1.Controls.Add(this.UserPreferenceButton);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(600, 40);
			this.panel1.TabIndex = 31;
			this.settingPanel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.settingPanel.Controls.Add(this.DataGridScrollBar);
			this.settingPanel.Controls.Add(this.MenuDescriptionScrollbar);
			this.settingPanel.Controls.Add(this.UserSettingGridView);
			this.settingPanel.Controls.Add(this.label1);
			this.settingPanel.Controls.Add(this.MenuDescriptionPanel);
			this.settingPanel.Location = new global::System.Drawing.Point(10, 50);
			this.settingPanel.Name = "settingPanel";
			this.settingPanel.Size = new global::System.Drawing.Size(580, 491);
			this.settingPanel.TabIndex = 41;
			this.settingPanel.Text = "CustomScrollBar Enabled";
			this.DataGridScrollBar.ArrowColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.DataGridScrollBar.BorderColor = global::System.Drawing.SystemColors.Control;
			this.DataGridScrollBar.ButtonFaceColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.DataGridScrollBar.ChannelColor = global::System.Drawing.SystemColors.Control;
			this.DataGridScrollBar.LargeChange = 10;
			this.DataGridScrollBar.Location = new global::System.Drawing.Point(560, 0);
			this.DataGridScrollBar.Maximum = 100;
			this.DataGridScrollBar.MaximumSize = new global::System.Drawing.Size(18, 10000);
			this.DataGridScrollBar.Minimum = 0;
			this.DataGridScrollBar.MinimumSize = new global::System.Drawing.Size(18, 92);
			this.DataGridScrollBar.Name = "DataGridScrollBar";
			this.DataGridScrollBar.Size = new global::System.Drawing.Size(18, 409);
			this.DataGridScrollBar.SmallChange = 1;
			this.DataGridScrollBar.TabIndex = 46;
			this.DataGridScrollBar.ThumbColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.DataGridScrollBar.Value = 0;
			this.DataGridScrollBar.Visible = false;
			this.MenuDescriptionScrollbar.ArrowColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.MenuDescriptionScrollbar.BorderColor = global::System.Drawing.SystemColors.Control;
			this.MenuDescriptionScrollbar.ButtonFaceColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.MenuDescriptionScrollbar.ChannelColor = global::System.Drawing.SystemColors.Control;
			this.MenuDescriptionScrollbar.LargeChange = 68;
			this.MenuDescriptionScrollbar.Location = new global::System.Drawing.Point(560, 410);
			this.MenuDescriptionScrollbar.Maximum = 90;
			this.MenuDescriptionScrollbar.MaximumSize = new global::System.Drawing.Size(18, 10000);
			this.MenuDescriptionScrollbar.Minimum = 0;
			this.MenuDescriptionScrollbar.MinimumSize = new global::System.Drawing.Size(18, 10);
			this.MenuDescriptionScrollbar.Name = "MenuDescriptionScrollbar";
			this.MenuDescriptionScrollbar.Size = new global::System.Drawing.Size(18, 79);
			this.MenuDescriptionScrollbar.SmallChange = 1;
			this.MenuDescriptionScrollbar.TabIndex = 47;
			this.MenuDescriptionScrollbar.ThumbColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.MenuDescriptionScrollbar.Value = 0;
			this.MenuDescriptionScrollbar.Visible = false;
			this.label1.BackColor = global::System.Drawing.Color.FromArgb(150, 150, 150);
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.label1.Location = new global::System.Drawing.Point(0, 409);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(578, 1);
			this.label1.TabIndex = 45;
			this.MenuDescriptionPanel.AutoScroll = true;
			this.MenuDescriptionPanel.BackColor = global::System.Drawing.SystemColors.Control;
			this.MenuDescriptionPanel.Controls.Add(this.MenuDescriptionLabel);
			this.MenuDescriptionPanel.Controls.Add(this.MenuNameLabel);
			this.MenuDescriptionPanel.Controls.Add(this.label2);
			this.MenuDescriptionPanel.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.MenuDescriptionPanel.Location = new global::System.Drawing.Point(0, 410);
			this.MenuDescriptionPanel.Name = "MenuDescriptionPanel";
			this.MenuDescriptionPanel.Size = new global::System.Drawing.Size(578, 79);
			this.MenuDescriptionPanel.TabIndex = 41;
			this.MenuDescriptionLabel.AutoSize = true;
			this.MenuDescriptionLabel.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.MenuDescriptionLabel.ForeColor = global::System.Drawing.Color.Black;
			this.MenuDescriptionLabel.Location = new global::System.Drawing.Point(0, 20);
			this.MenuDescriptionLabel.MaximumSize = new global::System.Drawing.Size(554, 0);
			this.MenuDescriptionLabel.Name = "MenuDescriptionLabel";
			this.MenuDescriptionLabel.Size = new global::System.Drawing.Size(0, 14);
			this.MenuDescriptionLabel.TabIndex = 43;
			this.MenuNameLabel.BackColor = global::System.Drawing.SystemColors.Control;
			this.MenuNameLabel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.MenuNameLabel.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.MenuNameLabel.ForeColor = global::System.Drawing.Color.Black;
			this.MenuNameLabel.Location = new global::System.Drawing.Point(0, 3);
			this.MenuNameLabel.Name = "MenuNameLabel";
			this.MenuNameLabel.Size = new global::System.Drawing.Size(578, 14);
			this.MenuNameLabel.TabIndex = 42;
			this.MenuNameLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.BackColor = global::System.Drawing.SystemColors.Control;
			this.label2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Black;
			this.label2.Location = new global::System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(578, 3);
			this.label2.TabIndex = 44;
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.WifiButton.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.WifiButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.WifiButton.FlatAppearance.BorderSize = 0;
			this.WifiButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.White;
			this.WifiButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.White;
			this.WifiButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.WifiButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.WifiButton.ForeColor = global::System.Drawing.Color.Black;
			this.WifiButton.Location = new global::System.Drawing.Point(500, 0);
			this.WifiButton.Name = "WifiButton";
			this.WifiButton.Size = new global::System.Drawing.Size(100, 40);
			this.WifiButton.TabIndex = 46;
			this.WifiButton.TabStop = false;
			this.WifiButton.Text = "Wi-Fi";
			this.WifiButton.UseVisualStyleBackColor = true;
			this.WifiButton.Click += new global::System.EventHandler(this.WifiButton_Click);
			this.GPSButton.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.GPSButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.GPSButton.FlatAppearance.BorderSize = 0;
			this.GPSButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.White;
			this.GPSButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.White;
			this.GPSButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.GPSButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.GPSButton.ForeColor = global::System.Drawing.Color.Black;
			this.GPSButton.Location = new global::System.Drawing.Point(200, 0);
			this.GPSButton.Name = "GPSButton";
			this.GPSButton.Size = new global::System.Drawing.Size(100, 40);
			this.GPSButton.TabIndex = 43;
			this.GPSButton.TabStop = false;
			this.GPSButton.Text = "GPS";
			this.GPSButton.UseVisualStyleBackColor = true;
			this.GPSButton.Click += new global::System.EventHandler(this.GPSButton_Click);
			this.UserSettingPenal.BackColor = global::System.Drawing.Color.White;
			this.UserSettingPenal.Controls.Add(this.panel4);
			this.UserSettingPenal.Controls.Add(this.hwRevisionPanel);
			this.UserSettingPenal.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.UserSettingPenal.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.UserSettingPenal.Location = new global::System.Drawing.Point(1, 30);
			this.UserSettingPenal.Name = "UserSettingPenal";
			this.UserSettingPenal.Size = new global::System.Drawing.Size(623, 647);
			this.UserSettingPenal.TabIndex = 30;
			this.panel4.BackColor = global::System.Drawing.Color.Transparent;
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Controls.Add(this.panel2);
			this.panel4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new global::System.Drawing.Point(0, 20);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(623, 627);
			this.panel4.TabIndex = 53;
			this.panel5.Controls.Add(this.panel7);
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new global::System.Drawing.Point(0, 574);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(623, 53);
			this.panel5.TabIndex = 49;
			this.panel7.Controls.Add(this.CloseButton);
			this.panel7.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panel7.Location = new global::System.Drawing.Point(503, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new global::System.Drawing.Size(120, 53);
			this.panel7.TabIndex = 41;
			this.panel6.Controls.Add(this.UserSettingLoadButton);
			this.panel6.Controls.Add(this.UserSettingSaveButton);
			this.panel6.Controls.Add(this.LoadFileButton);
			this.panel6.Controls.Add(this.SaveFileButton);
			this.panel6.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new global::System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new global::System.Drawing.Size(443, 53);
			this.panel6.TabIndex = 40;
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.settingPanel);
			this.panel2.Controls.Add(this.wifiPanel);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Location = new global::System.Drawing.Point(10, 10);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(602, 553);
			this.panel2.TabIndex = 48;
			this.wifiPanel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.wifiPanel.Controls.Add(this.panel8);
			this.wifiPanel.Controls.Add(this.panel3);
			this.wifiPanel.Location = new global::System.Drawing.Point(10, 50);
			this.wifiPanel.Name = "wifiPanel";
			this.wifiPanel.Size = new global::System.Drawing.Size(580, 491);
			this.wifiPanel.TabIndex = 42;
			this.wifiPanel.Visible = false;
			this.panel8.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel8.Controls.Add(this.currentSSIDLabel);
			this.panel8.Controls.Add(this.panel10);
			this.panel8.Controls.Add(this.modelLabelPanel);
			this.panel8.Location = new global::System.Drawing.Point(30, 40);
			this.panel8.Name = "panel8";
			this.panel8.Size = new global::System.Drawing.Size(520, 118);
			this.panel8.TabIndex = 11;
			this.currentSSIDLabel.AutoEllipsis = true;
			this.currentSSIDLabel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.currentSSIDLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.currentSSIDLabel.ForeColor = global::System.Drawing.Color.Black;
			this.currentSSIDLabel.Location = new global::System.Drawing.Point(0, 38);
			this.currentSSIDLabel.Name = "currentSSIDLabel";
			this.currentSSIDLabel.Size = new global::System.Drawing.Size(518, 78);
			this.currentSSIDLabel.TabIndex = 9;
			this.currentSSIDLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.panel10.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel10.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel10.Location = new global::System.Drawing.Point(0, 37);
			this.panel10.Name = "panel10";
			this.panel10.Size = new global::System.Drawing.Size(518, 1);
			this.panel10.TabIndex = 10;
			this.modelLabelPanel.BackColor = global::System.Drawing.SystemColors.ButtonFace;
			this.modelLabelPanel.Controls.Add(this.modelNameLabel);
			this.modelLabelPanel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.modelLabelPanel.Location = new global::System.Drawing.Point(0, 0);
			this.modelLabelPanel.Name = "modelLabelPanel";
			this.modelLabelPanel.Size = new global::System.Drawing.Size(518, 37);
			this.modelLabelPanel.TabIndex = 9;
			this.modelNameLabel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.modelNameLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.modelNameLabel.ForeColor = global::System.Drawing.Color.Black;
			this.modelNameLabel.Location = new global::System.Drawing.Point(0, 0);
			this.modelNameLabel.Name = "modelNameLabel";
			this.modelNameLabel.Size = new global::System.Drawing.Size(518, 37);
			this.modelNameLabel.TabIndex = 3;
			this.modelNameLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.panel3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.panel9);
			this.panel3.Controls.Add(this.settingLabelPanel);
			this.panel3.Controls.Add(this.setSSIDLabel);
			this.panel3.Controls.Add(this.saveWIFIInfoButton);
			this.panel3.Controls.Add(this.passwordEyeButton);
			this.panel3.Controls.Add(this.setPasswordLabel);
			this.panel3.Controls.Add(this.wifiSSIDTextBox);
			this.panel3.Controls.Add(this.wifiPasswordTextBox);
			this.panel3.Location = new global::System.Drawing.Point(30, 208);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(520, 243);
			this.panel3.TabIndex = 10;
			this.panel9.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel9.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel9.Location = new global::System.Drawing.Point(0, 37);
			this.panel9.Name = "panel9";
			this.panel9.Size = new global::System.Drawing.Size(518, 1);
			this.panel9.TabIndex = 10;
			this.settingLabelPanel.BackColor = global::System.Drawing.SystemColors.ButtonFace;
			this.settingLabelPanel.Controls.Add(this.settingLabel);
			this.settingLabelPanel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.settingLabelPanel.Location = new global::System.Drawing.Point(0, 0);
			this.settingLabelPanel.Name = "settingLabelPanel";
			this.settingLabelPanel.Size = new global::System.Drawing.Size(518, 37);
			this.settingLabelPanel.TabIndex = 9;
			this.settingLabel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.settingLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.settingLabel.ForeColor = global::System.Drawing.Color.Black;
			this.settingLabel.Location = new global::System.Drawing.Point(0, 0);
			this.settingLabel.Name = "settingLabel";
			this.settingLabel.Size = new global::System.Drawing.Size(518, 37);
			this.settingLabel.TabIndex = 3;
			this.settingLabel.Text = "Change Setting";
			this.settingLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.setSSIDLabel.AutoSize = true;
			this.setSSIDLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.setSSIDLabel.ForeColor = global::System.Drawing.Color.Black;
			this.setSSIDLabel.Location = new global::System.Drawing.Point(28, 85);
			this.setSSIDLabel.Name = "setSSIDLabel";
			this.setSSIDLabel.Size = new global::System.Drawing.Size(65, 25);
			this.setSSIDLabel.TabIndex = 2;
			this.setSSIDLabel.Text = "SSID:";
			this.saveWIFIInfoButton.BackColor = global::System.Drawing.Color.Black;
			this.saveWIFIInfoButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.saveWIFIInfoButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.saveWIFIInfoButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.saveWIFIInfoButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.saveWIFIInfoButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.saveWIFIInfoButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.saveWIFIInfoButton.Location = new global::System.Drawing.Point(298, 187);
			this.saveWIFIInfoButton.Name = "saveWIFIInfoButton";
			this.saveWIFIInfoButton.Size = new global::System.Drawing.Size(171, 30);
			this.saveWIFIInfoButton.TabIndex = 0;
			this.saveWIFIInfoButton.TabStop = false;
			this.saveWIFIInfoButton.Text = "Save";
			this.saveWIFIInfoButton.UseVisualStyleBackColor = false;
			this.saveWIFIInfoButton.Click += new global::System.EventHandler(this.saveWIFIInfoButton_Click);
			this.passwordEyeButton.BackgroundImage = global::Uniden_R_Series_Tool.Properties.Resources.hide;
			this.passwordEyeButton.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.passwordEyeButton.Location = new global::System.Drawing.Point(479, 133);
			this.passwordEyeButton.Name = "passwordEyeButton";
			this.passwordEyeButton.Size = new global::System.Drawing.Size(25, 25);
			this.passwordEyeButton.TabIndex = 8;
			this.passwordEyeButton.Click += new global::System.EventHandler(this.passwordEyeButton_Click);
			this.setPasswordLabel.AutoSize = true;
			this.setPasswordLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.setPasswordLabel.ForeColor = global::System.Drawing.Color.Black;
			this.setPasswordLabel.Location = new global::System.Drawing.Point(26, 133);
			this.setPasswordLabel.Name = "setPasswordLabel";
			this.setPasswordLabel.Size = new global::System.Drawing.Size(104, 25);
			this.setPasswordLabel.TabIndex = 3;
			this.setPasswordLabel.Text = "Password:";
			this.wifiSSIDTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.wifiSSIDTextBox.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.wifiSSIDTextBox.Location = new global::System.Drawing.Point(231, 85);
			this.wifiSSIDTextBox.Name = "wifiSSIDTextBox";
			this.wifiSSIDTextBox.Size = new global::System.Drawing.Size(238, 30);
			this.wifiSSIDTextBox.TabIndex = 4;
			this.wifiPasswordTextBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.wifiPasswordTextBox.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.wifiPasswordTextBox.Location = new global::System.Drawing.Point(231, 131);
			this.wifiPasswordTextBox.Name = "wifiPasswordTextBox";
			this.wifiPasswordTextBox.PasswordChar = '*';
			this.wifiPasswordTextBox.Size = new global::System.Drawing.Size(238, 30);
			this.wifiPasswordTextBox.TabIndex = 5;
			this.hwRevisionPanel.BackColor = global::System.Drawing.Color.Transparent;
			this.hwRevisionPanel.Controls.Add(this.hwRevisionConstLabel);
			this.hwRevisionPanel.Controls.Add(this.hwRevisionLabel);
			this.hwRevisionPanel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.hwRevisionPanel.Location = new global::System.Drawing.Point(0, 0);
			this.hwRevisionPanel.Name = "hwRevisionPanel";
			this.hwRevisionPanel.Size = new global::System.Drawing.Size(623, 20);
			this.hwRevisionPanel.TabIndex = 52;
			this.hwRevisionConstLabel.AutoSize = true;
			this.hwRevisionConstLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.hwRevisionConstLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.hwRevisionConstLabel.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.hwRevisionConstLabel.Location = new global::System.Drawing.Point(463, 6);
			this.hwRevisionConstLabel.Name = "hwRevisionConstLabel";
			this.hwRevisionConstLabel.Size = new global::System.Drawing.Size(101, 17);
			this.hwRevisionConstLabel.TabIndex = 50;
			this.hwRevisionConstLabel.Text = "H/W Revision :";
			this.hwRevisionLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.hwRevisionLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.hwRevisionLabel.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.hwRevisionLabel.Location = new global::System.Drawing.Point(562, 6);
			this.hwRevisionLabel.Name = "hwRevisionLabel";
			this.hwRevisionLabel.Size = new global::System.Drawing.Size(51, 17);
			this.hwRevisionLabel.TabIndex = 51;
			this.hwRevisionLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.SystemColors.WindowText;
			base.ClientSize = new global::System.Drawing.Size(625, 678);
			base.Controls.Add(this.UserSettingPenal);
			base.Controls.Add(this.UpTilePanel);
			base.Controls.Add(this.line2);
			base.Controls.Add(this.line4);
			base.Controls.Add(this.line1);
			base.Controls.Add(this.line3);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(625, 678);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(625, 678);
			base.Name = "UserSettingForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UserSetting";
			base.Load += new global::System.EventHandler(this.UserSetting_Load);
			this.UpTilePanel.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.UserSettingGridView).EndInit();
			this.panel1.ResumeLayout(false);
			this.settingPanel.ResumeLayout(false);
			this.MenuDescriptionPanel.ResumeLayout(false);
			this.MenuDescriptionPanel.PerformLayout();
			this.UserSettingPenal.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.wifiPanel.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.modelLabelPanel.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.settingLabelPanel.ResumeLayout(false);
			this.hwRevisionPanel.ResumeLayout(false);
			this.hwRevisionPanel.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000341 RID: 833
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000342 RID: 834
		private global::System.Windows.Forms.Label line3;

		// Token: 0x04000343 RID: 835
		private global::System.Windows.Forms.Label line4;

		// Token: 0x04000344 RID: 836
		private global::System.Windows.Forms.Label line1;

		// Token: 0x04000345 RID: 837
		private global::System.Windows.Forms.Label line2;

		// Token: 0x04000346 RID: 838
		private global::System.Windows.Forms.Panel UpTilePanel;

		// Token: 0x04000347 RID: 839
		private global::System.Windows.Forms.Label TitleLabel;

		// Token: 0x04000348 RID: 840
		private global::System.Windows.Forms.SaveFileDialog SaveFileDialog;

		// Token: 0x04000349 RID: 841
		private global::System.Windows.Forms.OpenFileDialog LoadFileDialog;

		// Token: 0x0400034A RID: 842
		private global::System.Windows.Forms.Button UpCloseButton;

		// Token: 0x0400034B RID: 843
		private global::System.Windows.Forms.Button UserSettingLoadButton;

		// Token: 0x0400034C RID: 844
		private global::System.Windows.Forms.Button UserSettingSaveButton;

		// Token: 0x0400034D RID: 845
		private global::System.Windows.Forms.Button CloseButton;

		// Token: 0x0400034E RID: 846
		private global::System.Windows.Forms.Button LoadFileButton;

		// Token: 0x0400034F RID: 847
		private global::System.Windows.Forms.Button SaveFileButton;

		// Token: 0x04000350 RID: 848
		private global::System.Windows.Forms.DataGridView UserSettingGridView;

		// Token: 0x04000351 RID: 849
		private global::System.Windows.Forms.Button UserPreferenceButton;

		// Token: 0x04000352 RID: 850
		private global::System.Windows.Forms.Button BandSettingButton;

		// Token: 0x04000353 RID: 851
		private global::System.Windows.Forms.Button DisplayButton;

		// Token: 0x04000354 RID: 852
		private global::System.Windows.Forms.Button SoundButton;

		// Token: 0x04000355 RID: 853
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000356 RID: 854
		private global::System.Windows.Forms.Panel UserSettingPenal;

		// Token: 0x04000357 RID: 855
		private global::System.Windows.Forms.Panel settingPanel;

		// Token: 0x04000358 RID: 856
		private global::System.Windows.Forms.Panel MenuDescriptionPanel;

		// Token: 0x04000359 RID: 857
		private global::System.Windows.Forms.Label MenuDescriptionLabel;

		// Token: 0x0400035A RID: 858
		private global::System.Windows.Forms.Label MenuNameLabel;

		// Token: 0x0400035B RID: 859
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400035C RID: 860
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400035D RID: 861
		private global::System.Windows.Forms.Button GPSButton;

		// Token: 0x0400035E RID: 862
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400035F RID: 863
		private global::CustomControls.CustomScrollbar DataGridScrollBar;

		// Token: 0x04000360 RID: 864
		private global::CustomControls.CustomScrollbar MenuDescriptionScrollbar;

		// Token: 0x04000361 RID: 865
		private global::System.Windows.Forms.Label hwRevisionLabel;

		// Token: 0x04000362 RID: 866
		private global::System.Windows.Forms.Label hwRevisionConstLabel;

		// Token: 0x04000363 RID: 867
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000364 RID: 868
		private global::System.Windows.Forms.Panel hwRevisionPanel;

		// Token: 0x04000365 RID: 869
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000366 RID: 870
		private global::System.Windows.Forms.Panel panel7;

		// Token: 0x04000367 RID: 871
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x04000368 RID: 872
		private global::System.Windows.Forms.Button WifiButton;

		// Token: 0x04000369 RID: 873
		private global::System.Windows.Forms.Panel wifiPanel;

		// Token: 0x0400036A RID: 874
		private global::System.Windows.Forms.TextBox wifiPasswordTextBox;

		// Token: 0x0400036B RID: 875
		private global::System.Windows.Forms.TextBox wifiSSIDTextBox;

		// Token: 0x0400036C RID: 876
		private global::System.Windows.Forms.Label setPasswordLabel;

		// Token: 0x0400036D RID: 877
		private global::System.Windows.Forms.Label setSSIDLabel;

		// Token: 0x0400036E RID: 878
		private global::System.Windows.Forms.Button saveWIFIInfoButton;

		// Token: 0x0400036F RID: 879
		private global::System.Windows.Forms.Panel passwordEyeButton;

		// Token: 0x04000370 RID: 880
		private global::System.Windows.Forms.Label currentSSIDLabel;

		// Token: 0x04000371 RID: 881
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000372 RID: 882
		private global::System.Windows.Forms.Panel settingLabelPanel;

		// Token: 0x04000373 RID: 883
		private global::System.Windows.Forms.Panel panel9;

		// Token: 0x04000374 RID: 884
		private global::System.Windows.Forms.Label settingLabel;

		// Token: 0x04000375 RID: 885
		private global::System.Windows.Forms.Panel panel8;

		// Token: 0x04000376 RID: 886
		private global::System.Windows.Forms.Panel panel10;

		// Token: 0x04000377 RID: 887
		private global::System.Windows.Forms.Panel modelLabelPanel;

		// Token: 0x04000378 RID: 888
		private global::System.Windows.Forms.Label modelNameLabel;
	}
}
