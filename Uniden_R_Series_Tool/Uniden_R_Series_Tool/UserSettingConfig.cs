using System;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200002A RID: 42
	public class UserSettingConfig
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00022218 File Offset: 0x00020418
		public UserSettingConfig(RDInfo modelInfo)
		{
			this.modelInfo = modelInfo;
			this.user_setting_model = new UserSettingModel(modelInfo.modelName);
			this.menuCnt = this.SetUserSettingMenu();
			this.hwRevisionVersion = -1;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0002224B File Offset: 0x0002044B
		public static int GetMinSupportedVer(ModelName model)
		{
			return new UserSettingModel(model).GetMinimumSupportVersion();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00022258 File Offset: 0x00020458
		public bool CheckCompatibility(int fileVersion)
		{
			return this.user_setting_model.CheckCompatibility(this.modelInfo.versionUI, fileVersion);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00022271 File Offset: 0x00020471
		public int SetUserSettingMenu()
		{
			this.menu = this.user_setting_model.GetMenuFormat(this.modelInfo.versionUI);
			if (this.menu == null)
			{
				return 0;
			}
			return this.menu.Length;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000222A1 File Offset: 0x000204A1
		public int[] GetUserSettingFromNVData(byte[] rawUserSettingData)
		{
			return this.user_setting_model.GetUserSettingFromNVData(this.modelInfo.versionUI, rawUserSettingData, ref this.hwRevisionVersion);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000222C0 File Offset: 0x000204C0
		public byte[] GetNVDataFromUserSetting(int[] userSetting)
		{
			return this.user_setting_model.GetNVDataFromUserSetting(this.modelInfo.versionUI, userSetting, this.receivedNVData);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000222DF File Offset: 0x000204DF
		public int GetMenuCnt()
		{
			return this.user_setting_model.GetMenuCnt(this.modelInfo.versionUI);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000222F7 File Offset: 0x000204F7
		public byte[] MaskingNVData(byte[] nvData)
		{
			return this.user_setting_model.MaskingNVData(this.modelInfo.versionUI, nvData);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00022310 File Offset: 0x00020510
		public bool user_k_block_op_mode_is_level(int level)
		{
			return this.user_setting_model.user_k_block_op_mode_is_level(this.modelInfo.versionUI, level);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00022329 File Offset: 0x00020529
		public int user_k_block_get_level(int strength, int mode)
		{
			return this.user_setting_model.user_k_block_get_level(this.modelInfo.versionUI, strength, mode);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00022343 File Offset: 0x00020543
		public int user_k_block_get_raw_strength(int level, int mode)
		{
			return this.user_setting_model.user_k_block_get_raw_strength(this.modelInfo.versionUI, level, mode);
		}

		// Token: 0x0400038B RID: 907
		public RDInfo modelInfo;

		// Token: 0x0400038C RID: 908
		private UserSettingModel user_setting_model;

		// Token: 0x0400038D RID: 909
		public UserSettingMenu[] menu;

		// Token: 0x0400038E RID: 910
		public int menuCnt;

		// Token: 0x0400038F RID: 911
		public byte[] receivedNVData;

		// Token: 0x04000390 RID: 912
		public int hwRevisionVersion;
	}
}
