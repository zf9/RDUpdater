using System;
using System.Threading;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000018 RID: 24
	public class ProgressBarAsync
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00016DA8 File Offset: 0x00014FA8
		public ProgressBarAsync(ProgressBar progressBar, int min, int max, int totalCnt, Label label)
		{
			this.progressBar = progressBar;
			this.minValue = min;
			this.maxValue = max;
			this.totalCnt = totalCnt;
			this.sendCnt = 0;
			this.currentPercent = 0;
			this.newPercent = 0;
			this.onlyUpFlag = false;
			if (progressBar.InvokeRequired)
			{
				progressBar.BeginInvoke(new MethodInvoker(delegate()
				{
					progressBar.Minimum = min;
				}));
				progressBar.BeginInvoke(new MethodInvoker(delegate()
				{
					progressBar.Maximum = max;
				}));
				progressBar.BeginInvoke(new MethodInvoker(delegate()
				{
					progressBar.Value = 0;
				}));
				progressBar.BeginInvoke(new MethodInvoker(delegate()
				{
					progressBar.Step = 1;
				}));
				SafetyControl.SetVisible(progressBar, true);
			}
			else
			{
				progressBar.Minimum = min;
				progressBar.Maximum = max;
				progressBar.Value = 0;
				progressBar.Step = 1;
			}
			this.label = label;
			this.progressThread = new Thread(new ThreadStart(this.ProgressTread));
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00016EF4 File Offset: 0x000150F4
		public void SetTotalCnt(int totalCnt)
		{
			try
			{
				if (this.totalCnt != totalCnt)
				{
					this.totalCnt = totalCnt;
					this.newPercent = (int)((long)this.sendCnt * (long)this.maxValue / (long)this.totalCnt);
					if (this.label != null)
					{
						SafetyControl.SetText(this.label, ((int)((double)this.newPercent / (double)this.maxValue * 100.0)).ToString() + "%");
					}
					if (this.progressBar.InvokeRequired)
					{
						this.progressBar.Invoke(new MethodInvoker(delegate()
						{
							this.progressBar.Value = this.newPercent;
						}));
					}
					else
					{
						this.progressBar.Value = this.newPercent;
					}
					this.currentPercent = this.newPercent;
				}
			}
			catch
			{
				if (this.label != null)
				{
					SafetyControl.SetText(this.label, "100%");
				}
				if (this.progressBar.InvokeRequired)
				{
					this.progressBar.Invoke(new MethodInvoker(delegate()
					{
						this.progressBar.Value = this.maxValue;
					}));
				}
				else
				{
					this.progressBar.Value = this.maxValue;
				}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0001701C File Offset: 0x0001521C
		public void SetSendCnt(int sendCnt, bool onlyUpFlag)
		{
			this.sendCnt += sendCnt;
			this.onlyUpFlag = onlyUpFlag;
			this.newPercent = (int)((long)this.sendCnt * (long)this.maxValue / (long)this.totalCnt);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00017051 File Offset: 0x00015251
		public void Start()
		{
			this.progressThread.IsBackground = true;
			this.progressThread.Priority = ThreadPriority.Lowest;
			this.progressThread.Start();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00017076 File Offset: 0x00015276
		public void Stop()
		{
			this.progressThread.Abort();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00017084 File Offset: 0x00015284
		private void ProgressTread()
		{
			try
			{
				for (;;)
				{
					if (this.onlyUpFlag)
					{
						if (this.currentPercent < this.newPercent)
						{
							for (int i = 0; i < this.newPercent - this.currentPercent; i++)
							{
								if (this.progressBar.InvokeRequired)
								{
									this.progressBar.BeginInvoke(new MethodInvoker(delegate()
									{
										this.progressBar.PerformStep();
									}));
								}
								else
								{
									this.progressBar.PerformStep();
								}
							}
							this.currentPercent = this.newPercent;
							if (this.label != null)
							{
								SafetyControl.SetText(this.label, ((int)((double)this.currentPercent / (double)this.maxValue * 100.0)).ToString() + "%");
							}
						}
					}
					else if (this.currentPercent != this.newPercent)
					{
						this.currentPercent = this.newPercent;
						if (this.label != null)
						{
							SafetyControl.SetText(this.label, ((int)((double)this.currentPercent / (double)this.maxValue * 100.0)).ToString() + "%");
						}
						SafetyControl.SetValue(this.progressBar, this.newPercent);
					}
					Thread.Sleep(50);
				}
			}
			catch
			{
				this.currentPercent = this.newPercent;
				if (this.label != null)
				{
					SafetyControl.SetText(this.label, ((int)((double)this.currentPercent / (double)this.maxValue * 100.0)).ToString() + "%");
				}
				SafetyControl.SetValue(this.progressBar, this.newPercent);
			}
		}

		// Token: 0x04000188 RID: 392
		private Thread progressThread;

		// Token: 0x04000189 RID: 393
		private ProgressBar progressBar;

		// Token: 0x0400018A RID: 394
		private Label label;

		// Token: 0x0400018B RID: 395
		private int minValue;

		// Token: 0x0400018C RID: 396
		private int maxValue;

		// Token: 0x0400018D RID: 397
		private int totalCnt;

		// Token: 0x0400018E RID: 398
		private int sendCnt;

		// Token: 0x0400018F RID: 399
		private int currentPercent;

		// Token: 0x04000190 RID: 400
		public int newPercent;

		// Token: 0x04000191 RID: 401
		private bool onlyUpFlag;
	}
}
