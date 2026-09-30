using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000020 RID: 32
	public partial class UserKBlockFilterEditor : Form
	{
		// Token: 0x06000179 RID: 377 RVA: 0x0001A370 File Offset: 0x00018570
		public UserKBlockFilterEditor(bool isDarkMode, int userKBlockCnt, bool useDirFlag)
		{
			int num = 10;
			int num2 = 35;
			this.InitializeComponent();
			this.isDarkMode = isDarkMode;
			if (isDarkMode)
			{
				this.SetDarkMode();
			}
			int width;
			if (userKBlockCnt / 3 > 0)
			{
				width = 1030;
			}
			else
			{
				width = 340 * (userKBlockCnt % 3) + 10;
			}
			int height;
			if (useDirFlag)
			{
				height = 175 + 155 * (userKBlockCnt / 3) + 10 + 45;
			}
			else
			{
				height = 145 + 125 * (userKBlockCnt / 3) + 10 + 45;
			}
			base.Size = new Size(width, height);
			this.userKBlockFilter = new UserKBlockFilterComboBox[userKBlockCnt];
			for (int i = 0; i < userKBlockCnt; i++)
			{
				Point location = new Point(num, num2);
				this.userKBlockFilter[i] = new UserKBlockFilterComboBox(isDarkMode, i + 1, 23900, 24250, 23924, 23929, UserKBlockFilterComboBox.DIR_TYPE.DIR_FRONT, 8, 4, false);
				this.userKBlockFilter[i].Location = location;
				if ((i + 1) % 3 == 0)
				{
					num = 10;
					if (useDirFlag)
					{
						num2 += 155;
					}
					else
					{
						num2 += 125;
					}
				}
				else
				{
					num += 340;
				}
			}
			base.Controls.AddRange(this.userKBlockFilter);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001A494 File Offset: 0x00018694
		private void SetDarkMode()
		{
			this.UpTilePanel.BackColor = Color.Black;
			this.TitleLabel.ForeColor = SystemColors.ButtonFace;
			this.UpCloseButton.ForeColor = SystemColors.ButtonFace;
			this.BackColor = Color.FromArgb(30, 30, 30);
			this.UpdateButton.FlatStyle = FlatStyle.Flat;
			this.CancelButton.FlatStyle = FlatStyle.Flat;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00005237 File Offset: 0x00003437
		private void UpdateButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005237 File Offset: 0x00003437
		private void CancelButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0001A4FC File Offset: 0x000186FC
		private void FormMouseDown(object sender, MouseEventArgs e)
		{
			this.TagMove = true;
			this.MValX = e.X;
			this.MValY = e.Y;
			if (sender.Equals(this.TitleLabel))
			{
				this.MValX += 4;
				this.MValY += 6;
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0001A554 File Offset: 0x00018754
		private void FormMouseMove(object sender, MouseEventArgs e)
		{
			if (this.TagMove)
			{
				base.SetDesktopLocation(Control.MousePosition.X - this.MValX, Control.MousePosition.Y - this.MValY);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0001A597 File Offset: 0x00018797
		private void FormMouseUp(object sender, MouseEventArgs e)
		{
			this.TagMove = false;
		}

		// Token: 0x04000310 RID: 784
		private UserKBlockFilterComboBox[] userKBlockFilter;

		// Token: 0x04000311 RID: 785
		private bool isDarkMode;

		// Token: 0x04000312 RID: 786
		private bool TagMove;

		// Token: 0x04000313 RID: 787
		private int MValX;

		// Token: 0x04000314 RID: 788
		private int MValY;
	}
}
