using System;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200000A RID: 10
	internal class UserSettingModel
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00007748 File Offset: 0x00005948
		public UserSettingModel(ModelName modelName)
		{
			if (modelName > ModelName.R7)
			{
				if (modelName <= ModelName.R4W)
				{
					switch (modelName)
					{
					case ModelName.R4:
						this.user_setting = UserSettingR4.user_setting;
						return;
					case ModelName.R4_NZ:
						this.user_setting = UserSettingR4NZ.user_setting;
						return;
					case ModelName.R4_IL:
					case ModelName.R4_EU:
						break;
					case ModelName.R8:
						this.user_setting = UserSettingR8.user_setting;
						return;
					case ModelName.R8_NZ:
						this.user_setting = UserSettingR8NZ.user_setting;
						return;
					default:
						if (modelName != ModelName.R4W)
						{
							return;
						}
						this.user_setting = UserSettingR4W.user_setting;
						return;
					}
				}
				else if (modelName != ModelName.R8W)
				{
					if (modelName != ModelName.R3_PLUS)
					{
						return;
					}
					goto IL_5A;
				}
				else
				{
					this.user_setting = UserSettingR8W.user_setting;
				}
				return;
			}
			if (modelName == ModelName.R1)
			{
				this.user_setting = UserSettingR1.user_setting;
				return;
			}
			if (modelName != ModelName.R3)
			{
				if (modelName != ModelName.R7)
				{
					return;
				}
				this.user_setting = UserSettingR7.user_setting;
				return;
			}
			IL_5A:
			this.user_setting = UserSettingR3.user_setting;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00007810 File Offset: 0x00005A10
		private UserSettingFormat find_user_setting(int ver)
		{
			UserSettingFormat userSettingFormat = null;
			for (int i = 0; i < this.user_setting.Length; i++)
			{
				if (ver >= this.user_setting[i].GetSupportVersion())
				{
					if (userSettingFormat == null)
					{
						userSettingFormat = this.user_setting[i];
					}
					else if (userSettingFormat.GetSupportVersion() < this.user_setting[i].GetSupportVersion())
					{
						userSettingFormat = this.user_setting[i];
					}
				}
			}
			return userSettingFormat;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007870 File Offset: 0x00005A70
		public int GetMinimumSupportVersion()
		{
			if (this.user_setting == null)
			{
				return -1;
			}
			if (this.user_setting.Length >= 1)
			{
				int supportVersion = this.user_setting[0].GetSupportVersion();
				for (int i = 0; i < this.user_setting.Length; i++)
				{
					if (this.user_setting[i].GetSupportVersion() < supportVersion)
					{
						supportVersion = this.user_setting[i].GetSupportVersion();
					}
				}
				return supportVersion;
			}
			return -1;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000078D8 File Offset: 0x00005AD8
		public bool CheckCompatibility(int ver1, int ver2)
		{
			UserSettingFormat userSettingFormat = this.find_user_setting(ver1);
			UserSettingFormat userSettingFormat2 = this.find_user_setting(ver2);
			return userSettingFormat.GetSupportVersion() == userSettingFormat2.GetSupportVersion();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007904 File Offset: 0x00005B04
		public UserSettingMenu[] GetMenuFormat(int modelVersion)
		{
			return this.find_user_setting(modelVersion).GetMenuFormat();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00007914 File Offset: 0x00005B14
		public byte[] MaskingNVData(int modelVersion, byte[] nvData)
		{
			UserSettingFormat userSettingFormat = this.find_user_setting(modelVersion);
			byte[] array = new byte[nvData.Length];
			byte[] nvdataMask = userSettingFormat.GetNVDataMask();
			for (int i = 0; i < array.Length; i++)
			{
				if (i < nvdataMask.Length)
				{
					// DECOMPILE-FIX: Restore byte narrowing for the exported bit-mask operations
					// in this file; unchecked casts preserve the original IL byte stores.
					array[i] = unchecked((byte)(nvData[i] & nvdataMask[i]));
				}
				else
				{
					array[i] = 0;
				}
			}
			return array;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000795D File Offset: 0x00005B5D
		public bool user_k_block_op_mode_is_level(int modelVersion, int op_mode)
		{
			return this.find_user_setting(modelVersion).user_k_block_op_mode_is_level(op_mode);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000796C File Offset: 0x00005B6C
		public int user_k_block_get_level(int modelVersion, int strength, int mode)
		{
			return this.find_user_setting(modelVersion).user_k_block_get_level(strength, mode);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000797C File Offset: 0x00005B7C
		public int user_k_block_get_raw_strength(int modelVersion, int level, int mode)
		{
			return this.find_user_setting(modelVersion).user_k_block_get_raw_strength(level, mode);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000798C File Offset: 0x00005B8C
		public int[] GetUserSettingFromNVData(int modelVersion, byte[] nvData, ref int hwReivsionVersion)
		{
			return this.find_user_setting(modelVersion).GetUserSettingFromNVData(nvData, ref hwReivsionVersion);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000799C File Offset: 0x00005B9C
		public byte[] GetNVDataFromUserSetting(int modelVersion, int[] userSettingR4, byte[] receivedNVData)
		{
			return this.find_user_setting(modelVersion).GetNVDataFromUserSetting(userSettingR4, receivedNVData);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000079AC File Offset: 0x00005BAC
		public int GetMenuCnt(int modelVersion)
		{
			return this.find_user_setting(modelVersion).GetMenuCnt();
		}

		// Token: 0x04000067 RID: 103
		public const int NOT_SUPPORT = -1;

		// Token: 0x04000068 RID: 104
		private UserSettingFormat[] user_setting;
	}
}
