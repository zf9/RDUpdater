namespace Uniden_R_Series_Tool
{
	// Token: 0x02000009 RID: 9
	public partial class GPSDataSettingSaveFileOptionForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00006FE8 File Offset: 0x000051E8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007008 File Offset: 0x00005208
		private void InitializeComponent()
		{
			this.MainPanel = new global::System.Windows.Forms.Panel();
			this.UpTilePanel = new global::System.Windows.Forms.Panel();
			this.UpCloseButton = new global::System.Windows.Forms.Button();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.cancelButton = new global::System.Windows.Forms.Button();
			this.addButton = new global::System.Windows.Forms.Button();
			this.UserMarkCheckBox = new global::System.Windows.Forms.CheckBox();
			this.MuteMemoryCheckBox = new global::System.Windows.Forms.CheckBox();
			this.MainPanel.SuspendLayout();
			this.UpTilePanel.SuspendLayout();
			base.SuspendLayout();
			this.MainPanel.BackColor = global::System.Drawing.Color.White;
			this.MainPanel.Controls.Add(this.MuteMemoryCheckBox);
			this.MainPanel.Controls.Add(this.UserMarkCheckBox);
			this.MainPanel.Controls.Add(this.UpTilePanel);
			this.MainPanel.Controls.Add(this.cancelButton);
			this.MainPanel.Controls.Add(this.addButton);
			this.MainPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new global::System.Drawing.Point(1, 1);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new global::System.Drawing.Size(238, 116);
			this.MainPanel.TabIndex = 23;
			this.UpTilePanel.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.UpTilePanel.Controls.Add(this.UpCloseButton);
			this.UpTilePanel.Controls.Add(this.TitleLabel);
			this.UpTilePanel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.UpTilePanel.ForeColor = global::System.Drawing.Color.Black;
			this.UpTilePanel.Location = new global::System.Drawing.Point(0, 0);
			this.UpTilePanel.Name = "UpTilePanel";
			this.UpTilePanel.Size = new global::System.Drawing.Size(238, 29);
			this.UpTilePanel.TabIndex = 21;
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
			this.UpCloseButton.Location = new global::System.Drawing.Point(206, 0);
			this.UpCloseButton.Name = "UpCloseButton";
			this.UpCloseButton.Size = new global::System.Drawing.Size(32, 29);
			this.UpCloseButton.TabIndex = 1;
			this.UpCloseButton.TabStop = false;
			this.UpCloseButton.Text = "X";
			this.UpCloseButton.UseVisualStyleBackColor = true;
			this.UpCloseButton.Click += new global::System.EventHandler(this.cancelButton_Click);
			this.TitleLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.TitleLabel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TitleLabel.Location = new global::System.Drawing.Point(24, 7);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new global::System.Drawing.Size(125, 22);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Save File Option";
			this.TitleLabel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.TitleLabel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.TitleLabel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.cancelButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.cancelButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.cancelButton.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.cancelButton.Location = new global::System.Drawing.Point(148, 80);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new global::System.Drawing.Size(75, 25);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new global::System.EventHandler(this.cancelButton_Click);
			this.addButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.addButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.addButton.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.addButton.Location = new global::System.Drawing.Point(66, 80);
			this.addButton.Name = "addButton";
			this.addButton.Size = new global::System.Drawing.Size(75, 25);
			this.addButton.TabIndex = 4;
			this.addButton.Text = "Okay";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new global::System.EventHandler(this.okayButton_Click);
			this.UserMarkCheckBox.AutoSize = true;
			this.UserMarkCheckBox.Checked = true;
			this.UserMarkCheckBox.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.UserMarkCheckBox.Location = new global::System.Drawing.Point(21, 49);
			this.UserMarkCheckBox.Name = "UserMarkCheckBox";
			this.UserMarkCheckBox.Size = new global::System.Drawing.Size(82, 16);
			this.UserMarkCheckBox.TabIndex = 22;
			this.UserMarkCheckBox.Text = "User Mark";
			this.UserMarkCheckBox.UseVisualStyleBackColor = true;
			this.MuteMemoryCheckBox.AutoSize = true;
			this.MuteMemoryCheckBox.Checked = true;
			this.MuteMemoryCheckBox.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.MuteMemoryCheckBox.Location = new global::System.Drawing.Point(123, 49);
			this.MuteMemoryCheckBox.Name = "MuteMemoryCheckBox";
			this.MuteMemoryCheckBox.Size = new global::System.Drawing.Size(103, 16);
			this.MuteMemoryCheckBox.TabIndex = 23;
			this.MuteMemoryCheckBox.Text = "Mute Memory";
			this.MuteMemoryCheckBox.UseVisualStyleBackColor = true;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			base.ClientSize = new global::System.Drawing.Size(240, 118);
			base.Controls.Add(this.MainPanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "GPSDataSettingSaveFileOptionForm";
			base.Padding = new global::System.Windows.Forms.Padding(1);
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "GPSDataSettingSaveFileOptionForm";
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.UpTilePanel.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400005E RID: 94
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Panel MainPanel;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Panel UpTilePanel;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Button UpCloseButton;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Label TitleLabel;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Button cancelButton;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Button addButton;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.CheckBox MuteMemoryCheckBox;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.CheckBox UserMarkCheckBox;
	}
}
