using System;
using System.Linq;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000023 RID: 35
	internal static class UserSettingR3
	{
		// Token: 0x04000331 RID: 817
		public static UserSettingFormat[] user_setting = new UserSettingFormat[]
		{
			new UserSettingR3.v161()
		};

		// Token: 0x02000088 RID: 136
		private class v161 : UserSettingFormat
		{
			// Token: 0x060002A1 RID: 673 RVA: 0x000266A7 File Offset: 0x000248A7
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x000266AF File Offset: 0x000248AF
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x000266B7 File Offset: 0x000248B7
			public byte[] GetNVDataMask()
			{
				return this.userNVDataPos;
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x00024E4C File Offset: 0x0002304C
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return false;
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_level(int strength, int mode)
			{
				return -1;
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_raw_strength(int level, int mode)
			{
				return -1;
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x000266C0 File Offset: 0x000248C0
			public UserSettingMenu[] GetMenuFormat()
			{
				UserSettingMenu[] array = new UserSettingMenu[this.menuCnt];
				if (array.Length == 0)
				{
					return null;
				}
				array[0] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Detection Mode", new int[]
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
				array[1] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "X Sensitive", new int[]
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
				array[2] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Sensitive", new int[]
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
				array[3] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Sensitive", new int[]
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
				array[4] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "GPS On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Determines your geographic location.");
				array[5] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "Speed Camera Off/On", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Notifies you if any speed cameras are nearby.");
				array[6] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_MATCHING_VALUE_MULTI_ITEM_ATT, "Speed Camera Alert Range", new int[][]
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
				array[7] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "Red Light Camera On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Notifies you if any red light cameras are nearby.");
				array[8] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Red Light Camera Quiet Ride", new int[][]
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
				array[9] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Voice On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns voice alert on or off under the following conditions:\nType of radar / laser Band alarms");
				array[10] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Frequency Voice", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Announces the detected Ka band frequency.");
				UserSettingMenu[] array2 = array;
				int num = 11;
				UserSettingMenu.MENU_TYPE menuType = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString = "X Band On/Off";
				int[] array3 = new int[2];
				array3[0] = 1;
				array2[num] = new UserSettingMenu(menuType, menuString, array3, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore X band frequencies.\nTurn on for X band sensitivity as follows:\nHighway: Full sensitivity\nCity: X band sensitivity reduced");
				array[12] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore K band frequencies.");
				array[13] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore Ka band frequencies.");
				array[14] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore lasers.");
				UserSettingMenu[] array4 = array;
				int num2 = 15;
				UserSettingMenu.MENU_TYPE menuType2 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString2 = "K POP On/Off";
				int[] array5 = new int[2];
				array5[0] = 1;
				array4[num2] = new UserSettingMenu(menuType2, menuString2, array5, new string[]
				{
					"Off",
					"On"
				}, "Detects K POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[16] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "MRCD On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates MultaRadar CD/CT low - powered radar gun detection.");
				array[17] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Gatso RT3/4 On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates detection for Gatso radar guns.");
				UserSettingMenu[] array6 = array;
				int num3 = 18;
				UserSettingMenu.MENU_TYPE menuType3 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString3 = "Ka POP On/Off";
				int[] array7 = new int[2];
				array7[0] = 1;
				array6[num3] = new UserSettingMenu(menuType3, menuString3, array7, new string[]
				{
					"Off",
					"On"
				}, "Detects Ka POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[19] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Filter", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the K band to prevent false detections.");
				UserSettingMenu[] array8 = array;
				int num4 = 20;
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
				int num5 = 21;
				UserSettingMenu.MENU_TYPE menuType5 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString5 = "TSF";
				int[] array11 = new int[2];
				array11[0] = 1;
				array10[num5] = new UserSettingMenu(menuType5, menuString5, array11, new string[]
				{
					"Off",
					"On"
				}, "Traffic Sensor Filter. Prevents false alarms caused by traffic monitoring radar systems.");
				array[22] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter 24.199Ghz (± 0.005)", new int[]
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
				array[23] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter 24.168Ghz (± 0.002)", new int[]
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
				array[24] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block3 Filter 24.123Ghz ~ 24.124Ghz", new int[]
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
				}, "Keep K Block3 Filter ON to block K band monitor systems in the 24.123Ghz ~ 24.124Ghz range");
				array[25] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Narrow/Wide/Extended", new int[]
				{
					0,
					1,
					2
				}, new string[]
				{
					"Narrow",
					"Wide",
					"Extended"
				}, "K Narrow scans a narrower frequency range than K Wide.\nK Extended increases the frequency scanning range for K band radar guns.\n(K Extended is only valid if the H/W Revision:2)");
				array[26] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Narrow/Wide/Segmentation", new int[]
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
				UserSettingMenu[] array12 = array;
				int num6 = 27;
				UserSettingMenu.MENU_TYPE menuType6 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString6 = "Ka Segmentation 1";
				int[] array13 = new int[2];
				array13[0] = 1;
				array12[num6] = new UserSettingMenu(menuType6, menuString6, array13, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.399Ghz – 33.705Ghz\n(Ka Segmentation mode)");
				UserSettingMenu[] array14 = array;
				int num7 = 28;
				UserSettingMenu.MENU_TYPE menuType7 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString7 = "Ka Segmentation 2";
				int[] array15 = new int[2];
				array15[0] = 1;
				array14[num7] = new UserSettingMenu(menuType7, menuString7, array15, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.705Ghz – 33.903Ghz\n(Ka Segmentation mode)");
				UserSettingMenu[] array16 = array;
				int num8 = 29;
				UserSettingMenu.MENU_TYPE menuType8 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString8 = "Ka Segmentation 3";
				int[] array17 = new int[2];
				array17[0] = 1;
				array16[num8] = new UserSettingMenu(menuType8, menuString8, array17, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 33.903Ghz – 34.191Ghz\n(Ka Segmentation mode)");
				UserSettingMenu[] array18 = array;
				int num9 = 30;
				UserSettingMenu.MENU_TYPE menuType9 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString9 = "Ka Segmentation 4";
				int[] array19 = new int[2];
				array19[0] = 1;
				array18[num9] = new UserSettingMenu(menuType9, menuString9, array19, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.191Ghz – 34.587Ghz\n(Ka Segmentation mode)");
				UserSettingMenu[] array20 = array;
				int num10 = 31;
				UserSettingMenu.MENU_TYPE menuType10 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString10 = "Ka Segmentation 5";
				int[] array21 = new int[2];
				array21[0] = 1;
				array20[num10] = new UserSettingMenu(menuType10, menuString10, array21, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.587Ghz – 34.803Ghz\n(Ka Segmentation mode)");
				UserSettingMenu[] array22 = array;
				int num11 = 32;
				UserSettingMenu.MENU_TYPE menuType11 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString11 = "Ka Segmentation 6";
				int[] array23 = new int[2];
				array23[0] = 1;
				array22[num11] = new UserSettingMenu(menuType11, menuString11, array23, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 34.803Ghz – 35.163Ghz\n(Ka Segmentation mode)");
				UserSettingMenu[] array24 = array;
				int num12 = 33;
				UserSettingMenu.MENU_TYPE menuType12 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString12 = "Ka Segmentation 7";
				int[] array25 = new int[2];
				array25[0] = 1;
				array24[num12] = new UserSettingMenu(menuType12, menuString12, array25, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.163Ghz – 35.379Ghz\n(Ka Segmentation mode)");
				UserSettingMenu[] array26 = array;
				int num13 = 34;
				UserSettingMenu.MENU_TYPE menuType13 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString13 = "Ka Segmentation 8";
				int[] array27 = new int[2];
				array27[0] = 1;
				array26[num13] = new UserSettingMenu(menuType13, menuString13, array27, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.379Ghz – 35.613Ghz\n(Ka Segmentation mode)");
				UserSettingMenu[] array28 = array;
				int num14 = 35;
				UserSettingMenu.MENU_TYPE menuType14 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString14 = "Ka Segmentation 9";
				int[] array29 = new int[2];
				array29[0] = 1;
				array28[num14] = new UserSettingMenu(menuType14, menuString14, array29, new string[]
				{
					"Off",
					"On"
				}, "H/W Revision:0,1 - Ka band sweep 35.613Ghz – 35.829Ghz\nH/W Revision:2 - Ka band sweep 35.613Ghz – 35.701Ghz\n(Ka Segmentation mode)");
				UserSettingMenu[] array30 = array;
				int num15 = 36;
				UserSettingMenu.MENU_TYPE menuType15 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString15 = "Ka Segmentation 10";
				int[] array31 = new int[2];
				array31[0] = 1;
				array30[num15] = new UserSettingMenu(menuType15, menuString15, array31, new string[]
				{
					"Off",
					"On"
				}, "H/W Revision:0,1 - Ka band sweep 35.829Ghz – 36.001Ghz\nH/W Revision:2 - Ka Segmentation10 does not exist\n(Ka Segmentation mode)");
				array[37] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Priority", new int[]
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
				array[38] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Select bands to be muted.");
				UserSettingMenu[] array32 = array;
				int num16 = 39;
				UserSettingMenu.MENU_TYPE menuType16 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString16 = "All Threat Display";
				int[] array33 = new int[2];
				array33[0] = 1;
				array32[num16] = new UserSettingMenu(menuType16, menuString16, array33, new string[]
				{
					"Off",
					"On"
				}, "Displays if more than one radar signals are detected at the same time. The signal with the strongest radar signal is considered the main signal. The other signals are displayed on the left side.");
				array[40] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Background Color", new int[]
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
					"Purple"
				}, "Select screen text color.");
				array[41] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Display", new int[]
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
				array[42] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Left Display", new int[]
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
				int num17 = 43;
				UserSettingMenu.MENU_TYPE menuType17 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString17 = "Speed Unit";
				int[] array35 = new int[2];
				array35[0] = 1;
				array34[num17] = new UserSettingMenu(menuType17, menuString17, array35, new string[]
				{
					"mph",
					"km/h"
				}, "Select the speed measurement type.");
				array[43].isUnitMenuFlag = true;
				array[44] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "X Band Alert Tone", new int[]
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
				array[45] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Alert Tone", new int[]
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
				array[46] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "MRCD Alert Tone", new int[]
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
				array[47] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "GATSO RT3/4 Alert Tone", new int[]
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
				array[48] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Alert Tone", new int[]
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
				array[49] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Bogey Tone", new int[]
				{
					1,
					2,
					3,
					4,
					5
				}, new string[]
				{
					"Tone 1",
					"Tone 2",
					"Tone 3",
					"Tone 4",
					"Tone 5"
				}, "Set a tone to indicate the detector is responding to a different Ka band signal.");
				array[50] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Laser Alert Tone", new int[]
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
				array[51] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Auto Mute reduces alarm level to 1 after 3 seconds and returns to normal operation(Auto Mute = OFF) 10 seconds after the alert ends.If the same alarm sounds within the 10 second period, Auto Mute remains at level 1.The unit returns to normal operation(Auto Mute = OFF) if a different band is detected during Auto Mute = ON mode.");
				array[52] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Volume", new int[]
				{
					0,
					1,
					2,
					3,
					4,
					5
				}, new string[]
				{
					"Volume 0",
					"Volume 1",
					"Volume 2",
					"Volume 3",
					"Volume 4",
					"Volume 5"
				}, "Sets a volume level for muted alarms.");
				array[53] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Dark mode Brightness", new int[]
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
				array[54] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Time", new int[]
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
				array[55] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Brightness", new int[]
				{
					4,
					3,
					2
				}, new string[]
				{
					"Bright",
					"Dim",
					"Dimmer"
				}, "The R3 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[56] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Time", new int[]
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
				array[57] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Brightness", new int[]
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
				}, "The R3 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[58] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Backlight On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns the front key backlight on and off.");
				array[59] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Quiet Ride", new int[][]
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
				UserSettingMenu[] array36 = array;
				int num18 = 60;
				UserSettingMenu.MENU_TYPE menuType18 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString18 = "Quiet Ride MRCD On/Off";
				int[] array37 = new int[2];
				array37[0] = 1;
				array36[num18] = new UserSettingMenu(menuType18, menuString18, array37, new string[]
				{
					"Off",
					"On"
				}, "Mutes MRCD alarms when users drive under the speed limit set previously.");
				array[61] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Limit Speed", new int[][]
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
				array[62] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "GMT", new int[]
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
				UserSettingMenu[] array38 = array;
				int num19 = 63;
				UserSettingMenu.MENU_TYPE menuType19 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString19 = "DST";
				int[] array39 = new int[2];
				array39[0] = 1;
				array38[num19] = new UserSettingMenu(menuType19, menuString19, array39, new string[]
				{
					"Off",
					"On"
				}, "Daylight Saving Time");
				UserSettingMenu[] array40 = array;
				int num20 = 64;
				UserSettingMenu.MENU_TYPE menuType20 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString20 = "Low Battery Warning";
				int[] array41 = new int[2];
				array41[0] = 1;
				array40[num20] = new UserSettingMenu(menuType20, menuString20, array41, new string[]
				{
					"Off",
					"On"
				}, "Sounds a warning tone if the vehicle battery power drops below 11V.");
				UserSettingMenu[] array42 = array;
				int num21 = 65;
				UserSettingMenu.MENU_TYPE menuType21 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString21 = "Vehicle Battery Saver";
				int[] array43 = new int[2];
				array43[0] = 1;
				array42[num21] = new UserSettingMenu(menuType21, menuString21, array43, new string[]
				{
					"Off",
					"On"
				}, "Turns off power to the R3 if the speed stays at 0 or if the GPS is not connected for more than an hour.");
				array[66] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Self Test", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Runs a self diagnostic test on the unit to check for faults.");
				array[67] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Dim", new int[]
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
				array[68] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Main Volume", new int[]
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
					"Volume 0",
					"Volume 1",
					"Volume 2",
					"Volume 3",
					"Volume 4",
					"Volume 5",
					"Volume 6"
				}, "Set a main volume");
				return array;
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x00027E84 File Offset: 0x00026084
			public int[] GetUserSettingFromNVData(byte[] nvData, ref int hwRevisionVersion)
			{
				int[] array = Enumerable.Repeat<int>(-1000, this.menuCnt).ToArray<int>();
				if (array.Length == 0)
				{
					return null;
				}
				byte[][] array2 = new byte[nvData.Length / 4][];
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = new byte[4];
					for (int j = 0; j < 4; j++)
					{
						array2[i][j] = nvData[i * 4 + j];
					}
				}
				byte b = array2[0][3];
				byte b2 = BinaryDefine.b00000001;
				int num = array2[0][3] >> 6 & (int)BinaryDefine.b00000001;
				array[39] = (array2[0][3] >> 5 & (int)BinaryDefine.b00000001);
				array[40] = (array2[0][3] >> 2 & (int)BinaryDefine.b00000111);
				int num2 = array2[0][3] >> 1 & (int)BinaryDefine.b00000001;
				array[21] = (int)(array2[0][3] & BinaryDefine.b00000001);
				if (array[40] > 7)
				{
					array[40] = 5;
				}
				array[20] = (array2[0][2] >> 7 & (int)BinaryDefine.b00000001);
				array[9] = (array2[0][2] >> 6 & (int)BinaryDefine.b00000001);
				array[11] = (array2[0][2] >> 5 & (int)BinaryDefine.b00000001);
				array[12] = (array2[0][2] >> 4 & (int)BinaryDefine.b00000001);
				array[13] = (array2[0][2] >> 3 & (int)BinaryDefine.b00000001);
				array[14] = (array2[0][2] >> 2 & (int)BinaryDefine.b00000001);
				array[18] = (array2[0][2] >> 1 & (int)BinaryDefine.b00000001);
				array[19] = (int)(array2[0][2] & BinaryDefine.b00000001);
				array[4] = (array2[0][1] >> 7 & (int)BinaryDefine.b00000001);
				byte b3 = array2[0][1];
				byte b4 = BinaryDefine.b00000111;
				array[51] = (array2[0][1] >> 3 & (int)BinaryDefine.b00000001);
				array[58] = (array2[0][1] >> 2 & (int)BinaryDefine.b00000001);
				array[64] = (array2[0][1] >> 1 & (int)BinaryDefine.b00000001);
				array[66] = (int)(array2[0][1] & BinaryDefine.b00000001);
				int num3 = array2[0][0] >> 7 & (int)BinaryDefine.b00000001;
				array[67] = (array2[0][0] >> 4 & (int)BinaryDefine.b00000111);
				int num4 = array2[0][0] >> 3 & (int)BinaryDefine.b00000001;
				array[68] = (int)(array2[0][0] & BinaryDefine.b00000111);
				if (array[67] > 5)
				{
					array[67] = 5;
				}
				if (array[68] > 6)
				{
					array[68] = 4;
				}
				array[43] = (array2[2][2] >> 7 & (int)BinaryDefine.b00000001);
				int num5 = array2[2][2] >> 6 & (int)BinaryDefine.b00000001;
				array[63] = (array2[2][2] >> 5 & (int)BinaryDefine.b00000001);
				array[65] = (array2[2][2] >> 4 & (int)BinaryDefine.b00000001);
				int num6 = (int)(array2[2][2] & BinaryDefine.b00001111);
				if (array[43] == 1)
				{
					if (num6 >= 0 && num6 <= 10)
					{
						array[59] = num6 * 5;
					}
					else
					{
						array[59] = 0;
					}
				}
				else if (num6 >= 0 && num6 <= 8)
				{
					array[59] = num6 * 10;
				}
				else
				{
					array[59] = 0;
				}
				bool flag = (array2[2][3] >> 6 & (int)BinaryDefine.b00000001) != 0;
				array[15] = (array2[2][3] >> 5 & (int)BinaryDefine.b00000001);
				num6 = (int)(array2[2][3] & BinaryDefine.b00011111);
				if (array[43] == 1)
				{
					if (num6 == 0 || (num6 >= 10 && num6 <= 17))
					{
						array[8] = num6 * 5;
					}
					else
					{
						array[8] = 0;
					}
				}
				else if (num6 == 0 || (num6 >= 8 && num6 <= 14))
				{
					array[8] = num6 * 10;
				}
				else
				{
					array[8] = 0;
				}
				if (!flag)
				{
					if (array[43] == 1)
					{
						array[59] += 55;
					}
					else
					{
						array[59] += 90;
					}
				}
				array[5] = (array2[2][1] >> 6 & (int)BinaryDefine.b00000001);
				array[7] = (array2[2][1] >> 5 & (int)BinaryDefine.b00000001);
				num6 = (int)(array2[2][1] & BinaryDefine.b00011111);
				if (array[43] == 1)
				{
					if (num6 == 0 || (num6 >= 10 && num6 <= 20))
					{
						array[61] = num6 * 5;
					}
					else
					{
						array[61] = 0;
					}
				}
				else if (num6 == 0 || (num6 >= 8 && num6 <= 16))
				{
					array[61] = num6 * 10;
				}
				else
				{
					array[61] = 0;
				}
				int num7 = array2[2][0] >> 5 & (int)BinaryDefine.b00000111;
				num6 = (int)(array2[2][0] & BinaryDefine.b00011111);
				if (num7 >= 6)
				{
					if (array[4] == 1)
					{
						num7 = 4;
					}
					else
					{
						num7 = 2;
					}
				}
				if (num6 != 31)
				{
					array[62] = (int)((byte)num6 - 12);
					if (array[62] < -12 || array[62] > 12)
					{
						array[62] = -8;
					}
				}
				else
				{
					array[62] = -8;
				}
				array[38] = (array2[4][3] >> 6 & (int)BinaryDefine.b00000001);
				array[10] = (array2[4][3] >> 5 & (int)BinaryDefine.b00000001);
				int num8 = array2[4][3] >> 4 & (int)BinaryDefine.b00000001;
				int num9 = array2[4][3] >> 3 & (int)BinaryDefine.b00000001;
				array[52] = (int)(array2[4][3] & BinaryDefine.b00000111);
				if (array[52] > 5)
				{
					array[52] = 2;
				}
				array[16] = (array2[4][2] >> 7 & (int)BinaryDefine.b00000001);
				int num10 = array2[4][2] >> 6 & (int)BinaryDefine.b00000001;
				array[1] = (array2[4][2] >> 3 & (int)BinaryDefine.b00000111);
				array[2] = (int)(array2[4][2] & BinaryDefine.b00000111);
				int num11 = array2[4][1] >> 7 & (int)BinaryDefine.b00000001;
				int num12 = array2[4][1] >> 5 & (int)BinaryDefine.b00000001;
				array[36] = (array2[4][1] >> 4 & (int)BinaryDefine.b00000001);
				array[35] = (array2[4][1] >> 3 & (int)BinaryDefine.b00000001);
				array[3] = (int)(array2[4][1] & BinaryDefine.b00000111);
				array[34] = (array2[4][0] >> 7 & (int)BinaryDefine.b00000001);
				array[33] = (array2[4][0] >> 6 & (int)BinaryDefine.b00000001);
				array[32] = (array2[4][0] >> 5 & (int)BinaryDefine.b00000001);
				array[31] = (array2[4][0] >> 4 & (int)BinaryDefine.b00000001);
				array[30] = (array2[4][0] >> 3 & (int)BinaryDefine.b00000001);
				array[29] = (array2[4][0] >> 2 & (int)BinaryDefine.b00000001);
				array[28] = (array2[4][0] >> 1 & (int)BinaryDefine.b00000001);
				array[27] = (int)(array2[4][0] & BinaryDefine.b00000001);
				bool flag2 = (array2[5][3] >> 6 & (int)BinaryDefine.b00000001) != 0;
				array[55] = (array2[5][3] >> 3 & (int)BinaryDefine.b00000111);
				array[57] = (int)(array2[5][3] & BinaryDefine.b00000111);
				if (array[55] < 2 || array[55] > 4)
				{
					array[55] = 4;
				}
				if (array[57] > 4)
				{
					array[57] = 3;
				}
				array[44] = (array2[5][2] >> 4 & (int)BinaryDefine.b00001111);
				array[45] = (int)(array2[5][2] & BinaryDefine.b00001111);
				array[50] = (array2[5][1] >> 4 & (int)BinaryDefine.b00001111);
				array[48] = (int)(array2[5][1] & BinaryDefine.b00001111);
				array[56] = (array2[5][0] >> 4 & (int)BinaryDefine.b00001111);
				array[54] = (int)(array2[5][0] & BinaryDefine.b00001111);
				if (array[56] > 12)
				{
					array[56] = 4;
				}
				if (array[54] > 8)
				{
					array[54] = 4;
				}
				if (!flag2)
				{
					int num13 = array2[5][3] >> 2 & (int)BinaryDefine.b00000011;
					int num14 = (int)(array2[5][3] & BinaryDefine.b00000011);
					switch (num13)
					{
					case 0:
						array[56] = 6;
						break;
					case 1:
						array[56] = 7;
						break;
					case 2:
						array[56] = 8;
						break;
					default:
						array[56] = 4;
						break;
					}
					switch (num14)
					{
					case 0:
						array[54] = 6;
						break;
					case 1:
						array[54] = 7;
						break;
					case 2:
						array[54] = 8;
						break;
					default:
						array[54] = 4;
						break;
					}
					array[55] = (array2[5][0] >> 4 & (int)BinaryDefine.b00000111);
					array[57] = (int)(array2[5][0] & BinaryDefine.b00000111);
				}
				array[49] = (array2[3][3] >> 4 & (int)BinaryDefine.b00001111);
				array[46] = (int)(array2[3][3] & BinaryDefine.b00001111);
				int num15 = array2[3][2] >> 7 & (int)BinaryDefine.b00000001;
				array[6] = (array2[3][2] >> 4 & (int)BinaryDefine.b00000111);
				array[60] = (array2[3][2] >> 3 & (int)BinaryDefine.b00000001);
				array[53] = (int)(array2[3][2] & BinaryDefine.b00000111);
				if (array[53] < 2 || array[53] > 4)
				{
					array[53] = 2;
				}
				int num16 = array2[3][1] >> 6 & (int)BinaryDefine.b00000001;
				int num17 = array2[3][1] >> 5 & (int)BinaryDefine.b00000001;
				int num18 = array2[3][1] >> 4 & (int)BinaryDefine.b00000001;
				int num19 = array2[3][1] >> 3 & (int)BinaryDefine.b00000001;
				int num20 = array2[3][1] >> 2 & (int)BinaryDefine.b00000001;
				bool flag3 = (array2[3][0] >> 7 & (int)BinaryDefine.b00000001) != 0;
				int num21 = array2[3][0] >> 6 & (int)BinaryDefine.b00000001;
				int num22 = array2[3][0] >> 5 & (int)BinaryDefine.b00000001;
				array[17] = (array2[3][0] >> 4 & (int)BinaryDefine.b00000001);
				array[47] = (int)(array2[3][0] & BinaryDefine.b00001111);
				if (array[44] > 12 || array[44] == 0)
				{
					array[44] = 1;
				}
				if (array[45] > 12 || array[45] == 0)
				{
					array[45] = 2;
				}
				if (array[46] > 12 || array[46] == 0)
				{
					array[46] = 2;
				}
				if (array[47] > 12 || array[47] == 0)
				{
					array[47] = 3;
				}
				if (array[48] > 12 || array[48] == 0)
				{
					array[48] = 3;
				}
				if (array[49] > 5 || array[49] == 0)
				{
					array[49] = 1;
				}
				if (array[50] > 12 || array[50] == 0)
				{
					array[50] = 4;
				}
				if (num == 1 && num4 == 0)
				{
					array[0] = 0;
				}
				else if (num == 1 && num4 == 1)
				{
					array[0] = 1;
				}
				else if (num == 0)
				{
					array[0] = 2;
				}
				if (num12 == 0)
				{
					array[22] = 1;
				}
				else if (num20 == 0)
				{
					array[22] = 2;
				}
				else if (num19 == 0)
				{
					array[22] = 3;
				}
				else
				{
					array[22] = 0;
				}
				if (num16 == 0)
				{
					array[23] = 1;
				}
				else if (num18 == 0)
				{
					array[23] = 2;
				}
				else if (num17 == 0)
				{
					array[23] = 3;
				}
				else
				{
					array[23] = 0;
				}
				if (!flag3)
				{
					array[24] = 1;
				}
				else if (num22 == 0)
				{
					array[24] = 2;
				}
				else if (num21 == 0)
				{
					array[24] = 3;
				}
				else
				{
					array[24] = 0;
				}
				if (num15 == 1)
				{
					if (num3 == 1)
					{
						array[25] = 1;
					}
					else
					{
						array[25] = 0;
					}
				}
				else
				{
					array[25] = 2;
				}
				if (num8 == 0)
				{
					if (num2 == 1)
					{
						array[26] = 1;
					}
					else
					{
						array[26] = 0;
					}
				}
				else
				{
					array[26] = 2;
				}
				if (num9 == 1)
				{
					array[37] = 0;
				}
				else if (num11 == 1)
				{
					array[37] = 2;
				}
				else
				{
					array[37] = 1;
				}
				if (num10 == 0)
				{
					if (num5 == 1)
					{
						array[41] = 1;
					}
					else
					{
						array[41] = 2;
					}
				}
				else
				{
					array[41] = 0;
				}
				hwRevisionVersion = (int)(array2[6][0] & BinaryDefine.b00001111);
				array[42] = num7;
				return array;
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x000287F0 File Offset: 0x000269F0
			public byte[] GetNVDataFromUserSetting(int[] userSettingR3, byte[] receivedNVData)
			{
				if (this.menuCnt == 0)
				{
					return null;
				}
				byte[][] array = new byte[7][];
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
				if (userSettingR3[0] == 2)
				{
					b = 0;
					b2 = 0;
				}
				else if (userSettingR3[0] == 1)
				{
					b = 1;
					b2 = 1;
				}
				else
				{
					if (userSettingR3[0] != 0)
					{
						return null;
					}
					b = 1;
					b2 = 0;
				}
				byte b3;
				byte b4;
				byte b5;
				if (userSettingR3[22] == 3)
				{
					b3 = 1;
					b4 = 1;
					b5 = 0;
				}
				else if (userSettingR3[22] == 2)
				{
					b3 = 1;
					b4 = 0;
					b5 = 1;
				}
				else if (userSettingR3[22] == 1)
				{
					b3 = 0;
					b4 = 1;
					b5 = 1;
				}
				else
				{
					if (userSettingR3[22] != 0)
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
				if (userSettingR3[23] == 3)
				{
					b6 = 1;
					b7 = 1;
					b8 = 0;
				}
				else if (userSettingR3[23] == 2)
				{
					b6 = 1;
					b7 = 0;
					b8 = 1;
				}
				else if (userSettingR3[23] == 1)
				{
					b6 = 0;
					b7 = 1;
					b8 = 1;
				}
				else
				{
					if (userSettingR3[23] != 0)
					{
						return null;
					}
					b6 = 1;
					b7 = 1;
					b8 = 1;
				}
				byte b9;
				byte b10;
				byte b11;
				if (userSettingR3[24] == 3)
				{
					b9 = 1;
					b10 = 1;
					b11 = 0;
				}
				else if (userSettingR3[24] == 2)
				{
					b9 = 1;
					b10 = 0;
					b11 = 1;
				}
				else if (userSettingR3[24] == 1)
				{
					b9 = 0;
					b10 = 1;
					b11 = 1;
				}
				else
				{
					if (userSettingR3[24] != 0)
					{
						return null;
					}
					b9 = 1;
					b10 = 1;
					b11 = 1;
				}
				byte b12;
				byte b13;
				if (userSettingR3[25] == 0)
				{
					b12 = 0;
					b13 = 1;
				}
				else if (userSettingR3[25] == 1)
				{
					b12 = 1;
					b13 = 1;
				}
				else
				{
					if (userSettingR3[25] != 2)
					{
						return null;
					}
					b12 = 0;
					b13 = 0;
				}
				byte b14;
				byte b15;
				if (userSettingR3[26] == 2)
				{
					b14 = 0;
					b15 = 1;
				}
				else if (userSettingR3[26] == 1)
				{
					b14 = 1;
					b15 = 0;
				}
				else
				{
					if (userSettingR3[26] != 0)
					{
						return null;
					}
					b14 = 0;
					b15 = 0;
				}
				byte b16;
				byte b17;
				if (userSettingR3[37] == 2)
				{
					b16 = 0;
					b17 = 1;
				}
				else if (userSettingR3[37] == 1)
				{
					b16 = 0;
					b17 = 0;
				}
				else
				{
					if (userSettingR3[37] != 0)
					{
						return null;
					}
					b16 = 1;
					b17 = 0;
				}
				byte b18;
				byte b19;
				if (userSettingR3[41] == 2)
				{
					b18 = 0;
					b19 = 0;
				}
				else if (userSettingR3[41] == 1)
				{
					b18 = 0;
					b19 = 1;
				}
				else
				{
					if (userSettingR3[41] != 0)
					{
						return null;
					}
					b18 = 1;
					b19 = 1;
				}
				byte b20;
				if (userSettingR3[43] == 1)
				{
					if (userSettingR3[59] > 50)
					{
						b20 = 0;
					}
					else
					{
						b20 = 1;
					}
				}
				else
				{
					if (userSettingR3[43] != 0)
					{
						return null;
					}
					if (userSettingR3[59] > 80)
					{
						b20 = 0;
					}
					else
					{
						b20 = 1;
					}
				}
				byte b21 = (byte)userSettingR3[42];
				byte[] array3 = array[0];
				int num = 3;
				array3[num] |= (byte)((int)b << 6 & (int)BinaryDefine.b01000000);
				byte[] array4 = array[0];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR3[39] << 5 & (int)BinaryDefine.b00100000);
				byte[] array5 = array[0];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR3[40] << 2 & (int)BinaryDefine.b00011100);
				byte[] array6 = array[0];
				int num4 = 3;
				array6[num4] |= (byte)((int)b14 << 1 & (int)BinaryDefine.b00000010);
				byte[] array7 = array[0];
				int num5 = 3;
				array7[num5] |= (byte)(userSettingR3[21] & (int)BinaryDefine.b00000001);
				byte[] array8 = array[0];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR3[20] << 7 & (int)BinaryDefine.b10000000);
				byte[] array9 = array[0];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR3[9] << 6 & (int)BinaryDefine.b01000000);
				byte[] array10 = array[0];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR3[11] << 5 & (int)BinaryDefine.b00100000);
				byte[] array11 = array[0];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR3[12] << 4 & (int)BinaryDefine.b00010000);
				byte[] array12 = array[0];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR3[13] << 3 & (int)BinaryDefine.b00001000);
				byte[] array13 = array[0];
				int num11 = 2;
				array13[num11] |= (byte)(userSettingR3[14] << 2 & (int)BinaryDefine.b00000100);
				byte[] array14 = array[0];
				int num12 = 2;
				array14[num12] |= (byte)(userSettingR3[18] << 1 & (int)BinaryDefine.b00000010);
				byte[] array15 = array[0];
				int num13 = 2;
				array15[num13] |= (byte)(userSettingR3[19] & (int)BinaryDefine.b00000001);
				byte[] array16 = array[0];
				int num14 = 1;
				array16[num14] |= (byte)(userSettingR3[4] << 7 & (int)BinaryDefine.b10000000);
				byte[] array17 = array[0];
				int num15 = 1;
				array17[num15] |= (byte)(userSettingR3[51] << 3 & (int)BinaryDefine.b00001000);
				byte[] array18 = array[0];
				int num16 = 1;
				array18[num16] |= (byte)(userSettingR3[58] << 2 & (int)BinaryDefine.b00000100);
				byte[] array19 = array[0];
				int num17 = 1;
				array19[num17] |= (byte)(userSettingR3[64] << 1 & (int)BinaryDefine.b00000010);
				byte[] array20 = array[0];
				int num18 = 1;
				array20[num18] |= (byte)(userSettingR3[66] & (int)BinaryDefine.b00000001);
				byte[] array21 = array[0];
				int num19 = 0;
				array21[num19] |= (byte)((int)b12 << 7 & (int)BinaryDefine.b10000000);
				byte[] array22 = array[0];
				int num20 = 0;
				array22[num20] |= (byte)(userSettingR3[67] << 4 & (int)BinaryDefine.b01110000);
				byte[] array23 = array[0];
				int num21 = 0;
				array23[num21] |= (byte)((int)b2 << 3 & (int)BinaryDefine.b00001000);
				byte[] array24 = array[0];
				int num22 = 0;
				array24[num22] |= (byte)(userSettingR3[68] & (int)BinaryDefine.b00000111);
				byte b22;
				if (b20 == 1)
				{
					if (userSettingR3[43] == 1)
					{
						b22 = (byte)(userSettingR3[59] / 5);
					}
					else
					{
						b22 = (byte)(userSettingR3[59] / 10);
					}
				}
				else if (userSettingR3[43] == 1)
				{
					b22 = (byte)((userSettingR3[59] - 55) / 5);
				}
				else
				{
					b22 = (byte)((userSettingR3[59] - 90) / 10);
				}
				byte[] array25 = array[2];
				int num23 = 2;
				array25[num23] |= (byte)(userSettingR3[43] << 7 & (int)BinaryDefine.b10000000);
				byte[] array26 = array[2];
				int num24 = 2;
				array26[num24] |= (byte)((int)b19 << 6 & (int)BinaryDefine.b01000000);
				byte[] array27 = array[2];
				int num25 = 2;
				array27[num25] |= (byte)(userSettingR3[63] << 5 & (int)BinaryDefine.b00100000);
				byte[] array28 = array[2];
				int num26 = 2;
				array28[num26] |= (byte)(userSettingR3[65] << 4 & (int)BinaryDefine.b00010000);
				byte[] array29 = array[2];
				int num27 = 2;
				// DECOMPILE-FIX: Restore byte narrowing for the exported bit-mask operations
				// in this file; unchecked casts preserve the original IL byte stores.
				array29[num27] |= unchecked((byte)(b22 & BinaryDefine.b00001111));
				if (userSettingR3[43] == 1)
				{
					b22 = (byte)(userSettingR3[8] / 5);
				}
				else
				{
					b22 = (byte)(userSettingR3[8] / 10);
				}
				byte[] array30 = array[2];
				int num28 = 3;
				array30[num28] |= (byte)((int)b20 << 6 & (int)BinaryDefine.b01000000);
				byte[] array31 = array[2];
				int num29 = 3;
				array31[num29] |= (byte)(userSettingR3[15] << 5 & (int)BinaryDefine.b00100000);
				byte[] array32 = array[2];
				int num30 = 3;
				array32[num30] |= unchecked((byte)(b22 & BinaryDefine.b00011111));
				if (userSettingR3[43] == 1)
				{
					b22 = (byte)(userSettingR3[61] / 5);
				}
				else
				{
					b22 = (byte)(userSettingR3[61] / 10);
				}
				byte[] array33 = array[2];
				int num31 = 1;
				array33[num31] |= (byte)(userSettingR3[5] << 6 & (int)BinaryDefine.b01000000);
				byte[] array34 = array[2];
				int num32 = 1;
				array34[num32] |= (byte)(userSettingR3[7] << 5 & (int)BinaryDefine.b00100000);
				byte[] array35 = array[2];
				int num33 = 1;
				array35[num33] |= unchecked((byte)(b22 & BinaryDefine.b00011111));
				b22 = (byte)(userSettingR3[62] + 12);
				byte[] array36 = array[2];
				int num34 = 0;
				array36[num34] |= (byte)((int)b21 << 5 & (int)BinaryDefine.b11100000);
				byte[] array37 = array[2];
				int num35 = 0;
				array37[num35] |= unchecked((byte)(b22 & BinaryDefine.b00011111));
				byte[] array38 = array[4];
				int num36 = 3;
				array38[num36] |= (byte)(userSettingR3[38] << 6 & (int)BinaryDefine.b01000000);
				byte[] array39 = array[4];
				int num37 = 3;
				array39[num37] |= (byte)(userSettingR3[10] << 5 & (int)BinaryDefine.b00100000);
				byte[] array40 = array[4];
				int num38 = 3;
				array40[num38] |= (byte)((int)b15 << 4 & (int)BinaryDefine.b00010000);
				byte[] array41 = array[4];
				int num39 = 3;
				array41[num39] |= (byte)((int)b16 << 3 & (int)BinaryDefine.b00001000);
				byte[] array42 = array[4];
				int num40 = 3;
				array42[num40] |= (byte)(userSettingR3[52] & (int)BinaryDefine.b00000111);
				byte[] array43 = array[4];
				int num41 = 2;
				array43[num41] |= (byte)(userSettingR3[16] << 7 & (int)BinaryDefine.b10000000);
				byte[] array44 = array[4];
				int num42 = 2;
				array44[num42] |= (byte)((int)b18 << 6 & (int)BinaryDefine.b01000000);
				byte[] array45 = array[4];
				int num43 = 2;
				array45[num43] |= (byte)(userSettingR3[1] << 3 & (int)BinaryDefine.b00111000);
				byte[] array46 = array[4];
				int num44 = 2;
				array46[num44] |= (byte)(userSettingR3[2] & (int)BinaryDefine.b00000111);
				byte[] array47 = array[4];
				int num45 = 1;
				array47[num45] |= (byte)((int)b17 << 7 & (int)BinaryDefine.b10000000);
				byte[] array48 = array[4];
				int num46 = 1;
				array48[num46] |= (byte)((int)b3 << 5 & (int)BinaryDefine.b00100000);
				byte[] array49 = array[4];
				int num47 = 1;
				array49[num47] |= (byte)(userSettingR3[36] << 4 & (int)BinaryDefine.b00010000);
				byte[] array50 = array[4];
				int num48 = 1;
				array50[num48] |= (byte)(userSettingR3[35] << 3 & (int)BinaryDefine.b00001000);
				byte[] array51 = array[4];
				int num49 = 1;
				array51[num49] |= (byte)(userSettingR3[3] & (int)BinaryDefine.b00000111);
				byte[] array52 = array[4];
				int num50 = 0;
				array52[num50] |= (byte)(userSettingR3[34] << 7 & (int)BinaryDefine.b10000000);
				byte[] array53 = array[4];
				int num51 = 0;
				array53[num51] |= (byte)(userSettingR3[33] << 6 & (int)BinaryDefine.b01000000);
				byte[] array54 = array[4];
				int num52 = 0;
				array54[num52] |= (byte)(userSettingR3[32] << 5 & (int)BinaryDefine.b00100000);
				byte[] array55 = array[4];
				int num53 = 0;
				array55[num53] |= (byte)(userSettingR3[31] << 4 & (int)BinaryDefine.b00010000);
				byte[] array56 = array[4];
				int num54 = 0;
				array56[num54] |= (byte)(userSettingR3[30] << 3 & (int)BinaryDefine.b00001000);
				byte[] array57 = array[4];
				int num55 = 0;
				array57[num55] |= (byte)(userSettingR3[29] << 2 & (int)BinaryDefine.b00000100);
				byte[] array58 = array[4];
				int num56 = 0;
				array58[num56] |= (byte)(userSettingR3[28] << 1 & (int)BinaryDefine.b00000010);
				byte[] array59 = array[4];
				int num57 = 0;
				array59[num57] |= (byte)(userSettingR3[27] & (int)BinaryDefine.b00000001);
				byte b23 = BinaryDefine.b01000000;
				byte[] array60 = array[5];
				int num58 = 3;
				array60[num58] |= b23;
				byte[] array61 = array[5];
				int num59 = 3;
				array61[num59] |= (byte)(userSettingR3[55] << 3 & (int)BinaryDefine.b00111000);
				byte[] array62 = array[5];
				int num60 = 3;
				array62[num60] |= (byte)(userSettingR3[57] & (int)BinaryDefine.b00000111);
				byte[] array63 = array[5];
				int num61 = 2;
				array63[num61] |= (byte)(userSettingR3[44] << 4 & (int)BinaryDefine.b11110000);
				byte[] array64 = array[5];
				int num62 = 2;
				array64[num62] |= (byte)(userSettingR3[45] & (int)BinaryDefine.b00001111);
				byte[] array65 = array[5];
				int num63 = 1;
				array65[num63] |= (byte)(userSettingR3[50] << 4 & (int)BinaryDefine.b11110000);
				byte[] array66 = array[5];
				int num64 = 1;
				array66[num64] |= (byte)(userSettingR3[48] & (int)BinaryDefine.b00001111);
				byte[] array67 = array[5];
				int num65 = 0;
				array67[num65] |= (byte)(userSettingR3[56] << 4 & (int)BinaryDefine.b11110000);
				byte[] array68 = array[5];
				int num66 = 0;
				array68[num66] |= (byte)(userSettingR3[54] & (int)BinaryDefine.b00001111);
				byte[] array69 = array[3];
				int num67 = 3;
				array69[num67] |= (byte)(userSettingR3[49] << 4 & (int)BinaryDefine.b01110000);
				byte[] array70 = array[3];
				int num68 = 3;
				array70[num68] |= (byte)(userSettingR3[46] & (int)BinaryDefine.b00001111);
				byte[] array71 = array[3];
				int num69 = 2;
				array71[num69] |= (byte)((int)b13 << 7 & (int)BinaryDefine.b10000000);
				byte[] array72 = array[3];
				int num70 = 2;
				array72[num70] |= (byte)(userSettingR3[6] << 4 & (int)BinaryDefine.b01110000);
				byte[] array73 = array[3];
				int num71 = 2;
				array73[num71] |= (byte)(userSettingR3[60] << 3 & (int)BinaryDefine.b00001000);
				byte[] array74 = array[3];
				int num72 = 2;
				array74[num72] |= (byte)(userSettingR3[53] & (int)BinaryDefine.b00000111);
				byte[] array75 = array[3];
				int num73 = 1;
				array75[num73] |= (byte)((int)b6 << 6 & (int)BinaryDefine.b01000000);
				byte[] array76 = array[3];
				int num74 = 1;
				array76[num74] |= (byte)((int)b8 << 5 & (int)BinaryDefine.b00100000);
				byte[] array77 = array[3];
				int num75 = 1;
				array77[num75] |= (byte)((int)b7 << 4 & (int)BinaryDefine.b00010000);
				byte[] array78 = array[3];
				int num76 = 1;
				array78[num76] |= (byte)((int)b5 << 3 & (int)BinaryDefine.b00001000);
				byte[] array79 = array[3];
				int num77 = 1;
				array79[num77] |= (byte)((int)b4 << 2 & (int)BinaryDefine.b00000100);
				byte[] array80 = array[3];
				int num78 = 0;
				array80[num78] |= (byte)((int)b9 << 7 & (int)BinaryDefine.b10000000);
				byte[] array81 = array[3];
				int num79 = 0;
				array81[num79] |= (byte)((int)b11 << 6 & (int)BinaryDefine.b01000000);
				byte[] array82 = array[3];
				int num80 = 0;
				array82[num80] |= (byte)((int)b10 << 5 & (int)BinaryDefine.b00100000);
				byte[] array83 = array[3];
				int num81 = 0;
				array83[num81] |= (byte)(userSettingR3[17] << 4 & (int)BinaryDefine.b00010000);
				byte[] array84 = array[3];
				int num82 = 0;
				array84[num82] |= (byte)(userSettingR3[47] & (int)BinaryDefine.b00001111);
				Array.Copy(receivedNVData, array2, receivedNVData.Length);
				for (int i = 0; i < array.Length; i++)
				{
					for (int j = 0; j < array[i].Length; j++)
					{
						byte[] array85 = array2;
						int num83 = i * 4 + j;
						array85[num83] &= unchecked((byte)(~this.userNVDataPos[i * 4 + j]));
						byte[] array86 = array2;
						int num84 = i * 4 + j;
						array86[num84] |= array[i][j];
					}
				}
				int num85 = 0;
				for (int i = 0; i < receivedNVData.Length; i++)
				{
					if (receivedNVData[i] == array2[i])
					{
						num85++;
					}
				}
				return array2;
			}

			// Token: 0x040004FF RID: 1279
			private int supportVersion = 161;

			// Token: 0x04000500 RID: 1280
			private int menuCnt = 69;

			// Token: 0x04000501 RID: 1281
			private byte[] userNVDataPos = new byte[]
			{
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				0,
				0,
				0,
				0,
				byte.MaxValue,
				127,
				byte.MaxValue,
				127,
				byte.MaxValue,
				124,
				byte.MaxValue,
				127,
				byte.MaxValue,
				191,
				byte.MaxValue,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				0,
				0,
				0,
				0
			};

			// Token: 0x04000502 RID: 1282
			private const int RD_1 = 0;

			// Token: 0x04000503 RID: 1283
			private const int RD_5 = 1;

			// Token: 0x04000504 RID: 1284
			private const int GPS = 2;

			// Token: 0x04000505 RID: 1285
			private const int RD_4 = 3;

			// Token: 0x04000506 RID: 1286
			private const int RD_2 = 4;

			// Token: 0x04000507 RID: 1287
			private const int RD_3 = 5;

			// Token: 0x04000508 RID: 1288
			private const int RD_6 = 6;

			// Token: 0x04000509 RID: 1289
			private const int ADDR_CNT = 7;

			// Token: 0x020000B3 RID: 179
			private enum MENU
			{
				// Token: 0x04000720 RID: 1824
				DETECTION_MODE,
				// Token: 0x04000721 RID: 1825
				X_SENSITIVE,
				// Token: 0x04000722 RID: 1826
				K_SENSITIVE,
				// Token: 0x04000723 RID: 1827
				KA_SENSITIVE,
				// Token: 0x04000724 RID: 1828
				GPS_ENABLE,
				// Token: 0x04000725 RID: 1829
				SPEED_CAMERA_ENABLE,
				// Token: 0x04000726 RID: 1830
				SPEED_CAMERA_ALERT_RANGE,
				// Token: 0x04000727 RID: 1831
				RLC_ENABLE,
				// Token: 0x04000728 RID: 1832
				RLC_QRIDE,
				// Token: 0x04000729 RID: 1833
				VOICE_ENABLE,
				// Token: 0x0400072A RID: 1834
				KA_FREQ_VOICE,
				// Token: 0x0400072B RID: 1835
				X_BAND_ENABLE,
				// Token: 0x0400072C RID: 1836
				K_BAND_ENABLE,
				// Token: 0x0400072D RID: 1837
				KA_BAND_ENABLE,
				// Token: 0x0400072E RID: 1838
				LASER_ENABLE,
				// Token: 0x0400072F RID: 1839
				K_POP_ENABLE,
				// Token: 0x04000730 RID: 1840
				MRCD_ENABLE,
				// Token: 0x04000731 RID: 1841
				GATSO_ENABLE,
				// Token: 0x04000732 RID: 1842
				KA_POP_ENABLE,
				// Token: 0x04000733 RID: 1843
				K_FILTER_ENABLE,
				// Token: 0x04000734 RID: 1844
				KA_FILTER_ENABLE,
				// Token: 0x04000735 RID: 1845
				TSF_ENABLE,
				// Token: 0x04000736 RID: 1846
				K_BLOCK_FILTER_1_MODE,
				// Token: 0x04000737 RID: 1847
				K_BLOCK_FILTER_2_MODE,
				// Token: 0x04000738 RID: 1848
				K_BLOCK_FILTER_3_MODE,
				// Token: 0x04000739 RID: 1849
				K_NARROW,
				// Token: 0x0400073A RID: 1850
				KA_NARROW,
				// Token: 0x0400073B RID: 1851
				KA_SEG1,
				// Token: 0x0400073C RID: 1852
				KA_SEG2,
				// Token: 0x0400073D RID: 1853
				KA_SEG3,
				// Token: 0x0400073E RID: 1854
				KA_SEG4,
				// Token: 0x0400073F RID: 1855
				KA_SEG5,
				// Token: 0x04000740 RID: 1856
				KA_SEG6,
				// Token: 0x04000741 RID: 1857
				KA_SEG7,
				// Token: 0x04000742 RID: 1858
				KA_SEG8,
				// Token: 0x04000743 RID: 1859
				KA_SEG9,
				// Token: 0x04000744 RID: 1860
				KA_SEG10,
				// Token: 0x04000745 RID: 1861
				PRIORITY_MODE,
				// Token: 0x04000746 RID: 1862
				MUTE_MEM_BAND_OPTION,
				// Token: 0x04000747 RID: 1863
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x04000748 RID: 1864
				BACKGROUND_COLOR,
				// Token: 0x04000749 RID: 1865
				MAIN_DISPLAY,
				// Token: 0x0400074A RID: 1866
				LEFT_DISPLAY,
				// Token: 0x0400074B RID: 1867
				SPEED_UNIT,
				// Token: 0x0400074C RID: 1868
				X_BAND_ALERT_TONE,
				// Token: 0x0400074D RID: 1869
				K_BAND_ALERT_TONE,
				// Token: 0x0400074E RID: 1870
				MRCD_ALERT_TONE,
				// Token: 0x0400074F RID: 1871
				GATSO_ALERT_TONE,
				// Token: 0x04000750 RID: 1872
				KA_BAND_ALERT_TONE,
				// Token: 0x04000751 RID: 1873
				KA_BAND_BOGEY_TONE,
				// Token: 0x04000752 RID: 1874
				LASER_ALERT_TONE,
				// Token: 0x04000753 RID: 1875
				AUTO_MUTE_ENABLE,
				// Token: 0x04000754 RID: 1876
				AUTO_MUTE_VOLUME,
				// Token: 0x04000755 RID: 1877
				DARK_MODE_BRIGHTNESS,
				// Token: 0x04000756 RID: 1878
				AUTO_DIM_SET_BRIGHT_TIME,
				// Token: 0x04000757 RID: 1879
				AUTO_DIM_SET_BRIGHT_BRIGHTNESS,
				// Token: 0x04000758 RID: 1880
				AUTO_DIM_SET_DIM_TIME,
				// Token: 0x04000759 RID: 1881
				AUTO_DIM_SET_DIM_BRIGHTNESS,
				// Token: 0x0400075A RID: 1882
				BACKLIGHT_MODE,
				// Token: 0x0400075B RID: 1883
				QRIDE_MODE,
				// Token: 0x0400075C RID: 1884
				MRCD_QRIDE_ENABLE,
				// Token: 0x0400075D RID: 1885
				LIMIT_SPEED_MODE,
				// Token: 0x0400075E RID: 1886
				GMT,
				// Token: 0x0400075F RID: 1887
				DST_ENABLE,
				// Token: 0x04000760 RID: 1888
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x04000761 RID: 1889
				VEHICLE_BATT_SAVER_ENABLE,
				// Token: 0x04000762 RID: 1890
				SELF_TEST_ENABLE,
				// Token: 0x04000763 RID: 1891
				MAIN_DIM_SET,
				// Token: 0x04000764 RID: 1892
				MAIN_VOLUME
			}
		}
	}
}
