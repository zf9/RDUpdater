namespace Uniden_R_Series_Tool
{
	// Token: 0x0200000D RID: 13
	public partial class UpdateCheckForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00008058 File Offset: 0x00006258
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008078 File Offset: 0x00006278
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Uniden_R_Series_Tool.UpdateCheckForm));
			this.AAFileVersionLabel = new global::System.Windows.Forms.Label();
			this.const3Label = new global::System.Windows.Forms.Label();
			this.FileVersionLabel = new global::System.Windows.Forms.Label();
			this.UpdateButton = new global::System.Windows.Forms.Button();
			this.CancelButton = new global::System.Windows.Forms.Button();
			this.RecoveryModeCheckBox = new global::System.Windows.Forms.CheckBox();
			this.ConnectedModelVersionLabel = new global::System.Windows.Forms.Label();
			this.const2Label = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.AAConnectedVersionLabel = new global::System.Windows.Forms.Label();
			this.ModelNameLabel = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.UpTilePanel = new global::System.Windows.Forms.Panel();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.line4 = new global::System.Windows.Forms.Label();
			this.line3 = new global::System.Windows.Forms.Label();
			this.line2 = new global::System.Windows.Forms.Label();
			this.line1 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.UpTilePanel.SuspendLayout();
			base.SuspendLayout();
			this.AAFileVersionLabel.AutoSize = true;
			this.AAFileVersionLabel.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.AAFileVersionLabel.Location = new global::System.Drawing.Point(27, 111);
			this.AAFileVersionLabel.Name = "AAFileVersionLabel";
			this.AAFileVersionLabel.Size = new global::System.Drawing.Size(87, 17);
			this.AAFileVersionLabel.TabIndex = 1;
			this.AAFileVersionLabel.Text = "Latest Version";
			this.const3Label.AutoSize = true;
			this.const3Label.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.const3Label.Location = new global::System.Drawing.Point(146, 111);
			this.const3Label.Name = "const3Label";
			this.const3Label.Size = new global::System.Drawing.Size(12, 17);
			this.const3Label.TabIndex = 3;
			this.const3Label.Text = ":";
			this.FileVersionLabel.AutoSize = true;
			this.FileVersionLabel.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.FileVersionLabel.Location = new global::System.Drawing.Point(161, 111);
			this.FileVersionLabel.Name = "FileVersionLabel";
			this.FileVersionLabel.Size = new global::System.Drawing.Size(0, 17);
			this.FileVersionLabel.TabIndex = 5;
			this.UpdateButton.BackColor = global::System.Drawing.Color.Black;
			this.UpdateButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.UpdateButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.UpdateButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.UpdateButton.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.UpdateButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.UpdateButton.Location = new global::System.Drawing.Point(236, 140);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new global::System.Drawing.Size(75, 26);
			this.UpdateButton.TabIndex = 6;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = false;
			this.UpdateButton.Click += new global::System.EventHandler(this.UpdateButton_Click);
			this.CancelButton.BackColor = global::System.Drawing.Color.Black;
			this.CancelButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.CancelButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.CancelButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.CancelButton.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.CancelButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.CancelButton.Location = new global::System.Drawing.Point(317, 140);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new global::System.Drawing.Size(75, 26);
			this.CancelButton.TabIndex = 7;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = false;
			this.CancelButton.Click += new global::System.EventHandler(this.CancelButton_Click);
			this.RecoveryModeCheckBox.AutoSize = true;
			this.RecoveryModeCheckBox.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.RecoveryModeCheckBox.Location = new global::System.Drawing.Point(120, 144);
			this.RecoveryModeCheckBox.Name = "RecoveryModeCheckBox";
			this.RecoveryModeCheckBox.Size = new global::System.Drawing.Size(115, 21);
			this.RecoveryModeCheckBox.TabIndex = 8;
			this.RecoveryModeCheckBox.Text = "Recovery Mode";
			this.RecoveryModeCheckBox.UseVisualStyleBackColor = true;
			this.RecoveryModeCheckBox.CheckedChanged += new global::System.EventHandler(this.RecoveryModeCheckBox_CheckedChanged);
			this.ConnectedModelVersionLabel.AutoSize = true;
			this.ConnectedModelVersionLabel.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.ConnectedModelVersionLabel.Location = new global::System.Drawing.Point(149, 38);
			this.ConnectedModelVersionLabel.Name = "ConnectedModelVersionLabel";
			this.ConnectedModelVersionLabel.Size = new global::System.Drawing.Size(0, 17);
			this.ConnectedModelVersionLabel.TabIndex = 4;
			this.const2Label.AutoSize = true;
			this.const2Label.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.const2Label.Location = new global::System.Drawing.Point(134, 38);
			this.const2Label.Name = "const2Label";
			this.const2Label.Size = new global::System.Drawing.Size(12, 17);
			this.const2Label.TabIndex = 2;
			this.const2Label.Text = ":";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.label2.Location = new global::System.Drawing.Point(134, 17);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(12, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = ":";
			this.AAConnectedVersionLabel.AutoSize = true;
			this.AAConnectedVersionLabel.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.AAConnectedVersionLabel.Location = new global::System.Drawing.Point(15, 38);
			this.AAConnectedVersionLabel.Name = "AAConnectedVersionLabel";
			this.AAConnectedVersionLabel.Size = new global::System.Drawing.Size(49, 17);
			this.AAConnectedVersionLabel.TabIndex = 0;
			this.AAConnectedVersionLabel.Text = "Version";
			this.ModelNameLabel.AutoSize = true;
			this.ModelNameLabel.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.ModelNameLabel.Location = new global::System.Drawing.Point(149, 17);
			this.ModelNameLabel.Name = "ModelNameLabel";
			this.ModelNameLabel.Size = new global::System.Drawing.Size(0, 17);
			this.ModelNameLabel.TabIndex = 11;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.label3.Location = new global::System.Drawing.Point(15, 17);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(107, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Connected Model";
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.ConnectedModelVersionLabel);
			this.groupBox1.Controls.Add(this.ModelNameLabel);
			this.groupBox1.Controls.Add(this.const2Label);
			this.groupBox1.Controls.Add(this.AAConnectedVersionLabel);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(380, 65);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.UpTilePanel.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.UpTilePanel.Controls.Add(this.TitleLabel);
			this.UpTilePanel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.UpTilePanel.ForeColor = global::System.Drawing.Color.Black;
			this.UpTilePanel.Location = new global::System.Drawing.Point(1, 1);
			this.UpTilePanel.Name = "UpTilePanel";
			this.UpTilePanel.Size = new global::System.Drawing.Size(402, 29);
			this.UpTilePanel.TabIndex = 21;
			this.UpTilePanel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.UpTilePanel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.UpTilePanel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.TitleLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TitleLabel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TitleLabel.Location = new global::System.Drawing.Point(3, 5);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new global::System.Drawing.Size(260, 16);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Update to check";
			this.TitleLabel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.TitleLabel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.TitleLabel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.line4.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.line4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line4.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line4.Location = new global::System.Drawing.Point(1, 175);
			this.line4.Name = "line4";
			this.line4.Size = new global::System.Drawing.Size(402, 1);
			this.line4.TabIndex = 28;
			this.line4.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.line3.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.line3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line3.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line3.Location = new global::System.Drawing.Point(1, 0);
			this.line3.Name = "line3";
			this.line3.Size = new global::System.Drawing.Size(402, 1);
			this.line3.TabIndex = 27;
			this.line3.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.line2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.line2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line2.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line2.Location = new global::System.Drawing.Point(403, 0);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 176);
			this.line2.TabIndex = 26;
			this.line2.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.line1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.line1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line1.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line1.Location = new global::System.Drawing.Point(0, 0);
			this.line1.Name = "line1";
			this.line1.Size = new global::System.Drawing.Size(1, 176);
			this.line1.TabIndex = 25;
			this.line1.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(404, 176);
			base.ControlBox = false;
			base.Controls.Add(this.UpTilePanel);
			base.Controls.Add(this.line4);
			base.Controls.Add(this.line3);
			base.Controls.Add(this.line2);
			base.Controls.Add(this.line1);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.RecoveryModeCheckBox);
			base.Controls.Add(this.CancelButton);
			base.Controls.Add(this.UpdateButton);
			base.Controls.Add(this.FileVersionLabel);
			base.Controls.Add(this.const3Label);
			base.Controls.Add(this.AAFileVersionLabel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(404, 176);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(404, 176);
			base.Name = "UpdateCheckForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update to check";
			base.Load += new global::System.EventHandler(this.UpdateCheckForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.UpTilePanel.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400007C RID: 124
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Label AAFileVersionLabel;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Label const3Label;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Label FileVersionLabel;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Button UpdateButton;

		// Token: 0x04000081 RID: 129
		private new global::System.Windows.Forms.Button CancelButton;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.CheckBox RecoveryModeCheckBox;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Label ConnectedModelVersionLabel;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Label const2Label;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Label AAConnectedVersionLabel;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Label ModelNameLabel;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Panel UpTilePanel;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Label TitleLabel;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label line4;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.Label line3;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Label line2;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Label line1;
	}
}
