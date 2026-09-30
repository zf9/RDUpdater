using System;
using System.Linq;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000024 RID: 36
	internal static class UserSettingR4W
	{
		// Token: 0x04000332 RID: 818
		public static UserSettingFormat[] user_setting = new UserSettingFormat[]
		{
			new UserSettingR4W.v114()
		};

		// Token: 0x02000089 RID: 137
		private class v114 : UserSettingFormat
		{
			// Token: 0x060002AB RID: 683 RVA: 0x000293AE File Offset: 0x000275AE
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x060002AC RID: 684 RVA: 0x000293B6 File Offset: 0x000275B6
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x060002AD RID: 685 RVA: 0x000293BE File Offset: 0x000275BE
			public byte[] GetNVDataMask()
			{
				return this.userNVDataPos;
			}

			// Token: 0x060002AE RID: 686 RVA: 0x000293C6 File Offset: 0x000275C6
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return op_mode != 1 && op_mode != 2 && op_mode != 3 && op_mode != 7;
			}

			// Token: 0x060002AF RID: 687 RVA: 0x000293DC File Offset: 0x000275DC
			public int user_k_block_get_level(int strength, int mode)
			{
				if (mode == 0)
				{
					if (strength <= 87)
					{
						return 8;
					}
					if (strength <= 95)
					{
						return 9;
					}
					if (strength <= 103)
					{
						return 10;
					}
					if (strength <= 111)
					{
						return 11;
					}
					if (strength <= 117)
					{
						return 12;
					}
					if (strength <= 123)
					{
						return 13;
					}
					if (strength <= 124)
					{
						return 14;
					}
					if (strength <= 125)
					{
						return 15;
					}
					if (strength <= 126)
					{
						return 16;
					}
					return 17;
				}
				else
				{
					if (strength <= 46)
					{
						return 8;
					}
					if (strength <= 55)
					{
						return 9;
					}
					if (strength <= 64)
					{
						return 10;
					}
					if (strength <= 74)
					{
						return 11;
					}
					if (strength <= 84)
					{
						return 12;
					}
					if (strength <= 95)
					{
						return 13;
					}
					if (strength <= 106)
					{
						return 14;
					}
					if (strength <= 117)
					{
						return 15;
					}
					if (strength <= 128)
					{
						return 16;
					}
					return 17;
				}
			}

			// Token: 0x060002B0 RID: 688 RVA: 0x00029484 File Offset: 0x00027684
			public int user_k_block_get_raw_strength(int level, int mode)
			{
				if (mode == 0)
				{
					if (level == 8)
					{
						return 87;
					}
					if (level == 9)
					{
						return 95;
					}
					if (level == 10)
					{
						return 103;
					}
					if (level == 11)
					{
						return 111;
					}
					if (level == 12)
					{
						return 117;
					}
					if (level == 13)
					{
						return 123;
					}
					if (level == 14)
					{
						return 124;
					}
					if (level == 15)
					{
						return 125;
					}
					if (level == 16)
					{
						return 126;
					}
					return 255;
				}
				else
				{
					if (level == 8)
					{
						return 46;
					}
					if (level == 9)
					{
						return 55;
					}
					if (level == 10)
					{
						return 64;
					}
					if (level == 11)
					{
						return 74;
					}
					if (level == 12)
					{
						return 84;
					}
					if (level == 13)
					{
						return 95;
					}
					if (level == 14)
					{
						return 106;
					}
					if (level == 15)
					{
						return 117;
					}
					if (level == 16)
					{
						return 128;
					}
					return 255;
				}
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x0002953C File Offset: 0x0002773C
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
				}, "Highway - Full Sensitivity\nCity - X and K sensitivity reduced. Ka band sensitivity same as Highway.\nAdvanced - User adjusts X, K, and Ka band sensitivity from 100%~30% in 10% intervals.\nAuto City - The R4w will automatically switch between Highway and City depending on the speed limits set in the Auto City Speed menu.");
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
				}, "Sets the speed at which the R4w changes from City mode to Highway mode and back.\n(Detection Mode - Auto City)");
				array[6] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "BT/WIFI", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to connect applications that support the radar detector.");
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
				array[22] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Gatso RT3/4 On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates detection for Gatso radar guns.");
				UserSettingMenu[] array6 = array;
				int num3 = 23;
				UserSettingMenu.MENU_TYPE menuType3 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString3 = "Ka POP On/Off";
				int[] array7 = new int[2];
				array7[0] = 1;
				array6[num3] = new UserSettingMenu(menuType3, menuString3, array7, new string[]
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
				UserSettingMenu[] array8 = array;
				int num4 = 25;
				UserSettingMenu.MENU_TYPE menuType4 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString4 = "Ka Filter";
				int[] array9 = new int[2];
				array9[0] = 1;
				array8[num4] = new UserSettingMenu(menuType4, menuString4, array9, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the Ka band to prevent false detections.");
				UserSettingMenu[] array10 = array;
				int num5 = 26;
				UserSettingMenu.MENU_TYPE menuType5 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString5 = "TSF";
				int[] array11 = new int[2];
				array11[0] = 1;
				array10[num5] = new UserSettingMenu(menuType5, menuString5, array11, new string[]
				{
					"Off",
					"On"
				}, "Traffic Sensor Filter. Prevents false alarms caused by traffic monitoring radar systems.");
				int[] array12 = new int[351];
				string[] array13 = new string[351];
				for (int i = 0; i < 351; i++)
				{
					array12[i] = 23900 + i;
					array13[i] = array12[i].ToString();
				}
				array[27] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block1 Filter Mode", new int[]
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
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set K Block1 Filter operation mode.");
				array[28] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[29] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter Minimum Frequency", array12, array13, "Set K Block1 Filter minimum frequency.");
				array[30] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter Maximum Frequency", array12, array13, "Set K Block1 Filter maximum frequency.");
				array[31] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block2 Filter Mode", new int[]
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
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set K Block2 Filter operation mode.");
				array[32] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[33] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter Minimum Frequency", array12, array13, "Set K Block2 Filter minimum frequency.");
				array[34] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter Maximum Frequency", array12, array13, "Set K Block2 Filter maximum frequency.");
				array[35] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block3 Filter Mode", new int[]
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
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set K Block3 Filter operation mode.");
				array[36] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[37] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter Minimum Frequency", array12, array13, "Set K Block3 Filter minimum frequency.");
				array[38] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter Maximum Frequency", array12, array13, "Set K Block3 Filter maximum frequency.");
				array[39] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block1 Filter Mode", new int[]
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
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set User K Block1 Filter operation mode.");
				array[40] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[41] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block1 Filter Minimum Frequency", array12, array13, "Set User K Block1 Filter minimum frequency.");
				array[42] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block1 Filter Maximum Frequency", array12, array13, "Set User K Block1 Filter maximum frequency.");
				array[43] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block2 Filter Mode", new int[]
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
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set User K Block2 Filter operation mode.");
				array[44] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[45] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block2 Filter Minimum Frequency", array12, array13, "Set User K Block2 Filter minimum frequency.");
				array[46] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block2 Filter Maximum Frequency", array12, array13, "Set User K Block2 Filter maximum frequency.");
				array[47] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block3 Filter Mode", new int[]
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
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set User K Block3 Filter operation mode.");
				array[48] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[49] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block3 Filter Minimum Frequency", array12, array13, "Set User K Block3 Filter minimum frequency.");
				array[50] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block3 Filter Maximum Frequency", array12, array13, "Set User K Block3 Filter maximum frequency.");
				array[51] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block4 Filter Mode", new int[]
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
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set User K Block4 Filter operation mode.");
				array[52] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[53] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block4 Filter Minimum Frequency", array12, array13, "Set User K Block4 Filter minimum frequency.");
				array[54] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block4 Filter Maximum Frequency", array12, array13, "Set User K Block4 Filter maximum frequency.");
				array[55] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block5 Filter Mode", new int[]
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
					"Weak",
					"Max",
					"Mute",
					"Off"
				}, "Set User K Block5 Filter operation mode.");
				array[56] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[57] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block5 Filter Minimum Frequency", array12, array13, "Set User K Block5 Filter minimum frequency.");
				array[58] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block5 Filter Maximum Frequency", array12, array13, "Set User K Block5 Filter maximum frequency.");
				array[59] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Narrow/Wide/Extended", new int[]
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
				array[60] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Narrow/Wide/Segmentation", new int[]
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
				int num6 = 61;
				UserSettingMenu.MENU_TYPE menuType6 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString6 = "Ka Segmentation 33.399Ghz – 33.705Ghz";
				int[] array15 = new int[2];
				array15[0] = 1;
				array14[num6] = new UserSettingMenu(menuType6, menuString6, array15, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.399Ghz – 33.705Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array16 = array;
				int num7 = 62;
				UserSettingMenu.MENU_TYPE menuType7 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString7 = "Ka Segmentation 33.705Ghz – 33.903Ghz";
				int[] array17 = new int[2];
				array17[0] = 1;
				array16[num7] = new UserSettingMenu(menuType7, menuString7, array17, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.705Ghz – 33.903Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array18 = array;
				int num8 = 63;
				UserSettingMenu.MENU_TYPE menuType8 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString8 = "Ka Segmentation 33.903Ghz – 34.191Ghz";
				int[] array19 = new int[2];
				array19[0] = 1;
				array18[num8] = new UserSettingMenu(menuType8, menuString8, array19, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.903Ghz – 34.191Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array20 = array;
				int num9 = 64;
				UserSettingMenu.MENU_TYPE menuType9 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString9 = "Ka Segmentation 34.191Ghz – 34.587Ghz";
				int[] array21 = new int[2];
				array21[0] = 1;
				array20[num9] = new UserSettingMenu(menuType9, menuString9, array21, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.191Ghz – 34.587Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array22 = array;
				int num10 = 65;
				UserSettingMenu.MENU_TYPE menuType10 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString10 = "Ka Segmentation 34.587Ghz – 34.803Ghz";
				int[] array23 = new int[2];
				array23[0] = 1;
				array22[num10] = new UserSettingMenu(menuType10, menuString10, array23, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.587Ghz – 34.803Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array24 = array;
				int num11 = 66;
				UserSettingMenu.MENU_TYPE menuType11 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString11 = "Ka Segmentation 34.803Ghz – 35.163Ghz";
				int[] array25 = new int[2];
				array25[0] = 1;
				array24[num11] = new UserSettingMenu(menuType11, menuString11, array25, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.803Ghz – 35.163Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array26 = array;
				int num12 = 67;
				UserSettingMenu.MENU_TYPE menuType12 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString12 = "Ka Segmentation 35.163Ghz – 35.379Ghz";
				int[] array27 = new int[2];
				array27[0] = 1;
				array26[num12] = new UserSettingMenu(menuType12, menuString12, array27, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.163Ghz – 35.379Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array28 = array;
				int num13 = 68;
				UserSettingMenu.MENU_TYPE menuType13 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString13 = "Ka Segmentation 35.379Ghz – 35.613Ghz";
				int[] array29 = new int[2];
				array29[0] = 1;
				array28[num13] = new UserSettingMenu(menuType13, menuString13, array29, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.379Ghz – 35.613Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array30 = array;
				int num14 = 69;
				UserSettingMenu.MENU_TYPE menuType14 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString14 = "Ka Segmentation 35.613Ghz – 35.701Ghz";
				int[] array31 = new int[2];
				array31[0] = 1;
				array30[num14] = new UserSettingMenu(menuType14, menuString14, array31, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.613Ghz – 35.701Ghz (Ka Segmentation mode)");
				array[70] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Priority", new int[]
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
				array[71] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Select bands to be muted.");
				array[72] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute Memory On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "This menu turns the ability to automatically save mute requests for specific locations/frequency bands.");
				array[73] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Auto Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Auto Mute Memory Band Option Set specifies which bands will be muted.");
				UserSettingMenu[] array32 = array;
				int num15 = 74;
				UserSettingMenu.MENU_TYPE menuType15 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString15 = "All Threat Display";
				int[] array33 = new int[2];
				array33[0] = 1;
				array32[num15] = new UserSettingMenu(menuType15, menuString15, array33, new string[]
				{
					"Off",
					"On"
				}, "Displays if more than one radar signals are detected at the same time. The signal with the strongest radar signal is considered the main signal. The other signals are displayed on the left side.");
				array[75] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Background Color", new int[]
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
				array[76] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Color", new int[]
				{
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
					"Signal"
				}, "Set X band indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[77] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Color", new int[]
				{
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
					"Signal"
				}, "Set K band indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[78] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD/T Color", new int[]
				{
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
					"Signal"
				}, "Set MRCD/T indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[79] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "GATSO RT3/4 Color", new int[]
				{
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
					"Signal"
				}, "Set Gatso RT3/4 indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[80] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Color", new int[]
				{
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
					"Signal"
				}, "Set Ka band indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[81] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Display", new int[]
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
				array[82] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Scan Icon", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Scan Icon displays to indicate the end of a scan cycle.");
				array[83] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Left Display", new int[]
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
				UserSettingMenu[] array34 = array;
				int num16 = 84;
				UserSettingMenu.MENU_TYPE menuType16 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString16 = "Alert Display";
				int[] array35 = new int[2];
				array35[0] = 1;
				array34[num16] = new UserSettingMenu(menuType16, menuString16, array35, new string[]
				{
					"Type 1",
					"Type 2"
				}, "Select one of two OLED display formats.");
				UserSettingMenu[] array36 = array;
				int num17 = 85;
				UserSettingMenu.MENU_TYPE menuType17 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString17 = "Speed Unit";
				int[] array37 = new int[2];
				array37[0] = 1;
				array36[num17] = new UserSettingMenu(menuType17, menuString17, array37, new string[]
				{
					"mph",
					"km/h"
				}, "Select the speed measurement type.");
				array[85].isUnitMenuFlag = true;
				array[86] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "X Band Alert Tone", new int[]
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
				array[87] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Alert Tone", new int[]
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
				array[88] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Tone", new int[]
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
				array[89] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Level", new int[]
				{
					1,
					2,
					3,
					4,
					5
				}, new string[]
				{
					"Level 1",
					"Level 2",
					"Level 3",
					"Level 4",
					"Level 5"
				}, "Set a level for K band bogey alarm.");
				array[90] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "MRCD/T Alert Tone", new int[]
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
				array[91] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "GATSO RT3/4 Alert Tone", new int[]
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
				array[92] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Alert Tone", new int[]
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
				array[93] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Bogey Tone", new int[]
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
				array[94] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Laser Alert Tone", new int[]
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
				array[95] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Alert Level", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5
				}, new string[]
				{
					"Off",
					"Level 1",
					"Level 2",
					"Level 3",
					"Level 4",
					"Level 5"
				}, "When a signal below the Auto Mute Alert Level is detected, set the volume to Auto Mute Volume.Auto Mute reduces alarm level to Auto Mute Volume after 3 seconds and returns to normal operation(Auto Mute = OFF) 10 seconds after the alert ends.If the same alarm sounds within the 10 second period, Auto Mute remains at Auto Mute Volume level.The unit returns to normal operation(Auto Mute = OFF) if a different band is detected during Auto Mute = ON mode.");
				array[96] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Volume", new int[]
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
				int num18 = 97;
				UserSettingMenu.MENU_TYPE menuType18 = UserSettingMenu.MENU_TYPE.SOUND;
				string menuString18 = "Alert Temporary Volume";
				int[] array39 = new int[2];
				array39[0] = 1;
				array38[num18] = new UserSettingMenu(menuType18, menuString18, array39, new string[]
				{
					"Off",
					"On"
				}, "Temporary volume function On/Off.");
				array[98] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Dark mode Brightness", new int[]
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
				array[99] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Mode", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Time",
					"Sensor"
				}, "Set the start times for the OLED to automatically brighten or dim.\nSelecting Time will let you set specific times when you want the OLED to get brighter or dimmer.\nSelecting Sensor will let the ambient light levels trigger when the OLED will get brighter or dimmer.");
				array[100] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Time", new int[]
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
				array[101] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Brightness", new int[]
				{
					4,
					3,
					2
				}, new string[]
				{
					"Bright",
					"Dim",
					"Dimmer"
				}, "The R4w has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[102] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Time", new int[]
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
				array[103] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Brightness", new int[]
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
				}, "The R4w has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[104] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Backlight On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns the front key backlight on and off.");
				array[105] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Quiet Ride", new int[][]
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
				int num19 = 106;
				UserSettingMenu.MENU_TYPE menuType19 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString19 = "Quiet Ride MRCD/T On/Off";
				int[] array41 = new int[2];
				array41[0] = 1;
				array40[num19] = new UserSettingMenu(menuType19, menuString19, array41, new string[]
				{
					"Off",
					"On"
				}, "Mutes MRCD/T alarms when users drive under the speed limit set previously.");
				array[107] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Quiet Ride Volume", new int[]
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
				array[108] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Limit Speed", new int[][]
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
				array[109] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "GMT", new int[]
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
				int num20 = 110;
				UserSettingMenu.MENU_TYPE menuType20 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString20 = "DST";
				int[] array43 = new int[2];
				array43[0] = 1;
				array42[num20] = new UserSettingMenu(menuType20, menuString20, array43, new string[]
				{
					"Off",
					"On"
				}, "Daylight Saving Time");
				UserSettingMenu[] array44 = array;
				int num21 = 111;
				UserSettingMenu.MENU_TYPE menuType21 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString21 = "Low Battery Warning";
				int[] array45 = new int[2];
				array45[0] = 1;
				array44[num21] = new UserSettingMenu(menuType21, menuString21, array45, new string[]
				{
					"Off",
					"On"
				}, "Sounds a warning tone if the vehicle battery power drops below 11V.");
				UserSettingMenu[] array46 = array;
				int num22 = 112;
				UserSettingMenu.MENU_TYPE menuType22 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString22 = "Vehicle Battery Saver";
				int[] array47 = new int[2];
				array47[0] = 1;
				array46[num22] = new UserSettingMenu(menuType22, menuString22, array47, new string[]
				{
					"Off",
					"On"
				}, "Turns off power to the R4w if the speed stays at 0 or if the GPS is not connected for more than an hour.");
				array[113] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Self Test", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Runs a self diagnostic test on the unit to check for faults.");
				array[114] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Memory Quota", new int[]
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
				array[115] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Dim", new int[]
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
				array[116] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Main Volume", new int[]
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

			// Token: 0x060002B2 RID: 690 RVA: 0x0002BBAB File Offset: 0x00029DAB
			private int user_k_block_n_data_raw_strength_read(byte[][] userSettingData, int rd_addr)
			{
				return (((int)userSettingData[rd_addr][3] << 24) + ((int)userSettingData[rd_addr][2] << 16) + ((int)userSettingData[rd_addr][1] << 8) + (int)userSettingData[rd_addr][0] & 66846720) >> 18;
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x0002BBD8 File Offset: 0x00029DD8
			private void user_k_block_n_data_read(byte[][] userSettingData, int rd_addr, int[] settingR4W, int menu_op_mode_num, int mode)
			{
				int num = ((int)userSettingData[rd_addr][3] << 24) + ((int)userSettingData[rd_addr][2] << 16) + ((int)userSettingData[rd_addr][1] << 8) + (int)userSettingData[rd_addr][0];
				int num2 = (num & 1879048192) >> 28;
				int num3 = (num & 66846720) >> 18;
				int num4 = (num & 261632) >> 9;
				int num5 = num & 511;
				int num6 = this.user_k_block_get_level(num3, mode);
				if (num4 == 511)
				{
					num4 = 0;
				}
				if (num5 == 511)
				{
					num5 = 0;
				}
				if (num2 == 0)
				{
					settingR4W[menu_op_mode_num] = num6;
				}
				else
				{
					settingR4W[menu_op_mode_num] = num2;
				}
				settingR4W[menu_op_mode_num + 1] = num3;
				settingR4W[menu_op_mode_num + 2] = num4 + 23900;
				settingR4W[menu_op_mode_num + 3] = num5 + 23900;
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x0002BC80 File Offset: 0x00029E80
			private void user_k_block_n_data_write(byte[][] userSettingData, int rd_addr, int[] settingR4W, int menu_op_mode_num, int mode)
			{
				int num = 0;
				int num2 = settingR4W[menu_op_mode_num];
				if (settingR4W[menu_op_mode_num] > 7)
				{
					num2 = 0;
				}
				else
				{
					num2 = settingR4W[menu_op_mode_num];
				}
				int num3 = settingR4W[menu_op_mode_num + 1];
				int num4;
				if (settingR4W[menu_op_mode_num + 2] != 511)
				{
					num4 = settingR4W[menu_op_mode_num + 2] - 23900;
				}
				else
				{
					num4 = 511;
				}
				int num5;
				if (settingR4W[menu_op_mode_num + 3] != 511)
				{
					num5 = settingR4W[menu_op_mode_num + 3] - 23900;
				}
				else
				{
					num5 = 511;
				}
				num |= (num2 << 28 & 1879048192);
				num |= (num3 << 18 & 66846720);
				num |= (num4 << 9 & 261632);
				num |= (num5 & 511);
				userSettingData[rd_addr][3] = (byte)(num >> 24 & (int)BinaryDefine.b11111111);
				userSettingData[rd_addr][2] = (byte)(num >> 16 & (int)BinaryDefine.b11111111);
				userSettingData[rd_addr][1] = (byte)(num >> 8 & (int)BinaryDefine.b11111111);
				userSettingData[rd_addr][0] = (byte)(num & (int)BinaryDefine.b11111111);
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0002BD60 File Offset: 0x00029F60
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
				array[60] = (array2[0][3] >> 5 & (int)BinaryDefine.b00000011);
				array[74] = (array2[0][3] >> 4 & (int)BinaryDefine.b00000001);
				array[75] = (array2[0][3] >> 1 & (int)BinaryDefine.b00000111);
				array[26] = (int)(array2[0][3] & BinaryDefine.b00000001);
				switch (array[60])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[60] = 1;
					break;
				}
				switch (array[75])
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
					array[75] = 5;
					break;
				}
				array[25] = (array2[0][2] >> 7 & (int)BinaryDefine.b00000001);
				array[13] = (array2[0][2] >> 6 & (int)BinaryDefine.b00000001);
				array[15] = (array2[0][2] >> 5 & (int)BinaryDefine.b00000001);
				array[16] = (array2[0][2] >> 4 & (int)BinaryDefine.b00000001);
				array[17] = (array2[0][2] >> 3 & (int)BinaryDefine.b00000001);
				array[18] = (array2[0][2] >> 2 & (int)BinaryDefine.b00000001);
				array[23] = (array2[0][2] >> 1 & (int)BinaryDefine.b00000001);
				array[24] = (int)(array2[0][2] & BinaryDefine.b00000001);
				array[7] = (array2[0][1] >> 7 & (int)BinaryDefine.b00000001);
				array[104] = (array2[0][1] >> 2 & (int)BinaryDefine.b00000001);
				array[111] = (array2[0][1] >> 1 & (int)BinaryDefine.b00000001);
				array[113] = (int)(array2[0][1] & BinaryDefine.b00000001);
				array[115] = (array2[0][0] >> 4 & (int)BinaryDefine.b00000111);
				array[116] = (int)(array2[0][0] & BinaryDefine.b00001111);
				switch (array[115])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
					break;
				default:
					array[115] = 5;
					break;
				}
				if (array[116] < 0 || array[116] > 8)
				{
					array[116] = 4;
				}
				array[85] = (array2[1][2] >> 7 & (int)BinaryDefine.b00000001);
				array[1] = (array2[1][2] >> 5 & (int)BinaryDefine.b00000011);
				int num = (int)(array2[1][2] & BinaryDefine.b00011111);
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
				if (array[85] == 1)
				{
					if (num >= 0 && num <= 18)
					{
						array[105] = num * 5;
					}
					else
					{
						array[105] = 0;
					}
				}
				else if (num >= 0 && num <= 14)
				{
					array[105] = num * 10;
				}
				else
				{
					array[105] = 0;
				}
				array[112] = (array2[1][3] >> 6 & (int)BinaryDefine.b00000001);
				array[20] = (array2[1][3] >> 5 & (int)BinaryDefine.b00000001);
				num = (int)(array2[1][3] & BinaryDefine.b00011111);
				if (array[85] == 1)
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
				array[110] = (array2[1][1] >> 7 & (int)BinaryDefine.b00000001);
				array[8] = (array2[1][1] >> 6 & (int)BinaryDefine.b00000001);
				array[10] = (array2[1][1] >> 5 & (int)BinaryDefine.b00000001);
				num = (int)(array2[1][1] & BinaryDefine.b00011111);
				if (array[85] == 1)
				{
					if (num == 0 || (num >= 10 && num <= 20))
					{
						array[108] = num * 5;
					}
					else
					{
						array[108] = 0;
					}
				}
				else if (num == 0 || (num >= 8 && num <= 16))
				{
					array[108] = num * 10;
				}
				else
				{
					array[108] = 0;
				}
				array[83] = (array2[1][0] >> 5 & (int)BinaryDefine.b00000111);
				num = (int)(array2[1][0] & BinaryDefine.b00011111);
				if (array[83] >= 6)
				{
					array[83] = 4;
				}
				if (num != 31)
				{
					array[109] = (int)((byte)num - 12);
					if (array[109] < -12 || array[109] > 12)
					{
						array[109] = -8;
					}
				}
				else
				{
					array[109] = -8;
				}
				array[70] = (array2[2][3] >> 5 & (int)BinaryDefine.b00000011);
				array[14] = (array2[2][3] >> 4 & (int)BinaryDefine.b00000001);
				array[71] = (array2[2][3] >> 3 & (int)BinaryDefine.b00000001);
				num = (int)(array2[2][3] & BinaryDefine.b00000111);
				switch (array[70])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[70] = 1;
					break;
				}
				if (num >= 0 && num <= 7)
				{
					array[96] = num;
				}
				else
				{
					array[96] = 2;
				}
				array[59] = (array2[2][2] >> 6 & (int)BinaryDefine.b00000011);
				array[2] = (array2[2][2] >> 3 & (int)BinaryDefine.b00000111);
				array[3] = (int)(array2[2][2] & BinaryDefine.b00000111);
				switch (array[59])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[59] = 1;
					break;
				}
				if (array[2] > 7)
				{
					array[2] = 7;
				}
				if (array[3] > 7)
				{
					array[3] = 7;
				}
				array[69] = (array2[2][1] >> 3 & (int)BinaryDefine.b00000001);
				array[4] = (int)(array2[2][1] & BinaryDefine.b00000111);
				if (array[4] > 7)
				{
					array[4] = 7;
				}
				array[68] = (array2[2][0] >> 7 & (int)BinaryDefine.b00000001);
				array[67] = (array2[2][0] >> 6 & (int)BinaryDefine.b00000001);
				array[66] = (array2[2][0] >> 5 & (int)BinaryDefine.b00000001);
				array[65] = (array2[2][0] >> 4 & (int)BinaryDefine.b00000001);
				array[64] = (array2[2][0] >> 3 & (int)BinaryDefine.b00000001);
				array[63] = (array2[2][0] >> 2 & (int)BinaryDefine.b00000001);
				array[62] = (array2[2][0] >> 1 & (int)BinaryDefine.b00000001);
				array[61] = (int)(array2[2][0] & BinaryDefine.b00000001);
				array[21] = (array2[3][3] >> 6 & (int)BinaryDefine.b00000001);
				array[101] = (array2[3][3] >> 3 & (int)BinaryDefine.b00000111);
				array[103] = (int)(array2[3][3] & BinaryDefine.b00000111);
				switch (array[101])
				{
				default:
					array[101] = 4;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				switch (array[103])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
					break;
				default:
					array[103] = 3;
					break;
				}
				array[86] = (array2[3][2] >> 4 & (int)BinaryDefine.b00001111);
				array[87] = (int)(array2[3][2] & BinaryDefine.b00001111);
				if (array[86] > 12 || array[86] == 0)
				{
					array[86] = 1;
				}
				if (array[87] > 12 || array[87] == 0)
				{
					array[87] = 2;
				}
				array[94] = (array2[3][1] >> 4 & (int)BinaryDefine.b00001111);
				array[92] = (int)(array2[3][1] & BinaryDefine.b00001111);
				if (array[92] > 12 || array[92] == 0)
				{
					array[92] = 3;
				}
				if (array[94] > 12 || array[94] == 0)
				{
					array[94] = 4;
				}
				array[102] = (array2[3][0] >> 4 & (int)BinaryDefine.b00001111);
				array[100] = (int)(array2[3][0] & BinaryDefine.b00001111);
				if (array[102] > 12)
				{
					array[102] = 4;
				}
				if (array[100] > 8)
				{
					array[100] = 4;
				}
				array[93] = (array2[4][3] >> 4 & (int)BinaryDefine.b00001111);
				array[90] = (int)(array2[4][3] & BinaryDefine.b00001111);
				if (array[90] > 12 || array[90] == 0)
				{
					array[90] = 2;
				}
				if (array[93] > 6 || array[93] == 0)
				{
					array[93] = 1;
				}
				array[0] = (array2[4][2] >> 7 & (int)BinaryDefine.b00000001);
				array[106] = (array2[4][2] >> 5 & (int)BinaryDefine.b00000001);
				array[81] = (array2[4][2] >> 3 & (int)BinaryDefine.b00000011);
				array[98] = (int)(array2[4][2] & BinaryDefine.b00000111);
				switch (array[81])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[81] = 1;
					break;
				}
				switch (array[98])
				{
				default:
					array[98] = 2;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				array[72] = (array2[4][1] >> 7 & (int)BinaryDefine.b00000001);
				array[9] = (array2[4][1] >> 4 & (int)BinaryDefine.b00000111);
				num = (int)(array2[4][1] & BinaryDefine.b00001111);
				if (array[9] > 4)
				{
					array[9] = 1;
				}
				if (array[85] == 1)
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
				array[73] = (array2[4][0] >> 7 & (int)BinaryDefine.b00000001);
				array[6] = (array2[4][0] >> 6 & (int)BinaryDefine.b00000001);
				array[99] = (array2[4][0] >> 5 & (int)BinaryDefine.b00000001);
				array[91] = (array2[4][0] >> 1 & (int)BinaryDefine.b00001111);
				array[22] = (int)(array2[4][0] & BinaryDefine.b00000001);
				if (array[91] > 12 || array[91] == 0)
				{
					array[91] = 2;
				}
				array[19] = (int)(array2[5][3] & BinaryDefine.b00000001);
				array[97] = (array2[5][1] >> 3 & (int)BinaryDefine.b00000001);
				array[95] = (int)(array2[5][1] & BinaryDefine.b00000111);
				if (array[95] > 5)
				{
					array[95] = 5;
				}
				array[82] = (array2[6][3] >> 6 & (int)BinaryDefine.b00000001);
				array[77] = (array2[6][3] >> 3 & (int)BinaryDefine.b00000111);
				array[76] = (int)(array2[6][3] & BinaryDefine.b00000111);
				if (array[76] > 7)
				{
					array[76] = 0;
				}
				if (array[77] > 7)
				{
					array[77] = 0;
				}
				array[12] = (array2[6][2] >> 7 & (int)BinaryDefine.b00000001);
				array[84] = (array2[6][2] >> 6 & (int)BinaryDefine.b00000001);
				array[78] = (array2[6][2] >> 3 & (int)BinaryDefine.b00000111);
				array[79] = (int)(array2[6][2] & BinaryDefine.b00000111);
				if (array[78] > 7)
				{
					array[78] = 0;
				}
				if (array[79] > 7)
				{
					array[79] = 0;
				}
				array[107] = (array2[6][1] >> 3 & (int)BinaryDefine.b00001111);
				array[80] = (int)(array2[6][1] & BinaryDefine.b00000111);
				if (array[107] > 8)
				{
					array[107] = 1;
				}
				if (array[80] > 7)
				{
					array[80] = 0;
				}
				array[89] = (array2[6][0] >> 3 & (int)BinaryDefine.b00000111);
				array[88] = (int)(array2[6][0] & BinaryDefine.b00000111);
				if (array[88] > 6 || array[88] == 0)
				{
					array[88] = 1;
				}
				if (array[89] > 5 || array[89] < 1)
				{
					array[89] = 3;
				}
				this.user_k_block_n_data_read(array2, 13, array, 27, array[1]);
				this.user_k_block_n_data_read(array2, 14, array, 31, array[1]);
				this.user_k_block_n_data_read(array2, 15, array, 35, array[1]);
				this.user_k_block_n_data_read(array2, 8, array, 39, array[1]);
				this.user_k_block_n_data_read(array2, 9, array, 43, array[1]);
				this.user_k_block_n_data_read(array2, 10, array, 47, array[1]);
				this.user_k_block_n_data_read(array2, 11, array, 51, array[1]);
				this.user_k_block_n_data_read(array2, 12, array, 55, array[1]);
				if ((array2[5][1] >> 7 & (int)BinaryDefine.b00000001) == 1)
				{
					if ((array2[0][1] >> 3 & (int)BinaryDefine.b00000001) == 1)
					{
						array[95] = 5;
					}
					else
					{
						array[95] = 0;
					}
					int num2 = array2[2][1] >> 6 & (int)BinaryDefine.b00000011;
					int num3 = array2[2][1] >> 4 & (int)BinaryDefine.b00000011;
					if (num2 == 1)
					{
						array[27] = 17;
						array[28] = 255;
					}
					else if (num2 == 2)
					{
						array[27] = 1;
						array[28] = 0;
					}
					else if (num2 == 3)
					{
						array[27] = 3;
						array[28] = 0;
					}
					else
					{
						array[27] = 7;
						array[28] = 0;
					}
					array[29] = 24194;
					array[30] = 24204;
					this.user_k_block_n_data_write(array2, 13, array, 27, array[1]);
					if (num3 == 1)
					{
						array[31] = 17;
						array[32] = 255;
					}
					else if (num3 == 2)
					{
						array[31] = 1;
						array[32] = 0;
					}
					else if (num3 == 3)
					{
						array[31] = 3;
						array[32] = 0;
					}
					else
					{
						array[31] = 7;
						array[32] = 0;
					}
					array[33] = 24166;
					array[34] = 24170;
					this.user_k_block_n_data_write(array2, 14, array, 31, array[1]);
					array[35] = 1;
					array[36] = 0;
					array[37] = 24123;
					array[38] = 24124;
					array[39] = 7;
					array[40] = 0;
					array[41] = 23900;
					array[42] = 23900;
					array[43] = 7;
					array[44] = 0;
					array[45] = 23900;
					array[46] = 23900;
					array[47] = 7;
					array[48] = 0;
					array[49] = 23900;
					array[50] = 23900;
					array[51] = 7;
					array[52] = 0;
					array[53] = 23900;
					array[54] = 23900;
					array[55] = 7;
					array[56] = 0;
					array[57] = 23900;
					array[58] = 23900;
					this.user_k_block_n_data_write(array2, 15, array, 35, array[1]);
					this.user_k_block_n_data_write(array2, 8, array, 39, array[1]);
					this.user_k_block_n_data_write(array2, 9, array, 43, array[1]);
					this.user_k_block_n_data_write(array2, 10, array, 47, array[1]);
					this.user_k_block_n_data_write(array2, 11, array, 51, array[1]);
					this.user_k_block_n_data_write(array2, 12, array, 55, array[1]);
				}
				array[114] = (int)nvData[64];
				return array;
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
			public byte[] GetNVDataFromUserSetting(int[] userSettingR4W, byte[] receivedNVData)
			{
				if (this.menuCnt == 0)
				{
					return null;
				}
				byte[][] array = new byte[16][];
				byte[] array2 = new byte[receivedNVData.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = new byte[4];
					for (int j = 0; j < 4; j++)
					{
						array[i][j] = 0;
					}
				}
				byte[] array3 = array[0];
				int num = 3;
				array3[num] |= (byte)(userSettingR4W[60] << 5 & (int)BinaryDefine.b01100000);
				byte[] array4 = array[0];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR4W[74] << 4 & (int)BinaryDefine.b00010000);
				byte[] array5 = array[0];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR4W[75] << 1 & (int)BinaryDefine.b00001110);
				byte[] array6 = array[0];
				int num4 = 3;
				array6[num4] |= (byte)(userSettingR4W[26] & (int)BinaryDefine.b00000001);
				byte[] array7 = array[0];
				int num5 = 2;
				array7[num5] |= (byte)(userSettingR4W[25] << 7 & (int)BinaryDefine.b10000000);
				byte[] array8 = array[0];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR4W[13] << 6 & (int)BinaryDefine.b01000000);
				byte[] array9 = array[0];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR4W[15] << 5 & (int)BinaryDefine.b00100000);
				byte[] array10 = array[0];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR4W[16] << 4 & (int)BinaryDefine.b00010000);
				byte[] array11 = array[0];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR4W[17] << 3 & (int)BinaryDefine.b00001000);
				byte[] array12 = array[0];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR4W[18] << 2 & (int)BinaryDefine.b00000100);
				byte[] array13 = array[0];
				int num11 = 2;
				array13[num11] |= (byte)(userSettingR4W[23] << 1 & (int)BinaryDefine.b00000010);
				byte[] array14 = array[0];
				int num12 = 2;
				array14[num12] |= (byte)(userSettingR4W[24] & (int)BinaryDefine.b00000001);
				byte[] array15 = array[0];
				int num13 = 1;
				array15[num13] |= (byte)(userSettingR4W[7] << 7 & (int)BinaryDefine.b10000000);
				byte[] array16 = array[0];
				int num14 = 1;
				array16[num14] |= (byte)(userSettingR4W[104] << 2 & (int)BinaryDefine.b00000100);
				byte[] array17 = array[0];
				int num15 = 1;
				array17[num15] |= (byte)(userSettingR4W[111] << 1 & (int)BinaryDefine.b00000010);
				byte[] array18 = array[0];
				int num16 = 1;
				array18[num16] |= (byte)(userSettingR4W[113] & (int)BinaryDefine.b00000001);
				byte[] array19 = array[0];
				int num17 = 0;
				array19[num17] |= (byte)(userSettingR4W[115] << 4 & (int)BinaryDefine.b01110000);
				byte[] array20 = array[0];
				int num18 = 0;
				array20[num18] |= (byte)(userSettingR4W[116] & (int)BinaryDefine.b00001111);
				byte b;
				if (userSettingR4W[85] == 1)
				{
					b = (byte)(userSettingR4W[11] / 5);
				}
				else
				{
					b = (byte)(userSettingR4W[11] / 10);
				}
				byte[] array21 = array[1];
				int num19 = 3;
				array21[num19] |= (byte)(userSettingR4W[112] << 6 & (int)BinaryDefine.b01000000);
				byte[] array22 = array[1];
				int num20 = 3;
				array22[num20] |= (byte)(userSettingR4W[20] << 5 & (int)BinaryDefine.b00100000);
				byte[] array23 = array[1];
				int num21 = 3;
				// DECOMPILE-FIX: Restore byte narrowing for the exported bit-mask operations
				// in this file; unchecked casts preserve the original IL byte stores.
				array23[num21] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR4W[85] == 1)
				{
					b = (byte)(userSettingR4W[105] / 5);
				}
				else
				{
					b = (byte)(userSettingR4W[105] / 10);
				}
				byte[] array24 = array[1];
				int num22 = 2;
				array24[num22] |= (byte)(userSettingR4W[85] << 7 & (int)BinaryDefine.b10000000);
				byte[] array25 = array[1];
				int num23 = 2;
				array25[num23] |= (byte)(userSettingR4W[1] << 5 & (int)BinaryDefine.b01100000);
				byte[] array26 = array[1];
				int num24 = 2;
				array26[num24] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR4W[85] == 1)
				{
					b = (byte)(userSettingR4W[108] / 5);
				}
				else
				{
					b = (byte)(userSettingR4W[108] / 10);
				}
				byte[] array27 = array[1];
				int num25 = 1;
				array27[num25] |= (byte)(userSettingR4W[110] << 7 & (int)BinaryDefine.b10000000);
				byte[] array28 = array[1];
				int num26 = 1;
				array28[num26] |= (byte)(userSettingR4W[8] << 6 & (int)BinaryDefine.b01000000);
				byte[] array29 = array[1];
				int num27 = 1;
				array29[num27] |= (byte)(userSettingR4W[10] << 5 & (int)BinaryDefine.b00100000);
				byte[] array30 = array[1];
				int num28 = 1;
				array30[num28] |= unchecked((byte)(b & BinaryDefine.b00011111));
				b = (byte)(userSettingR4W[109] + 12);
				byte[] array31 = array[1];
				int num29 = 0;
				array31[num29] |= (byte)(userSettingR4W[83] << 5 & (int)BinaryDefine.b11100000);
				byte[] array32 = array[1];
				int num30 = 0;
				array32[num30] |= unchecked((byte)(b & BinaryDefine.b00011111));
				byte[] array33 = array[2];
				int num31 = 3;
				array33[num31] |= (byte)(userSettingR4W[70] << 5 & (int)BinaryDefine.b01100000);
				byte[] array34 = array[2];
				int num32 = 3;
				array34[num32] |= (byte)(userSettingR4W[14] << 4 & (int)BinaryDefine.b00010000);
				byte[] array35 = array[2];
				int num33 = 3;
				array35[num33] |= (byte)(userSettingR4W[71] << 3 & (int)BinaryDefine.b00001000);
				byte[] array36 = array[2];
				int num34 = 3;
				array36[num34] |= (byte)(userSettingR4W[96] & (int)BinaryDefine.b00000111);
				byte[] array37 = array[2];
				int num35 = 2;
				array37[num35] |= (byte)(userSettingR4W[59] << 6 & (int)BinaryDefine.b11000000);
				byte[] array38 = array[2];
				int num36 = 2;
				array38[num36] |= (byte)(userSettingR4W[2] << 3 & (int)BinaryDefine.b00111000);
				byte[] array39 = array[2];
				int num37 = 2;
				array39[num37] |= (byte)(userSettingR4W[3] & (int)BinaryDefine.b00000111);
				byte[] array40 = array[2];
				int num38 = 1;
				array40[num38] |= (byte)(userSettingR4W[69] << 3 & (int)BinaryDefine.b00001000);
				byte[] array41 = array[2];
				int num39 = 1;
				array41[num39] |= (byte)(userSettingR4W[4] & (int)BinaryDefine.b00000111);
				byte[] array42 = array[2];
				int num40 = 0;
				array42[num40] |= (byte)(userSettingR4W[68] << 7 & (int)BinaryDefine.b10000000);
				byte[] array43 = array[2];
				int num41 = 0;
				array43[num41] |= (byte)(userSettingR4W[67] << 6 & (int)BinaryDefine.b01000000);
				byte[] array44 = array[2];
				int num42 = 0;
				array44[num42] |= (byte)(userSettingR4W[66] << 5 & (int)BinaryDefine.b00100000);
				byte[] array45 = array[2];
				int num43 = 0;
				array45[num43] |= (byte)(userSettingR4W[65] << 4 & (int)BinaryDefine.b00010000);
				byte[] array46 = array[2];
				int num44 = 0;
				array46[num44] |= (byte)(userSettingR4W[64] << 3 & (int)BinaryDefine.b00001000);
				byte[] array47 = array[2];
				int num45 = 0;
				array47[num45] |= (byte)(userSettingR4W[63] << 2 & (int)BinaryDefine.b00000100);
				byte[] array48 = array[2];
				int num46 = 0;
				array48[num46] |= (byte)(userSettingR4W[62] << 1 & (int)BinaryDefine.b00000010);
				byte[] array49 = array[2];
				int num47 = 0;
				array49[num47] |= (byte)(userSettingR4W[61] & (int)BinaryDefine.b00000001);
				byte[] array50 = array[3];
				int num48 = 3;
				array50[num48] |= (byte)(userSettingR4W[21] << 6 & (int)BinaryDefine.b01000000);
				byte[] array51 = array[3];
				int num49 = 3;
				array51[num49] |= (byte)(userSettingR4W[101] << 3 & (int)BinaryDefine.b00111000);
				byte[] array52 = array[3];
				int num50 = 3;
				array52[num50] |= (byte)(userSettingR4W[103] & (int)BinaryDefine.b00000111);
				byte[] array53 = array[3];
				int num51 = 2;
				array53[num51] |= (byte)(userSettingR4W[86] << 4 & (int)BinaryDefine.b11110000);
				byte[] array54 = array[3];
				int num52 = 2;
				array54[num52] |= (byte)(userSettingR4W[87] & (int)BinaryDefine.b00001111);
				byte[] array55 = array[3];
				int num53 = 1;
				array55[num53] |= (byte)(userSettingR4W[94] << 4 & (int)BinaryDefine.b11110000);
				byte[] array56 = array[3];
				int num54 = 1;
				array56[num54] |= (byte)(userSettingR4W[92] & (int)BinaryDefine.b00001111);
				byte[] array57 = array[3];
				int num55 = 0;
				array57[num55] |= (byte)(userSettingR4W[102] << 4 & (int)BinaryDefine.b11110000);
				byte[] array58 = array[3];
				int num56 = 0;
				array58[num56] |= (byte)(userSettingR4W[100] & (int)BinaryDefine.b00001111);
				byte[] array59 = array[4];
				int num57 = 3;
				array59[num57] |= (byte)(userSettingR4W[93] << 4 & (int)BinaryDefine.b01110000);
				byte[] array60 = array[4];
				int num58 = 3;
				array60[num58] |= (byte)(userSettingR4W[90] & (int)BinaryDefine.b00001111);
				byte[] array61 = array[4];
				int num59 = 2;
				array61[num59] |= (byte)(userSettingR4W[0] << 7 & (int)BinaryDefine.b10000000);
				byte[] array62 = array[4];
				int num60 = 2;
				array62[num60] |= (byte)(userSettingR4W[106] << 5 & (int)BinaryDefine.b00100000);
				byte[] array63 = array[4];
				int num61 = 2;
				array63[num61] |= (byte)(userSettingR4W[81] << 3 & (int)BinaryDefine.b00011000);
				byte[] array64 = array[4];
				int num62 = 2;
				array64[num62] |= (byte)(userSettingR4W[98] & (int)BinaryDefine.b00000111);
				if (userSettingR4W[85] == 1)
				{
					b = (byte)(userSettingR4W[5] / 5);
				}
				else
				{
					b = (byte)(userSettingR4W[5] / 10);
				}
				byte[] array65 = array[4];
				int num63 = 1;
				array65[num63] |= (byte)(userSettingR4W[72] << 7 & (int)BinaryDefine.b10000000);
				byte[] array66 = array[4];
				int num64 = 1;
				array66[num64] |= (byte)(userSettingR4W[9] << 4 & (int)BinaryDefine.b01110000);
				byte[] array67 = array[4];
				int num65 = 1;
				array67[num65] |= unchecked((byte)(b & BinaryDefine.b00001111));
				byte[] array68 = array[4];
				int num66 = 0;
				array68[num66] |= (byte)(userSettingR4W[73] << 7 & (int)BinaryDefine.b10000000);
				byte[] array69 = array[4];
				int num67 = 0;
				array69[num67] |= (byte)(userSettingR4W[6] << 6 & (int)BinaryDefine.b01000000);
				byte[] array70 = array[4];
				int num68 = 0;
				array70[num68] |= (byte)(userSettingR4W[99] << 5 & (int)BinaryDefine.b00100000);
				byte[] array71 = array[4];
				int num69 = 0;
				array71[num69] |= (byte)(userSettingR4W[91] << 1 & (int)BinaryDefine.b00011110);
				byte[] array72 = array[4];
				int num70 = 0;
				array72[num70] |= (byte)(userSettingR4W[22] & (int)BinaryDefine.b00000001);
				byte[] array73 = array[5];
				int num71 = 3;
				array73[num71] |= (byte)(userSettingR4W[19] & (int)BinaryDefine.b00000001);
				byte[] array74 = array[5];
				int num72 = 1;
				array74[num72] |= unchecked((byte)(0 & BinaryDefine.b10000000));
				byte[] array75 = array[5];
				int num73 = 1;
				array75[num73] |= (byte)(userSettingR4W[97] << 3 & (int)BinaryDefine.b00001000);
				byte[] array76 = array[5];
				int num74 = 1;
				array76[num74] |= (byte)(userSettingR4W[95] & (int)BinaryDefine.b00000111);
				byte[] array77 = array[6];
				int num75 = 3;
				array77[num75] |= (byte)(userSettingR4W[82] << 6 & (int)BinaryDefine.b01000000);
				byte[] array78 = array[6];
				int num76 = 3;
				array78[num76] |= (byte)(userSettingR4W[77] << 3 & (int)BinaryDefine.b00111000);
				byte[] array79 = array[6];
				int num77 = 3;
				array79[num77] |= (byte)(userSettingR4W[76] & (int)BinaryDefine.b00000111);
				byte[] array80 = array[6];
				int num78 = 2;
				array80[num78] |= (byte)(userSettingR4W[12] << 7 & (int)BinaryDefine.b10000000);
				byte[] array81 = array[6];
				int num79 = 2;
				array81[num79] |= (byte)(userSettingR4W[84] << 6 & (int)BinaryDefine.b01000000);
				byte[] array82 = array[6];
				int num80 = 2;
				array82[num80] |= (byte)(userSettingR4W[78] << 3 & (int)BinaryDefine.b00111000);
				byte[] array83 = array[6];
				int num81 = 2;
				array83[num81] |= (byte)(userSettingR4W[79] & (int)BinaryDefine.b00000111);
				byte[] array84 = array[6];
				int num82 = 1;
				array84[num82] |= (byte)(userSettingR4W[107] << 3 & (int)BinaryDefine.b01111000);
				byte[] array85 = array[6];
				int num83 = 1;
				array85[num83] |= (byte)(userSettingR4W[80] & (int)BinaryDefine.b00000111);
				byte[] array86 = array[6];
				int num84 = 0;
				array86[num84] |= (byte)(userSettingR4W[89] << 3 & (int)BinaryDefine.b00111000);
				byte[] array87 = array[6];
				int num85 = 0;
				array87[num85] |= (byte)(userSettingR4W[88] & (int)BinaryDefine.b00000111);
				this.user_k_block_n_data_write(array, 8, userSettingR4W, 39, userSettingR4W[1]);
				this.user_k_block_n_data_write(array, 9, userSettingR4W, 43, userSettingR4W[1]);
				this.user_k_block_n_data_write(array, 10, userSettingR4W, 47, userSettingR4W[1]);
				this.user_k_block_n_data_write(array, 11, userSettingR4W, 51, userSettingR4W[1]);
				this.user_k_block_n_data_write(array, 12, userSettingR4W, 55, userSettingR4W[1]);
				this.user_k_block_n_data_write(array, 13, userSettingR4W, 27, userSettingR4W[1]);
				this.user_k_block_n_data_write(array, 14, userSettingR4W, 31, userSettingR4W[1]);
				this.user_k_block_n_data_write(array, 15, userSettingR4W, 35, userSettingR4W[1]);
				Array.Copy(receivedNVData, array2, receivedNVData.Length);
				for (int i = 0; i < array.Length; i++)
				{
					for (int j = 0; j < array[i].Length; j++)
					{
						byte[] array88 = array2;
						int num86 = i * 4 + j;
						array88[num86] &= unchecked((byte)(~this.userNVDataPos[i * 4 + j]));
						byte[] array89 = array2;
						int num87 = i * 4 + j;
						array89[num87] |= array[i][j];
					}
				}
				array2[64] = (byte)userSettingR4W[114];
				int num88 = 0;
				for (int i = 0; i < receivedNVData.Length; i++)
				{
					if (receivedNVData[i] != array2[i])
					{
						num88++;
					}
				}
				return array2;
			}

			// Token: 0x0400050A RID: 1290
			private int supportVersion = 114;

			// Token: 0x0400050B RID: 1291
			private int menuCnt = 117;

			// Token: 0x0400050C RID: 1292
			private byte[] userNVDataPos = new byte[]
			{
				127,
				135,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				15,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				191,
				127,
				0,
				143,
				0,
				1,
				63,
				127,
				byte.MaxValue,
				127,
				0,
				0,
				0,
				0,
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
				127
			};

			// Token: 0x0400050D RID: 1293
			private const int memoryQuotaPos = 64;

			// Token: 0x0400050E RID: 1294
			private const int RD_1 = 0;

			// Token: 0x0400050F RID: 1295
			private const int GPS = 1;

			// Token: 0x04000510 RID: 1296
			private const int RD_2 = 2;

			// Token: 0x04000511 RID: 1297
			private const int RD_3 = 3;

			// Token: 0x04000512 RID: 1298
			private const int RD_4 = 4;

			// Token: 0x04000513 RID: 1299
			private const int RD_5 = 5;

			// Token: 0x04000514 RID: 1300
			private const int RD_6 = 6;

			// Token: 0x04000515 RID: 1301
			private const int RD_7 = 7;

			// Token: 0x04000516 RID: 1302
			private const int USR_K_BLK1 = 8;

			// Token: 0x04000517 RID: 1303
			private const int USR_K_BLK2 = 9;

			// Token: 0x04000518 RID: 1304
			private const int USR_K_BLK3 = 10;

			// Token: 0x04000519 RID: 1305
			private const int USR_K_BLK4 = 11;

			// Token: 0x0400051A RID: 1306
			private const int USR_K_BLK5 = 12;

			// Token: 0x0400051B RID: 1307
			private const int CONST_K_BLK1 = 13;

			// Token: 0x0400051C RID: 1308
			private const int CONST_K_BLK2 = 14;

			// Token: 0x0400051D RID: 1309
			private const int CONST_K_BLK3 = 15;

			// Token: 0x0400051E RID: 1310
			private const int ADDR_CNT = 16;

			// Token: 0x0400051F RID: 1311
			private const int RF_PWR_STRENGTH_LEVEL0P5 = 46;

			// Token: 0x04000520 RID: 1312
			private const int RF_PWR_STRENGTH_LEVEL1 = 55;

			// Token: 0x04000521 RID: 1313
			private const int RF_PWR_STRENGTH_LEVEL1P5 = 64;

			// Token: 0x04000522 RID: 1314
			private const int RF_PWR_STRENGTH_LEVEL2 = 74;

			// Token: 0x04000523 RID: 1315
			private const int RF_PWR_STRENGTH_LEVEL2P5 = 84;

			// Token: 0x04000524 RID: 1316
			private const int RF_PWR_STRENGTH_LEVEL3 = 95;

			// Token: 0x04000525 RID: 1317
			private const int RF_PWR_STRENGTH_LEVEL3P5 = 106;

			// Token: 0x04000526 RID: 1318
			private const int RF_PWR_STRENGTH_LEVEL4 = 117;

			// Token: 0x04000527 RID: 1319
			private const int RF_PWR_STRENGTH_LEVEL4P5 = 128;

			// Token: 0x04000528 RID: 1320
			private const int RF_PWR_STRENGTH_LEVEL0P5_CITY = 87;

			// Token: 0x04000529 RID: 1321
			private const int RF_PWR_STRENGTH_LEVEL1_CITY = 95;

			// Token: 0x0400052A RID: 1322
			private const int RF_PWR_STRENGTH_LEVEL1P5_CITY = 103;

			// Token: 0x0400052B RID: 1323
			private const int RF_PWR_STRENGTH_LEVEL2_CITY = 111;

			// Token: 0x0400052C RID: 1324
			private const int RF_PWR_STRENGTH_LEVEL2P5_CITY = 117;

			// Token: 0x0400052D RID: 1325
			private const int RF_PWR_STRENGTH_LEVEL3_CITY = 123;

			// Token: 0x0400052E RID: 1326
			private const int RF_PWR_STRENGTH_LEVEL3P5_CITY = 124;

			// Token: 0x0400052F RID: 1327
			private const int RF_PWR_STRENGTH_LEVEL4_CITY = 125;

			// Token: 0x04000530 RID: 1328
			private const int RF_PWR_STRENGTH_LEVEL4P5_CITY = 126;

			// Token: 0x04000531 RID: 1329
			private const int K_BLOCK_FILTER_LEVEL_0P5 = 8;

			// Token: 0x04000532 RID: 1330
			private const int K_BLOCK_FILTER_LEVEL_1P0 = 9;

			// Token: 0x04000533 RID: 1331
			private const int K_BLOCK_FILTER_LEVEL_1P5 = 10;

			// Token: 0x04000534 RID: 1332
			private const int K_BLOCK_FILTER_LEVEL_2P0 = 11;

			// Token: 0x04000535 RID: 1333
			private const int K_BLOCK_FILTER_LEVEL_2P5 = 12;

			// Token: 0x04000536 RID: 1334
			private const int K_BLOCK_FILTER_LEVEL_3P0 = 13;

			// Token: 0x04000537 RID: 1335
			private const int K_BLOCK_FILTER_LEVEL_3P5 = 14;

			// Token: 0x04000538 RID: 1336
			private const int K_BLOCK_FILTER_LEVEL_4P0 = 15;

			// Token: 0x04000539 RID: 1337
			private const int K_BLOCK_FILTER_LEVEL_4P5 = 16;

			// Token: 0x0400053A RID: 1338
			private const int K_BLOCK_FILTER_LEVEL_5P0 = 17;

			// Token: 0x020000B4 RID: 180
			private enum MENU
			{
				// Token: 0x04000766 RID: 1894
				MENU_MODE,
				// Token: 0x04000767 RID: 1895
				DETECTION_MODE,
				// Token: 0x04000768 RID: 1896
				X_SENSITIVE,
				// Token: 0x04000769 RID: 1897
				K_SENSITIVE,
				// Token: 0x0400076A RID: 1898
				KA_SENSITIVE,
				// Token: 0x0400076B RID: 1899
				AUTO_CITY_SPEED,
				// Token: 0x0400076C RID: 1900
				BLUETOOTH_MODE,
				// Token: 0x0400076D RID: 1901
				GPS_ENABLE,
				// Token: 0x0400076E RID: 1902
				SPEED_CAMERA_ENABLE,
				// Token: 0x0400076F RID: 1903
				SPEED_CAMERA_ALERT_RANGE,
				// Token: 0x04000770 RID: 1904
				RLC_ENABLE,
				// Token: 0x04000771 RID: 1905
				RLC_QRIDE,
				// Token: 0x04000772 RID: 1906
				POI_PASSCHIME,
				// Token: 0x04000773 RID: 1907
				VOICE_ENABLE,
				// Token: 0x04000774 RID: 1908
				KA_FREQ_VOICE,
				// Token: 0x04000775 RID: 1909
				X_BAND_ENABLE,
				// Token: 0x04000776 RID: 1910
				K_BAND_ENABLE,
				// Token: 0x04000777 RID: 1911
				KA_BAND_ENABLE,
				// Token: 0x04000778 RID: 1912
				LASER_ENABLE,
				// Token: 0x04000779 RID: 1913
				LASER_GUN_ID_ENABLE,
				// Token: 0x0400077A RID: 1914
				K_POP_ENABLE,
				// Token: 0x0400077B RID: 1915
				MRCD_ENABLE,
				// Token: 0x0400077C RID: 1916
				GATSO_ENABLE,
				// Token: 0x0400077D RID: 1917
				KA_POP_ENABLE,
				// Token: 0x0400077E RID: 1918
				K_FILTER_ENABLE,
				// Token: 0x0400077F RID: 1919
				KA_FILTER_ENABLE,
				// Token: 0x04000780 RID: 1920
				TSF_ENABLE,
				// Token: 0x04000781 RID: 1921
				K_BLOCK_FILTER_1_OP_MODE,
				// Token: 0x04000782 RID: 1922
				K_BLOCK_FILTER_1_RAW_STRENGTH,
				// Token: 0x04000783 RID: 1923
				K_BLOCK_FILTER_1_MIN_FREQ,
				// Token: 0x04000784 RID: 1924
				K_BLOCK_FILTER_1_MAX_FREQ,
				// Token: 0x04000785 RID: 1925
				K_BLOCK_FILTER_2_OP_MODE,
				// Token: 0x04000786 RID: 1926
				K_BLOCK_FILTER_2_RAW_STRENGTH,
				// Token: 0x04000787 RID: 1927
				K_BLOCK_FILTER_2_MIN_FREQ,
				// Token: 0x04000788 RID: 1928
				K_BLOCK_FILTER_2_MAX_FREQ,
				// Token: 0x04000789 RID: 1929
				K_BLOCK_FILTER_3_OP_MODE,
				// Token: 0x0400078A RID: 1930
				K_BLOCK_FILTER_3_RAW_STRENGTH,
				// Token: 0x0400078B RID: 1931
				K_BLOCK_FILTER_3_MIN_FREQ,
				// Token: 0x0400078C RID: 1932
				K_BLOCK_FILTER_3_MAX_FREQ,
				// Token: 0x0400078D RID: 1933
				USER_K_BLOCK_FILTER_1_OP_MODE,
				// Token: 0x0400078E RID: 1934
				USER_K_BLOCK_FILTER_1_RAW_STRENGTH,
				// Token: 0x0400078F RID: 1935
				USER_K_BLOCK_FILTER_1_MIN_FREQ,
				// Token: 0x04000790 RID: 1936
				USER_K_BLOCK_FILTER_1_MAX_FREQ,
				// Token: 0x04000791 RID: 1937
				USER_K_BLOCK_FILTER_2_OP_MODE,
				// Token: 0x04000792 RID: 1938
				USER_K_BLOCK_FILTER_2_RAW_STRENGTH,
				// Token: 0x04000793 RID: 1939
				USER_K_BLOCK_FILTER_2_MIN_FREQ,
				// Token: 0x04000794 RID: 1940
				USER_K_BLOCK_FILTER_2_MAX_FREQ,
				// Token: 0x04000795 RID: 1941
				USER_K_BLOCK_FILTER_3_OP_MODE,
				// Token: 0x04000796 RID: 1942
				USER_K_BLOCK_FILTER_3_RAW_STRENGTH,
				// Token: 0x04000797 RID: 1943
				USER_K_BLOCK_FILTER_3_MIN_FREQ,
				// Token: 0x04000798 RID: 1944
				USER_K_BLOCK_FILTER_3_MAX_FREQ,
				// Token: 0x04000799 RID: 1945
				USER_K_BLOCK_FILTER_4_OP_MODE,
				// Token: 0x0400079A RID: 1946
				USER_K_BLOCK_FILTER_4_RAW_STRENGTH,
				// Token: 0x0400079B RID: 1947
				USER_K_BLOCK_FILTER_4_MIN_FREQ,
				// Token: 0x0400079C RID: 1948
				USER_K_BLOCK_FILTER_4_MAX_FREQ,
				// Token: 0x0400079D RID: 1949
				USER_K_BLOCK_FILTER_5_OP_MODE,
				// Token: 0x0400079E RID: 1950
				USER_K_BLOCK_FILTER_5_RAW_STRENGTH,
				// Token: 0x0400079F RID: 1951
				USER_K_BLOCK_FILTER_5_MIN_FREQ,
				// Token: 0x040007A0 RID: 1952
				USER_K_BLOCK_FILTER_5_MAX_FREQ,
				// Token: 0x040007A1 RID: 1953
				K_NARROW,
				// Token: 0x040007A2 RID: 1954
				KA_NARROW,
				// Token: 0x040007A3 RID: 1955
				KA_SEG1,
				// Token: 0x040007A4 RID: 1956
				KA_SEG2,
				// Token: 0x040007A5 RID: 1957
				KA_SEG3,
				// Token: 0x040007A6 RID: 1958
				KA_SEG4,
				// Token: 0x040007A7 RID: 1959
				KA_SEG5,
				// Token: 0x040007A8 RID: 1960
				KA_SEG6,
				// Token: 0x040007A9 RID: 1961
				KA_SEG7,
				// Token: 0x040007AA RID: 1962
				KA_SEG8,
				// Token: 0x040007AB RID: 1963
				KA_SEG9,
				// Token: 0x040007AC RID: 1964
				PRIORITY_MODE,
				// Token: 0x040007AD RID: 1965
				MUTE_MEM_BAND_OPTION,
				// Token: 0x040007AE RID: 1966
				AUTO_MUTE_MEM_ENABLE,
				// Token: 0x040007AF RID: 1967
				AUTO_MUTE_MEM_BAND_OPTION,
				// Token: 0x040007B0 RID: 1968
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x040007B1 RID: 1969
				BACKGROUND_COLOR,
				// Token: 0x040007B2 RID: 1970
				X_BAND_COLOR,
				// Token: 0x040007B3 RID: 1971
				K_BAND_COLOR,
				// Token: 0x040007B4 RID: 1972
				MRCD_COLOR,
				// Token: 0x040007B5 RID: 1973
				GATSO_COLOR,
				// Token: 0x040007B6 RID: 1974
				KA_BAND_COLOR,
				// Token: 0x040007B7 RID: 1975
				MAIN_DISPLAY,
				// Token: 0x040007B8 RID: 1976
				HEARTBEAT_ICON_ENABLE,
				// Token: 0x040007B9 RID: 1977
				LEFT_DISPLAY,
				// Token: 0x040007BA RID: 1978
				ALERT_DISPLAY,
				// Token: 0x040007BB RID: 1979
				SPEED_UNIT,
				// Token: 0x040007BC RID: 1980
				X_BAND_ALERT_TONE,
				// Token: 0x040007BD RID: 1981
				K_BAND_ALERT_TONE,
				// Token: 0x040007BE RID: 1982
				K_BAND_BOGEY_TONE,
				// Token: 0x040007BF RID: 1983
				K_BAND_BOGEY_LEVEL,
				// Token: 0x040007C0 RID: 1984
				MRCD_ALERT_TONE,
				// Token: 0x040007C1 RID: 1985
				GATSO_ALERT_TONE,
				// Token: 0x040007C2 RID: 1986
				KA_BAND_ALERT_TONE,
				// Token: 0x040007C3 RID: 1987
				KA_BAND_BOGEY_TONE,
				// Token: 0x040007C4 RID: 1988
				LASER_ALERT_TONE,
				// Token: 0x040007C5 RID: 1989
				AUTO_MUTE_ALERT_LEVEL,
				// Token: 0x040007C6 RID: 1990
				AUTO_MUTE_VOLUME,
				// Token: 0x040007C7 RID: 1991
				ALERT_TEMPORARY_VOLUME,
				// Token: 0x040007C8 RID: 1992
				DARK_MODE_BRIGHTNESS,
				// Token: 0x040007C9 RID: 1993
				AUTO_DIM_SET_MODE_SELECT,
				// Token: 0x040007CA RID: 1994
				AUTO_DIM_SET_BRIGHT_TIME,
				// Token: 0x040007CB RID: 1995
				AUTO_DIM_SET_BRIGHT_BRIGHTNESS,
				// Token: 0x040007CC RID: 1996
				AUTO_DIM_SET_DIM_TIME,
				// Token: 0x040007CD RID: 1997
				AUTO_DIM_SET_DIM_BRIGHTNESS,
				// Token: 0x040007CE RID: 1998
				BACKLIGHT_MODE,
				// Token: 0x040007CF RID: 1999
				QRIDE_MODE,
				// Token: 0x040007D0 RID: 2000
				MRCD_QRIDE_ENABLE,
				// Token: 0x040007D1 RID: 2001
				QRIDE_VOLUME,
				// Token: 0x040007D2 RID: 2002
				LIMIT_SPEED_MODE,
				// Token: 0x040007D3 RID: 2003
				GMT,
				// Token: 0x040007D4 RID: 2004
				DST_ENABLE,
				// Token: 0x040007D5 RID: 2005
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x040007D6 RID: 2006
				VEHICLE_BATT_SAVER_ENABLE,
				// Token: 0x040007D7 RID: 2007
				SELF_TEST_ENABLE,
				// Token: 0x040007D8 RID: 2008
				MEMORY_QUOTA,
				// Token: 0x040007D9 RID: 2009
				MAIN_DIM_SET,
				// Token: 0x040007DA RID: 2010
				MAIN_VOLUME
			}
		}
	}
}
