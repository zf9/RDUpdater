namespace Uniden_R_Series_Tool
{
	// Token: 0x0200001E RID: 30
	public partial class LoadingForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000175 RID: 373 RVA: 0x0001A134 File Offset: 0x00018334
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0001A154 File Offset: 0x00018354
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Uniden_R_Series_Tool.LoadingForm));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = global::Uniden_R_Series_Tool.Properties.Resources.uniden_logo2;
			this.pictureBox1.Location = new global::System.Drawing.Point(9, -9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(374, 151);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.UseWaitCursor = true;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.Black;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(386, 134);
			base.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(386, 134);
			this.MinimumSize = new global::System.Drawing.Size(386, 134);
			base.Name = "LoadingForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Uniden";
			base.TransparencyKey = global::System.Drawing.Color.Gray;
			base.UseWaitCursor = true;
			base.Load += new global::System.EventHandler(this.LoadingForm_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400030E RID: 782
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400030F RID: 783
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
