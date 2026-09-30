using System;
using System.Linq;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200002B RID: 43
	internal static class UserSettingR8W
	{
		// Token: 0x04000391 RID: 913
		public static UserSettingFormat[] user_setting = new UserSettingFormat[]
		{
			new UserSettingR8W.v127()
		};

		// Token: 0x02000096 RID: 150
		private class v127 : UserSettingFormat
		{
			// Token: 0x06000317 RID: 791 RVA: 0x000487D1 File Offset: 0x000469D1
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x06000318 RID: 792 RVA: 0x000487D9 File Offset: 0x000469D9
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x06000319 RID: 793 RVA: 0x000487E1 File Offset: 0x000469E1
			public byte[] GetNVDataMask()
			{
				return this.userNVDataPos;
			}

			// Token: 0x0600031A RID: 794 RVA: 0x000293C6 File Offset: 0x000275C6
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return op_mode != 1 && op_mode != 2 && op_mode != 3 && op_mode != 7;
			}

			// Token: 0x0600031B RID: 795 RVA: 0x000487EC File Offset: 0x000469EC
			public int user_k_block_get_level(int strength, int mode)
			{
				if (mode == 0)
				{
					if (strength <= 96)
					{
						return 8;
					}
					if (strength <= 99)
					{
						return 9;
					}
					if (strength <= 102)
					{
						return 10;
					}
					if (strength <= 105)
					{
						return 11;
					}
					if (strength <= 108)
					{
						return 12;
					}
					if (strength <= 111)
					{
						return 13;
					}
					if (strength <= 113)
					{
						return 14;
					}
					if (strength <= 116)
					{
						return 15;
					}
					if (strength <= 119)
					{
						return 16;
					}
					if (strength <= 123)
					{
						return 17;
					}
					if (strength <= 125)
					{
						return 18;
					}
					if (strength <= 128)
					{
						return 19;
					}
					if (strength <= 132)
					{
						return 20;
					}
					if (strength <= 136)
					{
						return 21;
					}
					if (strength <= 140)
					{
						return 22;
					}
					return 23;
				}
				else
				{
					if (strength <= 50)
					{
						return 8;
					}
					if (strength <= 57)
					{
						return 9;
					}
					if (strength <= 64)
					{
						return 10;
					}
					if (strength <= 71)
					{
						return 11;
					}
					if (strength <= 77)
					{
						return 12;
					}
					if (strength <= 84)
					{
						return 13;
					}
					if (strength <= 91)
					{
						return 14;
					}
					if (strength <= 99)
					{
						return 15;
					}
					if (strength <= 105)
					{
						return 16;
					}
					if (strength <= 111)
					{
						return 17;
					}
					if (strength <= 117)
					{
						return 18;
					}
					if (strength <= 123)
					{
						return 19;
					}
					if (strength <= 129)
					{
						return 20;
					}
					if (strength <= 136)
					{
						return 21;
					}
					if (strength <= 142)
					{
						return 22;
					}
					return 23;
				}
			}

			// Token: 0x0600031C RID: 796 RVA: 0x00048908 File Offset: 0x00046B08
			public int user_k_block_get_raw_strength(int level, int mode)
			{
				if (mode == 0)
				{
					if (level == 8)
					{
						return 96;
					}
					if (level == 9)
					{
						return 99;
					}
					if (level == 10)
					{
						return 102;
					}
					if (level == 11)
					{
						return 105;
					}
					if (level == 12)
					{
						return 108;
					}
					if (level == 13)
					{
						return 111;
					}
					if (level == 14)
					{
						return 113;
					}
					if (level == 15)
					{
						return 116;
					}
					if (level == 16)
					{
						return 119;
					}
					if (level == 17)
					{
						return 123;
					}
					if (level == 18)
					{
						return 125;
					}
					if (level == 19)
					{
						return 128;
					}
					if (level == 20)
					{
						return 132;
					}
					if (level == 21)
					{
						return 136;
					}
					if (level == 22)
					{
						return 140;
					}
					return 255;
				}
				else
				{
					if (level == 8)
					{
						return 50;
					}
					if (level == 9)
					{
						return 57;
					}
					if (level == 10)
					{
						return 64;
					}
					if (level == 11)
					{
						return 71;
					}
					if (level == 12)
					{
						return 77;
					}
					if (level == 13)
					{
						return 84;
					}
					if (level == 14)
					{
						return 91;
					}
					if (level == 15)
					{
						return 99;
					}
					if (level == 16)
					{
						return 105;
					}
					if (level == 17)
					{
						return 111;
					}
					if (level == 18)
					{
						return 117;
					}
					if (level == 19)
					{
						return 123;
					}
					if (level == 20)
					{
						return 129;
					}
					if (level == 21)
					{
						return 136;
					}
					if (level == 22)
					{
						return 142;
					}
					return 255;
				}
			}

			// Token: 0x0600031D RID: 797 RVA: 0x00048A34 File Offset: 0x00046C34
			public UserSettingMenu[] GetMenuFormat()
			{
				UserSettingMenu[] array = new UserSettingMenu[this.menuCnt];
				if (array.Length == 0)
				{
					return null;
				}
				array[0] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Menu Mode", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Basic",
					"Expert"
				}, "Basic - This mode is for beginners who are not familiar with Radar detector. With Basic mode, user can access and set basic features in the Menu.\nExpert - This mode is for professional user. User can access and set all the features in the Menu.");
				array[1] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Detection Mode", new int[]
				{
					0,
					1,
					2,
					3
				}, new string[]
				{
					"City",
					"Highway",
					"Advanced",
					"Auto City"
				}, "Highway - Full Sensitivity\nCity - X and K sensitivity reduced. Ka band sensitivity same as Highway.\nAdvanced - User adjusts X, K, and Ka band sensitivity from 100%~30% in 10% intervals.\nAuto City - The R8w will automatically switch between Highway and City depending on the speed limits set in the Auto City Speed menu.");
				array[1].isDetectionMode = true;
				array[2] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "X Sensitive", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7
				}, new string[]
				{
					"30%",
					"40%",
					"50%",
					"60%",
					"70%",
					"80%",
					"90%",
					"100%"
				}, "Set a X band sensitivity from 100%~30% in 10% intervals.\n(Detection Mode - Advanced)");
				array[3] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Sensitive", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7
				}, new string[]
				{
					"30%",
					"40%",
					"50%",
					"60%",
					"70%",
					"80%",
					"90%",
					"100%"
				}, "Set a K band sensitivity from 100%~30% in 10% intervals.\n(Detection Mode - Advanced)");
				array[4] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Sensitive", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7
				}, new string[]
				{
					"30%",
					"40%",
					"50%",
					"60%",
					"70%",
					"80%",
					"90%",
					"100%"
				}, "Set a Ka band sensitivity from 100%~30% in 10% intervals.\n(Detection Mode - Advanced)");
				array[5] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Auto City Speed", new int[][]
				{
					new int[]
					{
						10,
						15,
						20,
						25,
						30,
						35,
						40,
						45,
						50,
						55,
						60
					},
					new int[]
					{
						10,
						20,
						30,
						40,
						50,
						60,
						70,
						80,
						90,
						100
					}
				}, new string[][]
				{
					new string[]
					{
						"10mph",
						"15mph",
						"20mph",
						"25mph",
						"30mph",
						"35mph",
						"40mph",
						"45mph",
						"50mph",
						"55mph",
						"60mph"
					},
					new string[]
					{
						"10km/h",
						"20km/h",
						"30km/h",
						"40km/h",
						"50km/h",
						"60km/h",
						"70km/h",
						"80km/h",
						"90km/h",
						"100km/h"
					}
				}, new string[]
				{
					"mph",
					"km/h"
				}, "Sets the speed at which the R8W changes from City mode to Highway mode and back.\n(Detection Mode - Auto City)");
				array[6] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear K Attenuation", new int[]
				{
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8
				}, new string[]
				{
					"30%",
					"40%",
					"50%",
					"60%",
					"70%",
					"80%",
					"90%",
					"100%"
				}, "Rear K Band Balance – Manually sets the sensitivity of rear radar.\nThe higher the attenuation(100 %) the more signals, including weaker signals, are received.Reduce attenuation and the weaker signals drop out, leaving only the stronger signals.");
				array[7] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear Ka Attenuation", new int[]
				{
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8
				}, new string[]
				{
					"30%",
					"40%",
					"50%",
					"60%",
					"70%",
					"80%",
					"90%",
					"100%"
				}, "Rear Ka Band Balance – Manually sets the sensitivity of rear radar.\nThe higher the attenuation(100 %) the more signals, including weaker signals, are received.Reduce attenuation and the weaker signals drop out, leaving only the stronger signals.");
				array[8] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear X Attenuation", new int[]
				{
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8
				}, new string[]
				{
					"30%",
					"40%",
					"50%",
					"60%",
					"70%",
					"80%",
					"90%",
					"100%"
				}, "Rear X Band Balance – Manually sets the sensitivity of rear radar.\nThe higher the attenuation(100 %) the more signals, including weaker signals, are received.Reduce attenuation and the weaker signals drop out, leaving only the stronger signals.");
				array[9] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "BT/WIFI", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to connect applications that support the radar detector.");
				array[10] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "GPS On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Determines your geographic location.");
				array[11] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "Speed Camera Off/On", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Notifies you if any speed cameras are nearby.");
				array[12] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_MATCHING_VALUE_MULTI_ITEM_ATT, "Speed Camera Alert Range", new int[][]
				{
					new int[]
					{
						0,
						1,
						2,
						3,
						4
					},
					new int[]
					{
						0,
						1,
						2,
						3,
						4
					}
				}, new string[][]
				{
					new string[]
					{
						"Auto",
						"1000ft",
						"2000ft",
						"2500ft",
						"3000ft"
					},
					new string[]
					{
						"Auto",
						"300m",
						"600m",
						"760m",
						"900m"
					}
				}, new string[]
				{
					"mph",
					"km/h"
				}, "Set the range to start Speed Camera Alarm.");
				array[13] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "Red Light Camera On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Notifies you if any red light cameras are nearby.");
				array[14] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Red Light Camera Quiet Ride", new int[][]
				{
					new int[]
					{
						0,
						50,
						55,
						60,
						65,
						70,
						75,
						80,
						85
					},
					new int[]
					{
						0,
						80,
						90,
						100,
						110,
						120,
						130,
						140
					}
				}, new string[][]
				{
					new string[]
					{
						"Off",
						"50mph",
						"55mph",
						"60mph",
						"65mph",
						"70mph",
						"75mph",
						"80mph",
						"85mph"
					},
					new string[]
					{
						"Off",
						"80km/h",
						"90km/h",
						"100km/h",
						"110km/h",
						"120km/h",
						"130km/h",
						"140km/h"
					}
				}, new string[]
				{
					"mph",
					"km/h"
				}, "Mutes red light camera alarms if you drive over the speed limit set here.");
				array[15] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "POI PassChime", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "POI PassChime sounds when users pass by a POI.");
				array[16] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Voice On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns voice alert on or off under the following conditions:\nType of radar / laser Band alarms");
				array[17] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Frequency Voice", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Announces the detected Ka band frequency.");
				UserSettingMenu[] array2 = array;
				int num = 18;
				UserSettingMenu.MENU_TYPE menuType = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString = "X Band On/Off";
				int[] array3 = new int[2];
				array3[0] = 1;
				array2[num] = new UserSettingMenu(menuType, menuString, array3, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore X band frequencies.\nTurn on for X band sensitivity as follows:\nHighway: Full sensitivity\nCity: X band sensitivity reduced");
				array[19] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore K band frequencies.");
				array[20] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore Ka band frequencies.");
				array[21] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore lasers.");
				array[22] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser Gun ID On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to display laser gun identifier.");
				UserSettingMenu[] array4 = array;
				int num2 = 23;
				UserSettingMenu.MENU_TYPE menuType2 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString2 = "K POP On/Off";
				int[] array5 = new int[2];
				array5[0] = 1;
				array4[num2] = new UserSettingMenu(menuType2, menuString2, array5, new string[]
				{
					"Off",
					"On"
				}, "Detects K POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[24] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "MRCD/T On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates MultaRadar CD/CT low - powered radar gun detection.");
				UserSettingMenu[] array6 = array;
				int num3 = 25;
				UserSettingMenu.MENU_TYPE menuType3 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString3 = "GATSO RT3/4 On/Off";
				int[] array7 = new int[2];
				array7[0] = 1;
				array6[num3] = new UserSettingMenu(menuType3, menuString3, array7, new string[]
				{
					"Off",
					"On"
				}, "Activates detection for Gatso radar guns.");
				UserSettingMenu[] array8 = array;
				int num4 = 26;
				UserSettingMenu.MENU_TYPE menuType4 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString4 = "Ka POP On/Off";
				int[] array9 = new int[2];
				array9[0] = 1;
				array8[num4] = new UserSettingMenu(menuType4, menuString4, array9, new string[]
				{
					"Off",
					"On"
				}, "Detects Ka POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[27] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Filter", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the K band to prevent false detections.");
				UserSettingMenu[] array10 = array;
				int num5 = 28;
				UserSettingMenu.MENU_TYPE menuType5 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString5 = "Ka Filter";
				int[] array11 = new int[2];
				array11[0] = 1;
				array10[num5] = new UserSettingMenu(menuType5, menuString5, array11, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the Ka band to prevent false detections.");
				UserSettingMenu[] array12 = array;
				int num6 = 29;
				UserSettingMenu.MENU_TYPE menuType6 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString6 = "TSF";
				int[] array13 = new int[2];
				array13[0] = 1;
				array12[num6] = new UserSettingMenu(menuType6, menuString6, array13, new string[]
				{
					"Off",
					"On"
				}, "Traffic Sensor Filter. Prevents false alarms caused by traffic monitoring radar systems.");
				int[] array14 = new int[351];
				string[] array15 = new string[351];
				for (int i = 0; i < 351; i++)
				{
					array14[i] = 23900 + i;
					array15[i] = array14[i].ToString();
				}
				array[30] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block1 Filter Mode", new int[]
				{
					8,
					9,
					10,
					11,
					12,
					13,
					14,
					15,
					16,
					17,
					18,
					19,
					20,
					21,
					22,
					23,
					1,
					2,
					3,
					7
				}, new string[]
				{
					"Level 0.5",
					"Level 1.0",
					"Level 1.5",
					"Level 2.0",
					"Level 2.5",
					"Level 3.0",
					"Level 3.5",
					"Level 4.0",
					"Level 4.5",
					"Level 5.0",
					"Level 5.5",
					"Level 6.0",
					"Level 6.5",
					"Level 7.0",
					"Level 7.5",
					"Level 8.0",
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set K Block1 Filter operation mode.");
				array[31] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[32] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter Direction", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Front",
					"Rear",
					"Side"
				}, "Set K Block1 Filter direction.");
				array[33] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter Minimum Frequency", array14, array15, "Set K Block1 Filter minimum frequency.");
				array[34] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter Maximum Frequency", array14, array15, "Set K Block1 Filter maximum frequency.");
				array[35] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block2 Filter Mode", new int[]
				{
					8,
					9,
					10,
					11,
					12,
					13,
					14,
					15,
					16,
					17,
					18,
					19,
					20,
					21,
					22,
					23,
					1,
					2,
					3,
					7
				}, new string[]
				{
					"Level 0.5",
					"Level 1.0",
					"Level 1.5",
					"Level 2.0",
					"Level 2.5",
					"Level 3.0",
					"Level 3.5",
					"Level 4.0",
					"Level 4.5",
					"Level 5.0",
					"Level 5.5",
					"Level 6.0",
					"Level 6.5",
					"Level 7.0",
					"Level 7.5",
					"Level 8.0",
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set K Block2 Filter operation mode.");
				array[36] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[37] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter Direction", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Front",
					"Rear",
					"Side"
				}, "Set K Block2 Filter direction.");
				array[38] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter Minimum Frequency", array14, array15, "Set K Block2 Filter minimum frequency.");
				array[39] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter Maximum Frequency", array14, array15, "Set K Block2 Filter maximum frequency.");
				array[40] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block3 Filter Mode", new int[]
				{
					8,
					9,
					10,
					11,
					12,
					13,
					14,
					15,
					16,
					17,
					18,
					19,
					20,
					21,
					22,
					23,
					1,
					2,
					3,
					7
				}, new string[]
				{
					"Level 0.5",
					"Level 1.0",
					"Level 1.5",
					"Level 2.0",
					"Level 2.5",
					"Level 3.0",
					"Level 3.5",
					"Level 4.0",
					"Level 4.5",
					"Level 5.0",
					"Level 5.5",
					"Level 6.0",
					"Level 6.5",
					"Level 7.0",
					"Level 7.5",
					"Level 8.0",
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set K Block3 Filter operation mode.");
				array[41] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[42] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter Direction", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Front",
					"Rear",
					"Side"
				}, "Set K Block3 Filter direction.");
				array[43] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter Minimum Frequency", array14, array15, "Set K Block3 Filter minimum frequency.");
				array[44] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter Maximum Frequency", array14, array15, "Set K Block3 Filter maximum frequency.");
				array[45] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block1 Filter Mode", new int[]
				{
					8,
					9,
					10,
					11,
					12,
					13,
					14,
					15,
					16,
					17,
					18,
					19,
					20,
					21,
					22,
					23,
					1,
					2,
					3,
					7
				}, new string[]
				{
					"Level 0.5",
					"Level 1.0",
					"Level 1.5",
					"Level 2.0",
					"Level 2.5",
					"Level 3.0",
					"Level 3.5",
					"Level 4.0",
					"Level 4.5",
					"Level 5.0",
					"Level 5.5",
					"Level 6.0",
					"Level 6.5",
					"Level 7.0",
					"Level 7.5",
					"Level 8.0",
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set User K Block1 Filter operation mode.");
				array[46] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[47] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block1 Filter Direction", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Front",
					"Rear",
					"Side"
				}, "Set User K Block1 Filter direction.");
				array[48] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block1 Filter Minimum Frequency", array14, array15, "Set User K Block1 Filter minimum frequency.");
				array[49] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block1 Filter Maximum Frequency", array14, array15, "Set User K Block1 Filter maximum frequency.");
				array[50] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block2 Filter Mode", new int[]
				{
					8,
					9,
					10,
					11,
					12,
					13,
					14,
					15,
					16,
					17,
					18,
					19,
					20,
					21,
					22,
					23,
					1,
					2,
					3,
					7
				}, new string[]
				{
					"Level 0.5",
					"Level 1.0",
					"Level 1.5",
					"Level 2.0",
					"Level 2.5",
					"Level 3.0",
					"Level 3.5",
					"Level 4.0",
					"Level 4.5",
					"Level 5.0",
					"Level 5.5",
					"Level 6.0",
					"Level 6.5",
					"Level 7.0",
					"Level 7.5",
					"Level 8.0",
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set User K Block2 Filter operation mode.");
				array[51] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[52] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block2 Filter Direction", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Front",
					"Rear",
					"Side"
				}, "Set User K Block2 Filter direction.");
				array[53] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block2 Filter Minimum Frequency", array14, array15, "Set User K Block2 Filter minimum frequency.");
				array[54] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block2 Filter Maximum Frequency", array14, array15, "Set User K Block2 Filter maximum frequency.");
				array[55] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block3 Filter Mode", new int[]
				{
					8,
					9,
					10,
					11,
					12,
					13,
					14,
					15,
					16,
					17,
					18,
					19,
					20,
					21,
					22,
					23,
					1,
					2,
					3,
					7
				}, new string[]
				{
					"Level 0.5",
					"Level 1.0",
					"Level 1.5",
					"Level 2.0",
					"Level 2.5",
					"Level 3.0",
					"Level 3.5",
					"Level 4.0",
					"Level 4.5",
					"Level 5.0",
					"Level 5.5",
					"Level 6.0",
					"Level 6.5",
					"Level 7.0",
					"Level 7.5",
					"Level 8.0",
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set User K Block3 Filter operation mode.");
				array[56] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[57] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block3 Filter Direction", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Front",
					"Rear",
					"Side"
				}, "Set User K Block3 Filter direction.");
				array[58] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block3 Filter Minimum Frequency", array14, array15, "Set User K Block3 Filter minimum frequency.");
				array[59] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block3 Filter Maximum Frequency", array14, array15, "Set User K Block3 Filter maximum frequency.");
				array[60] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block4 Filter Mode", new int[]
				{
					8,
					9,
					10,
					11,
					12,
					13,
					14,
					15,
					16,
					17,
					18,
					19,
					20,
					21,
					22,
					23,
					1,
					2,
					3,
					7
				}, new string[]
				{
					"Level 0.5",
					"Level 1.0",
					"Level 1.5",
					"Level 2.0",
					"Level 2.5",
					"Level 3.0",
					"Level 3.5",
					"Level 4.0",
					"Level 4.5",
					"Level 5.0",
					"Level 5.5",
					"Level 6.0",
					"Level 6.5",
					"Level 7.0",
					"Level 7.5",
					"Level 8.0",
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set User K Block4 Filter operation mode.");
				array[61] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[62] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block4 Filter Direction", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Front",
					"Rear",
					"Side"
				}, "Set User K Block4 Filter direction.");
				array[63] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block4 Filter Minimum Frequency", array14, array15, "Set User K Block4 Filter minimum frequency.");
				array[64] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block4 Filter Maximum Frequency", array14, array15, "Set User K Block4 Filter maximum frequency.");
				array[65] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block5 Filter Mode", new int[]
				{
					8,
					9,
					10,
					11,
					12,
					13,
					14,
					15,
					16,
					17,
					18,
					19,
					20,
					21,
					22,
					23,
					1,
					2,
					3,
					7
				}, new string[]
				{
					"Level 0.5",
					"Level 1.0",
					"Level 1.5",
					"Level 2.0",
					"Level 2.5",
					"Level 3.0",
					"Level 3.5",
					"Level 4.0",
					"Level 4.5",
					"Level 5.0",
					"Level 5.5",
					"Level 6.0",
					"Level 6.5",
					"Level 7.0",
					"Level 7.5",
					"Level 8.0",
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set User K Block5 Filter operation mode.");
				array[66] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[67] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block5 Filter Direction", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Front",
					"Rear",
					"Side"
				}, "Set User K Block5 Filter direction.");
				array[68] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block5 Filter Minimum Frequency", array14, array15, "Set User K Block5 Filter minimum frequency.");
				array[69] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block5 Filter Maximum Frequency", array14, array15, "Set User K Block5 Filter maximum frequency.");
				array[70] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Narrow/Wide/Extended", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Narrow",
					"Wide",
					"Extended"
				}, "K Narrow scans a narrower frequency range than K Wide.\nK Extended increases the frequency scanning range for K band radar guns.");
				array[71] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Narrow/Wide/Segmentation", new int[]
				{
					1,
					0,
					2
				}, new string[]
				{
					"Narrow",
					"Wide",
					"Segmentation"
				}, "Ka Narrow scans for Ka radar guns used in the US only and reduces false alarms.\nKa Narrow also provides a fast response to Ka POP radar guns.\nKa Wide scans Super Wide Ka band.\nKa Segmentation allows the user to customize a Ka band sweep from 9 filtered settings.");
				UserSettingMenu[] array16 = array;
				int num7 = 72;
				UserSettingMenu.MENU_TYPE menuType7 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString7 = "Ka Segmentation 33.399Ghz – 33.705Ghz";
				int[] array17 = new int[2];
				array17[0] = 1;
				array16[num7] = new UserSettingMenu(menuType7, menuString7, array17, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.399Ghz – 33.705Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array18 = array;
				int num8 = 73;
				UserSettingMenu.MENU_TYPE menuType8 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString8 = "Ka Segmentation 33.705Ghz – 33.903Ghz";
				int[] array19 = new int[2];
				array19[0] = 1;
				array18[num8] = new UserSettingMenu(menuType8, menuString8, array19, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.705Ghz – 33.903Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array20 = array;
				int num9 = 74;
				UserSettingMenu.MENU_TYPE menuType9 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString9 = "Ka Segmentation 33.903Ghz – 34.191Ghz";
				int[] array21 = new int[2];
				array21[0] = 1;
				array20[num9] = new UserSettingMenu(menuType9, menuString9, array21, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.903Ghz – 34.191Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array22 = array;
				int num10 = 75;
				UserSettingMenu.MENU_TYPE menuType10 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString10 = "Ka Segmentation 34.191Ghz – 34.587Ghz";
				int[] array23 = new int[2];
				array23[0] = 1;
				array22[num10] = new UserSettingMenu(menuType10, menuString10, array23, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.191Ghz – 34.587Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array24 = array;
				int num11 = 76;
				UserSettingMenu.MENU_TYPE menuType11 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString11 = "Ka Segmentation 34.587Ghz – 34.803Ghz";
				int[] array25 = new int[2];
				array25[0] = 1;
				array24[num11] = new UserSettingMenu(menuType11, menuString11, array25, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.587Ghz – 34.803Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array26 = array;
				int num12 = 77;
				UserSettingMenu.MENU_TYPE menuType12 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString12 = "Ka Segmentation 34.803Ghz – 35.163Ghz";
				int[] array27 = new int[2];
				array27[0] = 1;
				array26[num12] = new UserSettingMenu(menuType12, menuString12, array27, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.803Ghz – 35.163Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array28 = array;
				int num13 = 78;
				UserSettingMenu.MENU_TYPE menuType13 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString13 = "Ka Segmentation 35.163Ghz – 35.379Ghz";
				int[] array29 = new int[2];
				array29[0] = 1;
				array28[num13] = new UserSettingMenu(menuType13, menuString13, array29, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.163Ghz – 35.379Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array30 = array;
				int num14 = 79;
				UserSettingMenu.MENU_TYPE menuType14 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString14 = "Ka Segmentation 35.379Ghz – 35.613Ghz";
				int[] array31 = new int[2];
				array31[0] = 1;
				array30[num14] = new UserSettingMenu(menuType14, menuString14, array31, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.379Ghz – 35.613Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array32 = array;
				int num15 = 80;
				UserSettingMenu.MENU_TYPE menuType15 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString15 = "Ka Segmentation 35.613Ghz – 35.701Ghz";
				int[] array33 = new int[2];
				array33[0] = 1;
				array32[num15] = new UserSettingMenu(menuType15, menuString15, array33, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.613Ghz – 35.701Ghz (Ka Segmentation mode)");
				array[81] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Priority", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Signal",
					"MRCD Ka",
					"Ka MRCD"
				}, "Set the alert priority as below.\n1.Signal Priority: MRCD > Other Band(alert to a stronger signal)\n2.Ka / MRCD Priority: Ka > MRCD > Other Band(alert to a stronger signal)\n3.MRCD / Ka Priority(Default) : MRCD > Ka > Other Band(alert to a stronger signal)\n4.Laser unconditionally alerts at the first.");
				array[82] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Select bands to be muted.");
				array[83] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute Memory On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "This menu turns the ability to automatically save mute requests for specific locations/frequency bands.");
				array[84] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Auto Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Auto Mute Memory Band Option Set specifies which bands will be muted.");
				UserSettingMenu[] array34 = array;
				int num16 = 85;
				UserSettingMenu.MENU_TYPE menuType16 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString16 = "All Threat Display";
				int[] array35 = new int[2];
				array35[0] = 1;
				array34[num16] = new UserSettingMenu(menuType16, menuString16, array35, new string[]
				{
					"Off",
					"On"
				}, "Displays if more than one radar signals are detected at the same time. The signal with the strongest radar signal is considered the main signal. The other signals are displayed on the left side.");
				array[86] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Background Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7
				}, new string[]
				{
					"Blue",
					"Amber",
					"Green",
					"Pink",
					"Gray",
					"Red",
					"White",
					"Violet"
				}, "Select screen text color.");
				array[87] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Arrow Color", new int[]
				{
					6,
					5,
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red"
				}, "Set X band arrow color.");
				array[88] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Arrow Color", new int[]
				{
					6,
					5,
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red"
				}, "Set K band arrow color.");
				array[89] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD/T Arrow Color", new int[]
				{
					6,
					5,
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red"
				}, "Set MRCD/T arrow color.");
				array[90] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "GATSO RT3/4 Arrow Color", new int[]
				{
					6,
					5,
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red"
				}, "Set Gatso RT3/4 arrow color.");
				array[91] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Arrow Color", new int[]
				{
					6,
					5,
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red"
				}, "Set Ka band arrow color.");
				array[92] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Color", new int[]
				{
					8,
					7,
					6,
					5,
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red",
					"Arrow",
					"Signal"
				}, "Set X band indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[93] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Color", new int[]
				{
					8,
					7,
					6,
					5,
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red",
					"Arrow",
					"Signal"
				}, "Set K band indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[94] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD/T Color", new int[]
				{
					8,
					7,
					6,
					5,
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red",
					"Arrow",
					"Signal"
				}, "Set MRCD/T indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[95] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Gatso RT3/4 Color", new int[]
				{
					8,
					7,
					6,
					5,
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red",
					"Arrow",
					"Signal"
				}, "Set Gatso RT3/4 indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[96] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Color", new int[]
				{
					8,
					7,
					6,
					5,
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red",
					"Arrow",
					"Signal"
				}, "Set Ka band indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[97] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Display", new int[]
				{
					1,
					0,
					2
				}, new string[]
				{
					"Mode",
					"Scan",
					"Time"
				}, "Select what will display on the OLED, either scanning for frequencies, the mode, or the time.\n(GPS On)");
				UserSettingMenu[] array36 = array;
				int num17 = 98;
				UserSettingMenu.MENU_TYPE menuType17 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString17 = "Scan Icon";
				int[] array37 = new int[2];
				array37[0] = 1;
				array36[num17] = new UserSettingMenu(menuType17, menuString17, array37, new string[]
				{
					"Off",
					"On"
				}, "Scan Icon displays to indicate the end of a scan cycle.");
				array[99] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Left Display", new int[]
				{
					1,
					2,
					3,
					4,
					5
				}, new string[]
				{
					"Elevation",
					"Voltage",
					"Compass",
					"Speed",
					"Speed + Compass"
				}, "Lets you select various attributes to display on the left side of the OLED.\n(GPS On)");
				array[100] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Alert Display", new int[]
				{
					1,
					0,
					2
				}, new string[]
				{
					"Type 1",
					"Type 2",
					"Type 3"
				}, "Select one of three OLED display formats.");
				UserSettingMenu[] array38 = array;
				int num18 = 101;
				UserSettingMenu.MENU_TYPE menuType18 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString18 = "Speed Unit";
				int[] array39 = new int[2];
				array39[0] = 1;
				array38[num18] = new UserSettingMenu(menuType18, menuString18, array39, new string[]
				{
					"mph",
					"km/h"
				}, "Select the speed measurement type.");
				array[101].isUnitMenuFlag = true;
				array[102] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "X Band Alert Tone", new int[]
				{
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9,
					10,
					11,
					12
				}, new string[]
				{
					"Tone 1",
					"Tone 2",
					"Tone 3",
					"Tone 4",
					"Tone 5",
					"Tone 6",
					"Tone 7",
					"Tone 8",
					"Tone 9",
					"Tone 10",
					"Tone 11",
					"Tone 12"
				}, "Set a tone to indicate X Band.");
				array[103] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Alert Tone", new int[]
				{
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9,
					10,
					11,
					12
				}, new string[]
				{
					"Tone 1",
					"Tone 2",
					"Tone 3",
					"Tone 4",
					"Tone 5",
					"Tone 6",
					"Tone 7",
					"Tone 8",
					"Tone 9",
					"Tone 10",
					"Tone 11",
					"Tone 12"
				}, "Set a tone to indicate K Band.");
				array[104] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Tone", new int[]
				{
					6,
					1,
					2,
					3,
					4,
					5
				}, new string[]
				{
					"Off",
					"Tone 1",
					"Tone 2",
					"Tone 3",
					"Tone 4",
					"Tone 5"
				}, "Set a tone to indicate the detector is responding to a different K band signal.");
				array[105] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Level", new int[]
				{
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8
				}, new string[]
				{
					"Level 1",
					"Level 2",
					"Level 3",
					"Level 4",
					"Level 5",
					"Level 6",
					"Level 7",
					"Level 8"
				}, "Set a level for K band bogey alarm.");
				array[106] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "MRCD/T Alert Tone", new int[]
				{
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9,
					10,
					11,
					12
				}, new string[]
				{
					"Tone 1",
					"Tone 2",
					"Tone 3",
					"Tone 4",
					"Tone 5",
					"Tone 6",
					"Tone 7",
					"Tone 8",
					"Tone 9",
					"Tone 10",
					"Tone 11",
					"Tone 12"
				}, "Set a tone to indicate MRCD/T.");
				array[107] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "GATSO RT3/4 Alert Tone", new int[]
				{
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9,
					10,
					11,
					12
				}, new string[]
				{
					"Tone 1",
					"Tone 2",
					"Tone 3",
					"Tone 4",
					"Tone 5",
					"Tone 6",
					"Tone 7",
					"Tone 8",
					"Tone 9",
					"Tone 10",
					"Tone 11",
					"Tone 12"
				}, "Set a tone to indicate Gatso RT3/4.");
				array[108] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Alert Tone", new int[]
				{
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9,
					10,
					11,
					12
				}, new string[]
				{
					"Tone 1",
					"Tone 2",
					"Tone 3",
					"Tone 4",
					"Tone 5",
					"Tone 6",
					"Tone 7",
					"Tone 8",
					"Tone 9",
					"Tone 10",
					"Tone 11",
					"Tone 12"
				}, "Set a tone to indicate Ka Band.");
				array[109] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Bogey Tone", new int[]
				{
					6,
					1,
					2,
					3,
					4,
					5
				}, new string[]
				{
					"Off",
					"Tone 1",
					"Tone 2",
					"Tone 3",
					"Tone 4",
					"Tone 5"
				}, "Set a tone to indicate the detector is responding to a different Ka band signal.");
				array[110] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Laser Alert Tone", new int[]
				{
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9,
					10,
					11,
					12
				}, new string[]
				{
					"Tone 1",
					"Tone 2",
					"Tone 3",
					"Tone 4",
					"Tone 5",
					"Tone 6",
					"Tone 7",
					"Tone 8",
					"Tone 9",
					"Tone 10",
					"Tone 11",
					"Tone 12"
				}, "Set a tone to indicate Laser.");
				array[111] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Alert Level", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8
				}, new string[]
				{
					"Off",
					"Level 1",
					"Level 2",
					"Level 3",
					"Level 4",
					"Level 5",
					"Level 6",
					"Level 7",
					"Level 8"
				}, "When a signal below the Auto Mute Alert Level is detected, set the volume to Auto Mute Volume.Auto Mute reduces alarm level to Auto Mute Volume after 3 seconds and returns to normal operation(Auto Mute = OFF) 10 seconds after the alert ends.If the same alarm sounds within the 10 second period, Auto Mute remains at Auto Mute Volume level.The unit returns to normal operation(Auto Mute = OFF) if a different band is detected during Auto Mute = ON mode.");
				array[112] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Volume", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7
				}, new string[]
				{
					"Volume 0",
					"Volume 1",
					"Volume 2",
					"Volume 3",
					"Volume 4",
					"Volume 5",
					"Volume 6",
					"Volume 7"
				}, "Sets a volume level for muted alarms.");
				UserSettingMenu[] array40 = array;
				int num19 = 113;
				UserSettingMenu.MENU_TYPE menuType19 = UserSettingMenu.MENU_TYPE.SOUND;
				string menuString19 = "Alert Temporary Volume";
				int[] array41 = new int[2];
				array41[0] = 1;
				array40[num19] = new UserSettingMenu(menuType19, menuString19, array41, new string[]
				{
					"Off",
					"On"
				}, "Temporary volume function On/Off.");
				UserSettingMenu[] array42 = array;
				int num20 = 114;
				UserSettingMenu.MENU_TYPE menuType20 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString20 = "Rear K Band Mute";
				int[] array43 = new int[2];
				array43[0] = 1;
				array42[num20] = new UserSettingMenu(menuType20, menuString20, array43, new string[]
				{
					"Off",
					"On"
				}, "Mutes K band signals from rear side.");
				array[115] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Dark mode Brightness", new int[]
				{
					4,
					3,
					2
				}, new string[]
				{
					"Bright",
					"Dim",
					"Dimmer"
				}, "Set Alert brightness.");
				array[116] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Mode", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Time",
					"Sensor"
				}, "Set the start times for the OLED to automatically brighten or dim.\nSelecting Time will let you set specific times when you want the OLED to get brighter or dimmer.\nSelecting Sensor will let the ambient light levels trigger when the OLED will get brighter or dimmer.");
				array[117] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Time", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8
				}, new string[]
				{
					"5:30am",
					"5:45am",
					"6:00am",
					"6:15am",
					"6:30am",
					"6:45am",
					"7:00am",
					"7:15am",
					"7:30am"
				}, "Set the start times for the OLED to automatically brighten.For example, you can set the OLED to be brighter at 6:00 AM.");
				array[118] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Brightness", new int[]
				{
					4,
					3,
					2
				}, new string[]
				{
					"Bright",
					"Dim",
					"Dimmer"
				}, "The R8w has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[119] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Time", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9,
					10,
					11,
					12
				}, new string[]
				{
					"5:00pm",
					"5:15pm",
					"5:30pm",
					"5:45pm",
					"6:00pm",
					"6:15pm",
					"6:30pm",
					"6:45pm",
					"7:00pm",
					"7:15pm",
					"7:30pm",
					"7:45pm",
					"8:00pm"
				}, "Set the start times for the OLED to automatically dim.For example, you can set the OLED to be dim at 6:00 PM.");
				array[120] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Brightness", new int[]
				{
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Bright",
					"Dim",
					"Dimmer",
					"Dark",
					"Off"
				}, "The R8w has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[121] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Backlight On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns the front key backlight on and off.");
				array[122] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Quiet Ride", new int[][]
				{
					new int[]
					{
						0,
						5,
						10,
						15,
						20,
						25,
						30,
						35,
						40,
						45,
						50,
						55,
						60,
						65,
						70,
						75,
						80,
						85,
						90
					},
					new int[]
					{
						0,
						10,
						20,
						30,
						40,
						50,
						60,
						70,
						80,
						90,
						100,
						110,
						120,
						130,
						140
					}
				}, new string[][]
				{
					new string[]
					{
						"Off",
						"5mph",
						"10mph",
						"15mph",
						"20mph",
						"25mph",
						"30mph",
						"35mph",
						"40mph",
						"45mph",
						"50mph",
						"55mph",
						"60mph",
						"65mph",
						"70mph",
						"75mph",
						"80mph",
						"85mph",
						"90mph"
					},
					new string[]
					{
						"Off",
						"10km/h",
						"20km/h",
						"30km/h",
						"40km/h",
						"50km/h",
						"60km/h",
						"70km/h",
						"80km/h",
						"90km/h",
						"100km/h",
						"110km/h",
						"120km/h",
						"130km/h",
						"140km/h"
					}
				}, new string[]
				{
					"mph",
					"km/h"
				}, "Mutes radar alarms for K and X bands when you drive under the speed limit you set here.");
				UserSettingMenu[] array44 = array;
				int num21 = 123;
				UserSettingMenu.MENU_TYPE menuType21 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString21 = "Quiet Ride MRCD On/Off";
				int[] array45 = new int[2];
				array45[0] = 1;
				array44[num21] = new UserSettingMenu(menuType21, menuString21, array45, new string[]
				{
					"Off",
					"On"
				}, "Mutes MRCD/T alarms when users drive under the speed limit set previously.");
				array[124] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Quiet Ride Volume", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8
				}, new string[]
				{
					"Volume 0",
					"Volume 1",
					"Volume 2",
					"Volume 3",
					"Volume 4",
					"Volume 5",
					"Volume 6",
					"Volume 7",
					"Volume 8"
				}, "Sets the volume for Quiet Ride alerts.");
				array[125] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Limit Speed", new int[][]
				{
					new int[]
					{
						0,
						50,
						55,
						60,
						65,
						70,
						75,
						80,
						85,
						90,
						95,
						100
					},
					new int[]
					{
						0,
						80,
						90,
						100,
						110,
						120,
						130,
						140,
						150,
						160
					}
				}, new string[][]
				{
					new string[]
					{
						"Off",
						"50mph",
						"55mph",
						"60mph",
						"65mph",
						"70mph",
						"75mph",
						"80mph",
						"85mph",
						"90mph",
						"95mph",
						"100mph"
					},
					new string[]
					{
						"Off",
						"80km/h",
						"90km/h",
						"100km/h",
						"110km/h",
						"120km/h",
						"130km/h",
						"140km/h",
						"150km/h",
						"160km/h"
					}
				}, new string[]
				{
					"mph",
					"km/h"
				}, "Set an alarm to sound if you go faster than this selected speed.");
				array[126] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "GMT", new int[]
				{
					-12,
					-11,
					-10,
					-9,
					-8,
					-7,
					-6,
					-5,
					-4,
					-3,
					-2,
					-1,
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9,
					10,
					11,
					12
				}, new string[]
				{
					"-12",
					"-11",
					"-10",
					"-9",
					"-8",
					"-7",
					"-6",
					"-5",
					"-4",
					"-3",
					"-2",
					"-1",
					"0",
					"1",
					"2",
					"3",
					"4",
					"5",
					"6",
					"7",
					"8",
					"9",
					"10",
					"11",
					"12"
				}, "Sets time zone according to Greenwich Mean Time(GMT).");
				UserSettingMenu[] array46 = array;
				int num22 = 127;
				UserSettingMenu.MENU_TYPE menuType22 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString22 = "DST";
				int[] array47 = new int[2];
				array47[0] = 1;
				array46[num22] = new UserSettingMenu(menuType22, menuString22, array47, new string[]
				{
					"Off",
					"On"
				}, "Daylight Saving Time");
				UserSettingMenu[] array48 = array;
				int num23 = 128;
				UserSettingMenu.MENU_TYPE menuType23 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString23 = "Low Battery Warning";
				int[] array49 = new int[2];
				array49[0] = 1;
				array48[num23] = new UserSettingMenu(menuType23, menuString23, array49, new string[]
				{
					"Off",
					"On"
				}, "Sounds a warning tone if the vehicle battery power drops below 11V.");
				UserSettingMenu[] array50 = array;
				int num24 = 129;
				UserSettingMenu.MENU_TYPE menuType24 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString24 = "Vehicle Battery Saver";
				int[] array51 = new int[2];
				array51[0] = 1;
				array50[num24] = new UserSettingMenu(menuType24, menuString24, array51, new string[]
				{
					"Off",
					"On"
				}, "Turns off power to the R8w if the speed stays at 0 or if the GPS is not connected for more than an hour.");
				array[130] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Self Test", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Runs a self diagnostic test on the unit to check for faults.");
				array[131] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Memory Quota", new int[]
				{
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8,
					9,
					10,
					11,
					12,
					13,
					14,
					15,
					16,
					17,
					18,
					19,
					20,
					21,
					22,
					23,
					24,
					25,
					26,
					27,
					28,
					29,
					30,
					31
				}, new string[]
				{
					"1750/250",
					"1700/300",
					"1650/350",
					"1600/400",
					"1550/450",
					"1500/500",
					"1450/550",
					"1400/600",
					"1350/650",
					"1300/700",
					"1250/750",
					"1200/800",
					"1150/850",
					"1100/900",
					"1050/950",
					"1000/1000",
					"950/1050",
					"900/1100",
					"850/1150",
					"800/1200",
					"750/1250",
					"700/1300",
					"650/1350",
					"600/1400",
					"550/1450",
					"500/1500",
					"450/1550",
					"400/1600",
					"350/1650",
					"300/1700",
					"250/1750"
				}, "Allocate a total of 2000 memory points between Mute Memory and User Marks.\n(Mute Memory/User Mark)");
				array[132] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Dim", new int[]
				{
					5,
					4,
					3,
					2,
					1,
					0
				}, new string[]
				{
					"Auto",
					"Bright",
					"Dim",
					"Dimmer",
					"Dark",
					"Off"
				}, "Set a main dim");
				array[133] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Main Volume", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6,
					7,
					8
				}, new string[]
				{
					"Volume 0",
					"Volume 1",
					"Volume 2",
					"Volume 3",
					"Volume 4",
					"Volume 5",
					"Volume 6",
					"Volume 7",
					"Volume 8"
				}, "Set a main volume");
				return array;
			}

			// Token: 0x0600031E RID: 798 RVA: 0x0004B83C File Offset: 0x00049A3C
			private bool user_k_block_n_data_check_previous(byte[][] userSettingData, int rd_addr)
			{
				int num = ((int)userSettingData[rd_addr][0] << 24) + ((int)userSettingData[rd_addr][1] << 16) + ((int)userSettingData[rd_addr][2] << 8) + (int)userSettingData[rd_addr][3];
				int num2 = (num & 261632) >> 9;
				int num3 = num & 511;
				return num2 == 511 && num3 == 511;
			}

			// Token: 0x0600031F RID: 799 RVA: 0x0002BBAB File Offset: 0x00029DAB
			private int user_k_block_n_data_raw_strength_read(byte[][] userSettingData, int rd_addr)
			{
				return (((int)userSettingData[rd_addr][3] << 24) + ((int)userSettingData[rd_addr][2] << 16) + ((int)userSettingData[rd_addr][1] << 8) + (int)userSettingData[rd_addr][0] & 66846720) >> 18;
			}

			// Token: 0x06000320 RID: 800 RVA: 0x0004B890 File Offset: 0x00049A90
			private void user_k_block_n_data_read(byte[][] userSettingData, int rd_addr, int[] settingR7, int menu_op_mode_num, int mode)
			{
				int num = ((int)userSettingData[rd_addr][3] << 24) + ((int)userSettingData[rd_addr][2] << 16) + ((int)userSettingData[rd_addr][1] << 8) + (int)userSettingData[rd_addr][0];
				int num2 = (num & 1879048192) >> 28;
				int num3 = (num & 201326592) >> 26;
				int num4 = (num & 66846720) >> 18;
				int num5 = (num & 261632) >> 9;
				int num6 = num & 511;
				int num7 = this.user_k_block_get_level(num4, mode);
				if (num3 == 3)
				{
					num3 = 2;
				}
				if (num5 == 511)
				{
					num5 = 0;
				}
				if (num6 == 511)
				{
					num6 = 0;
				}
				if (num2 == 0)
				{
					settingR7[menu_op_mode_num] = num7;
				}
				else
				{
					settingR7[menu_op_mode_num] = num2;
				}
				settingR7[menu_op_mode_num + 1] = num4;
				settingR7[menu_op_mode_num + 2] = num3;
				settingR7[menu_op_mode_num + 3] = num5 + 23900;
				settingR7[menu_op_mode_num + 4] = num6 + 23900;
			}

			// Token: 0x06000321 RID: 801 RVA: 0x0004B954 File Offset: 0x00049B54
			private void user_k_block_n_data_write(byte[][] userSettingData, int rd_addr, int[] settingR7, int menu_op_mode_num, int mode)
			{
				int num = 0;
				int num2 = settingR7[menu_op_mode_num];
				if (settingR7[menu_op_mode_num] > 7)
				{
					num2 = 0;
				}
				else
				{
					num2 = settingR7[menu_op_mode_num];
				}
				int num3 = settingR7[menu_op_mode_num + 1];
				int num4;
				if (settingR7[menu_op_mode_num + 2] == 3)
				{
					num4 = 2;
				}
				else
				{
					num4 = settingR7[menu_op_mode_num + 2];
				}
				int num5;
				if (settingR7[menu_op_mode_num + 3] != 511)
				{
					num5 = settingR7[menu_op_mode_num + 3] - 23900;
				}
				else
				{
					num5 = 511;
				}
				int num6;
				if (settingR7[menu_op_mode_num + 4] != 511)
				{
					num6 = settingR7[menu_op_mode_num + 4] - 23900;
				}
				else
				{
					num6 = 511;
				}
				num |= (num2 << 28 & 1879048192);
				num |= (num4 << 26 & 201326592);
				num |= (num3 << 18 & 66846720);
				num |= (num5 << 9 & 261632);
				num |= (num6 & 511);
				userSettingData[rd_addr][3] = (byte)(num >> 24 & (int)BinaryDefine.b11111111);
				userSettingData[rd_addr][2] = (byte)(num >> 16 & (int)BinaryDefine.b11111111);
				userSettingData[rd_addr][1] = (byte)(num >> 8 & (int)BinaryDefine.b11111111);
				userSettingData[rd_addr][0] = (byte)(num & (int)BinaryDefine.b11111111);
			}

			// Token: 0x06000322 RID: 802 RVA: 0x0004BA58 File Offset: 0x00049C58
			public int[] GetUserSettingFromNVData(byte[] nvData, ref int hwRevisionVersion)
			{
				int[] array = Enumerable.Repeat<int>(-1000, this.menuCnt).ToArray<int>();
				if (array.Length == 0)
				{
					return null;
				}
				hwRevisionVersion = -1;
				byte[][] array2 = new byte[nvData.Length / 4][];
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = new byte[4];
					for (int j = 0; j < 4; j++)
					{
						array2[i][j] = nvData[i * 4 + j];
					}
				}
				byte b = array2[2][3];
				byte b2 = BinaryDefine.b00000001;
				array[71] = (array2[2][3] >> 5 & (int)BinaryDefine.b00000011);
				array[86] = (array2[2][3] >> 2 & (int)BinaryDefine.b00000111);
				array[85] = (array2[2][3] >> 1 & (int)BinaryDefine.b00000001);
				array[29] = (int)(array2[2][3] & BinaryDefine.b00000001);
				switch (array[86])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
					break;
				default:
					array[86] = 5;
					break;
				}
				array[28] = (array2[2][2] >> 7 & (int)BinaryDefine.b00000001);
				array[16] = (array2[2][2] >> 6 & (int)BinaryDefine.b00000001);
				array[18] = (array2[2][2] >> 5 & (int)BinaryDefine.b00000001);
				array[19] = (array2[2][2] >> 4 & (int)BinaryDefine.b00000001);
				array[20] = (array2[2][2] >> 3 & (int)BinaryDefine.b00000001);
				array[21] = (array2[2][2] >> 2 & (int)BinaryDefine.b00000001);
				array[26] = (array2[2][2] >> 1 & (int)BinaryDefine.b00000001);
				array[10] = (array2[2][1] >> 7 & (int)BinaryDefine.b00000001);
				int num = array2[2][1] >> 3 & (int)BinaryDefine.b00000001;
				array[121] = (array2[2][1] >> 2 & (int)BinaryDefine.b00000001);
				array[128] = (array2[2][1] >> 1 & (int)BinaryDefine.b00000001);
				array[130] = (int)(array2[2][1] & BinaryDefine.b00000001);
				array[132] = (array2[2][0] >> 4 & (int)BinaryDefine.b00000111);
				array[133] = (int)(array2[2][0] & BinaryDefine.b00001111);
				switch (array[132])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
					break;
				default:
					array[132] = 5;
					break;
				}
				if (array[133] < 0 || array[133] > 8)
				{
					array[133] = 4;
				}
				array[101] = (array2[1][2] >> 7 & (int)BinaryDefine.b00000001);
				array[127] = (array2[1][2] >> 5 & (int)BinaryDefine.b00000001);
				int num2 = (int)(array2[1][2] & BinaryDefine.b00011111);
				if (array[101] == 1)
				{
					if (num2 >= 0 && num2 <= 18)
					{
						array[122] = num2 * 5;
					}
					else
					{
						array[122] = 0;
					}
				}
				else if (num2 >= 0 && num2 <= 14)
				{
					array[122] = num2 * 10;
				}
				else
				{
					array[122] = 0;
				}
				array[129] = (array2[1][3] >> 6 & (int)BinaryDefine.b00000001);
				array[23] = (array2[1][3] >> 5 & (int)BinaryDefine.b00000001);
				num2 = (int)(array2[1][3] & BinaryDefine.b00011111);
				if (array[101] == 1)
				{
					if (num2 == 0 || (num2 >= 10 && num2 <= 17))
					{
						array[14] = num2 * 5;
					}
					else
					{
						array[14] = 0;
					}
				}
				else if (num2 == 0 || (num2 >= 8 && num2 <= 14))
				{
					array[14] = num2 * 10;
				}
				else
				{
					array[14] = 0;
				}
				array[11] = (array2[1][1] >> 6 & (int)BinaryDefine.b00000001);
				array[13] = (array2[1][1] >> 5 & (int)BinaryDefine.b00000001);
				num2 = (int)(array2[1][1] & BinaryDefine.b00011111);
				if (array[101] == 1)
				{
					if (num2 == 0 || (num2 >= 10 && num2 <= 20))
					{
						array[125] = num2 * 5;
					}
					else
					{
						array[125] = 0;
					}
				}
				else if (num2 == 0 || (num2 >= 8 && num2 <= 16))
				{
					array[125] = num2 * 10;
				}
				else
				{
					array[125] = 0;
				}
				array[99] = (array2[1][0] >> 5 & (int)BinaryDefine.b00000111);
				num2 = (int)(array2[1][0] & BinaryDefine.b00011111);
				if (array[99] >= 6)
				{
					if (array[10] == 1)
					{
						array[99] = 4;
					}
					else
					{
						array[99] = 2;
					}
				}
				if (num2 != 31)
				{
					array[126] = (int)((byte)num2 - 12);
					if (array[126] < -12 || array[126] > 12)
					{
						array[126] = -8;
					}
				}
				else
				{
					array[126] = -8;
				}
				array[82] = (array2[3][3] >> 6 & (int)BinaryDefine.b00000001);
				array[17] = (array2[3][3] >> 5 & (int)BinaryDefine.b00000001);
				array[81] = (array2[3][3] >> 3 & (int)BinaryDefine.b00000011);
				array[112] = (int)(array2[3][3] & BinaryDefine.b00000111);
				if (array[112] < 0 || array[112] > 7)
				{
					array[112] = 2;
				}
				array[24] = (array2[3][2] >> 7 & (int)BinaryDefine.b00000001);
				array[2] = (array2[3][2] >> 3 & (int)BinaryDefine.b00000111);
				array[3] = (int)(array2[3][2] & BinaryDefine.b00000111);
				int num3 = array2[3][1] >> 6 & (int)BinaryDefine.b00000011;
				array[80] = (array2[3][1] >> 3 & (int)BinaryDefine.b00000001);
				array[4] = (int)(array2[3][1] & BinaryDefine.b00000111);
				array[79] = (array2[3][0] >> 7 & (int)BinaryDefine.b00000001);
				array[78] = (array2[3][0] >> 6 & (int)BinaryDefine.b00000001);
				array[77] = (array2[3][0] >> 5 & (int)BinaryDefine.b00000001);
				array[76] = (array2[3][0] >> 4 & (int)BinaryDefine.b00000001);
				array[75] = (array2[3][0] >> 3 & (int)BinaryDefine.b00000001);
				array[74] = (array2[3][0] >> 2 & (int)BinaryDefine.b00000001);
				array[73] = (array2[3][0] >> 1 & (int)BinaryDefine.b00000001);
				array[72] = (int)(array2[3][0] & BinaryDefine.b00000001);
				array[116] = (array2[4][3] >> 6 & (int)BinaryDefine.b00000001);
				array[118] = (array2[4][3] >> 3 & (int)BinaryDefine.b00000111);
				array[120] = (int)(array2[4][3] & BinaryDefine.b00000111);
				switch (array[118])
				{
				default:
					array[118] = 4;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				switch (array[120])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
					break;
				default:
					array[120] = 4;
					break;
				}
				array[102] = (array2[4][2] >> 4 & (int)BinaryDefine.b00001111);
				array[103] = (int)(array2[4][2] & BinaryDefine.b00001111);
				array[110] = (array2[4][1] >> 4 & (int)BinaryDefine.b00001111);
				array[108] = (int)(array2[4][1] & BinaryDefine.b00001111);
				array[109] = (array2[5][3] >> 4 & (int)BinaryDefine.b00000111);
				array[106] = (int)(array2[5][3] & BinaryDefine.b00001111);
				array[70] = (array2[5][2] >> 6 & (int)BinaryDefine.b00000011);
				array[83] = (array2[5][2] >> 5 & (int)BinaryDefine.b00000001);
				array[115] = (int)(array2[5][2] & BinaryDefine.b00000111);
				switch (array[115])
				{
				default:
					array[115] = 2;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				array[84] = (array2[5][1] >> 7 & (int)BinaryDefine.b00000001);
				array[88] = (array2[5][1] >> 3 & (int)BinaryDefine.b00000111);
				array[87] = (int)(array2[5][1] & BinaryDefine.b00000111);
				if (array[88] > 6)
				{
					array[88] = 0;
				}
				if (array[87] > 6)
				{
					array[87] = 0;
				}
				array[0] = (array2[5][0] >> 7 & (int)BinaryDefine.b00000001);
				array[123] = (array2[5][0] >> 6 & (int)BinaryDefine.b00000001);
				array[91] = (array2[5][0] >> 3 & (int)BinaryDefine.b00000111);
				array[89] = (int)(array2[5][0] & BinaryDefine.b00000111);
				if (array[91] > 6)
				{
					array[91] = 0;
				}
				if (array[89] > 6)
				{
					array[89] = 0;
				}
				if (array[102] > 12 || array[102] == 0)
				{
					array[102] = 1;
				}
				if (array[103] > 12 || array[103] == 0)
				{
					array[103] = 2;
				}
				if (array[106] > 12 || array[106] == 0)
				{
					array[106] = 2;
				}
				if (array[108] > 12 || array[108] == 0)
				{
					array[108] = 3;
				}
				if (array[109] > 6 || array[109] == 0)
				{
					array[109] = 1;
				}
				if (array[110] > 12 || array[110] == 0)
				{
					array[110] = 4;
				}
				array[93] = (array2[6][3] >> 4 & (int)BinaryDefine.b00001111);
				array[92] = (int)(array2[6][3] & BinaryDefine.b00001111);
				if (array[93] > 8)
				{
					array[93] = 0;
				}
				if (array[92] > 8)
				{
					array[92] = 0;
				}
				array[96] = (array2[6][2] >> 4 & (int)BinaryDefine.b00001111);
				array[94] = (int)(array2[6][2] & BinaryDefine.b00001111);
				if (array[96] > 8)
				{
					array[96] = 0;
				}
				if (array[94] > 8)
				{
					array[94] = 0;
				}
				array[9] = (array2[6][1] >> 7 & (int)BinaryDefine.b00000001);
				array[27] = (array2[6][1] >> 5 & (int)BinaryDefine.b00000001);
				array[98] = (array2[6][1] >> 4 & (int)BinaryDefine.b00000001);
				array[6] = (int)(array2[6][1] & BinaryDefine.b00001111);
				if (array[6] > 8)
				{
					array[6] = 8;
				}
				if (array[6] == 0)
				{
					array[6] = 8;
				}
				array[12] = (array2[6][0] >> 5 & (int)BinaryDefine.b00000111);
				array[124] = (array2[6][0] >> 1 & (int)BinaryDefine.b00001111);
				array[114] = (int)(array2[6][0] & BinaryDefine.b00000001);
				if (array[12] > 4)
				{
					array[12] = 1;
				}
				if (array[124] > 8)
				{
					array[124] = 1;
				}
				array[119] = (array2[7][3] >> 4 & (int)BinaryDefine.b00001111);
				array[117] = (int)(array2[7][3] & BinaryDefine.b00001111);
				if (array[119] > 12)
				{
					array[119] = 4;
				}
				if (array[117] > 8)
				{
					array[117] = 4;
				}
				num2 = (array2[7][2] >> 4 & (int)BinaryDefine.b00001111);
				array[100] = (array2[7][2] >> 2 & (int)BinaryDefine.b00000011);
				array[1] = (int)(array2[7][2] & BinaryDefine.b00000011);
				if (array[101] == 1)
				{
					if (num2 >= 2 && num2 <= 12)
					{
						array[5] = num2 * 5;
					}
					else
					{
						array[5] = 40;
					}
				}
				else if (num2 >= 1 && num2 <= 10)
				{
					array[5] = num2 * 10;
				}
				else
				{
					array[5] = 60;
				}
				if (array[100] > 2)
				{
					array[100] = 1;
				}
				switch (array[1])
				{
				case 0:
				case 1:
				case 2:
				case 3:
					break;
				default:
					array[1] = 1;
					break;
				}
				array[107] = (array2[7][1] >> 4 & (int)BinaryDefine.b00001111);
				array[15] = (array2[7][1] >> 3 & (int)BinaryDefine.b00000001);
				int num4 = array2[7][1] >> 1 & (int)BinaryDefine.b00000011;
				array[25] = (int)(array2[7][1] & BinaryDefine.b00000001);
				if (array[107] > 12 || array[107] == 0)
				{
					array[107] = 9;
				}
				array[90] = (array2[7][0] >> 4 & (int)BinaryDefine.b00000111);
				array[95] = (int)(array2[7][0] & BinaryDefine.b00001111);
				if (array[90] > 6)
				{
					array[90] = 0;
				}
				if (array[95] > 8)
				{
					array[95] = 0;
				}
				array[113] = (array2[8][3] >> 6 & (int)BinaryDefine.b00000001);
				array[97] = (array2[8][3] >> 3 & (int)BinaryDefine.b00000011);
				array[104] = (int)(array2[8][3] & BinaryDefine.b00000111);
				if (array[104] > 6 || array[104] == 0)
				{
					array[104] = 1;
				}
				switch (array[97])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[97] = 1;
					break;
				}
				array[22] = (int)(array2[8][2] & BinaryDefine.b00000001);
				array[111] = (array2[8][0] >> 4 & (int)BinaryDefine.b00001111);
				array[105] = (int)(array2[8][0] & BinaryDefine.b00001111);
				if (array[111] > 8)
				{
					if (num == 1)
					{
						array[111] = 8;
					}
					else
					{
						array[111] = 0;
					}
				}
				if (array[105] > 8 || array[105] < 1)
				{
					array[105] = 4;
				}
				array[7] = (array2[17][3] >> 4 & (int)BinaryDefine.b00001111);
				array[8] = (int)(array2[17][3] & BinaryDefine.b00001111);
				if (array[7] > 8)
				{
					array[7] = 8;
				}
				if (array[7] == 0)
				{
					array[7] = 8;
				}
				if (array[8] > 8)
				{
					array[8] = 8;
				}
				if (array[8] == 0)
				{
					array[8] = 8;
				}
				if (this.user_k_block_n_data_check_previous(array2, 14))
				{
					if (num3 == 1)
					{
						array[30] = 23;
						array[31] = 255;
					}
					else if (num3 == 2)
					{
						array[30] = 1;
						array[31] = 0;
					}
					else if (num3 == 3)
					{
						array[30] = 3;
						array[31] = 0;
					}
					else
					{
						array[30] = 7;
						array[31] = 0;
					}
					array[32] = 2;
					array[33] = 24194;
					array[34] = 24204;
					this.user_k_block_n_data_write(array2, 14, array, 30, array[1]);
				}
				if (this.user_k_block_n_data_check_previous(array2, 15))
				{
					if (num4 == 1)
					{
						array[35] = 23;
						array[36] = 255;
					}
					else if (num4 == 2)
					{
						array[35] = 1;
						array[36] = 0;
					}
					else if (num4 == 3)
					{
						array[35] = 3;
						array[36] = 0;
					}
					else
					{
						array[35] = 7;
						array[36] = 0;
					}
					array[37] = 2;
					array[38] = 24166;
					array[39] = 24170;
					this.user_k_block_n_data_write(array2, 15, array, 35, array[1]);
				}
				if (this.user_k_block_n_data_check_previous(array2, 16))
				{
					array[40] = 1;
					array[41] = 0;
					array[42] = 2;
					array[43] = 24123;
					array[44] = 24124;
					this.user_k_block_n_data_write(array2, 16, array, 40, array[1]);
				}
				this.user_k_block_n_data_read(array2, 14, array, 30, array[1]);
				this.user_k_block_n_data_read(array2, 15, array, 35, array[1]);
				this.user_k_block_n_data_read(array2, 16, array, 40, array[1]);
				this.user_k_block_n_data_read(array2, 9, array, 45, array[1]);
				this.user_k_block_n_data_read(array2, 10, array, 50, array[1]);
				this.user_k_block_n_data_read(array2, 11, array, 55, array[1]);
				this.user_k_block_n_data_read(array2, 12, array, 60, array[1]);
				this.user_k_block_n_data_read(array2, 13, array, 65, array[1]);
				array[131] = (int)nvData[256];
				return array;
			}

			// Token: 0x06000323 RID: 803 RVA: 0x0004C6D0 File Offset: 0x0004A8D0
			public byte[] GetNVDataFromUserSetting(int[] userSettingR8W, byte[] receivedNVData)
			{
				if (this.menuCnt == 0)
				{
					return null;
				}
				byte[][] array = new byte[18][];
				byte[] array2 = new byte[receivedNVData.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = new byte[4];
					for (int j = 0; j < 4; j++)
					{
						array[i][j] = 0;
					}
				}
				byte[] array3 = array[2];
				int num = 3;
				array3[num] |= (byte)(userSettingR8W[71] << 5 & (int)BinaryDefine.b01100000);
				byte[] array4 = array[2];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR8W[86] << 2 & (int)BinaryDefine.b00011100);
				byte[] array5 = array[2];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR8W[85] << 1 & (int)BinaryDefine.b00000010);
				byte[] array6 = array[2];
				int num4 = 3;
				array6[num4] |= (byte)(userSettingR8W[29] & (int)BinaryDefine.b00000001);
				byte[] array7 = array[2];
				int num5 = 2;
				array7[num5] |= (byte)(userSettingR8W[28] << 7 & (int)BinaryDefine.b10000000);
				byte[] array8 = array[2];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR8W[16] << 6 & (int)BinaryDefine.b01000000);
				byte[] array9 = array[2];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR8W[18] << 5 & (int)BinaryDefine.b00100000);
				byte[] array10 = array[2];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR8W[19] << 4 & (int)BinaryDefine.b00010000);
				byte[] array11 = array[2];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR8W[20] << 3 & (int)BinaryDefine.b00001000);
				byte[] array12 = array[2];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR8W[21] << 2 & (int)BinaryDefine.b00000100);
				byte[] array13 = array[2];
				int num11 = 2;
				array13[num11] |= (byte)(userSettingR8W[26] << 1 & (int)BinaryDefine.b00000010);
				byte[] array14 = array[2];
				int num12 = 1;
				array14[num12] |= (byte)(userSettingR8W[10] << 7 & (int)BinaryDefine.b10000000);
				if (userSettingR8W[111] == 0)
				{
					byte[] array15 = array[2];
					int num13 = 1;
					// DECOMPILE-FIX: Restore byte narrowing for the exported bit-mask operations
					// in this file; unchecked casts preserve the original IL byte stores.
					array15[num13] |= unchecked((byte)(0 & BinaryDefine.b00001000));
				}
				else
				{
					byte[] array16 = array[2];
					int num14 = 1;
					array16[num14] |= unchecked((byte)(8 & BinaryDefine.b00001000));
				}
				byte[] array17 = array[2];
				int num15 = 1;
				array17[num15] |= (byte)(userSettingR8W[121] << 2 & (int)BinaryDefine.b00000100);
				byte[] array18 = array[2];
				int num16 = 1;
				array18[num16] |= (byte)(userSettingR8W[128] << 1 & (int)BinaryDefine.b00000010);
				byte[] array19 = array[2];
				int num17 = 1;
				array19[num17] |= (byte)(userSettingR8W[130] & (int)BinaryDefine.b00000001);
				byte[] array20 = array[2];
				int num18 = 0;
				array20[num18] |= (byte)(userSettingR8W[132] << 4 & (int)BinaryDefine.b01110000);
				byte[] array21 = array[2];
				int num19 = 0;
				array21[num19] |= (byte)(userSettingR8W[133] & (int)BinaryDefine.b00001111);
				byte b;
				if (userSettingR8W[101] == 1)
				{
					b = (byte)(userSettingR8W[122] / 5);
				}
				else
				{
					b = (byte)(userSettingR8W[122] / 10);
				}
				byte[] array22 = array[1];
				int num20 = 2;
				array22[num20] |= (byte)(userSettingR8W[101] << 7 & (int)BinaryDefine.b10000000);
				byte[] array23 = array[1];
				int num21 = 2;
				array23[num21] |= (byte)(userSettingR8W[127] << 5 & (int)BinaryDefine.b00100000);
				byte[] array24 = array[1];
				int num22 = 2;
				array24[num22] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR8W[101] == 1)
				{
					b = (byte)(userSettingR8W[14] / 5);
				}
				else
				{
					b = (byte)(userSettingR8W[14] / 10);
				}
				byte[] array25 = array[1];
				int num23 = 3;
				array25[num23] |= (byte)(userSettingR8W[129] << 6 & (int)BinaryDefine.b01000000);
				byte[] array26 = array[1];
				int num24 = 3;
				array26[num24] |= (byte)(userSettingR8W[23] << 5 & (int)BinaryDefine.b00100000);
				byte[] array27 = array[1];
				int num25 = 3;
				array27[num25] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR8W[101] == 1)
				{
					b = (byte)(userSettingR8W[125] / 5);
				}
				else
				{
					b = (byte)(userSettingR8W[125] / 10);
				}
				byte[] array28 = array[1];
				int num26 = 1;
				array28[num26] |= (byte)(userSettingR8W[11] << 6 & (int)BinaryDefine.b01000000);
				byte[] array29 = array[1];
				int num27 = 1;
				array29[num27] |= (byte)(userSettingR8W[13] << 5 & (int)BinaryDefine.b00100000);
				byte[] array30 = array[1];
				int num28 = 1;
				array30[num28] |= unchecked((byte)(b & BinaryDefine.b00011111));
				b = (byte)(userSettingR8W[126] + 12);
				byte[] array31 = array[1];
				int num29 = 0;
				array31[num29] |= (byte)(userSettingR8W[99] << 5 & (int)BinaryDefine.b11100000);
				byte[] array32 = array[1];
				int num30 = 0;
				array32[num30] |= unchecked((byte)(b & BinaryDefine.b00011111));
				byte[] array33 = array[3];
				int num31 = 3;
				array33[num31] |= (byte)(userSettingR8W[82] << 6 & (int)BinaryDefine.b01000000);
				byte[] array34 = array[3];
				int num32 = 3;
				array34[num32] |= (byte)(userSettingR8W[17] << 5 & (int)BinaryDefine.b00100000);
				byte[] array35 = array[3];
				int num33 = 3;
				array35[num33] |= (byte)(userSettingR8W[81] << 3 & (int)BinaryDefine.b00011000);
				byte[] array36 = array[3];
				int num34 = 3;
				array36[num34] |= (byte)(userSettingR8W[112] & (int)BinaryDefine.b00000111);
				byte[] array37 = array[3];
				int num35 = 2;
				array37[num35] |= (byte)(userSettingR8W[24] << 7 & (int)BinaryDefine.b10000000);
				byte[] array38 = array[3];
				int num36 = 2;
				array38[num36] |= (byte)(userSettingR8W[2] << 3 & (int)BinaryDefine.b00111000);
				byte[] array39 = array[3];
				int num37 = 2;
				array39[num37] |= (byte)(userSettingR8W[3] & (int)BinaryDefine.b00000111);
				byte[] array40 = array[3];
				int num38 = 1;
				array40[num38] |= (byte)(userSettingR8W[80] << 3 & (int)BinaryDefine.b00001000);
				byte[] array41 = array[3];
				int num39 = 1;
				array41[num39] |= (byte)(userSettingR8W[4] & (int)BinaryDefine.b00000111);
				byte[] array42 = array[3];
				int num40 = 0;
				array42[num40] |= (byte)(userSettingR8W[79] << 7 & (int)BinaryDefine.b10000000);
				byte[] array43 = array[3];
				int num41 = 0;
				array43[num41] |= (byte)(userSettingR8W[78] << 6 & (int)BinaryDefine.b01000000);
				byte[] array44 = array[3];
				int num42 = 0;
				array44[num42] |= (byte)(userSettingR8W[77] << 5 & (int)BinaryDefine.b00100000);
				byte[] array45 = array[3];
				int num43 = 0;
				array45[num43] |= (byte)(userSettingR8W[76] << 4 & (int)BinaryDefine.b00010000);
				byte[] array46 = array[3];
				int num44 = 0;
				array46[num44] |= (byte)(userSettingR8W[75] << 3 & (int)BinaryDefine.b00001000);
				byte[] array47 = array[3];
				int num45 = 0;
				array47[num45] |= (byte)(userSettingR8W[74] << 2 & (int)BinaryDefine.b00000100);
				byte[] array48 = array[3];
				int num46 = 0;
				array48[num46] |= (byte)(userSettingR8W[73] << 1 & (int)BinaryDefine.b00000010);
				byte[] array49 = array[3];
				int num47 = 0;
				array49[num47] |= (byte)(userSettingR8W[72] & (int)BinaryDefine.b00000001);
				byte[] array50 = array[4];
				int num48 = 3;
				array50[num48] |= (byte)(userSettingR8W[116] << 6 & (int)BinaryDefine.b01000000);
				byte[] array51 = array[4];
				int num49 = 3;
				array51[num49] |= (byte)(userSettingR8W[118] << 3 & (int)BinaryDefine.b00111000);
				byte[] array52 = array[4];
				int num50 = 3;
				array52[num50] |= (byte)(userSettingR8W[120] & (int)BinaryDefine.b00000111);
				byte[] array53 = array[4];
				int num51 = 2;
				array53[num51] |= (byte)(userSettingR8W[102] << 4 & (int)BinaryDefine.b11110000);
				byte[] array54 = array[4];
				int num52 = 2;
				array54[num52] |= (byte)(userSettingR8W[103] & (int)BinaryDefine.b00001111);
				byte[] array55 = array[4];
				int num53 = 1;
				array55[num53] |= (byte)(userSettingR8W[110] << 4 & (int)BinaryDefine.b11110000);
				byte[] array56 = array[4];
				int num54 = 1;
				array56[num54] |= (byte)(userSettingR8W[108] & (int)BinaryDefine.b00001111);
				byte[] array57 = array[5];
				int num55 = 3;
				array57[num55] |= (byte)(userSettingR8W[109] << 4 & (int)BinaryDefine.b01110000);
				byte[] array58 = array[5];
				int num56 = 3;
				array58[num56] |= (byte)(userSettingR8W[106] & (int)BinaryDefine.b00001111);
				byte[] array59 = array[5];
				int num57 = 2;
				array59[num57] |= (byte)(userSettingR8W[70] << 6 & (int)BinaryDefine.b11000000);
				byte[] array60 = array[5];
				int num58 = 2;
				array60[num58] |= (byte)(userSettingR8W[83] << 5 & (int)BinaryDefine.b00100000);
				byte[] array61 = array[5];
				int num59 = 2;
				array61[num59] |= (byte)(userSettingR8W[115] & (int)BinaryDefine.b00000111);
				byte[] array62 = array[5];
				int num60 = 1;
				array62[num60] |= (byte)(userSettingR8W[84] << 7 & (int)BinaryDefine.b10000000);
				byte[] array63 = array[5];
				int num61 = 1;
				array63[num61] |= (byte)(userSettingR8W[88] << 3 & (int)BinaryDefine.b00111000);
				byte[] array64 = array[5];
				int num62 = 1;
				array64[num62] |= (byte)(userSettingR8W[87] & (int)BinaryDefine.b00000111);
				byte[] array65 = array[5];
				int num63 = 0;
				array65[num63] |= (byte)(userSettingR8W[0] << 7 & (int)BinaryDefine.b10000000);
				byte[] array66 = array[5];
				int num64 = 0;
				array66[num64] |= (byte)(userSettingR8W[123] << 6 & (int)BinaryDefine.b01000000);
				byte[] array67 = array[5];
				int num65 = 0;
				array67[num65] |= (byte)(userSettingR8W[91] << 3 & (int)BinaryDefine.b00111000);
				byte[] array68 = array[5];
				int num66 = 0;
				array68[num66] |= (byte)(userSettingR8W[89] & (int)BinaryDefine.b00000111);
				byte[] array69 = array[6];
				int num67 = 3;
				array69[num67] |= (byte)(userSettingR8W[93] << 4 & (int)BinaryDefine.b11110000);
				byte[] array70 = array[6];
				int num68 = 3;
				array70[num68] |= (byte)(userSettingR8W[92] & (int)BinaryDefine.b00001111);
				byte[] array71 = array[6];
				int num69 = 2;
				array71[num69] |= (byte)(userSettingR8W[96] << 4 & (int)BinaryDefine.b11110000);
				byte[] array72 = array[6];
				int num70 = 2;
				array72[num70] |= (byte)(userSettingR8W[94] & (int)BinaryDefine.b00001111);
				byte[] array73 = array[6];
				int num71 = 1;
				array73[num71] |= (byte)(userSettingR8W[9] << 7 & (int)BinaryDefine.b10000000);
				byte[] array74 = array[6];
				int num72 = 1;
				array74[num72] |= (byte)(userSettingR8W[27] << 5 & (int)BinaryDefine.b01100000);
				byte[] array75 = array[6];
				int num73 = 1;
				array75[num73] |= (byte)(userSettingR8W[98] << 4 & (int)BinaryDefine.b00010000);
				byte[] array76 = array[6];
				int num74 = 1;
				array76[num74] |= (byte)(userSettingR8W[6] & (int)BinaryDefine.b00001111);
				byte[] array77 = array[6];
				int num75 = 0;
				array77[num75] |= (byte)(userSettingR8W[12] << 5 & (int)BinaryDefine.b11100000);
				byte[] array78 = array[6];
				int num76 = 0;
				array78[num76] |= (byte)(userSettingR8W[124] << 1 & (int)BinaryDefine.b00011110);
				byte[] array79 = array[6];
				int num77 = 0;
				array79[num77] |= (byte)(userSettingR8W[114] & (int)BinaryDefine.b00000001);
				byte[] array80 = array[7];
				int num78 = 3;
				array80[num78] |= (byte)(userSettingR8W[119] << 4 & (int)BinaryDefine.b11110000);
				byte[] array81 = array[7];
				int num79 = 3;
				array81[num79] |= (byte)(userSettingR8W[117] & (int)BinaryDefine.b00001111);
				if (userSettingR8W[101] == 1)
				{
					b = (byte)(userSettingR8W[5] / 5);
				}
				else
				{
					b = (byte)(userSettingR8W[5] / 10);
				}
				byte[] array82 = array[7];
				int num80 = 2;
				array82[num80] |= (byte)((int)b << 4 & (int)BinaryDefine.b11110000);
				byte[] array83 = array[7];
				int num81 = 2;
				array83[num81] |= (byte)(userSettingR8W[100] << 2 & (int)BinaryDefine.b00001100);
				byte[] array84 = array[7];
				int num82 = 2;
				array84[num82] |= (byte)(userSettingR8W[1] & (int)BinaryDefine.b00000011);
				byte[] array85 = array[7];
				int num83 = 1;
				array85[num83] |= (byte)(userSettingR8W[107] << 4 & (int)BinaryDefine.b11110000);
				byte[] array86 = array[7];
				int num84 = 1;
				array86[num84] |= (byte)(userSettingR8W[15] << 3 & (int)BinaryDefine.b00001000);
				byte[] array87 = array[7];
				int num85 = 1;
				array87[num85] |= (byte)(userSettingR8W[25] & (int)BinaryDefine.b00000001);
				byte[] array88 = array[7];
				int num86 = 0;
				array88[num86] |= (byte)(userSettingR8W[90] << 4 & (int)BinaryDefine.b01110000);
				byte[] array89 = array[7];
				int num87 = 0;
				array89[num87] |= (byte)(userSettingR8W[95] & (int)BinaryDefine.b00001111);
				byte[] array90 = array[8];
				int num88 = 3;
				array90[num88] |= (byte)(userSettingR8W[113] << 6 & (int)BinaryDefine.b01000000);
				byte[] array91 = array[8];
				int num89 = 3;
				array91[num89] |= (byte)(userSettingR8W[97] << 3 & (int)BinaryDefine.b00011000);
				byte[] array92 = array[8];
				int num90 = 3;
				array92[num90] |= (byte)(userSettingR8W[104] & (int)BinaryDefine.b00000111);
				byte[] array93 = array[8];
				int num91 = 2;
				array93[num91] |= (byte)(userSettingR8W[22] & (int)BinaryDefine.b00000001);
				byte[] array94 = array[8];
				int num92 = 0;
				array94[num92] |= (byte)(userSettingR8W[111] << 4 & (int)BinaryDefine.b11110000);
				byte[] array95 = array[8];
				int num93 = 0;
				array95[num93] |= (byte)(userSettingR8W[105] & (int)BinaryDefine.b00001111);
				byte[] array96 = array[17];
				int num94 = 3;
				array96[num94] |= (byte)(userSettingR8W[7] << 4 & (int)BinaryDefine.b11110000);
				byte[] array97 = array[17];
				int num95 = 3;
				array97[num95] |= (byte)(userSettingR8W[8] & (int)BinaryDefine.b00001111);
				this.user_k_block_n_data_write(array, 9, userSettingR8W, 45, userSettingR8W[1]);
				this.user_k_block_n_data_write(array, 10, userSettingR8W, 50, userSettingR8W[1]);
				this.user_k_block_n_data_write(array, 11, userSettingR8W, 55, userSettingR8W[1]);
				this.user_k_block_n_data_write(array, 12, userSettingR8W, 60, userSettingR8W[1]);
				this.user_k_block_n_data_write(array, 13, userSettingR8W, 65, userSettingR8W[1]);
				this.user_k_block_n_data_write(array, 14, userSettingR8W, 30, userSettingR8W[1]);
				this.user_k_block_n_data_write(array, 15, userSettingR8W, 35, userSettingR8W[1]);
				this.user_k_block_n_data_write(array, 16, userSettingR8W, 40, userSettingR8W[1]);
				Array.Copy(receivedNVData, array2, receivedNVData.Length);
				for (int i = 0; i < array.Length; i++)
				{
					for (int j = 0; j < array[i].Length; j++)
					{
						byte[] array98 = array2;
						int num96 = i * 4 + j;
						array98[num96] &= unchecked((byte)(~this.userNVDataPos[i * 4 + j]));
						byte[] array99 = array2;
						int num97 = i * 4 + j;
						array99[num97] |= array[i][j];
					}
				}
				array2[256] = (byte)userSettingR8W[131];
				int num98 = 0;
				for (int i = 0; i < receivedNVData.Length; i++)
				{
					if (receivedNVData[i] != array2[i])
					{
						num98++;
					}
				}
				return array2;
			}

			// Token: 0x0400063B RID: 1595
			private int supportVersion = 127;

			// Token: 0x0400063C RID: 1596
			private int menuCnt = 134;

			// Token: 0x0400063D RID: 1597
			private byte[] userNVDataPos = new byte[]
			{
				0,
				0,
				0,
				0,
				byte.MaxValue,
				127,
				191,
				127,
				127,
				143,
				254,
				127,
				byte.MaxValue,
				15,
				191,
				127,
				0,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				191,
				231,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				249,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				0,
				1,
				95,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				0,
				0,
				0,
				byte.MaxValue,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0
			};

			// Token: 0x0400063E RID: 1598
			private const int memoryQuotaPos = 256;

			// Token: 0x0400063F RID: 1599
			private const int HEADER = 0;

			// Token: 0x04000640 RID: 1600
			private const int GPS = 1;

			// Token: 0x04000641 RID: 1601
			private const int RD_1 = 2;

			// Token: 0x04000642 RID: 1602
			private const int RD_2 = 3;

			// Token: 0x04000643 RID: 1603
			private const int RD_3 = 4;

			// Token: 0x04000644 RID: 1604
			private const int RD_4 = 5;

			// Token: 0x04000645 RID: 1605
			private const int RD_5 = 6;

			// Token: 0x04000646 RID: 1606
			private const int RD_6 = 7;

			// Token: 0x04000647 RID: 1607
			private const int RD_7 = 8;

			// Token: 0x04000648 RID: 1608
			private const int USR_K_BLK1 = 9;

			// Token: 0x04000649 RID: 1609
			private const int USR_K_BLK2 = 10;

			// Token: 0x0400064A RID: 1610
			private const int USR_K_BLK3 = 11;

			// Token: 0x0400064B RID: 1611
			private const int USR_K_BLK4 = 12;

			// Token: 0x0400064C RID: 1612
			private const int USR_K_BLK5 = 13;

			// Token: 0x0400064D RID: 1613
			private const int CONST_K_BLK1 = 14;

			// Token: 0x0400064E RID: 1614
			private const int CONST_K_BLK2 = 15;

			// Token: 0x0400064F RID: 1615
			private const int CONST_K_BLK3 = 16;

			// Token: 0x04000650 RID: 1616
			private const int RD_8 = 17;

			// Token: 0x04000651 RID: 1617
			private const int ADDR_CNT = 18;

			// Token: 0x04000652 RID: 1618
			private const int RF_PWR_STRENGTH_LEVEL1 = 57;

			// Token: 0x04000653 RID: 1619
			private const int RF_PWR_STRENGTH_LEVEL2 = 71;

			// Token: 0x04000654 RID: 1620
			private const int RF_PWR_STRENGTH_LEVEL3 = 84;

			// Token: 0x04000655 RID: 1621
			private const int RF_PWR_STRENGTH_LEVEL4 = 99;

			// Token: 0x04000656 RID: 1622
			private const int RF_PWR_STRENGTH_LEVEL5 = 111;

			// Token: 0x04000657 RID: 1623
			private const int RF_PWR_STRENGTH_LEVEL6 = 123;

			// Token: 0x04000658 RID: 1624
			private const int RF_PWR_STRENGTH_LEVEL7 = 136;

			// Token: 0x04000659 RID: 1625
			private const int RF_PWR_STRENGTH_LEVEL0P5 = 50;

			// Token: 0x0400065A RID: 1626
			private const int RF_PWR_STRENGTH_LEVEL1P5 = 64;

			// Token: 0x0400065B RID: 1627
			private const int RF_PWR_STRENGTH_LEVEL2P5 = 77;

			// Token: 0x0400065C RID: 1628
			private const int RF_PWR_STRENGTH_LEVEL3P5 = 91;

			// Token: 0x0400065D RID: 1629
			private const int RF_PWR_STRENGTH_LEVEL4P5 = 105;

			// Token: 0x0400065E RID: 1630
			private const int RF_PWR_STRENGTH_LEVEL5P5 = 117;

			// Token: 0x0400065F RID: 1631
			private const int RF_PWR_STRENGTH_LEVEL6P5 = 129;

			// Token: 0x04000660 RID: 1632
			private const int RF_PWR_STRENGTH_LEVEL7P5 = 142;

			// Token: 0x04000661 RID: 1633
			private const int RF_PWR_STRENGTH_LEVEL1_CITY = 99;

			// Token: 0x04000662 RID: 1634
			private const int RF_PWR_STRENGTH_LEVEL2_CITY = 105;

			// Token: 0x04000663 RID: 1635
			private const int RF_PWR_STRENGTH_LEVEL3_CITY = 111;

			// Token: 0x04000664 RID: 1636
			private const int RF_PWR_STRENGTH_LEVEL4_CITY = 116;

			// Token: 0x04000665 RID: 1637
			private const int RF_PWR_STRENGTH_LEVEL5_CITY = 123;

			// Token: 0x04000666 RID: 1638
			private const int RF_PWR_STRENGTH_LEVEL6_CITY = 128;

			// Token: 0x04000667 RID: 1639
			private const int RF_PWR_STRENGTH_LEVEL7_CITY = 136;

			// Token: 0x04000668 RID: 1640
			private const int RF_PWR_STRENGTH_LEVEL0P5_CITY = 96;

			// Token: 0x04000669 RID: 1641
			private const int RF_PWR_STRENGTH_LEVEL1P5_CITY = 102;

			// Token: 0x0400066A RID: 1642
			private const int RF_PWR_STRENGTH_LEVEL2P5_CITY = 108;

			// Token: 0x0400066B RID: 1643
			private const int RF_PWR_STRENGTH_LEVEL3P5_CITY = 113;

			// Token: 0x0400066C RID: 1644
			private const int RF_PWR_STRENGTH_LEVEL4P5_CITY = 119;

			// Token: 0x0400066D RID: 1645
			private const int RF_PWR_STRENGTH_LEVEL5P5_CITY = 125;

			// Token: 0x0400066E RID: 1646
			private const int RF_PWR_STRENGTH_LEVEL6P5_CITY = 132;

			// Token: 0x0400066F RID: 1647
			private const int RF_PWR_STRENGTH_LEVEL7P5_CITY = 140;

			// Token: 0x04000670 RID: 1648
			private const int K_BLOCK_FILTER_LEVEL_0P5 = 8;

			// Token: 0x04000671 RID: 1649
			private const int K_BLOCK_FILTER_LEVEL_1P0 = 9;

			// Token: 0x04000672 RID: 1650
			private const int K_BLOCK_FILTER_LEVEL_1P5 = 10;

			// Token: 0x04000673 RID: 1651
			private const int K_BLOCK_FILTER_LEVEL_2P0 = 11;

			// Token: 0x04000674 RID: 1652
			private const int K_BLOCK_FILTER_LEVEL_2P5 = 12;

			// Token: 0x04000675 RID: 1653
			private const int K_BLOCK_FILTER_LEVEL_3P0 = 13;

			// Token: 0x04000676 RID: 1654
			private const int K_BLOCK_FILTER_LEVEL_3P5 = 14;

			// Token: 0x04000677 RID: 1655
			private const int K_BLOCK_FILTER_LEVEL_4P0 = 15;

			// Token: 0x04000678 RID: 1656
			private const int K_BLOCK_FILTER_LEVEL_4P5 = 16;

			// Token: 0x04000679 RID: 1657
			private const int K_BLOCK_FILTER_LEVEL_5P0 = 17;

			// Token: 0x0400067A RID: 1658
			private const int K_BLOCK_FILTER_LEVEL_5P5 = 18;

			// Token: 0x0400067B RID: 1659
			private const int K_BLOCK_FILTER_LEVEL_6P0 = 19;

			// Token: 0x0400067C RID: 1660
			private const int K_BLOCK_FILTER_LEVEL_6P5 = 20;

			// Token: 0x0400067D RID: 1661
			private const int K_BLOCK_FILTER_LEVEL_7P0 = 21;

			// Token: 0x0400067E RID: 1662
			private const int K_BLOCK_FILTER_LEVEL_7P5 = 22;

			// Token: 0x0400067F RID: 1663
			private const int K_BLOCK_FILTER_LEVEL_8P0 = 23;

			// Token: 0x020000BC RID: 188
			private enum MENU
			{
				// Token: 0x04000AC6 RID: 2758
				MENU_MODE,
				// Token: 0x04000AC7 RID: 2759
				DETECTION_MODE,
				// Token: 0x04000AC8 RID: 2760
				X_SENSITIVE,
				// Token: 0x04000AC9 RID: 2761
				K_SENSITIVE,
				// Token: 0x04000ACA RID: 2762
				KA_SENSITIVE,
				// Token: 0x04000ACB RID: 2763
				AUTO_CITY_SPEED,
				// Token: 0x04000ACC RID: 2764
				REAR_K_ATTENUATION,
				// Token: 0x04000ACD RID: 2765
				REAR_KA_ATTENUATION,
				// Token: 0x04000ACE RID: 2766
				REAR_X_ATTENUATION,
				// Token: 0x04000ACF RID: 2767
				BLUETOOTH_MODE,
				// Token: 0x04000AD0 RID: 2768
				GPS_ENABLE,
				// Token: 0x04000AD1 RID: 2769
				SPEED_CAMERA_ENABLE,
				// Token: 0x04000AD2 RID: 2770
				SPEED_CAMERA_ALERT_RANGE,
				// Token: 0x04000AD3 RID: 2771
				RLC_ENABLE,
				// Token: 0x04000AD4 RID: 2772
				RLC_QRIDE,
				// Token: 0x04000AD5 RID: 2773
				POI_PASSCHIME,
				// Token: 0x04000AD6 RID: 2774
				VOICE_ENABLE,
				// Token: 0x04000AD7 RID: 2775
				KA_FREQ_VOICE,
				// Token: 0x04000AD8 RID: 2776
				X_BAND_ENABLE,
				// Token: 0x04000AD9 RID: 2777
				K_BAND_ENABLE,
				// Token: 0x04000ADA RID: 2778
				KA_BAND_ENABLE,
				// Token: 0x04000ADB RID: 2779
				LASER_ENABLE,
				// Token: 0x04000ADC RID: 2780
				LASER_GUN_ID_ENABLE,
				// Token: 0x04000ADD RID: 2781
				K_POP_ENABLE,
				// Token: 0x04000ADE RID: 2782
				MRCD_ENABLE,
				// Token: 0x04000ADF RID: 2783
				GATSO_ENABLE,
				// Token: 0x04000AE0 RID: 2784
				KA_POP_ENABLE,
				// Token: 0x04000AE1 RID: 2785
				K_FILTER_ENABLE,
				// Token: 0x04000AE2 RID: 2786
				KA_FILTER_ENABLE,
				// Token: 0x04000AE3 RID: 2787
				TSF_ENABLE,
				// Token: 0x04000AE4 RID: 2788
				K_BLOCK_FILTER_1_OP_MODE,
				// Token: 0x04000AE5 RID: 2789
				K_BLOCK_FILTER_1_RAW_STRENGTH,
				// Token: 0x04000AE6 RID: 2790
				K_BLOCK_FILTER_1_DIR,
				// Token: 0x04000AE7 RID: 2791
				K_BLOCK_FILTER_1_MIN_FREQ,
				// Token: 0x04000AE8 RID: 2792
				K_BLOCK_FILTER_1_MAX_FREQ,
				// Token: 0x04000AE9 RID: 2793
				K_BLOCK_FILTER_2_OP_MODE,
				// Token: 0x04000AEA RID: 2794
				K_BLOCK_FILTER_2_RAW_STRENGTH,
				// Token: 0x04000AEB RID: 2795
				K_BLOCK_FILTER_2_DIR,
				// Token: 0x04000AEC RID: 2796
				K_BLOCK_FILTER_2_MIN_FREQ,
				// Token: 0x04000AED RID: 2797
				K_BLOCK_FILTER_2_MAX_FREQ,
				// Token: 0x04000AEE RID: 2798
				K_BLOCK_FILTER_3_OP_MODE,
				// Token: 0x04000AEF RID: 2799
				K_BLOCK_FILTER_3_RAW_STRENGTH,
				// Token: 0x04000AF0 RID: 2800
				K_BLOCK_FILTER_3_DIR,
				// Token: 0x04000AF1 RID: 2801
				K_BLOCK_FILTER_3_MIN_FREQ,
				// Token: 0x04000AF2 RID: 2802
				K_BLOCK_FILTER_3_MAX_FREQ,
				// Token: 0x04000AF3 RID: 2803
				USER_K_BLOCK_FILTER_1_OP_MODE,
				// Token: 0x04000AF4 RID: 2804
				USER_K_BLOCK_FILTER_1_RAW_STRENGTH,
				// Token: 0x04000AF5 RID: 2805
				USER_K_BLOCK_FILTER_1_DIR,
				// Token: 0x04000AF6 RID: 2806
				USER_K_BLOCK_FILTER_1_MIN_FREQ,
				// Token: 0x04000AF7 RID: 2807
				USER_K_BLOCK_FILTER_1_MAX_FREQ,
				// Token: 0x04000AF8 RID: 2808
				USER_K_BLOCK_FILTER_2_OP_MODE,
				// Token: 0x04000AF9 RID: 2809
				USER_K_BLOCK_FILTER_2_RAW_STRENGTH,
				// Token: 0x04000AFA RID: 2810
				USER_K_BLOCK_FILTER_2_DIR,
				// Token: 0x04000AFB RID: 2811
				USER_K_BLOCK_FILTER_2_MIN_FREQ,
				// Token: 0x04000AFC RID: 2812
				USER_K_BLOCK_FILTER_2_MAX_FREQ,
				// Token: 0x04000AFD RID: 2813
				USER_K_BLOCK_FILTER_3_OP_MODE,
				// Token: 0x04000AFE RID: 2814
				USER_K_BLOCK_FILTER_3_RAW_STRENGTH,
				// Token: 0x04000AFF RID: 2815
				USER_K_BLOCK_FILTER_3_DIR,
				// Token: 0x04000B00 RID: 2816
				USER_K_BLOCK_FILTER_3_MIN_FREQ,
				// Token: 0x04000B01 RID: 2817
				USER_K_BLOCK_FILTER_3_MAX_FREQ,
				// Token: 0x04000B02 RID: 2818
				USER_K_BLOCK_FILTER_4_OP_MODE,
				// Token: 0x04000B03 RID: 2819
				USER_K_BLOCK_FILTER_4_RAW_STRENGTH,
				// Token: 0x04000B04 RID: 2820
				USER_K_BLOCK_FILTER_4_DIR,
				// Token: 0x04000B05 RID: 2821
				USER_K_BLOCK_FILTER_4_MIN_FREQ,
				// Token: 0x04000B06 RID: 2822
				USER_K_BLOCK_FILTER_4_MAX_FREQ,
				// Token: 0x04000B07 RID: 2823
				USER_K_BLOCK_FILTER_5_OP_MODE,
				// Token: 0x04000B08 RID: 2824
				USER_K_BLOCK_FILTER_5_RAW_STRENGTH,
				// Token: 0x04000B09 RID: 2825
				USER_K_BLOCK_FILTER_5_DIR,
				// Token: 0x04000B0A RID: 2826
				USER_K_BLOCK_FILTER_5_MIN_FREQ,
				// Token: 0x04000B0B RID: 2827
				USER_K_BLOCK_FILTER_5_MAX_FREQ,
				// Token: 0x04000B0C RID: 2828
				K_NARROW,
				// Token: 0x04000B0D RID: 2829
				KA_NARROW,
				// Token: 0x04000B0E RID: 2830
				KA_SEG1,
				// Token: 0x04000B0F RID: 2831
				KA_SEG2,
				// Token: 0x04000B10 RID: 2832
				KA_SEG3,
				// Token: 0x04000B11 RID: 2833
				KA_SEG4,
				// Token: 0x04000B12 RID: 2834
				KA_SEG5,
				// Token: 0x04000B13 RID: 2835
				KA_SEG6,
				// Token: 0x04000B14 RID: 2836
				KA_SEG7,
				// Token: 0x04000B15 RID: 2837
				KA_SEG8,
				// Token: 0x04000B16 RID: 2838
				KA_SEG9,
				// Token: 0x04000B17 RID: 2839
				PRIORITY_MODE,
				// Token: 0x04000B18 RID: 2840
				MUTE_MEM_BAND_OPTION,
				// Token: 0x04000B19 RID: 2841
				AUTO_MUTE_MEM_ENABLE,
				// Token: 0x04000B1A RID: 2842
				AUTO_MUTE_MEM_BAND_OPTION,
				// Token: 0x04000B1B RID: 2843
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x04000B1C RID: 2844
				BACKGROUND_COLOR,
				// Token: 0x04000B1D RID: 2845
				X_BAND_ARROW_COLOR,
				// Token: 0x04000B1E RID: 2846
				K_BAND_ARROW_COLOR,
				// Token: 0x04000B1F RID: 2847
				MRCD_ARROW_COLOR,
				// Token: 0x04000B20 RID: 2848
				GATSO_ARROW_COLOR,
				// Token: 0x04000B21 RID: 2849
				KA_BAND_ARROW_COLOR,
				// Token: 0x04000B22 RID: 2850
				X_BAND_COLOR,
				// Token: 0x04000B23 RID: 2851
				K_BAND_COLOR,
				// Token: 0x04000B24 RID: 2852
				MRCD_COLOR,
				// Token: 0x04000B25 RID: 2853
				GATSO_COLOR,
				// Token: 0x04000B26 RID: 2854
				KA_BAND_COLOR,
				// Token: 0x04000B27 RID: 2855
				MAIN_DISPLAY,
				// Token: 0x04000B28 RID: 2856
				HEARTBEAT_ICON_ENABLE,
				// Token: 0x04000B29 RID: 2857
				LEFT_DISPLAY,
				// Token: 0x04000B2A RID: 2858
				ALERT_DISPLAY,
				// Token: 0x04000B2B RID: 2859
				SPEED_UNIT,
				// Token: 0x04000B2C RID: 2860
				X_BAND_ALERT_TONE,
				// Token: 0x04000B2D RID: 2861
				K_BAND_ALERT_TONE,
				// Token: 0x04000B2E RID: 2862
				K_BAND_BOGEY_TONE,
				// Token: 0x04000B2F RID: 2863
				K_BAND_BOGEY_LEVEL,
				// Token: 0x04000B30 RID: 2864
				MRCD_ALERT_TONE,
				// Token: 0x04000B31 RID: 2865
				GATSO_ALERT_TONE,
				// Token: 0x04000B32 RID: 2866
				KA_BAND_ALERT_TONE,
				// Token: 0x04000B33 RID: 2867
				KA_BAND_BOGEY_TONE,
				// Token: 0x04000B34 RID: 2868
				LASER_ALERT_TONE,
				// Token: 0x04000B35 RID: 2869
				AUTO_MUTE_ALERT_LEVEL,
				// Token: 0x04000B36 RID: 2870
				AUTO_MUTE_VOLUME,
				// Token: 0x04000B37 RID: 2871
				ALERT_TEMPORARY_VOLUME,
				// Token: 0x04000B38 RID: 2872
				REAR_K_BAND_MUTE_ENABLE,
				// Token: 0x04000B39 RID: 2873
				DARK_MODE_BRIGHTNESS,
				// Token: 0x04000B3A RID: 2874
				AUTO_DIM_SET_MODE_SELECT,
				// Token: 0x04000B3B RID: 2875
				AUTO_DIM_SET_BRIGHT_TIME,
				// Token: 0x04000B3C RID: 2876
				AUTO_DIM_SET_BRIGHT_BRIGHTNESS,
				// Token: 0x04000B3D RID: 2877
				AUTO_DIM_SET_DIM_TIME,
				// Token: 0x04000B3E RID: 2878
				AUTO_DIM_SET_DIM_BRIGHTNESS,
				// Token: 0x04000B3F RID: 2879
				BACKLIGHT_MODE,
				// Token: 0x04000B40 RID: 2880
				QRIDE_MODE,
				// Token: 0x04000B41 RID: 2881
				MRCD_QRIDE_ENABLE,
				// Token: 0x04000B42 RID: 2882
				QRIDE_VOLUME,
				// Token: 0x04000B43 RID: 2883
				LIMIT_SPEED_MODE,
				// Token: 0x04000B44 RID: 2884
				GMT,
				// Token: 0x04000B45 RID: 2885
				DST_ENABLE,
				// Token: 0x04000B46 RID: 2886
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x04000B47 RID: 2887
				VEHICLE_BATT_SAVER_ENABLE,
				// Token: 0x04000B48 RID: 2888
				SELF_TEST_ENABLE,
				// Token: 0x04000B49 RID: 2889
				MEMORY_QUOTA,
				// Token: 0x04000B4A RID: 2890
				MAIN_DIM_SET,
				// Token: 0x04000B4B RID: 2891
				MAIN_VOLUME
			}
		}
	}
}
