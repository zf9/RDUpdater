using System;
using System.Drawing;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000007 RID: 7
	public class UserMarkPoint : Button
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00006C94 File Offset: 0x00004E94
		public UserMarkPoint(UserMark userMark, bool isDarkMode)
		{
			base.FlatStyle = FlatStyle.Flat;
			base.FlatAppearance.BorderSize = 0;
			base.Size = new Size(180, 40);
			this.Dock = DockStyle.Top;
			this.Text = "User Mark";
			base.TabStop = false;
			if (isDarkMode)
			{
				this.ForeColor = SystemColors.ButtonFace;
				base.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				base.FlatAppearance.MouseDownBackColor = Color.FromArgb(110, 110, 110);
			}
			this.info = userMark;
		}

		// Token: 0x04000054 RID: 84
		public bool isSelected;

		// Token: 0x04000055 RID: 85
		public UserMark info;
	}
}
