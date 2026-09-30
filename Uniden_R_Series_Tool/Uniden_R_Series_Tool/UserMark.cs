using System;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000006 RID: 6
	public class UserMark
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00006C7B File Offset: 0x00004E7B
		public UserMark(float lat, float lng)
		{
			this.lat = lat;
			this.lng = lng;
		}

		// Token: 0x04000052 RID: 82
		public float lat;

		// Token: 0x04000053 RID: 83
		public float lng;
	}
}
