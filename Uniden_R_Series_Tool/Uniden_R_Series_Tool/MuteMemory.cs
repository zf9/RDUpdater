using System;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000005 RID: 5
	public class MuteMemory
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00006B74 File Offset: 0x00004D74
		public MuteMemory(float lat, float lng, int freq, bool isAutoMuteMemory, int autoMuteCnt)
		{
			this.isAutoMuteMemory = isAutoMuteMemory;
			this.autoMuteCnt = autoMuteCnt;
			this.lat = lat;
			this.lng = lng;
			if (freq >= 10500 && freq <= 10550)
			{
				this.band = "X band";
			}
			else if (freq >= 23900 && freq <= 24250)
			{
				this.band = "K band";
			}
			else if (freq >= 33399 && freq <= 36000)
			{
				this.band = "Ka band";
			}
			else if (freq >= 28900 && freq <= 29120)
			{
				this.band = "MRCD";
				freq -= 5000;
			}
			else
			{
				this.band = "";
			}
			this.freq = freq;
			this.freqStr = string.Format("{0:00.000} ", (double)((float)freq) / 1000.0) + "Ghz";
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006C60 File Offset: 0x00004E60
		public MuteMemory(float lat, float lng, int freq) : this(lat, lng, freq, false, 0)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006C6D File Offset: 0x00004E6D
		public MuteMemory(float lat, float lng, int freq, int autoMuteCnt) : this(lat, lng, freq, true, autoMuteCnt)
		{
		}

		// Token: 0x0400004B RID: 75
		public bool isAutoMuteMemory;

		// Token: 0x0400004C RID: 76
		public float lat;

		// Token: 0x0400004D RID: 77
		public float lng;

		// Token: 0x0400004E RID: 78
		public int freq;

		// Token: 0x0400004F RID: 79
		public string band;

		// Token: 0x04000050 RID: 80
		public string freqStr;

		// Token: 0x04000051 RID: 81
		public int autoMuteCnt;
	}
}
