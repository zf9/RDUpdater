using System;
using System.Linq;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200002D RID: 45
	internal static class UserSettingR8
	{
		// Token: 0x04000393 RID: 915
		public static UserSettingFormat[] user_setting = new UserSettingFormat[]
		{
			new UserSettingR8.v134(),
			new UserSettingR8.v127(),
			new UserSettingR8.v124()
		};

		// Token: 0x02000098 RID: 152
		private class v134 : UserSettingFormat
		{
			// Token: 0x0600032F RID: 815 RVA: 0x00050E33 File Offset: 0x0004F033
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x06000330 RID: 816 RVA: 0x00050E3B File Offset: 0x0004F03B
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x06000331 RID: 817 RVA: 0x00050E43 File Offset: 0x0004F043
			public byte[] GetNVDataMask()
			{
				return this.userNVDataPos;
			}

			// Token: 0x06000332 RID: 818 RVA: 0x000293C6 File Offset: 0x000275C6
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return op_mode != 1 && op_mode != 2 && op_mode != 3 && op_mode != 7;
			}

			// Token: 0x06000333 RID: 819 RVA: 0x00050E4C File Offset: 0x0004F04C
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

			// Token: 0x06000334 RID: 820 RVA: 0x00050F68 File Offset: 0x0004F168
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

			// Token: 0x06000335 RID: 821 RVA: 0x00051094 File Offset: 0x0004F294
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
				}, "Highway - Full Sensitivity\nCity - X and K sensitivity reduced. Ka band sensitivity same as Highway.\nAdvanced - User adjusts X, K, and Ka band sensitivity from 100%~30% in 10% intervals.\nAuto City - The R8 will automatically switch between Highway and City depending on the speed limits set in the Auto City Speed menu.");
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
				}, "Sets the speed at which the R8 changes from City mode to Highway mode and back.\n(Detection Mode - Auto City)");
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
				array[9] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Bluetooth", new int[]
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
				}, "The R8 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
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
				}, "The R8 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
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
				}, "Turns off power to the R8 if the speed stays at 0 or if the GPS is not connected for more than an hour.");
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

			// Token: 0x06000336 RID: 822 RVA: 0x00053E9C File Offset: 0x0005209C
			private bool user_k_block_n_data_check_previous(byte[][] userSettingData, int rd_addr)
			{
				int num = ((int)userSettingData[rd_addr][0] << 24) + ((int)userSettingData[rd_addr][1] << 16) + ((int)userSettingData[rd_addr][2] << 8) + (int)userSettingData[rd_addr][3];
				int num2 = (num & 261632) >> 9;
				int num3 = num & 511;
				return num2 == 511 && num3 == 511;
			}

			// Token: 0x06000337 RID: 823 RVA: 0x00053EF0 File Offset: 0x000520F0
			private static bool usr_mem_check_previous_verion_k_blk_format_paring_only_block3(byte[][] userSettingData, int rd_addr)
			{
				int num = ((int)userSettingData[rd_addr][0] << 24) + ((int)userSettingData[rd_addr][1] << 16) + ((int)userSettingData[rd_addr][2] << 8) + (int)userSettingData[rd_addr][3];
				int num2 = (num & 261632) >> 9;
				int num3 = num & 511;
				return (num2 == 511 && num3 == 511) || num == 402766560;
			}

			// Token: 0x06000338 RID: 824 RVA: 0x0002BBAB File Offset: 0x00029DAB
			private int user_k_block_n_data_raw_strength_read(byte[][] userSettingData, int rd_addr)
			{
				return (((int)userSettingData[rd_addr][3] << 24) + ((int)userSettingData[rd_addr][2] << 16) + ((int)userSettingData[rd_addr][1] << 8) + (int)userSettingData[rd_addr][0] & 66846720) >> 18;
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00053F4C File Offset: 0x0005214C
			private void user_k_block_n_data_read(byte[][] userSettingData, int rd_addr, int[] settingR8, int menu_op_mode_num, int mode)
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
					settingR8[menu_op_mode_num] = num7;
				}
				else
				{
					settingR8[menu_op_mode_num] = num2;
				}
				settingR8[menu_op_mode_num + 1] = num4;
				settingR8[menu_op_mode_num + 2] = num3;
				settingR8[menu_op_mode_num + 3] = num5 + 23900;
				settingR8[menu_op_mode_num + 4] = num6 + 23900;
			}

			// Token: 0x0600033A RID: 826 RVA: 0x00054010 File Offset: 0x00052210
			private void user_k_block_n_data_write(byte[][] userSettingData, int rd_addr, int[] settingR8, int menu_op_mode_num, int mode)
			{
				int num = 0;
				int num2 = settingR8[menu_op_mode_num];
				if (settingR8[menu_op_mode_num] > 7)
				{
					num2 = 0;
				}
				else
				{
					num2 = settingR8[menu_op_mode_num];
				}
				int num3 = settingR8[menu_op_mode_num + 1];
				int num4;
				if (settingR8[menu_op_mode_num + 2] == 3)
				{
					num4 = 2;
				}
				else
				{
					num4 = settingR8[menu_op_mode_num + 2];
				}
				int num5;
				if (settingR8[menu_op_mode_num + 3] != 511)
				{
					num5 = settingR8[menu_op_mode_num + 3] - 23900;
				}
				else
				{
					num5 = 511;
				}
				int num6;
				if (settingR8[menu_op_mode_num + 4] != 511)
				{
					num6 = settingR8[menu_op_mode_num + 4] - 23900;
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

			// Token: 0x0600033B RID: 827 RVA: 0x00054114 File Offset: 0x00052314
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
				array[105] = (int)(array2[8][0] & BinaryDefine.b00001111);
				if (array[105] > 8 || array[105] < 1)
				{
					array[105] = 4;
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
				if (UserSettingR8.v134.usr_mem_check_previous_verion_k_blk_format_paring_only_block3(array2, 16))
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
				array[111] = (array2[17][2] >> 1 & (int)BinaryDefine.b00001111);
				array[113] = (int)(array2[17][2] & BinaryDefine.b00000001);
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
				array[131] = (int)nvData[256];
				return array;
			}

			// Token: 0x0600033C RID: 828 RVA: 0x00054D8C File Offset: 0x00052F8C
			public byte[] GetNVDataFromUserSetting(int[] userSettingR8, byte[] receivedNVData)
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
				array3[num] |= (byte)(userSettingR8[71] << 5 & (int)BinaryDefine.b01100000);
				byte[] array4 = array[2];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR8[86] << 2 & (int)BinaryDefine.b00011100);
				byte[] array5 = array[2];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR8[85] << 1 & (int)BinaryDefine.b00000010);
				byte[] array6 = array[2];
				int num4 = 3;
				array6[num4] |= (byte)(userSettingR8[29] & (int)BinaryDefine.b00000001);
				byte[] array7 = array[2];
				int num5 = 2;
				array7[num5] |= (byte)(userSettingR8[28] << 7 & (int)BinaryDefine.b10000000);
				byte[] array8 = array[2];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR8[16] << 6 & (int)BinaryDefine.b01000000);
				byte[] array9 = array[2];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR8[18] << 5 & (int)BinaryDefine.b00100000);
				byte[] array10 = array[2];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR8[19] << 4 & (int)BinaryDefine.b00010000);
				byte[] array11 = array[2];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR8[20] << 3 & (int)BinaryDefine.b00001000);
				byte[] array12 = array[2];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR8[21] << 2 & (int)BinaryDefine.b00000100);
				byte[] array13 = array[2];
				int num11 = 2;
				array13[num11] |= (byte)(userSettingR8[26] << 1 & (int)BinaryDefine.b00000010);
				byte[] array14 = array[2];
				int num12 = 1;
				array14[num12] |= (byte)(userSettingR8[10] << 7 & (int)BinaryDefine.b10000000);
				if (userSettingR8[111] == 0)
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
				array17[num15] |= (byte)(userSettingR8[121] << 2 & (int)BinaryDefine.b00000100);
				byte[] array18 = array[2];
				int num16 = 1;
				array18[num16] |= (byte)(userSettingR8[128] << 1 & (int)BinaryDefine.b00000010);
				byte[] array19 = array[2];
				int num17 = 1;
				array19[num17] |= (byte)(userSettingR8[130] & (int)BinaryDefine.b00000001);
				byte[] array20 = array[2];
				int num18 = 0;
				array20[num18] |= (byte)(userSettingR8[132] << 4 & (int)BinaryDefine.b01110000);
				byte[] array21 = array[2];
				int num19 = 0;
				array21[num19] |= (byte)(userSettingR8[133] & (int)BinaryDefine.b00001111);
				byte b;
				if (userSettingR8[101] == 1)
				{
					b = (byte)(userSettingR8[122] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[122] / 10);
				}
				byte[] array22 = array[1];
				int num20 = 2;
				array22[num20] |= (byte)(userSettingR8[101] << 7 & (int)BinaryDefine.b10000000);
				byte[] array23 = array[1];
				int num21 = 2;
				array23[num21] |= (byte)(userSettingR8[127] << 5 & (int)BinaryDefine.b00100000);
				byte[] array24 = array[1];
				int num22 = 2;
				array24[num22] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR8[101] == 1)
				{
					b = (byte)(userSettingR8[14] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[14] / 10);
				}
				byte[] array25 = array[1];
				int num23 = 3;
				array25[num23] |= (byte)(userSettingR8[129] << 6 & (int)BinaryDefine.b01000000);
				byte[] array26 = array[1];
				int num24 = 3;
				array26[num24] |= (byte)(userSettingR8[23] << 5 & (int)BinaryDefine.b00100000);
				byte[] array27 = array[1];
				int num25 = 3;
				array27[num25] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR8[101] == 1)
				{
					b = (byte)(userSettingR8[125] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[125] / 10);
				}
				byte[] array28 = array[1];
				int num26 = 1;
				array28[num26] |= (byte)(userSettingR8[11] << 6 & (int)BinaryDefine.b01000000);
				byte[] array29 = array[1];
				int num27 = 1;
				array29[num27] |= (byte)(userSettingR8[13] << 5 & (int)BinaryDefine.b00100000);
				byte[] array30 = array[1];
				int num28 = 1;
				array30[num28] |= unchecked((byte)(b & BinaryDefine.b00011111));
				b = (byte)(userSettingR8[126] + 12);
				byte[] array31 = array[1];
				int num29 = 0;
				array31[num29] |= (byte)(userSettingR8[99] << 5 & (int)BinaryDefine.b11100000);
				byte[] array32 = array[1];
				int num30 = 0;
				array32[num30] |= unchecked((byte)(b & BinaryDefine.b00011111));
				byte[] array33 = array[3];
				int num31 = 3;
				array33[num31] |= (byte)(userSettingR8[82] << 6 & (int)BinaryDefine.b01000000);
				byte[] array34 = array[3];
				int num32 = 3;
				array34[num32] |= (byte)(userSettingR8[17] << 5 & (int)BinaryDefine.b00100000);
				byte[] array35 = array[3];
				int num33 = 3;
				array35[num33] |= (byte)(userSettingR8[81] << 3 & (int)BinaryDefine.b00011000);
				byte[] array36 = array[3];
				int num34 = 3;
				array36[num34] |= (byte)(userSettingR8[112] & (int)BinaryDefine.b00000111);
				byte[] array37 = array[3];
				int num35 = 2;
				array37[num35] |= (byte)(userSettingR8[24] << 7 & (int)BinaryDefine.b10000000);
				byte[] array38 = array[3];
				int num36 = 2;
				array38[num36] |= (byte)(userSettingR8[2] << 3 & (int)BinaryDefine.b00111000);
				byte[] array39 = array[3];
				int num37 = 2;
				array39[num37] |= (byte)(userSettingR8[3] & (int)BinaryDefine.b00000111);
				byte[] array40 = array[3];
				int num38 = 1;
				array40[num38] |= (byte)(userSettingR8[80] << 3 & (int)BinaryDefine.b00001000);
				byte[] array41 = array[3];
				int num39 = 1;
				array41[num39] |= (byte)(userSettingR8[4] & (int)BinaryDefine.b00000111);
				byte[] array42 = array[3];
				int num40 = 0;
				array42[num40] |= (byte)(userSettingR8[79] << 7 & (int)BinaryDefine.b10000000);
				byte[] array43 = array[3];
				int num41 = 0;
				array43[num41] |= (byte)(userSettingR8[78] << 6 & (int)BinaryDefine.b01000000);
				byte[] array44 = array[3];
				int num42 = 0;
				array44[num42] |= (byte)(userSettingR8[77] << 5 & (int)BinaryDefine.b00100000);
				byte[] array45 = array[3];
				int num43 = 0;
				array45[num43] |= (byte)(userSettingR8[76] << 4 & (int)BinaryDefine.b00010000);
				byte[] array46 = array[3];
				int num44 = 0;
				array46[num44] |= (byte)(userSettingR8[75] << 3 & (int)BinaryDefine.b00001000);
				byte[] array47 = array[3];
				int num45 = 0;
				array47[num45] |= (byte)(userSettingR8[74] << 2 & (int)BinaryDefine.b00000100);
				byte[] array48 = array[3];
				int num46 = 0;
				array48[num46] |= (byte)(userSettingR8[73] << 1 & (int)BinaryDefine.b00000010);
				byte[] array49 = array[3];
				int num47 = 0;
				array49[num47] |= (byte)(userSettingR8[72] & (int)BinaryDefine.b00000001);
				byte[] array50 = array[4];
				int num48 = 3;
				array50[num48] |= (byte)(userSettingR8[116] << 6 & (int)BinaryDefine.b01000000);
				byte[] array51 = array[4];
				int num49 = 3;
				array51[num49] |= (byte)(userSettingR8[118] << 3 & (int)BinaryDefine.b00111000);
				byte[] array52 = array[4];
				int num50 = 3;
				array52[num50] |= (byte)(userSettingR8[120] & (int)BinaryDefine.b00000111);
				byte[] array53 = array[4];
				int num51 = 2;
				array53[num51] |= (byte)(userSettingR8[102] << 4 & (int)BinaryDefine.b11110000);
				byte[] array54 = array[4];
				int num52 = 2;
				array54[num52] |= (byte)(userSettingR8[103] & (int)BinaryDefine.b00001111);
				byte[] array55 = array[4];
				int num53 = 1;
				array55[num53] |= (byte)(userSettingR8[110] << 4 & (int)BinaryDefine.b11110000);
				byte[] array56 = array[4];
				int num54 = 1;
				array56[num54] |= (byte)(userSettingR8[108] & (int)BinaryDefine.b00001111);
				byte[] array57 = array[5];
				int num55 = 3;
				array57[num55] |= (byte)(userSettingR8[109] << 4 & (int)BinaryDefine.b01110000);
				byte[] array58 = array[5];
				int num56 = 3;
				array58[num56] |= (byte)(userSettingR8[106] & (int)BinaryDefine.b00001111);
				byte[] array59 = array[5];
				int num57 = 2;
				array59[num57] |= (byte)(userSettingR8[70] << 6 & (int)BinaryDefine.b11000000);
				byte[] array60 = array[5];
				int num58 = 2;
				array60[num58] |= (byte)(userSettingR8[83] << 5 & (int)BinaryDefine.b00100000);
				byte[] array61 = array[5];
				int num59 = 2;
				array61[num59] |= (byte)(userSettingR8[115] & (int)BinaryDefine.b00000111);
				byte[] array62 = array[5];
				int num60 = 1;
				array62[num60] |= (byte)(userSettingR8[84] << 7 & (int)BinaryDefine.b10000000);
				byte[] array63 = array[5];
				int num61 = 1;
				array63[num61] |= (byte)(userSettingR8[88] << 3 & (int)BinaryDefine.b00111000);
				byte[] array64 = array[5];
				int num62 = 1;
				array64[num62] |= (byte)(userSettingR8[87] & (int)BinaryDefine.b00000111);
				byte[] array65 = array[5];
				int num63 = 0;
				array65[num63] |= (byte)(userSettingR8[0] << 7 & (int)BinaryDefine.b10000000);
				byte[] array66 = array[5];
				int num64 = 0;
				array66[num64] |= (byte)(userSettingR8[123] << 6 & (int)BinaryDefine.b01000000);
				byte[] array67 = array[5];
				int num65 = 0;
				array67[num65] |= (byte)(userSettingR8[91] << 3 & (int)BinaryDefine.b00111000);
				byte[] array68 = array[5];
				int num66 = 0;
				array68[num66] |= (byte)(userSettingR8[89] & (int)BinaryDefine.b00000111);
				byte[] array69 = array[6];
				int num67 = 3;
				array69[num67] |= (byte)(userSettingR8[93] << 4 & (int)BinaryDefine.b11110000);
				byte[] array70 = array[6];
				int num68 = 3;
				array70[num68] |= (byte)(userSettingR8[92] & (int)BinaryDefine.b00001111);
				byte[] array71 = array[6];
				int num69 = 2;
				array71[num69] |= (byte)(userSettingR8[96] << 4 & (int)BinaryDefine.b11110000);
				byte[] array72 = array[6];
				int num70 = 2;
				array72[num70] |= (byte)(userSettingR8[94] & (int)BinaryDefine.b00001111);
				byte[] array73 = array[6];
				int num71 = 1;
				array73[num71] |= (byte)(userSettingR8[9] << 7 & (int)BinaryDefine.b10000000);
				byte[] array74 = array[6];
				int num72 = 1;
				array74[num72] |= (byte)(userSettingR8[27] << 5 & (int)BinaryDefine.b01100000);
				byte[] array75 = array[6];
				int num73 = 1;
				array75[num73] |= (byte)(userSettingR8[98] << 4 & (int)BinaryDefine.b00010000);
				byte[] array76 = array[6];
				int num74 = 1;
				array76[num74] |= (byte)(userSettingR8[6] & (int)BinaryDefine.b00001111);
				byte[] array77 = array[6];
				int num75 = 0;
				array77[num75] |= (byte)(userSettingR8[12] << 5 & (int)BinaryDefine.b11100000);
				byte[] array78 = array[6];
				int num76 = 0;
				array78[num76] |= (byte)(userSettingR8[124] << 1 & (int)BinaryDefine.b00011110);
				byte[] array79 = array[6];
				int num77 = 0;
				array79[num77] |= (byte)(userSettingR8[114] & (int)BinaryDefine.b00000001);
				byte[] array80 = array[7];
				int num78 = 3;
				array80[num78] |= (byte)(userSettingR8[119] << 4 & (int)BinaryDefine.b11110000);
				byte[] array81 = array[7];
				int num79 = 3;
				array81[num79] |= (byte)(userSettingR8[117] & (int)BinaryDefine.b00001111);
				if (userSettingR8[101] == 1)
				{
					b = (byte)(userSettingR8[5] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[5] / 10);
				}
				byte[] array82 = array[7];
				int num80 = 2;
				array82[num80] |= (byte)((int)b << 4 & (int)BinaryDefine.b11110000);
				byte[] array83 = array[7];
				int num81 = 2;
				array83[num81] |= (byte)(userSettingR8[100] << 2 & (int)BinaryDefine.b00001100);
				byte[] array84 = array[7];
				int num82 = 2;
				array84[num82] |= (byte)(userSettingR8[1] & (int)BinaryDefine.b00000011);
				byte[] array85 = array[7];
				int num83 = 1;
				array85[num83] |= (byte)(userSettingR8[107] << 4 & (int)BinaryDefine.b11110000);
				byte[] array86 = array[7];
				int num84 = 1;
				array86[num84] |= (byte)(userSettingR8[15] << 3 & (int)BinaryDefine.b00001000);
				byte[] array87 = array[7];
				int num85 = 1;
				array87[num85] |= (byte)(userSettingR8[25] & (int)BinaryDefine.b00000001);
				byte[] array88 = array[7];
				int num86 = 0;
				array88[num86] |= (byte)(userSettingR8[90] << 4 & (int)BinaryDefine.b01110000);
				byte[] array89 = array[7];
				int num87 = 0;
				array89[num87] |= (byte)(userSettingR8[95] & (int)BinaryDefine.b00001111);
				byte[] array90 = array[8];
				int num88 = 3;
				array90[num88] |= (byte)(userSettingR8[97] << 3 & (int)BinaryDefine.b00011000);
				byte[] array91 = array[8];
				int num89 = 3;
				array91[num89] |= (byte)(userSettingR8[104] & (int)BinaryDefine.b00000111);
				byte[] array92 = array[8];
				int num90 = 2;
				array92[num90] |= (byte)(userSettingR8[22] & (int)BinaryDefine.b00000001);
				byte[] array93 = array[8];
				int num91 = 0;
				array93[num91] |= (byte)(userSettingR8[105] & (int)BinaryDefine.b00001111);
				byte[] array94 = array[17];
				int num92 = 3;
				array94[num92] |= (byte)(userSettingR8[7] << 4 & (int)BinaryDefine.b11110000);
				byte[] array95 = array[17];
				int num93 = 3;
				array95[num93] |= (byte)(userSettingR8[8] & (int)BinaryDefine.b00001111);
				byte[] array96 = array[17];
				int num94 = 2;
				array96[num94] |= (byte)(userSettingR8[111] << 1 & (int)BinaryDefine.b00011110);
				byte[] array97 = array[17];
				int num95 = 2;
				array97[num95] |= (byte)(userSettingR8[113] & (int)BinaryDefine.b00000001);
				this.user_k_block_n_data_write(array, 9, userSettingR8, 45, userSettingR8[1]);
				this.user_k_block_n_data_write(array, 10, userSettingR8, 50, userSettingR8[1]);
				this.user_k_block_n_data_write(array, 11, userSettingR8, 55, userSettingR8[1]);
				this.user_k_block_n_data_write(array, 12, userSettingR8, 60, userSettingR8[1]);
				this.user_k_block_n_data_write(array, 13, userSettingR8, 65, userSettingR8[1]);
				this.user_k_block_n_data_write(array, 14, userSettingR8, 30, userSettingR8[1]);
				this.user_k_block_n_data_write(array, 15, userSettingR8, 35, userSettingR8[1]);
				this.user_k_block_n_data_write(array, 16, userSettingR8, 40, userSettingR8[1]);
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
				array2[256] = (byte)userSettingR8[131];
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

			// Token: 0x0400068E RID: 1678
			private int supportVersion = 134;

			// Token: 0x0400068F RID: 1679
			private int menuCnt = 134;

			// Token: 0x04000690 RID: 1680
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
				15,
				0,
				1,
				31,
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
				31,
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

			// Token: 0x04000691 RID: 1681
			private const int memoryQuotaPos = 256;

			// Token: 0x04000692 RID: 1682
			private const int HEADER = 0;

			// Token: 0x04000693 RID: 1683
			private const int GPS = 1;

			// Token: 0x04000694 RID: 1684
			private const int RD_1 = 2;

			// Token: 0x04000695 RID: 1685
			private const int RD_2 = 3;

			// Token: 0x04000696 RID: 1686
			private const int RD_3 = 4;

			// Token: 0x04000697 RID: 1687
			private const int RD_4 = 5;

			// Token: 0x04000698 RID: 1688
			private const int RD_5 = 6;

			// Token: 0x04000699 RID: 1689
			private const int RD_6 = 7;

			// Token: 0x0400069A RID: 1690
			private const int RD_7 = 8;

			// Token: 0x0400069B RID: 1691
			private const int USR_K_BLK1 = 9;

			// Token: 0x0400069C RID: 1692
			private const int USR_K_BLK2 = 10;

			// Token: 0x0400069D RID: 1693
			private const int USR_K_BLK3 = 11;

			// Token: 0x0400069E RID: 1694
			private const int USR_K_BLK4 = 12;

			// Token: 0x0400069F RID: 1695
			private const int USR_K_BLK5 = 13;

			// Token: 0x040006A0 RID: 1696
			private const int CONST_K_BLK1 = 14;

			// Token: 0x040006A1 RID: 1697
			private const int CONST_K_BLK2 = 15;

			// Token: 0x040006A2 RID: 1698
			private const int CONST_K_BLK3 = 16;

			// Token: 0x040006A3 RID: 1699
			private const int RD_8 = 17;

			// Token: 0x040006A4 RID: 1700
			private const int ADDR_CNT = 18;

			// Token: 0x040006A5 RID: 1701
			private const int RF_PWR_STRENGTH_LEVEL1 = 57;

			// Token: 0x040006A6 RID: 1702
			private const int RF_PWR_STRENGTH_LEVEL2 = 71;

			// Token: 0x040006A7 RID: 1703
			private const int RF_PWR_STRENGTH_LEVEL3 = 84;

			// Token: 0x040006A8 RID: 1704
			private const int RF_PWR_STRENGTH_LEVEL4 = 99;

			// Token: 0x040006A9 RID: 1705
			private const int RF_PWR_STRENGTH_LEVEL5 = 111;

			// Token: 0x040006AA RID: 1706
			private const int RF_PWR_STRENGTH_LEVEL6 = 123;

			// Token: 0x040006AB RID: 1707
			private const int RF_PWR_STRENGTH_LEVEL7 = 136;

			// Token: 0x040006AC RID: 1708
			private const int RF_PWR_STRENGTH_LEVEL0P5 = 50;

			// Token: 0x040006AD RID: 1709
			private const int RF_PWR_STRENGTH_LEVEL1P5 = 64;

			// Token: 0x040006AE RID: 1710
			private const int RF_PWR_STRENGTH_LEVEL2P5 = 77;

			// Token: 0x040006AF RID: 1711
			private const int RF_PWR_STRENGTH_LEVEL3P5 = 91;

			// Token: 0x040006B0 RID: 1712
			private const int RF_PWR_STRENGTH_LEVEL4P5 = 105;

			// Token: 0x040006B1 RID: 1713
			private const int RF_PWR_STRENGTH_LEVEL5P5 = 117;

			// Token: 0x040006B2 RID: 1714
			private const int RF_PWR_STRENGTH_LEVEL6P5 = 129;

			// Token: 0x040006B3 RID: 1715
			private const int RF_PWR_STRENGTH_LEVEL7P5 = 142;

			// Token: 0x040006B4 RID: 1716
			private const int RF_PWR_STRENGTH_LEVEL1_CITY = 99;

			// Token: 0x040006B5 RID: 1717
			private const int RF_PWR_STRENGTH_LEVEL2_CITY = 105;

			// Token: 0x040006B6 RID: 1718
			private const int RF_PWR_STRENGTH_LEVEL3_CITY = 111;

			// Token: 0x040006B7 RID: 1719
			private const int RF_PWR_STRENGTH_LEVEL4_CITY = 116;

			// Token: 0x040006B8 RID: 1720
			private const int RF_PWR_STRENGTH_LEVEL5_CITY = 123;

			// Token: 0x040006B9 RID: 1721
			private const int RF_PWR_STRENGTH_LEVEL6_CITY = 128;

			// Token: 0x040006BA RID: 1722
			private const int RF_PWR_STRENGTH_LEVEL7_CITY = 136;

			// Token: 0x040006BB RID: 1723
			private const int RF_PWR_STRENGTH_LEVEL0P5_CITY = 96;

			// Token: 0x040006BC RID: 1724
			private const int RF_PWR_STRENGTH_LEVEL1P5_CITY = 102;

			// Token: 0x040006BD RID: 1725
			private const int RF_PWR_STRENGTH_LEVEL2P5_CITY = 108;

			// Token: 0x040006BE RID: 1726
			private const int RF_PWR_STRENGTH_LEVEL3P5_CITY = 113;

			// Token: 0x040006BF RID: 1727
			private const int RF_PWR_STRENGTH_LEVEL4P5_CITY = 119;

			// Token: 0x040006C0 RID: 1728
			private const int RF_PWR_STRENGTH_LEVEL5P5_CITY = 125;

			// Token: 0x040006C1 RID: 1729
			private const int RF_PWR_STRENGTH_LEVEL6P5_CITY = 132;

			// Token: 0x040006C2 RID: 1730
			private const int RF_PWR_STRENGTH_LEVEL7P5_CITY = 140;

			// Token: 0x040006C3 RID: 1731
			private const int K_BLOCK_FILTER_LEVEL_0P5 = 8;

			// Token: 0x040006C4 RID: 1732
			private const int K_BLOCK_FILTER_LEVEL_1P0 = 9;

			// Token: 0x040006C5 RID: 1733
			private const int K_BLOCK_FILTER_LEVEL_1P5 = 10;

			// Token: 0x040006C6 RID: 1734
			private const int K_BLOCK_FILTER_LEVEL_2P0 = 11;

			// Token: 0x040006C7 RID: 1735
			private const int K_BLOCK_FILTER_LEVEL_2P5 = 12;

			// Token: 0x040006C8 RID: 1736
			private const int K_BLOCK_FILTER_LEVEL_3P0 = 13;

			// Token: 0x040006C9 RID: 1737
			private const int K_BLOCK_FILTER_LEVEL_3P5 = 14;

			// Token: 0x040006CA RID: 1738
			private const int K_BLOCK_FILTER_LEVEL_4P0 = 15;

			// Token: 0x040006CB RID: 1739
			private const int K_BLOCK_FILTER_LEVEL_4P5 = 16;

			// Token: 0x040006CC RID: 1740
			private const int K_BLOCK_FILTER_LEVEL_5P0 = 17;

			// Token: 0x040006CD RID: 1741
			private const int K_BLOCK_FILTER_LEVEL_5P5 = 18;

			// Token: 0x040006CE RID: 1742
			private const int K_BLOCK_FILTER_LEVEL_6P0 = 19;

			// Token: 0x040006CF RID: 1743
			private const int K_BLOCK_FILTER_LEVEL_6P5 = 20;

			// Token: 0x040006D0 RID: 1744
			private const int K_BLOCK_FILTER_LEVEL_7P0 = 21;

			// Token: 0x040006D1 RID: 1745
			private const int K_BLOCK_FILTER_LEVEL_7P5 = 22;

			// Token: 0x040006D2 RID: 1746
			private const int K_BLOCK_FILTER_LEVEL_8P0 = 23;

			// Token: 0x020000BE RID: 190
			private enum MENU
			{
				// Token: 0x04000BB3 RID: 2995
				MENU_MODE,
				// Token: 0x04000BB4 RID: 2996
				DETECTION_MODE,
				// Token: 0x04000BB5 RID: 2997
				X_SENSITIVE,
				// Token: 0x04000BB6 RID: 2998
				K_SENSITIVE,
				// Token: 0x04000BB7 RID: 2999
				KA_SENSITIVE,
				// Token: 0x04000BB8 RID: 3000
				AUTO_CITY_SPEED,
				// Token: 0x04000BB9 RID: 3001
				REAR_K_ATTENUATION,
				// Token: 0x04000BBA RID: 3002
				REAR_KA_ATTENUATION,
				// Token: 0x04000BBB RID: 3003
				REAR_X_ATTENUATION,
				// Token: 0x04000BBC RID: 3004
				BLUETOOTH_MODE,
				// Token: 0x04000BBD RID: 3005
				GPS_ENABLE,
				// Token: 0x04000BBE RID: 3006
				SPEED_CAMERA_ENABLE,
				// Token: 0x04000BBF RID: 3007
				SPEED_CAMERA_ALERT_RANGE,
				// Token: 0x04000BC0 RID: 3008
				RLC_ENABLE,
				// Token: 0x04000BC1 RID: 3009
				RLC_QRIDE,
				// Token: 0x04000BC2 RID: 3010
				POI_PASSCHIME,
				// Token: 0x04000BC3 RID: 3011
				VOICE_ENABLE,
				// Token: 0x04000BC4 RID: 3012
				KA_FREQ_VOICE,
				// Token: 0x04000BC5 RID: 3013
				X_BAND_ENABLE,
				// Token: 0x04000BC6 RID: 3014
				K_BAND_ENABLE,
				// Token: 0x04000BC7 RID: 3015
				KA_BAND_ENABLE,
				// Token: 0x04000BC8 RID: 3016
				LASER_ENABLE,
				// Token: 0x04000BC9 RID: 3017
				LASER_GUN_ID_ENABLE,
				// Token: 0x04000BCA RID: 3018
				K_POP_ENABLE,
				// Token: 0x04000BCB RID: 3019
				MRCD_ENABLE,
				// Token: 0x04000BCC RID: 3020
				GATSO_ENABLE,
				// Token: 0x04000BCD RID: 3021
				KA_POP_ENABLE,
				// Token: 0x04000BCE RID: 3022
				K_FILTER_ENABLE,
				// Token: 0x04000BCF RID: 3023
				KA_FILTER_ENABLE,
				// Token: 0x04000BD0 RID: 3024
				TSF_ENABLE,
				// Token: 0x04000BD1 RID: 3025
				K_BLOCK_FILTER_1_OP_MODE,
				// Token: 0x04000BD2 RID: 3026
				K_BLOCK_FILTER_1_RAW_STRENGTH,
				// Token: 0x04000BD3 RID: 3027
				K_BLOCK_FILTER_1_DIR,
				// Token: 0x04000BD4 RID: 3028
				K_BLOCK_FILTER_1_MIN_FREQ,
				// Token: 0x04000BD5 RID: 3029
				K_BLOCK_FILTER_1_MAX_FREQ,
				// Token: 0x04000BD6 RID: 3030
				K_BLOCK_FILTER_2_OP_MODE,
				// Token: 0x04000BD7 RID: 3031
				K_BLOCK_FILTER_2_RAW_STRENGTH,
				// Token: 0x04000BD8 RID: 3032
				K_BLOCK_FILTER_2_DIR,
				// Token: 0x04000BD9 RID: 3033
				K_BLOCK_FILTER_2_MIN_FREQ,
				// Token: 0x04000BDA RID: 3034
				K_BLOCK_FILTER_2_MAX_FREQ,
				// Token: 0x04000BDB RID: 3035
				K_BLOCK_FILTER_3_OP_MODE,
				// Token: 0x04000BDC RID: 3036
				K_BLOCK_FILTER_3_RAW_STRENGTH,
				// Token: 0x04000BDD RID: 3037
				K_BLOCK_FILTER_3_DIR,
				// Token: 0x04000BDE RID: 3038
				K_BLOCK_FILTER_3_MIN_FREQ,
				// Token: 0x04000BDF RID: 3039
				K_BLOCK_FILTER_3_MAX_FREQ,
				// Token: 0x04000BE0 RID: 3040
				USER_K_BLOCK_FILTER_1_OP_MODE,
				// Token: 0x04000BE1 RID: 3041
				USER_K_BLOCK_FILTER_1_RAW_STRENGTH,
				// Token: 0x04000BE2 RID: 3042
				USER_K_BLOCK_FILTER_1_DIR,
				// Token: 0x04000BE3 RID: 3043
				USER_K_BLOCK_FILTER_1_MIN_FREQ,
				// Token: 0x04000BE4 RID: 3044
				USER_K_BLOCK_FILTER_1_MAX_FREQ,
				// Token: 0x04000BE5 RID: 3045
				USER_K_BLOCK_FILTER_2_OP_MODE,
				// Token: 0x04000BE6 RID: 3046
				USER_K_BLOCK_FILTER_2_RAW_STRENGTH,
				// Token: 0x04000BE7 RID: 3047
				USER_K_BLOCK_FILTER_2_DIR,
				// Token: 0x04000BE8 RID: 3048
				USER_K_BLOCK_FILTER_2_MIN_FREQ,
				// Token: 0x04000BE9 RID: 3049
				USER_K_BLOCK_FILTER_2_MAX_FREQ,
				// Token: 0x04000BEA RID: 3050
				USER_K_BLOCK_FILTER_3_OP_MODE,
				// Token: 0x04000BEB RID: 3051
				USER_K_BLOCK_FILTER_3_RAW_STRENGTH,
				// Token: 0x04000BEC RID: 3052
				USER_K_BLOCK_FILTER_3_DIR,
				// Token: 0x04000BED RID: 3053
				USER_K_BLOCK_FILTER_3_MIN_FREQ,
				// Token: 0x04000BEE RID: 3054
				USER_K_BLOCK_FILTER_3_MAX_FREQ,
				// Token: 0x04000BEF RID: 3055
				USER_K_BLOCK_FILTER_4_OP_MODE,
				// Token: 0x04000BF0 RID: 3056
				USER_K_BLOCK_FILTER_4_RAW_STRENGTH,
				// Token: 0x04000BF1 RID: 3057
				USER_K_BLOCK_FILTER_4_DIR,
				// Token: 0x04000BF2 RID: 3058
				USER_K_BLOCK_FILTER_4_MIN_FREQ,
				// Token: 0x04000BF3 RID: 3059
				USER_K_BLOCK_FILTER_4_MAX_FREQ,
				// Token: 0x04000BF4 RID: 3060
				USER_K_BLOCK_FILTER_5_OP_MODE,
				// Token: 0x04000BF5 RID: 3061
				USER_K_BLOCK_FILTER_5_RAW_STRENGTH,
				// Token: 0x04000BF6 RID: 3062
				USER_K_BLOCK_FILTER_5_DIR,
				// Token: 0x04000BF7 RID: 3063
				USER_K_BLOCK_FILTER_5_MIN_FREQ,
				// Token: 0x04000BF8 RID: 3064
				USER_K_BLOCK_FILTER_5_MAX_FREQ,
				// Token: 0x04000BF9 RID: 3065
				K_NARROW,
				// Token: 0x04000BFA RID: 3066
				KA_NARROW,
				// Token: 0x04000BFB RID: 3067
				KA_SEG1,
				// Token: 0x04000BFC RID: 3068
				KA_SEG2,
				// Token: 0x04000BFD RID: 3069
				KA_SEG3,
				// Token: 0x04000BFE RID: 3070
				KA_SEG4,
				// Token: 0x04000BFF RID: 3071
				KA_SEG5,
				// Token: 0x04000C00 RID: 3072
				KA_SEG6,
				// Token: 0x04000C01 RID: 3073
				KA_SEG7,
				// Token: 0x04000C02 RID: 3074
				KA_SEG8,
				// Token: 0x04000C03 RID: 3075
				KA_SEG9,
				// Token: 0x04000C04 RID: 3076
				PRIORITY_MODE,
				// Token: 0x04000C05 RID: 3077
				MUTE_MEM_BAND_OPTION,
				// Token: 0x04000C06 RID: 3078
				AUTO_MUTE_MEM_ENABLE,
				// Token: 0x04000C07 RID: 3079
				AUTO_MUTE_MEM_BAND_OPTION,
				// Token: 0x04000C08 RID: 3080
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x04000C09 RID: 3081
				BACKGROUND_COLOR,
				// Token: 0x04000C0A RID: 3082
				X_BAND_ARROW_COLOR,
				// Token: 0x04000C0B RID: 3083
				K_BAND_ARROW_COLOR,
				// Token: 0x04000C0C RID: 3084
				MRCD_ARROW_COLOR,
				// Token: 0x04000C0D RID: 3085
				GATSO_ARROW_COLOR,
				// Token: 0x04000C0E RID: 3086
				KA_BAND_ARROW_COLOR,
				// Token: 0x04000C0F RID: 3087
				X_BAND_COLOR,
				// Token: 0x04000C10 RID: 3088
				K_BAND_COLOR,
				// Token: 0x04000C11 RID: 3089
				MRCD_COLOR,
				// Token: 0x04000C12 RID: 3090
				GATSO_COLOR,
				// Token: 0x04000C13 RID: 3091
				KA_BAND_COLOR,
				// Token: 0x04000C14 RID: 3092
				MAIN_DISPLAY,
				// Token: 0x04000C15 RID: 3093
				HEARTBEAT_ICON_ENABLE,
				// Token: 0x04000C16 RID: 3094
				LEFT_DISPLAY,
				// Token: 0x04000C17 RID: 3095
				ALERT_DISPLAY,
				// Token: 0x04000C18 RID: 3096
				SPEED_UNIT,
				// Token: 0x04000C19 RID: 3097
				X_BAND_ALERT_TONE,
				// Token: 0x04000C1A RID: 3098
				K_BAND_ALERT_TONE,
				// Token: 0x04000C1B RID: 3099
				K_BAND_BOGEY_TONE,
				// Token: 0x04000C1C RID: 3100
				K_BAND_BOGEY_LEVEL,
				// Token: 0x04000C1D RID: 3101
				MRCD_ALERT_TONE,
				// Token: 0x04000C1E RID: 3102
				GATSO_ALERT_TONE,
				// Token: 0x04000C1F RID: 3103
				KA_BAND_ALERT_TONE,
				// Token: 0x04000C20 RID: 3104
				KA_BAND_BOGEY_TONE,
				// Token: 0x04000C21 RID: 3105
				LASER_ALERT_TONE,
				// Token: 0x04000C22 RID: 3106
				AUTO_MUTE_ALERT_LEVEL,
				// Token: 0x04000C23 RID: 3107
				AUTO_MUTE_VOLUME,
				// Token: 0x04000C24 RID: 3108
				ALERT_TEMPORARY_VOLUME,
				// Token: 0x04000C25 RID: 3109
				REAR_K_BAND_MUTE_ENABLE,
				// Token: 0x04000C26 RID: 3110
				DARK_MODE_BRIGHTNESS,
				// Token: 0x04000C27 RID: 3111
				AUTO_DIM_SET_MODE_SELECT,
				// Token: 0x04000C28 RID: 3112
				AUTO_DIM_SET_BRIGHT_TIME,
				// Token: 0x04000C29 RID: 3113
				AUTO_DIM_SET_BRIGHT_BRIGHTNESS,
				// Token: 0x04000C2A RID: 3114
				AUTO_DIM_SET_DIM_TIME,
				// Token: 0x04000C2B RID: 3115
				AUTO_DIM_SET_DIM_BRIGHTNESS,
				// Token: 0x04000C2C RID: 3116
				BACKLIGHT_MODE,
				// Token: 0x04000C2D RID: 3117
				QRIDE_MODE,
				// Token: 0x04000C2E RID: 3118
				MRCD_QRIDE_ENABLE,
				// Token: 0x04000C2F RID: 3119
				QRIDE_VOLUME,
				// Token: 0x04000C30 RID: 3120
				LIMIT_SPEED_MODE,
				// Token: 0x04000C31 RID: 3121
				GMT,
				// Token: 0x04000C32 RID: 3122
				DST_ENABLE,
				// Token: 0x04000C33 RID: 3123
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x04000C34 RID: 3124
				VEHICLE_BATT_SAVER_ENABLE,
				// Token: 0x04000C35 RID: 3125
				SELF_TEST_ENABLE,
				// Token: 0x04000C36 RID: 3126
				MEMORY_QUOTA,
				// Token: 0x04000C37 RID: 3127
				MAIN_DIM_SET,
				// Token: 0x04000C38 RID: 3128
				MAIN_VOLUME
			}
		}

		// Token: 0x02000099 RID: 153
		private class v127 : UserSettingFormat
		{
			// Token: 0x0600033E RID: 830 RVA: 0x00055956 File Offset: 0x00053B56
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x0600033F RID: 831 RVA: 0x0005595E File Offset: 0x00053B5E
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x06000340 RID: 832 RVA: 0x00055966 File Offset: 0x00053B66
			public byte[] GetNVDataMask()
			{
				return this.userNVDataPos;
			}

			// Token: 0x06000341 RID: 833 RVA: 0x00024E4C File Offset: 0x0002304C
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return false;
			}

			// Token: 0x06000342 RID: 834 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_level(int strength, int mode)
			{
				return -1;
			}

			// Token: 0x06000343 RID: 835 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_raw_strength(int level, int mode)
			{
				return -1;
			}

			// Token: 0x06000344 RID: 836 RVA: 0x00055970 File Offset: 0x00053B70
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
				}, "Highway - Full Sensitivity\nCity - X and K sensitivity reduced. Ka band sensitivity same as Highway.\nAdvanced - User adjusts X, K, and Ka band sensitivity from 100%~30% in 10% intervals.\nAuto City - The R8 will automatically switch between Highway and City depending on the speed limits set in the Auto City Speed menu.");
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
				}, "Sets the speed at which the R8 changes from City mode to Highway mode and back.\n(Detection Mode - Auto City)");
				array[6] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear Attenuation", new int[]
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
				}, "Rear Balance – Manually sets the sensitivity of rear radar.\nThe higher the attenuation(100 %) the more signals, including weaker signals, are received.Reduce attenuation and the weaker signals drop out, leaving only the stronger signals.");
				array[7] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Bluetooth", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to connect applications that support the radar detector.");
				array[8] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "GPS On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Determines your geographic location.");
				array[9] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "Speed Camera Off/On", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Notifies you if any speed cameras are nearby.");
				array[10] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_MATCHING_VALUE_MULTI_ITEM_ATT, "Speed Camera Alert Range", new int[][]
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
				array[11] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "Red Light Camera On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Notifies you if any red light cameras are nearby.");
				array[12] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Red Light Camera Quiet Ride", new int[][]
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
				array[13] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "POI PassChime", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "POI PassChime sounds when users pass by a POI.");
				array[14] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Voice On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns voice alert on or off under the following conditions:\nType of radar / laser Band alarms");
				array[15] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Frequency Voice", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Announces the detected Ka band frequency.");
				UserSettingMenu[] array2 = array;
				int num = 16;
				UserSettingMenu.MENU_TYPE menuType = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString = "X Band On/Off";
				int[] array3 = new int[2];
				array3[0] = 1;
				array2[num] = new UserSettingMenu(menuType, menuString, array3, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore X band frequencies.\nTurn on for X band sensitivity as follows:\nHighway: Full sensitivity\nCity: X band sensitivity reduced");
				array[17] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore K band frequencies.");
				array[18] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore Ka band frequencies.");
				array[19] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore lasers.");
				array[20] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser Gun ID On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to display laser gun identifier.");
				array[21] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to use the external laser transponder interface.");
				array[22] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP Mode", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Constant Mode",
					"Pulse Mode",
					"Receive Mode"
				}, "Set the operation mode for external laser transponder interface\n1) Constant mode: Constant Transmit while receiving(detecting) laser signals.\n2) Pulse mode: intermittent Transmit while receiving(detecting) laser signals.\n3) Receive mode: Alert to laser signals but no transmitting signal will be emitted.");
				array[23] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP1 Setting", new int[]
				{
					0,
					1,
					2,
					3
				}, new string[]
				{
					"Front Rx",
					"Front Tx",
					"Rear Rx",
					"Rear Tx"
				}, "Front/Rear Setting: Set according to the direction transponder1 is installed in the vehicle.\n1) Front: Set to Front when the transponder is installed at the front of vehicle.\n2) Rear: Set to Rear when the transponder is installed at the rear of vehicle.\nTx/Rx Setting: Affect only for Dragon Eye guns. This setting does not affect the detection and transmitting for any other laser guns.\n1) Tx: Transmit mode for Dragon Eye guns.\n2) Rx: Detection mode for Dragon Eye guns.");
				array[24] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP2 Setting", new int[]
				{
					0,
					1,
					2,
					3
				}, new string[]
				{
					"Front Rx",
					"Front Tx",
					"Rear Rx",
					"Rear Tx"
				}, "Front/Rear Setting: Set according to the direction transponder2 is installed in the vehicle.\n1) Front: Set to Front when the transponder is installed at the front of vehicle.\n2) Rear: Set to Rear when the transponder is installed at the rear of vehicle.\nTx/Rx Setting: Affect only for Dragon Eye guns. This setting does not affect the detection and transmitting for any other laser guns.\n1) Tx: Transmit mode for Dragon Eye guns.\n2) Rx: Detection mode for Dragon Eye guns.");
				array[25] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP3 Setting", new int[]
				{
					0,
					1,
					2,
					3
				}, new string[]
				{
					"Front Rx",
					"Front Tx",
					"Rear Rx",
					"Rear Tx"
				}, "Front/Rear Setting: Set according to the direction transponder3 is installed in the vehicle.\n1) Front: Set to Front when the transponder is installed at the front of vehicle.\n2) Rear: Set to Rear when the transponder is installed at the rear of vehicle.\nTx/Rx Setting: Affect only for Dragon Eye guns. This setting does not affect the detection and transmitting for any other laser guns.\n1) Tx: Transmit mode for Dragon Eye guns.\n2) Rx: Detection mode for Dragon Eye guns.");
				array[26] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP4 Setting", new int[]
				{
					0,
					1,
					2,
					3
				}, new string[]
				{
					"Front Rx",
					"Front Tx",
					"Rear Rx",
					"Rear Tx"
				}, "Front/Rear Setting: Set according to the direction transponder4 is installed in the vehicle.\n1) Front: Set to Front when the transponder is installed at the front of vehicle.\n2) Rear: Set to Rear when the transponder is installed at the rear of vehicle.\nTx/Rx Setting: Affect only for Dragon Eye guns. This setting does not affect the detection and transmitting for any other laser guns.\n1) Tx: Transmit mode for Dragon Eye guns.\n2) Rx: Detection mode for Dragon Eye guns.");
				array[27] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP5 Setting", new int[]
				{
					0,
					1,
					2,
					3
				}, new string[]
				{
					"Front Rx",
					"Front Tx",
					"Rear Rx",
					"Rear Tx"
				}, "Front/Rear Setting: Set according to the direction transponder5 is installed in the vehicle.\n1) Front: Set to Front when the transponder is installed at the front of vehicle.\n2) Rear: Set to Rear when the transponder is installed at the rear of vehicle.\nTx/Rx Setting: Affect only for Dragon Eye guns. This setting does not affect the detection and transmitting for any other laser guns.\n1) Tx: Transmit mode for Dragon Eye guns.\n2) Rx: Detection mode for Dragon Eye guns.");
				array[28] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP6 Setting", new int[]
				{
					0,
					1,
					2,
					3
				}, new string[]
				{
					"Front Rx",
					"Front Tx",
					"Rear Rx",
					"Rear Tx"
				}, "Front/Rear Setting: Set according to the direction transponder6 is installed in the vehicle.\n1) Front: Set to Front when the transponder is installed at the front of vehicle.\n2) Rear: Set to Rear when the transponder is installed at the rear of vehicle.\nTx/Rx Setting: Affect only for Dragon Eye guns. This setting does not affect the detection and transmitting for any other laser guns.\n1) Tx: Transmit mode for Dragon Eye guns.\n2) Rx: Detection mode for Dragon Eye guns.");
				UserSettingMenu[] array4 = array;
				int num2 = 29;
				UserSettingMenu.MENU_TYPE menuType2 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString2 = "K POP On/Off";
				int[] array5 = new int[2];
				array5[0] = 1;
				array4[num2] = new UserSettingMenu(menuType2, menuString2, array5, new string[]
				{
					"Off",
					"On"
				}, "Detects K POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[30] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "MRCD/T On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates MultaRadar CD/CT low - powered radar gun detection.");
				UserSettingMenu[] array6 = array;
				int num3 = 31;
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
				int num4 = 32;
				UserSettingMenu.MENU_TYPE menuType4 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString4 = "Ka POP On/Off";
				int[] array9 = new int[2];
				array9[0] = 1;
				array8[num4] = new UserSettingMenu(menuType4, menuString4, array9, new string[]
				{
					"Off",
					"On"
				}, "Detects Ka POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[33] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Filter", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the K band to prevent false detections.");
				UserSettingMenu[] array10 = array;
				int num5 = 34;
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
				int num6 = 35;
				UserSettingMenu.MENU_TYPE menuType6 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString6 = "TSF";
				int[] array13 = new int[2];
				array13[0] = 1;
				array12[num6] = new UserSettingMenu(menuType6, menuString6, array13, new string[]
				{
					"Off",
					"On"
				}, "Traffic Sensor Filter. Prevents false alarms caused by traffic monitoring radar systems.");
				array[36] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter 24.199Ghz (± 0.005)", new int[]
				{
					0,
					1,
					2,
					3
				}, new string[]
				{
					"Off",
					"On",
					"Weak",
					"Mute"
				}, "Keep K Block1 Filter ON to block K band monitor systems in the 24.199Ghz (± 0.005) range");
				array[37] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter 24.168Ghz (± 0.002)", new int[]
				{
					0,
					1,
					2,
					3
				}, new string[]
				{
					"Off",
					"On",
					"Weak",
					"Mute"
				}, "Keep K Block2 Filter ON to block K band monitor systems in the 24.168Ghz (± 0.002) range");
				array[38] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Narrow/Wide/Extended", new int[]
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
				array[39] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Narrow/Wide/Segmentation", new int[]
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
				UserSettingMenu[] array14 = array;
				int num7 = 40;
				UserSettingMenu.MENU_TYPE menuType7 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString7 = "Ka Segmentation 33.399Ghz – 33.705Ghz";
				int[] array15 = new int[2];
				array15[0] = 1;
				array14[num7] = new UserSettingMenu(menuType7, menuString7, array15, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.399Ghz – 33.705Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array16 = array;
				int num8 = 41;
				UserSettingMenu.MENU_TYPE menuType8 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString8 = "Ka Segmentation 33.705Ghz – 33.903Ghz";
				int[] array17 = new int[2];
				array17[0] = 1;
				array16[num8] = new UserSettingMenu(menuType8, menuString8, array17, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.705Ghz – 33.903Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array18 = array;
				int num9 = 42;
				UserSettingMenu.MENU_TYPE menuType9 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString9 = "Ka Segmentation 33.903Ghz – 34.191Ghz";
				int[] array19 = new int[2];
				array19[0] = 1;
				array18[num9] = new UserSettingMenu(menuType9, menuString9, array19, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.903Ghz – 34.191Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array20 = array;
				int num10 = 43;
				UserSettingMenu.MENU_TYPE menuType10 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString10 = "Ka Segmentation 34.191Ghz – 34.587Ghz";
				int[] array21 = new int[2];
				array21[0] = 1;
				array20[num10] = new UserSettingMenu(menuType10, menuString10, array21, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.191Ghz – 34.587Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array22 = array;
				int num11 = 44;
				UserSettingMenu.MENU_TYPE menuType11 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString11 = "Ka Segmentation 34.587Ghz – 34.803Ghz";
				int[] array23 = new int[2];
				array23[0] = 1;
				array22[num11] = new UserSettingMenu(menuType11, menuString11, array23, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.587Ghz – 34.803Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array24 = array;
				int num12 = 45;
				UserSettingMenu.MENU_TYPE menuType12 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString12 = "Ka Segmentation 34.803Ghz – 35.163Ghz";
				int[] array25 = new int[2];
				array25[0] = 1;
				array24[num12] = new UserSettingMenu(menuType12, menuString12, array25, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.803Ghz – 35.163Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array26 = array;
				int num13 = 46;
				UserSettingMenu.MENU_TYPE menuType13 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString13 = "Ka Segmentation 35.163Ghz – 35.379Ghz";
				int[] array27 = new int[2];
				array27[0] = 1;
				array26[num13] = new UserSettingMenu(menuType13, menuString13, array27, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.163Ghz – 35.379Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array28 = array;
				int num14 = 47;
				UserSettingMenu.MENU_TYPE menuType14 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString14 = "Ka Segmentation 35.379Ghz – 35.613Ghz";
				int[] array29 = new int[2];
				array29[0] = 1;
				array28[num14] = new UserSettingMenu(menuType14, menuString14, array29, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.379Ghz – 35.613Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array30 = array;
				int num15 = 48;
				UserSettingMenu.MENU_TYPE menuType15 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString15 = "Ka Segmentation 35.613Ghz – 35.701Ghz";
				int[] array31 = new int[2];
				array31[0] = 1;
				array30[num15] = new UserSettingMenu(menuType15, menuString15, array31, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.613Ghz – 35.701Ghz (Ka Segmentation mode)");
				array[49] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Priority", new int[]
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
				array[50] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Select bands to be muted.");
				array[51] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute Memory On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "This menu turns the ability to automatically save mute requests for specific locations/frequency bands.");
				array[52] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Auto Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Auto Mute Memory Band Option Set specifies which bands will be muted.");
				UserSettingMenu[] array32 = array;
				int num16 = 53;
				UserSettingMenu.MENU_TYPE menuType16 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString16 = "All Threat Display";
				int[] array33 = new int[2];
				array33[0] = 1;
				array32[num16] = new UserSettingMenu(menuType16, menuString16, array33, new string[]
				{
					"Off",
					"On"
				}, "Displays if more than one radar signals are detected at the same time. The signal with the strongest radar signal is considered the main signal. The other signals are displayed on the left side.");
				array[54] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Background Color", new int[]
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
				array[55] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Arrow Color", new int[]
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
				array[56] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Arrow Color", new int[]
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
				array[57] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD/T Arrow Color", new int[]
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
				array[58] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "GATSO RT3/4 Arrow Color", new int[]
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
				array[59] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Arrow Color", new int[]
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
				array[60] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Color", new int[]
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
				array[61] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Color", new int[]
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
				array[62] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD/T Color", new int[]
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
				array[63] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Gatso RT3/4 Color", new int[]
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
				array[64] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Color", new int[]
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
				array[65] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Display", new int[]
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
				UserSettingMenu[] array34 = array;
				int num17 = 66;
				UserSettingMenu.MENU_TYPE menuType17 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString17 = "Scan Icon";
				int[] array35 = new int[2];
				array35[0] = 1;
				array34[num17] = new UserSettingMenu(menuType17, menuString17, array35, new string[]
				{
					"Off",
					"On"
				}, "Scan Icon displays to indicate the end of a scan cycle.");
				array[67] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Left Display", new int[]
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
				array[68] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Alert Display", new int[]
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
				UserSettingMenu[] array36 = array;
				int num18 = 69;
				UserSettingMenu.MENU_TYPE menuType18 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString18 = "Speed Unit";
				int[] array37 = new int[2];
				array37[0] = 1;
				array36[num18] = new UserSettingMenu(menuType18, menuString18, array37, new string[]
				{
					"mph",
					"km/h"
				}, "Select the speed measurement type.");
				array[69].isUnitMenuFlag = true;
				array[70] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "X Band Alert Tone", new int[]
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
				array[71] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Alert Tone", new int[]
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
				array[72] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Tone", new int[]
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
				array[73] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Level", new int[]
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
				array[74] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "MRCD/T Alert Tone", new int[]
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
				array[75] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "GATSO RT3/4 Alert Tone", new int[]
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
				array[76] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Alert Tone", new int[]
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
				array[77] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Bogey Tone", new int[]
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
				array[78] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Laser Alert Tone", new int[]
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
				array[79] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Auto Mute reduces alarm level to 1 after 3 seconds and returns to normal operation(Auto Mute = OFF) 10 seconds after the alert ends.If the same alarm sounds within the 10 second period, Auto Mute remains at level 1.The unit returns to normal operation(Auto Mute = OFF) if a different band is detected during Auto Mute = ON mode.");
				array[80] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Volume", new int[]
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
				UserSettingMenu[] array38 = array;
				int num19 = 81;
				UserSettingMenu.MENU_TYPE menuType19 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString19 = "Rear K Band Mute";
				int[] array39 = new int[2];
				array39[0] = 1;
				array38[num19] = new UserSettingMenu(menuType19, menuString19, array39, new string[]
				{
					"Off",
					"On"
				}, "Mutes K band signals from rear side.");
				array[82] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Dark mode Brightness", new int[]
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
				array[83] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Mode", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Time",
					"Sensor"
				}, "Set the start times for the OLED to automatically brighten or dim.\nSelecting Time will let you set specific times when you want the OLED to get brighter or dimmer.\nSelecting Sensor will let the ambient light levels trigger when the OLED will get brighter or dimmer.");
				array[84] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Time", new int[]
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
				array[85] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Brightness", new int[]
				{
					4,
					3,
					2
				}, new string[]
				{
					"Bright",
					"Dim",
					"Dimmer"
				}, "The R8 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[86] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Time", new int[]
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
				array[87] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Brightness", new int[]
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
				}, "The R8 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[88] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Backlight On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns the front key backlight on and off.");
				array[89] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Quiet Ride", new int[][]
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
				UserSettingMenu[] array40 = array;
				int num20 = 90;
				UserSettingMenu.MENU_TYPE menuType20 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString20 = "Quiet Ride MRCD On/Off";
				int[] array41 = new int[2];
				array41[0] = 1;
				array40[num20] = new UserSettingMenu(menuType20, menuString20, array41, new string[]
				{
					"Off",
					"On"
				}, "Mutes MRCD/T alarms when users drive under the speed limit set previously.");
				array[91] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Quiet Ride Volume", new int[]
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
				array[92] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Limit Speed", new int[][]
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
				array[93] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "GMT", new int[]
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
				UserSettingMenu[] array42 = array;
				int num21 = 94;
				UserSettingMenu.MENU_TYPE menuType21 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString21 = "DST";
				int[] array43 = new int[2];
				array43[0] = 1;
				array42[num21] = new UserSettingMenu(menuType21, menuString21, array43, new string[]
				{
					"Off",
					"On"
				}, "Daylight Saving Time");
				UserSettingMenu[] array44 = array;
				int num22 = 95;
				UserSettingMenu.MENU_TYPE menuType22 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString22 = "Low Battery Warning";
				int[] array45 = new int[2];
				array45[0] = 1;
				array44[num22] = new UserSettingMenu(menuType22, menuString22, array45, new string[]
				{
					"Off",
					"On"
				}, "Sounds a warning tone if the vehicle battery power drops below 11V.");
				UserSettingMenu[] array46 = array;
				int num23 = 96;
				UserSettingMenu.MENU_TYPE menuType23 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString23 = "Vehicle Battery Saver";
				int[] array47 = new int[2];
				array47[0] = 1;
				array46[num23] = new UserSettingMenu(menuType23, menuString23, array47, new string[]
				{
					"Off",
					"On"
				}, "Turns off power to the R8 if the speed stays at 0 or if the GPS is not connected for more than an hour.");
				array[97] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Self Test", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Runs a self diagnostic test on the unit to check for faults.");
				array[98] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Memory Quota", new int[]
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
				array[99] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Dim", new int[]
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
				array[100] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Main Volume", new int[]
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

			// Token: 0x06000345 RID: 837 RVA: 0x00057D6C File Offset: 0x00055F6C
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
				array[39] = (array2[2][3] >> 5 & (int)BinaryDefine.b00000011);
				array[54] = (array2[2][3] >> 2 & (int)BinaryDefine.b00000111);
				array[53] = (array2[2][3] >> 1 & (int)BinaryDefine.b00000001);
				array[35] = (int)(array2[2][3] & BinaryDefine.b00000001);
				switch (array[54])
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
					array[54] = 5;
					break;
				}
				array[34] = (array2[2][2] >> 7 & (int)BinaryDefine.b00000001);
				array[14] = (array2[2][2] >> 6 & (int)BinaryDefine.b00000001);
				array[16] = (array2[2][2] >> 5 & (int)BinaryDefine.b00000001);
				array[17] = (array2[2][2] >> 4 & (int)BinaryDefine.b00000001);
				array[18] = (array2[2][2] >> 3 & (int)BinaryDefine.b00000001);
				array[19] = (array2[2][2] >> 2 & (int)BinaryDefine.b00000001);
				array[32] = (array2[2][2] >> 1 & (int)BinaryDefine.b00000001);
				array[8] = (array2[2][1] >> 7 & (int)BinaryDefine.b00000001);
				array[79] = (array2[2][1] >> 3 & (int)BinaryDefine.b00000001);
				array[88] = (array2[2][1] >> 2 & (int)BinaryDefine.b00000001);
				array[95] = (array2[2][1] >> 1 & (int)BinaryDefine.b00000001);
				array[97] = (int)(array2[2][1] & BinaryDefine.b00000001);
				array[99] = (array2[2][0] >> 4 & (int)BinaryDefine.b00000111);
				array[100] = (int)(array2[2][0] & BinaryDefine.b00001111);
				switch (array[99])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
					break;
				default:
					array[99] = 5;
					break;
				}
				if (array[100] < 0 || array[100] > 8)
				{
					array[100] = 4;
				}
				array[69] = (array2[1][2] >> 7 & (int)BinaryDefine.b00000001);
				array[94] = (array2[1][2] >> 5 & (int)BinaryDefine.b00000001);
				int num = (int)(array2[1][2] & BinaryDefine.b00011111);
				if (array[69] == 1)
				{
					if (num >= 0 && num <= 18)
					{
						array[89] = num * 5;
					}
					else
					{
						array[89] = 0;
					}
				}
				else if (num >= 0 && num <= 14)
				{
					array[89] = num * 10;
				}
				else
				{
					array[89] = 0;
				}
				array[96] = (array2[1][3] >> 6 & (int)BinaryDefine.b00000001);
				array[29] = (array2[1][3] >> 5 & (int)BinaryDefine.b00000001);
				num = (int)(array2[1][3] & BinaryDefine.b00011111);
				if (array[69] == 1)
				{
					if (num == 0 || (num >= 10 && num <= 17))
					{
						array[12] = num * 5;
					}
					else
					{
						array[12] = 0;
					}
				}
				else if (num == 0 || (num >= 8 && num <= 14))
				{
					array[12] = num * 10;
				}
				else
				{
					array[12] = 0;
				}
				array[9] = (array2[1][1] >> 6 & (int)BinaryDefine.b00000001);
				array[11] = (array2[1][1] >> 5 & (int)BinaryDefine.b00000001);
				num = (int)(array2[1][1] & BinaryDefine.b00011111);
				if (array[69] == 1)
				{
					if (num == 0 || (num >= 10 && num <= 20))
					{
						array[92] = num * 5;
					}
					else
					{
						array[92] = 0;
					}
				}
				else if (num == 0 || (num >= 8 && num <= 16))
				{
					array[92] = num * 10;
				}
				else
				{
					array[92] = 0;
				}
				array[67] = (array2[1][0] >> 5 & (int)BinaryDefine.b00000111);
				num = (int)(array2[1][0] & BinaryDefine.b00011111);
				if (array[67] >= 6)
				{
					if (array[8] == 1)
					{
						array[67] = 4;
					}
					else
					{
						array[67] = 2;
					}
				}
				if (num != 31)
				{
					array[93] = (int)((byte)num - 12);
					if (array[93] < -12 || array[93] > 12)
					{
						array[93] = -8;
					}
				}
				else
				{
					array[93] = -8;
				}
				array[50] = (array2[3][3] >> 6 & (int)BinaryDefine.b00000001);
				array[15] = (array2[3][3] >> 5 & (int)BinaryDefine.b00000001);
				array[49] = (array2[3][3] >> 3 & (int)BinaryDefine.b00000011);
				array[80] = (int)(array2[3][3] & BinaryDefine.b00000111);
				if (array[80] < 0 || array[80] > 7)
				{
					array[80] = 2;
				}
				array[30] = (array2[3][2] >> 7 & (int)BinaryDefine.b00000001);
				array[2] = (array2[3][2] >> 3 & (int)BinaryDefine.b00000111);
				array[3] = (int)(array2[3][2] & BinaryDefine.b00000111);
				array[36] = (array2[3][1] >> 6 & (int)BinaryDefine.b00000011);
				array[48] = (array2[3][1] >> 3 & (int)BinaryDefine.b00000001);
				array[4] = (int)(array2[3][1] & BinaryDefine.b00000111);
				array[47] = (array2[3][0] >> 7 & (int)BinaryDefine.b00000001);
				array[46] = (array2[3][0] >> 6 & (int)BinaryDefine.b00000001);
				array[45] = (array2[3][0] >> 5 & (int)BinaryDefine.b00000001);
				array[44] = (array2[3][0] >> 4 & (int)BinaryDefine.b00000001);
				array[43] = (array2[3][0] >> 3 & (int)BinaryDefine.b00000001);
				array[42] = (array2[3][0] >> 2 & (int)BinaryDefine.b00000001);
				array[41] = (array2[3][0] >> 1 & (int)BinaryDefine.b00000001);
				array[40] = (int)(array2[3][0] & BinaryDefine.b00000001);
				array[83] = (array2[4][3] >> 6 & (int)BinaryDefine.b00000001);
				array[85] = (array2[4][3] >> 3 & (int)BinaryDefine.b00000111);
				array[87] = (int)(array2[4][3] & BinaryDefine.b00000111);
				switch (array[85])
				{
				default:
					array[85] = 4;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				switch (array[87])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
					break;
				default:
					array[87] = 4;
					break;
				}
				array[70] = (array2[4][2] >> 4 & (int)BinaryDefine.b00001111);
				array[71] = (int)(array2[4][2] & BinaryDefine.b00001111);
				array[78] = (array2[4][1] >> 4 & (int)BinaryDefine.b00001111);
				array[76] = (int)(array2[4][1] & BinaryDefine.b00001111);
				array[77] = (array2[5][3] >> 4 & (int)BinaryDefine.b00000111);
				array[74] = (int)(array2[5][3] & BinaryDefine.b00001111);
				array[38] = (array2[5][2] >> 6 & (int)BinaryDefine.b00000011);
				array[51] = (array2[5][2] >> 5 & (int)BinaryDefine.b00000001);
				array[82] = (int)(array2[5][2] & BinaryDefine.b00000111);
				switch (array[82])
				{
				default:
					array[82] = 2;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				array[52] = (array2[5][1] >> 7 & (int)BinaryDefine.b00000001);
				array[56] = (array2[5][1] >> 3 & (int)BinaryDefine.b00000111);
				array[55] = (int)(array2[5][1] & BinaryDefine.b00000111);
				if (array[56] > 6)
				{
					array[56] = 0;
				}
				if (array[55] > 6)
				{
					array[55] = 0;
				}
				array[0] = (array2[5][0] >> 7 & (int)BinaryDefine.b00000001);
				array[90] = (array2[5][0] >> 6 & (int)BinaryDefine.b00000001);
				array[59] = (array2[5][0] >> 3 & (int)BinaryDefine.b00000111);
				array[57] = (int)(array2[5][0] & BinaryDefine.b00000111);
				if (array[59] > 6)
				{
					array[59] = 0;
				}
				if (array[57] > 6)
				{
					array[57] = 0;
				}
				if (array[70] > 12 || array[70] == 0)
				{
					array[70] = 1;
				}
				if (array[71] > 12 || array[71] == 0)
				{
					array[71] = 2;
				}
				if (array[74] > 12 || array[74] == 0)
				{
					array[74] = 2;
				}
				if (array[76] > 12 || array[76] == 0)
				{
					array[76] = 3;
				}
				if (array[77] > 6 || array[77] == 0)
				{
					array[77] = 1;
				}
				if (array[78] > 12 || array[78] == 0)
				{
					array[78] = 4;
				}
				array[61] = (array2[6][3] >> 4 & (int)BinaryDefine.b00001111);
				array[60] = (int)(array2[6][3] & BinaryDefine.b00001111);
				if (array[61] > 8)
				{
					array[61] = 0;
				}
				if (array[60] > 8)
				{
					array[60] = 0;
				}
				array[64] = (array2[6][2] >> 4 & (int)BinaryDefine.b00001111);
				array[62] = (int)(array2[6][2] & BinaryDefine.b00001111);
				if (array[64] > 8)
				{
					array[64] = 0;
				}
				if (array[62] > 8)
				{
					array[62] = 0;
				}
				array[7] = (array2[6][1] >> 7 & (int)BinaryDefine.b00000001);
				array[33] = (array2[6][1] >> 5 & (int)BinaryDefine.b00000001);
				array[66] = (array2[6][1] >> 4 & (int)BinaryDefine.b00000001);
				array[6] = (int)(array2[6][1] & BinaryDefine.b00001111);
				if (array[6] > 8)
				{
					array[6] = 8;
				}
				if (array[6] == 0)
				{
					array[6] = 8;
				}
				array[10] = (array2[6][0] >> 5 & (int)BinaryDefine.b00000111);
				array[91] = (array2[6][0] >> 1 & (int)BinaryDefine.b00001111);
				array[81] = (int)(array2[6][0] & BinaryDefine.b00000001);
				if (array[10] > 4)
				{
					array[10] = 1;
				}
				if (array[91] > 8)
				{
					array[91] = 1;
				}
				array[86] = (array2[7][3] >> 4 & (int)BinaryDefine.b00001111);
				array[84] = (int)(array2[7][3] & BinaryDefine.b00001111);
				if (array[86] > 12)
				{
					array[86] = 4;
				}
				if (array[84] > 8)
				{
					array[84] = 4;
				}
				num = (array2[7][2] >> 4 & (int)BinaryDefine.b00001111);
				array[68] = (array2[7][2] >> 2 & (int)BinaryDefine.b00000011);
				array[1] = (int)(array2[7][2] & BinaryDefine.b00000011);
				if (array[69] == 1)
				{
					if (num >= 2 && num <= 12)
					{
						array[5] = num * 5;
					}
					else
					{
						array[5] = 40;
					}
				}
				else if (num >= 1 && num <= 10)
				{
					array[5] = num * 10;
				}
				else
				{
					array[5] = 60;
				}
				if (array[68] > 2)
				{
					array[68] = 1;
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
				array[75] = (array2[7][1] >> 4 & (int)BinaryDefine.b00001111);
				array[13] = (array2[7][1] >> 3 & (int)BinaryDefine.b00000001);
				array[37] = (array2[7][1] >> 1 & (int)BinaryDefine.b00000011);
				array[31] = (int)(array2[7][1] & BinaryDefine.b00000001);
				if (array[75] > 12 || array[75] == 0)
				{
					array[75] = 9;
				}
				array[58] = (array2[7][0] >> 4 & (int)BinaryDefine.b00000111);
				array[63] = (int)(array2[7][0] & BinaryDefine.b00001111);
				if (array[58] > 6)
				{
					array[58] = 0;
				}
				if (array[63] > 8)
				{
					array[63] = 0;
				}
				array[65] = (array2[8][3] >> 3 & (int)BinaryDefine.b00000011);
				array[72] = (int)(array2[8][3] & BinaryDefine.b00000111);
				if (array[72] > 6 || array[72] == 0)
				{
					array[72] = 1;
				}
				switch (array[65])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[65] = 1;
					break;
				}
				array[24] = (array2[8][2] >> 6 & (int)BinaryDefine.b00000011);
				array[23] = (array2[8][2] >> 4 & (int)BinaryDefine.b00000011);
				array[22] = (array2[8][2] >> 2 & (int)BinaryDefine.b00000011);
				array[21] = (array2[8][2] >> 1 & (int)BinaryDefine.b00000001);
				array[20] = (int)(array2[8][2] & BinaryDefine.b00000001);
				if (array[24] > 3)
				{
					array[24] = 0;
				}
				if (array[23] > 3)
				{
					array[23] = 1;
				}
				switch (array[22])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[22] = 0;
					break;
				}
				array[28] = (array2[8][1] >> 6 & (int)BinaryDefine.b00000011);
				array[27] = (array2[8][1] >> 4 & (int)BinaryDefine.b00000011);
				array[26] = (array2[8][1] >> 2 & (int)BinaryDefine.b00000011);
				array[25] = (int)(array2[8][1] & BinaryDefine.b00000011);
				if (array[28] > 3)
				{
					array[28] = 0;
				}
				if (array[27] > 3)
				{
					array[27] = 2;
				}
				if (array[26] > 3)
				{
					array[26] = 3;
				}
				if (array[25] > 3)
				{
					array[25] = 2;
				}
				array[73] = (int)(array2[8][0] & BinaryDefine.b00001111);
				if (array[73] > 8 || array[73] < 1)
				{
					array[73] = 4;
				}
				array[98] = (int)nvData[256];
				return array;
			}

			// Token: 0x06000346 RID: 838 RVA: 0x0005889C File Offset: 0x00056A9C
			public byte[] GetNVDataFromUserSetting(int[] userSettingR8, byte[] receivedNVData)
			{
				if (this.menuCnt == 0)
				{
					return null;
				}
				byte[][] array = new byte[9][];
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
				array3[num] |= (byte)(userSettingR8[39] << 5 & (int)BinaryDefine.b01100000);
				byte[] array4 = array[2];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR8[54] << 2 & (int)BinaryDefine.b00011100);
				byte[] array5 = array[2];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR8[53] << 1 & (int)BinaryDefine.b00000010);
				byte[] array6 = array[2];
				int num4 = 3;
				array6[num4] |= (byte)(userSettingR8[35] & (int)BinaryDefine.b00000001);
				byte[] array7 = array[2];
				int num5 = 2;
				array7[num5] |= (byte)(userSettingR8[34] << 7 & (int)BinaryDefine.b10000000);
				byte[] array8 = array[2];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR8[14] << 6 & (int)BinaryDefine.b01000000);
				byte[] array9 = array[2];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR8[16] << 5 & (int)BinaryDefine.b00100000);
				byte[] array10 = array[2];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR8[17] << 4 & (int)BinaryDefine.b00010000);
				byte[] array11 = array[2];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR8[18] << 3 & (int)BinaryDefine.b00001000);
				byte[] array12 = array[2];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR8[19] << 2 & (int)BinaryDefine.b00000100);
				byte[] array13 = array[2];
				int num11 = 2;
				array13[num11] |= (byte)(userSettingR8[32] << 1 & (int)BinaryDefine.b00000010);
				byte[] array14 = array[2];
				int num12 = 1;
				array14[num12] |= (byte)(userSettingR8[8] << 7 & (int)BinaryDefine.b10000000);
				byte[] array15 = array[2];
				int num13 = 1;
				array15[num13] |= (byte)(userSettingR8[79] << 3 & (int)BinaryDefine.b00001000);
				byte[] array16 = array[2];
				int num14 = 1;
				array16[num14] |= (byte)(userSettingR8[88] << 2 & (int)BinaryDefine.b00000100);
				byte[] array17 = array[2];
				int num15 = 1;
				array17[num15] |= (byte)(userSettingR8[95] << 1 & (int)BinaryDefine.b00000010);
				byte[] array18 = array[2];
				int num16 = 1;
				array18[num16] |= (byte)(userSettingR8[97] & (int)BinaryDefine.b00000001);
				byte[] array19 = array[2];
				int num17 = 0;
				array19[num17] |= (byte)(userSettingR8[99] << 4 & (int)BinaryDefine.b01110000);
				byte[] array20 = array[2];
				int num18 = 0;
				array20[num18] |= (byte)(userSettingR8[100] & (int)BinaryDefine.b00001111);
				byte b;
				if (userSettingR8[69] == 1)
				{
					b = (byte)(userSettingR8[89] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[89] / 10);
				}
				byte[] array21 = array[1];
				int num19 = 2;
				array21[num19] |= (byte)(userSettingR8[69] << 7 & (int)BinaryDefine.b10000000);
				byte[] array22 = array[1];
				int num20 = 2;
				array22[num20] |= (byte)(userSettingR8[94] << 5 & (int)BinaryDefine.b00100000);
				byte[] array23 = array[1];
				int num21 = 2;
				array23[num21] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR8[69] == 1)
				{
					b = (byte)(userSettingR8[12] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[12] / 10);
				}
				byte[] array24 = array[1];
				int num22 = 3;
				array24[num22] |= (byte)(userSettingR8[96] << 6 & (int)BinaryDefine.b01000000);
				byte[] array25 = array[1];
				int num23 = 3;
				array25[num23] |= (byte)(userSettingR8[29] << 5 & (int)BinaryDefine.b00100000);
				byte[] array26 = array[1];
				int num24 = 3;
				array26[num24] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR8[69] == 1)
				{
					b = (byte)(userSettingR8[92] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[92] / 10);
				}
				byte[] array27 = array[1];
				int num25 = 1;
				array27[num25] |= (byte)(userSettingR8[9] << 6 & (int)BinaryDefine.b01000000);
				byte[] array28 = array[1];
				int num26 = 1;
				array28[num26] |= (byte)(userSettingR8[11] << 5 & (int)BinaryDefine.b00100000);
				byte[] array29 = array[1];
				int num27 = 1;
				array29[num27] |= unchecked((byte)(b & BinaryDefine.b00011111));
				b = (byte)(userSettingR8[93] + 12);
				byte[] array30 = array[1];
				int num28 = 0;
				array30[num28] |= (byte)(userSettingR8[67] << 5 & (int)BinaryDefine.b11100000);
				byte[] array31 = array[1];
				int num29 = 0;
				array31[num29] |= unchecked((byte)(b & BinaryDefine.b00011111));
				byte[] array32 = array[3];
				int num30 = 3;
				array32[num30] |= (byte)(userSettingR8[50] << 6 & (int)BinaryDefine.b01000000);
				byte[] array33 = array[3];
				int num31 = 3;
				array33[num31] |= (byte)(userSettingR8[15] << 5 & (int)BinaryDefine.b00100000);
				byte[] array34 = array[3];
				int num32 = 3;
				array34[num32] |= (byte)(userSettingR8[49] << 3 & (int)BinaryDefine.b00011000);
				byte[] array35 = array[3];
				int num33 = 3;
				array35[num33] |= (byte)(userSettingR8[80] & (int)BinaryDefine.b00000111);
				byte[] array36 = array[3];
				int num34 = 2;
				array36[num34] |= (byte)(userSettingR8[30] << 7 & (int)BinaryDefine.b10000000);
				byte[] array37 = array[3];
				int num35 = 2;
				array37[num35] |= (byte)(userSettingR8[2] << 3 & (int)BinaryDefine.b00111000);
				byte[] array38 = array[3];
				int num36 = 2;
				array38[num36] |= (byte)(userSettingR8[3] & (int)BinaryDefine.b00000111);
				byte[] array39 = array[3];
				int num37 = 1;
				array39[num37] |= (byte)(userSettingR8[36] << 6 & (int)BinaryDefine.b11000000);
				byte[] array40 = array[3];
				int num38 = 1;
				array40[num38] |= (byte)(userSettingR8[48] << 3 & (int)BinaryDefine.b00001000);
				byte[] array41 = array[3];
				int num39 = 1;
				array41[num39] |= (byte)(userSettingR8[4] & (int)BinaryDefine.b00000111);
				byte[] array42 = array[3];
				int num40 = 0;
				array42[num40] |= (byte)(userSettingR8[47] << 7 & (int)BinaryDefine.b10000000);
				byte[] array43 = array[3];
				int num41 = 0;
				array43[num41] |= (byte)(userSettingR8[46] << 6 & (int)BinaryDefine.b01000000);
				byte[] array44 = array[3];
				int num42 = 0;
				array44[num42] |= (byte)(userSettingR8[45] << 5 & (int)BinaryDefine.b00100000);
				byte[] array45 = array[3];
				int num43 = 0;
				array45[num43] |= (byte)(userSettingR8[44] << 4 & (int)BinaryDefine.b00010000);
				byte[] array46 = array[3];
				int num44 = 0;
				array46[num44] |= (byte)(userSettingR8[43] << 3 & (int)BinaryDefine.b00001000);
				byte[] array47 = array[3];
				int num45 = 0;
				array47[num45] |= (byte)(userSettingR8[42] << 2 & (int)BinaryDefine.b00000100);
				byte[] array48 = array[3];
				int num46 = 0;
				array48[num46] |= (byte)(userSettingR8[41] << 1 & (int)BinaryDefine.b00000010);
				byte[] array49 = array[3];
				int num47 = 0;
				array49[num47] |= (byte)(userSettingR8[40] & (int)BinaryDefine.b00000001);
				byte[] array50 = array[4];
				int num48 = 3;
				array50[num48] |= (byte)(userSettingR8[83] << 6 & (int)BinaryDefine.b01000000);
				byte[] array51 = array[4];
				int num49 = 3;
				array51[num49] |= (byte)(userSettingR8[85] << 3 & (int)BinaryDefine.b00111000);
				byte[] array52 = array[4];
				int num50 = 3;
				array52[num50] |= (byte)(userSettingR8[87] & (int)BinaryDefine.b00000111);
				byte[] array53 = array[4];
				int num51 = 2;
				array53[num51] |= (byte)(userSettingR8[70] << 4 & (int)BinaryDefine.b11110000);
				byte[] array54 = array[4];
				int num52 = 2;
				array54[num52] |= (byte)(userSettingR8[71] & (int)BinaryDefine.b00001111);
				byte[] array55 = array[4];
				int num53 = 1;
				array55[num53] |= (byte)(userSettingR8[78] << 4 & (int)BinaryDefine.b11110000);
				byte[] array56 = array[4];
				int num54 = 1;
				array56[num54] |= (byte)(userSettingR8[76] & (int)BinaryDefine.b00001111);
				byte[] array57 = array[5];
				int num55 = 3;
				array57[num55] |= (byte)(userSettingR8[77] << 4 & (int)BinaryDefine.b01110000);
				byte[] array58 = array[5];
				int num56 = 3;
				array58[num56] |= (byte)(userSettingR8[74] & (int)BinaryDefine.b00001111);
				byte[] array59 = array[5];
				int num57 = 2;
				array59[num57] |= (byte)(userSettingR8[38] << 6 & (int)BinaryDefine.b11000000);
				byte[] array60 = array[5];
				int num58 = 2;
				array60[num58] |= (byte)(userSettingR8[51] << 5 & (int)BinaryDefine.b00100000);
				byte[] array61 = array[5];
				int num59 = 2;
				array61[num59] |= (byte)(userSettingR8[82] & (int)BinaryDefine.b00000111);
				byte[] array62 = array[5];
				int num60 = 1;
				array62[num60] |= (byte)(userSettingR8[52] << 7 & (int)BinaryDefine.b10000000);
				byte[] array63 = array[5];
				int num61 = 1;
				array63[num61] |= (byte)(userSettingR8[56] << 3 & (int)BinaryDefine.b00111000);
				byte[] array64 = array[5];
				int num62 = 1;
				array64[num62] |= (byte)(userSettingR8[55] & (int)BinaryDefine.b00000111);
				byte[] array65 = array[5];
				int num63 = 0;
				array65[num63] |= (byte)(userSettingR8[0] << 7 & (int)BinaryDefine.b10000000);
				byte[] array66 = array[5];
				int num64 = 0;
				array66[num64] |= (byte)(userSettingR8[90] << 6 & (int)BinaryDefine.b01000000);
				byte[] array67 = array[5];
				int num65 = 0;
				array67[num65] |= (byte)(userSettingR8[59] << 3 & (int)BinaryDefine.b00111000);
				byte[] array68 = array[5];
				int num66 = 0;
				array68[num66] |= (byte)(userSettingR8[57] & (int)BinaryDefine.b00000111);
				byte[] array69 = array[6];
				int num67 = 3;
				array69[num67] |= (byte)(userSettingR8[61] << 4 & (int)BinaryDefine.b11110000);
				byte[] array70 = array[6];
				int num68 = 3;
				array70[num68] |= (byte)(userSettingR8[60] & (int)BinaryDefine.b00001111);
				byte[] array71 = array[6];
				int num69 = 2;
				array71[num69] |= (byte)(userSettingR8[64] << 4 & (int)BinaryDefine.b11110000);
				byte[] array72 = array[6];
				int num70 = 2;
				array72[num70] |= (byte)(userSettingR8[62] & (int)BinaryDefine.b00001111);
				byte[] array73 = array[6];
				int num71 = 1;
				array73[num71] |= (byte)(userSettingR8[7] << 7 & (int)BinaryDefine.b10000000);
				byte[] array74 = array[6];
				int num72 = 1;
				array74[num72] |= (byte)(userSettingR8[33] << 5 & (int)BinaryDefine.b01100000);
				byte[] array75 = array[6];
				int num73 = 1;
				array75[num73] |= (byte)(userSettingR8[66] << 4 & (int)BinaryDefine.b00010000);
				byte[] array76 = array[6];
				int num74 = 1;
				array76[num74] |= (byte)(userSettingR8[6] & (int)BinaryDefine.b00001111);
				byte[] array77 = array[6];
				int num75 = 0;
				array77[num75] |= (byte)(userSettingR8[10] << 5 & (int)BinaryDefine.b11100000);
				byte[] array78 = array[6];
				int num76 = 0;
				array78[num76] |= (byte)(userSettingR8[91] << 1 & (int)BinaryDefine.b00011110);
				byte[] array79 = array[6];
				int num77 = 0;
				array79[num77] |= (byte)(userSettingR8[81] & (int)BinaryDefine.b00000001);
				byte[] array80 = array[7];
				int num78 = 3;
				array80[num78] |= (byte)(userSettingR8[86] << 4 & (int)BinaryDefine.b11110000);
				byte[] array81 = array[7];
				int num79 = 3;
				array81[num79] |= (byte)(userSettingR8[84] & (int)BinaryDefine.b00001111);
				if (userSettingR8[69] == 1)
				{
					b = (byte)(userSettingR8[5] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[5] / 10);
				}
				byte[] array82 = array[7];
				int num80 = 2;
				array82[num80] |= (byte)((int)b << 4 & (int)BinaryDefine.b11110000);
				byte[] array83 = array[7];
				int num81 = 2;
				array83[num81] |= (byte)(userSettingR8[68] << 2 & (int)BinaryDefine.b00001100);
				byte[] array84 = array[7];
				int num82 = 2;
				array84[num82] |= (byte)(userSettingR8[1] & (int)BinaryDefine.b00000011);
				byte[] array85 = array[7];
				int num83 = 1;
				array85[num83] |= (byte)(userSettingR8[75] << 4 & (int)BinaryDefine.b11110000);
				byte[] array86 = array[7];
				int num84 = 1;
				array86[num84] |= (byte)(userSettingR8[13] << 3 & (int)BinaryDefine.b00001000);
				byte[] array87 = array[7];
				int num85 = 1;
				array87[num85] |= (byte)(userSettingR8[37] << 1 & (int)BinaryDefine.b00000110);
				byte[] array88 = array[7];
				int num86 = 1;
				array88[num86] |= (byte)(userSettingR8[31] & (int)BinaryDefine.b00000001);
				byte[] array89 = array[7];
				int num87 = 0;
				array89[num87] |= (byte)(userSettingR8[58] << 4 & (int)BinaryDefine.b01110000);
				byte[] array90 = array[7];
				int num88 = 0;
				array90[num88] |= (byte)(userSettingR8[63] & (int)BinaryDefine.b00001111);
				byte[] array91 = array[8];
				int num89 = 3;
				array91[num89] |= (byte)(userSettingR8[65] << 3 & (int)BinaryDefine.b00011000);
				byte[] array92 = array[8];
				int num90 = 3;
				array92[num90] |= (byte)(userSettingR8[72] & (int)BinaryDefine.b00000111);
				byte[] array93 = array[8];
				int num91 = 2;
				array93[num91] |= (byte)(userSettingR8[24] << 6 & (int)BinaryDefine.b11000000);
				byte[] array94 = array[8];
				int num92 = 2;
				array94[num92] |= (byte)(userSettingR8[23] << 4 & (int)BinaryDefine.b00110000);
				byte[] array95 = array[8];
				int num93 = 2;
				array95[num93] |= (byte)(userSettingR8[22] << 2 & (int)BinaryDefine.b00001100);
				byte[] array96 = array[8];
				int num94 = 2;
				array96[num94] |= (byte)(userSettingR8[21] << 1 & (int)BinaryDefine.b00000010);
				byte[] array97 = array[8];
				int num95 = 2;
				array97[num95] |= (byte)(userSettingR8[20] & (int)BinaryDefine.b00000001);
				byte[] array98 = array[8];
				int num96 = 1;
				array98[num96] |= (byte)(userSettingR8[28] << 6 & (int)BinaryDefine.b11000000);
				byte[] array99 = array[8];
				int num97 = 1;
				array99[num97] |= (byte)(userSettingR8[27] << 4 & (int)BinaryDefine.b00110000);
				byte[] array100 = array[8];
				int num98 = 1;
				array100[num98] |= (byte)(userSettingR8[26] << 2 & (int)BinaryDefine.b00001100);
				byte[] array101 = array[8];
				int num99 = 1;
				array101[num99] |= (byte)(userSettingR8[25] & (int)BinaryDefine.b00000011);
				byte[] array102 = array[8];
				int num100 = 0;
				array102[num100] |= (byte)(userSettingR8[73] & (int)BinaryDefine.b00001111);
				Array.Copy(receivedNVData, array2, receivedNVData.Length);
				for (int i = 0; i < array.Length; i++)
				{
					for (int j = 0; j < array[i].Length; j++)
					{
						byte[] array103 = array2;
						int num101 = i * 4 + j;
						array103[num101] &= unchecked((byte)(~this.userNVDataPos[i * 4 + j]));
						byte[] array104 = array2;
						int num102 = i * 4 + j;
						array104[num102] |= array[i][j];
					}
				}
				array2[256] = (byte)userSettingR8[98];
				int num103 = 0;
				for (int i = 0; i < receivedNVData.Length; i++)
				{
					if (receivedNVData[i] != array2[i])
					{
						num103++;
					}
				}
				return array2;
			}

			// Token: 0x040006D3 RID: 1747
			private int supportVersion = 127;

			// Token: 0x040006D4 RID: 1748
			private int menuCnt = 101;

			// Token: 0x040006D5 RID: 1749
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
				207,
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
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				15,
				byte.MaxValue,
				byte.MaxValue,
				31,
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

			// Token: 0x040006D6 RID: 1750
			private const int memoryQuotaPos = 256;

			// Token: 0x040006D7 RID: 1751
			private const int HEADER = 0;

			// Token: 0x040006D8 RID: 1752
			private const int GPS = 1;

			// Token: 0x040006D9 RID: 1753
			private const int RD_1 = 2;

			// Token: 0x040006DA RID: 1754
			private const int RD_2 = 3;

			// Token: 0x040006DB RID: 1755
			private const int RD_3 = 4;

			// Token: 0x040006DC RID: 1756
			private const int RD_4 = 5;

			// Token: 0x040006DD RID: 1757
			private const int RD_5 = 6;

			// Token: 0x040006DE RID: 1758
			private const int RD_6 = 7;

			// Token: 0x040006DF RID: 1759
			private const int RD_7 = 8;

			// Token: 0x040006E0 RID: 1760
			private const int ADDR_CNT = 9;

			// Token: 0x020000BF RID: 191
			private enum MENU
			{
				// Token: 0x04000C3A RID: 3130
				MENU_MODE,
				// Token: 0x04000C3B RID: 3131
				DETECTION_MODE,
				// Token: 0x04000C3C RID: 3132
				X_SENSITIVE,
				// Token: 0x04000C3D RID: 3133
				K_SENSITIVE,
				// Token: 0x04000C3E RID: 3134
				KA_SENSITIVE,
				// Token: 0x04000C3F RID: 3135
				AUTO_CITY_SPEED,
				// Token: 0x04000C40 RID: 3136
				REAR_ATTENUATION,
				// Token: 0x04000C41 RID: 3137
				BLUETOOTH_MODE,
				// Token: 0x04000C42 RID: 3138
				GPS_ENABLE,
				// Token: 0x04000C43 RID: 3139
				SPEED_CAMERA_ENABLE,
				// Token: 0x04000C44 RID: 3140
				SPEED_CAMERA_ALERT_RANGE,
				// Token: 0x04000C45 RID: 3141
				RLC_ENABLE,
				// Token: 0x04000C46 RID: 3142
				RLC_QRIDE,
				// Token: 0x04000C47 RID: 3143
				POI_PASSCHIME,
				// Token: 0x04000C48 RID: 3144
				VOICE_ENABLE,
				// Token: 0x04000C49 RID: 3145
				KA_FREQ_VOICE,
				// Token: 0x04000C4A RID: 3146
				X_BAND_ENABLE,
				// Token: 0x04000C4B RID: 3147
				K_BAND_ENABLE,
				// Token: 0x04000C4C RID: 3148
				KA_BAND_ENABLE,
				// Token: 0x04000C4D RID: 3149
				LASER_ENABLE,
				// Token: 0x04000C4E RID: 3150
				LASER_GUN_ID_ENABLE,
				// Token: 0x04000C4F RID: 3151
				LASER_JAMMER_INTERFACE_MODE,
				// Token: 0x04000C50 RID: 3152
				LASER_JAMMING_MODE,
				// Token: 0x04000C51 RID: 3153
				LASER_TP1_SETTING_MODE,
				// Token: 0x04000C52 RID: 3154
				LASER_TP2_SETTING_MODE,
				// Token: 0x04000C53 RID: 3155
				LASER_TP3_SETTING_MODE,
				// Token: 0x04000C54 RID: 3156
				LASER_TP4_SETTING_MODE,
				// Token: 0x04000C55 RID: 3157
				LASER_TP5_SETTING_MODE,
				// Token: 0x04000C56 RID: 3158
				LASER_TP6_SETTING_MODE,
				// Token: 0x04000C57 RID: 3159
				K_POP_ENABLE,
				// Token: 0x04000C58 RID: 3160
				MRCD_ENABLE,
				// Token: 0x04000C59 RID: 3161
				GATSO_ENABLE,
				// Token: 0x04000C5A RID: 3162
				KA_POP_ENABLE,
				// Token: 0x04000C5B RID: 3163
				K_FILTER_ENABLE,
				// Token: 0x04000C5C RID: 3164
				KA_FILTER_ENABLE,
				// Token: 0x04000C5D RID: 3165
				TSF_ENABLE,
				// Token: 0x04000C5E RID: 3166
				K_BLOCK_FILTER_1_MODE,
				// Token: 0x04000C5F RID: 3167
				K_BLOCK_FILTER_2_MODE,
				// Token: 0x04000C60 RID: 3168
				K_NARROW,
				// Token: 0x04000C61 RID: 3169
				KA_NARROW,
				// Token: 0x04000C62 RID: 3170
				KA_SEG1,
				// Token: 0x04000C63 RID: 3171
				KA_SEG2,
				// Token: 0x04000C64 RID: 3172
				KA_SEG3,
				// Token: 0x04000C65 RID: 3173
				KA_SEG4,
				// Token: 0x04000C66 RID: 3174
				KA_SEG5,
				// Token: 0x04000C67 RID: 3175
				KA_SEG6,
				// Token: 0x04000C68 RID: 3176
				KA_SEG7,
				// Token: 0x04000C69 RID: 3177
				KA_SEG8,
				// Token: 0x04000C6A RID: 3178
				KA_SEG9,
				// Token: 0x04000C6B RID: 3179
				PRIORITY_MODE,
				// Token: 0x04000C6C RID: 3180
				MUTE_MEM_BAND_OPTION,
				// Token: 0x04000C6D RID: 3181
				AUTO_MUTE_MEM_ENABLE,
				// Token: 0x04000C6E RID: 3182
				AUTO_MUTE_MEM_BAND_OPTION,
				// Token: 0x04000C6F RID: 3183
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x04000C70 RID: 3184
				BACKGROUND_COLOR,
				// Token: 0x04000C71 RID: 3185
				X_BAND_ARROW_COLOR,
				// Token: 0x04000C72 RID: 3186
				K_BAND_ARROW_COLOR,
				// Token: 0x04000C73 RID: 3187
				MRCD_ARROW_COLOR,
				// Token: 0x04000C74 RID: 3188
				GATSO_ARROW_COLOR,
				// Token: 0x04000C75 RID: 3189
				KA_BAND_ARROW_COLOR,
				// Token: 0x04000C76 RID: 3190
				X_BAND_COLOR,
				// Token: 0x04000C77 RID: 3191
				K_BAND_COLOR,
				// Token: 0x04000C78 RID: 3192
				MRCD_COLOR,
				// Token: 0x04000C79 RID: 3193
				GATSO_COLOR,
				// Token: 0x04000C7A RID: 3194
				KA_BAND_COLOR,
				// Token: 0x04000C7B RID: 3195
				MAIN_DISPLAY,
				// Token: 0x04000C7C RID: 3196
				HEARTBEAT_ICON_ENABLE,
				// Token: 0x04000C7D RID: 3197
				LEFT_DISPLAY,
				// Token: 0x04000C7E RID: 3198
				ALERT_DISPLAY,
				// Token: 0x04000C7F RID: 3199
				SPEED_UNIT,
				// Token: 0x04000C80 RID: 3200
				X_BAND_ALERT_TONE,
				// Token: 0x04000C81 RID: 3201
				K_BAND_ALERT_TONE,
				// Token: 0x04000C82 RID: 3202
				K_BAND_BOGEY_TONE,
				// Token: 0x04000C83 RID: 3203
				K_BAND_BOGEY_LEVEL,
				// Token: 0x04000C84 RID: 3204
				MRCD_ALERT_TONE,
				// Token: 0x04000C85 RID: 3205
				GATSO_ALERT_TONE,
				// Token: 0x04000C86 RID: 3206
				KA_BAND_ALERT_TONE,
				// Token: 0x04000C87 RID: 3207
				KA_BAND_BOGEY_TONE,
				// Token: 0x04000C88 RID: 3208
				LASER_ALERT_TONE,
				// Token: 0x04000C89 RID: 3209
				AUTO_MUTE_ENABLE,
				// Token: 0x04000C8A RID: 3210
				AUTO_MUTE_VOLUME,
				// Token: 0x04000C8B RID: 3211
				REAR_K_BAND_MUTE_ENABLE,
				// Token: 0x04000C8C RID: 3212
				DARK_MODE_BRIGHTNESS,
				// Token: 0x04000C8D RID: 3213
				AUTO_DIM_SET_MODE_SELECT,
				// Token: 0x04000C8E RID: 3214
				AUTO_DIM_SET_BRIGHT_TIME,
				// Token: 0x04000C8F RID: 3215
				AUTO_DIM_SET_BRIGHT_BRIGHTNESS,
				// Token: 0x04000C90 RID: 3216
				AUTO_DIM_SET_DIM_TIME,
				// Token: 0x04000C91 RID: 3217
				AUTO_DIM_SET_DIM_BRIGHTNESS,
				// Token: 0x04000C92 RID: 3218
				BACKLIGHT_MODE,
				// Token: 0x04000C93 RID: 3219
				QRIDE_MODE,
				// Token: 0x04000C94 RID: 3220
				MRCD_QRIDE_ENABLE,
				// Token: 0x04000C95 RID: 3221
				QRIDE_VOLUME,
				// Token: 0x04000C96 RID: 3222
				LIMIT_SPEED_MODE,
				// Token: 0x04000C97 RID: 3223
				GMT,
				// Token: 0x04000C98 RID: 3224
				DST_ENABLE,
				// Token: 0x04000C99 RID: 3225
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x04000C9A RID: 3226
				VEHICLE_BATT_SAVER_ENABLE,
				// Token: 0x04000C9B RID: 3227
				SELF_TEST_ENABLE,
				// Token: 0x04000C9C RID: 3228
				MEMORY_QUOTA,
				// Token: 0x04000C9D RID: 3229
				MAIN_DIM_SET,
				// Token: 0x04000C9E RID: 3230
				MAIN_VOLUME
			}
		}

		// Token: 0x0200009A RID: 154
		private class v124 : UserSettingFormat
		{
			// Token: 0x06000348 RID: 840 RVA: 0x0005945D File Offset: 0x0005765D
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x06000349 RID: 841 RVA: 0x00059465 File Offset: 0x00057665
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x0600034A RID: 842 RVA: 0x0005946D File Offset: 0x0005766D
			public byte[] GetNVDataMask()
			{
				return this.userNVDataPos;
			}

			// Token: 0x0600034B RID: 843 RVA: 0x00024E4C File Offset: 0x0002304C
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return false;
			}

			// Token: 0x0600034C RID: 844 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_level(int strength, int mode)
			{
				return -1;
			}

			// Token: 0x0600034D RID: 845 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_raw_strength(int level, int mode)
			{
				return -1;
			}

			// Token: 0x0600034E RID: 846 RVA: 0x00059478 File Offset: 0x00057678
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
				}, "Highway - Full Sensitivity\nCity - X and K sensitivity reduced. Ka band sensitivity same as Highway.\nAdvanced - User adjusts X, K, and Ka band sensitivity from 100%~30% in 10% intervals.\nAuto City - The R8 will automatically switch between Highway and City depending on the speed limits set in the Auto City Speed menu.");
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
				}, "Sets the speed at which the R8 changes from City mode to Highway mode and back.\n(Detection Mode - Auto City)");
				array[6] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear Attenuation", new int[]
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
				}, "Rear Balance – Manually sets the sensitivity of rear radar.\nThe higher the attenuation(100 %) the more signals, including weaker signals, are received.Reduce attenuation and the weaker signals drop out, leaving only the stronger signals.");
				array[7] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "GPS On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Determines your geographic location.");
				array[8] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "Speed Camera Off/On", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Notifies you if any speed cameras are nearby.");
				array[9] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_MATCHING_VALUE_MULTI_ITEM_ATT, "Speed Camera Alert Range", new int[][]
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
				array[10] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "Red Light Camera On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Notifies you if any red light cameras are nearby.");
				array[11] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Red Light Camera Quiet Ride", new int[][]
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
				array[12] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "POI PassChime", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "POI PassChime sounds when users pass by a POI.");
				array[13] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Voice On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns voice alert on or off under the following conditions:\nType of radar / laser Band alarms");
				array[14] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Frequency Voice", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Announces the detected Ka band frequency.");
				UserSettingMenu[] array2 = array;
				int num = 15;
				UserSettingMenu.MENU_TYPE menuType = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString = "X Band On/Off";
				int[] array3 = new int[2];
				array3[0] = 1;
				array2[num] = new UserSettingMenu(menuType, menuString, array3, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore X band frequencies.\nTurn on for X band sensitivity as follows:\nHighway: Full sensitivity\nCity: X band sensitivity reduced");
				array[16] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore K band frequencies.");
				array[17] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore Ka band frequencies.");
				array[18] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore lasers.");
				array[19] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser Gun ID On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to display laser gun identifier.");
				UserSettingMenu[] array4 = array;
				int num2 = 20;
				UserSettingMenu.MENU_TYPE menuType2 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString2 = "K POP On/Off";
				int[] array5 = new int[2];
				array5[0] = 1;
				array4[num2] = new UserSettingMenu(menuType2, menuString2, array5, new string[]
				{
					"Off",
					"On"
				}, "Detects K POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[21] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "MRCD/T On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates MultaRadar CD/CT low - powered radar gun detection.");
				UserSettingMenu[] array6 = array;
				int num3 = 22;
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
				int num4 = 23;
				UserSettingMenu.MENU_TYPE menuType4 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString4 = "Ka POP On/Off";
				int[] array9 = new int[2];
				array9[0] = 1;
				array8[num4] = new UserSettingMenu(menuType4, menuString4, array9, new string[]
				{
					"Off",
					"On"
				}, "Detects Ka POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[24] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Filter", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the K band to prevent false detections.");
				UserSettingMenu[] array10 = array;
				int num5 = 25;
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
				int num6 = 26;
				UserSettingMenu.MENU_TYPE menuType6 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString6 = "TSF";
				int[] array13 = new int[2];
				array13[0] = 1;
				array12[num6] = new UserSettingMenu(menuType6, menuString6, array13, new string[]
				{
					"Off",
					"On"
				}, "Traffic Sensor Filter. Prevents false alarms caused by traffic monitoring radar systems.");
				array[27] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter 24.199Ghz (± 0.005)", new int[]
				{
					0,
					1,
					2,
					3
				}, new string[]
				{
					"Off",
					"On",
					"Weak",
					"Mute"
				}, "Keep K Block1 Filter ON to block K band monitor systems in the 24.199Ghz (± 0.005) range");
				array[28] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter 24.168Ghz (± 0.002)", new int[]
				{
					0,
					1,
					2,
					3
				}, new string[]
				{
					"Off",
					"On",
					"Weak",
					"Mute"
				}, "Keep K Block2 Filter ON to block K band monitor systems in the 24.168Ghz (± 0.002) range");
				array[29] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Narrow/Wide/Extended", new int[]
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
				array[30] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Narrow/Wide/Segmentation", new int[]
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
				UserSettingMenu[] array14 = array;
				int num7 = 31;
				UserSettingMenu.MENU_TYPE menuType7 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString7 = "Ka Segmentation 33.399Ghz – 33.705Ghz";
				int[] array15 = new int[2];
				array15[0] = 1;
				array14[num7] = new UserSettingMenu(menuType7, menuString7, array15, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.399Ghz – 33.705Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array16 = array;
				int num8 = 32;
				UserSettingMenu.MENU_TYPE menuType8 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString8 = "Ka Segmentation 33.705Ghz – 33.903Ghz";
				int[] array17 = new int[2];
				array17[0] = 1;
				array16[num8] = new UserSettingMenu(menuType8, menuString8, array17, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.705Ghz – 33.903Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array18 = array;
				int num9 = 33;
				UserSettingMenu.MENU_TYPE menuType9 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString9 = "Ka Segmentation 33.903Ghz – 34.191Ghz";
				int[] array19 = new int[2];
				array19[0] = 1;
				array18[num9] = new UserSettingMenu(menuType9, menuString9, array19, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.903Ghz – 34.191Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array20 = array;
				int num10 = 34;
				UserSettingMenu.MENU_TYPE menuType10 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString10 = "Ka Segmentation 34.191Ghz – 34.587Ghz";
				int[] array21 = new int[2];
				array21[0] = 1;
				array20[num10] = new UserSettingMenu(menuType10, menuString10, array21, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.191Ghz – 34.587Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array22 = array;
				int num11 = 35;
				UserSettingMenu.MENU_TYPE menuType11 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString11 = "Ka Segmentation 34.587Ghz – 34.803Ghz";
				int[] array23 = new int[2];
				array23[0] = 1;
				array22[num11] = new UserSettingMenu(menuType11, menuString11, array23, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.587Ghz – 34.803Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array24 = array;
				int num12 = 36;
				UserSettingMenu.MENU_TYPE menuType12 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString12 = "Ka Segmentation 34.803Ghz – 35.163Ghz";
				int[] array25 = new int[2];
				array25[0] = 1;
				array24[num12] = new UserSettingMenu(menuType12, menuString12, array25, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.803Ghz – 35.163Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array26 = array;
				int num13 = 37;
				UserSettingMenu.MENU_TYPE menuType13 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString13 = "Ka Segmentation 35.163Ghz – 35.379Ghz";
				int[] array27 = new int[2];
				array27[0] = 1;
				array26[num13] = new UserSettingMenu(menuType13, menuString13, array27, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.163Ghz – 35.379Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array28 = array;
				int num14 = 38;
				UserSettingMenu.MENU_TYPE menuType14 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString14 = "Ka Segmentation 35.379Ghz – 35.613Ghz";
				int[] array29 = new int[2];
				array29[0] = 1;
				array28[num14] = new UserSettingMenu(menuType14, menuString14, array29, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.379Ghz – 35.613Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array30 = array;
				int num15 = 39;
				UserSettingMenu.MENU_TYPE menuType15 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString15 = "Ka Segmentation 35.613Ghz – 35.701Ghz";
				int[] array31 = new int[2];
				array31[0] = 1;
				array30[num15] = new UserSettingMenu(menuType15, menuString15, array31, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.613Ghz – 35.701Ghz (Ka Segmentation mode)");
				array[40] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Priority", new int[]
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
				array[41] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Select bands to be muted.");
				array[42] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute Memory On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "This menu turns the ability to automatically save mute requests for specific locations/frequency bands.");
				array[43] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Auto Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Auto Mute Memory Band Option Set specifies which bands will be muted.");
				UserSettingMenu[] array32 = array;
				int num16 = 44;
				UserSettingMenu.MENU_TYPE menuType16 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString16 = "All Threat Display";
				int[] array33 = new int[2];
				array33[0] = 1;
				array32[num16] = new UserSettingMenu(menuType16, menuString16, array33, new string[]
				{
					"Off",
					"On"
				}, "Displays if more than one radar signals are detected at the same time. The signal with the strongest radar signal is considered the main signal. The other signals are displayed on the left side.");
				array[45] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Background Color", new int[]
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
				array[46] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Arrow Color", new int[]
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
				array[47] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Arrow Color", new int[]
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
				array[48] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD/T Arrow Color", new int[]
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
				array[49] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "GATSO RT3/4 Arrow Color", new int[]
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
				array[50] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Arrow Color", new int[]
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
				array[51] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Color", new int[]
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
				array[52] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Color", new int[]
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
				array[53] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD/T Color", new int[]
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
				array[54] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Gatso RT3/4 Color", new int[]
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
				array[55] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Color", new int[]
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
				array[56] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Display", new int[]
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
				UserSettingMenu[] array34 = array;
				int num17 = 57;
				UserSettingMenu.MENU_TYPE menuType17 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString17 = "Scan Icon";
				int[] array35 = new int[2];
				array35[0] = 1;
				array34[num17] = new UserSettingMenu(menuType17, menuString17, array35, new string[]
				{
					"Off",
					"On"
				}, "Scan Icon displays to indicate the end of a scan cycle.");
				array[58] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Left Display", new int[]
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
				array[59] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Alert Display", new int[]
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
				UserSettingMenu[] array36 = array;
				int num18 = 60;
				UserSettingMenu.MENU_TYPE menuType18 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString18 = "Speed Unit";
				int[] array37 = new int[2];
				array37[0] = 1;
				array36[num18] = new UserSettingMenu(menuType18, menuString18, array37, new string[]
				{
					"mph",
					"km/h"
				}, "Select the speed measurement type.");
				array[60].isUnitMenuFlag = true;
				array[61] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "X Band Alert Tone", new int[]
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
				array[62] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Alert Tone", new int[]
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
				array[63] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Tone", new int[]
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
				array[64] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "MRCD/T Alert Tone", new int[]
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
				array[65] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "GATSO RT3/4 Alert Tone", new int[]
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
				array[66] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Alert Tone", new int[]
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
				array[67] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Bogey Tone", new int[]
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
				array[68] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Laser Alert Tone", new int[]
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
				array[69] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Auto Mute reduces alarm level to 1 after 3 seconds and returns to normal operation(Auto Mute = OFF) 10 seconds after the alert ends.If the same alarm sounds within the 10 second period, Auto Mute remains at level 1.The unit returns to normal operation(Auto Mute = OFF) if a different band is detected during Auto Mute = ON mode.");
				array[70] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Volume", new int[]
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
				UserSettingMenu[] array38 = array;
				int num19 = 71;
				UserSettingMenu.MENU_TYPE menuType19 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString19 = "Rear K Band Mute";
				int[] array39 = new int[2];
				array39[0] = 1;
				array38[num19] = new UserSettingMenu(menuType19, menuString19, array39, new string[]
				{
					"Off",
					"On"
				}, "Mutes K band signals from rear side.");
				array[72] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Dark mode Brightness", new int[]
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
				array[73] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Mode", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Time",
					"Sensor"
				}, "Set the start times for the OLED to automatically brighten or dim.\nSelecting Time will let you set specific times when you want the OLED to get brighter or dimmer.\nSelecting Sensor will let the ambient light levels trigger when the OLED will get brighter or dimmer.");
				array[74] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Time", new int[]
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
				array[75] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Brightness", new int[]
				{
					4,
					3,
					2
				}, new string[]
				{
					"Bright",
					"Dim",
					"Dimmer"
				}, "The R8 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[76] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Time", new int[]
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
				array[77] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Brightness", new int[]
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
				}, "The R8 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[78] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Backlight On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns the front key backlight on and off.");
				array[79] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Quiet Ride", new int[][]
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
				UserSettingMenu[] array40 = array;
				int num20 = 80;
				UserSettingMenu.MENU_TYPE menuType20 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString20 = "Quiet Ride MRCD On/Off";
				int[] array41 = new int[2];
				array41[0] = 1;
				array40[num20] = new UserSettingMenu(menuType20, menuString20, array41, new string[]
				{
					"Off",
					"On"
				}, "Mutes MRCD/T alarms when users drive under the speed limit set previously.");
				array[81] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Quiet Ride Volume", new int[]
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
				array[82] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Limit Speed", new int[][]
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
				array[83] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "GMT", new int[]
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
				UserSettingMenu[] array42 = array;
				int num21 = 84;
				UserSettingMenu.MENU_TYPE menuType21 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString21 = "DST";
				int[] array43 = new int[2];
				array43[0] = 1;
				array42[num21] = new UserSettingMenu(menuType21, menuString21, array43, new string[]
				{
					"Off",
					"On"
				}, "Daylight Saving Time");
				UserSettingMenu[] array44 = array;
				int num22 = 85;
				UserSettingMenu.MENU_TYPE menuType22 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString22 = "Low Battery Warning";
				int[] array45 = new int[2];
				array45[0] = 1;
				array44[num22] = new UserSettingMenu(menuType22, menuString22, array45, new string[]
				{
					"Off",
					"On"
				}, "Sounds a warning tone if the vehicle battery power drops below 11V.");
				UserSettingMenu[] array46 = array;
				int num23 = 86;
				UserSettingMenu.MENU_TYPE menuType23 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString23 = "Vehicle Battery Saver";
				int[] array47 = new int[2];
				array47[0] = 1;
				array46[num23] = new UserSettingMenu(menuType23, menuString23, array47, new string[]
				{
					"Off",
					"On"
				}, "Turns off power to the R8 if the speed stays at 0 or if the GPS is not connected for more than an hour.");
				array[87] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Self Test", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Runs a self diagnostic test on the unit to check for faults.");
				array[88] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Memory Quota", new int[]
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
				array[89] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Dim", new int[]
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
				array[90] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Main Volume", new int[]
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

			// Token: 0x0600034F RID: 847 RVA: 0x0005B5A0 File Offset: 0x000597A0
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
				array[30] = (array2[2][3] >> 5 & (int)BinaryDefine.b00000011);
				array[45] = (array2[2][3] >> 2 & (int)BinaryDefine.b00000111);
				array[44] = (array2[2][3] >> 1 & (int)BinaryDefine.b00000001);
				array[26] = (int)(array2[2][3] & BinaryDefine.b00000001);
				switch (array[45])
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
					array[45] = 5;
					break;
				}
				array[25] = (array2[2][2] >> 7 & (int)BinaryDefine.b00000001);
				array[13] = (array2[2][2] >> 6 & (int)BinaryDefine.b00000001);
				array[15] = (array2[2][2] >> 5 & (int)BinaryDefine.b00000001);
				array[16] = (array2[2][2] >> 4 & (int)BinaryDefine.b00000001);
				array[17] = (array2[2][2] >> 3 & (int)BinaryDefine.b00000001);
				array[18] = (array2[2][2] >> 2 & (int)BinaryDefine.b00000001);
				array[23] = (array2[2][2] >> 1 & (int)BinaryDefine.b00000001);
				array[7] = (array2[2][1] >> 7 & (int)BinaryDefine.b00000001);
				array[69] = (array2[2][1] >> 3 & (int)BinaryDefine.b00000001);
				array[78] = (array2[2][1] >> 2 & (int)BinaryDefine.b00000001);
				array[85] = (array2[2][1] >> 1 & (int)BinaryDefine.b00000001);
				array[87] = (int)(array2[2][1] & BinaryDefine.b00000001);
				array[89] = (array2[2][0] >> 4 & (int)BinaryDefine.b00000111);
				array[90] = (int)(array2[2][0] & BinaryDefine.b00001111);
				switch (array[89])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
					break;
				default:
					array[89] = 5;
					break;
				}
				if (array[90] < 0 || array[90] > 8)
				{
					array[90] = 4;
				}
				array[60] = (array2[1][2] >> 7 & (int)BinaryDefine.b00000001);
				array[84] = (array2[1][2] >> 5 & (int)BinaryDefine.b00000001);
				int num = (int)(array2[1][2] & BinaryDefine.b00011111);
				if (array[60] == 1)
				{
					if (num >= 0 && num <= 18)
					{
						array[79] = num * 5;
					}
					else
					{
						array[79] = 0;
					}
				}
				else if (num >= 0 && num <= 14)
				{
					array[79] = num * 10;
				}
				else
				{
					array[79] = 0;
				}
				array[86] = (array2[1][3] >> 6 & (int)BinaryDefine.b00000001);
				array[20] = (array2[1][3] >> 5 & (int)BinaryDefine.b00000001);
				num = (int)(array2[1][3] & BinaryDefine.b00011111);
				if (array[60] == 1)
				{
					if (num == 0 || (num >= 10 && num <= 17))
					{
						array[11] = num * 5;
					}
					else
					{
						array[11] = 0;
					}
				}
				else if (num == 0 || (num >= 8 && num <= 14))
				{
					array[11] = num * 10;
				}
				else
				{
					array[11] = 0;
				}
				array[8] = (array2[1][1] >> 6 & (int)BinaryDefine.b00000001);
				array[10] = (array2[1][1] >> 5 & (int)BinaryDefine.b00000001);
				num = (int)(array2[1][1] & BinaryDefine.b00011111);
				if (array[60] == 1)
				{
					if (num == 0 || (num >= 10 && num <= 20))
					{
						array[82] = num * 5;
					}
					else
					{
						array[82] = 0;
					}
				}
				else if (num == 0 || (num >= 8 && num <= 16))
				{
					array[82] = num * 10;
				}
				else
				{
					array[82] = 0;
				}
				array[58] = (array2[1][0] >> 5 & (int)BinaryDefine.b00000111);
				num = (int)(array2[1][0] & BinaryDefine.b00011111);
				if (array[58] >= 6)
				{
					if (array[7] == 1)
					{
						array[58] = 4;
					}
					else
					{
						array[58] = 2;
					}
				}
				if (num != 31)
				{
					array[83] = (int)((byte)num - 12);
					if (array[83] < -12 || array[83] > 12)
					{
						array[83] = -8;
					}
				}
				else
				{
					array[83] = -8;
				}
				array[41] = (array2[3][3] >> 6 & (int)BinaryDefine.b00000001);
				array[14] = (array2[3][3] >> 5 & (int)BinaryDefine.b00000001);
				array[40] = (array2[3][3] >> 3 & (int)BinaryDefine.b00000011);
				array[70] = (int)(array2[3][3] & BinaryDefine.b00000111);
				if (array[70] < 0 || array[70] > 7)
				{
					array[70] = 2;
				}
				array[21] = (array2[3][2] >> 7 & (int)BinaryDefine.b00000001);
				array[2] = (array2[3][2] >> 3 & (int)BinaryDefine.b00000111);
				array[3] = (int)(array2[3][2] & BinaryDefine.b00000111);
				array[27] = (array2[3][1] >> 6 & (int)BinaryDefine.b00000011);
				array[39] = (array2[3][1] >> 3 & (int)BinaryDefine.b00000001);
				array[4] = (int)(array2[3][1] & BinaryDefine.b00000111);
				array[38] = (array2[3][0] >> 7 & (int)BinaryDefine.b00000001);
				array[37] = (array2[3][0] >> 6 & (int)BinaryDefine.b00000001);
				array[36] = (array2[3][0] >> 5 & (int)BinaryDefine.b00000001);
				array[35] = (array2[3][0] >> 4 & (int)BinaryDefine.b00000001);
				array[34] = (array2[3][0] >> 3 & (int)BinaryDefine.b00000001);
				array[33] = (array2[3][0] >> 2 & (int)BinaryDefine.b00000001);
				array[32] = (array2[3][0] >> 1 & (int)BinaryDefine.b00000001);
				array[31] = (int)(array2[3][0] & BinaryDefine.b00000001);
				array[73] = (array2[4][3] >> 6 & (int)BinaryDefine.b00000001);
				array[75] = (array2[4][3] >> 3 & (int)BinaryDefine.b00000111);
				array[77] = (int)(array2[4][3] & BinaryDefine.b00000111);
				switch (array[75])
				{
				default:
					array[75] = 4;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				switch (array[77])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
					break;
				default:
					array[77] = 4;
					break;
				}
				array[61] = (array2[4][2] >> 4 & (int)BinaryDefine.b00001111);
				array[62] = (int)(array2[4][2] & BinaryDefine.b00001111);
				array[68] = (array2[4][1] >> 4 & (int)BinaryDefine.b00001111);
				array[66] = (int)(array2[4][1] & BinaryDefine.b00001111);
				array[67] = (array2[5][3] >> 4 & (int)BinaryDefine.b00000111);
				array[64] = (int)(array2[5][3] & BinaryDefine.b00001111);
				array[29] = (array2[5][2] >> 6 & (int)BinaryDefine.b00000011);
				array[42] = (array2[5][2] >> 5 & (int)BinaryDefine.b00000001);
				array[72] = (int)(array2[5][2] & BinaryDefine.b00000111);
				switch (array[72])
				{
				default:
					array[72] = 2;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				array[43] = (array2[5][1] >> 7 & (int)BinaryDefine.b00000001);
				array[47] = (array2[5][1] >> 3 & (int)BinaryDefine.b00000111);
				array[46] = (int)(array2[5][1] & BinaryDefine.b00000111);
				if (array[47] > 6)
				{
					array[47] = 0;
				}
				if (array[46] > 6)
				{
					array[46] = 0;
				}
				array[0] = (array2[5][0] >> 7 & (int)BinaryDefine.b00000001);
				array[80] = (array2[5][0] >> 6 & (int)BinaryDefine.b00000001);
				array[50] = (array2[5][0] >> 3 & (int)BinaryDefine.b00000111);
				array[48] = (int)(array2[5][0] & BinaryDefine.b00000111);
				if (array[50] > 6)
				{
					array[50] = 0;
				}
				if (array[48] > 6)
				{
					array[48] = 0;
				}
				if (array[61] > 12 || array[61] == 0)
				{
					array[61] = 1;
				}
				if (array[62] > 12 || array[62] == 0)
				{
					array[62] = 2;
				}
				if (array[64] > 12 || array[64] == 0)
				{
					array[64] = 2;
				}
				if (array[66] > 12 || array[66] == 0)
				{
					array[66] = 3;
				}
				if (array[67] > 6 || array[67] == 0)
				{
					array[67] = 1;
				}
				if (array[68] > 12 || array[68] == 0)
				{
					array[68] = 4;
				}
				array[52] = (array2[6][3] >> 4 & (int)BinaryDefine.b00001111);
				array[51] = (int)(array2[6][3] & BinaryDefine.b00001111);
				if (array[52] > 8)
				{
					array[52] = 0;
				}
				if (array[51] > 8)
				{
					array[51] = 0;
				}
				array[55] = (array2[6][2] >> 4 & (int)BinaryDefine.b00001111);
				array[53] = (int)(array2[6][2] & BinaryDefine.b00001111);
				if (array[55] > 8)
				{
					array[55] = 0;
				}
				if (array[53] > 8)
				{
					array[53] = 0;
				}
				array[24] = (array2[6][1] >> 5 & (int)BinaryDefine.b00000001);
				array[57] = (array2[6][1] >> 4 & (int)BinaryDefine.b00000001);
				array[6] = (int)(array2[6][1] & BinaryDefine.b00001111);
				if (array[6] > 8)
				{
					array[6] = 8;
				}
				if (array[6] == 0)
				{
					array[6] = 8;
				}
				array[9] = (array2[6][0] >> 5 & (int)BinaryDefine.b00000111);
				array[81] = (array2[6][0] >> 1 & (int)BinaryDefine.b00001111);
				array[71] = (int)(array2[6][0] & BinaryDefine.b00000001);
				if (array[9] > 4)
				{
					array[9] = 1;
				}
				if (array[81] > 8)
				{
					array[81] = 1;
				}
				array[76] = (array2[7][3] >> 4 & (int)BinaryDefine.b00001111);
				array[74] = (int)(array2[7][3] & BinaryDefine.b00001111);
				if (array[76] > 12)
				{
					array[76] = 4;
				}
				if (array[74] > 8)
				{
					array[74] = 4;
				}
				num = (array2[7][2] >> 4 & (int)BinaryDefine.b00001111);
				array[59] = (array2[7][2] >> 2 & (int)BinaryDefine.b00000011);
				array[1] = (int)(array2[7][2] & BinaryDefine.b00000011);
				if (array[60] == 1)
				{
					if (num >= 2 && num <= 12)
					{
						array[5] = num * 5;
					}
					else
					{
						array[5] = 40;
					}
				}
				else if (num >= 1 && num <= 10)
				{
					array[5] = num * 10;
				}
				else
				{
					array[5] = 60;
				}
				if (array[59] > 2)
				{
					array[59] = 1;
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
				array[65] = (array2[7][1] >> 4 & (int)BinaryDefine.b00001111);
				array[12] = (array2[7][1] >> 3 & (int)BinaryDefine.b00000001);
				array[28] = (array2[7][1] >> 1 & (int)BinaryDefine.b00000011);
				array[22] = (int)(array2[7][1] & BinaryDefine.b00000001);
				if (array[65] > 12 || array[65] == 0)
				{
					array[65] = 9;
				}
				array[49] = (array2[7][0] >> 4 & (int)BinaryDefine.b00000111);
				array[54] = (int)(array2[7][0] & BinaryDefine.b00001111);
				if (array[49] > 6)
				{
					array[49] = 0;
				}
				if (array[54] > 8)
				{
					array[54] = 0;
				}
				array[56] = (array2[8][3] >> 3 & (int)BinaryDefine.b00000011);
				array[63] = (int)(array2[8][3] & BinaryDefine.b00000111);
				if (array[63] > 6 || array[63] == 0)
				{
					array[63] = 1;
				}
				switch (array[56])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[56] = 1;
					break;
				}
				array[19] = (int)(array2[8][2] & BinaryDefine.b00000001);
				array[88] = (int)nvData[256];
				return array;
			}

			// Token: 0x06000350 RID: 848 RVA: 0x0005BFB0 File Offset: 0x0005A1B0
			public byte[] GetNVDataFromUserSetting(int[] userSettingR8, byte[] receivedNVData)
			{
				if (this.menuCnt == 0)
				{
					return null;
				}
				byte[][] array = new byte[9][];
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
				array3[num] |= (byte)(userSettingR8[30] << 5 & (int)BinaryDefine.b01100000);
				byte[] array4 = array[2];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR8[45] << 2 & (int)BinaryDefine.b00011100);
				byte[] array5 = array[2];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR8[44] << 1 & (int)BinaryDefine.b00000010);
				byte[] array6 = array[2];
				int num4 = 3;
				array6[num4] |= (byte)(userSettingR8[26] & (int)BinaryDefine.b00000001);
				byte[] array7 = array[2];
				int num5 = 2;
				array7[num5] |= (byte)(userSettingR8[25] << 7 & (int)BinaryDefine.b10000000);
				byte[] array8 = array[2];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR8[13] << 6 & (int)BinaryDefine.b01000000);
				byte[] array9 = array[2];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR8[15] << 5 & (int)BinaryDefine.b00100000);
				byte[] array10 = array[2];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR8[16] << 4 & (int)BinaryDefine.b00010000);
				byte[] array11 = array[2];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR8[17] << 3 & (int)BinaryDefine.b00001000);
				byte[] array12 = array[2];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR8[18] << 2 & (int)BinaryDefine.b00000100);
				byte[] array13 = array[2];
				int num11 = 2;
				array13[num11] |= (byte)(userSettingR8[23] << 1 & (int)BinaryDefine.b00000010);
				byte[] array14 = array[2];
				int num12 = 1;
				array14[num12] |= (byte)(userSettingR8[7] << 7 & (int)BinaryDefine.b10000000);
				byte[] array15 = array[2];
				int num13 = 1;
				array15[num13] |= (byte)(userSettingR8[69] << 3 & (int)BinaryDefine.b00001000);
				byte[] array16 = array[2];
				int num14 = 1;
				array16[num14] |= (byte)(userSettingR8[78] << 2 & (int)BinaryDefine.b00000100);
				byte[] array17 = array[2];
				int num15 = 1;
				array17[num15] |= (byte)(userSettingR8[85] << 1 & (int)BinaryDefine.b00000010);
				byte[] array18 = array[2];
				int num16 = 1;
				array18[num16] |= (byte)(userSettingR8[87] & (int)BinaryDefine.b00000001);
				byte[] array19 = array[2];
				int num17 = 0;
				array19[num17] |= (byte)(userSettingR8[89] << 4 & (int)BinaryDefine.b01110000);
				byte[] array20 = array[2];
				int num18 = 0;
				array20[num18] |= (byte)(userSettingR8[90] & (int)BinaryDefine.b00001111);
				byte b;
				if (userSettingR8[60] == 1)
				{
					b = (byte)(userSettingR8[79] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[79] / 10);
				}
				byte[] array21 = array[1];
				int num19 = 2;
				array21[num19] |= (byte)(userSettingR8[60] << 7 & (int)BinaryDefine.b10000000);
				byte[] array22 = array[1];
				int num20 = 2;
				array22[num20] |= (byte)(userSettingR8[84] << 5 & (int)BinaryDefine.b00100000);
				byte[] array23 = array[1];
				int num21 = 2;
				array23[num21] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR8[60] == 1)
				{
					b = (byte)(userSettingR8[11] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[11] / 10);
				}
				byte[] array24 = array[1];
				int num22 = 3;
				array24[num22] |= (byte)(userSettingR8[86] << 6 & (int)BinaryDefine.b01000000);
				byte[] array25 = array[1];
				int num23 = 3;
				array25[num23] |= (byte)(userSettingR8[20] << 5 & (int)BinaryDefine.b00100000);
				byte[] array26 = array[1];
				int num24 = 3;
				array26[num24] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR8[60] == 1)
				{
					b = (byte)(userSettingR8[82] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[82] / 10);
				}
				byte[] array27 = array[1];
				int num25 = 1;
				array27[num25] |= (byte)(userSettingR8[8] << 6 & (int)BinaryDefine.b01000000);
				byte[] array28 = array[1];
				int num26 = 1;
				array28[num26] |= (byte)(userSettingR8[10] << 5 & (int)BinaryDefine.b00100000);
				byte[] array29 = array[1];
				int num27 = 1;
				array29[num27] |= unchecked((byte)(b & BinaryDefine.b00011111));
				b = (byte)(userSettingR8[83] + 12);
				byte[] array30 = array[1];
				int num28 = 0;
				array30[num28] |= (byte)(userSettingR8[58] << 5 & (int)BinaryDefine.b11100000);
				byte[] array31 = array[1];
				int num29 = 0;
				array31[num29] |= unchecked((byte)(b & BinaryDefine.b00011111));
				byte[] array32 = array[3];
				int num30 = 3;
				array32[num30] |= (byte)(userSettingR8[41] << 6 & (int)BinaryDefine.b01000000);
				byte[] array33 = array[3];
				int num31 = 3;
				array33[num31] |= (byte)(userSettingR8[14] << 5 & (int)BinaryDefine.b00100000);
				byte[] array34 = array[3];
				int num32 = 3;
				array34[num32] |= (byte)(userSettingR8[40] << 3 & (int)BinaryDefine.b00011000);
				byte[] array35 = array[3];
				int num33 = 3;
				array35[num33] |= (byte)(userSettingR8[70] & (int)BinaryDefine.b00000111);
				byte[] array36 = array[3];
				int num34 = 2;
				array36[num34] |= (byte)(userSettingR8[21] << 7 & (int)BinaryDefine.b10000000);
				byte[] array37 = array[3];
				int num35 = 2;
				array37[num35] |= (byte)(userSettingR8[2] << 3 & (int)BinaryDefine.b00111000);
				byte[] array38 = array[3];
				int num36 = 2;
				array38[num36] |= (byte)(userSettingR8[3] & (int)BinaryDefine.b00000111);
				byte[] array39 = array[3];
				int num37 = 1;
				array39[num37] |= (byte)(userSettingR8[27] << 6 & (int)BinaryDefine.b11000000);
				byte[] array40 = array[3];
				int num38 = 1;
				array40[num38] |= (byte)(userSettingR8[39] << 3 & (int)BinaryDefine.b00001000);
				byte[] array41 = array[3];
				int num39 = 1;
				array41[num39] |= (byte)(userSettingR8[4] & (int)BinaryDefine.b00000111);
				byte[] array42 = array[3];
				int num40 = 0;
				array42[num40] |= (byte)(userSettingR8[38] << 7 & (int)BinaryDefine.b10000000);
				byte[] array43 = array[3];
				int num41 = 0;
				array43[num41] |= (byte)(userSettingR8[37] << 6 & (int)BinaryDefine.b01000000);
				byte[] array44 = array[3];
				int num42 = 0;
				array44[num42] |= (byte)(userSettingR8[36] << 5 & (int)BinaryDefine.b00100000);
				byte[] array45 = array[3];
				int num43 = 0;
				array45[num43] |= (byte)(userSettingR8[35] << 4 & (int)BinaryDefine.b00010000);
				byte[] array46 = array[3];
				int num44 = 0;
				array46[num44] |= (byte)(userSettingR8[34] << 3 & (int)BinaryDefine.b00001000);
				byte[] array47 = array[3];
				int num45 = 0;
				array47[num45] |= (byte)(userSettingR8[33] << 2 & (int)BinaryDefine.b00000100);
				byte[] array48 = array[3];
				int num46 = 0;
				array48[num46] |= (byte)(userSettingR8[32] << 1 & (int)BinaryDefine.b00000010);
				byte[] array49 = array[3];
				int num47 = 0;
				array49[num47] |= (byte)(userSettingR8[31] & (int)BinaryDefine.b00000001);
				byte[] array50 = array[4];
				int num48 = 3;
				array50[num48] |= (byte)(userSettingR8[73] << 6 & (int)BinaryDefine.b01000000);
				byte[] array51 = array[4];
				int num49 = 3;
				array51[num49] |= (byte)(userSettingR8[75] << 3 & (int)BinaryDefine.b00111000);
				byte[] array52 = array[4];
				int num50 = 3;
				array52[num50] |= (byte)(userSettingR8[77] & (int)BinaryDefine.b00000111);
				byte[] array53 = array[4];
				int num51 = 2;
				array53[num51] |= (byte)(userSettingR8[61] << 4 & (int)BinaryDefine.b11110000);
				byte[] array54 = array[4];
				int num52 = 2;
				array54[num52] |= (byte)(userSettingR8[62] & (int)BinaryDefine.b00001111);
				byte[] array55 = array[4];
				int num53 = 1;
				array55[num53] |= (byte)(userSettingR8[68] << 4 & (int)BinaryDefine.b11110000);
				byte[] array56 = array[4];
				int num54 = 1;
				array56[num54] |= (byte)(userSettingR8[66] & (int)BinaryDefine.b00001111);
				byte[] array57 = array[5];
				int num55 = 3;
				array57[num55] |= (byte)(userSettingR8[67] << 4 & (int)BinaryDefine.b01110000);
				byte[] array58 = array[5];
				int num56 = 3;
				array58[num56] |= (byte)(userSettingR8[64] & (int)BinaryDefine.b00001111);
				byte[] array59 = array[5];
				int num57 = 2;
				array59[num57] |= (byte)(userSettingR8[29] << 6 & (int)BinaryDefine.b11000000);
				byte[] array60 = array[5];
				int num58 = 2;
				array60[num58] |= (byte)(userSettingR8[42] << 5 & (int)BinaryDefine.b00100000);
				byte[] array61 = array[5];
				int num59 = 2;
				array61[num59] |= (byte)(userSettingR8[72] & (int)BinaryDefine.b00000111);
				byte[] array62 = array[5];
				int num60 = 1;
				array62[num60] |= (byte)(userSettingR8[43] << 7 & (int)BinaryDefine.b10000000);
				byte[] array63 = array[5];
				int num61 = 1;
				array63[num61] |= (byte)(userSettingR8[47] << 3 & (int)BinaryDefine.b00111000);
				byte[] array64 = array[5];
				int num62 = 1;
				array64[num62] |= (byte)(userSettingR8[46] & (int)BinaryDefine.b00000111);
				byte[] array65 = array[5];
				int num63 = 0;
				array65[num63] |= (byte)(userSettingR8[0] << 7 & (int)BinaryDefine.b10000000);
				byte[] array66 = array[5];
				int num64 = 0;
				array66[num64] |= (byte)(userSettingR8[80] << 6 & (int)BinaryDefine.b01000000);
				byte[] array67 = array[5];
				int num65 = 0;
				array67[num65] |= (byte)(userSettingR8[50] << 3 & (int)BinaryDefine.b00111000);
				byte[] array68 = array[5];
				int num66 = 0;
				array68[num66] |= (byte)(userSettingR8[48] & (int)BinaryDefine.b00000111);
				byte[] array69 = array[6];
				int num67 = 3;
				array69[num67] |= (byte)(userSettingR8[52] << 4 & (int)BinaryDefine.b11110000);
				byte[] array70 = array[6];
				int num68 = 3;
				array70[num68] |= (byte)(userSettingR8[51] & (int)BinaryDefine.b00001111);
				byte[] array71 = array[6];
				int num69 = 2;
				array71[num69] |= (byte)(userSettingR8[55] << 4 & (int)BinaryDefine.b11110000);
				byte[] array72 = array[6];
				int num70 = 2;
				array72[num70] |= (byte)(userSettingR8[53] & (int)BinaryDefine.b00001111);
				byte[] array73 = array[6];
				int num71 = 1;
				array73[num71] |= (byte)(userSettingR8[24] << 5 & (int)BinaryDefine.b01100000);
				byte[] array74 = array[6];
				int num72 = 1;
				array74[num72] |= (byte)(userSettingR8[57] << 4 & (int)BinaryDefine.b00010000);
				byte[] array75 = array[6];
				int num73 = 1;
				array75[num73] |= (byte)(userSettingR8[6] & (int)BinaryDefine.b00001111);
				byte[] array76 = array[6];
				int num74 = 0;
				array76[num74] |= (byte)(userSettingR8[9] << 5 & (int)BinaryDefine.b11100000);
				byte[] array77 = array[6];
				int num75 = 0;
				array77[num75] |= (byte)(userSettingR8[81] << 1 & (int)BinaryDefine.b00011110);
				byte[] array78 = array[6];
				int num76 = 0;
				array78[num76] |= (byte)(userSettingR8[71] & (int)BinaryDefine.b00000001);
				byte[] array79 = array[7];
				int num77 = 3;
				array79[num77] |= (byte)(userSettingR8[76] << 4 & (int)BinaryDefine.b11110000);
				byte[] array80 = array[7];
				int num78 = 3;
				array80[num78] |= (byte)(userSettingR8[74] & (int)BinaryDefine.b00001111);
				if (userSettingR8[60] == 1)
				{
					b = (byte)(userSettingR8[5] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[5] / 10);
				}
				byte[] array81 = array[7];
				int num79 = 2;
				array81[num79] |= (byte)((int)b << 4 & (int)BinaryDefine.b11110000);
				byte[] array82 = array[7];
				int num80 = 2;
				array82[num80] |= (byte)(userSettingR8[59] << 2 & (int)BinaryDefine.b00001100);
				byte[] array83 = array[7];
				int num81 = 2;
				array83[num81] |= (byte)(userSettingR8[1] & (int)BinaryDefine.b00000011);
				byte[] array84 = array[7];
				int num82 = 1;
				array84[num82] |= (byte)(userSettingR8[65] << 4 & (int)BinaryDefine.b11110000);
				byte[] array85 = array[7];
				int num83 = 1;
				array85[num83] |= (byte)(userSettingR8[12] << 3 & (int)BinaryDefine.b00001000);
				byte[] array86 = array[7];
				int num84 = 1;
				array86[num84] |= (byte)(userSettingR8[28] << 1 & (int)BinaryDefine.b00000110);
				byte[] array87 = array[7];
				int num85 = 1;
				array87[num85] |= (byte)(userSettingR8[22] & (int)BinaryDefine.b00000001);
				byte[] array88 = array[7];
				int num86 = 0;
				array88[num86] |= (byte)(userSettingR8[49] << 4 & (int)BinaryDefine.b01110000);
				byte[] array89 = array[7];
				int num87 = 0;
				array89[num87] |= (byte)(userSettingR8[54] & (int)BinaryDefine.b00001111);
				byte[] array90 = array[8];
				int num88 = 3;
				array90[num88] |= (byte)(userSettingR8[56] << 3 & (int)BinaryDefine.b00011000);
				byte[] array91 = array[8];
				int num89 = 3;
				array91[num89] |= (byte)(userSettingR8[63] & (int)BinaryDefine.b00000111);
				byte[] array92 = array[8];
				int num90 = 2;
				array92[num90] |= (byte)(userSettingR8[19] & (int)BinaryDefine.b00000001);
				Array.Copy(receivedNVData, array2, receivedNVData.Length);
				for (int i = 0; i < array.Length; i++)
				{
					for (int j = 0; j < array[i].Length; j++)
					{
						byte[] array93 = array2;
						int num91 = i * 4 + j;
						array93[num91] &= unchecked((byte)(~this.userNVDataPos[i * 4 + j]));
						byte[] array94 = array2;
						int num92 = i * 4 + j;
						array94[num92] |= array[i][j];
					}
				}
				array2[256] = (byte)userSettingR8[88];
				int num93 = 0;
				for (int i = 0; i < receivedNVData.Length; i++)
				{
					if (receivedNVData[i] != array2[i])
					{
						num93++;
					}
				}
				return array2;
			}

			// Token: 0x040006E1 RID: 1761
			private int supportVersion = 124;

			// Token: 0x040006E2 RID: 1762
			private int menuCnt = 91;

			// Token: 0x040006E3 RID: 1763
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
				207,
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
				127,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				0,
				0,
				1,
				31,
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

			// Token: 0x040006E4 RID: 1764
			private const int memoryQuotaPos = 256;

			// Token: 0x040006E5 RID: 1765
			private const int HEADER = 0;

			// Token: 0x040006E6 RID: 1766
			private const int GPS = 1;

			// Token: 0x040006E7 RID: 1767
			private const int RD_1 = 2;

			// Token: 0x040006E8 RID: 1768
			private const int RD_2 = 3;

			// Token: 0x040006E9 RID: 1769
			private const int RD_3 = 4;

			// Token: 0x040006EA RID: 1770
			private const int RD_4 = 5;

			// Token: 0x040006EB RID: 1771
			private const int RD_5 = 6;

			// Token: 0x040006EC RID: 1772
			private const int RD_6 = 7;

			// Token: 0x040006ED RID: 1773
			private const int RD_7 = 8;

			// Token: 0x040006EE RID: 1774
			private const int ADDR_CNT = 9;

			// Token: 0x020000C0 RID: 192
			private enum MENU
			{
				// Token: 0x04000CA0 RID: 3232
				MENU_MODE,
				// Token: 0x04000CA1 RID: 3233
				DETECTION_MODE,
				// Token: 0x04000CA2 RID: 3234
				X_SENSITIVE,
				// Token: 0x04000CA3 RID: 3235
				K_SENSITIVE,
				// Token: 0x04000CA4 RID: 3236
				KA_SENSITIVE,
				// Token: 0x04000CA5 RID: 3237
				AUTO_CITY_SPEED,
				// Token: 0x04000CA6 RID: 3238
				REAR_ATTENUATION,
				// Token: 0x04000CA7 RID: 3239
				GPS_ENABLE,
				// Token: 0x04000CA8 RID: 3240
				SPEED_CAMERA_ENABLE,
				// Token: 0x04000CA9 RID: 3241
				SPEED_CAMERA_ALERT_RANGE,
				// Token: 0x04000CAA RID: 3242
				RLC_ENABLE,
				// Token: 0x04000CAB RID: 3243
				RLC_QRIDE,
				// Token: 0x04000CAC RID: 3244
				POI_PASSCHIME,
				// Token: 0x04000CAD RID: 3245
				VOICE_ENABLE,
				// Token: 0x04000CAE RID: 3246
				KA_FREQ_VOICE,
				// Token: 0x04000CAF RID: 3247
				X_BAND_ENABLE,
				// Token: 0x04000CB0 RID: 3248
				K_BAND_ENABLE,
				// Token: 0x04000CB1 RID: 3249
				KA_BAND_ENABLE,
				// Token: 0x04000CB2 RID: 3250
				LASER_ENABLE,
				// Token: 0x04000CB3 RID: 3251
				LASER_GUN_ID_ENABLE,
				// Token: 0x04000CB4 RID: 3252
				K_POP_ENABLE,
				// Token: 0x04000CB5 RID: 3253
				MRCD_ENABLE,
				// Token: 0x04000CB6 RID: 3254
				GATSO_ENABLE,
				// Token: 0x04000CB7 RID: 3255
				KA_POP_ENABLE,
				// Token: 0x04000CB8 RID: 3256
				K_FILTER_ENABLE,
				// Token: 0x04000CB9 RID: 3257
				KA_FILTER_ENABLE,
				// Token: 0x04000CBA RID: 3258
				TSF_ENABLE,
				// Token: 0x04000CBB RID: 3259
				K_BLOCK_FILTER_1_MODE,
				// Token: 0x04000CBC RID: 3260
				K_BLOCK_FILTER_2_MODE,
				// Token: 0x04000CBD RID: 3261
				K_NARROW,
				// Token: 0x04000CBE RID: 3262
				KA_NARROW,
				// Token: 0x04000CBF RID: 3263
				KA_SEG1,
				// Token: 0x04000CC0 RID: 3264
				KA_SEG2,
				// Token: 0x04000CC1 RID: 3265
				KA_SEG3,
				// Token: 0x04000CC2 RID: 3266
				KA_SEG4,
				// Token: 0x04000CC3 RID: 3267
				KA_SEG5,
				// Token: 0x04000CC4 RID: 3268
				KA_SEG6,
				// Token: 0x04000CC5 RID: 3269
				KA_SEG7,
				// Token: 0x04000CC6 RID: 3270
				KA_SEG8,
				// Token: 0x04000CC7 RID: 3271
				KA_SEG9,
				// Token: 0x04000CC8 RID: 3272
				PRIORITY_MODE,
				// Token: 0x04000CC9 RID: 3273
				MUTE_MEM_BAND_OPTION,
				// Token: 0x04000CCA RID: 3274
				AUTO_MUTE_MEM_ENABLE,
				// Token: 0x04000CCB RID: 3275
				AUTO_MUTE_MEM_BAND_OPTION,
				// Token: 0x04000CCC RID: 3276
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x04000CCD RID: 3277
				BACKGROUND_COLOR,
				// Token: 0x04000CCE RID: 3278
				X_BAND_ARROW_COLOR,
				// Token: 0x04000CCF RID: 3279
				K_BAND_ARROW_COLOR,
				// Token: 0x04000CD0 RID: 3280
				MRCD_ARROW_COLOR,
				// Token: 0x04000CD1 RID: 3281
				GATSO_ARROW_COLOR,
				// Token: 0x04000CD2 RID: 3282
				KA_BAND_ARROW_COLOR,
				// Token: 0x04000CD3 RID: 3283
				X_BAND_COLOR,
				// Token: 0x04000CD4 RID: 3284
				K_BAND_COLOR,
				// Token: 0x04000CD5 RID: 3285
				MRCD_COLOR,
				// Token: 0x04000CD6 RID: 3286
				GATSO_COLOR,
				// Token: 0x04000CD7 RID: 3287
				KA_BAND_COLOR,
				// Token: 0x04000CD8 RID: 3288
				MAIN_DISPLAY,
				// Token: 0x04000CD9 RID: 3289
				HEARTBEAT_ICON_ENABLE,
				// Token: 0x04000CDA RID: 3290
				LEFT_DISPLAY,
				// Token: 0x04000CDB RID: 3291
				ALERT_DISPLAY,
				// Token: 0x04000CDC RID: 3292
				SPEED_UNIT,
				// Token: 0x04000CDD RID: 3293
				X_BAND_ALERT_TONE,
				// Token: 0x04000CDE RID: 3294
				K_BAND_ALERT_TONE,
				// Token: 0x04000CDF RID: 3295
				K_BAND_BOGEY_TONE,
				// Token: 0x04000CE0 RID: 3296
				MRCD_ALERT_TONE,
				// Token: 0x04000CE1 RID: 3297
				GATSO_ALERT_TONE,
				// Token: 0x04000CE2 RID: 3298
				KA_BAND_ALERT_TONE,
				// Token: 0x04000CE3 RID: 3299
				KA_BAND_BOGEY_TONE,
				// Token: 0x04000CE4 RID: 3300
				LASER_ALERT_TONE,
				// Token: 0x04000CE5 RID: 3301
				AUTO_MUTE_ENABLE,
				// Token: 0x04000CE6 RID: 3302
				AUTO_MUTE_VOLUME,
				// Token: 0x04000CE7 RID: 3303
				REAR_K_BAND_MUTE_ENABLE,
				// Token: 0x04000CE8 RID: 3304
				DARK_MODE_BRIGHTNESS,
				// Token: 0x04000CE9 RID: 3305
				AUTO_DIM_SET_MODE_SELECT,
				// Token: 0x04000CEA RID: 3306
				AUTO_DIM_SET_BRIGHT_TIME,
				// Token: 0x04000CEB RID: 3307
				AUTO_DIM_SET_BRIGHT_BRIGHTNESS,
				// Token: 0x04000CEC RID: 3308
				AUTO_DIM_SET_DIM_TIME,
				// Token: 0x04000CED RID: 3309
				AUTO_DIM_SET_DIM_BRIGHTNESS,
				// Token: 0x04000CEE RID: 3310
				BACKLIGHT_MODE,
				// Token: 0x04000CEF RID: 3311
				QRIDE_MODE,
				// Token: 0x04000CF0 RID: 3312
				MRCD_QRIDE_ENABLE,
				// Token: 0x04000CF1 RID: 3313
				QRIDE_VOLUME,
				// Token: 0x04000CF2 RID: 3314
				LIMIT_SPEED_MODE,
				// Token: 0x04000CF3 RID: 3315
				GMT,
				// Token: 0x04000CF4 RID: 3316
				DST_ENABLE,
				// Token: 0x04000CF5 RID: 3317
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x04000CF6 RID: 3318
				VEHICLE_BATT_SAVER_ENABLE,
				// Token: 0x04000CF7 RID: 3319
				SELF_TEST_ENABLE,
				// Token: 0x04000CF8 RID: 3320
				MEMORY_QUOTA,
				// Token: 0x04000CF9 RID: 3321
				MAIN_DIM_SET,
				// Token: 0x04000CFA RID: 3322
				MAIN_VOLUME
			}
		}
	}
}
