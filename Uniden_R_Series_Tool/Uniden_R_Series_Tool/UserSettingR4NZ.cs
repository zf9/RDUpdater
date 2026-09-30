using System;
using System.Linq;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000025 RID: 37
	internal static class UserSettingR4NZ
	{
		// Token: 0x04000333 RID: 819
		public static UserSettingFormat[] user_setting = new UserSettingFormat[]
		{
			new UserSettingR4NZ.v128()
		};

		// Token: 0x0200008A RID: 138
		private class v128 : UserSettingFormat
		{
			// Token: 0x060002B8 RID: 696 RVA: 0x0002D458 File Offset: 0x0002B658
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0002D460 File Offset: 0x0002B660
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x060002BA RID: 698 RVA: 0x0002D468 File Offset: 0x0002B668
			public byte[] GetNVDataMask()
			{
				return UserSettingR4NZ.v128.userNVDataPos;
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00024E4C File Offset: 0x0002304C
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return false;
			}

			// Token: 0x060002BC RID: 700 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_level(int strength, int mode)
			{
				return -1;
			}

			// Token: 0x060002BD RID: 701 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_raw_strength(int level, int mode)
			{
				return -1;
			}

			// Token: 0x060002BE RID: 702 RVA: 0x0002D470 File Offset: 0x0002B670
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
				}, "Highway - Full Sensitivity\nCity - X and K sensitivity reduced. Ka band sensitivity same as Highway.\nAdvanced - User adjusts X, K, and Ka band sensitivity from 100%~30% in 10% intervals.\nAuto City - The R4 will automatically switch between Highway and City depending on the speed limits set in the Auto City Speed menu.");
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
				}, "Sets the speed at which the R4 changes from City mode to Highway mode and back.\n(Detection Mode - Auto City)");
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
				array[11] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, "POI PassChime", new int[]
				{
					0,
					1
				}, new string[]
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
				UserSettingMenu[] array2 = array;
				int num = 14;
				UserSettingMenu.MENU_TYPE menuType = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString = "X Band On/Off";
				int[] array3 = new int[2];
				array3[0] = 1;
				array2[num] = new UserSettingMenu(menuType, menuString, array3, new string[]
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
				array[18] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser Gun ID On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to display laser gun identifier.");
				UserSettingMenu[] array4 = array;
				int num2 = 19;
				UserSettingMenu.MENU_TYPE menuType2 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString2 = "K POP On/Off";
				int[] array5 = new int[2];
				array5[0] = 1;
				array4[num2] = new UserSettingMenu(menuType2, menuString2, array5, new string[]
				{
					"Off",
					"On"
				}, "Detects K POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[20] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "MRCD/T On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates MultaRadar CD/CT low - powered radar gun detection.");
				array[21] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Gatso RT3/4 On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates detection for Gatso radar guns.");
				UserSettingMenu[] array6 = array;
				int num3 = 22;
				UserSettingMenu.MENU_TYPE menuType3 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString3 = "Ka POP On/Off";
				int[] array7 = new int[2];
				array7[0] = 1;
				array6[num3] = new UserSettingMenu(menuType3, menuString3, array7, new string[]
				{
					"Off",
					"On"
				}, "Detects Ka POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[23] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Filter", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the K band to prevent false detections.");
				UserSettingMenu[] array8 = array;
				int num4 = 24;
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
				int num5 = 25;
				UserSettingMenu.MENU_TYPE menuType5 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString5 = "TSF";
				int[] array11 = new int[2];
				array11[0] = 1;
				array10[num5] = new UserSettingMenu(menuType5, menuString5, array11, new string[]
				{
					"Off",
					"On"
				}, "Traffic Sensor Filter. Prevents false alarms caused by traffic monitoring radar systems.");
				array[26] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter 24.199Ghz (± 0.005)", new int[]
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
				array[27] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter 24.168Ghz (± 0.002)", new int[]
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
				array[28] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Band 1 : 23.900Ghz ~ 24.100Ghz", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "K band sweep 23.900Ghz – 24.100Ghz");
				UserSettingMenu[] array12 = array;
				int num6 = 29;
				UserSettingMenu.MENU_TYPE menuType6 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString6 = "K Band 2 : 24.100Ghz ~ 24.250Ghz";
				int[] array13 = new int[2];
				array13[0] = 1;
				array12[num6] = new UserSettingMenu(menuType6, menuString6, array13, new string[]
				{
					"Off",
					"On"
				}, "K band sweep 24.100Ghz – 24.250Gh");
				UserSettingMenu[] array14 = array;
				int num7 = 30;
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
				int num8 = 31;
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
				int num9 = 32;
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
				int num10 = 33;
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
				int num11 = 34;
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
				int num12 = 35;
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
				int num13 = 36;
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
				int num14 = 37;
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
				int num15 = 38;
				UserSettingMenu.MENU_TYPE menuType15 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString15 = "Ka Segmentation 35.613Ghz – 35.701Ghz";
				int[] array31 = new int[2];
				array31[0] = 1;
				array30[num15] = new UserSettingMenu(menuType15, menuString15, array31, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.613Ghz – 35.701Ghz (Ka Segmentation mode)");
				array[39] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Priority", new int[]
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
				array[40] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Select bands to be muted.");
				array[41] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute Memory On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "This menu turns the ability to automatically save mute requests for specific locations/frequency bands.");
				array[42] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Auto Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Auto Mute Memory Band Option Set specifies which bands will be muted.");
				UserSettingMenu[] array32 = array;
				int num16 = 43;
				UserSettingMenu.MENU_TYPE menuType16 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString16 = "All Threat Display";
				int[] array33 = new int[2];
				array33[0] = 1;
				array32[num16] = new UserSettingMenu(menuType16, menuString16, array33, new string[]
				{
					"Off",
					"On"
				}, "Displays if more than one radar signals are detected at the same time. The signal with the strongest radar signal is considered the main signal. The other signals are displayed on the left side.");
				array[44] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Background Color", new int[]
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
				array[45] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Color", new int[]
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
				array[46] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Color", new int[]
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
				array[47] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD/T Color", new int[]
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
				array[48] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "GATSO RT3/4 Color", new int[]
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
				array[49] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Color", new int[]
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
				array[50] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Display", new int[]
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
				array[51] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Scan Icon", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Scan Icon displays to indicate the end of a scan cycle.");
				array[52] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Left Display", new int[]
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
				int num17 = 53;
				UserSettingMenu.MENU_TYPE menuType17 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString17 = "Alert Display";
				int[] array35 = new int[2];
				array35[0] = 1;
				array34[num17] = new UserSettingMenu(menuType17, menuString17, array35, new string[]
				{
					"Type 1",
					"Type 2"
				}, "Select one of two OLED display formats.");
				UserSettingMenu[] array36 = array;
				int num18 = 54;
				UserSettingMenu.MENU_TYPE menuType18 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString18 = "Speed Unit";
				int[] array37 = new int[2];
				array37[0] = 1;
				array36[num18] = new UserSettingMenu(menuType18, menuString18, array37, new string[]
				{
					"mph",
					"km/h"
				}, "Select the speed measurement type.");
				array[54].isUnitMenuFlag = true;
				array[55] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "X Band Alert Tone", new int[]
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
				array[56] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Alert Tone", new int[]
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
				array[57] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Tone", new int[]
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
				array[58] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "MRCD/T Alert Tone", new int[]
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
				array[59] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "GATSO RT3/4 Alert Tone", new int[]
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
				array[60] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Alert Tone", new int[]
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
				array[61] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Bogey Tone", new int[]
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
				array[62] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Laser Alert Tone", new int[]
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
				array[63] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Auto Mute reduces alarm level to 1 after 3 seconds and returns to normal operation(Auto Mute = OFF) 10 seconds after the alert ends.If the same alarm sounds within the 10 second period, Auto Mute remains at level 1.The unit returns to normal operation(Auto Mute = OFF) if a different band is detected during Auto Mute = ON mode.");
				array[64] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Volume", new int[]
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
				array[65] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Dark mode Brightness", new int[]
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
				array[66] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Mode", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Time",
					"Sensor"
				}, "Set the start times for the OLED to automatically brighten or dim.\nSelecting Time will let you set specific times when you want the OLED to get brighter or dimmer.\nSelecting Sensor will let the ambient light levels trigger when the OLED will get brighter or dimmer.");
				array[67] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Time", new int[]
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
				array[68] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Brightness", new int[]
				{
					4,
					3,
					2
				}, new string[]
				{
					"Bright",
					"Dim",
					"Dimmer"
				}, "The R4 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[69] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Time", new int[]
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
				}, "The R4 has a light sensor that works with the Auto Dim feature to dim or brighten the OLED display according to outside light levels. Configure OLED brightness/dim levels through the Auto Dim setting in the menus.");
				array[71] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Backlight On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns the front key backlight on and off.");
				array[72] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Quiet Ride", new int[][]
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
						90,
						95,
						100,
						105,
						110,
						115,
						120,
						125,
						130,
						135,
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
						"15km/h",
						"20km/h",
						"25km/h",
						"30km/h",
						"35km/h",
						"40km/h",
						"45km/h",
						"50km/h",
						"55km/h",
						"60km/h",
						"65km/h",
						"70km/h",
						"75km/h",
						"80km/h",
						"85km/h",
						"90km/h",
						"95km/h",
						"100km/h",
						"105km/h",
						"110km/h",
						"115km/h",
						"120km/h",
						"125km/h",
						"130km/h",
						"135km/h",
						"140km/h"
					}
				}, new string[]
				{
					"mph",
					"km/h"
				}, "Mutes radar alarms for K and X bands when you drive under the speed limit you set here.");
				UserSettingMenu[] array38 = array;
				int num19 = 73;
				UserSettingMenu.MENU_TYPE menuType19 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString19 = "Quiet Ride MRCD/T On/Off";
				int[] array39 = new int[2];
				array39[0] = 1;
				array38[num19] = new UserSettingMenu(menuType19, menuString19, array39, new string[]
				{
					"Off",
					"On"
				}, "Mutes MRCD/T alarms when users drive under the speed limit set previously.");
				array[74] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Quiet Ride Volume", new int[]
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
				array[75] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Limit Speed", new int[][]
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
						85,
						90,
						95,
						100,
						105,
						110,
						115,
						120,
						125,
						130,
						135,
						140,
						145,
						150,
						155,
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
						"85km/h",
						"90km/h",
						"95km/h",
						"100km/h",
						"105km/h",
						"110km/h",
						"115km/h",
						"120km/h",
						"125km/h",
						"130km/h",
						"135km/h",
						"140km/h",
						"145km/h",
						"150km/h",
						"155km/h",
						"160km/h"
					}
				}, new string[]
				{
					"mph",
					"km/h"
				}, "Set an alarm to sound if you go faster than this selected speed.");
				array[76] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "GMT", new int[]
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
				UserSettingMenu[] array40 = array;
				int num20 = 77;
				UserSettingMenu.MENU_TYPE menuType20 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString20 = "DST";
				int[] array41 = new int[2];
				array41[0] = 1;
				array40[num20] = new UserSettingMenu(menuType20, menuString20, array41, new string[]
				{
					"Off",
					"On"
				}, "Daylight Saving Time");
				UserSettingMenu[] array42 = array;
				int num21 = 78;
				UserSettingMenu.MENU_TYPE menuType21 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString21 = "Low Battery Warning";
				int[] array43 = new int[2];
				array43[0] = 1;
				array42[num21] = new UserSettingMenu(menuType21, menuString21, array43, new string[]
				{
					"Off",
					"On"
				}, "Sounds a warning tone if the vehicle battery power drops below 11V.");
				UserSettingMenu[] array44 = array;
				int num22 = 79;
				UserSettingMenu.MENU_TYPE menuType22 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString22 = "Vehicle Battery Saver";
				int[] array45 = new int[2];
				array45[0] = 1;
				array44[num22] = new UserSettingMenu(menuType22, menuString22, array45, new string[]
				{
					"Off",
					"On"
				}, "Turns off power to the R4 if the speed stays at 0 or if the GPS is not connected for more than an hour.");
				array[80] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Self Test", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Runs a self diagnostic test on the unit to check for faults.");
				array[81] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Memory Quota", new int[]
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
				array[82] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Dim", new int[]
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
				array[83] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Main Volume", new int[]
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
				array[84] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Level", new int[]
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
				array[85] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Bluetooth", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to connect applications that support the radar detector.");
				array[86] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to use the external laser transponder interface.");
				array[87] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP Mode", new int[]
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
				array[88] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP1 Setting", new int[]
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
				array[89] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP2 Setting", new int[]
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
				array[90] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP3 Setting", new int[]
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
				array[91] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP4 Setting", new int[]
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
				array[92] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP5 Setting", new int[]
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
				array[93] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP6 Setting", new int[]
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
				// DECOMPILE-FIX: Captures identify R4NZ M.Cam at NV byte 21 bit 3 (1=Off, 0=On).
				array[94] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "M.Cam", new int[]
				{
					1,
					0
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates Mobile Camera (Acusensus) detection.");
				return array;
			}

			// Token: 0x060002BF RID: 703 RVA: 0x0002F630 File Offset: 0x0002D830
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
				array[43] = (array2[0][3] >> 4 & (int)BinaryDefine.b00000001);
				array[44] = (array2[0][3] >> 1 & (int)BinaryDefine.b00000111);
				array[25] = (int)(array2[0][3] & BinaryDefine.b00000001);
				switch (array[44])
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
					array[44] = 5;
					break;
				}
				array[24] = (array2[0][2] >> 7 & (int)BinaryDefine.b00000001);
				array[12] = (array2[0][2] >> 6 & (int)BinaryDefine.b00000001);
				array[14] = (array2[0][2] >> 5 & (int)BinaryDefine.b00000001);
				array[15] = (array2[0][2] >> 4 & (int)BinaryDefine.b00000001);
				array[16] = (array2[0][2] >> 3 & (int)BinaryDefine.b00000001);
				array[17] = (array2[0][2] >> 2 & (int)BinaryDefine.b00000001);
				array[22] = (array2[0][2] >> 1 & (int)BinaryDefine.b00000001);
				array[23] = (int)(array2[0][2] & BinaryDefine.b00000001);
				array[6] = (array2[0][1] >> 7 & (int)BinaryDefine.b00000001);
				array[63] = (array2[0][1] >> 3 & (int)BinaryDefine.b00000001);
				array[71] = (array2[0][1] >> 2 & (int)BinaryDefine.b00000001);
				array[78] = (array2[0][1] >> 1 & (int)BinaryDefine.b00000001);
				array[80] = (int)(array2[0][1] & BinaryDefine.b00000001);
				array[82] = (array2[0][0] >> 4 & (int)BinaryDefine.b00000111);
				array[83] = (int)(array2[0][0] & BinaryDefine.b00001111);
				switch (array[82])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
					break;
				default:
					array[82] = 5;
					break;
				}
				if (array[83] < 0 || array[83] > 8)
				{
					array[83] = 4;
				}
				array[54] = (array2[1][2] >> 7 & (int)BinaryDefine.b00000001);
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
				if (array[54] == 1)
				{
					if (num >= 0 && num <= 18)
					{
						array[72] = num * 5;
					}
					else
					{
						array[72] = 0;
					}
				}
				else if (num >= 0 && num <= 28)
				{
					array[72] = num * 5;
				}
				else
				{
					array[72] = 0;
				}
				array[77] = (array2[1][3] >> 7 & (int)BinaryDefine.b00000001);
				array[79] = (array2[1][3] >> 6 & (int)BinaryDefine.b00000001);
				array[19] = (array2[1][3] >> 5 & (int)BinaryDefine.b00000001);
				num = (int)(array2[1][3] & BinaryDefine.b00011111);
				if (array[54] == 1)
				{
					if (num == 0 || (num >= 10 && num <= 17))
					{
						array[10] = num * 5;
					}
					else
					{
						array[10] = 0;
					}
				}
				else if (num == 0 || (num >= 8 && num <= 14))
				{
					array[10] = num * 10;
				}
				else
				{
					array[10] = 0;
				}
				array[7] = (array2[1][1] >> 7 & (int)BinaryDefine.b00000001);
				array[9] = (array2[1][1] >> 6 & (int)BinaryDefine.b00000001);
				num = (int)(array2[1][1] & BinaryDefine.b00111111);
				if (array[54] == 1)
				{
					if (num == 0 || (num >= 10 && num <= 20))
					{
						array[75] = num * 5;
					}
					else
					{
						array[75] = 0;
					}
				}
				else if (num == 0 || (num >= 16 && num <= 32))
				{
					array[75] = num * 5;
				}
				else
				{
					array[75] = 0;
				}
				array[52] = (array2[1][0] >> 5 & (int)BinaryDefine.b00000111);
				num = (int)(array2[1][0] & BinaryDefine.b00011111);
				if (array[52] >= 6)
				{
					array[52] = 4;
				}
				if (num != 31)
				{
					array[76] = (int)((byte)num - 12);
					if (array[76] < -12 || array[76] > 12)
					{
						array[76] = -8;
					}
				}
				else
				{
					array[76] = -8;
				}
				array[39] = (array2[2][3] >> 5 & (int)BinaryDefine.b00000011);
				array[13] = (array2[2][3] >> 4 & (int)BinaryDefine.b00000001);
				array[40] = (array2[2][3] >> 3 & (int)BinaryDefine.b00000001);
				num = (int)(array2[2][3] & BinaryDefine.b00000111);
				switch (array[39])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[39] = 1;
					break;
				}
				if (num >= 0 && num <= 7)
				{
					array[64] = num;
				}
				else
				{
					array[64] = 2;
				}
				array[2] = (array2[2][2] >> 3 & (int)BinaryDefine.b00000111);
				array[3] = (int)(array2[2][2] & BinaryDefine.b00000111);
				if (array[2] > 7)
				{
					array[2] = 7;
				}
				if (array[3] > 7)
				{
					array[3] = 7;
				}
				array[26] = (array2[2][1] >> 6 & (int)BinaryDefine.b00000011);
				array[27] = (array2[2][1] >> 4 & (int)BinaryDefine.b00000011);
				array[38] = (array2[2][1] >> 3 & (int)BinaryDefine.b00000001);
				array[4] = (int)(array2[2][1] & BinaryDefine.b00000111);
				if (array[4] > 7)
				{
					array[4] = 7;
				}
				array[37] = (array2[2][0] >> 7 & (int)BinaryDefine.b00000001);
				array[36] = (array2[2][0] >> 6 & (int)BinaryDefine.b00000001);
				array[35] = (array2[2][0] >> 5 & (int)BinaryDefine.b00000001);
				array[34] = (array2[2][0] >> 4 & (int)BinaryDefine.b00000001);
				array[33] = (array2[2][0] >> 3 & (int)BinaryDefine.b00000001);
				array[32] = (array2[2][0] >> 2 & (int)BinaryDefine.b00000001);
				array[31] = (array2[2][0] >> 1 & (int)BinaryDefine.b00000001);
				array[30] = (int)(array2[2][0] & BinaryDefine.b00000001);
				array[20] = (array2[3][3] >> 6 & (int)BinaryDefine.b00000001);
				array[68] = (array2[3][3] >> 3 & (int)BinaryDefine.b00000111);
				array[70] = (int)(array2[3][3] & BinaryDefine.b00000111);
				switch (array[68])
				{
				default:
					array[68] = 4;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				switch (array[70])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
					break;
				default:
					array[70] = 3;
					break;
				}
				array[55] = (array2[3][2] >> 4 & (int)BinaryDefine.b00001111);
				array[56] = (int)(array2[3][2] & BinaryDefine.b00001111);
				if (array[55] > 12 || array[55] == 0)
				{
					array[55] = 1;
				}
				if (array[56] > 12 || array[56] == 0)
				{
					array[56] = 2;
				}
				array[62] = (array2[3][1] >> 4 & (int)BinaryDefine.b00001111);
				array[60] = (int)(array2[3][1] & BinaryDefine.b00001111);
				if (array[60] > 12 || array[60] == 0)
				{
					array[60] = 3;
				}
				if (array[62] > 12 || array[62] == 0)
				{
					array[62] = 4;
				}
				array[69] = (array2[3][0] >> 4 & (int)BinaryDefine.b00001111);
				array[67] = (int)(array2[3][0] & BinaryDefine.b00001111);
				if (array[69] > 12)
				{
					array[69] = 4;
				}
				if (array[67] > 8)
				{
					array[67] = 4;
				}
				array[41] = (array2[4][3] >> 7 & (int)BinaryDefine.b00000001);
				array[61] = (array2[4][3] >> 4 & (int)BinaryDefine.b00000111);
				array[58] = (int)(array2[4][3] & BinaryDefine.b00001111);
				if (array[58] > 12 || array[58] == 0)
				{
					array[58] = 2;
				}
				if (array[61] > 6 || array[61] == 0)
				{
					array[61] = 1;
				}
				array[0] = (array2[4][2] >> 7 & (int)BinaryDefine.b00000001);
				array[73] = (array2[4][2] >> 5 & (int)BinaryDefine.b00000001);
				array[50] = (array2[4][2] >> 3 & (int)BinaryDefine.b00000011);
				array[65] = (int)(array2[4][2] & BinaryDefine.b00000111);
				switch (array[50])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[50] = 1;
					break;
				}
				switch (array[65])
				{
				default:
					array[65] = 2;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				array[8] = (array2[4][1] >> 5 & (int)BinaryDefine.b00000111);
				num = (int)(array2[4][1] & BinaryDefine.b00001111);
				if (array[8] > 4)
				{
					array[8] = 1;
				}
				if (array[54] == 1)
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
				array[42] = (array2[4][0] >> 7 & (int)BinaryDefine.b00000001);
				array[85] = (array2[4][0] >> 6 & (int)BinaryDefine.b00000001);
				array[66] = (array2[4][0] >> 5 & (int)BinaryDefine.b00000001);
				array[59] = (array2[4][0] >> 1 & (int)BinaryDefine.b00001111);
				array[21] = (int)(array2[4][0] & BinaryDefine.b00000001);
				if (array[59] > 12 || array[59] == 0)
				{
					array[59] = 2;
				}
				array[89] = (array2[5][3] >> 6 & (int)BinaryDefine.b00000011);
				array[88] = (array2[5][3] >> 4 & (int)BinaryDefine.b00000011);
				array[87] = (array2[5][3] >> 2 & (int)BinaryDefine.b00000011);
				array[86] = (array2[5][3] >> 1 & (int)BinaryDefine.b00000001);
				array[18] = (int)(array2[5][3] & BinaryDefine.b00000001);
				if (array[89] > 3)
				{
					array[89] = 0;
				}
				if (array[88] > 3)
				{
					array[88] = 1;
				}
				switch (array[87])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[87] = 0;
					break;
				}
				array[93] = (array2[5][2] >> 6 & (int)BinaryDefine.b00000011);
				array[92] = (array2[5][2] >> 4 & (int)BinaryDefine.b00000011);
				array[91] = (array2[5][2] >> 2 & (int)BinaryDefine.b00000011);
				array[90] = (int)(array2[5][2] & BinaryDefine.b00000011);
				if (array[93] > 3)
				{
					array[93] = 0;
				}
				if (array[92] > 3)
				{
					array[92] = 2;
				}
				if (array[91] > 3)
				{
					array[91] = 3;
				}
				if (array[90] > 3)
				{
					array[90] = 2;
				}
				array[51] = (array2[6][3] >> 6 & (int)BinaryDefine.b00000001);
				array[46] = (array2[6][3] >> 3 & (int)BinaryDefine.b00000111);
				array[45] = (int)(array2[6][3] & BinaryDefine.b00000111);
				if (array[45] > 7)
				{
					array[45] = 0;
				}
				if (array[46] > 7)
				{
					array[46] = 0;
				}
				array[11] = (array2[6][2] >> 7 & (int)BinaryDefine.b00000001);
				array[53] = (array2[6][2] >> 6 & (int)BinaryDefine.b00000001);
				array[47] = (array2[6][2] >> 3 & (int)BinaryDefine.b00000111);
				array[48] = (int)(array2[6][2] & BinaryDefine.b00000111);
				if (array[47] > 7)
				{
					array[47] = 0;
				}
				if (array[48] > 7)
				{
					array[48] = 0;
				}
				array[74] = (array2[6][1] >> 3 & (int)BinaryDefine.b00001111);
				array[49] = (int)(array2[6][1] & BinaryDefine.b00000111);
				if (array[74] > 8)
				{
					array[74] = 1;
				}
				if (array[49] > 7)
				{
					array[49] = 0;
				}
				array[84] = (array2[6][0] >> 5 & (int)BinaryDefine.b00000111);
				array[29] = (array2[6][0] >> 4 & (int)BinaryDefine.b00000001);
				array[28] = (array2[6][0] >> 3 & (int)BinaryDefine.b00000001);
				array[57] = (int)(array2[6][0] & BinaryDefine.b00000111);
				if (array[57] > 6 || array[57] == 0)
				{
					array[57] = 6;
				}
				if (array[84] > 5 || array[84] < 1)
				{
					array[84] = 3;
				}
				array[94] = (array2[5][1] >> 3 & (int)BinaryDefine.b00000001);
				array[81] = (int)nvData[32];
				return array;
			}

			// Token: 0x060002C0 RID: 704 RVA: 0x000300B4 File Offset: 0x0002E2B4
			public byte[] GetNVDataFromUserSetting(int[] userSettingR4, byte[] receivedNVData)
			{
				if (this.menuCnt == 0)
				{
					return null;
				}
				byte[][] array = new byte[8][];
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
				array3[num] |= (byte)(userSettingR4[43] << 4 & (int)BinaryDefine.b00010000);
				byte[] array4 = array[0];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR4[44] << 1 & (int)BinaryDefine.b00001110);
				byte[] array5 = array[0];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR4[25] & (int)BinaryDefine.b00000001);
				byte[] array6 = array[0];
				int num4 = 2;
				array6[num4] |= (byte)(userSettingR4[24] << 7 & (int)BinaryDefine.b10000000);
				byte[] array7 = array[0];
				int num5 = 2;
				array7[num5] |= (byte)(userSettingR4[12] << 6 & (int)BinaryDefine.b01000000);
				byte[] array8 = array[0];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR4[14] << 5 & (int)BinaryDefine.b00100000);
				byte[] array9 = array[0];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR4[15] << 4 & (int)BinaryDefine.b00010000);
				byte[] array10 = array[0];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR4[16] << 3 & (int)BinaryDefine.b00001000);
				byte[] array11 = array[0];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR4[17] << 2 & (int)BinaryDefine.b00000100);
				byte[] array12 = array[0];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR4[22] << 1 & (int)BinaryDefine.b00000010);
				byte[] array13 = array[0];
				int num11 = 2;
				array13[num11] |= (byte)(userSettingR4[23] & (int)BinaryDefine.b00000001);
				byte[] array14 = array[0];
				int num12 = 1;
				array14[num12] |= (byte)(userSettingR4[6] << 7 & (int)BinaryDefine.b10000000);
				byte[] array15 = array[0];
				int num13 = 1;
				array15[num13] |= (byte)(userSettingR4[63] << 3 & (int)BinaryDefine.b00001000);
				byte[] array16 = array[0];
				int num14 = 1;
				array16[num14] |= (byte)(userSettingR4[71] << 2 & (int)BinaryDefine.b00000100);
				byte[] array17 = array[0];
				int num15 = 1;
				array17[num15] |= (byte)(userSettingR4[78] << 1 & (int)BinaryDefine.b00000010);
				byte[] array18 = array[0];
				int num16 = 1;
				array18[num16] |= (byte)(userSettingR4[80] & (int)BinaryDefine.b00000001);
				byte[] array19 = array[0];
				int num17 = 0;
				array19[num17] |= (byte)(userSettingR4[82] << 4 & (int)BinaryDefine.b01110000);
				byte[] array20 = array[0];
				int num18 = 0;
				array20[num18] |= (byte)(userSettingR4[83] & (int)BinaryDefine.b00001111);
				byte b;
				if (userSettingR4[54] == 1)
				{
					b = (byte)(userSettingR4[10] / 5);
				}
				else
				{
					b = (byte)(userSettingR4[10] / 10);
				}
				byte[] array21 = array[1];
				int num19 = 3;
				array21[num19] |= (byte)(userSettingR4[77] << 7 & (int)BinaryDefine.b10000000);
				byte[] array22 = array[1];
				int num20 = 3;
				array22[num20] |= (byte)(userSettingR4[79] << 6 & (int)BinaryDefine.b01000000);
				byte[] array23 = array[1];
				int num21 = 3;
				array23[num21] |= (byte)(userSettingR4[19] << 5 & (int)BinaryDefine.b00100000);
				byte[] array24 = array[1];
				int num22 = 3;
				// DECOMPILE-FIX: Restore byte narrowing for the exported bit-mask operations
				// in this file; unchecked casts preserve the original IL byte stores.
				array24[num22] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR4[54] == 1)
				{
					b = (byte)(userSettingR4[72] / 5);
				}
				else
				{
					b = (byte)(userSettingR4[72] / 5);
				}
				byte[] array25 = array[1];
				int num23 = 2;
				array25[num23] |= (byte)(userSettingR4[54] << 7 & (int)BinaryDefine.b10000000);
				byte[] array26 = array[1];
				int num24 = 2;
				array26[num24] |= (byte)(userSettingR4[1] << 5 & (int)BinaryDefine.b01100000);
				byte[] array27 = array[1];
				int num25 = 2;
				array27[num25] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR4[54] == 1)
				{
					b = (byte)(userSettingR4[75] / 5);
				}
				else
				{
					b = (byte)(userSettingR4[75] / 5);
				}
				byte[] array28 = array[1];
				int num26 = 1;
				array28[num26] |= (byte)(userSettingR4[7] << 7 & (int)BinaryDefine.b10000000);
				byte[] array29 = array[1];
				int num27 = 1;
				array29[num27] |= (byte)(userSettingR4[9] << 6 & (int)BinaryDefine.b01000000);
				byte[] array30 = array[1];
				int num28 = 1;
				array30[num28] |= unchecked((byte)(b & BinaryDefine.b00111111));
				b = (byte)(userSettingR4[76] + 12);
				byte[] array31 = array[1];
				int num29 = 0;
				array31[num29] |= (byte)(userSettingR4[52] << 5 & (int)BinaryDefine.b11100000);
				byte[] array32 = array[1];
				int num30 = 0;
				array32[num30] |= unchecked((byte)(b & BinaryDefine.b00011111));
				byte[] array33 = array[2];
				int num31 = 3;
				array33[num31] |= (byte)(userSettingR4[39] << 5 & (int)BinaryDefine.b01100000);
				byte[] array34 = array[2];
				int num32 = 3;
				array34[num32] |= (byte)(userSettingR4[13] << 4 & (int)BinaryDefine.b00010000);
				byte[] array35 = array[2];
				int num33 = 3;
				array35[num33] |= (byte)(userSettingR4[40] << 3 & (int)BinaryDefine.b00001000);
				byte[] array36 = array[2];
				int num34 = 3;
				array36[num34] |= (byte)(userSettingR4[64] & (int)BinaryDefine.b00000111);
				byte[] array37 = array[2];
				int num35 = 2;
				array37[num35] |= (byte)(userSettingR4[2] << 3 & (int)BinaryDefine.b00111000);
				byte[] array38 = array[2];
				int num36 = 2;
				array38[num36] |= (byte)(userSettingR4[3] & (int)BinaryDefine.b00000111);
				byte[] array39 = array[2];
				int num37 = 1;
				array39[num37] |= (byte)(userSettingR4[26] << 6 & (int)BinaryDefine.b11000000);
				byte[] array40 = array[2];
				int num38 = 1;
				array40[num38] |= (byte)(userSettingR4[27] << 4 & (int)BinaryDefine.b00110000);
				byte[] array41 = array[2];
				int num39 = 1;
				array41[num39] |= (byte)(userSettingR4[38] << 3 & (int)BinaryDefine.b00001000);
				byte[] array42 = array[2];
				int num40 = 1;
				array42[num40] |= (byte)(userSettingR4[4] & (int)BinaryDefine.b00000111);
				byte[] array43 = array[2];
				int num41 = 0;
				array43[num41] |= (byte)(userSettingR4[37] << 7 & (int)BinaryDefine.b10000000);
				byte[] array44 = array[2];
				int num42 = 0;
				array44[num42] |= (byte)(userSettingR4[36] << 6 & (int)BinaryDefine.b01000000);
				byte[] array45 = array[2];
				int num43 = 0;
				array45[num43] |= (byte)(userSettingR4[35] << 5 & (int)BinaryDefine.b00100000);
				byte[] array46 = array[2];
				int num44 = 0;
				array46[num44] |= (byte)(userSettingR4[34] << 4 & (int)BinaryDefine.b00010000);
				byte[] array47 = array[2];
				int num45 = 0;
				array47[num45] |= (byte)(userSettingR4[33] << 3 & (int)BinaryDefine.b00001000);
				byte[] array48 = array[2];
				int num46 = 0;
				array48[num46] |= (byte)(userSettingR4[32] << 2 & (int)BinaryDefine.b00000100);
				byte[] array49 = array[2];
				int num47 = 0;
				array49[num47] |= (byte)(userSettingR4[31] << 1 & (int)BinaryDefine.b00000010);
				byte[] array50 = array[2];
				int num48 = 0;
				array50[num48] |= (byte)(userSettingR4[30] & (int)BinaryDefine.b00000001);
				byte[] array51 = array[3];
				int num49 = 3;
				array51[num49] |= (byte)(userSettingR4[20] << 6 & (int)BinaryDefine.b01000000);
				byte[] array52 = array[3];
				int num50 = 3;
				array52[num50] |= (byte)(userSettingR4[68] << 3 & (int)BinaryDefine.b00111000);
				byte[] array53 = array[3];
				int num51 = 3;
				array53[num51] |= (byte)(userSettingR4[70] & (int)BinaryDefine.b00000111);
				byte[] array54 = array[3];
				int num52 = 2;
				array54[num52] |= (byte)(userSettingR4[55] << 4 & (int)BinaryDefine.b11110000);
				byte[] array55 = array[3];
				int num53 = 2;
				array55[num53] |= (byte)(userSettingR4[56] & (int)BinaryDefine.b00001111);
				byte[] array56 = array[3];
				int num54 = 1;
				array56[num54] |= (byte)(userSettingR4[62] << 4 & (int)BinaryDefine.b11110000);
				byte[] array57 = array[3];
				int num55 = 1;
				array57[num55] |= (byte)(userSettingR4[60] & (int)BinaryDefine.b00001111);
				byte[] array58 = array[3];
				int num56 = 0;
				array58[num56] |= (byte)(userSettingR4[69] << 4 & (int)BinaryDefine.b11110000);
				byte[] array59 = array[3];
				int num57 = 0;
				array59[num57] |= (byte)(userSettingR4[67] & (int)BinaryDefine.b00001111);
				byte[] array60 = array[4];
				int num58 = 3;
				array60[num58] |= (byte)(userSettingR4[41] << 7 & (int)BinaryDefine.b10000000);
				byte[] array61 = array[4];
				int num59 = 3;
				array61[num59] |= (byte)(userSettingR4[61] << 4 & (int)BinaryDefine.b01110000);
				byte[] array62 = array[4];
				int num60 = 3;
				array62[num60] |= (byte)(userSettingR4[58] & (int)BinaryDefine.b00001111);
				byte[] array63 = array[4];
				int num61 = 2;
				array63[num61] |= (byte)(userSettingR4[0] << 7 & (int)BinaryDefine.b10000000);
				byte[] array64 = array[4];
				int num62 = 2;
				array64[num62] |= (byte)(userSettingR4[73] << 5 & (int)BinaryDefine.b00100000);
				byte[] array65 = array[4];
				int num63 = 2;
				array65[num63] |= (byte)(userSettingR4[50] << 3 & (int)BinaryDefine.b00011000);
				byte[] array66 = array[4];
				int num64 = 2;
				array66[num64] |= (byte)(userSettingR4[65] & (int)BinaryDefine.b00000111);
				if (userSettingR4[54] == 1)
				{
					b = (byte)(userSettingR4[5] / 5);
				}
				else
				{
					b = (byte)(userSettingR4[5] / 10);
				}
				byte[] array67 = array[4];
				int num65 = 1;
				array67[num65] |= (byte)(userSettingR4[8] << 5 & (int)BinaryDefine.b11100000);
				byte[] array68 = array[4];
				int num66 = 1;
				array68[num66] |= unchecked((byte)(b & BinaryDefine.b00001111));
				byte[] array69 = array[4];
				int num67 = 0;
				array69[num67] |= (byte)(userSettingR4[42] << 7 & (int)BinaryDefine.b10000000);
				byte[] array70 = array[4];
				int num68 = 0;
				array70[num68] |= (byte)(userSettingR4[85] << 6 & (int)BinaryDefine.b01000000);
				byte[] array71 = array[4];
				int num69 = 0;
				array71[num69] |= (byte)(userSettingR4[66] << 5 & (int)BinaryDefine.b00100000);
				byte[] array72 = array[4];
				int num70 = 0;
				array72[num70] |= (byte)(userSettingR4[59] << 1 & (int)BinaryDefine.b00011110);
				byte[] array73 = array[4];
				int num71 = 0;
				array73[num71] |= (byte)(userSettingR4[21] & (int)BinaryDefine.b00000001);
				byte[] array74 = array[5];
				int num72 = 3;
				array74[num72] |= (byte)(userSettingR4[89] << 6 & (int)BinaryDefine.b11000000);
				byte[] array75 = array[5];
				int num73 = 3;
				array75[num73] |= (byte)(userSettingR4[88] << 4 & (int)BinaryDefine.b00110000);
				byte[] array76 = array[5];
				int num74 = 3;
				array76[num74] |= (byte)(userSettingR4[87] << 2 & (int)BinaryDefine.b00001100);
				byte[] array77 = array[5];
				int num75 = 3;
				array77[num75] |= (byte)(userSettingR4[86] << 1 & (int)BinaryDefine.b00000010);
				byte[] array78 = array[5];
				int num76 = 3;
				array78[num76] |= (byte)(userSettingR4[18] & (int)BinaryDefine.b00000001);
				byte[] array79 = array[5];
				int num77 = 2;
				array79[num77] |= (byte)(userSettingR4[93] << 6 & (int)BinaryDefine.b11000000);
				byte[] array80 = array[5];
				int num78 = 2;
				array80[num78] |= (byte)(userSettingR4[92] << 4 & (int)BinaryDefine.b00110000);
				byte[] array81 = array[5];
				int num79 = 2;
				array81[num79] |= (byte)(userSettingR4[91] << 2 & (int)BinaryDefine.b00001100);
				byte[] array82 = array[5];
				int num80 = 2;
				array82[num80] |= (byte)(userSettingR4[90] & (int)BinaryDefine.b00000011);
				byte[] array83 = array[6];
				int num81 = 3;
				array83[num81] |= (byte)(userSettingR4[51] << 6 & (int)BinaryDefine.b01000000);
				byte[] array84 = array[6];
				int num82 = 3;
				array84[num82] |= (byte)(userSettingR4[46] << 3 & (int)BinaryDefine.b00111000);
				byte[] array85 = array[6];
				int num83 = 3;
				array85[num83] |= (byte)(userSettingR4[45] & (int)BinaryDefine.b00000111);
				byte[] array86 = array[6];
				int num84 = 2;
				array86[num84] |= (byte)(userSettingR4[11] << 7 & (int)BinaryDefine.b10000000);
				byte[] array87 = array[6];
				int num85 = 2;
				array87[num85] |= (byte)(userSettingR4[53] << 6 & (int)BinaryDefine.b01000000);
				byte[] array88 = array[6];
				int num86 = 2;
				array88[num86] |= (byte)(userSettingR4[47] << 3 & (int)BinaryDefine.b00111000);
				byte[] array89 = array[6];
				int num87 = 2;
				array89[num87] |= (byte)(userSettingR4[48] & (int)BinaryDefine.b00000111);
				byte[] array90 = array[6];
				int num88 = 1;
				array90[num88] |= (byte)(userSettingR4[74] << 3 & (int)BinaryDefine.b01111000);
				byte[] array91 = array[6];
				int num89 = 1;
				array91[num89] |= (byte)(userSettingR4[49] & (int)BinaryDefine.b00000111);
				byte[] array92 = array[6];
				int num90 = 0;
				array92[num90] |= (byte)(userSettingR4[84] << 5 & (int)BinaryDefine.b11100000);
				byte[] array93 = array[6];
				int num91 = 0;
				array93[num91] |= (byte)(userSettingR4[29] << 4 & (int)BinaryDefine.b00010000);
				byte[] array94 = array[6];
				int num92 = 0;
				array94[num92] |= (byte)(userSettingR4[28] << 3 & (int)BinaryDefine.b00001000);
				byte[] array95 = array[6];
				int num93 = 0;
				array95[num93] |= (byte)(userSettingR4[57] & (int)BinaryDefine.b00000111);
				array[5][1] |= (byte)(userSettingR4[94] << 3 & (int)BinaryDefine.b00001000);
				Array.Copy(receivedNVData, array2, receivedNVData.Length);
				for (int i = 0; i < array.Length; i++)
				{
					for (int j = 0; j < array[i].Length; j++)
					{
						byte[] array96 = array2;
						int num94 = i * 4 + j;
						array96[num94] &= unchecked((byte)(~UserSettingR4NZ.v128.userNVDataPos[i * 4 + j]));
						byte[] array97 = array2;
						int num95 = i * 4 + j;
						array97[num95] |= array[i][j];
					}
				}
				array2[32] = (byte)userSettingR4[81];
				int num96 = 0;
				for (int i = 0; i < receivedNVData.Length; i++)
				{
					if (receivedNVData[i] != array2[i])
					{
						num96++;
					}
				}
				return array2;
			}

			// Token: 0x0400053B RID: 1339
			private int supportVersion = 128;

			// Token: 0x0400053C RID: 1340
			private int menuCnt = 95;

			// Token: 0x0400053D RID: 1341
			private static byte[] userNVDataPos = new byte[]
			{
				127,
				143,
				byte.MaxValue,
				31,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				63,
				127,
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				239,
				191,
				byte.MaxValue,
				0,
				8, // NV byte 21: own only M.Cam bit 3 (0x08).
				byte.MaxValue,
				byte.MaxValue,
				byte.MaxValue,
				127,
				byte.MaxValue,
				127,
				0,
				0,
				0,
				0
			};

			// Token: 0x0400053E RID: 1342
			private const int memoryQuotaPos = 32;

			// Token: 0x0400053F RID: 1343
			private const int RD_1 = 0;

			// Token: 0x04000540 RID: 1344
			private const int GPS = 1;

			// Token: 0x04000541 RID: 1345
			private const int RD_2 = 2;

			// Token: 0x04000542 RID: 1346
			private const int RD_3 = 3;

			// Token: 0x04000543 RID: 1347
			private const int RD_4 = 4;

			// Token: 0x04000544 RID: 1348
			private const int RD_5 = 5;

			// Token: 0x04000545 RID: 1349
			private const int RD_6 = 6;

			// Token: 0x04000546 RID: 1350
			private const int RD_7 = 7;

			// Token: 0x04000547 RID: 1351
			private const int ADDR_CNT = 8;

			// Token: 0x020000B5 RID: 181
			private enum MENU
			{
				// Token: 0x040007DC RID: 2012
				MENU_MODE,
				// Token: 0x040007DD RID: 2013
				DETECTION_MODE,
				// Token: 0x040007DE RID: 2014
				X_SENSITIVE,
				// Token: 0x040007DF RID: 2015
				K_SENSITIVE,
				// Token: 0x040007E0 RID: 2016
				KA_SENSITIVE,
				// Token: 0x040007E1 RID: 2017
				AUTO_CITY_SPEED,
				// Token: 0x040007E2 RID: 2018
				GPS_ENABLE,
				// Token: 0x040007E3 RID: 2019
				SPEED_CAMERA_ENABLE,
				// Token: 0x040007E4 RID: 2020
				SPEED_CAMERA_ALERT_RANGE,
				// Token: 0x040007E5 RID: 2021
				RLC_ENABLE,
				// Token: 0x040007E6 RID: 2022
				RLC_QRIDE,
				// Token: 0x040007E7 RID: 2023
				POI_PASSCHIME,
				// Token: 0x040007E8 RID: 2024
				VOICE_ENABLE,
				// Token: 0x040007E9 RID: 2025
				KA_FREQ_VOICE,
				// Token: 0x040007EA RID: 2026
				X_BAND_ENABLE,
				// Token: 0x040007EB RID: 2027
				K_BAND_ENABLE,
				// Token: 0x040007EC RID: 2028
				KA_BAND_ENABLE,
				// Token: 0x040007ED RID: 2029
				LASER_ENABLE,
				// Token: 0x040007EE RID: 2030
				LASER_GUN_ID_ENABLE,
				// Token: 0x040007EF RID: 2031
				K_POP_ENABLE,
				// Token: 0x040007F0 RID: 2032
				MRCD_ENABLE,
				// Token: 0x040007F1 RID: 2033
				GATSO_ENABLE,
				// Token: 0x040007F2 RID: 2034
				KA_POP_ENABLE,
				// Token: 0x040007F3 RID: 2035
				K_FILTER_ENABLE,
				// Token: 0x040007F4 RID: 2036
				KA_FILTER_ENABLE,
				// Token: 0x040007F5 RID: 2037
				TSF_ENABLE,
				// Token: 0x040007F6 RID: 2038
				K_BLOCK_FILTER_1_MODE,
				// Token: 0x040007F7 RID: 2039
				K_BLOCK_FILTER_2_MODE,
				// Token: 0x040007F8 RID: 2040
				K_BAND_1,
				// Token: 0x040007F9 RID: 2041
				K_BAND_2,
				// Token: 0x040007FA RID: 2042
				KA_SEG1,
				// Token: 0x040007FB RID: 2043
				KA_SEG2,
				// Token: 0x040007FC RID: 2044
				KA_SEG3,
				// Token: 0x040007FD RID: 2045
				KA_SEG4,
				// Token: 0x040007FE RID: 2046
				KA_SEG5,
				// Token: 0x040007FF RID: 2047
				KA_SEG6,
				// Token: 0x04000800 RID: 2048
				KA_SEG7,
				// Token: 0x04000801 RID: 2049
				KA_SEG8,
				// Token: 0x04000802 RID: 2050
				KA_SEG9,
				// Token: 0x04000803 RID: 2051
				PRIORITY_MODE,
				// Token: 0x04000804 RID: 2052
				MUTE_MEM_BAND_OPTION,
				// Token: 0x04000805 RID: 2053
				AUTO_MUTE_MEM_ENABLE,
				// Token: 0x04000806 RID: 2054
				AUTO_MUTE_MEM_BAND_OPTION,
				// Token: 0x04000807 RID: 2055
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x04000808 RID: 2056
				BACKGROUND_COLOR,
				// Token: 0x04000809 RID: 2057
				X_BAND_COLOR,
				// Token: 0x0400080A RID: 2058
				K_BAND_COLOR,
				// Token: 0x0400080B RID: 2059
				MRCD_COLOR,
				// Token: 0x0400080C RID: 2060
				GATSO_COLOR,
				// Token: 0x0400080D RID: 2061
				KA_BAND_COLOR,
				// Token: 0x0400080E RID: 2062
				MAIN_DISPLAY,
				// Token: 0x0400080F RID: 2063
				HEARTBEAT_ICON_ENABLE,
				// Token: 0x04000810 RID: 2064
				LEFT_DISPLAY,
				// Token: 0x04000811 RID: 2065
				ALERT_DISPLAY,
				// Token: 0x04000812 RID: 2066
				SPEED_UNIT,
				// Token: 0x04000813 RID: 2067
				X_BAND_ALERT_TONE,
				// Token: 0x04000814 RID: 2068
				K_BAND_ALERT_TONE,
				// Token: 0x04000815 RID: 2069
				K_BAND_BOGEY_TONE,
				// Token: 0x04000816 RID: 2070
				MRCD_ALERT_TONE,
				// Token: 0x04000817 RID: 2071
				GATSO_ALERT_TONE,
				// Token: 0x04000818 RID: 2072
				KA_BAND_ALERT_TONE,
				// Token: 0x04000819 RID: 2073
				KA_BAND_BOGEY_TONE,
				// Token: 0x0400081A RID: 2074
				LASER_ALERT_TONE,
				// Token: 0x0400081B RID: 2075
				AUTO_MUTE_ENABLE,
				// Token: 0x0400081C RID: 2076
				AUTO_MUTE_VOLUME,
				// Token: 0x0400081D RID: 2077
				DARK_MODE_BRIGHTNESS,
				// Token: 0x0400081E RID: 2078
				AUTO_DIM_SET_MODE_SELECT,
				// Token: 0x0400081F RID: 2079
				AUTO_DIM_SET_BRIGHT_TIME,
				// Token: 0x04000820 RID: 2080
				AUTO_DIM_SET_BRIGHT_BRIGHTNESS,
				// Token: 0x04000821 RID: 2081
				AUTO_DIM_SET_DIM_TIME,
				// Token: 0x04000822 RID: 2082
				AUTO_DIM_SET_DIM_BRIGHTNESS,
				// Token: 0x04000823 RID: 2083
				BACKLIGHT_MODE,
				// Token: 0x04000824 RID: 2084
				QRIDE_MODE,
				// Token: 0x04000825 RID: 2085
				MRCD_QRIDE_ENABLE,
				// Token: 0x04000826 RID: 2086
				QRIDE_VOLUME,
				// Token: 0x04000827 RID: 2087
				LIMIT_SPEED_MODE,
				// Token: 0x04000828 RID: 2088
				GMT,
				// Token: 0x04000829 RID: 2089
				DST_ENABLE,
				// Token: 0x0400082A RID: 2090
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x0400082B RID: 2091
				VEHICLE_BATT_SAVER_ENABLE,
				// Token: 0x0400082C RID: 2092
				SELF_TEST_ENABLE,
				// Token: 0x0400082D RID: 2093
				MEMORY_QUOTA,
				// Token: 0x0400082E RID: 2094
				MAIN_DIM_SET,
				// Token: 0x0400082F RID: 2095
				MAIN_VOLUME,
				// Token: 0x04000830 RID: 2096
				K_BAND_BOGEY_LEVEL,
				// Token: 0x04000831 RID: 2097
				BLUETOOTH_MODE,
				// Token: 0x04000832 RID: 2098
				LASER_JAMMER_INTERFACE_MODE,
				// Token: 0x04000833 RID: 2099
				LASER_JAMMING_MODE,
				// Token: 0x04000834 RID: 2100
				LASER_TP1_SETTING_MODE,
				// Token: 0x04000835 RID: 2101
				LASER_TP2_SETTING_MODE,
				// Token: 0x04000836 RID: 2102
				LASER_TP3_SETTING_MODE,
				// Token: 0x04000837 RID: 2103
				LASER_TP4_SETTING_MODE,
				// Token: 0x04000838 RID: 2104
				LASER_TP5_SETTING_MODE,
				// Token: 0x04000839 RID: 2105
				LASER_TP6_SETTING_MODE,
				MCAM_ENABLE = 94
			}
		}
	}
}
