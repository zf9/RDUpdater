using System;
using System.Linq;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000027 RID: 39
	internal static class UserSettingR7
	{
		// Token: 0x04000335 RID: 821
		public static UserSettingFormat[] user_setting = new UserSettingFormat[]
		{
			new UserSettingR7.v151(),
			new UserSettingR7.v146(),
			new UserSettingR7.v143()
		};

		// Token: 0x0200008E RID: 142
		private class v151 : UserSettingFormat
		{
			// Token: 0x060002E5 RID: 741 RVA: 0x0003B52D File Offset: 0x0003972D
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x0003B535 File Offset: 0x00039735
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0003B53D File Offset: 0x0003973D
			public byte[] GetNVDataMask()
			{
				return this.userNVDataPos;
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x000293C6 File Offset: 0x000275C6
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return op_mode != 1 && op_mode != 2 && op_mode != 3 && op_mode != 7;
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x0003B548 File Offset: 0x00039748
			public int user_k_block_get_level(int strength, int mode)
			{
				if (mode == 0)
				{
					if (strength <= 113)
					{
						return 8;
					}
					if (strength <= 115)
					{
						return 9;
					}
					if (strength <= 117)
					{
						return 10;
					}
					if (strength <= 120)
					{
						return 11;
					}
					if (strength <= 124)
					{
						return 12;
					}
					if (strength <= 128)
					{
						return 13;
					}
					if (strength <= 130)
					{
						return 14;
					}
					if (strength <= 132)
					{
						return 15;
					}
					if (strength <= 135)
					{
						return 16;
					}
					if (strength <= 138)
					{
						return 17;
					}
					if (strength <= 140)
					{
						return 18;
					}
					if (strength <= 142)
					{
						return 19;
					}
					if (strength <= 147)
					{
						return 20;
					}
					if (strength <= 152)
					{
						return 21;
					}
					if (strength <= 157)
					{
						return 22;
					}
					return 23;
				}
				else
				{
					if (strength <= 76)
					{
						return 8;
					}
					if (strength <= 82)
					{
						return 9;
					}
					if (strength <= 88)
					{
						return 10;
					}
					if (strength <= 94)
					{
						return 11;
					}
					if (strength <= 99)
					{
						return 12;
					}
					if (strength <= 104)
					{
						return 13;
					}
					if (strength <= 109)
					{
						return 14;
					}
					if (strength <= 115)
					{
						return 15;
					}
					if (strength <= 121)
					{
						return 16;
					}
					if (strength <= 128)
					{
						return 17;
					}
					if (strength <= 133)
					{
						return 18;
					}
					if (strength <= 138)
					{
						return 19;
					}
					if (strength <= 145)
					{
						return 20;
					}
					if (strength <= 152)
					{
						return 21;
					}
					if (strength <= 159)
					{
						return 22;
					}
					return 23;
				}
			}

			// Token: 0x060002EA RID: 746 RVA: 0x0003B680 File Offset: 0x00039880
			public int user_k_block_get_raw_strength(int level, int mode)
			{
				if (mode == 0)
				{
					if (level == 8)
					{
						return 113;
					}
					if (level == 9)
					{
						return 115;
					}
					if (level == 10)
					{
						return 117;
					}
					if (level == 11)
					{
						return 120;
					}
					if (level == 12)
					{
						return 124;
					}
					if (level == 13)
					{
						return 128;
					}
					if (level == 14)
					{
						return 130;
					}
					if (level == 15)
					{
						return 132;
					}
					if (level == 16)
					{
						return 135;
					}
					if (level == 17)
					{
						return 138;
					}
					if (level == 18)
					{
						return 140;
					}
					if (level == 19)
					{
						return 142;
					}
					if (level == 20)
					{
						return 147;
					}
					if (level == 21)
					{
						return 152;
					}
					if (level == 22)
					{
						return 157;
					}
					return 255;
				}
				else
				{
					if (level == 8)
					{
						return 76;
					}
					if (level == 9)
					{
						return 82;
					}
					if (level == 10)
					{
						return 88;
					}
					if (level == 11)
					{
						return 94;
					}
					if (level == 12)
					{
						return 99;
					}
					if (level == 13)
					{
						return 104;
					}
					if (level == 14)
					{
						return 109;
					}
					if (level == 15)
					{
						return 115;
					}
					if (level == 16)
					{
						return 121;
					}
					if (level == 17)
					{
						return 128;
					}
					if (level == 18)
					{
						return 133;
					}
					if (level == 19)
					{
						return 138;
					}
					if (level == 20)
					{
						return 145;
					}
					if (level == 21)
					{
						return 152;
					}
					if (level == 22)
					{
						return 159;
					}
					return 255;
				}
			}

			// Token: 0x060002EB RID: 747 RVA: 0x0003B7C8 File Offset: 0x000399C8
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
					2
				}, new string[]
				{
					"City",
					"Highway",
					"Advanced"
				}, "Highway - Full Sensitivity\nCity - X and K sensitivity reduced. Ka band sensitivity same as Highway.\nAdvanced - User adjusts X, K, and Ka band sensitivity from 100%~30% in 10% intervals.");
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
				array[5] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear K Attenuation", new int[]
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
				array[6] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear Ka Attenuation", new int[]
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
				array[7] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear X Attenuation", new int[]
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
				UserSettingMenu[] array2 = array;
				int num = 13;
				UserSettingMenu.MENU_TYPE menuType = UserSettingMenu.MENU_TYPE.GPS;
				string menuString = "POI PassChime";
				int[] array3 = new int[2];
				array3[0] = 1;
				array2[num] = new UserSettingMenu(menuType, menuString, array3, new string[]
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
				UserSettingMenu[] array4 = array;
				int num2 = 16;
				UserSettingMenu.MENU_TYPE menuType2 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString2 = "X Band On/Off";
				int[] array5 = new int[2];
				array5[0] = 1;
				array4[num2] = new UserSettingMenu(menuType2, menuString2, array5, new string[]
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
				UserSettingMenu[] array6 = array;
				int num3 = 20;
				UserSettingMenu.MENU_TYPE menuType3 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString3 = "Laser Gun ID On/Off";
				int[] array7 = new int[2];
				array7[0] = 1;
				array6[num3] = new UserSettingMenu(menuType3, menuString3, array7, new string[]
				{
					"Off",
					"On"
				}, "Turn on to display laser gun identifier.");
				UserSettingMenu[] array8 = array;
				int num4 = 21;
				UserSettingMenu.MENU_TYPE menuType4 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString4 = "K POP On/Off";
				int[] array9 = new int[2];
				array9[0] = 1;
				array8[num4] = new UserSettingMenu(menuType4, menuString4, array9, new string[]
				{
					"Off",
					"On"
				}, "Detects K POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[22] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "MRCD On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates MultaRadar CD/CT low - powered radar gun detection.");
				UserSettingMenu[] array10 = array;
				int num5 = 23;
				UserSettingMenu.MENU_TYPE menuType5 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString5 = "Gatso RT3/4 On/Off";
				int[] array11 = new int[2];
				array11[0] = 1;
				array10[num5] = new UserSettingMenu(menuType5, menuString5, array11, new string[]
				{
					"Off",
					"On"
				}, "Activates detection for Gatso radar guns.");
				UserSettingMenu[] array12 = array;
				int num6 = 24;
				UserSettingMenu.MENU_TYPE menuType6 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString6 = "Ka POP On/Off";
				int[] array13 = new int[2];
				array13[0] = 1;
				array12[num6] = new UserSettingMenu(menuType6, menuString6, array13, new string[]
				{
					"Off",
					"On"
				}, "Detects Ka POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[25] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Filter", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the K band to prevent false detections.");
				UserSettingMenu[] array14 = array;
				int num7 = 26;
				UserSettingMenu.MENU_TYPE menuType7 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString7 = "Ka Filter";
				int[] array15 = new int[2];
				array15[0] = 1;
				array14[num7] = new UserSettingMenu(menuType7, menuString7, array15, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the Ka band to prevent false detections.");
				UserSettingMenu[] array16 = array;
				int num8 = 27;
				UserSettingMenu.MENU_TYPE menuType8 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString8 = "TSF";
				int[] array17 = new int[2];
				array17[0] = 1;
				array16[num8] = new UserSettingMenu(menuType8, menuString8, array17, new string[]
				{
					"Off",
					"On"
				}, "Traffic Sensor Filter. Prevents false alarms caused by traffic monitoring radar systems.");
				int[] array18 = new int[351];
				string[] array19 = new string[351];
				for (int i = 0; i < 351; i++)
				{
					array18[i] = 23900 + i;
					array19[i] = array18[i].ToString();
				}
				array[28] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block1 Filter Mode", new int[]
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
				array[29] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[30] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter Direction", new int[]
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
				array[31] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter Minimum Frequency", array18, array19, "Set K Block1 Filter minimum frequency.");
				array[32] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter Maximum Frequency", array18, array19, "Set K Block1 Filter maximum frequency.");
				array[33] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block2 Filter Mode", new int[]
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
				array[34] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[35] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter Direction", new int[]
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
				array[36] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter Minimum Frequency", array18, array19, "Set K Block2 Filter minimum frequency.");
				array[37] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter Maximum Frequency", array18, array19, "Set K Block2 Filter maximum frequency.");
				array[38] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block3 Filter Mode", new int[]
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
				array[39] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[40] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter Direction", new int[]
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
				array[41] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter Minimum Frequency", array18, array19, "Set K Block3 Filter minimum frequency.");
				array[42] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter Maximum Frequency", array18, array19, "Set K Block3 Filter maximum frequency.");
				array[43] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block1 Filter Mode", new int[]
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
				array[44] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[45] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block1 Filter Direction", new int[]
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
				array[46] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block1 Filter Minimum Frequency", array18, array19, "Set User K Block1 Filter minimum frequency.");
				array[47] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block1 Filter Maximum Frequency", array18, array19, "Set User K Block1 Filter maximum frequency.");
				array[48] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block2 Filter Mode", new int[]
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
				array[49] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[50] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block2 Filter Direction", new int[]
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
				array[51] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block2 Filter Minimum Frequency", array18, array19, "Set User K Block2 Filter minimum frequency.");
				array[52] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block2 Filter Maximum Frequency", array18, array19, "Set User K Block2 Filter maximum frequency.");
				array[53] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block3 Filter Mode", new int[]
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
				array[54] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[55] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block3 Filter Direction", new int[]
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
				array[56] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block3 Filter Minimum Frequency", array18, array19, "Set User K Block3 Filter minimum frequency.");
				array[57] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block3 Filter Maximum Frequency", array18, array19, "Set User K Block3 Filter maximum frequency.");
				array[58] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block4 Filter Mode", new int[]
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
				array[59] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[60] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block4 Filter Direction", new int[]
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
				array[61] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block4 Filter Minimum Frequency", array18, array19, "Set User K Block4 Filter minimum frequency.");
				array[62] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block4 Filter Maximum Frequency", array18, array19, "Set User K Block4 Filter maximum frequency.");
				array[63] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block5 Filter Mode", new int[]
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
				array[64] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[65] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block5 Filter Direction", new int[]
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
				array[66] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block5 Filter Minimum Frequency", array18, array19, "Set User K Block5 Filter minimum frequency.");
				array[67] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block5 Filter Maximum Frequency", array18, array19, "Set User K Block5 Filter maximum frequency.");
				array[68] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Narrow/Wide/Extended", new int[]
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
				array[69] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Narrow/Wide/Segmentation", new int[]
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
				UserSettingMenu[] array20 = array;
				int num9 = 70;
				UserSettingMenu.MENU_TYPE menuType9 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString9 = "Ka Segmentation 33.399Ghz – 33.705Ghz";
				int[] array21 = new int[2];
				array21[0] = 1;
				array20[num9] = new UserSettingMenu(menuType9, menuString9, array21, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.399Ghz – 33.705Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array22 = array;
				int num10 = 71;
				UserSettingMenu.MENU_TYPE menuType10 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString10 = "Ka Segmentation 33.705Ghz – 33.903Ghz";
				int[] array23 = new int[2];
				array23[0] = 1;
				array22[num10] = new UserSettingMenu(menuType10, menuString10, array23, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.705Ghz – 33.903Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array24 = array;
				int num11 = 72;
				UserSettingMenu.MENU_TYPE menuType11 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString11 = "Ka Segmentation 33.903Ghz – 34.191Ghz";
				int[] array25 = new int[2];
				array25[0] = 1;
				array24[num11] = new UserSettingMenu(menuType11, menuString11, array25, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.903Ghz – 34.191Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array26 = array;
				int num12 = 73;
				UserSettingMenu.MENU_TYPE menuType12 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString12 = "Ka Segmentation 34.191Ghz – 34.587Ghz";
				int[] array27 = new int[2];
				array27[0] = 1;
				array26[num12] = new UserSettingMenu(menuType12, menuString12, array27, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.191Ghz – 34.587Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array28 = array;
				int num13 = 74;
				UserSettingMenu.MENU_TYPE menuType13 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString13 = "Ka Segmentation 34.587Ghz – 34.803Ghz";
				int[] array29 = new int[2];
				array29[0] = 1;
				array28[num13] = new UserSettingMenu(menuType13, menuString13, array29, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.587Ghz – 34.803Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array30 = array;
				int num14 = 75;
				UserSettingMenu.MENU_TYPE menuType14 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString14 = "Ka Segmentation 34.803Ghz – 35.163Ghz";
				int[] array31 = new int[2];
				array31[0] = 1;
				array30[num14] = new UserSettingMenu(menuType14, menuString14, array31, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.803Ghz – 35.163Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array32 = array;
				int num15 = 76;
				UserSettingMenu.MENU_TYPE menuType15 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString15 = "Ka Segmentation 35.163Ghz – 35.379Ghz";
				int[] array33 = new int[2];
				array33[0] = 1;
				array32[num15] = new UserSettingMenu(menuType15, menuString15, array33, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.163Ghz – 35.379Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array34 = array;
				int num16 = 77;
				UserSettingMenu.MENU_TYPE menuType16 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString16 = "Ka Segmentation 35.379Ghz – 35.613Ghz";
				int[] array35 = new int[2];
				array35[0] = 1;
				array34[num16] = new UserSettingMenu(menuType16, menuString16, array35, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.379Ghz – 35.613Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array36 = array;
				int num17 = 78;
				UserSettingMenu.MENU_TYPE menuType17 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString17 = "Ka Segmentation 35.613Ghz – 35.701Ghz";
				int[] array37 = new int[2];
				array37[0] = 1;
				array36[num17] = new UserSettingMenu(menuType17, menuString17, array37, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.613Ghz – 35.701Ghz (Ka Segmentation mode)");
				array[79] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Priority", new int[]
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
				array[80] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Select bands to be muted.");
				array[81] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute Memory On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "This menu turns the ability to automatically save mute requests for specific locations/frequency bands.");
				array[82] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Auto Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Auto Mute Memory Band Option Set specifies which bands will be muted.");
				UserSettingMenu[] array38 = array;
				int num18 = 83;
				UserSettingMenu.MENU_TYPE menuType18 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString18 = "All Threat Display";
				int[] array39 = new int[2];
				array39[0] = 1;
				array38[num18] = new UserSettingMenu(menuType18, menuString18, array39, new string[]
				{
					"Off",
					"On"
				}, "Displays if more than one radar signals are detected at the same time. The signal with the strongest radar signal is considered the main signal. The other signals are displayed on the left side.");
				array[84] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Background Color", new int[]
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
				array[85] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
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
				array[86] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
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
				array[87] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red"
				}, "Set MRCD arrow color.");
				array[88] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "GATSO RT3/4 Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
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
				array[89] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
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
				array[90] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Color", new int[]
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
				array[91] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Color", new int[]
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
				array[92] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD Color", new int[]
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
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red",
					"Arrow",
					"Signal"
				}, "Set MRCD indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[93] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Gatso RT3/4 Color", new int[]
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
				array[94] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Color", new int[]
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
				array[95] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Display", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Mode",
					"Scan",
					"Time"
				}, "Select what will display on the OLED, either scanning for frequencies, the mode, or the time.\n(GPS On)");
				UserSettingMenu[] array40 = array;
				int num19 = 96;
				UserSettingMenu.MENU_TYPE menuType19 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString19 = "Scan Icon";
				int[] array41 = new int[2];
				array41[0] = 1;
				array40[num19] = new UserSettingMenu(menuType19, menuString19, array41, new string[]
				{
					"Off",
					"On"
				}, "Scan Icon displays to indicate the end of a scan cycle.");
				array[97] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Left Display", new int[]
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
				UserSettingMenu[] array42 = array;
				int num20 = 98;
				UserSettingMenu.MENU_TYPE menuType20 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString20 = "Alert Display";
				int[] array43 = new int[2];
				array43[0] = 1;
				array42[num20] = new UserSettingMenu(menuType20, menuString20, array43, new string[]
				{
					"Type 1",
					"Type 2"
				}, "Select one of two OLED display formats.");
				UserSettingMenu[] array44 = array;
				int num21 = 99;
				UserSettingMenu.MENU_TYPE menuType21 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString21 = "Speed Unit";
				int[] array45 = new int[2];
				array45[0] = 1;
				array44[num21] = new UserSettingMenu(menuType21, menuString21, array45, new string[]
				{
					"mph",
					"km/h"
				}, "Select the speed measurement type.");
				array[99].isUnitMenuFlag = true;
				array[100] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "X Band Alert Tone", new int[]
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
				array[101] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Alert Tone", new int[]
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
				array[102] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Tone", new int[]
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
				array[103] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Level", new int[]
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
				array[104] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "MRCD Alert Tone", new int[]
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
				}, "Set a tone to indicate MRCD.");
				array[105] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "GATSO RT3/4 Alert Tone", new int[]
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
				array[106] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Alert Tone", new int[]
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
				array[107] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Bogey Tone", new int[]
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
				array[108] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Laser Alert Tone", new int[]
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
				array[109] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Alert Level", new int[]
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
				array[110] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Volume", new int[]
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
				UserSettingMenu[] array46 = array;
				int num22 = 111;
				UserSettingMenu.MENU_TYPE menuType22 = UserSettingMenu.MENU_TYPE.SOUND;
				string menuString22 = "Alert Temporary Volume";
				int[] array47 = new int[2];
				array47[0] = 1;
				array46[num22] = new UserSettingMenu(menuType22, menuString22, array47, new string[]
				{
					"Off",
					"On"
				}, "Temporary volume function On/Off.");
				UserSettingMenu[] array48 = array;
				int num23 = 112;
				UserSettingMenu.MENU_TYPE menuType23 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString23 = "Rear K Band Mute";
				int[] array49 = new int[2];
				array49[0] = 1;
				array48[num23] = new UserSettingMenu(menuType23, menuString23, array49, new string[]
				{
					"Off",
					"On"
				}, "Mutes K band signals from rear side.");
				array[113] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Dark mode Brightness", new int[]
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
				array[114] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Brightness", new int[]
				{
					4,
					3,
					2
				}, new string[]
				{
					"Bright",
					"Dim",
					"Dimmer"
				}, "The R7 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[115] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Brightness", new int[]
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
				}, "The R7 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[116] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Quiet Ride", new int[][]
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
				UserSettingMenu[] array50 = array;
				int num24 = 117;
				UserSettingMenu.MENU_TYPE menuType24 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString24 = "Quiet Ride MRCD On/Off";
				int[] array51 = new int[2];
				array51[0] = 1;
				array50[num24] = new UserSettingMenu(menuType24, menuString24, array51, new string[]
				{
					"Off",
					"On"
				}, "Mutes MRCD alarms when users drive under the speed limit set previously.");
				array[118] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Quiet Ride Volume", new int[]
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
				array[119] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Limit Speed", new int[][]
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
				array[120] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "GMT", new int[]
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
				UserSettingMenu[] array52 = array;
				int num25 = 121;
				UserSettingMenu.MENU_TYPE menuType25 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString25 = "DST";
				int[] array53 = new int[2];
				array53[0] = 1;
				array52[num25] = new UserSettingMenu(menuType25, menuString25, array53, new string[]
				{
					"Off",
					"On"
				}, "Daylight Saving Time");
				UserSettingMenu[] array54 = array;
				int num26 = 122;
				UserSettingMenu.MENU_TYPE menuType26 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString26 = "Low Battery Warning";
				int[] array55 = new int[2];
				array55[0] = 1;
				array54[num26] = new UserSettingMenu(menuType26, menuString26, array55, new string[]
				{
					"Off",
					"On"
				}, "Sounds a warning tone if the vehicle battery power drops below 11V.");
				UserSettingMenu[] array56 = array;
				int num27 = 123;
				UserSettingMenu.MENU_TYPE menuType27 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString27 = "Vehicle Battery Saver";
				int[] array57 = new int[2];
				array57[0] = 1;
				array56[num27] = new UserSettingMenu(menuType27, menuString27, array57, new string[]
				{
					"Off",
					"On"
				}, "Turns off power to the R7 if the speed stays at 0 or if the GPS is not connected for more than an hour.");
				array[124] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Self Test", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Runs a self diagnostic test on the unit to check for faults.");
				array[125] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Memory Quota", new int[]
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
				array[126] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Dim", new int[]
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
				array[127] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Main Volume", new int[]
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

			// Token: 0x060002EC RID: 748 RVA: 0x0003E2DC File Offset: 0x0003C4DC
			private bool user_k_block_n_data_check_previous(byte[][] userSettingData, int rd_addr)
			{
				int num = ((int)userSettingData[rd_addr][0] << 24) + ((int)userSettingData[rd_addr][1] << 16) + ((int)userSettingData[rd_addr][2] << 8) + (int)userSettingData[rd_addr][3];
				int num2 = (num & 261632) >> 9;
				int num3 = num & 511;
				return num2 == 511 && num3 == 511;
			}

			// Token: 0x060002ED RID: 749 RVA: 0x0003E330 File Offset: 0x0003C530
			private static bool usr_mem_check_previous_verion_k_blk_format_paring_only_block3(byte[][] userSettingData, int rd_addr)
			{
				int num = ((int)userSettingData[rd_addr][0] << 24) + ((int)userSettingData[rd_addr][1] << 16) + ((int)userSettingData[rd_addr][2] << 8) + (int)userSettingData[rd_addr][3];
				int num2 = (num & 261632) >> 9;
				int num3 = num & 511;
				return (num2 == 511 && num3 == 511) || num == 402766560;
			}

			// Token: 0x060002EE RID: 750 RVA: 0x0002BBAB File Offset: 0x00029DAB
			private int user_k_block_n_data_raw_strength_read(byte[][] userSettingData, int rd_addr)
			{
				return (((int)userSettingData[rd_addr][3] << 24) + ((int)userSettingData[rd_addr][2] << 16) + ((int)userSettingData[rd_addr][1] << 8) + (int)userSettingData[rd_addr][0] & 66846720) >> 18;
			}

			// Token: 0x060002EF RID: 751 RVA: 0x0003E38C File Offset: 0x0003C58C
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

			// Token: 0x060002F0 RID: 752 RVA: 0x0003E450 File Offset: 0x0003C650
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

			// Token: 0x060002F1 RID: 753 RVA: 0x0003E554 File Offset: 0x0003C754
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
				int num = array2[2][3] >> 6 & (int)BinaryDefine.b00000001;
				array[83] = (array2[2][3] >> 5 & (int)BinaryDefine.b00000001);
				array[84] = (array2[2][3] >> 2 & (int)BinaryDefine.b00000111);
				int num2 = array2[2][3] >> 1 & (int)BinaryDefine.b00000001;
				array[27] = (int)(array2[2][3] & BinaryDefine.b00000001);
				if (array[84] > 7)
				{
					array[84] = 5;
				}
				array[26] = (array2[2][2] >> 7 & (int)BinaryDefine.b00000001);
				array[14] = (array2[2][2] >> 6 & (int)BinaryDefine.b00000001);
				array[16] = (array2[2][2] >> 5 & (int)BinaryDefine.b00000001);
				array[17] = (array2[2][2] >> 4 & (int)BinaryDefine.b00000001);
				array[18] = (array2[2][2] >> 3 & (int)BinaryDefine.b00000001);
				array[19] = (array2[2][2] >> 2 & (int)BinaryDefine.b00000001);
				array[24] = (array2[2][2] >> 1 & (int)BinaryDefine.b00000001);
				array[25] = (int)(array2[2][2] & BinaryDefine.b00000001);
				array[8] = (array2[2][1] >> 7 & (int)BinaryDefine.b00000001);
				byte b3 = array2[2][1];
				byte b4 = BinaryDefine.b00000111;
				int num3 = array2[2][1] >> 3 & (int)BinaryDefine.b00000001;
				array[122] = (array2[2][1] >> 1 & (int)BinaryDefine.b00000001);
				array[124] = (int)(array2[2][1] & BinaryDefine.b00000001);
				int num4 = array2[2][0] >> 7 & (int)BinaryDefine.b00000001;
				array[126] = (array2[2][0] >> 4 & (int)BinaryDefine.b00000111);
				int num5 = array2[2][0] >> 3 & (int)BinaryDefine.b00000001;
				int num6 = (int)(array2[2][0] & BinaryDefine.b00000111);
				if (array[126] > 5)
				{
					array[126] = 5;
				}
				array[99] = (array2[1][2] >> 7 & (int)BinaryDefine.b00000001);
				int num7 = array2[1][2] >> 6 & (int)BinaryDefine.b00000001;
				array[121] = (array2[1][2] >> 5 & (int)BinaryDefine.b00000001);
				array[123] = (array2[1][2] >> 4 & (int)BinaryDefine.b00000001);
				int num8 = (int)(array2[1][2] & BinaryDefine.b00001111);
				if (array[99] == 1)
				{
					if (num8 >= 0 && num8 <= 10)
					{
						array[116] = num8 * 5;
					}
					else
					{
						array[116] = 0;
					}
				}
				else if (num8 >= 0 && num8 <= 8)
				{
					array[116] = num8 * 10;
				}
				else
				{
					array[116] = 0;
				}
				bool flag = (array2[1][3] >> 6 & (int)BinaryDefine.b00000001) != 0;
				array[21] = (array2[1][3] >> 5 & (int)BinaryDefine.b00000001);
				num8 = (int)(array2[1][3] & BinaryDefine.b00011111);
				if (array[99] == 1)
				{
					if (num8 == 0 || (num8 >= 10 && num8 <= 17))
					{
						array[12] = num8 * 5;
					}
					else
					{
						array[12] = 0;
					}
				}
				else if (num8 == 0 || (num8 >= 8 && num8 <= 14))
				{
					array[12] = num8 * 10;
				}
				else
				{
					array[12] = 0;
				}
				if (!flag)
				{
					if (array[99] == 1)
					{
						array[116] += 55;
					}
					else
					{
						array[116] += 90;
					}
				}
				array[9] = (array2[1][1] >> 6 & (int)BinaryDefine.b00000001);
				array[11] = (array2[1][1] >> 5 & (int)BinaryDefine.b00000001);
				num8 = (int)(array2[1][1] & BinaryDefine.b00011111);
				if (array[99] == 1)
				{
					if (num8 == 0 || (num8 >= 10 && num8 <= 20))
					{
						array[119] = num8 * 5;
					}
					else
					{
						array[119] = 0;
					}
				}
				else if (num8 == 0 || (num8 >= 8 && num8 <= 16))
				{
					array[119] = num8 * 10;
				}
				else
				{
					array[119] = 0;
				}
				int num9 = array2[1][0] >> 5 & (int)BinaryDefine.b00000111;
				num8 = (int)(array2[1][0] & BinaryDefine.b00011111);
				if (num9 >= 6)
				{
					if (array[8] == 1)
					{
						num9 = 4;
					}
					else
					{
						num9 = 2;
					}
				}
				if (num8 != 31)
				{
					array[120] = (int)((byte)num8 - 12);
					if (array[120] < -12 || array[120] > 12)
					{
						array[120] = -8;
					}
				}
				else
				{
					array[120] = -8;
				}
				array[80] = (array2[3][3] >> 6 & (int)BinaryDefine.b00000001);
				array[15] = (array2[3][3] >> 5 & (int)BinaryDefine.b00000001);
				bool flag2 = (array2[3][3] >> 4 & (int)BinaryDefine.b00000001) != 0;
				int num10 = array2[3][3] >> 3 & (int)BinaryDefine.b00000001;
				array[110] = (int)(array2[3][3] & BinaryDefine.b00000111);
				if (array[110] < 0 || array[110] > 7)
				{
					array[110] = 2;
				}
				array[22] = (array2[3][2] >> 7 & (int)BinaryDefine.b00000001);
				int num11 = array2[3][2] >> 6 & (int)BinaryDefine.b00000001;
				array[2] = (array2[3][2] >> 3 & (int)BinaryDefine.b00000111);
				array[3] = (int)(array2[3][2] & BinaryDefine.b00000111);
				int num12 = array2[3][1] >> 7 & (int)BinaryDefine.b00000001;
				int num13 = array2[3][1] >> 6 & (int)BinaryDefine.b00000001;
				array[98] = (array2[3][1] >> 5 & (int)BinaryDefine.b00000001);
				array[78] = (array2[3][1] >> 3 & (int)BinaryDefine.b00000001);
				array[4] = (int)(array2[3][1] & BinaryDefine.b00000111);
				array[77] = (array2[3][0] >> 7 & (int)BinaryDefine.b00000001);
				array[76] = (array2[3][0] >> 6 & (int)BinaryDefine.b00000001);
				array[75] = (array2[3][0] >> 5 & (int)BinaryDefine.b00000001);
				array[74] = (array2[3][0] >> 4 & (int)BinaryDefine.b00000001);
				array[73] = (array2[3][0] >> 3 & (int)BinaryDefine.b00000001);
				array[72] = (array2[3][0] >> 2 & (int)BinaryDefine.b00000001);
				array[71] = (array2[3][0] >> 1 & (int)BinaryDefine.b00000001);
				array[70] = (int)(array2[3][0] & BinaryDefine.b00000001);
				array[114] = (array2[4][3] >> 3 & (int)BinaryDefine.b00000111);
				array[115] = (int)(array2[4][3] & BinaryDefine.b00000111);
				if (array[114] < 2 || array[114] > 4)
				{
					array[114] = 4;
				}
				if (array[115] > 4)
				{
					array[115] = 3;
				}
				array[100] = (array2[4][2] >> 4 & (int)BinaryDefine.b00001111);
				array[101] = (int)(array2[4][2] & BinaryDefine.b00001111);
				array[108] = (array2[4][1] >> 4 & (int)BinaryDefine.b00001111);
				array[106] = (int)(array2[4][1] & BinaryDefine.b00001111);
				array[107] = (array2[5][3] >> 4 & (int)BinaryDefine.b00000111);
				array[104] = (int)(array2[5][3] & BinaryDefine.b00001111);
				array[20] = (array2[5][2] >> 7 & (int)BinaryDefine.b00000001);
				array[81] = (array2[5][2] >> 6 & (int)BinaryDefine.b00000001);
				int num14 = array2[5][2] >> 5 & (int)BinaryDefine.b00000001;
				array[113] = (int)(array2[5][2] & BinaryDefine.b00000111);
				if (array[113] < 2 || array[113] > 4)
				{
					array[113] = 2;
				}
				bool flag3 = (array2[5][1] >> 7 & (int)BinaryDefine.b00000001) != 0;
				array[86] = (array2[5][1] >> 3 & (int)BinaryDefine.b00000111);
				array[85] = (int)(array2[5][1] & BinaryDefine.b00000111);
				if (!flag3)
				{
					num6 = 8;
				}
				if (array[86] > 6)
				{
					array[86] = 6;
				}
				if (array[85] > 6)
				{
					array[85] = 6;
				}
				if (num6 >= 0 && num6 <= 8)
				{
					array[127] = num6;
				}
				else
				{
					array[127] = 4;
				}
				array[0] = (array2[5][0] >> 7 & (int)BinaryDefine.b00000001);
				array[117] = (array2[5][0] >> 6 & (int)BinaryDefine.b00000001);
				array[89] = (array2[5][0] >> 3 & (int)BinaryDefine.b00000111);
				array[87] = (int)(array2[5][0] & BinaryDefine.b00000111);
				if (array[89] > 6)
				{
					array[89] = 6;
				}
				if (array[87] > 6)
				{
					array[87] = 6;
				}
				if (array[100] > 12 || array[100] == 0)
				{
					array[100] = 1;
				}
				if (array[101] > 12 || array[101] == 0)
				{
					array[101] = 2;
				}
				if (array[104] > 12 || array[104] == 0)
				{
					array[104] = 2;
				}
				if (array[106] > 12 || array[106] == 0)
				{
					array[106] = 3;
				}
				if (array[107] > 6 || array[107] == 0)
				{
					array[107] = 1;
				}
				if (array[108] > 12 || array[108] == 0)
				{
					array[108] = 4;
				}
				array[91] = (array2[6][3] >> 4 & (int)BinaryDefine.b00001111);
				array[90] = (int)(array2[6][3] & BinaryDefine.b00001111);
				if (array[91] > 8)
				{
					array[91] = 8;
				}
				if (array[90] > 8)
				{
					array[90] = 8;
				}
				array[94] = (array2[6][2] >> 4 & (int)BinaryDefine.b00001111);
				array[92] = (int)(array2[6][2] & BinaryDefine.b00001111);
				if (array[94] > 8)
				{
					array[94] = 8;
				}
				if (array[92] > 8)
				{
					array[92] = 8;
				}
				if ((array2[6][1] >> 5 & (int)BinaryDefine.b00000001) == 1)
				{
					if (num11 == 0 && num7 == 1)
					{
						array[96] = 0;
					}
					else
					{
						array[96] = 1;
					}
				}
				else
				{
					array[96] = (array2[6][1] >> 4 & (int)BinaryDefine.b00000001);
				}
				int num15 = array2[6][1] >> 7 & (int)BinaryDefine.b00000001;
				int num16 = array2[6][1] >> 6 & (int)BinaryDefine.b00000001;
				array[5] = (int)(array2[6][1] & BinaryDefine.b00001111);
				if (array[5] > 8)
				{
					array[5] = 8;
				}
				if (array[5] == 0)
				{
					array[5] = 8;
				}
				array[10] = (array2[6][0] >> 5 & (int)BinaryDefine.b00000111);
				array[118] = (array2[6][0] >> 1 & (int)BinaryDefine.b00001111);
				array[112] = (int)(array2[6][0] & BinaryDefine.b00000001);
				if (array[10] > 4)
				{
					array[10] = 1;
				}
				if (array[118] > 8)
				{
					array[118] = 1;
				}
				array[102] = (array2[7][3] >> 4 & (int)BinaryDefine.b00000111);
				array[13] = (array2[7][3] >> 3 & (int)BinaryDefine.b00000001);
				int num17 = array2[7][3] >> 2 & (int)BinaryDefine.b00000001;
				int num18 = array2[7][3] >> 1 & (int)BinaryDefine.b00000001;
				int num19 = (int)(array2[7][3] & BinaryDefine.b00000001);
				if (array[102] > 6 || array[102] == 0)
				{
					array[102] = 1;
				}
				array[82] = (int)(array2[7][1] & BinaryDefine.b00000011);
				if (array[82] != 1 && array[82] != 0)
				{
					array[82] = array[80];
				}
				array[23] = (array2[8][3] >> 7 & (int)BinaryDefine.b00000001);
				array[88] = (array2[8][3] >> 4 & (int)BinaryDefine.b00000111);
				array[93] = (int)(array2[8][3] & BinaryDefine.b00001111);
				if (array[88] > 6)
				{
					array[88] = 6;
				}
				if (array[93] > 8)
				{
					array[93] = 8;
				}
				array[103] = (array2[8][2] >> 4 & (int)BinaryDefine.b00001111);
				array[105] = (int)(array2[8][2] & BinaryDefine.b00001111);
				if (array[103] > 8 || array[103] < 1)
				{
					array[103] = 4;
				}
				if (array[105] > 12 || array[105] == 0)
				{
					array[105] = 9;
				}
				array[109] = (array2[8][1] >> 1 & (int)BinaryDefine.b00001111);
				array[111] = (int)(array2[8][1] & BinaryDefine.b00000001);
				if (array[109] > 8)
				{
					if (num3 == 1)
					{
						array[109] = 8;
					}
					else
					{
						array[109] = 0;
					}
				}
				array[6] = (array2[8][0] >> 4 & (int)BinaryDefine.b00001111);
				array[7] = (int)(array2[8][0] & BinaryDefine.b00001111);
				if (array[6] > 8)
				{
					array[6] = 8;
				}
				if (array[6] == 0)
				{
					array[6] = 8;
				}
				if (array[7] > 8)
				{
					array[7] = 8;
				}
				if (array[7] == 0)
				{
					array[7] = 8;
				}
				if (num == 1 && num5 == 0)
				{
					array[1] = 0;
				}
				else if (num == 1 && num5 == 1)
				{
					array[1] = 1;
				}
				else if (num == 0)
				{
					array[1] = 2;
				}
				if (this.user_k_block_n_data_check_previous(array2, 14))
				{
					if (num13 == 0)
					{
						array[28] = 23;
						array[29] = 255;
					}
					else if (num16 == 0)
					{
						array[28] = 1;
						array[29] = 0;
					}
					else if (num15 == 0)
					{
						array[28] = 3;
						array[29] = 0;
					}
					else
					{
						array[28] = 7;
						array[29] = 0;
					}
					array[30] = 2;
					array[31] = 24194;
					array[32] = 24204;
					this.user_k_block_n_data_write(array2, 14, array, 28, array[1]);
				}
				if (this.user_k_block_n_data_check_previous(array2, 15))
				{
					if (num17 == 0)
					{
						array[33] = 23;
						array[34] = 255;
					}
					else if (num19 == 0)
					{
						array[33] = 1;
						array[34] = 0;
					}
					else if (num18 == 0)
					{
						array[33] = 3;
						array[34] = 0;
					}
					else
					{
						array[33] = 7;
						array[34] = 0;
					}
					array[35] = 2;
					array[36] = 24166;
					array[37] = 24170;
					this.user_k_block_n_data_write(array2, 15, array, 33, array[1]);
				}
				if (UserSettingR7.v151.usr_mem_check_previous_verion_k_blk_format_paring_only_block3(array2, 16))
				{
					array[38] = 1;
					array[39] = 0;
					array[40] = 2;
					array[41] = 24123;
					array[42] = 24124;
					this.user_k_block_n_data_write(array2, 16, array, 38, array[1]);
				}
				this.user_k_block_n_data_read(array2, 14, array, 28, array[1]);
				this.user_k_block_n_data_read(array2, 15, array, 33, array[1]);
				this.user_k_block_n_data_read(array2, 16, array, 38, array[1]);
				this.user_k_block_n_data_read(array2, 9, array, 43, array[1]);
				this.user_k_block_n_data_read(array2, 10, array, 48, array[1]);
				this.user_k_block_n_data_read(array2, 11, array, 53, array[1]);
				this.user_k_block_n_data_read(array2, 12, array, 58, array[1]);
				this.user_k_block_n_data_read(array2, 13, array, 63, array[1]);
				if (num4 == 0)
				{
					array[68] = 0;
				}
				else if (num14 == 0)
				{
					array[68] = 2;
				}
				else
				{
					array[68] = 1;
				}
				if (!flag2)
				{
					if (num2 == 1)
					{
						array[69] = 1;
					}
					else
					{
						array[69] = 0;
					}
				}
				else
				{
					array[69] = 2;
				}
				if (num10 == 1)
				{
					array[79] = 0;
				}
				else if (num12 == 1)
				{
					array[79] = 2;
				}
				else
				{
					array[79] = 1;
				}
				if (num11 == 0)
				{
					if (num7 == 1)
					{
						array[95] = 1;
					}
					else
					{
						array[95] = 2;
					}
				}
				else
				{
					array[95] = 0;
				}
				array[97] = num9;
				array[125] = (int)nvData[256];
				return array;
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x0003F1BC File Offset: 0x0003D3BC
			public byte[] GetNVDataFromUserSetting(int[] userSettingR7, byte[] receivedNVData)
			{
				if (this.menuCnt == 0)
				{
					return null;
				}
				byte[][] array = new byte[17][];
				byte[] array2 = new byte[receivedNVData.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = new byte[4];
					for (int j = 0; j < 4; j++)
					{
						array[i][j] = 0;
					}
				}
				byte b;
				byte b2;
				if (userSettingR7[1] == 2)
				{
					b = 0;
					b2 = 0;
				}
				else if (userSettingR7[1] == 1)
				{
					b = 1;
					b2 = 1;
				}
				else
				{
					if (userSettingR7[1] != 0)
					{
						return null;
					}
					b = 1;
					b2 = 0;
				}
				byte b3;
				byte b4;
				if (userSettingR7[68] == 2)
				{
					b3 = 1;
					b4 = 0;
				}
				else if (userSettingR7[68] == 1)
				{
					b3 = 1;
					b4 = 1;
				}
				else
				{
					if (userSettingR7[68] != 0)
					{
						return null;
					}
					b3 = 0;
					b4 = 1;
				}
				byte b5;
				byte b6;
				if (userSettingR7[69] == 2)
				{
					b5 = 0;
					b6 = 1;
				}
				else if (userSettingR7[69] == 1)
				{
					b5 = 1;
					b6 = 0;
				}
				else
				{
					if (userSettingR7[69] != 0)
					{
						return null;
					}
					b5 = 0;
					b6 = 0;
				}
				byte b7;
				byte b8;
				if (userSettingR7[79] == 2)
				{
					b7 = 0;
					b8 = 1;
				}
				else if (userSettingR7[79] == 1)
				{
					b7 = 0;
					b8 = 0;
				}
				else
				{
					if (userSettingR7[79] != 0)
					{
						return null;
					}
					b7 = 1;
					b8 = 0;
				}
				byte b9;
				byte b10;
				if (userSettingR7[95] == 2)
				{
					b9 = 0;
					b10 = 0;
				}
				else if (userSettingR7[95] == 1)
				{
					b9 = 0;
					b10 = 1;
				}
				else
				{
					if (userSettingR7[95] != 0)
					{
						return null;
					}
					b9 = 1;
					b10 = 1;
				}
				byte b11;
				if (userSettingR7[99] == 1)
				{
					if (userSettingR7[116] > 50)
					{
						b11 = 0;
					}
					else
					{
						b11 = 1;
					}
				}
				else
				{
					if (userSettingR7[99] != 0)
					{
						return null;
					}
					if (userSettingR7[116] > 80)
					{
						b11 = 0;
					}
					else
					{
						b11 = 1;
					}
				}
				byte b12 = (byte)userSettingR7[97];
				byte[] array3 = array[2];
				int num = 3;
				array3[num] |= (byte)((int)b << 6 & (int)BinaryDefine.b01000000);
				byte[] array4 = array[2];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR7[83] << 5 & (int)BinaryDefine.b00100000);
				byte[] array5 = array[2];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR7[84] << 2 & (int)BinaryDefine.b00011100);
				byte[] array6 = array[2];
				int num4 = 3;
				array6[num4] |= (byte)((int)b5 << 1 & (int)BinaryDefine.b00000010);
				byte[] array7 = array[2];
				int num5 = 3;
				array7[num5] |= (byte)(userSettingR7[27] & (int)BinaryDefine.b00000001);
				byte[] array8 = array[2];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR7[26] << 7 & (int)BinaryDefine.b10000000);
				byte[] array9 = array[2];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR7[14] << 6 & (int)BinaryDefine.b01000000);
				byte[] array10 = array[2];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR7[16] << 5 & (int)BinaryDefine.b00100000);
				byte[] array11 = array[2];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR7[17] << 4 & (int)BinaryDefine.b00010000);
				byte[] array12 = array[2];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR7[18] << 3 & (int)BinaryDefine.b00001000);
				byte[] array13 = array[2];
				int num11 = 2;
				array13[num11] |= (byte)(userSettingR7[19] << 2 & (int)BinaryDefine.b00000100);
				byte[] array14 = array[2];
				int num12 = 2;
				array14[num12] |= (byte)(userSettingR7[24] << 1 & (int)BinaryDefine.b00000010);
				byte[] array15 = array[2];
				int num13 = 2;
				array15[num13] |= (byte)(userSettingR7[25] & (int)BinaryDefine.b00000001);
				byte[] array16 = array[2];
				int num14 = 1;
				array16[num14] |= (byte)(userSettingR7[8] << 7 & (int)BinaryDefine.b10000000);
				if (userSettingR7[109] == 0)
				{
					byte[] array17 = array[2];
					int num15 = 1;
					// DECOMPILE-FIX: Restore byte narrowing for the exported bit-mask operations
					// in this file; unchecked casts preserve the original IL byte stores.
					array17[num15] |= unchecked((byte)(0 & BinaryDefine.b00001000));
				}
				else
				{
					byte[] array18 = array[2];
					int num16 = 1;
					array18[num16] |= unchecked((byte)(8 & BinaryDefine.b00001000));
				}
				byte[] array19 = array[2];
				int num17 = 1;
				array19[num17] |= (byte)(userSettingR7[122] << 1 & (int)BinaryDefine.b00000010);
				byte[] array20 = array[2];
				int num18 = 1;
				array20[num18] |= (byte)(userSettingR7[124] & (int)BinaryDefine.b00000001);
				byte[] array21 = array[2];
				int num19 = 0;
				array21[num19] |= (byte)((int)b3 << 7 & (int)BinaryDefine.b10000000);
				byte[] array22 = array[2];
				int num20 = 0;
				array22[num20] |= (byte)(userSettingR7[126] << 4 & (int)BinaryDefine.b01110000);
				byte[] array23 = array[2];
				int num21 = 0;
				array23[num21] |= (byte)((int)b2 << 3 & (int)BinaryDefine.b00001000);
				if (userSettingR7[127] >= 8)
				{
					byte[] array24 = array[2];
					int num22 = 0;
					array24[num22] |= BinaryDefine.b00000110;
				}
				else
				{
					byte[] array25 = array[2];
					int num23 = 0;
					array25[num23] |= (byte)(userSettingR7[127] & (int)BinaryDefine.b00000111);
				}
				byte b13;
				if (b11 == 1)
				{
					if (userSettingR7[99] == 1)
					{
						b13 = (byte)(userSettingR7[116] / 5);
					}
					else
					{
						b13 = (byte)(userSettingR7[116] / 10);
					}
				}
				else if (userSettingR7[99] == 1)
				{
					b13 = (byte)((userSettingR7[116] - 55) / 5);
				}
				else
				{
					b13 = (byte)((userSettingR7[116] - 90) / 10);
				}
				byte[] array26 = array[1];
				int num24 = 2;
				array26[num24] |= (byte)(userSettingR7[99] << 7 & (int)BinaryDefine.b10000000);
				byte[] array27 = array[1];
				int num25 = 2;
				array27[num25] |= (byte)((int)b10 << 6 & (int)BinaryDefine.b01000000);
				byte[] array28 = array[1];
				int num26 = 2;
				array28[num26] |= (byte)(userSettingR7[121] << 5 & (int)BinaryDefine.b00100000);
				byte[] array29 = array[1];
				int num27 = 2;
				array29[num27] |= (byte)(userSettingR7[123] << 4 & (int)BinaryDefine.b00010000);
				byte[] array30 = array[1];
				int num28 = 2;
				array30[num28] |= unchecked((byte)(b13 & BinaryDefine.b00001111));
				if (userSettingR7[99] == 1)
				{
					b13 = (byte)(userSettingR7[12] / 5);
				}
				else
				{
					b13 = (byte)(userSettingR7[12] / 10);
				}
				byte[] array31 = array[1];
				int num29 = 3;
				array31[num29] |= (byte)((int)b11 << 6 & (int)BinaryDefine.b01000000);
				byte[] array32 = array[1];
				int num30 = 3;
				array32[num30] |= (byte)(userSettingR7[21] << 5 & (int)BinaryDefine.b00100000);
				byte[] array33 = array[1];
				int num31 = 3;
				array33[num31] |= unchecked((byte)(b13 & BinaryDefine.b00011111));
				if (userSettingR7[99] == 1)
				{
					b13 = (byte)(userSettingR7[119] / 5);
				}
				else
				{
					b13 = (byte)(userSettingR7[119] / 10);
				}
				byte[] array34 = array[1];
				int num32 = 1;
				array34[num32] |= (byte)(userSettingR7[9] << 6 & (int)BinaryDefine.b01000000);
				byte[] array35 = array[1];
				int num33 = 1;
				array35[num33] |= (byte)(userSettingR7[11] << 5 & (int)BinaryDefine.b00100000);
				byte[] array36 = array[1];
				int num34 = 1;
				array36[num34] |= unchecked((byte)(b13 & BinaryDefine.b00011111));
				b13 = (byte)(userSettingR7[120] + 12);
				byte[] array37 = array[1];
				int num35 = 0;
				array37[num35] |= (byte)((int)b12 << 5 & (int)BinaryDefine.b11100000);
				byte[] array38 = array[1];
				int num36 = 0;
				array38[num36] |= unchecked((byte)(b13 & BinaryDefine.b00011111));
				byte[] array39 = array[3];
				int num37 = 3;
				array39[num37] |= (byte)(userSettingR7[80] << 6 & (int)BinaryDefine.b01000000);
				byte[] array40 = array[3];
				int num38 = 3;
				array40[num38] |= (byte)(userSettingR7[15] << 5 & (int)BinaryDefine.b00100000);
				byte[] array41 = array[3];
				int num39 = 3;
				array41[num39] |= (byte)((int)b6 << 4 & (int)BinaryDefine.b00010000);
				byte[] array42 = array[3];
				int num40 = 3;
				array42[num40] |= (byte)((int)b7 << 3 & (int)BinaryDefine.b00001000);
				byte[] array43 = array[3];
				int num41 = 3;
				array43[num41] |= (byte)(userSettingR7[110] & (int)BinaryDefine.b00000111);
				byte[] array44 = array[3];
				int num42 = 2;
				array44[num42] |= (byte)(userSettingR7[22] << 7 & (int)BinaryDefine.b10000000);
				byte[] array45 = array[3];
				int num43 = 2;
				array45[num43] |= (byte)((int)b9 << 6 & (int)BinaryDefine.b01000000);
				byte[] array46 = array[3];
				int num44 = 2;
				array46[num44] |= (byte)(userSettingR7[2] << 3 & (int)BinaryDefine.b00111000);
				byte[] array47 = array[3];
				int num45 = 2;
				array47[num45] |= (byte)(userSettingR7[3] & (int)BinaryDefine.b00000111);
				byte[] array48 = array[3];
				int num46 = 1;
				array48[num46] |= (byte)((int)b8 << 7 & (int)BinaryDefine.b10000000);
				byte[] array49 = array[3];
				int num47 = 1;
				array49[num47] |= (byte)(userSettingR7[98] << 5 & (int)BinaryDefine.b00100000);
				byte[] array50 = array[3];
				int num48 = 1;
				array50[num48] |= (byte)(userSettingR7[78] << 3 & (int)BinaryDefine.b00001000);
				byte[] array51 = array[3];
				int num49 = 1;
				array51[num49] |= (byte)(userSettingR7[4] & (int)BinaryDefine.b00000111);
				byte[] array52 = array[3];
				int num50 = 0;
				array52[num50] |= (byte)(userSettingR7[77] << 7 & (int)BinaryDefine.b10000000);
				byte[] array53 = array[3];
				int num51 = 0;
				array53[num51] |= (byte)(userSettingR7[76] << 6 & (int)BinaryDefine.b01000000);
				byte[] array54 = array[3];
				int num52 = 0;
				array54[num52] |= (byte)(userSettingR7[75] << 5 & (int)BinaryDefine.b00100000);
				byte[] array55 = array[3];
				int num53 = 0;
				array55[num53] |= (byte)(userSettingR7[74] << 4 & (int)BinaryDefine.b00010000);
				byte[] array56 = array[3];
				int num54 = 0;
				array56[num54] |= (byte)(userSettingR7[73] << 3 & (int)BinaryDefine.b00001000);
				byte[] array57 = array[3];
				int num55 = 0;
				array57[num55] |= (byte)(userSettingR7[72] << 2 & (int)BinaryDefine.b00000100);
				byte[] array58 = array[3];
				int num56 = 0;
				array58[num56] |= (byte)(userSettingR7[71] << 1 & (int)BinaryDefine.b00000010);
				byte[] array59 = array[3];
				int num57 = 0;
				array59[num57] |= (byte)(userSettingR7[70] & (int)BinaryDefine.b00000001);
				byte[] array60 = array[4];
				int num58 = 3;
				array60[num58] |= (byte)(userSettingR7[114] << 3 & (int)BinaryDefine.b00111000);
				byte[] array61 = array[4];
				int num59 = 3;
				array61[num59] |= (byte)(userSettingR7[115] & (int)BinaryDefine.b00000111);
				byte[] array62 = array[4];
				int num60 = 2;
				array62[num60] |= (byte)(userSettingR7[100] << 4 & (int)BinaryDefine.b11110000);
				byte[] array63 = array[4];
				int num61 = 2;
				array63[num61] |= (byte)(userSettingR7[101] & (int)BinaryDefine.b00001111);
				byte[] array64 = array[4];
				int num62 = 1;
				array64[num62] |= (byte)(userSettingR7[108] << 4 & (int)BinaryDefine.b11110000);
				byte[] array65 = array[4];
				int num63 = 1;
				array65[num63] |= (byte)(userSettingR7[106] & (int)BinaryDefine.b00001111);
				byte[] array66 = array[5];
				int num64 = 3;
				array66[num64] |= (byte)(userSettingR7[107] << 4 & (int)BinaryDefine.b01110000);
				byte[] array67 = array[5];
				int num65 = 3;
				array67[num65] |= (byte)(userSettingR7[104] & (int)BinaryDefine.b00001111);
				byte[] array68 = array[5];
				int num66 = 2;
				array68[num66] |= (byte)(userSettingR7[20] << 7 & (int)BinaryDefine.b10000000);
				byte[] array69 = array[5];
				int num67 = 2;
				array69[num67] |= (byte)(userSettingR7[81] << 6 & (int)BinaryDefine.b01000000);
				byte[] array70 = array[5];
				int num68 = 2;
				array70[num68] |= (byte)((int)b4 << 5 & (int)BinaryDefine.b00100000);
				byte[] array71 = array[5];
				int num69 = 2;
				array71[num69] |= (byte)(userSettingR7[113] & (int)BinaryDefine.b00000111);
				if (userSettingR7[127] >= 8)
				{
					byte[] array72 = array[5];
					int num70 = 1;
					array72[num70] &= BinaryDefine.b01111111;
				}
				else
				{
					byte[] array73 = array[5];
					int num71 = 1;
					array73[num71] |= BinaryDefine.b10000000;
				}
				byte[] array74 = array[5];
				int num72 = 1;
				array74[num72] |= (byte)(userSettingR7[86] << 3 & (int)BinaryDefine.b00111000);
				byte[] array75 = array[5];
				int num73 = 1;
				array75[num73] |= (byte)(userSettingR7[85] & (int)BinaryDefine.b00000111);
				byte[] array76 = array[5];
				int num74 = 0;
				array76[num74] |= (byte)(userSettingR7[0] << 7 & (int)BinaryDefine.b10000000);
				byte[] array77 = array[5];
				int num75 = 0;
				array77[num75] |= (byte)(userSettingR7[117] << 6 & (int)BinaryDefine.b01000000);
				byte[] array78 = array[5];
				int num76 = 0;
				array78[num76] |= (byte)(userSettingR7[89] << 3 & (int)BinaryDefine.b00111000);
				byte[] array79 = array[5];
				int num77 = 0;
				array79[num77] |= (byte)(userSettingR7[87] & (int)BinaryDefine.b00000111);
				byte[] array80 = array[6];
				int num78 = 3;
				array80[num78] |= (byte)(userSettingR7[91] << 4 & (int)BinaryDefine.b11110000);
				byte[] array81 = array[6];
				int num79 = 3;
				array81[num79] |= (byte)(userSettingR7[90] & (int)BinaryDefine.b00001111);
				byte[] array82 = array[6];
				int num80 = 2;
				array82[num80] |= (byte)(userSettingR7[94] << 4 & (int)BinaryDefine.b11110000);
				byte[] array83 = array[6];
				int num81 = 2;
				array83[num81] |= (byte)(userSettingR7[92] & (int)BinaryDefine.b00001111);
				byte[] array84 = array[6];
				int num82 = 1;
				array84[num82] |= (byte)(userSettingR7[96] << 4 & (int)BinaryDefine.b00010000);
				byte[] array85 = array[6];
				int num83 = 1;
				array85[num83] |= (byte)(userSettingR7[5] & (int)BinaryDefine.b00001111);
				byte[] array86 = array[6];
				int num84 = 0;
				array86[num84] |= (byte)(userSettingR7[10] << 5 & (int)BinaryDefine.b11100000);
				byte[] array87 = array[6];
				int num85 = 0;
				array87[num85] |= (byte)(userSettingR7[118] << 1 & (int)BinaryDefine.b00011110);
				byte[] array88 = array[6];
				int num86 = 0;
				array88[num86] |= (byte)(userSettingR7[112] & (int)BinaryDefine.b00000001);
				byte[] array89 = array[7];
				int num87 = 3;
				array89[num87] |= (byte)(userSettingR7[102] << 4 & (int)BinaryDefine.b01110000);
				byte[] array90 = array[7];
				int num88 = 3;
				array90[num88] |= (byte)(userSettingR7[13] << 3 & (int)BinaryDefine.b00001000);
				byte[] array91 = array[7];
				int num89 = 1;
				array91[num89] |= (byte)(userSettingR7[82] & (int)BinaryDefine.b00000011);
				byte[] array92 = array[8];
				int num90 = 3;
				array92[num90] |= (byte)(userSettingR7[23] << 7 & (int)BinaryDefine.b10000000);
				byte[] array93 = array[8];
				int num91 = 3;
				array93[num91] |= (byte)(userSettingR7[88] << 4 & (int)BinaryDefine.b01110000);
				byte[] array94 = array[8];
				int num92 = 3;
				array94[num92] |= (byte)(userSettingR7[93] & (int)BinaryDefine.b00001111);
				byte[] array95 = array[8];
				int num93 = 2;
				array95[num93] |= (byte)(userSettingR7[103] << 4 & (int)BinaryDefine.b11110000);
				byte[] array96 = array[8];
				int num94 = 2;
				array96[num94] |= (byte)(userSettingR7[105] & (int)BinaryDefine.b00001111);
				byte[] array97 = array[8];
				int num95 = 1;
				array97[num95] |= (byte)(userSettingR7[109] << 1 & (int)BinaryDefine.b00011110);
				byte[] array98 = array[8];
				int num96 = 1;
				array98[num96] |= (byte)(userSettingR7[111] & (int)BinaryDefine.b00000001);
				byte[] array99 = array[8];
				int num97 = 0;
				array99[num97] |= (byte)(userSettingR7[6] << 4 & (int)BinaryDefine.b11110000);
				byte[] array100 = array[8];
				int num98 = 0;
				array100[num98] |= (byte)(userSettingR7[7] & (int)BinaryDefine.b00001111);
				this.user_k_block_n_data_write(array, 9, userSettingR7, 43, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 10, userSettingR7, 48, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 11, userSettingR7, 53, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 12, userSettingR7, 58, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 13, userSettingR7, 63, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 14, userSettingR7, 28, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 15, userSettingR7, 33, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 16, userSettingR7, 38, userSettingR7[1]);
				Array.Copy(receivedNVData, array2, receivedNVData.Length);
				for (int i = 0; i < array.Length; i++)
				{
					for (int j = 0; j < array[i].Length; j++)
					{
						byte[] array101 = array2;
						int num99 = i * 4 + j;
						array101[num99] &= unchecked((byte)(~this.userNVDataPos[i * 4 + j]));
						byte[] array102 = array2;
						int num100 = i * 4 + j;
						array102[num100] |= array[i][j];
					}
				}
				array2[256] = (byte)userSettingR7[125];
				int num101 = 0;
				for (int i = 0; i < receivedNVData.Length; i++)
				{
					if (receivedNVData[i] == array2[i])
					{
						num101++;
					}
				}
				return array2;
			}

			// Token: 0x04000593 RID: 1427
			private int supportVersion = 151;

			// Token: 0x04000594 RID: 1428
			private int menuCnt = 128;

			// Token: 0x04000595 RID: 1429
			private byte[] userNVDataPos = new byte[]
			{
				0,
				0,
				0,
				0,
				byte.MaxValue,
				127,
				byte.MaxValue,
				127,
				byte.MaxValue,
				139,
				byte.MaxValue,
				127,
				byte.MaxValue,
				175,
				byte.MaxValue,
				127,
				0,
				byte.MaxValue,
				byte.MaxValue,
				63,
				byte.MaxValue,
				191,
				231,
				127,
				byte.MaxValue,
				31,
				byte.MaxValue,
				byte.MaxValue,
				0,
				3,
				0,
				120,
				byte.MaxValue,
				31,
				byte.MaxValue,
				byte.MaxValue,
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
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
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

			// Token: 0x04000596 RID: 1430
			private const int memoryQuotaPos = 256;

			// Token: 0x04000597 RID: 1431
			private const int HEADER = 0;

			// Token: 0x04000598 RID: 1432
			private const int GPS = 1;

			// Token: 0x04000599 RID: 1433
			private const int RD_1 = 2;

			// Token: 0x0400059A RID: 1434
			private const int RD_2 = 3;

			// Token: 0x0400059B RID: 1435
			private const int RD_3 = 4;

			// Token: 0x0400059C RID: 1436
			private const int RD_4 = 5;

			// Token: 0x0400059D RID: 1437
			private const int RD_5 = 6;

			// Token: 0x0400059E RID: 1438
			private const int RD_6 = 7;

			// Token: 0x0400059F RID: 1439
			private const int RD_7 = 8;

			// Token: 0x040005A0 RID: 1440
			private const int USR_K_BLK1 = 9;

			// Token: 0x040005A1 RID: 1441
			private const int USR_K_BLK2 = 10;

			// Token: 0x040005A2 RID: 1442
			private const int USR_K_BLK3 = 11;

			// Token: 0x040005A3 RID: 1443
			private const int USR_K_BLK4 = 12;

			// Token: 0x040005A4 RID: 1444
			private const int USR_K_BLK5 = 13;

			// Token: 0x040005A5 RID: 1445
			private const int CONST_K_BLK1 = 14;

			// Token: 0x040005A6 RID: 1446
			private const int CONST_K_BLK2 = 15;

			// Token: 0x040005A7 RID: 1447
			private const int CONST_K_BLK3 = 16;

			// Token: 0x040005A8 RID: 1448
			private const int ADDR_CNT = 17;

			// Token: 0x040005A9 RID: 1449
			private const int RF_PWR_STRENGTH_LEVEL0P5 = 76;

			// Token: 0x040005AA RID: 1450
			private const int RF_PWR_STRENGTH_LEVEL1 = 82;

			// Token: 0x040005AB RID: 1451
			private const int RF_PWR_STRENGTH_LEVEL1P5 = 88;

			// Token: 0x040005AC RID: 1452
			private const int RF_PWR_STRENGTH_LEVEL2 = 94;

			// Token: 0x040005AD RID: 1453
			private const int RF_PWR_STRENGTH_LEVEL2P5 = 99;

			// Token: 0x040005AE RID: 1454
			private const int RF_PWR_STRENGTH_LEVEL3 = 104;

			// Token: 0x040005AF RID: 1455
			private const int RF_PWR_STRENGTH_LEVEL3P5 = 109;

			// Token: 0x040005B0 RID: 1456
			private const int RF_PWR_STRENGTH_LEVEL4 = 115;

			// Token: 0x040005B1 RID: 1457
			private const int RF_PWR_STRENGTH_LEVEL4P5 = 121;

			// Token: 0x040005B2 RID: 1458
			private const int RF_PWR_STRENGTH_LEVEL5 = 128;

			// Token: 0x040005B3 RID: 1459
			private const int RF_PWR_STRENGTH_LEVEL5P5 = 133;

			// Token: 0x040005B4 RID: 1460
			private const int RF_PWR_STRENGTH_LEVEL6 = 138;

			// Token: 0x040005B5 RID: 1461
			private const int RF_PWR_STRENGTH_LEVEL6P5 = 145;

			// Token: 0x040005B6 RID: 1462
			private const int RF_PWR_STRENGTH_LEVEL7 = 152;

			// Token: 0x040005B7 RID: 1463
			private const int RF_PWR_STRENGTH_LEVEL7P5 = 159;

			// Token: 0x040005B8 RID: 1464
			private const int RF_PWR_STRENGTH_LEVEL0P5_CITY = 113;

			// Token: 0x040005B9 RID: 1465
			private const int RF_PWR_STRENGTH_LEVEL1_CITY = 115;

			// Token: 0x040005BA RID: 1466
			private const int RF_PWR_STRENGTH_LEVEL1P5_CITY = 117;

			// Token: 0x040005BB RID: 1467
			private const int RF_PWR_STRENGTH_LEVEL2_CITY = 120;

			// Token: 0x040005BC RID: 1468
			private const int RF_PWR_STRENGTH_LEVEL2P5_CITY = 124;

			// Token: 0x040005BD RID: 1469
			private const int RF_PWR_STRENGTH_LEVEL3_CITY = 128;

			// Token: 0x040005BE RID: 1470
			private const int RF_PWR_STRENGTH_LEVEL3P5_CITY = 130;

			// Token: 0x040005BF RID: 1471
			private const int RF_PWR_STRENGTH_LEVEL4_CITY = 132;

			// Token: 0x040005C0 RID: 1472
			private const int RF_PWR_STRENGTH_LEVEL4P5_CITY = 135;

			// Token: 0x040005C1 RID: 1473
			private const int RF_PWR_STRENGTH_LEVEL5_CITY = 138;

			// Token: 0x040005C2 RID: 1474
			private const int RF_PWR_STRENGTH_LEVEL5P5_CITY = 140;

			// Token: 0x040005C3 RID: 1475
			private const int RF_PWR_STRENGTH_LEVEL6_CITY = 142;

			// Token: 0x040005C4 RID: 1476
			private const int RF_PWR_STRENGTH_LEVEL6P5_CITY = 147;

			// Token: 0x040005C5 RID: 1477
			private const int RF_PWR_STRENGTH_LEVEL7_CITY = 152;

			// Token: 0x040005C6 RID: 1478
			private const int RF_PWR_STRENGTH_LEVEL7P5_CITY = 157;

			// Token: 0x040005C7 RID: 1479
			private const int K_BLOCK_FILTER_LEVEL_0P5 = 8;

			// Token: 0x040005C8 RID: 1480
			private const int K_BLOCK_FILTER_LEVEL_1P0 = 9;

			// Token: 0x040005C9 RID: 1481
			private const int K_BLOCK_FILTER_LEVEL_1P5 = 10;

			// Token: 0x040005CA RID: 1482
			private const int K_BLOCK_FILTER_LEVEL_2P0 = 11;

			// Token: 0x040005CB RID: 1483
			private const int K_BLOCK_FILTER_LEVEL_2P5 = 12;

			// Token: 0x040005CC RID: 1484
			private const int K_BLOCK_FILTER_LEVEL_3P0 = 13;

			// Token: 0x040005CD RID: 1485
			private const int K_BLOCK_FILTER_LEVEL_3P5 = 14;

			// Token: 0x040005CE RID: 1486
			private const int K_BLOCK_FILTER_LEVEL_4P0 = 15;

			// Token: 0x040005CF RID: 1487
			private const int K_BLOCK_FILTER_LEVEL_4P5 = 16;

			// Token: 0x040005D0 RID: 1488
			private const int K_BLOCK_FILTER_LEVEL_5P0 = 17;

			// Token: 0x040005D1 RID: 1489
			private const int K_BLOCK_FILTER_LEVEL_5P5 = 18;

			// Token: 0x040005D2 RID: 1490
			private const int K_BLOCK_FILTER_LEVEL_6P0 = 19;

			// Token: 0x040005D3 RID: 1491
			private const int K_BLOCK_FILTER_LEVEL_6P5 = 20;

			// Token: 0x040005D4 RID: 1492
			private const int K_BLOCK_FILTER_LEVEL_7P0 = 21;

			// Token: 0x040005D5 RID: 1493
			private const int K_BLOCK_FILTER_LEVEL_7P5 = 22;

			// Token: 0x040005D6 RID: 1494
			private const int K_BLOCK_FILTER_LEVEL_8P0 = 23;

			// Token: 0x020000B9 RID: 185
			private enum MENU
			{
				// Token: 0x0400096F RID: 2415
				MENU_MODE,
				// Token: 0x04000970 RID: 2416
				DETECTION_MODE,
				// Token: 0x04000971 RID: 2417
				X_SENSITIVE,
				// Token: 0x04000972 RID: 2418
				K_SENSITIVE,
				// Token: 0x04000973 RID: 2419
				KA_SENSITIVE,
				// Token: 0x04000974 RID: 2420
				REAR_K_ATTENUATION,
				// Token: 0x04000975 RID: 2421
				REAR_KA_ATTENUATION,
				// Token: 0x04000976 RID: 2422
				REAR_X_ATTENUATION,
				// Token: 0x04000977 RID: 2423
				GPS_ENABLE,
				// Token: 0x04000978 RID: 2424
				SPEED_CAMERA_ENABLE,
				// Token: 0x04000979 RID: 2425
				SPEED_CAMERA_ALERT_RANGE,
				// Token: 0x0400097A RID: 2426
				RLC_ENABLE,
				// Token: 0x0400097B RID: 2427
				RLC_QRIDE,
				// Token: 0x0400097C RID: 2428
				POI_PASSCHIME,
				// Token: 0x0400097D RID: 2429
				VOICE_ENABLE,
				// Token: 0x0400097E RID: 2430
				KA_FREQ_VOICE,
				// Token: 0x0400097F RID: 2431
				X_BAND_ENABLE,
				// Token: 0x04000980 RID: 2432
				K_BAND_ENABLE,
				// Token: 0x04000981 RID: 2433
				KA_BAND_ENABLE,
				// Token: 0x04000982 RID: 2434
				LASER_ENABLE,
				// Token: 0x04000983 RID: 2435
				LASER_GUN_ID_ENABLE,
				// Token: 0x04000984 RID: 2436
				K_POP_ENABLE,
				// Token: 0x04000985 RID: 2437
				MRCD_ENABLE,
				// Token: 0x04000986 RID: 2438
				GATSO_ENABLE,
				// Token: 0x04000987 RID: 2439
				KA_POP_ENABLE,
				// Token: 0x04000988 RID: 2440
				K_FILTER_ENABLE,
				// Token: 0x04000989 RID: 2441
				KA_FILTER_ENABLE,
				// Token: 0x0400098A RID: 2442
				TSF_ENABLE,
				// Token: 0x0400098B RID: 2443
				K_BLOCK_FILTER_1_OP_MODE,
				// Token: 0x0400098C RID: 2444
				K_BLOCK_FILTER_1_RAW_STRENGTH,
				// Token: 0x0400098D RID: 2445
				K_BLOCK_FILTER_1_DIR,
				// Token: 0x0400098E RID: 2446
				K_BLOCK_FILTER_1_MIN_FREQ,
				// Token: 0x0400098F RID: 2447
				K_BLOCK_FILTER_1_MAX_FREQ,
				// Token: 0x04000990 RID: 2448
				K_BLOCK_FILTER_2_OP_MODE,
				// Token: 0x04000991 RID: 2449
				K_BLOCK_FILTER_2_RAW_STRENGTH,
				// Token: 0x04000992 RID: 2450
				K_BLOCK_FILTER_2_DIR,
				// Token: 0x04000993 RID: 2451
				K_BLOCK_FILTER_2_MIN_FREQ,
				// Token: 0x04000994 RID: 2452
				K_BLOCK_FILTER_2_MAX_FREQ,
				// Token: 0x04000995 RID: 2453
				K_BLOCK_FILTER_3_OP_MODE,
				// Token: 0x04000996 RID: 2454
				K_BLOCK_FILTER_3_RAW_STRENGTH,
				// Token: 0x04000997 RID: 2455
				K_BLOCK_FILTER_3_DIR,
				// Token: 0x04000998 RID: 2456
				K_BLOCK_FILTER_3_MIN_FREQ,
				// Token: 0x04000999 RID: 2457
				K_BLOCK_FILTER_3_MAX_FREQ,
				// Token: 0x0400099A RID: 2458
				USER_K_BLOCK_FILTER_1_OP_MODE,
				// Token: 0x0400099B RID: 2459
				USER_K_BLOCK_FILTER_1_RAW_STRENGTH,
				// Token: 0x0400099C RID: 2460
				USER_K_BLOCK_FILTER_1_DIR,
				// Token: 0x0400099D RID: 2461
				USER_K_BLOCK_FILTER_1_MIN_FREQ,
				// Token: 0x0400099E RID: 2462
				USER_K_BLOCK_FILTER_1_MAX_FREQ,
				// Token: 0x0400099F RID: 2463
				USER_K_BLOCK_FILTER_2_OP_MODE,
				// Token: 0x040009A0 RID: 2464
				USER_K_BLOCK_FILTER_2_RAW_STRENGTH,
				// Token: 0x040009A1 RID: 2465
				USER_K_BLOCK_FILTER_2_DIR,
				// Token: 0x040009A2 RID: 2466
				USER_K_BLOCK_FILTER_2_MIN_FREQ,
				// Token: 0x040009A3 RID: 2467
				USER_K_BLOCK_FILTER_2_MAX_FREQ,
				// Token: 0x040009A4 RID: 2468
				USER_K_BLOCK_FILTER_3_OP_MODE,
				// Token: 0x040009A5 RID: 2469
				USER_K_BLOCK_FILTER_3_RAW_STRENGTH,
				// Token: 0x040009A6 RID: 2470
				USER_K_BLOCK_FILTER_3_DIR,
				// Token: 0x040009A7 RID: 2471
				USER_K_BLOCK_FILTER_3_MIN_FREQ,
				// Token: 0x040009A8 RID: 2472
				USER_K_BLOCK_FILTER_3_MAX_FREQ,
				// Token: 0x040009A9 RID: 2473
				USER_K_BLOCK_FILTER_4_OP_MODE,
				// Token: 0x040009AA RID: 2474
				USER_K_BLOCK_FILTER_4_RAW_STRENGTH,
				// Token: 0x040009AB RID: 2475
				USER_K_BLOCK_FILTER_4_DIR,
				// Token: 0x040009AC RID: 2476
				USER_K_BLOCK_FILTER_4_MIN_FREQ,
				// Token: 0x040009AD RID: 2477
				USER_K_BLOCK_FILTER_4_MAX_FREQ,
				// Token: 0x040009AE RID: 2478
				USER_K_BLOCK_FILTER_5_OP_MODE,
				// Token: 0x040009AF RID: 2479
				USER_K_BLOCK_FILTER_5_RAW_STRENGTH,
				// Token: 0x040009B0 RID: 2480
				USER_K_BLOCK_FILTER_5_DIR,
				// Token: 0x040009B1 RID: 2481
				USER_K_BLOCK_FILTER_5_MIN_FREQ,
				// Token: 0x040009B2 RID: 2482
				USER_K_BLOCK_FILTER_5_MAX_FREQ,
				// Token: 0x040009B3 RID: 2483
				K_NARROW,
				// Token: 0x040009B4 RID: 2484
				KA_NARROW,
				// Token: 0x040009B5 RID: 2485
				KA_SEG1,
				// Token: 0x040009B6 RID: 2486
				KA_SEG2,
				// Token: 0x040009B7 RID: 2487
				KA_SEG3,
				// Token: 0x040009B8 RID: 2488
				KA_SEG4,
				// Token: 0x040009B9 RID: 2489
				KA_SEG5,
				// Token: 0x040009BA RID: 2490
				KA_SEG6,
				// Token: 0x040009BB RID: 2491
				KA_SEG7,
				// Token: 0x040009BC RID: 2492
				KA_SEG8,
				// Token: 0x040009BD RID: 2493
				KA_SEG9,
				// Token: 0x040009BE RID: 2494
				PRIORITY_MODE,
				// Token: 0x040009BF RID: 2495
				MUTE_MEM_BAND_OPTION,
				// Token: 0x040009C0 RID: 2496
				AUTO_MUTE_MEM_ENABLE,
				// Token: 0x040009C1 RID: 2497
				AUTO_MUTE_MEM_BAND_OPTION,
				// Token: 0x040009C2 RID: 2498
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x040009C3 RID: 2499
				BACKGROUND_COLOR,
				// Token: 0x040009C4 RID: 2500
				X_BAND_ARROW_COLOR,
				// Token: 0x040009C5 RID: 2501
				K_BAND_ARROW_COLOR,
				// Token: 0x040009C6 RID: 2502
				MRCD_ARROW_COLOR,
				// Token: 0x040009C7 RID: 2503
				GATSO_ARROW_COLOR,
				// Token: 0x040009C8 RID: 2504
				KA_BAND_ARROW_COLOR,
				// Token: 0x040009C9 RID: 2505
				X_BAND_COLOR,
				// Token: 0x040009CA RID: 2506
				K_BAND_COLOR,
				// Token: 0x040009CB RID: 2507
				MRCD_COLOR,
				// Token: 0x040009CC RID: 2508
				GATSO_COLOR,
				// Token: 0x040009CD RID: 2509
				KA_BAND_COLOR,
				// Token: 0x040009CE RID: 2510
				MAIN_DISPLAY,
				// Token: 0x040009CF RID: 2511
				HEARTBEAT_ICON_ENABLE,
				// Token: 0x040009D0 RID: 2512
				LEFT_DISPLAY,
				// Token: 0x040009D1 RID: 2513
				ALERT_DISPLAY,
				// Token: 0x040009D2 RID: 2514
				SPEED_UNIT,
				// Token: 0x040009D3 RID: 2515
				X_BAND_ALERT_TONE,
				// Token: 0x040009D4 RID: 2516
				K_BAND_ALERT_TONE,
				// Token: 0x040009D5 RID: 2517
				K_BAND_BOGEY_TONE,
				// Token: 0x040009D6 RID: 2518
				K_BAND_BOGEY_LEVEL,
				// Token: 0x040009D7 RID: 2519
				MRCD_ALERT_TONE,
				// Token: 0x040009D8 RID: 2520
				GATSO_ALERT_TONE,
				// Token: 0x040009D9 RID: 2521
				KA_BAND_ALERT_TONE,
				// Token: 0x040009DA RID: 2522
				KA_BAND_BOGEY_TONE,
				// Token: 0x040009DB RID: 2523
				LASER_ALERT_TONE,
				// Token: 0x040009DC RID: 2524
				AUTO_MUTE_ALERT_LEVEL,
				// Token: 0x040009DD RID: 2525
				AUTO_MUTE_VOLUME,
				// Token: 0x040009DE RID: 2526
				ALERT_TEMPORARY_VOLUME,
				// Token: 0x040009DF RID: 2527
				REAR_K_BAND_MUTE_ENABLE,
				// Token: 0x040009E0 RID: 2528
				DARK_MODE_BRIGHTNESS,
				// Token: 0x040009E1 RID: 2529
				AUTO_DIM_SET_BRIGHT_BRIGHTNESS,
				// Token: 0x040009E2 RID: 2530
				AUTO_DIM_SET_DIM_BRIGHTNESS,
				// Token: 0x040009E3 RID: 2531
				QRIDE_MODE,
				// Token: 0x040009E4 RID: 2532
				MRCD_QRIDE_ENABLE,
				// Token: 0x040009E5 RID: 2533
				QRIDE_VOLUME,
				// Token: 0x040009E6 RID: 2534
				LIMIT_SPEED_MODE,
				// Token: 0x040009E7 RID: 2535
				GMT,
				// Token: 0x040009E8 RID: 2536
				DST_ENABLE,
				// Token: 0x040009E9 RID: 2537
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x040009EA RID: 2538
				VEHICLE_BATT_SAVER_ENABLE,
				// Token: 0x040009EB RID: 2539
				SELF_TEST_ENABLE,
				// Token: 0x040009EC RID: 2540
				MEMORY_QUOTA,
				// Token: 0x040009ED RID: 2541
				MAIN_DIM_SET,
				// Token: 0x040009EE RID: 2542
				MAIN_VOLUME
			}
		}

		// Token: 0x0200008F RID: 143
		private class v146 : UserSettingFormat
		{
			// Token: 0x060002F4 RID: 756 RVA: 0x0003FED7 File Offset: 0x0003E0D7
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x060002F5 RID: 757 RVA: 0x0003FEDF File Offset: 0x0003E0DF
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x060002F6 RID: 758 RVA: 0x0003FEE7 File Offset: 0x0003E0E7
			public byte[] GetNVDataMask()
			{
				return this.userNVDataPos;
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x000293C6 File Offset: 0x000275C6
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return op_mode != 1 && op_mode != 2 && op_mode != 3 && op_mode != 7;
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x0003FEF0 File Offset: 0x0003E0F0
			public int user_k_block_get_level(int strength, int mode)
			{
				if (mode == 0)
				{
					if (strength <= 113)
					{
						return 8;
					}
					if (strength <= 115)
					{
						return 9;
					}
					if (strength <= 117)
					{
						return 10;
					}
					if (strength <= 120)
					{
						return 11;
					}
					if (strength <= 124)
					{
						return 12;
					}
					if (strength <= 128)
					{
						return 13;
					}
					if (strength <= 130)
					{
						return 14;
					}
					if (strength <= 132)
					{
						return 15;
					}
					if (strength <= 135)
					{
						return 16;
					}
					if (strength <= 138)
					{
						return 17;
					}
					if (strength <= 140)
					{
						return 18;
					}
					if (strength <= 142)
					{
						return 19;
					}
					if (strength <= 147)
					{
						return 20;
					}
					if (strength <= 152)
					{
						return 21;
					}
					if (strength <= 157)
					{
						return 22;
					}
					return 23;
				}
				else
				{
					if (strength <= 76)
					{
						return 8;
					}
					if (strength <= 82)
					{
						return 9;
					}
					if (strength <= 88)
					{
						return 10;
					}
					if (strength <= 94)
					{
						return 11;
					}
					if (strength <= 99)
					{
						return 12;
					}
					if (strength <= 104)
					{
						return 13;
					}
					if (strength <= 109)
					{
						return 14;
					}
					if (strength <= 115)
					{
						return 15;
					}
					if (strength <= 121)
					{
						return 16;
					}
					if (strength <= 128)
					{
						return 17;
					}
					if (strength <= 133)
					{
						return 18;
					}
					if (strength <= 138)
					{
						return 19;
					}
					if (strength <= 145)
					{
						return 20;
					}
					if (strength <= 152)
					{
						return 21;
					}
					if (strength <= 159)
					{
						return 22;
					}
					return 23;
				}
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x00040028 File Offset: 0x0003E228
			public int user_k_block_get_raw_strength(int level, int mode)
			{
				if (mode == 0)
				{
					if (level == 8)
					{
						return 113;
					}
					if (level == 9)
					{
						return 115;
					}
					if (level == 10)
					{
						return 117;
					}
					if (level == 11)
					{
						return 120;
					}
					if (level == 12)
					{
						return 124;
					}
					if (level == 13)
					{
						return 128;
					}
					if (level == 14)
					{
						return 130;
					}
					if (level == 15)
					{
						return 132;
					}
					if (level == 16)
					{
						return 135;
					}
					if (level == 17)
					{
						return 138;
					}
					if (level == 18)
					{
						return 140;
					}
					if (level == 19)
					{
						return 142;
					}
					if (level == 20)
					{
						return 147;
					}
					if (level == 21)
					{
						return 152;
					}
					if (level == 22)
					{
						return 157;
					}
					return 255;
				}
				else
				{
					if (level == 8)
					{
						return 76;
					}
					if (level == 9)
					{
						return 82;
					}
					if (level == 10)
					{
						return 88;
					}
					if (level == 11)
					{
						return 94;
					}
					if (level == 12)
					{
						return 99;
					}
					if (level == 13)
					{
						return 104;
					}
					if (level == 14)
					{
						return 109;
					}
					if (level == 15)
					{
						return 115;
					}
					if (level == 16)
					{
						return 121;
					}
					if (level == 17)
					{
						return 128;
					}
					if (level == 18)
					{
						return 133;
					}
					if (level == 19)
					{
						return 138;
					}
					if (level == 20)
					{
						return 145;
					}
					if (level == 21)
					{
						return 152;
					}
					if (level == 22)
					{
						return 159;
					}
					return 255;
				}
			}

			// Token: 0x060002FA RID: 762 RVA: 0x00040170 File Offset: 0x0003E370
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
					2
				}, new string[]
				{
					"City",
					"Highway",
					"Advanced"
				}, "Highway - Full Sensitivity\nCity - X and K sensitivity reduced. Ka band sensitivity same as Highway.\nAdvanced - User adjusts X, K, and Ka band sensitivity from 100%~30% in 10% intervals.");
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
				array[5] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear K Attenuation", new int[]
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
				array[6] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear Ka Attenuation", new int[]
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
				array[7] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear X Attenuation", new int[]
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
				UserSettingMenu[] array2 = array;
				int num = 13;
				UserSettingMenu.MENU_TYPE menuType = UserSettingMenu.MENU_TYPE.GPS;
				string menuString = "POI PassChime";
				int[] array3 = new int[2];
				array3[0] = 1;
				array2[num] = new UserSettingMenu(menuType, menuString, array3, new string[]
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
				UserSettingMenu[] array4 = array;
				int num2 = 16;
				UserSettingMenu.MENU_TYPE menuType2 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString2 = "X Band On/Off";
				int[] array5 = new int[2];
				array5[0] = 1;
				array4[num2] = new UserSettingMenu(menuType2, menuString2, array5, new string[]
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
				UserSettingMenu[] array6 = array;
				int num3 = 20;
				UserSettingMenu.MENU_TYPE menuType3 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString3 = "Laser Gun ID On/Off";
				int[] array7 = new int[2];
				array7[0] = 1;
				array6[num3] = new UserSettingMenu(menuType3, menuString3, array7, new string[]
				{
					"Off",
					"On"
				}, "Turn on to display laser gun identifier.");
				UserSettingMenu[] array8 = array;
				int num4 = 21;
				UserSettingMenu.MENU_TYPE menuType4 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString4 = "K POP On/Off";
				int[] array9 = new int[2];
				array9[0] = 1;
				array8[num4] = new UserSettingMenu(menuType4, menuString4, array9, new string[]
				{
					"Off",
					"On"
				}, "Detects K POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[22] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "MRCD On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates MultaRadar CD/CT low - powered radar gun detection.");
				UserSettingMenu[] array10 = array;
				int num5 = 23;
				UserSettingMenu.MENU_TYPE menuType5 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString5 = "Gatso RT3/4 On/Off";
				int[] array11 = new int[2];
				array11[0] = 1;
				array10[num5] = new UserSettingMenu(menuType5, menuString5, array11, new string[]
				{
					"Off",
					"On"
				}, "Activates detection for Gatso radar guns.");
				UserSettingMenu[] array12 = array;
				int num6 = 24;
				UserSettingMenu.MENU_TYPE menuType6 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString6 = "Ka POP On/Off";
				int[] array13 = new int[2];
				array13[0] = 1;
				array12[num6] = new UserSettingMenu(menuType6, menuString6, array13, new string[]
				{
					"Off",
					"On"
				}, "Detects Ka POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[25] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Filter", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the K band to prevent false detections.");
				UserSettingMenu[] array14 = array;
				int num7 = 26;
				UserSettingMenu.MENU_TYPE menuType7 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString7 = "Ka Filter";
				int[] array15 = new int[2];
				array15[0] = 1;
				array14[num7] = new UserSettingMenu(menuType7, menuString7, array15, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the Ka band to prevent false detections.");
				UserSettingMenu[] array16 = array;
				int num8 = 27;
				UserSettingMenu.MENU_TYPE menuType8 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString8 = "TSF";
				int[] array17 = new int[2];
				array17[0] = 1;
				array16[num8] = new UserSettingMenu(menuType8, menuString8, array17, new string[]
				{
					"Off",
					"On"
				}, "Traffic Sensor Filter. Prevents false alarms caused by traffic monitoring radar systems.");
				int[] array18 = new int[351];
				string[] array19 = new string[351];
				for (int i = 0; i < 351; i++)
				{
					array18[i] = 23900 + i;
					array19[i] = array18[i].ToString();
				}
				array[28] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block1 Filter Mode", new int[]
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
				array[29] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[30] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter Direction", new int[]
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
				array[31] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter Minimum Frequency", array18, array19, "Set K Block1 Filter minimum frequency.");
				array[32] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter Maximum Frequency", array18, array19, "Set K Block1 Filter maximum frequency.");
				array[33] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block2 Filter Mode", new int[]
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
				array[34] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[35] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter Direction", new int[]
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
				array[36] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter Minimum Frequency", array18, array19, "Set K Block2 Filter minimum frequency.");
				array[37] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter Maximum Frequency", array18, array19, "Set K Block2 Filter maximum frequency.");
				array[38] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "K Block3 Filter Mode", new int[]
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
				array[39] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[40] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter Direction", new int[]
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
				array[41] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter Minimum Frequency", array18, array19, "Set K Block3 Filter minimum frequency.");
				array[42] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter Maximum Frequency", array18, array19, "Set K Block3 Filter maximum frequency.");
				array[43] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block1 Filter Mode", new int[]
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
				array[44] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[45] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block1 Filter Direction", new int[]
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
				array[46] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block1 Filter Minimum Frequency", array18, array19, "Set User K Block1 Filter minimum frequency.");
				array[47] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block1 Filter Maximum Frequency", array18, array19, "Set User K Block1 Filter maximum frequency.");
				array[48] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block2 Filter Mode", new int[]
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
				array[49] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[50] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block2 Filter Direction", new int[]
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
				array[51] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block2 Filter Minimum Frequency", array18, array19, "Set User K Block2 Filter minimum frequency.");
				array[52] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block2 Filter Maximum Frequency", array18, array19, "Set User K Block2 Filter maximum frequency.");
				array[53] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block3 Filter Mode", new int[]
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
				array[54] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[55] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block3 Filter Direction", new int[]
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
				array[56] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block3 Filter Minimum Frequency", array18, array19, "Set User K Block3 Filter minimum frequency.");
				array[57] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block3 Filter Maximum Frequency", array18, array19, "Set User K Block3 Filter maximum frequency.");
				array[58] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block4 Filter Mode", new int[]
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
				array[59] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[60] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block4 Filter Direction", new int[]
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
				array[61] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block4 Filter Minimum Frequency", array18, array19, "Set User K Block4 Filter minimum frequency.");
				array[62] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block4 Filter Maximum Frequency", array18, array19, "Set User K Block4 Filter maximum frequency.");
				array[63] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT, "User K Block5 Filter Mode", new int[]
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
				array[64] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.INVISIBLE, UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT, "", new int[0], new string[0], "");
				array[65] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block5 Filter Direction", new int[]
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
				array[66] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block5 Filter Minimum Frequency", array18, array19, "Set User K Block5 Filter minimum frequency.");
				array[67] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "User K Block5 Filter Maximum Frequency", array18, array19, "Set User K Block5 Filter maximum frequency.");
				array[68] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Narrow/Wide/Extended", new int[]
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
				array[69] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Narrow/Wide/Segmentation", new int[]
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
				UserSettingMenu[] array20 = array;
				int num9 = 70;
				UserSettingMenu.MENU_TYPE menuType9 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString9 = "Ka Segmentation 33.399Ghz – 33.705Ghz";
				int[] array21 = new int[2];
				array21[0] = 1;
				array20[num9] = new UserSettingMenu(menuType9, menuString9, array21, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.399Ghz – 33.705Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array22 = array;
				int num10 = 71;
				UserSettingMenu.MENU_TYPE menuType10 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString10 = "Ka Segmentation 33.705Ghz – 33.903Ghz";
				int[] array23 = new int[2];
				array23[0] = 1;
				array22[num10] = new UserSettingMenu(menuType10, menuString10, array23, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.705Ghz – 33.903Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array24 = array;
				int num11 = 72;
				UserSettingMenu.MENU_TYPE menuType11 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString11 = "Ka Segmentation 33.903Ghz – 34.191Ghz";
				int[] array25 = new int[2];
				array25[0] = 1;
				array24[num11] = new UserSettingMenu(menuType11, menuString11, array25, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.903Ghz – 34.191Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array26 = array;
				int num12 = 73;
				UserSettingMenu.MENU_TYPE menuType12 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString12 = "Ka Segmentation 34.191Ghz – 34.587Ghz";
				int[] array27 = new int[2];
				array27[0] = 1;
				array26[num12] = new UserSettingMenu(menuType12, menuString12, array27, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.191Ghz – 34.587Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array28 = array;
				int num13 = 74;
				UserSettingMenu.MENU_TYPE menuType13 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString13 = "Ka Segmentation 34.587Ghz – 34.803Ghz";
				int[] array29 = new int[2];
				array29[0] = 1;
				array28[num13] = new UserSettingMenu(menuType13, menuString13, array29, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.587Ghz – 34.803Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array30 = array;
				int num14 = 75;
				UserSettingMenu.MENU_TYPE menuType14 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString14 = "Ka Segmentation 34.803Ghz – 35.163Ghz";
				int[] array31 = new int[2];
				array31[0] = 1;
				array30[num14] = new UserSettingMenu(menuType14, menuString14, array31, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.803Ghz – 35.163Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array32 = array;
				int num15 = 76;
				UserSettingMenu.MENU_TYPE menuType15 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString15 = "Ka Segmentation 35.163Ghz – 35.379Ghz";
				int[] array33 = new int[2];
				array33[0] = 1;
				array32[num15] = new UserSettingMenu(menuType15, menuString15, array33, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.163Ghz – 35.379Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array34 = array;
				int num16 = 77;
				UserSettingMenu.MENU_TYPE menuType16 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString16 = "Ka Segmentation 35.379Ghz – 35.613Ghz";
				int[] array35 = new int[2];
				array35[0] = 1;
				array34[num16] = new UserSettingMenu(menuType16, menuString16, array35, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.379Ghz – 35.613Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array36 = array;
				int num17 = 78;
				UserSettingMenu.MENU_TYPE menuType17 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString17 = "Ka Segmentation 35.613Ghz – 35.701Ghz";
				int[] array37 = new int[2];
				array37[0] = 1;
				array36[num17] = new UserSettingMenu(menuType17, menuString17, array37, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.613Ghz – 35.701Ghz (Ka Segmentation mode)");
				array[79] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Priority", new int[]
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
				array[80] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Select bands to be muted.");
				array[81] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute Memory On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "This menu turns the ability to automatically save mute requests for specific locations/frequency bands.");
				array[82] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Auto Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Auto Mute Memory Band Option Set specifies which bands will be muted.");
				UserSettingMenu[] array38 = array;
				int num18 = 83;
				UserSettingMenu.MENU_TYPE menuType18 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString18 = "All Threat Display";
				int[] array39 = new int[2];
				array39[0] = 1;
				array38[num18] = new UserSettingMenu(menuType18, menuString18, array39, new string[]
				{
					"Off",
					"On"
				}, "Displays if more than one radar signals are detected at the same time. The signal with the strongest radar signal is considered the main signal. The other signals are displayed on the left side.");
				array[84] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Background Color", new int[]
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
				array[85] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
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
				array[86] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
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
				array[87] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red"
				}, "Set MRCD arrow color.");
				array[88] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "GATSO RT3/4 Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
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
				array[89] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
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
				array[90] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Color", new int[]
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
				array[91] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Color", new int[]
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
				array[92] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD Color", new int[]
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
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red",
					"Arrow",
					"Signal"
				}, "Set MRCD indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[93] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Gatso RT3/4 Color", new int[]
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
				array[94] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Color", new int[]
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
				array[95] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Display", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Mode",
					"Scan",
					"Time"
				}, "Select what will display on the OLED, either scanning for frequencies, the mode, or the time.\n(GPS On)");
				UserSettingMenu[] array40 = array;
				int num19 = 96;
				UserSettingMenu.MENU_TYPE menuType19 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString19 = "Scan Icon";
				int[] array41 = new int[2];
				array41[0] = 1;
				array40[num19] = new UserSettingMenu(menuType19, menuString19, array41, new string[]
				{
					"Off",
					"On"
				}, "Scan Icon displays to indicate the end of a scan cycle.");
				array[97] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Left Display", new int[]
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
				UserSettingMenu[] array42 = array;
				int num20 = 98;
				UserSettingMenu.MENU_TYPE menuType20 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString20 = "Alert Display";
				int[] array43 = new int[2];
				array43[0] = 1;
				array42[num20] = new UserSettingMenu(menuType20, menuString20, array43, new string[]
				{
					"Type 1",
					"Type 2"
				}, "Select one of two OLED display formats.");
				UserSettingMenu[] array44 = array;
				int num21 = 99;
				UserSettingMenu.MENU_TYPE menuType21 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString21 = "Speed Unit";
				int[] array45 = new int[2];
				array45[0] = 1;
				array44[num21] = new UserSettingMenu(menuType21, menuString21, array45, new string[]
				{
					"mph",
					"km/h"
				}, "Select the speed measurement type.");
				array[99].isUnitMenuFlag = true;
				array[100] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "X Band Alert Tone", new int[]
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
				array[101] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Alert Tone", new int[]
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
				array[102] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Tone", new int[]
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
				array[103] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Level", new int[]
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
				array[104] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "MRCD Alert Tone", new int[]
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
				}, "Set a tone to indicate MRCD.");
				array[105] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "GATSO RT3/4 Alert Tone", new int[]
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
				array[106] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Alert Tone", new int[]
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
				array[107] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Bogey Tone", new int[]
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
				array[108] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Laser Alert Tone", new int[]
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
				array[109] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Auto Mute reduces alarm level to 1 after 3 seconds and returns to normal operation(Auto Mute = OFF) 10 seconds after the alert ends.If the same alarm sounds within the 10 second period, Auto Mute remains at level 1.The unit returns to normal operation(Auto Mute = OFF) if a different band is detected during Auto Mute = ON mode.");
				array[110] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Volume", new int[]
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
				array[111] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Alert Level", new int[]
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
				}, "Sets a alert level for auto muted alarms.");
				UserSettingMenu[] array46 = array;
				int num22 = 112;
				UserSettingMenu.MENU_TYPE menuType22 = UserSettingMenu.MENU_TYPE.SOUND;
				string menuString22 = "Alert Temporary Volume";
				int[] array47 = new int[2];
				array47[0] = 1;
				array46[num22] = new UserSettingMenu(menuType22, menuString22, array47, new string[]
				{
					"Off",
					"On"
				}, "Temporary volume function On/Off.");
				UserSettingMenu[] array48 = array;
				int num23 = 113;
				UserSettingMenu.MENU_TYPE menuType23 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString23 = "Rear K Band Mute";
				int[] array49 = new int[2];
				array49[0] = 1;
				array48[num23] = new UserSettingMenu(menuType23, menuString23, array49, new string[]
				{
					"Off",
					"On"
				}, "Mutes K band signals from rear side.");
				array[114] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Dark mode Brightness", new int[]
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
				array[115] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Brightness", new int[]
				{
					4,
					3,
					2
				}, new string[]
				{
					"Bright",
					"Dim",
					"Dimmer"
				}, "The R7 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[116] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Brightness", new int[]
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
				}, "The R7 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[117] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Quiet Ride", new int[][]
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
				UserSettingMenu[] array50 = array;
				int num24 = 118;
				UserSettingMenu.MENU_TYPE menuType24 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString24 = "Quiet Ride MRCD On/Off";
				int[] array51 = new int[2];
				array51[0] = 1;
				array50[num24] = new UserSettingMenu(menuType24, menuString24, array51, new string[]
				{
					"Off",
					"On"
				}, "Mutes MRCD alarms when users drive under the speed limit set previously.");
				array[119] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Quiet Ride Volume", new int[]
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
				array[120] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Limit Speed", new int[][]
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
				array[121] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "GMT", new int[]
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
				UserSettingMenu[] array52 = array;
				int num25 = 122;
				UserSettingMenu.MENU_TYPE menuType25 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString25 = "DST";
				int[] array53 = new int[2];
				array53[0] = 1;
				array52[num25] = new UserSettingMenu(menuType25, menuString25, array53, new string[]
				{
					"Off",
					"On"
				}, "Daylight Saving Time");
				UserSettingMenu[] array54 = array;
				int num26 = 123;
				UserSettingMenu.MENU_TYPE menuType26 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString26 = "Low Battery Warning";
				int[] array55 = new int[2];
				array55[0] = 1;
				array54[num26] = new UserSettingMenu(menuType26, menuString26, array55, new string[]
				{
					"Off",
					"On"
				}, "Sounds a warning tone if the vehicle battery power drops below 11V.");
				UserSettingMenu[] array56 = array;
				int num27 = 124;
				UserSettingMenu.MENU_TYPE menuType27 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString27 = "Vehicle Battery Saver";
				int[] array57 = new int[2];
				array57[0] = 1;
				array56[num27] = new UserSettingMenu(menuType27, menuString27, array57, new string[]
				{
					"Off",
					"On"
				}, "Turns off power to the R7 if the speed stays at 0 or if the GPS is not connected for more than an hour.");
				array[125] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Self Test", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Runs a self diagnostic test on the unit to check for faults.");
				array[126] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Memory Quota", new int[]
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
				array[127] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Dim", new int[]
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
				array[128] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Main Volume", new int[]
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

			// Token: 0x060002FB RID: 763 RVA: 0x00042CB0 File Offset: 0x00040EB0
			private bool user_k_block_n_data_check_previous(byte[][] userSettingData, int rd_addr)
			{
				int num = ((int)userSettingData[rd_addr][0] << 24) + ((int)userSettingData[rd_addr][1] << 16) + ((int)userSettingData[rd_addr][2] << 8) + (int)userSettingData[rd_addr][3];
				int num2 = (num & 261632) >> 9;
				int num3 = num & 511;
				return num2 == 511 && num3 == 511;
			}

			// Token: 0x060002FC RID: 764 RVA: 0x0002BBAB File Offset: 0x00029DAB
			private int user_k_block_n_data_raw_strength_read(byte[][] userSettingData, int rd_addr)
			{
				return (((int)userSettingData[rd_addr][3] << 24) + ((int)userSettingData[rd_addr][2] << 16) + ((int)userSettingData[rd_addr][1] << 8) + (int)userSettingData[rd_addr][0] & 66846720) >> 18;
			}

			// Token: 0x060002FD RID: 765 RVA: 0x00042D04 File Offset: 0x00040F04
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

			// Token: 0x060002FE RID: 766 RVA: 0x00042DC8 File Offset: 0x00040FC8
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

			// Token: 0x060002FF RID: 767 RVA: 0x00042ECC File Offset: 0x000410CC
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
				int num = array2[2][3] >> 6 & (int)BinaryDefine.b00000001;
				array[83] = (array2[2][3] >> 5 & (int)BinaryDefine.b00000001);
				array[84] = (array2[2][3] >> 2 & (int)BinaryDefine.b00000111);
				int num2 = array2[2][3] >> 1 & (int)BinaryDefine.b00000001;
				array[27] = (int)(array2[2][3] & BinaryDefine.b00000001);
				if (array[84] > 7)
				{
					array[84] = 5;
				}
				array[26] = (array2[2][2] >> 7 & (int)BinaryDefine.b00000001);
				array[14] = (array2[2][2] >> 6 & (int)BinaryDefine.b00000001);
				array[16] = (array2[2][2] >> 5 & (int)BinaryDefine.b00000001);
				array[17] = (array2[2][2] >> 4 & (int)BinaryDefine.b00000001);
				array[18] = (array2[2][2] >> 3 & (int)BinaryDefine.b00000001);
				array[19] = (array2[2][2] >> 2 & (int)BinaryDefine.b00000001);
				array[24] = (array2[2][2] >> 1 & (int)BinaryDefine.b00000001);
				array[25] = (int)(array2[2][2] & BinaryDefine.b00000001);
				array[8] = (array2[2][1] >> 7 & (int)BinaryDefine.b00000001);
				byte b3 = array2[2][1];
				byte b4 = BinaryDefine.b00000111;
				array[109] = (array2[2][1] >> 3 & (int)BinaryDefine.b00000001);
				array[123] = (array2[2][1] >> 1 & (int)BinaryDefine.b00000001);
				array[125] = (int)(array2[2][1] & BinaryDefine.b00000001);
				int num3 = array2[2][0] >> 7 & (int)BinaryDefine.b00000001;
				array[127] = (array2[2][0] >> 4 & (int)BinaryDefine.b00000111);
				int num4 = array2[2][0] >> 3 & (int)BinaryDefine.b00000001;
				int num5 = (int)(array2[2][0] & BinaryDefine.b00000111);
				if (array[127] > 5)
				{
					array[127] = 5;
				}
				array[99] = (array2[1][2] >> 7 & (int)BinaryDefine.b00000001);
				int num6 = array2[1][2] >> 6 & (int)BinaryDefine.b00000001;
				array[122] = (array2[1][2] >> 5 & (int)BinaryDefine.b00000001);
				array[124] = (array2[1][2] >> 4 & (int)BinaryDefine.b00000001);
				int num7 = (int)(array2[1][2] & BinaryDefine.b00001111);
				if (array[99] == 1)
				{
					if (num7 >= 0 && num7 <= 10)
					{
						array[117] = num7 * 5;
					}
					else
					{
						array[117] = 0;
					}
				}
				else if (num7 >= 0 && num7 <= 8)
				{
					array[117] = num7 * 10;
				}
				else
				{
					array[117] = 0;
				}
				bool flag = (array2[1][3] >> 6 & (int)BinaryDefine.b00000001) != 0;
				array[21] = (array2[1][3] >> 5 & (int)BinaryDefine.b00000001);
				num7 = (int)(array2[1][3] & BinaryDefine.b00011111);
				if (array[99] == 1)
				{
					if (num7 == 0 || (num7 >= 10 && num7 <= 17))
					{
						array[12] = num7 * 5;
					}
					else
					{
						array[12] = 0;
					}
				}
				else if (num7 == 0 || (num7 >= 8 && num7 <= 14))
				{
					array[12] = num7 * 10;
				}
				else
				{
					array[12] = 0;
				}
				if (!flag)
				{
					if (array[99] == 1)
					{
						array[117] += 55;
					}
					else
					{
						array[117] += 90;
					}
				}
				array[9] = (array2[1][1] >> 6 & (int)BinaryDefine.b00000001);
				array[11] = (array2[1][1] >> 5 & (int)BinaryDefine.b00000001);
				num7 = (int)(array2[1][1] & BinaryDefine.b00011111);
				if (array[99] == 1)
				{
					if (num7 == 0 || (num7 >= 10 && num7 <= 20))
					{
						array[120] = num7 * 5;
					}
					else
					{
						array[120] = 0;
					}
				}
				else if (num7 == 0 || (num7 >= 8 && num7 <= 16))
				{
					array[120] = num7 * 10;
				}
				else
				{
					array[120] = 0;
				}
				int num8 = array2[1][0] >> 5 & (int)BinaryDefine.b00000111;
				num7 = (int)(array2[1][0] & BinaryDefine.b00011111);
				if (num8 >= 6)
				{
					if (array[8] == 1)
					{
						num8 = 4;
					}
					else
					{
						num8 = 2;
					}
				}
				if (num7 != 31)
				{
					array[121] = (int)((byte)num7 - 12);
					if (array[121] < -12 || array[121] > 12)
					{
						array[121] = -8;
					}
				}
				else
				{
					array[121] = -8;
				}
				array[80] = (array2[3][3] >> 6 & (int)BinaryDefine.b00000001);
				array[15] = (array2[3][3] >> 5 & (int)BinaryDefine.b00000001);
				bool flag2 = (array2[3][3] >> 4 & (int)BinaryDefine.b00000001) != 0;
				int num9 = array2[3][3] >> 3 & (int)BinaryDefine.b00000001;
				array[110] = (int)(array2[3][3] & BinaryDefine.b00000111);
				if (array[110] < 0 || array[110] > 7)
				{
					array[110] = 2;
				}
				array[22] = (array2[3][2] >> 7 & (int)BinaryDefine.b00000001);
				int num10 = array2[3][2] >> 6 & (int)BinaryDefine.b00000001;
				array[2] = (array2[3][2] >> 3 & (int)BinaryDefine.b00000111);
				array[3] = (int)(array2[3][2] & BinaryDefine.b00000111);
				int num11 = array2[3][1] >> 7 & (int)BinaryDefine.b00000001;
				int num12 = array2[3][1] >> 6 & (int)BinaryDefine.b00000001;
				array[98] = (array2[3][1] >> 5 & (int)BinaryDefine.b00000001);
				array[78] = (array2[3][1] >> 3 & (int)BinaryDefine.b00000001);
				array[4] = (int)(array2[3][1] & BinaryDefine.b00000111);
				array[77] = (array2[3][0] >> 7 & (int)BinaryDefine.b00000001);
				array[76] = (array2[3][0] >> 6 & (int)BinaryDefine.b00000001);
				array[75] = (array2[3][0] >> 5 & (int)BinaryDefine.b00000001);
				array[74] = (array2[3][0] >> 4 & (int)BinaryDefine.b00000001);
				array[73] = (array2[3][0] >> 3 & (int)BinaryDefine.b00000001);
				array[72] = (array2[3][0] >> 2 & (int)BinaryDefine.b00000001);
				array[71] = (array2[3][0] >> 1 & (int)BinaryDefine.b00000001);
				array[70] = (int)(array2[3][0] & BinaryDefine.b00000001);
				array[115] = (array2[4][3] >> 3 & (int)BinaryDefine.b00000111);
				array[116] = (int)(array2[4][3] & BinaryDefine.b00000111);
				if (array[115] < 2 || array[115] > 4)
				{
					array[115] = 4;
				}
				if (array[116] > 4)
				{
					array[116] = 3;
				}
				array[100] = (array2[4][2] >> 4 & (int)BinaryDefine.b00001111);
				array[101] = (int)(array2[4][2] & BinaryDefine.b00001111);
				array[108] = (array2[4][1] >> 4 & (int)BinaryDefine.b00001111);
				array[106] = (int)(array2[4][1] & BinaryDefine.b00001111);
				array[107] = (array2[5][3] >> 4 & (int)BinaryDefine.b00000111);
				array[104] = (int)(array2[5][3] & BinaryDefine.b00001111);
				array[20] = (array2[5][2] >> 7 & (int)BinaryDefine.b00000001);
				array[81] = (array2[5][2] >> 6 & (int)BinaryDefine.b00000001);
				int num13 = array2[5][2] >> 5 & (int)BinaryDefine.b00000001;
				array[114] = (int)(array2[5][2] & BinaryDefine.b00000111);
				if (array[114] < 2 || array[114] > 4)
				{
					array[114] = 2;
				}
				bool flag3 = (array2[5][1] >> 7 & (int)BinaryDefine.b00000001) != 0;
				array[86] = (array2[5][1] >> 3 & (int)BinaryDefine.b00000111);
				array[85] = (int)(array2[5][1] & BinaryDefine.b00000111);
				if (!flag3)
				{
					num5 = 8;
				}
				if (array[86] > 6)
				{
					array[86] = 6;
				}
				if (array[85] > 6)
				{
					array[85] = 6;
				}
				if (num5 >= 0 && num5 <= 8)
				{
					array[128] = num5;
				}
				else
				{
					array[128] = 4;
				}
				array[0] = (array2[5][0] >> 7 & (int)BinaryDefine.b00000001);
				array[118] = (array2[5][0] >> 6 & (int)BinaryDefine.b00000001);
				array[89] = (array2[5][0] >> 3 & (int)BinaryDefine.b00000111);
				array[87] = (int)(array2[5][0] & BinaryDefine.b00000111);
				if (array[89] > 6)
				{
					array[89] = 6;
				}
				if (array[87] > 6)
				{
					array[87] = 6;
				}
				if (array[100] > 12 || array[100] == 0)
				{
					array[100] = 1;
				}
				if (array[101] > 12 || array[101] == 0)
				{
					array[101] = 2;
				}
				if (array[104] > 12 || array[104] == 0)
				{
					array[104] = 2;
				}
				if (array[106] > 12 || array[106] == 0)
				{
					array[106] = 3;
				}
				if (array[107] > 6 || array[107] == 0)
				{
					array[107] = 1;
				}
				if (array[108] > 12 || array[108] == 0)
				{
					array[108] = 4;
				}
				array[91] = (array2[6][3] >> 4 & (int)BinaryDefine.b00001111);
				array[90] = (int)(array2[6][3] & BinaryDefine.b00001111);
				if (array[91] > 8)
				{
					array[91] = 8;
				}
				if (array[90] > 8)
				{
					array[90] = 8;
				}
				array[94] = (array2[6][2] >> 4 & (int)BinaryDefine.b00001111);
				array[92] = (int)(array2[6][2] & BinaryDefine.b00001111);
				if (array[94] > 8)
				{
					array[94] = 8;
				}
				if (array[92] > 8)
				{
					array[92] = 8;
				}
				if ((array2[6][1] >> 5 & (int)BinaryDefine.b00000001) == 1)
				{
					if (num10 == 0 && num6 == 1)
					{
						array[96] = 0;
					}
					else
					{
						array[96] = 1;
					}
				}
				else
				{
					array[96] = (array2[6][1] >> 4 & (int)BinaryDefine.b00000001);
				}
				int num14 = array2[6][1] >> 7 & (int)BinaryDefine.b00000001;
				int num15 = array2[6][1] >> 6 & (int)BinaryDefine.b00000001;
				array[5] = (int)(array2[6][1] & BinaryDefine.b00001111);
				if (array[5] > 8)
				{
					array[5] = 8;
				}
				if (array[5] == 0)
				{
					array[5] = 8;
				}
				array[10] = (array2[6][0] >> 5 & (int)BinaryDefine.b00000111);
				array[119] = (array2[6][0] >> 1 & (int)BinaryDefine.b00001111);
				array[113] = (int)(array2[6][0] & BinaryDefine.b00000001);
				if (array[10] > 4)
				{
					array[10] = 1;
				}
				if (array[119] > 8)
				{
					array[119] = 1;
				}
				array[102] = (array2[7][3] >> 4 & (int)BinaryDefine.b00000111);
				array[13] = (array2[7][3] >> 3 & (int)BinaryDefine.b00000001);
				int num16 = array2[7][3] >> 2 & (int)BinaryDefine.b00000001;
				int num17 = array2[7][3] >> 1 & (int)BinaryDefine.b00000001;
				int num18 = (int)(array2[7][3] & BinaryDefine.b00000001);
				if (array[102] > 6 || array[102] == 0)
				{
					array[102] = 1;
				}
				array[82] = (int)(array2[7][1] & BinaryDefine.b00000011);
				if (array[82] != 1 && array[82] != 0)
				{
					array[82] = array[80];
				}
				array[23] = (array2[8][3] >> 7 & (int)BinaryDefine.b00000001);
				array[88] = (array2[8][3] >> 4 & (int)BinaryDefine.b00000111);
				array[93] = (int)(array2[8][3] & BinaryDefine.b00001111);
				if (array[88] > 6)
				{
					array[88] = 6;
				}
				if (array[93] > 8)
				{
					array[93] = 8;
				}
				array[103] = (array2[8][2] >> 4 & (int)BinaryDefine.b00001111);
				array[105] = (int)(array2[8][2] & BinaryDefine.b00001111);
				if (array[103] > 8 || array[103] < 1)
				{
					array[103] = 4;
				}
				if (array[105] > 12 || array[105] == 0)
				{
					array[105] = 9;
				}
				array[111] = (array2[8][1] >> 1 & (int)BinaryDefine.b00001111);
				array[112] = (int)(array2[8][1] & BinaryDefine.b00000001);
				if (array[111] > 8)
				{
					array[111] = 8;
				}
				array[6] = (array2[8][0] >> 4 & (int)BinaryDefine.b00001111);
				array[7] = (int)(array2[8][0] & BinaryDefine.b00001111);
				if (array[6] > 8)
				{
					array[6] = 8;
				}
				if (array[6] == 0)
				{
					array[6] = 8;
				}
				if (array[7] > 8)
				{
					array[7] = 8;
				}
				if (array[7] == 0)
				{
					array[7] = 8;
				}
				if (num == 1 && num4 == 0)
				{
					array[1] = 0;
				}
				else if (num == 1 && num4 == 1)
				{
					array[1] = 1;
				}
				else if (num == 0)
				{
					array[1] = 2;
				}
				if (this.user_k_block_n_data_check_previous(array2, 14))
				{
					if (num12 == 0)
					{
						array[28] = 23;
						array[29] = 255;
					}
					else if (num15 == 0)
					{
						array[28] = 1;
						array[29] = 0;
					}
					else if (num14 == 0)
					{
						array[28] = 3;
						array[29] = 0;
					}
					else
					{
						array[28] = 7;
						array[29] = 0;
					}
					array[30] = 2;
					array[31] = 24194;
					array[32] = 24204;
					this.user_k_block_n_data_write(array2, 14, array, 28, array[1]);
				}
				if (this.user_k_block_n_data_check_previous(array2, 15))
				{
					if (num16 == 0)
					{
						array[33] = 23;
						array[34] = 255;
					}
					else if (num18 == 0)
					{
						array[33] = 1;
						array[34] = 0;
					}
					else if (num17 == 0)
					{
						array[33] = 3;
						array[34] = 0;
					}
					else
					{
						array[33] = 7;
						array[34] = 0;
					}
					array[35] = 2;
					array[36] = 24166;
					array[37] = 24170;
					this.user_k_block_n_data_write(array2, 15, array, 33, array[1]);
				}
				if (this.user_k_block_n_data_check_previous(array2, 16))
				{
					array[38] = 1;
					array[39] = 0;
					array[40] = 2;
					array[41] = 24121;
					array[42] = 24124;
					this.user_k_block_n_data_write(array2, 16, array, 38, array[1]);
				}
				this.user_k_block_n_data_read(array2, 14, array, 28, array[1]);
				this.user_k_block_n_data_read(array2, 15, array, 33, array[1]);
				this.user_k_block_n_data_read(array2, 16, array, 38, array[1]);
				this.user_k_block_n_data_read(array2, 9, array, 43, array[1]);
				this.user_k_block_n_data_read(array2, 10, array, 48, array[1]);
				this.user_k_block_n_data_read(array2, 11, array, 53, array[1]);
				this.user_k_block_n_data_read(array2, 12, array, 58, array[1]);
				this.user_k_block_n_data_read(array2, 13, array, 63, array[1]);
				if (num3 == 0)
				{
					array[68] = 0;
				}
				else if (num13 == 0)
				{
					array[68] = 2;
				}
				else
				{
					array[68] = 1;
				}
				if (!flag2)
				{
					if (num2 == 1)
					{
						array[69] = 1;
					}
					else
					{
						array[69] = 0;
					}
				}
				else
				{
					array[69] = 2;
				}
				if (num9 == 1)
				{
					array[79] = 0;
				}
				else if (num11 == 1)
				{
					array[79] = 2;
				}
				else
				{
					array[79] = 1;
				}
				if (num10 == 0)
				{
					if (num6 == 1)
					{
						array[95] = 1;
					}
					else
					{
						array[95] = 2;
					}
				}
				else
				{
					array[95] = 0;
				}
				array[97] = num8;
				array[126] = (int)nvData[256];
				return array;
			}

			// Token: 0x06000300 RID: 768 RVA: 0x00043B30 File Offset: 0x00041D30
			public byte[] GetNVDataFromUserSetting(int[] userSettingR7, byte[] receivedNVData)
			{
				if (this.menuCnt == 0)
				{
					return null;
				}
				byte[][] array = new byte[17][];
				byte[] array2 = new byte[receivedNVData.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = new byte[4];
					for (int j = 0; j < 4; j++)
					{
						array[i][j] = 0;
					}
				}
				byte b;
				byte b2;
				if (userSettingR7[1] == 2)
				{
					b = 0;
					b2 = 0;
				}
				else if (userSettingR7[1] == 1)
				{
					b = 1;
					b2 = 1;
				}
				else
				{
					if (userSettingR7[1] != 0)
					{
						return null;
					}
					b = 1;
					b2 = 0;
				}
				byte b3;
				byte b4;
				if (userSettingR7[68] == 2)
				{
					b3 = 1;
					b4 = 0;
				}
				else if (userSettingR7[68] == 1)
				{
					b3 = 1;
					b4 = 1;
				}
				else
				{
					if (userSettingR7[68] != 0)
					{
						return null;
					}
					b3 = 0;
					b4 = 1;
				}
				byte b5;
				byte b6;
				if (userSettingR7[69] == 2)
				{
					b5 = 0;
					b6 = 1;
				}
				else if (userSettingR7[69] == 1)
				{
					b5 = 1;
					b6 = 0;
				}
				else
				{
					if (userSettingR7[69] != 0)
					{
						return null;
					}
					b5 = 0;
					b6 = 0;
				}
				byte b7;
				byte b8;
				if (userSettingR7[79] == 2)
				{
					b7 = 0;
					b8 = 1;
				}
				else if (userSettingR7[79] == 1)
				{
					b7 = 0;
					b8 = 0;
				}
				else
				{
					if (userSettingR7[79] != 0)
					{
						return null;
					}
					b7 = 1;
					b8 = 0;
				}
				byte b9;
				byte b10;
				if (userSettingR7[95] == 2)
				{
					b9 = 0;
					b10 = 0;
				}
				else if (userSettingR7[95] == 1)
				{
					b9 = 0;
					b10 = 1;
				}
				else
				{
					if (userSettingR7[95] != 0)
					{
						return null;
					}
					b9 = 1;
					b10 = 1;
				}
				byte b11;
				if (userSettingR7[99] == 1)
				{
					if (userSettingR7[117] > 50)
					{
						b11 = 0;
					}
					else
					{
						b11 = 1;
					}
				}
				else
				{
					if (userSettingR7[99] != 0)
					{
						return null;
					}
					if (userSettingR7[117] > 80)
					{
						b11 = 0;
					}
					else
					{
						b11 = 1;
					}
				}
				byte b12 = (byte)userSettingR7[97];
				byte[] array3 = array[2];
				int num = 3;
				array3[num] |= (byte)((int)b << 6 & (int)BinaryDefine.b01000000);
				byte[] array4 = array[2];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR7[83] << 5 & (int)BinaryDefine.b00100000);
				byte[] array5 = array[2];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR7[84] << 2 & (int)BinaryDefine.b00011100);
				byte[] array6 = array[2];
				int num4 = 3;
				array6[num4] |= (byte)((int)b5 << 1 & (int)BinaryDefine.b00000010);
				byte[] array7 = array[2];
				int num5 = 3;
				array7[num5] |= (byte)(userSettingR7[27] & (int)BinaryDefine.b00000001);
				byte[] array8 = array[2];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR7[26] << 7 & (int)BinaryDefine.b10000000);
				byte[] array9 = array[2];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR7[14] << 6 & (int)BinaryDefine.b01000000);
				byte[] array10 = array[2];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR7[16] << 5 & (int)BinaryDefine.b00100000);
				byte[] array11 = array[2];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR7[17] << 4 & (int)BinaryDefine.b00010000);
				byte[] array12 = array[2];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR7[18] << 3 & (int)BinaryDefine.b00001000);
				byte[] array13 = array[2];
				int num11 = 2;
				array13[num11] |= (byte)(userSettingR7[19] << 2 & (int)BinaryDefine.b00000100);
				byte[] array14 = array[2];
				int num12 = 2;
				array14[num12] |= (byte)(userSettingR7[24] << 1 & (int)BinaryDefine.b00000010);
				byte[] array15 = array[2];
				int num13 = 2;
				array15[num13] |= (byte)(userSettingR7[25] & (int)BinaryDefine.b00000001);
				byte[] array16 = array[2];
				int num14 = 1;
				array16[num14] |= (byte)(userSettingR7[8] << 7 & (int)BinaryDefine.b10000000);
				byte[] array17 = array[2];
				int num15 = 1;
				array17[num15] |= (byte)(userSettingR7[109] << 3 & (int)BinaryDefine.b00001000);
				byte[] array18 = array[2];
				int num16 = 1;
				array18[num16] |= (byte)(userSettingR7[123] << 1 & (int)BinaryDefine.b00000010);
				byte[] array19 = array[2];
				int num17 = 1;
				array19[num17] |= (byte)(userSettingR7[125] & (int)BinaryDefine.b00000001);
				byte[] array20 = array[2];
				int num18 = 0;
				array20[num18] |= (byte)((int)b3 << 7 & (int)BinaryDefine.b10000000);
				byte[] array21 = array[2];
				int num19 = 0;
				array21[num19] |= (byte)(userSettingR7[127] << 4 & (int)BinaryDefine.b01110000);
				byte[] array22 = array[2];
				int num20 = 0;
				array22[num20] |= (byte)((int)b2 << 3 & (int)BinaryDefine.b00001000);
				if (userSettingR7[128] >= 8)
				{
					byte[] array23 = array[2];
					int num21 = 0;
					array23[num21] |= BinaryDefine.b00000110;
				}
				else
				{
					byte[] array24 = array[2];
					int num22 = 0;
					array24[num22] |= (byte)(userSettingR7[128] & (int)BinaryDefine.b00000111);
				}
				byte b13;
				if (b11 == 1)
				{
					if (userSettingR7[99] == 1)
					{
						b13 = (byte)(userSettingR7[117] / 5);
					}
					else
					{
						b13 = (byte)(userSettingR7[117] / 10);
					}
				}
				else if (userSettingR7[99] == 1)
				{
					b13 = (byte)((userSettingR7[117] - 55) / 5);
				}
				else
				{
					b13 = (byte)((userSettingR7[117] - 90) / 10);
				}
				byte[] array25 = array[1];
				int num23 = 2;
				array25[num23] |= (byte)(userSettingR7[99] << 7 & (int)BinaryDefine.b10000000);
				byte[] array26 = array[1];
				int num24 = 2;
				array26[num24] |= (byte)((int)b10 << 6 & (int)BinaryDefine.b01000000);
				byte[] array27 = array[1];
				int num25 = 2;
				array27[num25] |= (byte)(userSettingR7[122] << 5 & (int)BinaryDefine.b00100000);
				byte[] array28 = array[1];
				int num26 = 2;
				array28[num26] |= (byte)(userSettingR7[124] << 4 & (int)BinaryDefine.b00010000);
				byte[] array29 = array[1];
				int num27 = 2;
				array29[num27] |= unchecked((byte)(b13 & BinaryDefine.b00001111));
				if (userSettingR7[99] == 1)
				{
					b13 = (byte)(userSettingR7[12] / 5);
				}
				else
				{
					b13 = (byte)(userSettingR7[12] / 10);
				}
				byte[] array30 = array[1];
				int num28 = 3;
				array30[num28] |= (byte)((int)b11 << 6 & (int)BinaryDefine.b01000000);
				byte[] array31 = array[1];
				int num29 = 3;
				array31[num29] |= (byte)(userSettingR7[21] << 5 & (int)BinaryDefine.b00100000);
				byte[] array32 = array[1];
				int num30 = 3;
				array32[num30] |= unchecked((byte)(b13 & BinaryDefine.b00011111));
				if (userSettingR7[99] == 1)
				{
					b13 = (byte)(userSettingR7[120] / 5);
				}
				else
				{
					b13 = (byte)(userSettingR7[120] / 10);
				}
				byte[] array33 = array[1];
				int num31 = 1;
				array33[num31] |= (byte)(userSettingR7[9] << 6 & (int)BinaryDefine.b01000000);
				byte[] array34 = array[1];
				int num32 = 1;
				array34[num32] |= (byte)(userSettingR7[11] << 5 & (int)BinaryDefine.b00100000);
				byte[] array35 = array[1];
				int num33 = 1;
				array35[num33] |= unchecked((byte)(b13 & BinaryDefine.b00011111));
				b13 = (byte)(userSettingR7[121] + 12);
				byte[] array36 = array[1];
				int num34 = 0;
				array36[num34] |= (byte)((int)b12 << 5 & (int)BinaryDefine.b11100000);
				byte[] array37 = array[1];
				int num35 = 0;
				array37[num35] |= unchecked((byte)(b13 & BinaryDefine.b00011111));
				byte[] array38 = array[3];
				int num36 = 3;
				array38[num36] |= (byte)(userSettingR7[80] << 6 & (int)BinaryDefine.b01000000);
				byte[] array39 = array[3];
				int num37 = 3;
				array39[num37] |= (byte)(userSettingR7[15] << 5 & (int)BinaryDefine.b00100000);
				byte[] array40 = array[3];
				int num38 = 3;
				array40[num38] |= (byte)((int)b6 << 4 & (int)BinaryDefine.b00010000);
				byte[] array41 = array[3];
				int num39 = 3;
				array41[num39] |= (byte)((int)b7 << 3 & (int)BinaryDefine.b00001000);
				byte[] array42 = array[3];
				int num40 = 3;
				array42[num40] |= (byte)(userSettingR7[110] & (int)BinaryDefine.b00000111);
				byte[] array43 = array[3];
				int num41 = 2;
				array43[num41] |= (byte)(userSettingR7[22] << 7 & (int)BinaryDefine.b10000000);
				byte[] array44 = array[3];
				int num42 = 2;
				array44[num42] |= (byte)((int)b9 << 6 & (int)BinaryDefine.b01000000);
				byte[] array45 = array[3];
				int num43 = 2;
				array45[num43] |= (byte)(userSettingR7[2] << 3 & (int)BinaryDefine.b00111000);
				byte[] array46 = array[3];
				int num44 = 2;
				array46[num44] |= (byte)(userSettingR7[3] & (int)BinaryDefine.b00000111);
				byte[] array47 = array[3];
				int num45 = 1;
				array47[num45] |= (byte)((int)b8 << 7 & (int)BinaryDefine.b10000000);
				byte[] array48 = array[3];
				int num46 = 1;
				array48[num46] |= (byte)(userSettingR7[98] << 5 & (int)BinaryDefine.b00100000);
				byte[] array49 = array[3];
				int num47 = 1;
				array49[num47] |= (byte)(userSettingR7[78] << 3 & (int)BinaryDefine.b00001000);
				byte[] array50 = array[3];
				int num48 = 1;
				array50[num48] |= (byte)(userSettingR7[4] & (int)BinaryDefine.b00000111);
				byte[] array51 = array[3];
				int num49 = 0;
				array51[num49] |= (byte)(userSettingR7[77] << 7 & (int)BinaryDefine.b10000000);
				byte[] array52 = array[3];
				int num50 = 0;
				array52[num50] |= (byte)(userSettingR7[76] << 6 & (int)BinaryDefine.b01000000);
				byte[] array53 = array[3];
				int num51 = 0;
				array53[num51] |= (byte)(userSettingR7[75] << 5 & (int)BinaryDefine.b00100000);
				byte[] array54 = array[3];
				int num52 = 0;
				array54[num52] |= (byte)(userSettingR7[74] << 4 & (int)BinaryDefine.b00010000);
				byte[] array55 = array[3];
				int num53 = 0;
				array55[num53] |= (byte)(userSettingR7[73] << 3 & (int)BinaryDefine.b00001000);
				byte[] array56 = array[3];
				int num54 = 0;
				array56[num54] |= (byte)(userSettingR7[72] << 2 & (int)BinaryDefine.b00000100);
				byte[] array57 = array[3];
				int num55 = 0;
				array57[num55] |= (byte)(userSettingR7[71] << 1 & (int)BinaryDefine.b00000010);
				byte[] array58 = array[3];
				int num56 = 0;
				array58[num56] |= (byte)(userSettingR7[70] & (int)BinaryDefine.b00000001);
				byte[] array59 = array[4];
				int num57 = 3;
				array59[num57] |= (byte)(userSettingR7[115] << 3 & (int)BinaryDefine.b00111000);
				byte[] array60 = array[4];
				int num58 = 3;
				array60[num58] |= (byte)(userSettingR7[116] & (int)BinaryDefine.b00000111);
				byte[] array61 = array[4];
				int num59 = 2;
				array61[num59] |= (byte)(userSettingR7[100] << 4 & (int)BinaryDefine.b11110000);
				byte[] array62 = array[4];
				int num60 = 2;
				array62[num60] |= (byte)(userSettingR7[101] & (int)BinaryDefine.b00001111);
				byte[] array63 = array[4];
				int num61 = 1;
				array63[num61] |= (byte)(userSettingR7[108] << 4 & (int)BinaryDefine.b11110000);
				byte[] array64 = array[4];
				int num62 = 1;
				array64[num62] |= (byte)(userSettingR7[106] & (int)BinaryDefine.b00001111);
				byte[] array65 = array[5];
				int num63 = 3;
				array65[num63] |= (byte)(userSettingR7[107] << 4 & (int)BinaryDefine.b01110000);
				byte[] array66 = array[5];
				int num64 = 3;
				array66[num64] |= (byte)(userSettingR7[104] & (int)BinaryDefine.b00001111);
				byte[] array67 = array[5];
				int num65 = 2;
				array67[num65] |= (byte)(userSettingR7[20] << 7 & (int)BinaryDefine.b10000000);
				byte[] array68 = array[5];
				int num66 = 2;
				array68[num66] |= (byte)(userSettingR7[81] << 6 & (int)BinaryDefine.b01000000);
				byte[] array69 = array[5];
				int num67 = 2;
				array69[num67] |= (byte)((int)b4 << 5 & (int)BinaryDefine.b00100000);
				byte[] array70 = array[5];
				int num68 = 2;
				array70[num68] |= (byte)(userSettingR7[114] & (int)BinaryDefine.b00000111);
				if (userSettingR7[128] >= 8)
				{
					byte[] array71 = array[5];
					int num69 = 1;
					array71[num69] &= BinaryDefine.b01111111;
				}
				else
				{
					byte[] array72 = array[5];
					int num70 = 1;
					array72[num70] |= BinaryDefine.b10000000;
				}
				byte[] array73 = array[5];
				int num71 = 1;
				array73[num71] |= (byte)(userSettingR7[86] << 3 & (int)BinaryDefine.b00111000);
				byte[] array74 = array[5];
				int num72 = 1;
				array74[num72] |= (byte)(userSettingR7[85] & (int)BinaryDefine.b00000111);
				byte[] array75 = array[5];
				int num73 = 0;
				array75[num73] |= (byte)(userSettingR7[0] << 7 & (int)BinaryDefine.b10000000);
				byte[] array76 = array[5];
				int num74 = 0;
				array76[num74] |= (byte)(userSettingR7[118] << 6 & (int)BinaryDefine.b01000000);
				byte[] array77 = array[5];
				int num75 = 0;
				array77[num75] |= (byte)(userSettingR7[89] << 3 & (int)BinaryDefine.b00111000);
				byte[] array78 = array[5];
				int num76 = 0;
				array78[num76] |= (byte)(userSettingR7[87] & (int)BinaryDefine.b00000111);
				byte[] array79 = array[6];
				int num77 = 3;
				array79[num77] |= (byte)(userSettingR7[91] << 4 & (int)BinaryDefine.b11110000);
				byte[] array80 = array[6];
				int num78 = 3;
				array80[num78] |= (byte)(userSettingR7[90] & (int)BinaryDefine.b00001111);
				byte[] array81 = array[6];
				int num79 = 2;
				array81[num79] |= (byte)(userSettingR7[94] << 4 & (int)BinaryDefine.b11110000);
				byte[] array82 = array[6];
				int num80 = 2;
				array82[num80] |= (byte)(userSettingR7[92] & (int)BinaryDefine.b00001111);
				byte[] array83 = array[6];
				int num81 = 1;
				array83[num81] |= (byte)(userSettingR7[96] << 4 & (int)BinaryDefine.b00010000);
				byte[] array84 = array[6];
				int num82 = 1;
				array84[num82] |= (byte)(userSettingR7[5] & (int)BinaryDefine.b00001111);
				byte[] array85 = array[6];
				int num83 = 0;
				array85[num83] |= (byte)(userSettingR7[10] << 5 & (int)BinaryDefine.b11100000);
				byte[] array86 = array[6];
				int num84 = 0;
				array86[num84] |= (byte)(userSettingR7[119] << 1 & (int)BinaryDefine.b00011110);
				byte[] array87 = array[6];
				int num85 = 0;
				array87[num85] |= (byte)(userSettingR7[113] & (int)BinaryDefine.b00000001);
				byte[] array88 = array[7];
				int num86 = 3;
				array88[num86] |= (byte)(userSettingR7[102] << 4 & (int)BinaryDefine.b01110000);
				byte[] array89 = array[7];
				int num87 = 3;
				array89[num87] |= (byte)(userSettingR7[13] << 3 & (int)BinaryDefine.b00001000);
				byte[] array90 = array[7];
				int num88 = 1;
				array90[num88] |= (byte)(userSettingR7[82] & (int)BinaryDefine.b00000011);
				byte[] array91 = array[8];
				int num89 = 3;
				array91[num89] |= (byte)(userSettingR7[23] << 7 & (int)BinaryDefine.b10000000);
				byte[] array92 = array[8];
				int num90 = 3;
				array92[num90] |= (byte)(userSettingR7[88] << 4 & (int)BinaryDefine.b01110000);
				byte[] array93 = array[8];
				int num91 = 3;
				array93[num91] |= (byte)(userSettingR7[93] & (int)BinaryDefine.b00001111);
				byte[] array94 = array[8];
				int num92 = 2;
				array94[num92] |= (byte)(userSettingR7[103] << 4 & (int)BinaryDefine.b11110000);
				byte[] array95 = array[8];
				int num93 = 2;
				array95[num93] |= (byte)(userSettingR7[105] & (int)BinaryDefine.b00001111);
				byte[] array96 = array[8];
				int num94 = 1;
				array96[num94] |= (byte)(userSettingR7[111] << 1 & (int)BinaryDefine.b00011110);
				byte[] array97 = array[8];
				int num95 = 1;
				array97[num95] |= (byte)(userSettingR7[112] & (int)BinaryDefine.b00000001);
				byte[] array98 = array[8];
				int num96 = 0;
				array98[num96] |= (byte)(userSettingR7[6] << 4 & (int)BinaryDefine.b11110000);
				byte[] array99 = array[8];
				int num97 = 0;
				array99[num97] |= (byte)(userSettingR7[7] & (int)BinaryDefine.b00001111);
				this.user_k_block_n_data_write(array, 9, userSettingR7, 43, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 10, userSettingR7, 48, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 11, userSettingR7, 53, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 12, userSettingR7, 58, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 13, userSettingR7, 63, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 14, userSettingR7, 28, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 15, userSettingR7, 33, userSettingR7[1]);
				this.user_k_block_n_data_write(array, 16, userSettingR7, 38, userSettingR7[1]);
				Array.Copy(receivedNVData, array2, receivedNVData.Length);
				for (int i = 0; i < array.Length; i++)
				{
					for (int j = 0; j < array[i].Length; j++)
					{
						byte[] array100 = array2;
						int num98 = i * 4 + j;
						array100[num98] &= unchecked((byte)(~this.userNVDataPos[i * 4 + j]));
						byte[] array101 = array2;
						int num99 = i * 4 + j;
						array101[num99] |= array[i][j];
					}
				}
				array2[256] = (byte)userSettingR7[126];
				int num100 = 0;
				for (int i = 0; i < receivedNVData.Length; i++)
				{
					if (receivedNVData[i] == array2[i])
					{
						num100++;
					}
				}
				return array2;
			}

			// Token: 0x040005D7 RID: 1495
			private int supportVersion = 146;

			// Token: 0x040005D8 RID: 1496
			private int menuCnt = 129;

			// Token: 0x040005D9 RID: 1497
			private byte[] userNVDataPos = new byte[]
			{
				0,
				0,
				0,
				0,
				byte.MaxValue,
				127,
				byte.MaxValue,
				127,
				byte.MaxValue,
				139,
				byte.MaxValue,
				127,
				byte.MaxValue,
				175,
				byte.MaxValue,
				127,
				0,
				byte.MaxValue,
				byte.MaxValue,
				63,
				byte.MaxValue,
				191,
				231,
				127,
				byte.MaxValue,
				31,
				byte.MaxValue,
				byte.MaxValue,
				0,
				3,
				0,
				120,
				byte.MaxValue,
				31,
				byte.MaxValue,
				byte.MaxValue,
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
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
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

			// Token: 0x040005DA RID: 1498
			private const int memoryQuotaPos = 256;

			// Token: 0x040005DB RID: 1499
			private const int HEADER = 0;

			// Token: 0x040005DC RID: 1500
			private const int GPS = 1;

			// Token: 0x040005DD RID: 1501
			private const int RD_1 = 2;

			// Token: 0x040005DE RID: 1502
			private const int RD_2 = 3;

			// Token: 0x040005DF RID: 1503
			private const int RD_3 = 4;

			// Token: 0x040005E0 RID: 1504
			private const int RD_4 = 5;

			// Token: 0x040005E1 RID: 1505
			private const int RD_5 = 6;

			// Token: 0x040005E2 RID: 1506
			private const int RD_6 = 7;

			// Token: 0x040005E3 RID: 1507
			private const int RD_7 = 8;

			// Token: 0x040005E4 RID: 1508
			private const int USR_K_BLK1 = 9;

			// Token: 0x040005E5 RID: 1509
			private const int USR_K_BLK2 = 10;

			// Token: 0x040005E6 RID: 1510
			private const int USR_K_BLK3 = 11;

			// Token: 0x040005E7 RID: 1511
			private const int USR_K_BLK4 = 12;

			// Token: 0x040005E8 RID: 1512
			private const int USR_K_BLK5 = 13;

			// Token: 0x040005E9 RID: 1513
			private const int CONST_K_BLK1 = 14;

			// Token: 0x040005EA RID: 1514
			private const int CONST_K_BLK2 = 15;

			// Token: 0x040005EB RID: 1515
			private const int CONST_K_BLK3 = 16;

			// Token: 0x040005EC RID: 1516
			private const int ADDR_CNT = 17;

			// Token: 0x040005ED RID: 1517
			private const int RF_PWR_STRENGTH_LEVEL0P5 = 76;

			// Token: 0x040005EE RID: 1518
			private const int RF_PWR_STRENGTH_LEVEL1 = 82;

			// Token: 0x040005EF RID: 1519
			private const int RF_PWR_STRENGTH_LEVEL1P5 = 88;

			// Token: 0x040005F0 RID: 1520
			private const int RF_PWR_STRENGTH_LEVEL2 = 94;

			// Token: 0x040005F1 RID: 1521
			private const int RF_PWR_STRENGTH_LEVEL2P5 = 99;

			// Token: 0x040005F2 RID: 1522
			private const int RF_PWR_STRENGTH_LEVEL3 = 104;

			// Token: 0x040005F3 RID: 1523
			private const int RF_PWR_STRENGTH_LEVEL3P5 = 109;

			// Token: 0x040005F4 RID: 1524
			private const int RF_PWR_STRENGTH_LEVEL4 = 115;

			// Token: 0x040005F5 RID: 1525
			private const int RF_PWR_STRENGTH_LEVEL4P5 = 121;

			// Token: 0x040005F6 RID: 1526
			private const int RF_PWR_STRENGTH_LEVEL5 = 128;

			// Token: 0x040005F7 RID: 1527
			private const int RF_PWR_STRENGTH_LEVEL5P5 = 133;

			// Token: 0x040005F8 RID: 1528
			private const int RF_PWR_STRENGTH_LEVEL6 = 138;

			// Token: 0x040005F9 RID: 1529
			private const int RF_PWR_STRENGTH_LEVEL6P5 = 145;

			// Token: 0x040005FA RID: 1530
			private const int RF_PWR_STRENGTH_LEVEL7 = 152;

			// Token: 0x040005FB RID: 1531
			private const int RF_PWR_STRENGTH_LEVEL7P5 = 159;

			// Token: 0x040005FC RID: 1532
			private const int RF_PWR_STRENGTH_LEVEL0P5_CITY = 113;

			// Token: 0x040005FD RID: 1533
			private const int RF_PWR_STRENGTH_LEVEL1_CITY = 115;

			// Token: 0x040005FE RID: 1534
			private const int RF_PWR_STRENGTH_LEVEL1P5_CITY = 117;

			// Token: 0x040005FF RID: 1535
			private const int RF_PWR_STRENGTH_LEVEL2_CITY = 120;

			// Token: 0x04000600 RID: 1536
			private const int RF_PWR_STRENGTH_LEVEL2P5_CITY = 124;

			// Token: 0x04000601 RID: 1537
			private const int RF_PWR_STRENGTH_LEVEL3_CITY = 128;

			// Token: 0x04000602 RID: 1538
			private const int RF_PWR_STRENGTH_LEVEL3P5_CITY = 130;

			// Token: 0x04000603 RID: 1539
			private const int RF_PWR_STRENGTH_LEVEL4_CITY = 132;

			// Token: 0x04000604 RID: 1540
			private const int RF_PWR_STRENGTH_LEVEL4P5_CITY = 135;

			// Token: 0x04000605 RID: 1541
			private const int RF_PWR_STRENGTH_LEVEL5_CITY = 138;

			// Token: 0x04000606 RID: 1542
			private const int RF_PWR_STRENGTH_LEVEL5P5_CITY = 140;

			// Token: 0x04000607 RID: 1543
			private const int RF_PWR_STRENGTH_LEVEL6_CITY = 142;

			// Token: 0x04000608 RID: 1544
			private const int RF_PWR_STRENGTH_LEVEL6P5_CITY = 147;

			// Token: 0x04000609 RID: 1545
			private const int RF_PWR_STRENGTH_LEVEL7_CITY = 152;

			// Token: 0x0400060A RID: 1546
			private const int RF_PWR_STRENGTH_LEVEL7P5_CITY = 157;

			// Token: 0x0400060B RID: 1547
			private const int K_BLOCK_FILTER_LEVEL_0P5 = 8;

			// Token: 0x0400060C RID: 1548
			private const int K_BLOCK_FILTER_LEVEL_1P0 = 9;

			// Token: 0x0400060D RID: 1549
			private const int K_BLOCK_FILTER_LEVEL_1P5 = 10;

			// Token: 0x0400060E RID: 1550
			private const int K_BLOCK_FILTER_LEVEL_2P0 = 11;

			// Token: 0x0400060F RID: 1551
			private const int K_BLOCK_FILTER_LEVEL_2P5 = 12;

			// Token: 0x04000610 RID: 1552
			private const int K_BLOCK_FILTER_LEVEL_3P0 = 13;

			// Token: 0x04000611 RID: 1553
			private const int K_BLOCK_FILTER_LEVEL_3P5 = 14;

			// Token: 0x04000612 RID: 1554
			private const int K_BLOCK_FILTER_LEVEL_4P0 = 15;

			// Token: 0x04000613 RID: 1555
			private const int K_BLOCK_FILTER_LEVEL_4P5 = 16;

			// Token: 0x04000614 RID: 1556
			private const int K_BLOCK_FILTER_LEVEL_5P0 = 17;

			// Token: 0x04000615 RID: 1557
			private const int K_BLOCK_FILTER_LEVEL_5P5 = 18;

			// Token: 0x04000616 RID: 1558
			private const int K_BLOCK_FILTER_LEVEL_6P0 = 19;

			// Token: 0x04000617 RID: 1559
			private const int K_BLOCK_FILTER_LEVEL_6P5 = 20;

			// Token: 0x04000618 RID: 1560
			private const int K_BLOCK_FILTER_LEVEL_7P0 = 21;

			// Token: 0x04000619 RID: 1561
			private const int K_BLOCK_FILTER_LEVEL_7P5 = 22;

			// Token: 0x0400061A RID: 1562
			private const int K_BLOCK_FILTER_LEVEL_8P0 = 23;

			// Token: 0x020000BA RID: 186
			private enum MENU
			{
				// Token: 0x040009F0 RID: 2544
				MENU_MODE,
				// Token: 0x040009F1 RID: 2545
				DETECTION_MODE,
				// Token: 0x040009F2 RID: 2546
				X_SENSITIVE,
				// Token: 0x040009F3 RID: 2547
				K_SENSITIVE,
				// Token: 0x040009F4 RID: 2548
				KA_SENSITIVE,
				// Token: 0x040009F5 RID: 2549
				REAR_K_ATTENUATION,
				// Token: 0x040009F6 RID: 2550
				REAR_KA_ATTENUATION,
				// Token: 0x040009F7 RID: 2551
				REAR_X_ATTENUATION,
				// Token: 0x040009F8 RID: 2552
				GPS_ENABLE,
				// Token: 0x040009F9 RID: 2553
				SPEED_CAMERA_ENABLE,
				// Token: 0x040009FA RID: 2554
				SPEED_CAMERA_ALERT_RANGE,
				// Token: 0x040009FB RID: 2555
				RLC_ENABLE,
				// Token: 0x040009FC RID: 2556
				RLC_QRIDE,
				// Token: 0x040009FD RID: 2557
				POI_PASSCHIME,
				// Token: 0x040009FE RID: 2558
				VOICE_ENABLE,
				// Token: 0x040009FF RID: 2559
				KA_FREQ_VOICE,
				// Token: 0x04000A00 RID: 2560
				X_BAND_ENABLE,
				// Token: 0x04000A01 RID: 2561
				K_BAND_ENABLE,
				// Token: 0x04000A02 RID: 2562
				KA_BAND_ENABLE,
				// Token: 0x04000A03 RID: 2563
				LASER_ENABLE,
				// Token: 0x04000A04 RID: 2564
				LASER_GUN_ID_ENABLE,
				// Token: 0x04000A05 RID: 2565
				K_POP_ENABLE,
				// Token: 0x04000A06 RID: 2566
				MRCD_ENABLE,
				// Token: 0x04000A07 RID: 2567
				GATSO_ENABLE,
				// Token: 0x04000A08 RID: 2568
				KA_POP_ENABLE,
				// Token: 0x04000A09 RID: 2569
				K_FILTER_ENABLE,
				// Token: 0x04000A0A RID: 2570
				KA_FILTER_ENABLE,
				// Token: 0x04000A0B RID: 2571
				TSF_ENABLE,
				// Token: 0x04000A0C RID: 2572
				K_BLOCK_FILTER_1_OP_MODE,
				// Token: 0x04000A0D RID: 2573
				K_BLOCK_FILTER_1_RAW_STRENGTH,
				// Token: 0x04000A0E RID: 2574
				K_BLOCK_FILTER_1_DIR,
				// Token: 0x04000A0F RID: 2575
				K_BLOCK_FILTER_1_MIN_FREQ,
				// Token: 0x04000A10 RID: 2576
				K_BLOCK_FILTER_1_MAX_FREQ,
				// Token: 0x04000A11 RID: 2577
				K_BLOCK_FILTER_2_OP_MODE,
				// Token: 0x04000A12 RID: 2578
				K_BLOCK_FILTER_2_RAW_STRENGTH,
				// Token: 0x04000A13 RID: 2579
				K_BLOCK_FILTER_2_DIR,
				// Token: 0x04000A14 RID: 2580
				K_BLOCK_FILTER_2_MIN_FREQ,
				// Token: 0x04000A15 RID: 2581
				K_BLOCK_FILTER_2_MAX_FREQ,
				// Token: 0x04000A16 RID: 2582
				K_BLOCK_FILTER_3_OP_MODE,
				// Token: 0x04000A17 RID: 2583
				K_BLOCK_FILTER_3_RAW_STRENGTH,
				// Token: 0x04000A18 RID: 2584
				K_BLOCK_FILTER_3_DIR,
				// Token: 0x04000A19 RID: 2585
				K_BLOCK_FILTER_3_MIN_FREQ,
				// Token: 0x04000A1A RID: 2586
				K_BLOCK_FILTER_3_MAX_FREQ,
				// Token: 0x04000A1B RID: 2587
				USER_K_BLOCK_FILTER_1_OP_MODE,
				// Token: 0x04000A1C RID: 2588
				USER_K_BLOCK_FILTER_1_RAW_STRENGTH,
				// Token: 0x04000A1D RID: 2589
				USER_K_BLOCK_FILTER_1_DIR,
				// Token: 0x04000A1E RID: 2590
				USER_K_BLOCK_FILTER_1_MIN_FREQ,
				// Token: 0x04000A1F RID: 2591
				USER_K_BLOCK_FILTER_1_MAX_FREQ,
				// Token: 0x04000A20 RID: 2592
				USER_K_BLOCK_FILTER_2_OP_MODE,
				// Token: 0x04000A21 RID: 2593
				USER_K_BLOCK_FILTER_2_RAW_STRENGTH,
				// Token: 0x04000A22 RID: 2594
				USER_K_BLOCK_FILTER_2_DIR,
				// Token: 0x04000A23 RID: 2595
				USER_K_BLOCK_FILTER_2_MIN_FREQ,
				// Token: 0x04000A24 RID: 2596
				USER_K_BLOCK_FILTER_2_MAX_FREQ,
				// Token: 0x04000A25 RID: 2597
				USER_K_BLOCK_FILTER_3_OP_MODE,
				// Token: 0x04000A26 RID: 2598
				USER_K_BLOCK_FILTER_3_RAW_STRENGTH,
				// Token: 0x04000A27 RID: 2599
				USER_K_BLOCK_FILTER_3_DIR,
				// Token: 0x04000A28 RID: 2600
				USER_K_BLOCK_FILTER_3_MIN_FREQ,
				// Token: 0x04000A29 RID: 2601
				USER_K_BLOCK_FILTER_3_MAX_FREQ,
				// Token: 0x04000A2A RID: 2602
				USER_K_BLOCK_FILTER_4_OP_MODE,
				// Token: 0x04000A2B RID: 2603
				USER_K_BLOCK_FILTER_4_RAW_STRENGTH,
				// Token: 0x04000A2C RID: 2604
				USER_K_BLOCK_FILTER_4_DIR,
				// Token: 0x04000A2D RID: 2605
				USER_K_BLOCK_FILTER_4_MIN_FREQ,
				// Token: 0x04000A2E RID: 2606
				USER_K_BLOCK_FILTER_4_MAX_FREQ,
				// Token: 0x04000A2F RID: 2607
				USER_K_BLOCK_FILTER_5_OP_MODE,
				// Token: 0x04000A30 RID: 2608
				USER_K_BLOCK_FILTER_5_RAW_STRENGTH,
				// Token: 0x04000A31 RID: 2609
				USER_K_BLOCK_FILTER_5_DIR,
				// Token: 0x04000A32 RID: 2610
				USER_K_BLOCK_FILTER_5_MIN_FREQ,
				// Token: 0x04000A33 RID: 2611
				USER_K_BLOCK_FILTER_5_MAX_FREQ,
				// Token: 0x04000A34 RID: 2612
				K_NARROW,
				// Token: 0x04000A35 RID: 2613
				KA_NARROW,
				// Token: 0x04000A36 RID: 2614
				KA_SEG1,
				// Token: 0x04000A37 RID: 2615
				KA_SEG2,
				// Token: 0x04000A38 RID: 2616
				KA_SEG3,
				// Token: 0x04000A39 RID: 2617
				KA_SEG4,
				// Token: 0x04000A3A RID: 2618
				KA_SEG5,
				// Token: 0x04000A3B RID: 2619
				KA_SEG6,
				// Token: 0x04000A3C RID: 2620
				KA_SEG7,
				// Token: 0x04000A3D RID: 2621
				KA_SEG8,
				// Token: 0x04000A3E RID: 2622
				KA_SEG9,
				// Token: 0x04000A3F RID: 2623
				PRIORITY_MODE,
				// Token: 0x04000A40 RID: 2624
				MUTE_MEM_BAND_OPTION,
				// Token: 0x04000A41 RID: 2625
				AUTO_MUTE_MEM_ENABLE,
				// Token: 0x04000A42 RID: 2626
				AUTO_MUTE_MEM_BAND_OPTION,
				// Token: 0x04000A43 RID: 2627
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x04000A44 RID: 2628
				BACKGROUND_COLOR,
				// Token: 0x04000A45 RID: 2629
				X_BAND_ARROW_COLOR,
				// Token: 0x04000A46 RID: 2630
				K_BAND_ARROW_COLOR,
				// Token: 0x04000A47 RID: 2631
				MRCD_ARROW_COLOR,
				// Token: 0x04000A48 RID: 2632
				GATSO_ARROW_COLOR,
				// Token: 0x04000A49 RID: 2633
				KA_BAND_ARROW_COLOR,
				// Token: 0x04000A4A RID: 2634
				X_BAND_COLOR,
				// Token: 0x04000A4B RID: 2635
				K_BAND_COLOR,
				// Token: 0x04000A4C RID: 2636
				MRCD_COLOR,
				// Token: 0x04000A4D RID: 2637
				GATSO_COLOR,
				// Token: 0x04000A4E RID: 2638
				KA_BAND_COLOR,
				// Token: 0x04000A4F RID: 2639
				MAIN_DISPLAY,
				// Token: 0x04000A50 RID: 2640
				HEARTBEAT_ICON_ENABLE,
				// Token: 0x04000A51 RID: 2641
				LEFT_DISPLAY,
				// Token: 0x04000A52 RID: 2642
				ALERT_DISPLAY,
				// Token: 0x04000A53 RID: 2643
				SPEED_UNIT,
				// Token: 0x04000A54 RID: 2644
				X_BAND_ALERT_TONE,
				// Token: 0x04000A55 RID: 2645
				K_BAND_ALERT_TONE,
				// Token: 0x04000A56 RID: 2646
				K_BAND_BOGEY_TONE,
				// Token: 0x04000A57 RID: 2647
				K_BAND_BOGEY_LEVEL,
				// Token: 0x04000A58 RID: 2648
				MRCD_ALERT_TONE,
				// Token: 0x04000A59 RID: 2649
				GATSO_ALERT_TONE,
				// Token: 0x04000A5A RID: 2650
				KA_BAND_ALERT_TONE,
				// Token: 0x04000A5B RID: 2651
				KA_BAND_BOGEY_TONE,
				// Token: 0x04000A5C RID: 2652
				LASER_ALERT_TONE,
				// Token: 0x04000A5D RID: 2653
				AUTO_MUTE_ENABLE,
				// Token: 0x04000A5E RID: 2654
				AUTO_MUTE_VOLUME,
				// Token: 0x04000A5F RID: 2655
				AUTO_MUTE_ALERT_LEVEL,
				// Token: 0x04000A60 RID: 2656
				ALERT_TEMPORARY_VOLUME,
				// Token: 0x04000A61 RID: 2657
				REAR_K_BAND_MUTE_ENABLE,
				// Token: 0x04000A62 RID: 2658
				DARK_MODE_BRIGHTNESS,
				// Token: 0x04000A63 RID: 2659
				AUTO_DIM_SET_BRIGHT_BRIGHTNESS,
				// Token: 0x04000A64 RID: 2660
				AUTO_DIM_SET_DIM_BRIGHTNESS,
				// Token: 0x04000A65 RID: 2661
				QRIDE_MODE,
				// Token: 0x04000A66 RID: 2662
				MRCD_QRIDE_ENABLE,
				// Token: 0x04000A67 RID: 2663
				QRIDE_VOLUME,
				// Token: 0x04000A68 RID: 2664
				LIMIT_SPEED_MODE,
				// Token: 0x04000A69 RID: 2665
				GMT,
				// Token: 0x04000A6A RID: 2666
				DST_ENABLE,
				// Token: 0x04000A6B RID: 2667
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x04000A6C RID: 2668
				VEHICLE_BATT_SAVER_ENABLE,
				// Token: 0x04000A6D RID: 2669
				SELF_TEST_ENABLE,
				// Token: 0x04000A6E RID: 2670
				MEMORY_QUOTA,
				// Token: 0x04000A6F RID: 2671
				MAIN_DIM_SET,
				// Token: 0x04000A70 RID: 2672
				MAIN_VOLUME
			}
		}

		// Token: 0x02000090 RID: 144
		private class v143 : UserSettingFormat
		{
			// Token: 0x06000302 RID: 770 RVA: 0x0004483B File Offset: 0x00042A3B
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x06000303 RID: 771 RVA: 0x00044843 File Offset: 0x00042A43
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x06000304 RID: 772 RVA: 0x0004484B File Offset: 0x00042A4B
			public byte[] GetNVDataMask()
			{
				return this.userNVDataPos;
			}

			// Token: 0x06000305 RID: 773 RVA: 0x00024E4C File Offset: 0x0002304C
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return false;
			}

			// Token: 0x06000306 RID: 774 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_level(int strength, int mode)
			{
				return -1;
			}

			// Token: 0x06000307 RID: 775 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_raw_strength(int level, int mode)
			{
				return -1;
			}

			// Token: 0x06000308 RID: 776 RVA: 0x00044854 File Offset: 0x00042A54
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
					2
				}, new string[]
				{
					"City",
					"Highway",
					"Advanced"
				}, "Highway - Full Sensitivity\nCity - X and K sensitivity reduced. Ka band sensitivity same as Highway.\nAdvanced - User adjusts X, K, and Ka band sensitivity from 100%~30% in 10% intervals.");
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
				array[5] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Rear Attenuation", new int[]
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
				array[6] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "GPS On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Determines your geographic location.");
				array[7] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "Speed Camera Off/On", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Notifies you if any speed cameras are nearby.");
				array[8] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_MATCHING_VALUE_MULTI_ITEM_ATT, "Speed Camera Alert Range", new int[][]
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
				array[9] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "Red Light Camera On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Notifies you if any red light cameras are nearby.");
				array[10] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Red Light Camera Quiet Ride", new int[][]
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
				UserSettingMenu[] array2 = array;
				int num = 11;
				UserSettingMenu.MENU_TYPE menuType = UserSettingMenu.MENU_TYPE.GPS;
				string menuString = "POI PassChime";
				int[] array3 = new int[2];
				array3[0] = 1;
				array2[num] = new UserSettingMenu(menuType, menuString, array3, new string[]
				{
					"Off",
					"On"
				}, "POI PassChime sounds when users pass by a POI.");
				array[12] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Voice On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns voice alert on or off under the following conditions:\nType of radar / laser Band alarms");
				array[13] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Frequency Voice", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Announces the detected Ka band frequency.");
				UserSettingMenu[] array4 = array;
				int num2 = 14;
				UserSettingMenu.MENU_TYPE menuType2 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString2 = "X Band On/Off";
				int[] array5 = new int[2];
				array5[0] = 1;
				array4[num2] = new UserSettingMenu(menuType2, menuString2, array5, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore X band frequencies.\nTurn on for X band sensitivity as follows:\nHighway: Full sensitivity\nCity: X band sensitivity reduced");
				array[15] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore K band frequencies.");
				array[16] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore Ka band frequencies.");
				array[17] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore lasers.");
				UserSettingMenu[] array6 = array;
				int num3 = 18;
				UserSettingMenu.MENU_TYPE menuType3 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString3 = "Laser Gun ID On/Off";
				int[] array7 = new int[2];
				array7[0] = 1;
				array6[num3] = new UserSettingMenu(menuType3, menuString3, array7, new string[]
				{
					"Off",
					"On"
				}, "Turn on to display laser gun identifier.");
				UserSettingMenu[] array8 = array;
				int num4 = 19;
				UserSettingMenu.MENU_TYPE menuType4 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString4 = "K POP On/Off";
				int[] array9 = new int[2];
				array9[0] = 1;
				array8[num4] = new UserSettingMenu(menuType4, menuString4, array9, new string[]
				{
					"Off",
					"On"
				}, "Detects K POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[20] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "MRCD On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates MultaRadar CD/CT low - powered radar gun detection.");
				UserSettingMenu[] array10 = array;
				int num5 = 21;
				UserSettingMenu.MENU_TYPE menuType5 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString5 = "Ka POP On/Off";
				int[] array11 = new int[2];
				array11[0] = 1;
				array10[num5] = new UserSettingMenu(menuType5, menuString5, array11, new string[]
				{
					"Off",
					"On"
				}, "Detects Ka POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[22] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Filter", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the K band to prevent false detections.");
				UserSettingMenu[] array12 = array;
				int num6 = 23;
				UserSettingMenu.MENU_TYPE menuType6 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString6 = "Ka Filter";
				int[] array13 = new int[2];
				array13[0] = 1;
				array12[num6] = new UserSettingMenu(menuType6, menuString6, array13, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the Ka band to prevent false detections.");
				UserSettingMenu[] array14 = array;
				int num7 = 24;
				UserSettingMenu.MENU_TYPE menuType7 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString7 = "TSF";
				int[] array15 = new int[2];
				array15[0] = 1;
				array14[num7] = new UserSettingMenu(menuType7, menuString7, array15, new string[]
				{
					"Off",
					"On"
				}, "Traffic Sensor Filter. Prevents false alarms caused by traffic monitoring radar systems.");
				array[25] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter 24.199Ghz (± 0.005)", new int[]
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
				array[26] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter 24.168Ghz (± 0.002)", new int[]
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
				array[27] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Narrow/Wide/Extended", new int[]
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
				array[28] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Narrow/Wide/Segmentation", new int[]
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
				int num8 = 29;
				UserSettingMenu.MENU_TYPE menuType8 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString8 = "Ka Segmentation 33.399Ghz – 33.705Ghz";
				int[] array17 = new int[2];
				array17[0] = 1;
				array16[num8] = new UserSettingMenu(menuType8, menuString8, array17, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.399Ghz – 33.705Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array18 = array;
				int num9 = 30;
				UserSettingMenu.MENU_TYPE menuType9 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString9 = "Ka Segmentation 33.705Ghz – 33.903Ghz";
				int[] array19 = new int[2];
				array19[0] = 1;
				array18[num9] = new UserSettingMenu(menuType9, menuString9, array19, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.705Ghz – 33.903Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array20 = array;
				int num10 = 31;
				UserSettingMenu.MENU_TYPE menuType10 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString10 = "Ka Segmentation 33.903Ghz – 34.191Ghz";
				int[] array21 = new int[2];
				array21[0] = 1;
				array20[num10] = new UserSettingMenu(menuType10, menuString10, array21, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.903Ghz – 34.191Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array22 = array;
				int num11 = 32;
				UserSettingMenu.MENU_TYPE menuType11 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString11 = "Ka Segmentation 34.191Ghz – 34.587Ghz";
				int[] array23 = new int[2];
				array23[0] = 1;
				array22[num11] = new UserSettingMenu(menuType11, menuString11, array23, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.191Ghz – 34.587Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array24 = array;
				int num12 = 33;
				UserSettingMenu.MENU_TYPE menuType12 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString12 = "Ka Segmentation 34.587Ghz – 34.803Ghz";
				int[] array25 = new int[2];
				array25[0] = 1;
				array24[num12] = new UserSettingMenu(menuType12, menuString12, array25, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.587Ghz – 34.803Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array26 = array;
				int num13 = 34;
				UserSettingMenu.MENU_TYPE menuType13 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString13 = "Ka Segmentation 34.803Ghz – 35.163Ghz";
				int[] array27 = new int[2];
				array27[0] = 1;
				array26[num13] = new UserSettingMenu(menuType13, menuString13, array27, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.803Ghz – 35.163Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array28 = array;
				int num14 = 35;
				UserSettingMenu.MENU_TYPE menuType14 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString14 = "Ka Segmentation 35.163Ghz – 35.379Ghz";
				int[] array29 = new int[2];
				array29[0] = 1;
				array28[num14] = new UserSettingMenu(menuType14, menuString14, array29, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.163Ghz – 35.379Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array30 = array;
				int num15 = 36;
				UserSettingMenu.MENU_TYPE menuType15 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString15 = "Ka Segmentation 35.379Ghz – 35.613Ghz";
				int[] array31 = new int[2];
				array31[0] = 1;
				array30[num15] = new UserSettingMenu(menuType15, menuString15, array31, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.379Ghz – 35.613Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array32 = array;
				int num16 = 37;
				UserSettingMenu.MENU_TYPE menuType16 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString16 = "Ka Segmentation 35.613Ghz – 35.701Ghz";
				int[] array33 = new int[2];
				array33[0] = 1;
				array32[num16] = new UserSettingMenu(menuType16, menuString16, array33, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.613Ghz – 35.701Ghz (Ka Segmentation mode)");
				array[38] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Priority", new int[]
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
				array[39] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Select bands to be muted.");
				array[40] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute Memory On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "This menu turns the ability to automatically save mute requests for specific locations/frequency bands.");
				array[41] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Auto Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Auto Mute Memory Band Option Set specifies which bands will be muted.");
				UserSettingMenu[] array34 = array;
				int num17 = 42;
				UserSettingMenu.MENU_TYPE menuType17 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString17 = "All Threat Display";
				int[] array35 = new int[2];
				array35[0] = 1;
				array34[num17] = new UserSettingMenu(menuType17, menuString17, array35, new string[]
				{
					"Off",
					"On"
				}, "Displays if more than one radar signals are detected at the same time. The signal with the strongest radar signal is considered the main signal. The other signals are displayed on the left side.");
				array[43] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Background Color", new int[]
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
				array[44] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
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
				array[45] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
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
				array[46] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
				}, new string[]
				{
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red"
				}, "Set MRCD arrow color.");
				array[47] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Arrow Color", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5,
					6
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
				array[48] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Color", new int[]
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
				array[49] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Color", new int[]
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
				array[50] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD Color", new int[]
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
					"Violet",
					"White",
					"Yellow",
					"Orange",
					"Green",
					"Blue",
					"Red",
					"Arrow",
					"Signal"
				}, "Set MRCD indicator color.\nIf Signal is selected, the radar band color matches the signal strength level color. It changes as the signal strength level changes.");
				array[51] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Color", new int[]
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
				array[52] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Display", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Mode",
					"Scan",
					"Time"
				}, "Select what will display on the OLED, either scanning for frequencies, the mode, or the time.\n(GPS On)");
				UserSettingMenu[] array36 = array;
				int num18 = 53;
				UserSettingMenu.MENU_TYPE menuType18 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString18 = "Scan Icon";
				int[] array37 = new int[2];
				array37[0] = 1;
				array36[num18] = new UserSettingMenu(menuType18, menuString18, array37, new string[]
				{
					"Off",
					"On"
				}, "Scan Icon displays to indicate the end of a scan cycle.");
				array[54] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Left Display", new int[]
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
				UserSettingMenu[] array38 = array;
				int num19 = 55;
				UserSettingMenu.MENU_TYPE menuType19 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString19 = "Alert Display";
				int[] array39 = new int[2];
				array39[0] = 1;
				array38[num19] = new UserSettingMenu(menuType19, menuString19, array39, new string[]
				{
					"Type 1",
					"Type 2"
				}, "Select one of two OLED display formats.");
				UserSettingMenu[] array40 = array;
				int num20 = 56;
				UserSettingMenu.MENU_TYPE menuType20 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString20 = "Speed Unit";
				int[] array41 = new int[2];
				array41[0] = 1;
				array40[num20] = new UserSettingMenu(menuType20, menuString20, array41, new string[]
				{
					"mph",
					"km/h"
				}, "Select the speed measurement type.");
				array[56].isUnitMenuFlag = true;
				array[57] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "X Band Alert Tone", new int[]
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
				array[58] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Alert Tone", new int[]
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
				array[59] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Tone", new int[]
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
				array[60] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Level", new int[]
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
				array[61] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "MRCD Alert Tone", new int[]
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
				}, "Set a tone to indicate MRCD.");
				array[62] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Alert Tone", new int[]
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
				array[63] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Bogey Tone", new int[]
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
				array[64] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Laser Alert Tone", new int[]
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
				array[65] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Auto Mute reduces alarm level to 1 after 3 seconds and returns to normal operation(Auto Mute = OFF) 10 seconds after the alert ends.If the same alarm sounds within the 10 second period, Auto Mute remains at level 1.The unit returns to normal operation(Auto Mute = OFF) if a different band is detected during Auto Mute = ON mode.");
				array[66] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Volume", new int[]
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
				UserSettingMenu[] array42 = array;
				int num21 = 67;
				UserSettingMenu.MENU_TYPE menuType21 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString21 = "Rear K Band Mute";
				int[] array43 = new int[2];
				array43[0] = 1;
				array42[num21] = new UserSettingMenu(menuType21, menuString21, array43, new string[]
				{
					"Off",
					"On"
				}, "Mutes K band signals from rear side.");
				array[68] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Dark mode Brightness", new int[]
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
				array[69] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Brightness", new int[]
				{
					4,
					3,
					2
				}, new string[]
				{
					"Bright",
					"Dim",
					"Dimmer"
				}, "The R7 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[70] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Brightness", new int[]
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
				}, "The R7 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[71] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Quiet Ride", new int[][]
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
				int num22 = 72;
				UserSettingMenu.MENU_TYPE menuType22 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString22 = "Quiet Ride MRCD On/Off";
				int[] array45 = new int[2];
				array45[0] = 1;
				array44[num22] = new UserSettingMenu(menuType22, menuString22, array45, new string[]
				{
					"Off",
					"On"
				}, "Mutes MRCD alarms when users drive under the speed limit set previously.");
				array[73] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Quiet Ride Volume", new int[]
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
				array[74] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Limit Speed", new int[][]
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
				array[75] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "GMT", new int[]
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
				int num23 = 76;
				UserSettingMenu.MENU_TYPE menuType23 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString23 = "DST";
				int[] array47 = new int[2];
				array47[0] = 1;
				array46[num23] = new UserSettingMenu(menuType23, menuString23, array47, new string[]
				{
					"Off",
					"On"
				}, "Daylight Saving Time");
				UserSettingMenu[] array48 = array;
				int num24 = 77;
				UserSettingMenu.MENU_TYPE menuType24 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString24 = "Low Battery Warning";
				int[] array49 = new int[2];
				array49[0] = 1;
				array48[num24] = new UserSettingMenu(menuType24, menuString24, array49, new string[]
				{
					"Off",
					"On"
				}, "Sounds a warning tone if the vehicle battery power drops below 11V.");
				UserSettingMenu[] array50 = array;
				int num25 = 78;
				UserSettingMenu.MENU_TYPE menuType25 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString25 = "Vehicle Battery Saver";
				int[] array51 = new int[2];
				array51[0] = 1;
				array50[num25] = new UserSettingMenu(menuType25, menuString25, array51, new string[]
				{
					"Off",
					"On"
				}, "Turns off power to the R7 if the speed stays at 0 or if the GPS is not connected for more than an hour.");
				array[79] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Self Test", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Runs a self diagnostic test on the unit to check for faults.");
				array[80] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Memory Quota", new int[]
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
				array[81] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Dim", new int[]
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
				array[82] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Main Volume", new int[]
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

			// Token: 0x06000309 RID: 777 RVA: 0x000465A0 File Offset: 0x000447A0
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
				int num = array2[2][3] >> 6 & (int)BinaryDefine.b00000001;
				array[42] = (array2[2][3] >> 5 & (int)BinaryDefine.b00000001);
				array[43] = (array2[2][3] >> 2 & (int)BinaryDefine.b00000111);
				int num2 = array2[2][3] >> 1 & (int)BinaryDefine.b00000001;
				array[24] = (int)(array2[2][3] & BinaryDefine.b00000001);
				if (array[43] > 7)
				{
					array[43] = 5;
				}
				array[23] = (array2[2][2] >> 7 & (int)BinaryDefine.b00000001);
				array[12] = (array2[2][2] >> 6 & (int)BinaryDefine.b00000001);
				array[14] = (array2[2][2] >> 5 & (int)BinaryDefine.b00000001);
				array[15] = (array2[2][2] >> 4 & (int)BinaryDefine.b00000001);
				array[16] = (array2[2][2] >> 3 & (int)BinaryDefine.b00000001);
				array[17] = (array2[2][2] >> 2 & (int)BinaryDefine.b00000001);
				array[21] = (array2[2][2] >> 1 & (int)BinaryDefine.b00000001);
				array[22] = (int)(array2[2][2] & BinaryDefine.b00000001);
				array[6] = (array2[2][1] >> 7 & (int)BinaryDefine.b00000001);
				byte b3 = array2[2][1];
				byte b4 = BinaryDefine.b00000111;
				array[65] = (array2[2][1] >> 3 & (int)BinaryDefine.b00000001);
				array[77] = (array2[2][1] >> 1 & (int)BinaryDefine.b00000001);
				array[79] = (int)(array2[2][1] & BinaryDefine.b00000001);
				int num3 = array2[2][0] >> 7 & (int)BinaryDefine.b00000001;
				array[81] = (array2[2][0] >> 4 & (int)BinaryDefine.b00000111);
				int num4 = array2[2][0] >> 3 & (int)BinaryDefine.b00000001;
				int num5 = (int)(array2[2][0] & BinaryDefine.b00000111);
				if (array[81] > 5)
				{
					array[81] = 5;
				}
				array[56] = (array2[1][2] >> 7 & (int)BinaryDefine.b00000001);
				int num6 = array2[1][2] >> 6 & (int)BinaryDefine.b00000001;
				array[76] = (array2[1][2] >> 5 & (int)BinaryDefine.b00000001);
				array[78] = (array2[1][2] >> 4 & (int)BinaryDefine.b00000001);
				int num7 = (int)(array2[1][2] & BinaryDefine.b00001111);
				if (array[56] == 1)
				{
					if (num7 >= 0 && num7 <= 10)
					{
						array[71] = num7 * 5;
					}
					else
					{
						array[71] = 0;
					}
				}
				else if (num7 >= 0 && num7 <= 8)
				{
					array[71] = num7 * 10;
				}
				else
				{
					array[71] = 0;
				}
				bool flag = (array2[1][3] >> 6 & (int)BinaryDefine.b00000001) != 0;
				array[19] = (array2[1][3] >> 5 & (int)BinaryDefine.b00000001);
				num7 = (int)(array2[1][3] & BinaryDefine.b00011111);
				if (array[56] == 1)
				{
					if (num7 == 0 || (num7 >= 10 && num7 <= 17))
					{
						array[10] = num7 * 5;
					}
					else
					{
						array[10] = 0;
					}
				}
				else if (num7 == 0 || (num7 >= 8 && num7 <= 14))
				{
					array[10] = num7 * 10;
				}
				else
				{
					array[10] = 0;
				}
				if (!flag)
				{
					if (array[56] == 1)
					{
						array[71] += 55;
					}
					else
					{
						array[71] += 90;
					}
				}
				array[7] = (array2[1][1] >> 6 & (int)BinaryDefine.b00000001);
				array[9] = (array2[1][1] >> 5 & (int)BinaryDefine.b00000001);
				num7 = (int)(array2[1][1] & BinaryDefine.b00011111);
				if (array[56] == 1)
				{
					if (num7 == 0 || (num7 >= 10 && num7 <= 20))
					{
						array[74] = num7 * 5;
					}
					else
					{
						array[74] = 0;
					}
				}
				else if (num7 == 0 || (num7 >= 8 && num7 <= 16))
				{
					array[74] = num7 * 10;
				}
				else
				{
					array[74] = 0;
				}
				int num8 = array2[1][0] >> 5 & (int)BinaryDefine.b00000111;
				num7 = (int)(array2[1][0] & BinaryDefine.b00011111);
				if (num8 >= 6)
				{
					if (array[6] == 1)
					{
						num8 = 4;
					}
					else
					{
						num8 = 2;
					}
				}
				if (num7 != 31)
				{
					array[75] = (int)((byte)num7 - 12);
					if (array[75] < -12 || array[75] > 12)
					{
						array[75] = -8;
					}
				}
				else
				{
					array[75] = -8;
				}
				array[39] = (array2[3][3] >> 6 & (int)BinaryDefine.b00000001);
				array[13] = (array2[3][3] >> 5 & (int)BinaryDefine.b00000001);
				bool flag2 = (array2[3][3] >> 4 & (int)BinaryDefine.b00000001) != 0;
				int num9 = array2[3][3] >> 3 & (int)BinaryDefine.b00000001;
				array[66] = (int)(array2[3][3] & BinaryDefine.b00000111);
				if (array[66] < 0 || array[66] > 7)
				{
					array[66] = 2;
				}
				array[20] = (array2[3][2] >> 7 & (int)BinaryDefine.b00000001);
				int num10 = array2[3][2] >> 6 & (int)BinaryDefine.b00000001;
				array[2] = (array2[3][2] >> 3 & (int)BinaryDefine.b00000111);
				array[3] = (int)(array2[3][2] & BinaryDefine.b00000111);
				int num11 = array2[3][1] >> 7 & (int)BinaryDefine.b00000001;
				int num12 = array2[3][1] >> 6 & (int)BinaryDefine.b00000001;
				array[55] = (array2[3][1] >> 5 & (int)BinaryDefine.b00000001);
				array[37] = (array2[3][1] >> 3 & (int)BinaryDefine.b00000001);
				array[4] = (int)(array2[3][1] & BinaryDefine.b00000111);
				array[36] = (array2[3][0] >> 7 & (int)BinaryDefine.b00000001);
				array[35] = (array2[3][0] >> 6 & (int)BinaryDefine.b00000001);
				array[34] = (array2[3][0] >> 5 & (int)BinaryDefine.b00000001);
				array[33] = (array2[3][0] >> 4 & (int)BinaryDefine.b00000001);
				array[32] = (array2[3][0] >> 3 & (int)BinaryDefine.b00000001);
				array[31] = (array2[3][0] >> 2 & (int)BinaryDefine.b00000001);
				array[30] = (array2[3][0] >> 1 & (int)BinaryDefine.b00000001);
				array[29] = (int)(array2[3][0] & BinaryDefine.b00000001);
				array[69] = (array2[4][3] >> 3 & (int)BinaryDefine.b00000111);
				array[70] = (int)(array2[4][3] & BinaryDefine.b00000111);
				if (array[69] < 2 || array[69] > 4)
				{
					array[69] = 4;
				}
				if (array[70] > 4)
				{
					array[70] = 3;
				}
				array[57] = (array2[4][2] >> 4 & (int)BinaryDefine.b00001111);
				array[58] = (int)(array2[4][2] & BinaryDefine.b00001111);
				array[64] = (array2[4][1] >> 4 & (int)BinaryDefine.b00001111);
				array[62] = (int)(array2[4][1] & BinaryDefine.b00001111);
				array[63] = (array2[5][3] >> 4 & (int)BinaryDefine.b00000111);
				array[61] = (int)(array2[5][3] & BinaryDefine.b00001111);
				array[18] = (array2[5][2] >> 7 & (int)BinaryDefine.b00000001);
				array[40] = (array2[5][2] >> 6 & (int)BinaryDefine.b00000001);
				int num13 = array2[5][2] >> 5 & (int)BinaryDefine.b00000001;
				array[68] = (int)(array2[5][2] & BinaryDefine.b00000111);
				if (array[68] < 2 || array[68] > 4)
				{
					array[68] = 2;
				}
				bool flag3 = (array2[5][1] >> 7 & (int)BinaryDefine.b00000001) != 0;
				array[45] = (array2[5][1] >> 3 & (int)BinaryDefine.b00000111);
				array[44] = (int)(array2[5][1] & BinaryDefine.b00000111);
				if (!flag3)
				{
					num5 = 8;
				}
				if (array[45] > 6)
				{
					array[45] = 6;
				}
				if (array[44] > 6)
				{
					array[44] = 6;
				}
				if (num5 >= 0 && num5 <= 8)
				{
					array[82] = num5;
				}
				else
				{
					array[82] = 4;
				}
				array[0] = (array2[5][0] >> 7 & (int)BinaryDefine.b00000001);
				array[72] = (array2[5][0] >> 6 & (int)BinaryDefine.b00000001);
				array[47] = (array2[5][0] >> 3 & (int)BinaryDefine.b00000111);
				array[46] = (int)(array2[5][0] & BinaryDefine.b00000111);
				if (array[47] > 6)
				{
					array[47] = 6;
				}
				if (array[46] > 6)
				{
					array[46] = 6;
				}
				if (array[57] > 12 || array[57] == 0)
				{
					array[57] = 1;
				}
				if (array[58] > 12 || array[58] == 0)
				{
					array[58] = 2;
				}
				if (array[61] > 12 || array[61] == 0)
				{
					array[61] = 2;
				}
				if (array[62] > 12 || array[62] == 0)
				{
					array[62] = 3;
				}
				if (array[63] > 6 || array[63] == 0)
				{
					array[63] = 1;
				}
				if (array[64] > 12 || array[64] == 0)
				{
					array[64] = 4;
				}
				array[49] = (array2[6][3] >> 4 & (int)BinaryDefine.b00001111);
				array[48] = (int)(array2[6][3] & BinaryDefine.b00001111);
				if (array[49] > 8)
				{
					array[49] = 8;
				}
				if (array[48] > 8)
				{
					array[48] = 8;
				}
				array[51] = (array2[6][2] >> 4 & (int)BinaryDefine.b00001111);
				array[50] = (int)(array2[6][2] & BinaryDefine.b00001111);
				if (array[51] > 8)
				{
					array[51] = 8;
				}
				if (array[50] > 8)
				{
					array[50] = 8;
				}
				if ((array2[6][1] >> 5 & (int)BinaryDefine.b00000001) == 1)
				{
					if (num10 == 0 && num6 == 1)
					{
						array[53] = 0;
					}
					else
					{
						array[53] = 1;
					}
				}
				else
				{
					array[53] = (array2[6][1] >> 4 & (int)BinaryDefine.b00000001);
				}
				int num14 = array2[6][1] >> 7 & (int)BinaryDefine.b00000001;
				int num15 = array2[6][1] >> 6 & (int)BinaryDefine.b00000001;
				array[5] = (int)(array2[6][1] & BinaryDefine.b00001111);
				if (array[5] > 8)
				{
					array[5] = 8;
				}
				if (array[5] == 0)
				{
					array[5] = 8;
				}
				array[8] = (array2[6][0] >> 5 & (int)BinaryDefine.b00000111);
				array[73] = (array2[6][0] >> 1 & (int)BinaryDefine.b00001111);
				array[67] = (int)(array2[6][0] & BinaryDefine.b00000001);
				if (array[8] > 4)
				{
					array[8] = 1;
				}
				if (array[73] > 8)
				{
					array[73] = 1;
				}
				array[59] = (array2[7][3] >> 4 & (int)BinaryDefine.b00000111);
				array[11] = (array2[7][3] >> 3 & (int)BinaryDefine.b00000001);
				bool flag4 = (array2[7][3] >> 2 & (int)BinaryDefine.b00000001) != 0;
				int num16 = array2[7][3] >> 1 & (int)BinaryDefine.b00000001;
				int num17 = (int)(array2[7][3] & BinaryDefine.b00000001);
				if (array[59] > 6 || array[59] == 0)
				{
					array[59] = 1;
				}
				array[41] = (int)(array2[7][1] & BinaryDefine.b00000011);
				if (array[41] != 1 && array[41] != 0)
				{
					array[41] = array[39];
				}
				array[60] = (array2[8][2] >> 4 & (int)BinaryDefine.b00001111);
				if (array[60] > 8 || array[60] < 1)
				{
					array[60] = 4;
				}
				if (num == 1 && num4 == 0)
				{
					array[1] = 0;
				}
				else if (num == 1 && num4 == 1)
				{
					array[1] = 1;
				}
				else if (num == 0)
				{
					array[1] = 2;
				}
				if (num12 == 0)
				{
					array[25] = 1;
				}
				else if (num15 == 0)
				{
					array[25] = 2;
				}
				else if (num14 == 0)
				{
					array[25] = 3;
				}
				else
				{
					array[25] = 0;
				}
				if (!flag4)
				{
					array[26] = 1;
				}
				else if (num17 == 0)
				{
					array[26] = 2;
				}
				else if (num16 == 0)
				{
					array[26] = 3;
				}
				else
				{
					array[26] = 0;
				}
				if (num3 == 0)
				{
					array[27] = 0;
				}
				else if (num13 == 0)
				{
					array[27] = 2;
				}
				else
				{
					array[27] = 1;
				}
				if (!flag2)
				{
					if (num2 == 1)
					{
						array[28] = 1;
					}
					else
					{
						array[28] = 0;
					}
				}
				else
				{
					array[28] = 2;
				}
				if (num9 == 1)
				{
					array[38] = 0;
				}
				else if (num11 == 1)
				{
					array[38] = 2;
				}
				else
				{
					array[38] = 1;
				}
				if (num10 == 0)
				{
					if (num6 == 1)
					{
						array[52] = 1;
					}
					else
					{
						array[52] = 2;
					}
				}
				else
				{
					array[52] = 0;
				}
				array[54] = num8;
				array[80] = (int)nvData[256];
				return array;
			}

			// Token: 0x0600030A RID: 778 RVA: 0x00046FD4 File Offset: 0x000451D4
			public byte[] GetNVDataFromUserSetting(int[] userSettingR7, byte[] receivedNVData)
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
				byte b;
				byte b2;
				if (userSettingR7[1] == 2)
				{
					b = 0;
					b2 = 0;
				}
				else if (userSettingR7[1] == 1)
				{
					b = 1;
					b2 = 1;
				}
				else
				{
					if (userSettingR7[1] != 0)
					{
						return null;
					}
					b = 1;
					b2 = 0;
				}
				byte b3;
				byte b4;
				byte b5;
				if (userSettingR7[25] == 3)
				{
					b3 = 1;
					b4 = 1;
					b5 = 0;
				}
				else if (userSettingR7[25] == 2)
				{
					b3 = 1;
					b4 = 0;
					b5 = 1;
				}
				else if (userSettingR7[25] == 1)
				{
					b3 = 0;
					b4 = 1;
					b5 = 1;
				}
				else
				{
					if (userSettingR7[25] != 0)
					{
						return null;
					}
					b3 = 1;
					b4 = 1;
					b5 = 1;
				}
				byte b6;
				byte b7;
				byte b8;
				if (userSettingR7[26] == 3)
				{
					b6 = 1;
					b7 = 1;
					b8 = 0;
				}
				else if (userSettingR7[26] == 2)
				{
					b6 = 1;
					b7 = 0;
					b8 = 1;
				}
				else if (userSettingR7[26] == 1)
				{
					b6 = 0;
					b7 = 1;
					b8 = 1;
				}
				else
				{
					if (userSettingR7[26] != 0)
					{
						return null;
					}
					b6 = 1;
					b7 = 1;
					b8 = 1;
				}
				byte b9;
				byte b10;
				if (userSettingR7[27] == 2)
				{
					b9 = 1;
					b10 = 0;
				}
				else if (userSettingR7[27] == 1)
				{
					b9 = 1;
					b10 = 1;
				}
				else
				{
					if (userSettingR7[27] != 0)
					{
						return null;
					}
					b9 = 0;
					b10 = 1;
				}
				byte b11;
				byte b12;
				if (userSettingR7[28] == 2)
				{
					b11 = 0;
					b12 = 1;
				}
				else if (userSettingR7[28] == 1)
				{
					b11 = 1;
					b12 = 0;
				}
				else
				{
					if (userSettingR7[28] != 0)
					{
						return null;
					}
					b11 = 0;
					b12 = 0;
				}
				byte b13;
				byte b14;
				if (userSettingR7[38] == 2)
				{
					b13 = 0;
					b14 = 1;
				}
				else if (userSettingR7[38] == 1)
				{
					b13 = 0;
					b14 = 0;
				}
				else
				{
					if (userSettingR7[38] != 0)
					{
						return null;
					}
					b13 = 1;
					b14 = 0;
				}
				byte b15;
				byte b16;
				if (userSettingR7[52] == 2)
				{
					b15 = 0;
					b16 = 0;
				}
				else if (userSettingR7[52] == 1)
				{
					b15 = 0;
					b16 = 1;
				}
				else
				{
					if (userSettingR7[52] != 0)
					{
						return null;
					}
					b15 = 1;
					b16 = 1;
				}
				byte b17;
				if (userSettingR7[56] == 1)
				{
					if (userSettingR7[71] > 50)
					{
						b17 = 0;
					}
					else
					{
						b17 = 1;
					}
				}
				else
				{
					if (userSettingR7[56] != 0)
					{
						return null;
					}
					if (userSettingR7[71] > 80)
					{
						b17 = 0;
					}
					else
					{
						b17 = 1;
					}
				}
				byte b18 = (byte)userSettingR7[54];
				byte[] array3 = array[2];
				int num = 3;
				array3[num] |= (byte)((int)b << 6 & (int)BinaryDefine.b01000000);
				byte[] array4 = array[2];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR7[42] << 5 & (int)BinaryDefine.b00100000);
				byte[] array5 = array[2];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR7[43] << 2 & (int)BinaryDefine.b00011100);
				byte[] array6 = array[2];
				int num4 = 3;
				array6[num4] |= (byte)((int)b11 << 1 & (int)BinaryDefine.b00000010);
				byte[] array7 = array[2];
				int num5 = 3;
				array7[num5] |= (byte)(userSettingR7[24] & (int)BinaryDefine.b00000001);
				byte[] array8 = array[2];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR7[23] << 7 & (int)BinaryDefine.b10000000);
				byte[] array9 = array[2];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR7[12] << 6 & (int)BinaryDefine.b01000000);
				byte[] array10 = array[2];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR7[14] << 5 & (int)BinaryDefine.b00100000);
				byte[] array11 = array[2];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR7[15] << 4 & (int)BinaryDefine.b00010000);
				byte[] array12 = array[2];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR7[16] << 3 & (int)BinaryDefine.b00001000);
				byte[] array13 = array[2];
				int num11 = 2;
				array13[num11] |= (byte)(userSettingR7[17] << 2 & (int)BinaryDefine.b00000100);
				byte[] array14 = array[2];
				int num12 = 2;
				array14[num12] |= (byte)(userSettingR7[21] << 1 & (int)BinaryDefine.b00000010);
				byte[] array15 = array[2];
				int num13 = 2;
				array15[num13] |= (byte)(userSettingR7[22] & (int)BinaryDefine.b00000001);
				byte[] array16 = array[2];
				int num14 = 1;
				array16[num14] |= (byte)(userSettingR7[6] << 7 & (int)BinaryDefine.b10000000);
				byte[] array17 = array[2];
				int num15 = 1;
				array17[num15] |= (byte)(userSettingR7[65] << 3 & (int)BinaryDefine.b00001000);
				byte[] array18 = array[2];
				int num16 = 1;
				array18[num16] |= (byte)(userSettingR7[77] << 1 & (int)BinaryDefine.b00000010);
				byte[] array19 = array[2];
				int num17 = 1;
				array19[num17] |= (byte)(userSettingR7[79] & (int)BinaryDefine.b00000001);
				byte[] array20 = array[2];
				int num18 = 0;
				array20[num18] |= (byte)((int)b9 << 7 & (int)BinaryDefine.b10000000);
				byte[] array21 = array[2];
				int num19 = 0;
				array21[num19] |= (byte)(userSettingR7[81] << 4 & (int)BinaryDefine.b01110000);
				byte[] array22 = array[2];
				int num20 = 0;
				array22[num20] |= (byte)((int)b2 << 3 & (int)BinaryDefine.b00001000);
				if (userSettingR7[82] >= 8)
				{
					byte[] array23 = array[2];
					int num21 = 0;
					array23[num21] |= BinaryDefine.b00000110;
				}
				else
				{
					byte[] array24 = array[2];
					int num22 = 0;
					array24[num22] |= (byte)(userSettingR7[82] & (int)BinaryDefine.b00000111);
				}
				byte b19;
				if (b17 == 1)
				{
					if (userSettingR7[56] == 1)
					{
						b19 = (byte)(userSettingR7[71] / 5);
					}
					else
					{
						b19 = (byte)(userSettingR7[71] / 10);
					}
				}
				else if (userSettingR7[56] == 1)
				{
					b19 = (byte)((userSettingR7[71] - 55) / 5);
				}
				else
				{
					b19 = (byte)((userSettingR7[71] - 90) / 10);
				}
				byte[] array25 = array[1];
				int num23 = 2;
				array25[num23] |= (byte)(userSettingR7[56] << 7 & (int)BinaryDefine.b10000000);
				byte[] array26 = array[1];
				int num24 = 2;
				array26[num24] |= (byte)((int)b16 << 6 & (int)BinaryDefine.b01000000);
				byte[] array27 = array[1];
				int num25 = 2;
				array27[num25] |= (byte)(userSettingR7[76] << 5 & (int)BinaryDefine.b00100000);
				byte[] array28 = array[1];
				int num26 = 2;
				array28[num26] |= (byte)(userSettingR7[78] << 4 & (int)BinaryDefine.b00010000);
				byte[] array29 = array[1];
				int num27 = 2;
				array29[num27] |= unchecked((byte)(b19 & BinaryDefine.b00001111));
				if (userSettingR7[56] == 1)
				{
					b19 = (byte)(userSettingR7[10] / 5);
				}
				else
				{
					b19 = (byte)(userSettingR7[10] / 10);
				}
				byte[] array30 = array[1];
				int num28 = 3;
				array30[num28] |= (byte)((int)b17 << 6 & (int)BinaryDefine.b01000000);
				byte[] array31 = array[1];
				int num29 = 3;
				array31[num29] |= (byte)(userSettingR7[19] << 5 & (int)BinaryDefine.b00100000);
				byte[] array32 = array[1];
				int num30 = 3;
				array32[num30] |= unchecked((byte)(b19 & BinaryDefine.b00011111));
				if (userSettingR7[56] == 1)
				{
					b19 = (byte)(userSettingR7[74] / 5);
				}
				else
				{
					b19 = (byte)(userSettingR7[74] / 10);
				}
				byte[] array33 = array[1];
				int num31 = 1;
				array33[num31] |= (byte)(userSettingR7[7] << 6 & (int)BinaryDefine.b01000000);
				byte[] array34 = array[1];
				int num32 = 1;
				array34[num32] |= (byte)(userSettingR7[9] << 5 & (int)BinaryDefine.b00100000);
				byte[] array35 = array[1];
				int num33 = 1;
				array35[num33] |= unchecked((byte)(b19 & BinaryDefine.b00011111));
				b19 = (byte)(userSettingR7[75] + 12);
				byte[] array36 = array[1];
				int num34 = 0;
				array36[num34] |= (byte)((int)b18 << 5 & (int)BinaryDefine.b11100000);
				byte[] array37 = array[1];
				int num35 = 0;
				array37[num35] |= unchecked((byte)(b19 & BinaryDefine.b00011111));
				byte[] array38 = array[3];
				int num36 = 3;
				array38[num36] |= (byte)(userSettingR7[39] << 6 & (int)BinaryDefine.b01000000);
				byte[] array39 = array[3];
				int num37 = 3;
				array39[num37] |= (byte)(userSettingR7[13] << 5 & (int)BinaryDefine.b00100000);
				byte[] array40 = array[3];
				int num38 = 3;
				array40[num38] |= (byte)((int)b12 << 4 & (int)BinaryDefine.b00010000);
				byte[] array41 = array[3];
				int num39 = 3;
				array41[num39] |= (byte)((int)b13 << 3 & (int)BinaryDefine.b00001000);
				byte[] array42 = array[3];
				int num40 = 3;
				array42[num40] |= (byte)(userSettingR7[66] & (int)BinaryDefine.b00000111);
				byte[] array43 = array[3];
				int num41 = 2;
				array43[num41] |= (byte)(userSettingR7[20] << 7 & (int)BinaryDefine.b10000000);
				byte[] array44 = array[3];
				int num42 = 2;
				array44[num42] |= (byte)((int)b15 << 6 & (int)BinaryDefine.b01000000);
				byte[] array45 = array[3];
				int num43 = 2;
				array45[num43] |= (byte)(userSettingR7[2] << 3 & (int)BinaryDefine.b00111000);
				byte[] array46 = array[3];
				int num44 = 2;
				array46[num44] |= (byte)(userSettingR7[3] & (int)BinaryDefine.b00000111);
				byte[] array47 = array[3];
				int num45 = 1;
				array47[num45] |= (byte)((int)b14 << 7 & (int)BinaryDefine.b10000000);
				byte[] array48 = array[3];
				int num46 = 1;
				array48[num46] |= (byte)((int)b3 << 6 & (int)BinaryDefine.b01000000);
				byte[] array49 = array[3];
				int num47 = 1;
				array49[num47] |= (byte)(userSettingR7[55] << 5 & (int)BinaryDefine.b00100000);
				byte[] array50 = array[3];
				int num48 = 1;
				array50[num48] |= (byte)(userSettingR7[37] << 3 & (int)BinaryDefine.b00001000);
				byte[] array51 = array[3];
				int num49 = 1;
				array51[num49] |= (byte)(userSettingR7[4] & (int)BinaryDefine.b00000111);
				byte[] array52 = array[3];
				int num50 = 0;
				array52[num50] |= (byte)(userSettingR7[36] << 7 & (int)BinaryDefine.b10000000);
				byte[] array53 = array[3];
				int num51 = 0;
				array53[num51] |= (byte)(userSettingR7[35] << 6 & (int)BinaryDefine.b01000000);
				byte[] array54 = array[3];
				int num52 = 0;
				array54[num52] |= (byte)(userSettingR7[34] << 5 & (int)BinaryDefine.b00100000);
				byte[] array55 = array[3];
				int num53 = 0;
				array55[num53] |= (byte)(userSettingR7[33] << 4 & (int)BinaryDefine.b00010000);
				byte[] array56 = array[3];
				int num54 = 0;
				array56[num54] |= (byte)(userSettingR7[32] << 3 & (int)BinaryDefine.b00001000);
				byte[] array57 = array[3];
				int num55 = 0;
				array57[num55] |= (byte)(userSettingR7[31] << 2 & (int)BinaryDefine.b00000100);
				byte[] array58 = array[3];
				int num56 = 0;
				array58[num56] |= (byte)(userSettingR7[30] << 1 & (int)BinaryDefine.b00000010);
				byte[] array59 = array[3];
				int num57 = 0;
				array59[num57] |= (byte)(userSettingR7[29] & (int)BinaryDefine.b00000001);
				byte[] array60 = array[4];
				int num58 = 3;
				array60[num58] |= (byte)(userSettingR7[69] << 3 & (int)BinaryDefine.b00111000);
				byte[] array61 = array[4];
				int num59 = 3;
				array61[num59] |= (byte)(userSettingR7[70] & (int)BinaryDefine.b00000111);
				byte[] array62 = array[4];
				int num60 = 2;
				array62[num60] |= (byte)(userSettingR7[57] << 4 & (int)BinaryDefine.b11110000);
				byte[] array63 = array[4];
				int num61 = 2;
				array63[num61] |= (byte)(userSettingR7[58] & (int)BinaryDefine.b00001111);
				byte[] array64 = array[4];
				int num62 = 1;
				array64[num62] |= (byte)(userSettingR7[64] << 4 & (int)BinaryDefine.b11110000);
				byte[] array65 = array[4];
				int num63 = 1;
				array65[num63] |= (byte)(userSettingR7[62] & (int)BinaryDefine.b00001111);
				byte[] array66 = array[5];
				int num64 = 3;
				array66[num64] |= (byte)(userSettingR7[63] << 4 & (int)BinaryDefine.b01110000);
				byte[] array67 = array[5];
				int num65 = 3;
				array67[num65] |= (byte)(userSettingR7[61] & (int)BinaryDefine.b00001111);
				byte[] array68 = array[5];
				int num66 = 2;
				array68[num66] |= (byte)(userSettingR7[18] << 7 & (int)BinaryDefine.b10000000);
				byte[] array69 = array[5];
				int num67 = 2;
				array69[num67] |= (byte)(userSettingR7[40] << 6 & (int)BinaryDefine.b01000000);
				byte[] array70 = array[5];
				int num68 = 2;
				array70[num68] |= (byte)((int)b10 << 5 & (int)BinaryDefine.b00100000);
				byte[] array71 = array[5];
				int num69 = 2;
				array71[num69] |= (byte)(userSettingR7[68] & (int)BinaryDefine.b00000111);
				if (userSettingR7[82] >= 8)
				{
					byte[] array72 = array[5];
					int num70 = 1;
					array72[num70] &= BinaryDefine.b01111111;
				}
				else
				{
					byte[] array73 = array[5];
					int num71 = 1;
					array73[num71] |= BinaryDefine.b10000000;
				}
				byte[] array74 = array[5];
				int num72 = 1;
				array74[num72] |= (byte)(userSettingR7[45] << 3 & (int)BinaryDefine.b00111000);
				byte[] array75 = array[5];
				int num73 = 1;
				array75[num73] |= (byte)(userSettingR7[44] & (int)BinaryDefine.b00000111);
				byte[] array76 = array[5];
				int num74 = 0;
				array76[num74] |= (byte)(userSettingR7[0] << 7 & (int)BinaryDefine.b10000000);
				byte[] array77 = array[5];
				int num75 = 0;
				array77[num75] |= (byte)(userSettingR7[72] << 6 & (int)BinaryDefine.b01000000);
				byte[] array78 = array[5];
				int num76 = 0;
				array78[num76] |= (byte)(userSettingR7[47] << 3 & (int)BinaryDefine.b00111000);
				byte[] array79 = array[5];
				int num77 = 0;
				array79[num77] |= (byte)(userSettingR7[46] & (int)BinaryDefine.b00000111);
				byte[] array80 = array[6];
				int num78 = 3;
				array80[num78] |= (byte)(userSettingR7[49] << 4 & (int)BinaryDefine.b11110000);
				byte[] array81 = array[6];
				int num79 = 3;
				array81[num79] |= (byte)(userSettingR7[48] & (int)BinaryDefine.b00001111);
				byte[] array82 = array[6];
				int num80 = 2;
				array82[num80] |= (byte)(userSettingR7[51] << 4 & (int)BinaryDefine.b11110000);
				byte[] array83 = array[6];
				int num81 = 2;
				array83[num81] |= (byte)(userSettingR7[50] & (int)BinaryDefine.b00001111);
				byte[] array84 = array[6];
				int num82 = 1;
				array84[num82] |= (byte)((int)b5 << 7 & (int)BinaryDefine.b10000000);
				byte[] array85 = array[6];
				int num83 = 1;
				array85[num83] |= (byte)((int)b4 << 6 & (int)BinaryDefine.b01000000);
				byte[] array86 = array[6];
				int num84 = 1;
				array86[num84] |= (byte)(userSettingR7[53] << 4 & (int)BinaryDefine.b00010000);
				byte[] array87 = array[6];
				int num85 = 1;
				array87[num85] |= (byte)(userSettingR7[5] & (int)BinaryDefine.b00001111);
				byte[] array88 = array[6];
				int num86 = 0;
				array88[num86] |= (byte)(userSettingR7[8] << 5 & (int)BinaryDefine.b11100000);
				byte[] array89 = array[6];
				int num87 = 0;
				array89[num87] |= (byte)(userSettingR7[73] << 1 & (int)BinaryDefine.b00011110);
				byte[] array90 = array[6];
				int num88 = 0;
				array90[num88] |= (byte)(userSettingR7[67] & (int)BinaryDefine.b00000001);
				byte[] array91 = array[7];
				int num89 = 3;
				array91[num89] |= (byte)(userSettingR7[59] << 4 & (int)BinaryDefine.b01110000);
				byte[] array92 = array[7];
				int num90 = 3;
				array92[num90] |= (byte)(userSettingR7[11] << 3 & (int)BinaryDefine.b00001000);
				byte[] array93 = array[7];
				int num91 = 3;
				array93[num91] |= (byte)((int)b6 << 2 & (int)BinaryDefine.b00000100);
				byte[] array94 = array[7];
				int num92 = 3;
				array94[num92] |= (byte)((int)b8 << 1 & (int)BinaryDefine.b00000010);
				byte[] array95 = array[7];
				int num93 = 3;
				array95[num93] |= unchecked((byte)(b7 & BinaryDefine.b00000001));
				byte[] array96 = array[7];
				int num94 = 1;
				array96[num94] |= (byte)(userSettingR7[41] & (int)BinaryDefine.b00000011);
				byte[] array97 = array[8];
				int num95 = 2;
				array97[num95] |= (byte)(userSettingR7[60] << 4 & (int)BinaryDefine.b11110000);
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
				array2[256] = (byte)userSettingR7[80];
				int num98 = 0;
				for (int i = 0; i < receivedNVData.Length; i++)
				{
					if (receivedNVData[i] == array2[i])
					{
						num98++;
					}
				}
				return array2;
			}

			// Token: 0x0400061B RID: 1563
			private int supportVersion = 143;

			// Token: 0x0400061C RID: 1564
			private int menuCnt = 83;

			// Token: 0x0400061D RID: 1565
			private byte[] userNVDataPos = new byte[]
			{
				0,
				0,
				0,
				0,
				byte.MaxValue,
				127,
				byte.MaxValue,
				127,
				byte.MaxValue,
				139,
				byte.MaxValue,
				127,
				byte.MaxValue,
				239,
				byte.MaxValue,
				127,
				0,
				byte.MaxValue,
				byte.MaxValue,
				63,
				byte.MaxValue,
				191,
				231,
				127,
				byte.MaxValue,
				223,
				byte.MaxValue,
				byte.MaxValue,
				0,
				3,
				0,
				127,
				0,
				0,
				240,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
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

			// Token: 0x0400061E RID: 1566
			private const int memoryQuotaPos = 256;

			// Token: 0x0400061F RID: 1567
			private const int HEADER = 0;

			// Token: 0x04000620 RID: 1568
			private const int GPS = 1;

			// Token: 0x04000621 RID: 1569
			private const int RD_1 = 2;

			// Token: 0x04000622 RID: 1570
			private const int RD_2 = 3;

			// Token: 0x04000623 RID: 1571
			private const int RD_3 = 4;

			// Token: 0x04000624 RID: 1572
			private const int RD_4 = 5;

			// Token: 0x04000625 RID: 1573
			private const int RD_5 = 6;

			// Token: 0x04000626 RID: 1574
			private const int RD_6 = 7;

			// Token: 0x04000627 RID: 1575
			private const int RD_7 = 8;

			// Token: 0x04000628 RID: 1576
			private const int ADDR_CNT = 9;

			// Token: 0x020000BB RID: 187
			private enum MENU
			{
				// Token: 0x04000A72 RID: 2674
				MENU_MODE,
				// Token: 0x04000A73 RID: 2675
				DETECTION_MODE,
				// Token: 0x04000A74 RID: 2676
				X_SENSITIVE,
				// Token: 0x04000A75 RID: 2677
				K_SENSITIVE,
				// Token: 0x04000A76 RID: 2678
				KA_SENSITIVE,
				// Token: 0x04000A77 RID: 2679
				REAR_ATTENUATION,
				// Token: 0x04000A78 RID: 2680
				GPS_ENABLE,
				// Token: 0x04000A79 RID: 2681
				SPEED_CAMERA_ENABLE,
				// Token: 0x04000A7A RID: 2682
				SPEED_CAMERA_ALERT_RANGE,
				// Token: 0x04000A7B RID: 2683
				RLC_ENABLE,
				// Token: 0x04000A7C RID: 2684
				RLC_QRIDE,
				// Token: 0x04000A7D RID: 2685
				POI_PASSCHIME,
				// Token: 0x04000A7E RID: 2686
				VOICE_ENABLE,
				// Token: 0x04000A7F RID: 2687
				KA_FREQ_VOICE,
				// Token: 0x04000A80 RID: 2688
				X_BAND_ENABLE,
				// Token: 0x04000A81 RID: 2689
				K_BAND_ENABLE,
				// Token: 0x04000A82 RID: 2690
				KA_BAND_ENABLE,
				// Token: 0x04000A83 RID: 2691
				LASER_ENABLE,
				// Token: 0x04000A84 RID: 2692
				LASER_GUN_ID_ENABLE,
				// Token: 0x04000A85 RID: 2693
				K_POP_ENABLE,
				// Token: 0x04000A86 RID: 2694
				MRCD_ENABLE,
				// Token: 0x04000A87 RID: 2695
				KA_POP_ENABLE,
				// Token: 0x04000A88 RID: 2696
				K_FILTER_ENABLE,
				// Token: 0x04000A89 RID: 2697
				KA_FILTER_ENABLE,
				// Token: 0x04000A8A RID: 2698
				TSF_ENABLE,
				// Token: 0x04000A8B RID: 2699
				K_BLOCK_FILTER_1_MODE,
				// Token: 0x04000A8C RID: 2700
				K_BLOCK_FILTER_2_MODE,
				// Token: 0x04000A8D RID: 2701
				K_NARROW,
				// Token: 0x04000A8E RID: 2702
				KA_NARROW,
				// Token: 0x04000A8F RID: 2703
				KA_SEG1,
				// Token: 0x04000A90 RID: 2704
				KA_SEG2,
				// Token: 0x04000A91 RID: 2705
				KA_SEG3,
				// Token: 0x04000A92 RID: 2706
				KA_SEG4,
				// Token: 0x04000A93 RID: 2707
				KA_SEG5,
				// Token: 0x04000A94 RID: 2708
				KA_SEG6,
				// Token: 0x04000A95 RID: 2709
				KA_SEG7,
				// Token: 0x04000A96 RID: 2710
				KA_SEG8,
				// Token: 0x04000A97 RID: 2711
				KA_SEG9,
				// Token: 0x04000A98 RID: 2712
				PRIORITY_MODE,
				// Token: 0x04000A99 RID: 2713
				MUTE_MEM_BAND_OPTION,
				// Token: 0x04000A9A RID: 2714
				AUTO_MUTE_MEM_ENABLE,
				// Token: 0x04000A9B RID: 2715
				AUTO_MUTE_MEM_BAND_OPTION,
				// Token: 0x04000A9C RID: 2716
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x04000A9D RID: 2717
				BACKGROUND_COLOR,
				// Token: 0x04000A9E RID: 2718
				X_BAND_ARROW_COLOR,
				// Token: 0x04000A9F RID: 2719
				K_BAND_ARROW_COLOR,
				// Token: 0x04000AA0 RID: 2720
				MRCD_ARROW_COLOR,
				// Token: 0x04000AA1 RID: 2721
				KA_BAND_ARROW_COLOR,
				// Token: 0x04000AA2 RID: 2722
				X_BAND_COLOR,
				// Token: 0x04000AA3 RID: 2723
				K_BAND_COLOR,
				// Token: 0x04000AA4 RID: 2724
				MRCD_COLOR,
				// Token: 0x04000AA5 RID: 2725
				KA_BAND_COLOR,
				// Token: 0x04000AA6 RID: 2726
				MAIN_DISPLAY,
				// Token: 0x04000AA7 RID: 2727
				HEARTBEAT_ICON_ENABLE,
				// Token: 0x04000AA8 RID: 2728
				LEFT_DISPLAY,
				// Token: 0x04000AA9 RID: 2729
				ALERT_DISPLAY,
				// Token: 0x04000AAA RID: 2730
				SPEED_UNIT,
				// Token: 0x04000AAB RID: 2731
				X_BAND_ALERT_TONE,
				// Token: 0x04000AAC RID: 2732
				K_BAND_ALERT_TONE,
				// Token: 0x04000AAD RID: 2733
				K_BAND_BOGEY_TONE,
				// Token: 0x04000AAE RID: 2734
				K_BAND_BOGEY_LEVEL,
				// Token: 0x04000AAF RID: 2735
				MRCD_ALERT_TONE,
				// Token: 0x04000AB0 RID: 2736
				KA_BAND_ALERT_TONE,
				// Token: 0x04000AB1 RID: 2737
				KA_BAND_BOGEY_TONE,
				// Token: 0x04000AB2 RID: 2738
				LASER_ALERT_TONE,
				// Token: 0x04000AB3 RID: 2739
				AUTO_MUTE_ENABLE,
				// Token: 0x04000AB4 RID: 2740
				AUTO_MUTE_VOLUME,
				// Token: 0x04000AB5 RID: 2741
				REAR_K_BAND_MUTE_ENABLE,
				// Token: 0x04000AB6 RID: 2742
				DARK_MODE_BRIGHTNESS,
				// Token: 0x04000AB7 RID: 2743
				AUTO_DIM_SET_BRIGHT_BRIGHTNESS,
				// Token: 0x04000AB8 RID: 2744
				AUTO_DIM_SET_DIM_BRIGHTNESS,
				// Token: 0x04000AB9 RID: 2745
				QRIDE_MODE,
				// Token: 0x04000ABA RID: 2746
				MRCD_QRIDE_ENABLE,
				// Token: 0x04000ABB RID: 2747
				QRIDE_VOLUME,
				// Token: 0x04000ABC RID: 2748
				LIMIT_SPEED_MODE,
				// Token: 0x04000ABD RID: 2749
				GMT,
				// Token: 0x04000ABE RID: 2750
				DST_ENABLE,
				// Token: 0x04000ABF RID: 2751
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x04000AC0 RID: 2752
				VEHICLE_BATT_SAVER_ENABLE,
				// Token: 0x04000AC1 RID: 2753
				SELF_TEST_ENABLE,
				// Token: 0x04000AC2 RID: 2754
				MEMORY_QUOTA,
				// Token: 0x04000AC3 RID: 2755
				MAIN_DIM_SET,
				// Token: 0x04000AC4 RID: 2756
				MAIN_VOLUME
			}
		}
	}
}
