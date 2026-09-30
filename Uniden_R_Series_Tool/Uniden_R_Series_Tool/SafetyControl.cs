using System;
using System.Drawing;
using System.Windows.Forms;
using CustomControls;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200001A RID: 26
	public static class SafetyControl
	{
		// Token: 0x06000131 RID: 305 RVA: 0x00017D1C File Offset: 0x00015F1C
		public static void SetActiveControl(Form form, Control activeControl)
		{
			if (form.InvokeRequired)
			{
				form.Invoke(new MethodInvoker(delegate()
				{
					form.ActiveControl = activeControl;
				}));
				return;
			}
			form.ActiveControl = activeControl;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00017D74 File Offset: 0x00015F74
		public static void SetText(Control control, string text)
		{
			if (control.InvokeRequired)
			{
				control.BeginInvoke(new MethodInvoker(delegate()
				{
					control.Text = text;
				}));
				return;
			}
			control.Text = text;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00017DCC File Offset: 0x00015FCC
		public static void SetText(Label label, string text)
		{
			if (label.InvokeRequired)
			{
				label.BeginInvoke(new MethodInvoker(delegate()
				{
					label.Text = text;
				}));
				return;
			}
			label.Text = text;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00017E24 File Offset: 0x00016024
		public static string GetText(Control control)
		{
			string text = string.Empty;
			if (control.InvokeRequired)
			{
				control.Invoke(new MethodInvoker(delegate()
				{
					text = control.Text;
				}));
			}
			else
			{
				text = control.Text;
			}
			return text;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00017E88 File Offset: 0x00016088
		public static void SetText(RichTextBox richTextBox, string text)
		{
			if (richTextBox.InvokeRequired)
			{
				richTextBox.BeginInvoke(new MethodInvoker(delegate()
				{
					richTextBox.Text = text;
				}));
				return;
			}
			richTextBox.Text = text;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00017EE0 File Offset: 0x000160E0
		public static void SetText(TextBox textBox, string text)
		{
			if (textBox.InvokeRequired)
			{
				textBox.BeginInvoke(new MethodInvoker(delegate()
				{
					textBox.Text = text;
				}));
				return;
			}
			textBox.Text = text;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00017F38 File Offset: 0x00016138
		public static void SetText(Button button, string text)
		{
			if (button.InvokeRequired)
			{
				button.BeginInvoke(new MethodInvoker(delegate()
				{
					button.Text = text;
				}));
				return;
			}
			button.Text = text;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00017F90 File Offset: 0x00016190
		public static void AddText(Label label, string text)
		{
			if (label.InvokeRequired)
			{
				label.BeginInvoke(new MethodInvoker(delegate()
				{
					Label label3 = label;
					label3.Text += text;
				}));
				return;
			}
			Label label2 = label;
			label2.Text += text;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00017FF4 File Offset: 0x000161F4
		public static void SetColor(Label label, Color color)
		{
			if (label.InvokeRequired)
			{
				label.BeginInvoke(new MethodInvoker(delegate()
				{
					label.ForeColor = color;
				}));
				return;
			}
			label.ForeColor = color;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001804C File Offset: 0x0001624C
		public static void SetFontSize(Label label, int size)
		{
			if (label.InvokeRequired)
			{
				label.BeginInvoke(new MethodInvoker(delegate()
				{
					label.Font = new Font(label.Font.Name, (float)size, label.Font.Style, label.Font.Unit);
				}));
				return;
			}
			label.Font = new Font(label.Font.Name, (float)size, label.Font.Style, label.Font.Unit);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000180DC File Offset: 0x000162DC
		public static void SetFront(Label label, bool frontFlag)
		{
			if (label.InvokeRequired)
			{
				if (frontFlag)
				{
					label.BeginInvoke(new MethodInvoker(delegate()
					{
						label.BringToFront();
					}));
					return;
				}
				label.BeginInvoke(new MethodInvoker(delegate()
				{
					label.SendToBack();
				}));
				return;
			}
			else
			{
				if (frontFlag)
				{
					label.BringToFront();
					return;
				}
				label.SendToBack();
				return;
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00018154 File Offset: 0x00016354
		public static void SetEnable(Button button, bool enalbeFlag)
		{
			if (button.InvokeRequired)
			{
				button.BeginInvoke(new MethodInvoker(delegate()
				{
					button.Enabled = enalbeFlag;
				}));
				return;
			}
			button.Enabled = enalbeFlag;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000181AC File Offset: 0x000163AC
		public static void SetEnable(CheckBox checkBox, bool enalbeFlag)
		{
			if (checkBox.InvokeRequired)
			{
				checkBox.BeginInvoke(new MethodInvoker(delegate()
				{
					checkBox.Enabled = enalbeFlag;
				}));
				return;
			}
			checkBox.Enabled = enalbeFlag;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00018204 File Offset: 0x00016404
		public static bool GetChecked(CheckBox checkBox)
		{
			bool flag = false;
			if (checkBox.InvokeRequired)
			{
				checkBox.Invoke(new MethodInvoker(delegate()
				{
					flag = checkBox.Checked;
				}));
			}
			else
			{
				flag = checkBox.Checked;
			}
			return flag;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00018264 File Offset: 0x00016464
		public static void SetValue(ProgressBar progressbar, int value)
		{
			if (progressbar.InvokeRequired)
			{
				progressbar.BeginInvoke(new MethodInvoker(delegate()
				{
					progressbar.Value = value;
				}));
				return;
			}
			progressbar.Value = value;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000182BC File Offset: 0x000164BC
		public static int GetValue(ProgressBar progressbar)
		{
			int value = 0;
			if (progressbar.InvokeRequired)
			{
				progressbar.Invoke(new MethodInvoker(delegate()
				{
					value = progressbar.Value;
				}));
			}
			else
			{
				value = progressbar.Value;
			}
			return value;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0001831C File Offset: 0x0001651C
		public static void SetVisible(Button button, bool flag)
		{
			if (button.InvokeRequired)
			{
				button.BeginInvoke(new MethodInvoker(delegate()
				{
					button.Visible = flag;
				}));
				return;
			}
			button.Visible = flag;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00018374 File Offset: 0x00016574
		public static void SetVisible(Control control, bool flag)
		{
			if (control.InvokeRequired)
			{
				control.BeginInvoke(new MethodInvoker(delegate()
				{
					control.Visible = flag;
				}));
				return;
			}
			control.Visible = flag;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000183CC File Offset: 0x000165CC
		public static void SetVisible(Panel panel, bool flag)
		{
			if (panel.InvokeRequired)
			{
				panel.BeginInvoke(new MethodInvoker(delegate()
				{
					panel.Visible = flag;
				}));
				return;
			}
			panel.Visible = flag;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00018424 File Offset: 0x00016624
		public static void SetVisible(ProgressBar progressbar, bool flag)
		{
			if (progressbar.InvokeRequired)
			{
				progressbar.BeginInvoke(new MethodInvoker(delegate()
				{
					progressbar.Visible = flag;
				}));
				return;
			}
			progressbar.Visible = flag;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0001847C File Offset: 0x0001667C
		public static void SetVisible(Label label, bool flag)
		{
			if (label.InvokeRequired)
			{
				label.BeginInvoke(new MethodInvoker(delegate()
				{
					label.Visible = flag;
				}));
				return;
			}
			label.Visible = flag;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000184D4 File Offset: 0x000166D4
		public static void SetDock(Panel panel, DockStyle dockStyle)
		{
			if (panel.InvokeRequired)
			{
				panel.BeginInvoke(new MethodInvoker(delegate()
				{
					panel.Dock = dockStyle;
				}));
				return;
			}
			panel.Dock = dockStyle;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001852C File Offset: 0x0001672C
		public static void SetDockSync(Panel panel, DockStyle dockStyle)
		{
			if (panel.InvokeRequired)
			{
				panel.Invoke(new MethodInvoker(delegate()
				{
					panel.Dock = dockStyle;
				}));
				return;
			}
			panel.Dock = dockStyle;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00018584 File Offset: 0x00016784
		public static void BringToFront(Control control)
		{
			if (control.InvokeRequired)
			{
				control.Invoke(new MethodInvoker(delegate()
				{
					control.BringToFront();
				}));
				return;
			}
			control.BringToFront();
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000185D0 File Offset: 0x000167D0
		public static void SendToBack(Control control)
		{
			if (control.InvokeRequired)
			{
				control.Invoke(new MethodInvoker(delegate()
				{
					control.SendToBack();
				}));
				return;
			}
			control.SendToBack();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001861C File Offset: 0x0001681C
		public static bool GetVisible(ProgressBar progressbar)
		{
			bool flag = false;
			if (progressbar.InvokeRequired)
			{
				progressbar.Invoke(new MethodInvoker(delegate()
				{
					flag = progressbar.Visible;
				}));
			}
			else
			{
				flag = progressbar.Visible;
			}
			return flag;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0001867C File Offset: 0x0001687C
		public static int GetVerticalScrollMinimum(Panel panel)
		{
			int value = 0;
			if (panel.InvokeRequired)
			{
				panel.Invoke(new MethodInvoker(delegate()
				{
					value = panel.VerticalScroll.Minimum;
				}));
			}
			else
			{
				value = panel.VerticalScroll.Minimum;
			}
			return value;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000186E0 File Offset: 0x000168E0
		public static int GetVerticalScrollMaximum(Panel panel)
		{
			int value = 0;
			if (panel.InvokeRequired)
			{
				panel.Invoke(new MethodInvoker(delegate()
				{
					value = panel.VerticalScroll.Maximum;
				}));
			}
			else
			{
				value = panel.VerticalScroll.Maximum;
			}
			return value;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00018744 File Offset: 0x00016944
		public static int GetVerticalScrollSmallChange(Panel panel)
		{
			int value = 0;
			if (panel.InvokeRequired)
			{
				panel.Invoke(new MethodInvoker(delegate()
				{
					value = panel.VerticalScroll.SmallChange;
				}));
			}
			else
			{
				value = panel.VerticalScroll.SmallChange;
			}
			return value;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000187A8 File Offset: 0x000169A8
		public static int GetVerticalScrollLargeChange(Panel panel)
		{
			int value = 0;
			if (panel.InvokeRequired)
			{
				panel.Invoke(new MethodInvoker(delegate()
				{
					value = panel.VerticalScroll.LargeChange;
				}));
			}
			else
			{
				value = panel.VerticalScroll.LargeChange;
			}
			return value;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0001880C File Offset: 0x00016A0C
		public static int GetVerticalScrollValue(Panel panel)
		{
			int value = 0;
			if (panel.InvokeRequired)
			{
				panel.Invoke(new MethodInvoker(delegate()
				{
					value = panel.VerticalScroll.Value;
				}));
			}
			else
			{
				value = panel.VerticalScroll.Value;
			}
			return value;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00018870 File Offset: 0x00016A70
		public static int GetHeight(Control control)
		{
			int value = 0;
			if (control.InvokeRequired)
			{
				control.Invoke(new MethodInvoker(delegate()
				{
					value = control.Size.Height;
				}));
			}
			else
			{
				value = control.Size.Height;
			}
			return value;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000188D8 File Offset: 0x00016AD8
		public static void CustomScrollSetParam(CustomScrollbar scorllBar, int height, int minimum, int maximum, int largeChange, int smallChange, int value)
		{
			if (scorllBar.InvokeRequired)
			{
				scorllBar.Invoke(new MethodInvoker(delegate()
				{
					scorllBar.Height = height;
					scorllBar.Minimum = minimum;
					scorllBar.Maximum = maximum;
					scorllBar.LargeChange = largeChange;
					scorllBar.SmallChange = smallChange;
					scorllBar.Value = value;
				}));
				return;
			}
			scorllBar.Height = height;
			scorllBar.Minimum = minimum;
			scorllBar.Maximum = maximum;
			scorllBar.LargeChange = largeChange;
			scorllBar.SmallChange = smallChange;
			scorllBar.Value = value;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000189AC File Offset: 0x00016BAC
		public static void SetTextAlign(Label label, ContentAlignment align)
		{
			if (label.InvokeRequired)
			{
				label.BeginInvoke(new MethodInvoker(delegate()
				{
					label.TextAlign = align;
				}));
				return;
			}
			label.TextAlign = align;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00018A04 File Offset: 0x00016C04
		public static void SetSize(Label label, int sizeX, int sizeY)
		{
			if (label.InvokeRequired)
			{
				label.BeginInvoke(new MethodInvoker(delegate()
				{
					label.Size = new Size(sizeX, sizeY);
				}));
				return;
			}
			label.Size = new Size(sizeX, sizeY);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00018A70 File Offset: 0x00016C70
		public static void SetLocation(Control control, int posX, int posY)
		{
			if (control.InvokeRequired)
			{
				control.BeginInvoke(new MethodInvoker(delegate()
				{
					control.Location = new Point(posX, posY);
				}));
				return;
			}
			control.Location = new Point(posX, posY);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00018ADC File Offset: 0x00016CDC
		public static void SetFocus(Form form, Control control)
		{
			if (form.InvokeRequired)
			{
				form.Invoke(new MethodInvoker(delegate()
				{
					form.ActiveControl = control;
				}));
				return;
			}
			form.ActiveControl = control;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00018B34 File Offset: 0x00016D34
		public static void SetFocus(Form form)
		{
			if (form.InvokeRequired)
			{
				form.Invoke(new MethodInvoker(delegate()
				{
					form.Focus();
				}));
				return;
			}
			form.Focus();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00018B80 File Offset: 0x00016D80
		public static void invokeScript(WebBrowser web, string func)
		{
			if (web.InvokeRequired)
			{
				web.Invoke(new MethodInvoker(delegate()
				{
					web.Document.InvokeScript(func);
				}));
				return;
			}
			web.Document.InvokeScript(func);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00018BE0 File Offset: 0x00016DE0
		public static void invokeScript(WebBrowser web, string func, object[] obj)
		{
			if (web.InvokeRequired)
			{
				web.Invoke(new MethodInvoker(delegate()
				{
					web.Document.InvokeScript(func, obj);
				}));
				return;
			}
			web.Document.InvokeScript(func, obj);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00018C4C File Offset: 0x00016E4C
		public static void ControlAdd(Control parentsControl, Control childControl)
		{
			if (parentsControl.InvokeRequired)
			{
				parentsControl.BeginInvoke(new MethodInvoker(delegate()
				{
					parentsControl.Controls.Add(childControl);
				}));
				return;
			}
			parentsControl.Controls.Add(childControl);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00018CAC File Offset: 0x00016EAC
		public static void ControlAddSync(Control parentsControl, Control childControl)
		{
			if (parentsControl.InvokeRequired)
			{
				parentsControl.Invoke(new MethodInvoker(delegate()
				{
					parentsControl.Controls.Add(childControl);
				}));
				return;
			}
			parentsControl.Controls.Add(childControl);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00018D0C File Offset: 0x00016F0C
		public static void ControlAdd(Control parentsControl, Control[] childControl)
		{
			if (parentsControl.InvokeRequired)
			{
				parentsControl.BeginInvoke(new MethodInvoker(delegate()
				{
					parentsControl.Controls.AddRange(childControl);
				}));
				return;
			}
			parentsControl.Controls.AddRange(childControl);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00018D6C File Offset: 0x00016F6C
		public static void ControlAddSync(Control parentsControl, Control[] childControl)
		{
			if (parentsControl.InvokeRequired)
			{
				parentsControl.Invoke(new MethodInvoker(delegate()
				{
					parentsControl.Controls.AddRange(childControl);
				}));
				return;
			}
			parentsControl.Controls.AddRange(childControl);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00018DCC File Offset: 0x00016FCC
		public static void ControlRemove(Control parentsControl, Control childControl)
		{
			if (parentsControl.InvokeRequired)
			{
				parentsControl.BeginInvoke(new MethodInvoker(delegate()
				{
					parentsControl.Controls.Remove(childControl);
				}));
				return;
			}
			parentsControl.Controls.Remove(childControl);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00018E2C File Offset: 0x0001702C
		public static void ControlClear(Control control)
		{
			if (control.InvokeRequired)
			{
				control.BeginInvoke(new MethodInvoker(delegate()
				{
					control.Controls.Clear();
				}));
				return;
			}
			control.Controls.Clear();
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00018E7C File Offset: 0x0001707C
		public static void ControlClearSync(Control control)
		{
			if (control.InvokeRequired)
			{
				control.BeginInvoke(new MethodInvoker(delegate()
				{
					control.Controls.Clear();
				}));
				return;
			}
			control.Controls.Clear();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00018ECC File Offset: 0x000170CC
		public static void ControlRemoveSync(Control parentsControl, Control childControl)
		{
			if (parentsControl.InvokeRequired)
			{
				parentsControl.Invoke(new MethodInvoker(delegate()
				{
					parentsControl.Controls.Remove(childControl);
				}));
				return;
			}
			parentsControl.Controls.Remove(childControl);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00018F2C File Offset: 0x0001712C
		public static void CloseForm(Form form)
		{
			if (form.InvokeRequired)
			{
				form.Invoke(new MethodInvoker(delegate()
				{
					form.Close();
				}));
				return;
			}
			form.Close();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00018F78 File Offset: 0x00017178
		public static void MessageBoxShowSync(Form form, string Text)
		{
			try
			{
				form.Invoke(new Action(delegate()
				{
					MessageBox.Show(Text);
				}));
			}
			catch
			{
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00018FBC File Offset: 0x000171BC
		public static void MessageBoxShowSync(Form form, string Text, string caption, MessageBoxButtons button, MessageBoxIcon icon)
		{
			try
			{
				form.Invoke(new Action(delegate()
				{
					MessageBox.Show(Text, caption, button, icon);
				}));
			}
			catch
			{
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00019014 File Offset: 0x00017214
		public static DialogResult FormShowDialogSync(Form form, object childForm)
		{
			DialogResult result = DialogResult.None;
			DialogResult result2;
			try
			{
				form.Invoke(new Action(delegate()
				{
					result = ((Form)childForm).ShowDialog();
				}));
				result2 = result;
			}
			catch
			{
				result2 = DialogResult.None;
			}
			return result2;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00019068 File Offset: 0x00017268
		public static void SetUseWaitCursor(Form form, bool flag)
		{
			if (form.InvokeRequired)
			{
				form.Invoke(new MethodInvoker(delegate()
				{
					form.UseWaitCursor = flag;
				}));
				return;
			}
			form.UseWaitCursor = flag;
		}
	}
}
