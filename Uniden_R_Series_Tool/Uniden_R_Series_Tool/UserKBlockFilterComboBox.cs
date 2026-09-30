using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000021 RID: 33
	public class UserKBlockFilterComboBox : GroupBox
	{
		// Token: 0x06000182 RID: 386 RVA: 0x0001AF84 File Offset: 0x00019184
		public UserKBlockFilterComboBox(bool isDarkMode, int filterNumber, int freqMinRange, int freqMaxRange, int freqMinValue, int freqMaxValue, UserKBlockFilterComboBox.DIR_TYPE dir, int maxLevel, int level, bool onFlag)
		{
			this.isDarkMode = isDarkMode;
			this.displayControl(isDarkMode, filterNumber, freqMinRange, freqMaxRange, true, maxLevel);
			this.SetControlValue(freqMinValue, freqMaxValue, dir, level, onFlag);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0001B058 File Offset: 0x00019258
		public UserKBlockFilterComboBox(bool isDarkMode, int filterNumber, int freqMinRange, int freqMaxRange, int freqMinValue, int freqMaxValue, int maxLevel, int level, bool onFlag)
		{
			this.isDarkMode = isDarkMode;
			this.displayControl(isDarkMode, filterNumber, freqMinRange, freqMaxRange, false, maxLevel);
			this.SetControlValue(freqMinValue, freqMaxValue, UserKBlockFilterComboBox.DIR_TYPE.NOT_USED, level, onFlag);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0001B12C File Offset: 0x0001932C
		protected override void OnPaint(PaintEventArgs e)
		{
			Color color;
			if (this.isDarkMode)
			{
				color = Color.FromArgb(100, 100, 100);
			}
			else
			{
				color = Color.FromArgb(220, 220, 220);
			}
			Rectangle clip = new Rectangle(0, 0, 1000, 1000);
			e.Graphics.SetClip(clip);
			Size size = TextRenderer.MeasureText(this.Text, this.Font);
			Rectangle clipRectangle = e.ClipRectangle;
			clipRectangle.X = 0;
			clipRectangle.Y = 7;
			clipRectangle.Width = base.ClientRectangle.Width;
			clipRectangle.Height = base.ClientRectangle.Height - 8;
			ControlPaint.DrawBorder(e.Graphics, clipRectangle, color, ButtonBorderStyle.Solid);
			Rectangle clipRectangle2 = e.ClipRectangle;
			clipRectangle2.X = 12;
			clipRectangle2.Y = 0;
			clipRectangle2.Width = size.Width + 2;
			clipRectangle2.Height = size.Height;
			e.Graphics.FillRectangle(new SolidBrush(this.BackColor), clipRectangle2);
			e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), clipRectangle2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0001B260 File Offset: 0x00019460
		private string dirTypeToString(UserKBlockFilterComboBox.DIR_TYPE dir)
		{
			switch (dir)
			{
			case UserKBlockFilterComboBox.DIR_TYPE.DIR_FRONT:
				return "Front";
			case UserKBlockFilterComboBox.DIR_TYPE.DIR_REAR:
				return "Rear";
			case UserKBlockFilterComboBox.DIR_TYPE.DIR_SIDE:
				return "Side";
			}
			return null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0001B290 File Offset: 0x00019490
		private void displayControl(bool isDarkMode, int filterNumber, int freqMinRange, int freqMaxRange, bool usedDir, int maxLevel)
		{
			Color backColor;
			Color foreColor;
			if (isDarkMode)
			{
				backColor = Color.FromArgb(30, 30, 30);
				foreColor = SystemColors.ButtonFace;
				this.freqMinCombo.FlatStyle = FlatStyle.Flat;
				this.freqMaxCombo.FlatStyle = FlatStyle.Flat;
				this.directionCombo.FlatStyle = FlatStyle.Flat;
				this.levelCombo.FlatStyle = FlatStyle.Flat;
			}
			else
			{
				backColor = SystemColors.Control;
				foreColor = Color.Black;
			}
			int num = 0;
			this.GroupLable.Location = new Point(15, num);
			this.GroupLable.Text = "User K Block" + filterNumber.ToString() + " Filter";
			this.GroupLable.Font = new Font("Calibri", 10f);
			this.GroupLable.AutoSize = true;
			this.GroupLable.ForeColor = foreColor;
			base.Controls.Add(this.GroupLable);
			num += 28;
			this.freqLabel.Location = new Point(15, num);
			this.freqLabel.Text = "Frequence";
			this.freqLabel.Font = new Font("Calibri", 10f);
			this.freqLabel.ForeColor = foreColor;
			this.freqLabel.AutoSize = true;
			base.Controls.Add(this.freqLabel);
			this.freqColonLabel.Location = new Point(90, num);
			this.freqColonLabel.Text = ":";
			this.freqColonLabel.Font = new Font("Calibri", 10f);
			this.freqColonLabel.ForeColor = foreColor;
			this.freqColonLabel.AutoSize = true;
			base.Controls.Add(this.freqColonLabel);
			this.freqtildeLabel.Location = new Point(204, num + 2);
			this.freqtildeLabel.Text = "~";
			this.freqtildeLabel.Font = new Font("Calibri", 10f);
			this.freqtildeLabel.ForeColor = foreColor;
			this.freqtildeLabel.AutoSize = true;
			base.Controls.Add(this.freqtildeLabel);
			this.freqMinCombo.Location = new Point(108, num - 1);
			this.freqMinCombo.Items.AddRange((from i in Enumerable.Range(freqMinRange, freqMaxRange - freqMinRange + 1).ToArray<int>()
			select ((double)i / 1000.0).ToString("F3")).ToArray<string>());
			this.freqMinCombo.Size = new Size(90, 23);
			this.freqMinCombo.DropDownStyle = ComboBoxStyle.DropDownList;
			this.freqMinCombo.BackColor = backColor;
			this.freqMinCombo.ForeColor = foreColor;
			base.Controls.Add(this.freqMinCombo);
			this.freqMaxCombo.Location = new Point(222, num - 1);
			this.freqMaxCombo.Items.AddRange((from i in Enumerable.Range(freqMinRange, freqMaxRange - freqMinRange + 1).ToArray<int>()
			select ((double)i / 1000.0).ToString("F3")).ToArray<string>());
			this.freqMaxCombo.Size = new Size(90, 23);
			this.freqMaxCombo.DropDownStyle = ComboBoxStyle.DropDownList;
			this.freqMaxCombo.BackColor = backColor;
			this.freqMaxCombo.ForeColor = foreColor;
			base.Controls.Add(this.freqMaxCombo);
			num += 30;
			if (usedDir)
			{
				this.directionLabel.Location = new Point(15, num);
				this.directionLabel.Text = "Direction";
				this.directionLabel.Font = new Font("Calibri", 10f);
				this.directionLabel.ForeColor = foreColor;
				this.directionLabel.AutoSize = true;
				base.Controls.Add(this.directionLabel);
				this.directionColonLabel.Location = new Point(90, num);
				this.directionColonLabel.Text = ":";
				this.directionColonLabel.Font = new Font("Calibri", 10f);
				this.directionColonLabel.ForeColor = foreColor;
				this.directionColonLabel.AutoSize = true;
				base.Controls.Add(this.directionColonLabel);
				this.directionCombo.Location = new Point(108, num - 1);
				this.directionCombo.Items.AddRange(new string[]
				{
					"Front",
					"Rear",
					"Side"
				});
				this.directionCombo.Size = new Size(90, 23);
				this.directionCombo.DropDownStyle = ComboBoxStyle.DropDownList;
				this.directionCombo.BackColor = backColor;
				this.directionCombo.ForeColor = foreColor;
				base.Controls.Add(this.directionCombo);
				num += 30;
			}
			this.levelLabel.Location = new Point(15, num);
			this.levelLabel.Text = "level";
			this.levelLabel.Font = new Font("Calibri", 10f);
			this.levelLabel.ForeColor = foreColor;
			this.levelLabel.AutoSize = true;
			base.Controls.Add(this.levelLabel);
			this.levelColonLabel.Location = new Point(90, num);
			this.levelColonLabel.Text = ":";
			this.levelColonLabel.Font = new Font("Calibri", 10f);
			this.levelColonLabel.ForeColor = foreColor;
			this.levelColonLabel.AutoSize = true;
			base.Controls.Add(this.levelColonLabel);
			this.levelCombo.Location = new Point(108, num - 1);
			this.levelCombo.Items.AddRange((from i in Enumerable.Range(0, maxLevel + 2).ToArray<int>()
			select i.ToString()).ToArray<string>());
			this.levelCombo.Size = new Size(90, 23);
			this.levelCombo.DropDownStyle = ComboBoxStyle.DropDownList;
			this.levelCombo.BackColor = backColor;
			this.levelCombo.ForeColor = foreColor;
			base.Controls.Add(this.levelCombo);
			num += 30;
			this.onRadioButton.Location = new Point(233, num);
			this.onRadioButton.Text = "On";
			this.onRadioButton.Font = new Font("Calibri", 10f);
			this.onRadioButton.ForeColor = foreColor;
			this.onRadioButton.AutoSize = true;
			base.Controls.Add(this.onRadioButton);
			this.offRadioButton.Location = new Point(281, num);
			this.offRadioButton.Text = "Off";
			this.offRadioButton.Font = new Font("Calibri", 10f);
			this.offRadioButton.ForeColor = foreColor;
			this.offRadioButton.AutoSize = true;
			base.Controls.Add(this.offRadioButton);
			base.Size = new Size(330, 27 + num);
			this.onRadioButton.CheckedChanged += this.onoffRadioButton_CheckedChanged;
			this.offRadioButton.CheckedChanged += this.onoffRadioButton_CheckedChanged;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001B9EC File Offset: 0x00019BEC
		private void SetControlValue(int freqMinValue, int freqMaxValue, UserKBlockFilterComboBox.DIR_TYPE dir, int level, bool onFlag)
		{
			this.freqMinCombo.SelectedItem = ((double)freqMinValue / 1000.0).ToString("F3");
			this.freqMaxCombo.SelectedItem = ((double)freqMaxValue / 1000.0).ToString("F3");
			if (dir != UserKBlockFilterComboBox.DIR_TYPE.NOT_USED)
			{
				this.directionCombo.SelectedItem = this.dirTypeToString(dir);
			}
			this.levelCombo.SelectedItem = level.ToString();
			if (onFlag)
			{
				this.onRadioButton.Checked = true;
				return;
			}
			this.offRadioButton.Checked = true;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0001BA88 File Offset: 0x00019C88
		private void onoffRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (this.onRadioButton.Checked)
			{
				if (!this.isDarkMode)
				{
					this.freqLabel.Enabled = true;
					this.freqColonLabel.Enabled = true;
					this.freqtildeLabel.Enabled = true;
					this.directionLabel.Enabled = true;
					this.directionColonLabel.Enabled = true;
					this.levelLabel.Enabled = true;
					this.levelColonLabel.Enabled = true;
				}
				this.freqMinCombo.Enabled = true;
				this.freqMaxCombo.Enabled = true;
				this.directionCombo.Enabled = true;
				this.levelCombo.Enabled = true;
				return;
			}
			if (this.offRadioButton.Checked)
			{
				if (!this.isDarkMode)
				{
					this.freqLabel.Enabled = false;
					this.freqColonLabel.Enabled = false;
					this.freqtildeLabel.Enabled = false;
					this.directionLabel.Enabled = false;
					this.directionColonLabel.Enabled = false;
					this.levelLabel.Enabled = false;
					this.levelColonLabel.Enabled = false;
				}
				this.freqMinCombo.Enabled = false;
				this.freqMaxCombo.Enabled = false;
				this.directionCombo.Enabled = false;
				this.levelCombo.Enabled = false;
			}
		}

		// Token: 0x04000321 RID: 801
		private bool isDarkMode;

		// Token: 0x04000322 RID: 802
		private Label GroupLable = new Label();

		// Token: 0x04000323 RID: 803
		private Label freqLabel = new Label();

		// Token: 0x04000324 RID: 804
		private Label freqColonLabel = new Label();

		// Token: 0x04000325 RID: 805
		private Label freqtildeLabel = new Label();

		// Token: 0x04000326 RID: 806
		private ComboBox freqMinCombo = new ComboBox();

		// Token: 0x04000327 RID: 807
		private ComboBox freqMaxCombo = new ComboBox();

		// Token: 0x04000328 RID: 808
		private Label directionLabel = new Label();

		// Token: 0x04000329 RID: 809
		private Label directionColonLabel = new Label();

		// Token: 0x0400032A RID: 810
		private ComboBox directionCombo = new ComboBox();

		// Token: 0x0400032B RID: 811
		private Label levelLabel = new Label();

		// Token: 0x0400032C RID: 812
		private Label levelColonLabel = new Label();

		// Token: 0x0400032D RID: 813
		private ComboBox levelCombo = new ComboBox();

		// Token: 0x0400032E RID: 814
		private RadioButton onRadioButton = new RadioButton();

		// Token: 0x0400032F RID: 815
		private RadioButton offRadioButton = new RadioButton();

		// Token: 0x02000085 RID: 133
		public enum DIR_TYPE
		{
			// Token: 0x040004ED RID: 1261
			DIR_FRONT,
			// Token: 0x040004EE RID: 1262
			DIR_REAR,
			// Token: 0x040004EF RID: 1263
			DIR_SIDE,
			// Token: 0x040004F0 RID: 1264
			NOT_USED
		}
	}
}
