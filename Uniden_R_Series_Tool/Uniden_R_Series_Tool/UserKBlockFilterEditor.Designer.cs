namespace Uniden_R_Series_Tool
{
	// Token: 0x02000020 RID: 32
	public partial class UserKBlockFilterEditor : global::System.Windows.Forms.Form
	{
		// Token: 0x06000180 RID: 384 RVA: 0x0001A5A0 File Offset: 0x000187A0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0001A5C0 File Offset: 0x000187C0
		private void InitializeComponent()
		{
			this.line4 = new global::System.Windows.Forms.Label();
			this.line3 = new global::System.Windows.Forms.Label();
			this.line1 = new global::System.Windows.Forms.Label();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.UpTilePanel = new global::System.Windows.Forms.Panel();
			this.UpCloseButton = new global::System.Windows.Forms.Button();
			this.line2 = new global::System.Windows.Forms.Label();
			this.UpdateButton = new global::System.Windows.Forms.Button();
			this.CancelButton = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.UpTilePanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.line4.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.line4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line4.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line4.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line4.Location = new global::System.Drawing.Point(1, 194);
			this.line4.Name = "line4";
			this.line4.Size = new global::System.Drawing.Size(348, 1);
			this.line4.TabIndex = 40;
			this.line4.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.line3.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.line3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line3.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line3.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line3.Location = new global::System.Drawing.Point(1, 0);
			this.line3.Name = "line3";
			this.line3.Size = new global::System.Drawing.Size(348, 1);
			this.line3.TabIndex = 39;
			this.line3.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.line1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line1.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.line1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line1.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line1.Location = new global::System.Drawing.Point(0, 0);
			this.line1.Name = "line1";
			this.line1.Size = new global::System.Drawing.Size(1, 195);
			this.line1.TabIndex = 37;
			this.line1.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.TitleLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TitleLabel.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.TitleLabel.Location = new global::System.Drawing.Point(3, 5);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new global::System.Drawing.Size(260, 16);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "User K Block Filter Editor";
			this.TitleLabel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
			this.TitleLabel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
			this.TitleLabel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
			this.UpTilePanel.BackColor = global::System.Drawing.Color.FromArgb(234, 235, 235);
			this.UpTilePanel.Controls.Add(this.UpCloseButton);
			this.UpTilePanel.Controls.Add(this.TitleLabel);
			this.UpTilePanel.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.UpTilePanel.ForeColor = global::System.Drawing.Color.Black;
			this.UpTilePanel.Location = new global::System.Drawing.Point(1, 1);
			this.UpTilePanel.Name = "UpTilePanel";
			this.UpTilePanel.Size = new global::System.Drawing.Size(348, 29);
			this.UpTilePanel.TabIndex = 36;
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
			this.UpCloseButton.Location = new global::System.Drawing.Point(316, 0);
			this.UpCloseButton.Name = "UpCloseButton";
			this.UpCloseButton.Size = new global::System.Drawing.Size(32, 29);
			this.UpCloseButton.TabIndex = 34;
			this.UpCloseButton.TabStop = false;
			this.UpCloseButton.Text = "X";
			this.UpCloseButton.UseVisualStyleBackColor = true;
			this.UpCloseButton.Click += new global::System.EventHandler(this.CancelButton_Click);
			this.line2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.line2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.line2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.line2.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.line2.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.line2.Location = new global::System.Drawing.Point(349, 0);
			this.line2.Name = "line2";
			this.line2.Size = new global::System.Drawing.Size(1, 195);
			this.line2.TabIndex = 38;
			this.line2.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.UpdateButton.BackColor = global::System.Drawing.Color.Black;
			this.UpdateButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.UpdateButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.UpdateButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.UpdateButton.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.UpdateButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.UpdateButton.Location = new global::System.Drawing.Point(35, 9);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new global::System.Drawing.Size(75, 26);
			this.UpdateButton.TabIndex = 32;
			this.UpdateButton.Text = "Save";
			this.UpdateButton.UseVisualStyleBackColor = false;
			this.CancelButton.BackColor = global::System.Drawing.Color.Black;
			this.CancelButton.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(105, 102, 115);
			this.CancelButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(90, 90, 90);
			this.CancelButton.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.CancelButton.Font = new global::System.Drawing.Font("Calibri", 11f);
			this.CancelButton.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.CancelButton.Location = new global::System.Drawing.Point(116, 9);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new global::System.Drawing.Size(75, 26);
			this.CancelButton.TabIndex = 33;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = false;
			this.CancelButton.Click += new global::System.EventHandler(this.CancelButton_Click);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new global::System.Drawing.Point(1, 150);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(348, 44);
			this.panel1.TabIndex = 41;
			this.panel2.Controls.Add(this.CancelButton);
			this.panel2.Controls.Add(this.UpdateButton);
			this.panel2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new global::System.Drawing.Point(148, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(200, 44);
			this.panel2.TabIndex = 34;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(350, 195);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.UpTilePanel);
			base.Controls.Add(this.line4);
			base.Controls.Add(this.line3);
			base.Controls.Add(this.line1);
			base.Controls.Add(this.line2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "UserKBlockFilterEditor";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "UserKBlockFilterEditor";
			this.UpTilePanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000315 RID: 789
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000316 RID: 790
		private global::System.Windows.Forms.Label line4;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.Forms.Label line3;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.Label line1;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Forms.Label TitleLabel;

		// Token: 0x0400031A RID: 794
		private global::System.Windows.Forms.Panel UpTilePanel;

		// Token: 0x0400031B RID: 795
		private global::System.Windows.Forms.Label line2;

		// Token: 0x0400031C RID: 796
		private global::System.Windows.Forms.Button UpCloseButton;

		// Token: 0x0400031D RID: 797
		private global::System.Windows.Forms.Button UpdateButton;

		// Token: 0x0400031E RID: 798
		private new global::System.Windows.Forms.Button CancelButton;

		// Token: 0x0400031F RID: 799
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000320 RID: 800
		private global::System.Windows.Forms.Panel panel2;
	}
}
