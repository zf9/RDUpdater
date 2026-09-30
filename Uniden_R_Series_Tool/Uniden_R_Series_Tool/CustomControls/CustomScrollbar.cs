using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
	// Token: 0x02000030 RID: 48
	public class CustomScrollbar : UserControl
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060001E5 RID: 485 RVA: 0x00022538 File Offset: 0x00020738
		// (remove) Token: 0x060001E6 RID: 486 RVA: 0x00022570 File Offset: 0x00020770
		public new event EventHandler Scroll;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001E7 RID: 487 RVA: 0x000225A8 File Offset: 0x000207A8
		// (remove) Token: 0x060001E8 RID: 488 RVA: 0x000225E0 File Offset: 0x000207E0
		public event EventHandler ValueChanged;

		// Token: 0x060001E9 RID: 489 RVA: 0x00022618 File Offset: 0x00020818
		private int GetThumbHeight()
		{
			int num = base.Height - 36;
			int num2 = (int)((float)this.LargeChange / (float)this.Maximum * (float)num);
			if (num2 > num)
			{
				num2 = num;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00022650 File Offset: 0x00020850
		public CustomScrollbar()
		{
			this.InitializeComponent();
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			this.moChannelColor = Color.FromArgb(130, 130, 130);
			this.moBorderColor = Color.FromArgb(130, 130, 130);
			this.moThumbColor = Color.FromArgb(60, 60, 60);
			this.moButtonFaceColor = Color.FromArgb(60, 60, 60);
			this.moArrowColor = Color.FromArgb(255, 255, 255);
			base.Width = 18;
			base.MinimumSize = new Size(18, 36);
			base.MinimumSize = new Size(18, 10000);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00022AA1 File Offset: 0x00020CA1
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00022AA9 File Offset: 0x00020CA9
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Behavior")]
		[Description("LargeChange")]
		public int LargeChange
		{
			get
			{
				return this.moLargeChange;
			}
			set
			{
				this.moLargeChange = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00022AB8 File Offset: 0x00020CB8
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00022AC0 File Offset: 0x00020CC0
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Behavior")]
		[Description("SmallChange")]
		public int SmallChange
		{
			get
			{
				return this.moSmallChange;
			}
			set
			{
				this.moSmallChange = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00022ACF File Offset: 0x00020CCF
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00022AD7 File Offset: 0x00020CD7
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Behavior")]
		[Description("Minimum")]
		public int Minimum
		{
			get
			{
				return this.moMinimum;
			}
			set
			{
				this.moMinimum = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00022AE6 File Offset: 0x00020CE6
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00022AEE File Offset: 0x00020CEE
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Behavior")]
		[Description("Maximum")]
		public int Maximum
		{
			get
			{
				return this.moMaximum;
			}
			set
			{
				this.moMaximum = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00022AFD File Offset: 0x00020CFD
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00022B08 File Offset: 0x00020D08
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Behavior")]
		[Description("Value")]
		public int Value
		{
			get
			{
				return this.moValue;
			}
			set
			{
				this.moValue = value;
				int num = base.Height - 36;
				int num2 = (int)((float)this.LargeChange / (float)this.Maximum * (float)num);
				if (num2 > num)
				{
					num2 = num;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
				int num3 = num - num2;
				int num4 = this.Maximum - this.Minimum - this.LargeChange;
				float num5 = 0f;
				if (num4 != 0)
				{
					num5 = (float)this.moValue / (float)num4;
				}
				float num6 = num5 * (float)num3;
				this.moThumbTop = (int)num6;
				base.Invalidate();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00022B8B File Offset: 0x00020D8B
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00022B93 File Offset: 0x00020D93
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Skin")]
		[Description("Channel Color")]
		public Color ChannelColor
		{
			get
			{
				return this.moChannelColor;
			}
			set
			{
				this.moChannelColor = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00022B9C File Offset: 0x00020D9C
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00022BA4 File Offset: 0x00020DA4
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Skin")]
		[Description("Border Color")]
		public Color BorderColor
		{
			get
			{
				return this.moBorderColor;
			}
			set
			{
				this.moBorderColor = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00022BAD File Offset: 0x00020DAD
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00022BB5 File Offset: 0x00020DB5
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Skin")]
		[Description("Thumb Color")]
		public Color ThumbColor
		{
			get
			{
				return this.moThumbColor;
			}
			set
			{
				this.moThumbColor = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00022BBE File Offset: 0x00020DBE
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00022BC6 File Offset: 0x00020DC6
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Skin")]
		[Description("Button Face Color")]
		public Color ButtonFaceColor
		{
			get
			{
				return this.moButtonFaceColor;
			}
			set
			{
				this.moButtonFaceColor = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00022BCF File Offset: 0x00020DCF
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00022BD7 File Offset: 0x00020DD7
		[EditorBrowsable(EditorBrowsableState.Always)]
		[Browsable(true)]
		[DefaultValue(false)]
		[Category("Skin")]
		[Description("Arrow Color")]
		public Color ArrowColor
		{
			get
			{
				return this.moArrowColor;
			}
			set
			{
				this.moArrowColor = value;
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00022BE0 File Offset: 0x00020DE0
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
			Brush brush = new SolidBrush(this.moChannelColor);
			Brush brush2 = new SolidBrush(this.moBorderColor);
			e.Graphics.FillRectangle(brush2, new Rectangle(0, 0, base.Width, base.Height));
			e.Graphics.FillRectangle(brush, new Rectangle(1, 18, base.Width - 2, base.Height - 18 - 18));
			Pen pen = new Pen(this.moButtonFaceColor, 1f);
			Pen pen2 = new Pen(this.moArrowColor, 1f);
			for (int i = 0; i < 15; i++)
			{
				for (int j = 0; j < 13; j++)
				{
					if ((this.upArrowBitmap[i][j / 8] >> 7 - j % 8 & 1) == 1)
					{
						e.Graphics.DrawRectangle(pen, new Rectangle(2 + j, 1 + i, 1, 1));
					}
					else
					{
						e.Graphics.DrawRectangle(pen2, new Rectangle(2 + j, 1 + i, 1, 1));
					}
				}
			}
			for (int i = 0; i < 15; i++)
			{
				for (int j = 0; j < 13; j++)
				{
					if ((this.downArrowBitmap[i][j / 8] >> 7 - j % 8 & 1) == 1)
					{
						e.Graphics.DrawRectangle(pen, new Rectangle(2 + j, base.Height - 17 + i, 1, 1));
					}
					else
					{
						e.Graphics.DrawRectangle(pen2, new Rectangle(2 + j, base.Height - 17 + i, 1, 1));
					}
				}
			}
			int num = base.Height - 36;
			int num2 = (int)((float)this.LargeChange / (float)this.Maximum * (float)num);
			if (num2 > num)
			{
				num2 = num;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			Brush brush3 = new SolidBrush(this.moThumbColor);
			e.Graphics.FillRectangle(brush3, new Rectangle(2, this.moThumbTop + 18, base.Width - 4, num2));
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00022DC6 File Offset: 0x00020FC6
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00022DCE File Offset: 0x00020FCE
		public override bool AutoSize
		{
			get
			{
				return base.AutoSize;
			}
			set
			{
				base.AutoSize = value;
				if (base.AutoSize)
				{
					base.Width = 18;
				}
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00022DE8 File Offset: 0x00020FE8
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.Name = "CustomScrollbar";
			base.MouseDown += this.CustomScrollbar_MouseDown;
			base.MouseMove += this.CustomScrollbar_MouseMove;
			base.MouseUp += this.CustomScrollbar_MouseUp;
			base.ResumeLayout(false);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00022E44 File Offset: 0x00021044
		private void CustomScrollbar_MouseDown(object sender, MouseEventArgs e)
		{
			Point pt = base.PointToClient(Cursor.Position);
			int num = base.Height - 36;
			int num2 = (int)((float)this.LargeChange / (float)this.Maximum * (float)num);
			if (num2 > num)
			{
				num2 = num;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			int num3 = this.moThumbTop;
			num3 += 18;
			Rectangle rectangle = new Rectangle(new Point(1, num3), new Size(base.Width - 2, num2));
			if (rectangle.Contains(pt))
			{
				this.nClickPoint = pt.Y - num3;
				this.moThumbDown = true;
			}
			Rectangle rectangle2 = new Rectangle(new Point(1, 0), new Size(18, 18));
			if (rectangle2.Contains(pt))
			{
				int num4 = this.Maximum - this.Minimum - this.LargeChange;
				int num5 = num - num2;
				if (num4 > 0 && num5 > 0)
				{
					if (this.moThumbTop - this.SmallChange < 0)
					{
						this.moThumbTop = 0;
					}
					else
					{
						this.moThumbTop -= this.SmallChange;
					}
					float num6 = (float)this.moThumbTop / (float)num5 * (float)(this.Maximum - this.LargeChange);
					this.moValue = (int)num6;
					if (this.ValueChanged != null)
					{
						this.ValueChanged(this, new EventArgs());
					}
					if (this.Scroll != null)
					{
						this.Scroll(this, new EventArgs());
					}
					base.Invalidate();
				}
			}
			Rectangle rectangle3 = new Rectangle(new Point(1, 18 + num), new Size(18, 18));
			if (rectangle3.Contains(pt))
			{
				int num7 = this.Maximum - this.Minimum - this.LargeChange;
				int num8 = num - num2;
				if (num7 > 0 && num8 > 0)
				{
					if (this.moThumbTop + this.SmallChange > num8)
					{
						this.moThumbTop = num8;
					}
					else
					{
						this.moThumbTop += this.SmallChange;
					}
					float num9 = (float)this.moThumbTop / (float)num8 * (float)(this.Maximum - this.LargeChange);
					this.moValue = (int)num9;
					if (this.ValueChanged != null)
					{
						this.ValueChanged(this, new EventArgs());
					}
					if (this.Scroll != null)
					{
						this.Scroll(this, new EventArgs());
					}
					base.Invalidate();
				}
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0002307C File Offset: 0x0002127C
		private void CustomScrollbar_MouseUp(object sender, MouseEventArgs e)
		{
			this.moThumbDown = false;
			this.moThumbDragging = false;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0002308C File Offset: 0x0002128C
		private void MoveThumb(int y)
		{
			int num = this.Maximum - this.Minimum;
			int num2 = base.Height - 36;
			int num3 = (int)((float)this.LargeChange / (float)this.Maximum * (float)num2);
			if (num3 > num2)
			{
				num3 = num2;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			int num4 = this.nClickPoint;
			int num5 = num2 - num3;
			if (this.moThumbDown && num > 0 && num5 > 0)
			{
				int num6 = y - (18 + num4);
				if (num6 < 0)
				{
					this.moThumbTop = 0;
				}
				else if (num6 > num5)
				{
					this.moThumbTop = num5;
				}
				else
				{
					this.moThumbTop = y - (18 + num4);
				}
				float num7 = (float)this.moThumbTop / (float)num5 * (float)(this.Maximum - this.LargeChange);
				this.moValue = (int)num7;
				Application.DoEvents();
				base.Invalidate();
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00023158 File Offset: 0x00021358
		private void CustomScrollbar_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.moThumbDown)
			{
				this.moThumbDragging = true;
			}
			if (this.moThumbDragging)
			{
				this.MoveThumb(e.Y);
			}
			if (this.ValueChanged != null)
			{
				this.ValueChanged(this, new EventArgs());
			}
			if (this.Scroll != null)
			{
				this.Scroll(this, new EventArgs());
			}
		}

		// Token: 0x04000397 RID: 919
		protected byte[][] upArrowBitmap = new byte[][]
		{
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				252,
				252
			},
			new byte[]
			{
				248,
				124
			},
			new byte[]
			{
				240,
				60
			},
			new byte[]
			{
				224,
				28
			},
			new byte[]
			{
				195,
				12
			},
			new byte[]
			{
				199,
				140
			},
			new byte[]
			{
				239,
				220
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			}
		};

		// Token: 0x04000398 RID: 920
		protected byte[][] downArrowBitmap = new byte[][]
		{
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				239,
				220
			},
			new byte[]
			{
				199,
				140
			},
			new byte[]
			{
				195,
				12
			},
			new byte[]
			{
				224,
				28
			},
			new byte[]
			{
				240,
				60
			},
			new byte[]
			{
				248,
				124
			},
			new byte[]
			{
				252,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			},
			new byte[]
			{
				byte.MaxValue,
				252
			}
		};

		// Token: 0x04000399 RID: 921
		protected Color moChannelColor = Color.Empty;

		// Token: 0x0400039A RID: 922
		protected Color moBorderColor = Color.Empty;

		// Token: 0x0400039B RID: 923
		protected Color moThumbColor = Color.Empty;

		// Token: 0x0400039C RID: 924
		protected Color moButtonFaceColor = Color.Empty;

		// Token: 0x0400039D RID: 925
		protected Color moArrowColor = Color.Empty;

		// Token: 0x0400039E RID: 926
		protected int moLargeChange = 10;

		// Token: 0x0400039F RID: 927
		protected int moSmallChange = 1;

		// Token: 0x040003A0 RID: 928
		protected int moMinimum;

		// Token: 0x040003A1 RID: 929
		protected int moMaximum = 100;

		// Token: 0x040003A2 RID: 930
		protected int moValue;

		// Token: 0x040003A3 RID: 931
		private int nClickPoint;

		// Token: 0x040003A4 RID: 932
		protected int moThumbTop;

		// Token: 0x040003A5 RID: 933
		protected bool moAutoSize;

		// Token: 0x040003A6 RID: 934
		private bool moThumbDown;

		// Token: 0x040003A7 RID: 935
		private bool moThumbDragging;
	}
}
