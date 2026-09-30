using System;
using System.Drawing;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000008 RID: 8
	public class MuteMemoryPoint : Button
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00006D28 File Offset: 0x00004F28
		public MuteMemoryPoint(MuteMemory muteMemory, bool isDarkMode)
		{
			string text;
			if (muteMemory.isAutoMuteMemory)
			{
				text = string.Concat(new string[]
				{
					muteMemory.band,
					" ",
					muteMemory.freqStr,
					" (",
					muteMemory.autoMuteCnt.ToString(),
					")"
				});
			}
			else
			{
				text = muteMemory.band + " " + muteMemory.freqStr;
			}
			base.FlatStyle = FlatStyle.Flat;
			base.FlatAppearance.BorderSize = 0;
			base.Size = new Size(180, 40);
			this.Dock = DockStyle.Top;
			this.Text = text;
			base.TabStop = false;
			if (isDarkMode)
			{
				this.ForeColor = SystemColors.ButtonFace;
				base.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90);
				base.FlatAppearance.MouseDownBackColor = Color.FromArgb(110, 110, 110);
			}
			this.info = muteMemory;
		}

		// Token: 0x04000056 RID: 86
		public bool isSelected;

		// Token: 0x04000057 RID: 87
		public MuteMemory info;
	}
}
