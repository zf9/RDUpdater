using System;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000014 RID: 20
	public class RDInfo
	{
		// Token: 0x06000108 RID: 264 RVA: 0x0001121C File Offset: 0x0000F41C
		public RDInfo()
		{
			this.isConnected = false;
			this.versionUI = -1;
			this.versionDSP = -1;
			this.versionGPS = -1;
			this.versionSoundDB = -1;
			this.versionGPSDB = -1;
			this.versionBLE = -1;
			this.supportBT = RDInfo.isSupportBT(this.modelName);
			this.supportWIFI = RDInfo.isSupportWIFI(this.modelName);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00011284 File Offset: 0x0000F484
		public static bool isSupportBT(ModelName modelName)
		{
			switch (modelName)
			{
			case ModelName.R1:
			case (ModelName)2:
			case ModelName.R3:
			case ModelName.R3_NZ:
			case ModelName.R3_NZK:
			case (ModelName)6:
			case ModelName.R7:
			case ModelName.R7_NZ:
			case ModelName.R7_IL:
			case (ModelName)10:
			case (ModelName)11:
			case (ModelName)12:
			case (ModelName)13:
			case (ModelName)22:
			case (ModelName)23:
			case (ModelName)25:
			case (ModelName)26:
			case (ModelName)27:
				break;
			case ModelName.R4:
			case ModelName.R4_NZ:
			case ModelName.R4_IL:
			case ModelName.R4_EU:
			case ModelName.R8:
			case ModelName.R8_NZ:
			case ModelName.R8_IL:
			case ModelName.R8_EU:
			case ModelName.R4W:
			case ModelName.R8W:
				return true;
			default:
				if (modelName != ModelName.R3_PLUS)
				{
				}
				break;
			}
			return false;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00011318 File Offset: 0x0000F518
		public static bool isSupportWIFI(ModelName modelName)
		{
			switch (modelName)
			{
			case ModelName.R1:
			case (ModelName)2:
			case ModelName.R3:
			case ModelName.R3_NZ:
			case ModelName.R3_NZK:
			case (ModelName)6:
			case ModelName.R7:
			case ModelName.R7_NZ:
			case ModelName.R7_IL:
			case (ModelName)10:
			case (ModelName)11:
			case (ModelName)12:
			case (ModelName)13:
			case ModelName.R4:
			case ModelName.R4_NZ:
			case ModelName.R4_IL:
			case ModelName.R4_EU:
			case ModelName.R8:
			case ModelName.R8_NZ:
			case ModelName.R8_IL:
			case ModelName.R8_EU:
			case (ModelName)22:
			case (ModelName)23:
			case (ModelName)25:
			case (ModelName)26:
			case (ModelName)27:
				break;
			case ModelName.R4W:
			case ModelName.R8W:
				return true;
			default:
				if (modelName != ModelName.R3_PLUS)
				{
				}
				break;
			}
			return false;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000113AC File Offset: 0x0000F5AC
		public void SetModel(ModelName modelName)
		{
			switch (modelName)
			{
			case ModelName.R1:
			case ModelName.R4:
			case ModelName.R4_NZ:
			case ModelName.R4_IL:
			case ModelName.R4_EU:
			case ModelName.R8:
			case ModelName.R8_NZ:
			case ModelName.R8_IL:
			case ModelName.R8_EU:
			case ModelName.R4W:
			case ModelName.R8W:
				goto IL_D0;
			case (ModelName)2:
			case (ModelName)6:
			case (ModelName)10:
			case (ModelName)11:
			case (ModelName)12:
			case (ModelName)13:
			case (ModelName)22:
			case (ModelName)23:
			case (ModelName)25:
			case (ModelName)26:
			case (ModelName)27:
				break;
			case ModelName.R3:
				this.oldgpsDBKey = FWDloadFormat.oldUSgpsDBKey;
				goto IL_D0;
			case ModelName.R3_NZ:
			case ModelName.R3_NZK:
				this.oldgpsDBKey = FWDloadFormat.oldNZgpsDBKey;
				goto IL_D0;
			case ModelName.R7:
				this.oldgpsDBKey = FWDloadFormat.oldUSgpsDBKey;
				goto IL_D0;
			case ModelName.R7_NZ:
				this.oldgpsDBKey = FWDloadFormat.oldNZgpsDBKey;
				goto IL_D0;
			case ModelName.R7_IL:
				this.oldgpsDBKey = FWDloadFormat.oldILgpsDBKey;
				goto IL_D0;
			default:
				if (modelName == ModelName.R3_PLUS || modelName == ModelName.R3_NZK_PLUS)
				{
					goto IL_D0;
				}
				break;
			}
			this.oldgpsDBKey = FWDloadFormat.oldUSgpsDBKey;
			IL_D0:
			this.supportBT = RDInfo.isSupportBT(modelName);
			this.supportWIFI = RDInfo.isSupportWIFI(modelName);
			this.modelName = modelName;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000114A8 File Offset: 0x0000F6A8
		public static string GetModelNameStr(ModelName model)
		{
			if (model <= ModelName.R3_PLUS)
			{
				switch (model)
				{
				case ModelName.R1:
					return "R1";
				case (ModelName)2:
				case (ModelName)6:
				case (ModelName)10:
				case (ModelName)11:
				case (ModelName)12:
				case (ModelName)13:
				case (ModelName)22:
				case (ModelName)23:
				case (ModelName)25:
				case (ModelName)26:
				case (ModelName)27:
					goto IL_167;
				case ModelName.R3:
					break;
				case ModelName.R3_NZ:
					return "R3 NZ";
				case ModelName.R3_NZK:
					goto IL_D1;
				case ModelName.R7:
					return "R7";
				case ModelName.R7_NZ:
					return "R7 NZ";
				case ModelName.R7_IL:
					return "R7 IL";
				case ModelName.R4:
					return "R4";
				case ModelName.R4_NZ:
					return "R4 NZ";
				case ModelName.R4_IL:
					return "R4 IL";
				case ModelName.R4_EU:
					return "R4 EU";
				case ModelName.R8:
					return "R8";
				case ModelName.R8_NZ:
					return "R8 NZ";
				case ModelName.R8_IL:
					return "R8 IL";
				case ModelName.R8_EU:
					return "R8 EU";
				case ModelName.R4W:
					return "R4w";
				case ModelName.R8W:
					return "R8w";
				default:
					if (model != ModelName.R3_PLUS)
					{
						goto IL_167;
					}
					break;
				}
				return "R3";
			}
			if (model != ModelName.R3_NZK_PLUS)
			{
				switch (model)
				{
				case ModelName.DB_EU:
					return "DB EU";
				case ModelName.DB_IL:
					return "DB IL";
				case ModelName.DB_US:
					return "DB US";
				case ModelName.DB_NZ:
					return "DB NZ";
				default:
					goto IL_167;
				}
			}
			IL_D1:
			return "R3 NZ K";
			IL_167:
			return "UnKnown";
		}

		// Token: 0x04000129 RID: 297
		public string serialPortName;

		// Token: 0x0400012A RID: 298
		public const int notAvailableValue = -1;

		// Token: 0x0400012B RID: 299
		public ModelName modelName;

		// Token: 0x0400012C RID: 300
		public bool isConnected;

		// Token: 0x0400012D RID: 301
		public int versionUI;

		// Token: 0x0400012E RID: 302
		public int versionDSP;

		// Token: 0x0400012F RID: 303
		public int versionGPS;

		// Token: 0x04000130 RID: 304
		public int versionSoundDB;

		// Token: 0x04000131 RID: 305
		public int versionGPSDB;

		// Token: 0x04000132 RID: 306
		public int versionBLE;

		// Token: 0x04000133 RID: 307
		public bool supportBT;

		// Token: 0x04000134 RID: 308
		public bool supportWIFI;

		// Token: 0x04000135 RID: 309
		public FWDloadFormat.VOICE_IC voiceICType;

		// Token: 0x04000136 RID: 310
		public FWDloadFormat.GPS_DB_TYPE gpsDBType;

		// Token: 0x04000137 RID: 311
		public byte[] oldgpsDBKey;
	}
}
