namespace Uniden_R_Series_Tool
{
	// Token: 0x02000002 RID: 2
	public partial class GPSDataSettingAddMuteMemForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002300 File Offset: 0x00000500
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002320 File Offset: 0x00000520
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Uniden_R_Series_Tool.GPSDataSettingAddMuteMemForm));
			this.bandComboBox = new global::System.Windows.Forms.ComboBox();
			this.bandLabel = new global::System.Windows.Forms.Label();
			this.freqTextBox = new global::System.Windows.Forms.TextBox();
			this.freqLabel = new global::System.Windows.Forms.Label();
			this.addButton = new global::System.Windows.Forms.Button();
			this.cancelButton = new global::System.Windows.Forms.Button();
			this.ghzLabel = new global::System.Windows.Forms.Label();
			this.UpCloseButton = new global::System.Windows.Forms.Button();
			this.UpTilePanel = new global::System.Windows.Forms.Panel();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.MainPanel = new global::System.Windows.Forms.Panel();
			this.UpTilePanel.SuspendLayout();
			this.MainPanel.SuspendLayout();
			base.SuspendLayout();
			this.bandComboBox.BackColor = global::System.Drawing.Color.White;
			this.bandComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bandComboBox.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.bandComboBox.FormattingEnabled = true;
			this.bandComboBox.Items.AddRange(new object[]
			{
				"X",
				"K",
				"Ka",
				"POP",
				"MRCD",
				"RT3",
				"RT4"
			});
			this.bandComboBox.Location = new global::System.Drawing.Point(101, 39);
			this.bandComboBox.Name = "bandComboBox";
			this.bandComboBox.Size = new global::System.Drawing.Size(121, 26);
			this.bandComboBox.TabIndex = 0;
			this.bandLabel.AutoSize = true;
			this.bandLabel.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.bandLabel.Location = new global::System.Drawing.Point(18, 42);
			this.bandLabel.Name = "bandLabel";
			this.bandLabel.Size = new global::System.Drawing.Size(39, 18);
			this.bandLabel.TabIndex = 1;
			this.bandLabel.Text = "Band";
			this.freqTextBox.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.freqTextBox.Location = new global::System.Drawing.Point(101, 67);
			this.freqTextBox.Name = "freqTextBox";
			this.freqTextBox.Size = new global::System.Drawing.Size(121, 24);
			this.freqTextBox.TabIndex = 2;
			this.freqTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.freqLabel.AutoSize = true;
			this.freqLabel.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.freqLabel.Location = new global::System.Drawing.Point(18, 70);
			this.freqLabel.Name = "freqLabel";
			this.freqLabel.Size = new global::System.Drawing.Size(73, 18);
			this.freqLabel.TabIndex = 3;
			this.freqLabel.Text = "Frequency";
			this.addButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.addButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.addButton.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.addButton.Location = new global::System.Drawing.Point(100, 99);
			this.addButton.Name = "addButton";
			this.addButton.Size = new global::System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 4;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new global::System.EventHandler(this.addButton_Click);
			this.cancelButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.cancelButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.cancelButton.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.cancelButton.Location = new global::System.Drawing.Point(181, 99);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new global::System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new global::System.EventHandler(this.cancelButton_Click);
			this.ghzLabel.AutoSize = true;
			this.ghzLabel.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.ghzLabel.Location = new global::System.Drawing.Point(225, 70);
			this.ghzLabel.Name = "ghzLabel";
			this.ghzLabel.Size = new global::System.Drawing.Size(31, 18);
			this.ghzLabel.TabIndex = 6;
			this.ghzLabel.Text = "Ghz";
			this.UpCloseButton.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.UpCloseButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.UpCloseButton.FlatAppearance.BorderSize = 0;
			this.UpCloseButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.UpCloseButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.UpCloseButton.Font = new global::System.Drawing.Font("Microsoft JhengHei", 9f);
			this.UpCloseButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.UpCloseButton.Location = new global::System.Drawing.Point(236, 0);
			this.UpCloseButton.Name = "UpCloseButton";
			this.UpCloseButton.Size = new global::System.Drawing.Size(32, 29);
			this.UpCloseButton.TabIndex = 1;
			this.UpCloseButton.TabStop = false;
			this.UpCloseButton.Text = "X";
			this.UpCloseButton.UseVisualStyleBackColor = true;
			this.UpCloseButton.Click += new global::System.EventHandler(this.cancelButton_Click);
			this.UpTilePanel.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.UpTilePanel.Controls.Add(this.UpCloseButton);
			this.UpTilePanel.Controls.Add(this.TitleLabel);
			this.UpTilePanel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.UpTilePanel.ForeColor = global::System.Drawing.Color.Black;
			this.UpTilePanel.Location = new global::System.Drawing.Point(0, 0);
			this.UpTilePanel.Name = "UpTilePanel";
			this.UpTilePanel.Size = new global::System.Drawing.Size(268, 29);
			this.UpTilePanel.TabIndex = 21;
			this.UpTilePanel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.UpTilePanel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.UpTilePanel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.TitleLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.TitleLabel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TitleLabel.Location = new global::System.Drawing.Point(24, 7);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new global::System.Drawing.Size(125, 22);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Add Mute Memory";
			this.TitleLabel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.TitleLabel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.TitleLabel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.MainPanel.BackColor = global::System.Drawing.Color.White;
			this.MainPanel.Controls.Add(this.UpTilePanel);
			this.MainPanel.Controls.Add(this.ghzLabel);
			this.MainPanel.Controls.Add(this.bandLabel);
			this.MainPanel.Controls.Add(this.cancelButton);
			this.MainPanel.Controls.Add(this.bandComboBox);
			this.MainPanel.Controls.Add(this.addButton);
			this.MainPanel.Controls.Add(this.freqTextBox);
			this.MainPanel.Controls.Add(this.freqLabel);
			this.MainPanel.Location = new global::System.Drawing.Point(1, 1);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new global::System.Drawing.Size(268, 129);
			this.MainPanel.TabIndex = 22;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			base.ClientSize = new global::System.Drawing.Size(270, 131);
			base.Controls.Add(this.MainPanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "GPSDataSettingAddMuteMemForm";
			base.Padding = new global::System.Windows.Forms.Padding(1);
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Mute Memory";
			this.UpTilePanel.ResumeLayout(false);
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000006 RID: 6
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.ComboBox bandComboBox;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label bandLabel;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.TextBox freqTextBox;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label freqLabel;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button addButton;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button cancelButton;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label ghzLabel;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button UpCloseButton;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Panel UpTilePanel;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label TitleLabel;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Panel MainPanel;
	}
}
