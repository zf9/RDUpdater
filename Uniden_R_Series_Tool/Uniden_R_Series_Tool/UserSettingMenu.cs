using System;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200000B RID: 11
	public class UserSettingMenu
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000079BA File Offset: 0x00005BBA
		public UserSettingMenu(UserSettingMenu.MENU_TYPE menuType, string menuString, int[] itemValue, string[] itemString, string menuDecription)
		{
			this.menuType = menuType;
			this.menuAtt = UserSettingMenu.MENU_ATTRIBUTE.NORMAL_ATT;
			this.menuString = menuString;
			this.itemValue = itemValue;
			this.itemString = itemString;
			this.menuDecription = menuDecription;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000079EE File Offset: 0x00005BEE
		public UserSettingMenu(UserSettingMenu.MENU_TYPE menuType, UserSettingMenu.MENU_ATTRIBUTE menuAtt, string menuString, int[] itemValue, string[] itemString, string menuDecription)
		{
			this.menuType = menuType;
			this.menuAtt = menuAtt;
			this.menuString = menuString;
			this.itemValue = itemValue;
			this.itemString = itemString;
			this.menuDecription = menuDecription;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007A23 File Offset: 0x00005C23
		public UserSettingMenu(UserSettingMenu.MENU_TYPE menuType, UserSettingMenu.MENU_ATTRIBUTE menuAtt, string menuString, int[][] multipleItemValue, string[][] multipleItemString, string[] multipleSourceString, string menuDecription)
		{
			this.menuType = menuType;
			this.menuAtt = menuAtt;
			this.menuString = menuString;
			this.multipleItemValue = multipleItemValue;
			this.multipleItemString = multipleItemString;
			this.multipleSourceString = multipleSourceString;
			this.menuDecription = menuDecription;
		}

		// Token: 0x04000069 RID: 105
		public UserSettingMenu.MENU_TYPE menuType;

		// Token: 0x0400006A RID: 106
		public UserSettingMenu.MENU_ATTRIBUTE menuAtt;

		// Token: 0x0400006B RID: 107
		public int menuNum;

		// Token: 0x0400006C RID: 108
		public string menuString;

		// Token: 0x0400006D RID: 109
		public string menuDecription;

		// Token: 0x0400006E RID: 110
		public int[] itemValue;

		// Token: 0x0400006F RID: 111
		public string[] itemString;

		// Token: 0x04000070 RID: 112
		public string[] multipleSourceString;

		// Token: 0x04000071 RID: 113
		public int[][] multipleItemValue;

		// Token: 0x04000072 RID: 114
		public string[][] multipleItemString;

		// Token: 0x04000073 RID: 115
		public int rawValue;

		// Token: 0x04000074 RID: 116
		public bool isUnitMenuFlag;

		// Token: 0x04000075 RID: 117
		public bool isDetectionMode;

		// Token: 0x02000033 RID: 51
		public enum MENU_TYPE
		{
			// Token: 0x040003E1 RID: 993
			USER_PREFERENCE,
			// Token: 0x040003E2 RID: 994
			BAND_SETTING,
			// Token: 0x040003E3 RID: 995
			GPS,
			// Token: 0x040003E4 RID: 996
			SOUND,
			// Token: 0x040003E5 RID: 997
			DISPLAY,
			// Token: 0x040003E6 RID: 998
			MENU_TYPE_NUM,
			// Token: 0x040003E7 RID: 999
			INVISIBLE
		}

		// Token: 0x02000034 RID: 52
		public enum MENU_ATTRIBUTE
		{
			// Token: 0x040003E9 RID: 1001
			NORMAL_ATT,
			// Token: 0x040003EA RID: 1002
			UNIT_RAW_VALUE_MULTI_ITEM_ATT,
			// Token: 0x040003EB RID: 1003
			UNIT_MATCHING_VALUE_MULTI_ITEM_ATT,
			// Token: 0x040003EC RID: 1004
			K_BLOCK_LEVEL_ATT,
			// Token: 0x040003ED RID: 1005
			RAW_VALUE_ATT
		}
	}
}
