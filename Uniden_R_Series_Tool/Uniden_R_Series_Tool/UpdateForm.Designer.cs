namespace Uniden_R_Series_Tool
{
	// Token: 0x0200000E RID: 14
	public partial class UpdateForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00009D8C File Offset: 0x00007F8C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00009DAC File Offset: 0x00007FAC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Uniden_R_Series_Tool.UpdateForm));
			this.CancelButton = new global::System.Windows.Forms.Button();
			this.StatusLabel = new global::System.Windows.Forms.Label();
			this.RemainingTimeLabel = new global::System.Windows.Forms.Label();
			this.UpTilePanel = new global::System.Windows.Forms.Panel();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.line1 = new global::System.Windows.Forms.Label();
			this.line2 = new global::System.Windows.Forms.Label();
			this.line3 = new global::System.Windows.Forms.Label();
			this.line4 = new global::System.Windows.Forms.Label();
			this.percentLabel = new global::System.Windows.Forms.Label();
			this.simpleDownloadProgressBar = new global::CustomControls.ProgressAsync();
			this.UpTilePanel.SuspendLayout();
			base.SuspendLayout();
			this.CancelButton.BackColor = global::System.Drawing.Color.Black;
			this.CancelButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.CancelButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.CancelButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.CancelButton.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.CancelButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.CancelButton.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.CancelButton.Location = new global::System.Drawing.Point(408, 110);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new global::System.Drawing.Size(75, 26);
			this.CancelButton.TabIndex = 0;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = false;
			this.CancelButton.Click += new global::System.EventHandler(this.CancelButton_Click);
			this.StatusLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.StatusLabel.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.StatusLabel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.StatusLabel.Location = new global::System.Drawing.Point(18, 44);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new global::System.Drawing.Size(348, 27);
			this.StatusLabel.TabIndex = 1;
			this.StatusLabel.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.RemainingTimeLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.RemainingTimeLabel.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.RemainingTimeLabel.ForeColor = global::System.Drawing.Color.Black;
			this.RemainingTimeLabel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.RemainingTimeLabel.Location = new global::System.Drawing.Point(282, 44);
			this.RemainingTimeLabel.Name = "RemainingTimeLabel";
			this.RemainingTimeLabel.Size = new global::System.Drawing.Size(201, 27);
			this.RemainingTimeLabel.TabIndex = 4;
			this.RemainingTimeLabel.TextAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.UpTilePanel.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.UpTilePanel.Controls.Add(this.TitleLabel);
			this.UpTilePanel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.UpTilePanel.ForeColor = global::System.Drawing.Color.Black;
			this.UpTilePanel.Location = new global::System.Drawing.Point(1, 1);
			this.UpTilePanel.Name = "UpTilePanel";
			this.UpTilePanel.Size = new global::System.Drawing.Size(500, 29);
			this.UpTilePanel.TabIndex = 20;
			this.UpTilePanel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.UpTilePanel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.UpTilePanel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.TitleLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TitleLabel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TitleLabel.Location = new global::System.Drawing.Point(3, 5);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new global::System.Drawing.Size(260, 16);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Download progress";
			this.TitleLabel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.TitleLabel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.TitleLabel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.line1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.line1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line1.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line1.Location = new global::System.Drawing.Point(0, 0);
			this.line1.Name = "line1";
			this.line1.Size = new global::System.Drawing.Size(1, 148);
			this.line1.TabIndex = 21;
			this.line1.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.line2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.line2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line2.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line2.Location = new global::System.Drawing.Point(501, 0);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 148);
			this.line2.TabIndex = 22;
			this.line2.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.line3.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.line3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line3.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line3.Location = new global::System.Drawing.Point(1, 0);
			this.line3.Name = "line3";
			this.line3.Size = new global::System.Drawing.Size(500, 1);
			this.line3.TabIndex = 23;
			this.line3.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.line4.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.line4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line4.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line4.Location = new global::System.Drawing.Point(1, 147);
			this.line4.Name = "line4";
			this.line4.Size = new global::System.Drawing.Size(500, 1);
			this.line4.TabIndex = 24;
			this.line4.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.percentLabel.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.percentLabel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.percentLabel.Location = new global::System.Drawing.Point(18, 100);
			this.percentLabel.Name = "percentLabel";
			this.percentLabel.Size = new global::System.Drawing.Size(74, 19);
			this.percentLabel.TabIndex = 25;
			this.percentLabel.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.simpleDownloadProgressBar.BackColor = global::System.Drawing.Color.White;
			this.simpleDownloadProgressBar.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.simpleDownloadProgressBar.Location = new global::System.Drawing.Point(21, 74);
			this.simpleDownloadProgressBar.Name = "simpleDownloadProgressBar";
			this.simpleDownloadProgressBar.Size = new global::System.Drawing.Size(461, 23);
			this.simpleDownloadProgressBar.TabIndex = 3;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = global::System.Drawing.Color.White;
			base.CausesValidation = false;
			base.ClientSize = new global::System.Drawing.Size(502, 148);
			base.ControlBox = false;
			base.Controls.Add(this.UpTilePanel);
			base.Controls.Add(this.simpleDownloadProgressBar);
			base.Controls.Add(this.StatusLabel);
			base.Controls.Add(this.CancelButton);
			base.Controls.Add(this.line4);
			base.Controls.Add(this.line3);
			base.Controls.Add(this.line2);
			base.Controls.Add(this.line1);
			base.Controls.Add(this.RemainingTimeLabel);
			base.Controls.Add(this.percentLabel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(502, 148);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(502, 148);
			base.Name = "UpdateForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Download progress";
			base.Load += new global::System.EventHandler(this.UpdateForm_Load);
			this.UpTilePanel.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000A0 RID: 160
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000A1 RID: 161
		private new global::System.Windows.Forms.Button CancelButton;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Label StatusLabel;

		// Token: 0x040000A3 RID: 163
		private global::CustomControls.ProgressAsync simpleDownloadProgressBar;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.Label RemainingTimeLabel;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.Panel UpTilePanel;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.Label TitleLabel;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Label line1;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.Label line2;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Label line3;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Label line4;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.Label percentLabel;
	}
}
