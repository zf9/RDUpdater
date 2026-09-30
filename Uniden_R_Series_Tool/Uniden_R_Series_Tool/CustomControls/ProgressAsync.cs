using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
	// Token: 0x02000031 RID: 49
	public class ProgressAsync : ProgressBar
	{
		// Token: 0x06000207 RID: 519 RVA: 0x000231BA File Offset: 0x000213BA
		public void SetDarkMode()
		{
			base.SetStyle(ControlStyles.UserPaint, true);
			this.ForeColor = Color.White;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000231D0 File Offset: 0x000213D0
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			Graphics graphics = pevent.Graphics;
			double num = ((double)base.Value - (double)base.Minimum) / ((double)base.Maximum - (double)base.Minimum);
			int x = (int)((double)base.Width * num);
			Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
			using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(10, 10, 10)))
			{
				rect.X = x;
				graphics.FillRectangle(solidBrush, rect);
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00023268 File Offset: 0x00021468
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			double num = ((double)base.Value - (double)base.Minimum) / ((double)base.Maximum - (double)base.Minimum);
			int num2 = (int)((double)base.Width * num);
			Rectangle rect = new Rectangle(0, 0, num2, base.Height);
			using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(100, 100, 100)))
			{
				if (num2 > 1)
				{
					graphics.FillRectangle(solidBrush, rect);
				}
			}
		}
	}
}
