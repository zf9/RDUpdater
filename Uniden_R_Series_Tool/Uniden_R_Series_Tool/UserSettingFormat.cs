using System;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200000C RID: 12
	internal interface UserSettingFormat
	{
		// Token: 0x06000060 RID: 96
		int GetSupportVersion();

		// Token: 0x06000061 RID: 97
		int GetMenuCnt();

		// Token: 0x06000062 RID: 98
		byte[] GetNVDataMask();

		// Token: 0x06000063 RID: 99
		bool user_k_block_op_mode_is_level(int op_mode);

		// Token: 0x06000064 RID: 100
		int user_k_block_get_level(int strength, int mode);

		// Token: 0x06000065 RID: 101
		int user_k_block_get_raw_strength(int level, int mode);

		// Token: 0x06000066 RID: 102
		UserSettingMenu[] GetMenuFormat();

		// Token: 0x06000067 RID: 103
		int[] GetUserSettingFromNVData(byte[] nvData, ref int hwRevisionVersion);

		// Token: 0x06000068 RID: 104
		byte[] GetNVDataFromUserSetting(int[] userSettingR4, byte[] receivedNVData);
	}
}
