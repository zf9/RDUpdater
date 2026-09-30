using System;
using System.Linq;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200002C RID: 44
	internal static class UserSettingR8NZ
	{
		// Token: 0x04000392 RID: 914
		public static UserSettingFormat[] user_setting = new UserSettingFormat[]
		{
			new UserSettingR8NZ.v126()
		};

		// Token: 0x02000097 RID: 151
		private class v126 : UserSettingFormat
		{
			// Token: 0x06000325 RID: 805 RVA: 0x0004D297 File Offset: 0x0004B497
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x06000326 RID: 806 RVA: 0x0004D29F File Offset: 0x0004B49F
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x06000327 RID: 807 RVA: 0x0004D2A7 File Offset: 0x0004B4A7
			public byte[] GetNVDataMask()
			{
				return this.userNVDataPos;
			}

			// Token: 0x06000328 RID: 808 RVA: 0x00024E4C File Offset: 0x0002304C
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return false;
			}

			// Token: 0x06000329 RID: 809 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_level(int strength, int mode)
			{
				return -1;
			}

			// Token: 0x0600032A RID: 810 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_raw_strength(int level, int mode)
			{
				return -1;
			}

			// Token: 0x0600032B RID: 811 RVA: 0x0004D2B0 File Offset: 0x0004B4B0
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
				array[20] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to use the external laser transponder interface.");
				array[21] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP Mode", new int[]
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
				array[22] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP1 Setting", new int[]
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
				array[23] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP2 Setting", new int[]
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
				array[24] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP3 Setting", new int[]
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
				array[25] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP4 Setting", new int[]
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
				array[26] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP5 Setting", new int[]
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
				array[27] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser TP6 Setting", new int[]
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
				int num2 = 28;
				UserSettingMenu.MENU_TYPE menuType2 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString2 = "K POP On/Off";
				int[] array5 = new int[2];
				array5[0] = 1;
				array4[num2] = new UserSettingMenu(menuType2, menuString2, array5, new string[]
				{
					"Off",
					"On"
				}, "Detects K POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[29] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "MRCD/T On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates MultaRadar CD/CT low - powered radar gun detection.");
				UserSettingMenu[] array6 = array;
				int num3 = 30;
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
				int num4 = 31;
				UserSettingMenu.MENU_TYPE menuType4 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString4 = "Ka POP On/Off";
				int[] array9 = new int[2];
				array9[0] = 1;
				array8[num4] = new UserSettingMenu(menuType4, menuString4, array9, new string[]
				{
					"Off",
					"On"
				}, "Detects Ka POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[32] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Filter", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the K band to prevent false detections.");
				UserSettingMenu[] array10 = array;
				int num5 = 33;
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
				int num6 = 34;
				UserSettingMenu.MENU_TYPE menuType6 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString6 = "TSF";
				int[] array13 = new int[2];
				array13[0] = 1;
				array12[num6] = new UserSettingMenu(menuType6, menuString6, array13, new string[]
				{
					"Off",
					"On"
				}, "Traffic Sensor Filter. Prevents false alarms caused by traffic monitoring radar systems.");
				array[35] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block1 Filter 24.199Ghz (± 0.005)", new int[]
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
				array[36] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Block2 Filter 24.168Ghz (± 0.002)", new int[]
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
				array[37] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Band 1 : 23.900Ghz ~ 24.100Ghz", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "K band sweep 23.900Ghz – 24.100Ghz");
				UserSettingMenu[] array14 = array;
				int num7 = 38;
				UserSettingMenu.MENU_TYPE menuType7 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString7 = "K Band 2 : 24.100Ghz ~ 24.250Ghz";
				int[] array15 = new int[2];
				array15[0] = 1;
				array14[num7] = new UserSettingMenu(menuType7, menuString7, array15, new string[]
				{
					"Off",
					"On"
				}, "K band sweep 24.100Ghz – 24.250Gh");
				UserSettingMenu[] array16 = array;
				int num8 = 39;
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
				int num9 = 40;
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
				int num10 = 41;
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
				int num11 = 42;
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
				int num12 = 43;
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
				int num13 = 44;
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
				int num14 = 45;
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
				int num15 = 46;
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
				int num16 = 47;
				UserSettingMenu.MENU_TYPE menuType16 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString16 = "Ka Segmentation 35.613Ghz – 35.701Ghz";
				int[] array33 = new int[2];
				array33[0] = 1;
				array32[num16] = new UserSettingMenu(menuType16, menuString16, array33, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.613Ghz – 35.701Ghz (Ka Segmentation mode)");
				array[48] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Priority", new int[]
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
				array[49] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Select bands to be muted.");
				array[50] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute Memory On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "This menu turns the ability to automatically save mute requests for specific locations/frequency bands.");
				array[51] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Auto Mute Memory Band Option", new int[]
				{
					0,
					1
				}, new string[]
				{
					"X K",
					"X K Ka"
				}, "Auto Mute Memory Band Option Set specifies which bands will be muted.");
				UserSettingMenu[] array34 = array;
				int num17 = 52;
				UserSettingMenu.MENU_TYPE menuType17 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString17 = "All Threat Display";
				int[] array35 = new int[2];
				array35[0] = 1;
				array34[num17] = new UserSettingMenu(menuType17, menuString17, array35, new string[]
				{
					"Off",
					"On"
				}, "Displays if more than one radar signals are detected at the same time. The signal with the strongest radar signal is considered the main signal. The other signals are displayed on the left side.");
				array[53] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Background Color", new int[]
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
				array[54] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Arrow Color", new int[]
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
				array[55] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Arrow Color", new int[]
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
				array[56] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD/T Arrow Color", new int[]
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
				array[57] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "GATSO RT3/4 Arrow Color", new int[]
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
				array[58] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Arrow Color", new int[]
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
				array[59] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "X Band Color", new int[]
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
				array[60] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "K Band Color", new int[]
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
				array[61] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "MRCD/T Color", new int[]
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
				array[62] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Gatso RT3/4 Color", new int[]
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
				array[63] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Ka Band Color", new int[]
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
				array[64] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Display", new int[]
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
				int num18 = 65;
				UserSettingMenu.MENU_TYPE menuType18 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString18 = "Scan Icon";
				int[] array37 = new int[2];
				array37[0] = 1;
				array36[num18] = new UserSettingMenu(menuType18, menuString18, array37, new string[]
				{
					"Off",
					"On"
				}, "Scan Icon displays to indicate the end of a scan cycle.");
				array[66] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Left Display", new int[]
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
				array[67] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Alert Display", new int[]
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
				int num19 = 68;
				UserSettingMenu.MENU_TYPE menuType19 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString19 = "Speed Unit";
				int[] array39 = new int[2];
				array39[0] = 1;
				array38[num19] = new UserSettingMenu(menuType19, menuString19, array39, new string[]
				{
					"mph",
					"km/h"
				}, "Select the speed measurement type.");
				array[68].isUnitMenuFlag = true;
				array[69] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "X Band Alert Tone", new int[]
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
				array[70] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Alert Tone", new int[]
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
				array[71] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Tone", new int[]
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
				array[73] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "MRCD/T Alert Tone", new int[]
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
				array[74] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "GATSO RT3/4 Alert Tone", new int[]
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
				array[75] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Alert Tone", new int[]
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
				array[76] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Bogey Tone", new int[]
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
				array[72] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Bogey Level", new int[]
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
				array[77] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Laser Alert Tone", new int[]
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
				array[78] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Auto Mute reduces alarm level to 1 after 3 seconds and returns to normal operation(Auto Mute = OFF) 10 seconds after the alert ends.If the same alarm sounds within the 10 second period, Auto Mute remains at level 1.The unit returns to normal operation(Auto Mute = OFF) if a different band is detected during Auto Mute = ON mode.");
				array[79] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Volume", new int[]
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
				int num20 = 80;
				UserSettingMenu.MENU_TYPE menuType20 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString20 = "Rear K Band Mute";
				int[] array41 = new int[2];
				array41[0] = 1;
				array40[num20] = new UserSettingMenu(menuType20, menuString20, array41, new string[]
				{
					"Off",
					"On"
				}, "Mutes K band signals from rear side.");
				array[81] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Dark mode Brightness", new int[]
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
				array[82] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Mode", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Time",
					"Sensor"
				}, "Set the start times for the OLED to automatically brighten or dim.\nSelecting Time will let you set specific times when you want the OLED to get brighter or dimmer.\nSelecting Sensor will let the ambient light levels trigger when the OLED will get brighter or dimmer.");
				array[83] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Time", new int[]
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
				array[84] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Bright Brightness", new int[]
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
				array[85] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Time", new int[]
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
				array[86] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Auto Dim Set Dim Brightness", new int[]
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
				array[87] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Backlight On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns the front key backlight on and off.");
				array[88] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Quiet Ride", new int[][]
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
				UserSettingMenu[] array42 = array;
				int num21 = 89;
				UserSettingMenu.MENU_TYPE menuType21 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString21 = "Quiet Ride MRCD On/Off";
				int[] array43 = new int[2];
				array43[0] = 1;
				array42[num21] = new UserSettingMenu(menuType21, menuString21, array43, new string[]
				{
					"Off",
					"On"
				}, "Mutes MRCD/T alarms when users drive under the speed limit set previously.");
				array[90] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Quiet Ride Volume", new int[]
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
				array[91] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.GPS, UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT, "Limit Speed", new int[][]
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
				array[92] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "GMT", new int[]
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
				UserSettingMenu[] array44 = array;
				int num22 = 93;
				UserSettingMenu.MENU_TYPE menuType22 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString22 = "DST";
				int[] array45 = new int[2];
				array45[0] = 1;
				array44[num22] = new UserSettingMenu(menuType22, menuString22, array45, new string[]
				{
					"Off",
					"On"
				}, "Daylight Saving Time");
				UserSettingMenu[] array46 = array;
				int num23 = 94;
				UserSettingMenu.MENU_TYPE menuType23 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString23 = "Low Battery Warning";
				int[] array47 = new int[2];
				array47[0] = 1;
				array46[num23] = new UserSettingMenu(menuType23, menuString23, array47, new string[]
				{
					"Off",
					"On"
				}, "Sounds a warning tone if the vehicle battery power drops below 11V.");
				UserSettingMenu[] array48 = array;
				int num24 = 95;
				UserSettingMenu.MENU_TYPE menuType24 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString24 = "Vehicle Battery Saver";
				int[] array49 = new int[2];
				array49[0] = 1;
				array48[num24] = new UserSettingMenu(menuType24, menuString24, array49, new string[]
				{
					"Off",
					"On"
				}, "Turns off power to the R8 if the speed stays at 0 or if the GPS is not connected for more than an hour.");
				array[96] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Self Test", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Runs a self diagnostic test on the unit to check for faults.");
				array[97] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Memory Quota", new int[]
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
				array[98] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Dim", new int[]
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
				array[99] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Main Volume", new int[]
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
				array[100] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Bluetooth", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn on to connect applications that support the radar detector.");
				return array;
			}

			// Token: 0x0600032C RID: 812 RVA: 0x0004F6DC File Offset: 0x0004D8DC
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
				array[53] = (array2[2][3] >> 2 & (int)BinaryDefine.b00000111);
				array[52] = (array2[2][3] >> 1 & (int)BinaryDefine.b00000001);
				array[34] = (int)(array2[2][3] & BinaryDefine.b00000001);
				switch (array[53])
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
					array[53] = 5;
					break;
				}
				array[33] = (array2[2][2] >> 7 & (int)BinaryDefine.b00000001);
				array[13] = (array2[2][2] >> 6 & (int)BinaryDefine.b00000001);
				array[15] = (array2[2][2] >> 5 & (int)BinaryDefine.b00000001);
				array[16] = (array2[2][2] >> 4 & (int)BinaryDefine.b00000001);
				array[17] = (array2[2][2] >> 3 & (int)BinaryDefine.b00000001);
				array[18] = (array2[2][2] >> 2 & (int)BinaryDefine.b00000001);
				array[31] = (array2[2][2] >> 1 & (int)BinaryDefine.b00000001);
				array[7] = (array2[2][1] >> 7 & (int)BinaryDefine.b00000001);
				array[78] = (array2[2][1] >> 3 & (int)BinaryDefine.b00000001);
				array[87] = (array2[2][1] >> 2 & (int)BinaryDefine.b00000001);
				array[94] = (array2[2][1] >> 1 & (int)BinaryDefine.b00000001);
				array[96] = (int)(array2[2][1] & BinaryDefine.b00000001);
				array[98] = (array2[2][0] >> 4 & (int)BinaryDefine.b00000111);
				array[99] = (int)(array2[2][0] & BinaryDefine.b00001111);
				switch (array[98])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
					break;
				default:
					array[98] = 5;
					break;
				}
				if (array[99] < 0 || array[99] > 8)
				{
					array[99] = 4;
				}
				array[68] = (array2[1][2] >> 7 & (int)BinaryDefine.b00000001);
				array[93] = (array2[1][2] >> 5 & (int)BinaryDefine.b00000001);
				int num = (int)(array2[1][2] & BinaryDefine.b00011111);
				if (array[68] == 1)
				{
					if (num >= 0 && num <= 18)
					{
						array[88] = num * 5;
					}
					else
					{
						array[88] = 0;
					}
				}
				else if (num >= 0 && num <= 14)
				{
					array[88] = num * 10;
				}
				else
				{
					array[88] = 0;
				}
				array[95] = (array2[1][3] >> 6 & (int)BinaryDefine.b00000001);
				array[28] = (array2[1][3] >> 5 & (int)BinaryDefine.b00000001);
				num = (int)(array2[1][3] & BinaryDefine.b00011111);
				if (array[68] == 1)
				{
					if (num == 0 || (num >= 5 && num <= 17))
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
				int num2 = array2[1][1] >> 7 & (int)BinaryDefine.b00000001;
				array[8] = (array2[1][1] >> 6 & (int)BinaryDefine.b00000001);
				array[10] = (array2[1][1] >> 5 & (int)BinaryDefine.b00000001);
				num = (int)(array2[1][1] & BinaryDefine.b00011111);
				if (array[68] == 1)
				{
					if (num == 0 || (num >= 10 && num <= 20))
					{
						array[91] = num * 5;
					}
					else
					{
						array[91] = 0;
					}
				}
				else if (num2 == 1)
				{
					if (num == 0 || (num >= 8 && num <= 16))
					{
						array[91] = num * 10;
					}
					else
					{
						array[91] = 0;
					}
				}
				else if (num >= 17 && num <= 31)
				{
					array[91] = num * 5;
				}
				else
				{
					array[91] = 0;
				}
				array[66] = (array2[1][0] >> 5 & (int)BinaryDefine.b00000111);
				num = (int)(array2[1][0] & BinaryDefine.b00011111);
				if (array[66] >= 6)
				{
					if (array[7] == 1)
					{
						array[66] = 4;
					}
					else
					{
						array[66] = 2;
					}
				}
				if (num != 31)
				{
					array[92] = (int)((byte)num - 12);
					if (array[92] < -12 || array[92] > 12)
					{
						array[92] = -8;
					}
				}
				else
				{
					array[92] = -8;
				}
				array[49] = (array2[3][3] >> 6 & (int)BinaryDefine.b00000001);
				array[14] = (array2[3][3] >> 5 & (int)BinaryDefine.b00000001);
				array[48] = (array2[3][3] >> 3 & (int)BinaryDefine.b00000011);
				array[79] = (int)(array2[3][3] & BinaryDefine.b00000111);
				if (array[79] < 0 || array[79] > 7)
				{
					array[79] = 2;
				}
				array[29] = (array2[3][2] >> 7 & (int)BinaryDefine.b00000001);
				array[2] = (array2[3][2] >> 3 & (int)BinaryDefine.b00000111);
				array[3] = (int)(array2[3][2] & BinaryDefine.b00000111);
				array[35] = (array2[3][1] >> 6 & (int)BinaryDefine.b00000011);
				array[47] = (array2[3][1] >> 3 & (int)BinaryDefine.b00000001);
				array[4] = (int)(array2[3][1] & BinaryDefine.b00000111);
				array[46] = (array2[3][0] >> 7 & (int)BinaryDefine.b00000001);
				array[45] = (array2[3][0] >> 6 & (int)BinaryDefine.b00000001);
				array[44] = (array2[3][0] >> 5 & (int)BinaryDefine.b00000001);
				array[43] = (array2[3][0] >> 4 & (int)BinaryDefine.b00000001);
				array[42] = (array2[3][0] >> 3 & (int)BinaryDefine.b00000001);
				array[41] = (array2[3][0] >> 2 & (int)BinaryDefine.b00000001);
				array[40] = (array2[3][0] >> 1 & (int)BinaryDefine.b00000001);
				array[39] = (int)(array2[3][0] & BinaryDefine.b00000001);
				array[82] = (array2[4][3] >> 6 & (int)BinaryDefine.b00000001);
				array[84] = (array2[4][3] >> 3 & (int)BinaryDefine.b00000111);
				array[86] = (int)(array2[4][3] & BinaryDefine.b00000111);
				switch (array[84])
				{
				default:
					array[84] = 4;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				switch (array[86])
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
					break;
				default:
					array[86] = 4;
					break;
				}
				array[69] = (array2[4][2] >> 4 & (int)BinaryDefine.b00001111);
				array[70] = (int)(array2[4][2] & BinaryDefine.b00001111);
				array[77] = (array2[4][1] >> 4 & (int)BinaryDefine.b00001111);
				array[75] = (int)(array2[4][1] & BinaryDefine.b00001111);
				array[76] = (array2[5][3] >> 4 & (int)BinaryDefine.b00000111);
				array[73] = (int)(array2[5][3] & BinaryDefine.b00001111);
				array[50] = (array2[5][2] >> 5 & (int)BinaryDefine.b00000001);
				array[37] = (array2[5][2] >> 4 & (int)BinaryDefine.b00000001);
				array[38] = (array2[5][2] >> 3 & (int)BinaryDefine.b00000001);
				array[81] = (int)(array2[5][2] & BinaryDefine.b00000111);
				switch (array[81])
				{
				default:
					array[81] = 2;
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				array[51] = (array2[5][1] >> 7 & (int)BinaryDefine.b00000001);
				array[55] = (array2[5][1] >> 3 & (int)BinaryDefine.b00000111);
				array[54] = (int)(array2[5][1] & BinaryDefine.b00000111);
				if (array[55] > 6)
				{
					array[55] = 0;
				}
				if (array[54] > 6)
				{
					array[54] = 0;
				}
				array[0] = (array2[5][0] >> 7 & (int)BinaryDefine.b00000001);
				array[89] = (array2[5][0] >> 6 & (int)BinaryDefine.b00000001);
				array[58] = (array2[5][0] >> 3 & (int)BinaryDefine.b00000111);
				array[56] = (int)(array2[5][0] & BinaryDefine.b00000111);
				if (array[58] > 6)
				{
					array[58] = 0;
				}
				if (array[56] > 6)
				{
					array[56] = 0;
				}
				if (array[69] > 12 || array[69] == 0)
				{
					array[69] = 1;
				}
				if (array[70] > 12 || array[70] == 0)
				{
					array[70] = 2;
				}
				if (array[73] > 12 || array[73] == 0)
				{
					array[73] = 2;
				}
				if (array[75] > 12 || array[75] == 0)
				{
					array[75] = 3;
				}
				if (array[76] > 6 || array[76] == 0)
				{
					array[76] = 1;
				}
				if (array[77] > 12 || array[77] == 0)
				{
					array[77] = 4;
				}
				array[60] = (array2[6][3] >> 4 & (int)BinaryDefine.b00001111);
				array[59] = (int)(array2[6][3] & BinaryDefine.b00001111);
				if (array[60] > 8)
				{
					array[60] = 0;
				}
				if (array[59] > 8)
				{
					array[59] = 0;
				}
				array[63] = (array2[6][2] >> 4 & (int)BinaryDefine.b00001111);
				array[61] = (int)(array2[6][2] & BinaryDefine.b00001111);
				if (array[63] > 8)
				{
					array[63] = 0;
				}
				if (array[61] > 8)
				{
					array[61] = 0;
				}
				array[100] = (array2[6][1] >> 7 & (int)BinaryDefine.b00000001);
				array[32] = (array2[6][1] >> 5 & (int)BinaryDefine.b00000001);
				array[65] = (array2[6][1] >> 4 & (int)BinaryDefine.b00000001);
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
				array[90] = (array2[6][0] >> 1 & (int)BinaryDefine.b00001111);
				array[80] = (int)(array2[6][0] & BinaryDefine.b00000001);
				if (array[9] > 4)
				{
					array[9] = 1;
				}
				if (array[90] > 8)
				{
					array[90] = 1;
				}
				array[85] = (array2[7][3] >> 4 & (int)BinaryDefine.b00001111);
				array[83] = (int)(array2[7][3] & BinaryDefine.b00001111);
				if (array[85] > 12)
				{
					array[85] = 4;
				}
				if (array[83] > 8)
				{
					array[83] = 4;
				}
				num = (array2[7][2] >> 4 & (int)BinaryDefine.b00001111);
				array[67] = (array2[7][2] >> 2 & (int)BinaryDefine.b00000011);
				array[1] = (int)(array2[7][2] & BinaryDefine.b00000011);
				if (array[68] == 1)
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
				if (array[67] > 2)
				{
					array[67] = 1;
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
				array[74] = (array2[7][1] >> 4 & (int)BinaryDefine.b00001111);
				array[12] = (array2[7][1] >> 3 & (int)BinaryDefine.b00000001);
				array[36] = (array2[7][1] >> 1 & (int)BinaryDefine.b00000011);
				array[30] = (int)(array2[7][1] & BinaryDefine.b00000001);
				if (array[74] > 12 || array[74] == 0)
				{
					array[74] = 9;
				}
				array[57] = (array2[7][0] >> 4 & (int)BinaryDefine.b00000111);
				array[62] = (int)(array2[7][0] & BinaryDefine.b00001111);
				if (array[57] > 6)
				{
					array[57] = 0;
				}
				if (array[62] > 8)
				{
					array[62] = 0;
				}
				array[64] = (array2[8][3] >> 3 & (int)BinaryDefine.b00000011);
				array[71] = (int)(array2[8][3] & BinaryDefine.b00000111);
				if (array[71] > 6 || array[71] == 0)
				{
					array[71] = 6;
				}
				switch (array[64])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[64] = 1;
					break;
				}
				array[23] = (array2[8][2] >> 6 & (int)BinaryDefine.b00000011);
				array[22] = (array2[8][2] >> 4 & (int)BinaryDefine.b00000011);
				array[21] = (array2[8][2] >> 2 & (int)BinaryDefine.b00000011);
				array[20] = (array2[8][2] >> 1 & (int)BinaryDefine.b00000001);
				array[19] = (int)(array2[8][2] & BinaryDefine.b00000001);
				if (array[23] > 3)
				{
					array[23] = 0;
				}
				if (array[22] > 3)
				{
					array[22] = 1;
				}
				switch (array[21])
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					array[21] = 0;
					break;
				}
				array[27] = (array2[8][1] >> 6 & (int)BinaryDefine.b00000011);
				array[26] = (array2[8][1] >> 4 & (int)BinaryDefine.b00000011);
				array[25] = (array2[8][1] >> 2 & (int)BinaryDefine.b00000011);
				array[24] = (int)(array2[8][1] & BinaryDefine.b00000011);
				if (array[27] > 3)
				{
					array[27] = 0;
				}
				if (array[26] > 3)
				{
					array[26] = 2;
				}
				if (array[25] > 3)
				{
					array[25] = 3;
				}
				if (array[24] > 3)
				{
					array[24] = 2;
				}
				array[72] = (int)(array2[8][0] & BinaryDefine.b00001111);
				if (array[72] > 8 || array[72] < 1)
				{
					array[72] = 4;
				}
				array[97] = (int)nvData[256];
				return array;
			}

			// Token: 0x0600032D RID: 813 RVA: 0x0005023C File Offset: 0x0004E43C
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
				array3[num] |= (byte)(userSettingR8[53] << 2 & (int)BinaryDefine.b00011100);
				byte[] array4 = array[2];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR8[52] << 1 & (int)BinaryDefine.b00000010);
				byte[] array5 = array[2];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR8[34] & (int)BinaryDefine.b00000001);
				byte[] array6 = array[2];
				int num4 = 2;
				array6[num4] |= (byte)(userSettingR8[33] << 7 & (int)BinaryDefine.b10000000);
				byte[] array7 = array[2];
				int num5 = 2;
				array7[num5] |= (byte)(userSettingR8[13] << 6 & (int)BinaryDefine.b01000000);
				byte[] array8 = array[2];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR8[15] << 5 & (int)BinaryDefine.b00100000);
				byte[] array9 = array[2];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR8[16] << 4 & (int)BinaryDefine.b00010000);
				byte[] array10 = array[2];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR8[17] << 3 & (int)BinaryDefine.b00001000);
				byte[] array11 = array[2];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR8[18] << 2 & (int)BinaryDefine.b00000100);
				byte[] array12 = array[2];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR8[31] << 1 & (int)BinaryDefine.b00000010);
				byte[] array13 = array[2];
				int num11 = 1;
				array13[num11] |= (byte)(userSettingR8[7] << 7 & (int)BinaryDefine.b10000000);
				byte[] array14 = array[2];
				int num12 = 1;
				array14[num12] |= (byte)(userSettingR8[78] << 3 & (int)BinaryDefine.b00001000);
				byte[] array15 = array[2];
				int num13 = 1;
				array15[num13] |= (byte)(userSettingR8[87] << 2 & (int)BinaryDefine.b00000100);
				byte[] array16 = array[2];
				int num14 = 1;
				array16[num14] |= (byte)(userSettingR8[94] << 1 & (int)BinaryDefine.b00000010);
				byte[] array17 = array[2];
				int num15 = 1;
				array17[num15] |= (byte)(userSettingR8[96] & (int)BinaryDefine.b00000001);
				byte[] array18 = array[2];
				int num16 = 0;
				array18[num16] |= (byte)(userSettingR8[98] << 4 & (int)BinaryDefine.b01110000);
				byte[] array19 = array[2];
				int num17 = 0;
				array19[num17] |= (byte)(userSettingR8[99] & (int)BinaryDefine.b00001111);
				byte b;
				if (userSettingR8[68] == 1)
				{
					b = (byte)(userSettingR8[88] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[88] / 10);
				}
				byte[] array20 = array[1];
				int num18 = 2;
				array20[num18] |= (byte)(userSettingR8[68] << 7 & (int)BinaryDefine.b10000000);
				byte[] array21 = array[1];
				int num19 = 2;
				array21[num19] |= (byte)(userSettingR8[93] << 5 & (int)BinaryDefine.b00100000);
				byte[] array22 = array[1];
				int num20 = 2;
				// DECOMPILE-FIX: Restore byte narrowing for the exported bit-mask operations
				// in this file; unchecked casts preserve the original IL byte stores.
				array22[num20] |= unchecked((byte)(b & BinaryDefine.b00011111));
				if (userSettingR8[68] == 1)
				{
					b = (byte)(userSettingR8[11] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[11] / 10);
				}
				byte[] array23 = array[1];
				int num21 = 3;
				array23[num21] |= (byte)(userSettingR8[95] << 6 & (int)BinaryDefine.b01000000);
				byte[] array24 = array[1];
				int num22 = 3;
				array24[num22] |= (byte)(userSettingR8[28] << 5 & (int)BinaryDefine.b00100000);
				byte[] array25 = array[1];
				int num23 = 3;
				array25[num23] |= unchecked((byte)(b & BinaryDefine.b00011111));
				byte b2;
				if (userSettingR8[68] == 1)
				{
					b2 = 1;
					b = (byte)(userSettingR8[91] / 5);
				}
				else if (userSettingR8[91] % 10 == 0)
				{
					b2 = 1;
					b = (byte)(userSettingR8[91] / 10);
				}
				else
				{
					b2 = 0;
					b = (byte)(userSettingR8[91] / 5);
				}
				byte[] array26 = array[1];
				int num24 = 1;
				array26[num24] |= (byte)((int)b2 << 7 & (int)BinaryDefine.b10000000);
				byte[] array27 = array[1];
				int num25 = 1;
				array27[num25] |= (byte)(userSettingR8[8] << 6 & (int)BinaryDefine.b01000000);
				byte[] array28 = array[1];
				int num26 = 1;
				array28[num26] |= (byte)(userSettingR8[10] << 5 & (int)BinaryDefine.b00100000);
				byte[] array29 = array[1];
				int num27 = 1;
				array29[num27] |= unchecked((byte)(b & BinaryDefine.b00011111));
				b = (byte)(userSettingR8[92] + 12);
				byte[] array30 = array[1];
				int num28 = 0;
				array30[num28] |= (byte)(userSettingR8[66] << 5 & (int)BinaryDefine.b11100000);
				byte[] array31 = array[1];
				int num29 = 0;
				array31[num29] |= unchecked((byte)(b & BinaryDefine.b00011111));
				byte[] array32 = array[3];
				int num30 = 3;
				array32[num30] |= (byte)(userSettingR8[49] << 6 & (int)BinaryDefine.b01000000);
				byte[] array33 = array[3];
				int num31 = 3;
				array33[num31] |= (byte)(userSettingR8[14] << 5 & (int)BinaryDefine.b00100000);
				byte[] array34 = array[3];
				int num32 = 3;
				array34[num32] |= (byte)(userSettingR8[48] << 3 & (int)BinaryDefine.b00011000);
				byte[] array35 = array[3];
				int num33 = 3;
				array35[num33] |= (byte)(userSettingR8[79] & (int)BinaryDefine.b00000111);
				byte[] array36 = array[3];
				int num34 = 2;
				array36[num34] |= (byte)(userSettingR8[29] << 7 & (int)BinaryDefine.b10000000);
				byte[] array37 = array[3];
				int num35 = 2;
				array37[num35] |= (byte)(userSettingR8[2] << 3 & (int)BinaryDefine.b00111000);
				byte[] array38 = array[3];
				int num36 = 2;
				array38[num36] |= (byte)(userSettingR8[3] & (int)BinaryDefine.b00000111);
				byte[] array39 = array[3];
				int num37 = 1;
				array39[num37] |= (byte)(userSettingR8[35] << 6 & (int)BinaryDefine.b11000000);
				byte[] array40 = array[3];
				int num38 = 1;
				array40[num38] |= (byte)(userSettingR8[47] << 3 & (int)BinaryDefine.b00001000);
				byte[] array41 = array[3];
				int num39 = 1;
				array41[num39] |= (byte)(userSettingR8[4] & (int)BinaryDefine.b00000111);
				byte[] array42 = array[3];
				int num40 = 0;
				array42[num40] |= (byte)(userSettingR8[46] << 7 & (int)BinaryDefine.b10000000);
				byte[] array43 = array[3];
				int num41 = 0;
				array43[num41] |= (byte)(userSettingR8[45] << 6 & (int)BinaryDefine.b01000000);
				byte[] array44 = array[3];
				int num42 = 0;
				array44[num42] |= (byte)(userSettingR8[44] << 5 & (int)BinaryDefine.b00100000);
				byte[] array45 = array[3];
				int num43 = 0;
				array45[num43] |= (byte)(userSettingR8[43] << 4 & (int)BinaryDefine.b00010000);
				byte[] array46 = array[3];
				int num44 = 0;
				array46[num44] |= (byte)(userSettingR8[42] << 3 & (int)BinaryDefine.b00001000);
				byte[] array47 = array[3];
				int num45 = 0;
				array47[num45] |= (byte)(userSettingR8[41] << 2 & (int)BinaryDefine.b00000100);
				byte[] array48 = array[3];
				int num46 = 0;
				array48[num46] |= (byte)(userSettingR8[40] << 1 & (int)BinaryDefine.b00000010);
				byte[] array49 = array[3];
				int num47 = 0;
				array49[num47] |= (byte)(userSettingR8[39] & (int)BinaryDefine.b00000001);
				byte[] array50 = array[4];
				int num48 = 3;
				array50[num48] |= (byte)(userSettingR8[82] << 6 & (int)BinaryDefine.b01000000);
				byte[] array51 = array[4];
				int num49 = 3;
				array51[num49] |= (byte)(userSettingR8[84] << 3 & (int)BinaryDefine.b00111000);
				byte[] array52 = array[4];
				int num50 = 3;
				array52[num50] |= (byte)(userSettingR8[86] & (int)BinaryDefine.b00000111);
				byte[] array53 = array[4];
				int num51 = 2;
				array53[num51] |= (byte)(userSettingR8[69] << 4 & (int)BinaryDefine.b11110000);
				byte[] array54 = array[4];
				int num52 = 2;
				array54[num52] |= (byte)(userSettingR8[70] & (int)BinaryDefine.b00001111);
				byte[] array55 = array[4];
				int num53 = 1;
				array55[num53] |= (byte)(userSettingR8[77] << 4 & (int)BinaryDefine.b11110000);
				byte[] array56 = array[4];
				int num54 = 1;
				array56[num54] |= (byte)(userSettingR8[75] & (int)BinaryDefine.b00001111);
				byte[] array57 = array[5];
				int num55 = 3;
				array57[num55] |= (byte)(userSettingR8[76] << 4 & (int)BinaryDefine.b01110000);
				byte[] array58 = array[5];
				int num56 = 3;
				array58[num56] |= (byte)(userSettingR8[73] & (int)BinaryDefine.b00001111);
				byte[] array59 = array[5];
				int num57 = 2;
				array59[num57] |= (byte)(userSettingR8[50] << 5 & (int)BinaryDefine.b00100000);
				byte[] array60 = array[5];
				int num58 = 2;
				array60[num58] |= (byte)(userSettingR8[37] << 4 & (int)BinaryDefine.b00010000);
				byte[] array61 = array[5];
				int num59 = 2;
				array61[num59] |= (byte)(userSettingR8[37] << 3 & (int)BinaryDefine.b00001000);
				byte[] array62 = array[5];
				int num60 = 2;
				array62[num60] |= (byte)(userSettingR8[81] & (int)BinaryDefine.b00000111);
				byte[] array63 = array[5];
				int num61 = 1;
				array63[num61] |= (byte)(userSettingR8[51] << 7 & (int)BinaryDefine.b10000000);
				byte[] array64 = array[5];
				int num62 = 1;
				array64[num62] |= (byte)(userSettingR8[55] << 3 & (int)BinaryDefine.b00111000);
				byte[] array65 = array[5];
				int num63 = 1;
				array65[num63] |= (byte)(userSettingR8[54] & (int)BinaryDefine.b00000111);
				byte[] array66 = array[5];
				int num64 = 0;
				array66[num64] |= (byte)(userSettingR8[0] << 7 & (int)BinaryDefine.b10000000);
				byte[] array67 = array[5];
				int num65 = 0;
				array67[num65] |= (byte)(userSettingR8[89] << 6 & (int)BinaryDefine.b01000000);
				byte[] array68 = array[5];
				int num66 = 0;
				array68[num66] |= (byte)(userSettingR8[58] << 3 & (int)BinaryDefine.b00111000);
				byte[] array69 = array[5];
				int num67 = 0;
				array69[num67] |= (byte)(userSettingR8[56] & (int)BinaryDefine.b00000111);
				byte[] array70 = array[6];
				int num68 = 3;
				array70[num68] |= (byte)(userSettingR8[60] << 4 & (int)BinaryDefine.b11110000);
				byte[] array71 = array[6];
				int num69 = 3;
				array71[num69] |= (byte)(userSettingR8[59] & (int)BinaryDefine.b00001111);
				byte[] array72 = array[6];
				int num70 = 2;
				array72[num70] |= (byte)(userSettingR8[63] << 4 & (int)BinaryDefine.b11110000);
				byte[] array73 = array[6];
				int num71 = 2;
				array73[num71] |= (byte)(userSettingR8[61] & (int)BinaryDefine.b00001111);
				byte[] array74 = array[6];
				int num72 = 1;
				array74[num72] |= (byte)(userSettingR8[100] << 7 & (int)BinaryDefine.b10000000);
				byte[] array75 = array[6];
				int num73 = 1;
				array75[num73] |= (byte)(userSettingR8[32] << 5 & (int)BinaryDefine.b01100000);
				byte[] array76 = array[6];
				int num74 = 1;
				array76[num74] |= (byte)(userSettingR8[65] << 4 & (int)BinaryDefine.b00010000);
				byte[] array77 = array[6];
				int num75 = 1;
				array77[num75] |= (byte)(userSettingR8[6] & (int)BinaryDefine.b00001111);
				byte[] array78 = array[6];
				int num76 = 0;
				array78[num76] |= (byte)(userSettingR8[9] << 5 & (int)BinaryDefine.b11100000);
				byte[] array79 = array[6];
				int num77 = 0;
				array79[num77] |= (byte)(userSettingR8[90] << 1 & (int)BinaryDefine.b00011110);
				byte[] array80 = array[6];
				int num78 = 0;
				array80[num78] |= (byte)(userSettingR8[80] & (int)BinaryDefine.b00000001);
				byte[] array81 = array[7];
				int num79 = 3;
				array81[num79] |= (byte)(userSettingR8[85] << 4 & (int)BinaryDefine.b11110000);
				byte[] array82 = array[7];
				int num80 = 3;
				array82[num80] |= (byte)(userSettingR8[83] & (int)BinaryDefine.b00001111);
				if (userSettingR8[68] == 1)
				{
					b = (byte)(userSettingR8[5] / 5);
				}
				else
				{
					b = (byte)(userSettingR8[5] / 10);
				}
				byte[] array83 = array[7];
				int num81 = 2;
				array83[num81] |= (byte)((int)b << 4 & (int)BinaryDefine.b11110000);
				byte[] array84 = array[7];
				int num82 = 2;
				array84[num82] |= (byte)(userSettingR8[67] << 2 & (int)BinaryDefine.b00001100);
				byte[] array85 = array[7];
				int num83 = 2;
				array85[num83] |= (byte)(userSettingR8[1] & (int)BinaryDefine.b00000011);
				byte[] array86 = array[7];
				int num84 = 1;
				array86[num84] |= (byte)(userSettingR8[74] << 4 & (int)BinaryDefine.b11110000);
				byte[] array87 = array[7];
				int num85 = 1;
				array87[num85] |= (byte)(userSettingR8[12] << 3 & (int)BinaryDefine.b00001000);
				byte[] array88 = array[7];
				int num86 = 1;
				array88[num86] |= (byte)(userSettingR8[36] << 1 & (int)BinaryDefine.b00000110);
				byte[] array89 = array[7];
				int num87 = 1;
				array89[num87] |= (byte)(userSettingR8[30] & (int)BinaryDefine.b00000001);
				byte[] array90 = array[7];
				int num88 = 0;
				array90[num88] |= (byte)(userSettingR8[57] << 4 & (int)BinaryDefine.b01110000);
				byte[] array91 = array[7];
				int num89 = 0;
				array91[num89] |= (byte)(userSettingR8[62] & (int)BinaryDefine.b00001111);
				byte[] array92 = array[8];
				int num90 = 3;
				array92[num90] |= (byte)(userSettingR8[64] << 3 & (int)BinaryDefine.b00011000);
				byte[] array93 = array[8];
				int num91 = 3;
				array93[num91] |= (byte)(userSettingR8[71] & (int)BinaryDefine.b00000111);
				byte[] array94 = array[8];
				int num92 = 2;
				array94[num92] |= (byte)(userSettingR8[23] << 6 & (int)BinaryDefine.b11000000);
				byte[] array95 = array[8];
				int num93 = 2;
				array95[num93] |= (byte)(userSettingR8[22] << 4 & (int)BinaryDefine.b00110000);
				byte[] array96 = array[8];
				int num94 = 2;
				array96[num94] |= (byte)(userSettingR8[21] << 2 & (int)BinaryDefine.b00001100);
				byte[] array97 = array[8];
				int num95 = 2;
				array97[num95] |= (byte)(userSettingR8[20] << 1 & (int)BinaryDefine.b00000010);
				byte[] array98 = array[8];
				int num96 = 2;
				array98[num96] |= (byte)(userSettingR8[19] & (int)BinaryDefine.b00000001);
				byte[] array99 = array[8];
				int num97 = 1;
				array99[num97] |= (byte)(userSettingR8[27] << 6 & (int)BinaryDefine.b11000000);
				byte[] array100 = array[8];
				int num98 = 1;
				array100[num98] |= (byte)(userSettingR8[26] << 4 & (int)BinaryDefine.b00110000);
				byte[] array101 = array[8];
				int num99 = 1;
				array101[num99] |= (byte)(userSettingR8[25] << 2 & (int)BinaryDefine.b00001100);
				byte[] array102 = array[8];
				int num100 = 1;
				array102[num100] |= (byte)(userSettingR8[24] & (int)BinaryDefine.b00000011);
				byte[] array103 = array[8];
				int num101 = 0;
				array103[num101] |= (byte)(userSettingR8[72] & (int)BinaryDefine.b00001111);
				Array.Copy(receivedNVData, array2, receivedNVData.Length);
				for (int i = 0; i < array.Length; i++)
				{
					for (int j = 0; j < array[i].Length; j++)
					{
						byte[] array104 = array2;
						int num102 = i * 4 + j;
						array104[num102] &= unchecked((byte)(~this.userNVDataPos[i * 4 + j]));
						byte[] array105 = array2;
						int num103 = i * 4 + j;
						array105[num103] |= array[i][j];
					}
				}
				array2[256] = (byte)userSettingR8[97];
				int num104 = 0;
				for (int i = 0; i < receivedNVData.Length; i++)
				{
					if (receivedNVData[i] != array2[i])
					{
						num104++;
					}
				}
				return array2;
			}

			// Token: 0x04000680 RID: 1664
			private int supportVersion = 126;

			// Token: 0x04000681 RID: 1665
			private int menuCnt = 101;

			// Token: 0x04000682 RID: 1666
			private byte[] userNVDataPos = new byte[]
			{
				0,
				0,
				0,
				0,
				byte.MaxValue,
				byte.MaxValue,
				191,
				127,
				127,
				143,
				254,
				31,
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
				63,
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

			// Token: 0x04000683 RID: 1667
			private const int memoryQuotaPos = 256;

			// Token: 0x04000684 RID: 1668
			private const int HEADER = 0;

			// Token: 0x04000685 RID: 1669
			private const int GPS = 1;

			// Token: 0x04000686 RID: 1670
			private const int RD_1 = 2;

			// Token: 0x04000687 RID: 1671
			private const int RD_2 = 3;

			// Token: 0x04000688 RID: 1672
			private const int RD_3 = 4;

			// Token: 0x04000689 RID: 1673
			private const int RD_4 = 5;

			// Token: 0x0400068A RID: 1674
			private const int RD_5 = 6;

			// Token: 0x0400068B RID: 1675
			private const int RD_6 = 7;

			// Token: 0x0400068C RID: 1676
			private const int RD_7 = 8;

			// Token: 0x0400068D RID: 1677
			private const int ADDR_CNT = 9;

			// Token: 0x020000BD RID: 189
			private enum MENU
			{
				// Token: 0x04000B4D RID: 2893
				MENU_MODE,
				// Token: 0x04000B4E RID: 2894
				DETECTION_MODE,
				// Token: 0x04000B4F RID: 2895
				X_SENSITIVE,
				// Token: 0x04000B50 RID: 2896
				K_SENSITIVE,
				// Token: 0x04000B51 RID: 2897
				KA_SENSITIVE,
				// Token: 0x04000B52 RID: 2898
				AUTO_CITY_SPEED,
				// Token: 0x04000B53 RID: 2899
				REAR_ATTENUATION,
				// Token: 0x04000B54 RID: 2900
				GPS_ENABLE,
				// Token: 0x04000B55 RID: 2901
				SPEED_CAMERA_ENABLE,
				// Token: 0x04000B56 RID: 2902
				SPEED_CAMERA_ALERT_RANGE,
				// Token: 0x04000B57 RID: 2903
				RLC_ENABLE,
				// Token: 0x04000B58 RID: 2904
				RLC_QRIDE,
				// Token: 0x04000B59 RID: 2905
				POI_PASSCHIME,
				// Token: 0x04000B5A RID: 2906
				VOICE_ENABLE,
				// Token: 0x04000B5B RID: 2907
				KA_FREQ_VOICE,
				// Token: 0x04000B5C RID: 2908
				X_BAND_ENABLE,
				// Token: 0x04000B5D RID: 2909
				K_BAND_ENABLE,
				// Token: 0x04000B5E RID: 2910
				KA_BAND_ENABLE,
				// Token: 0x04000B5F RID: 2911
				LASER_ENABLE,
				// Token: 0x04000B60 RID: 2912
				LASER_GUN_ID_ENABLE,
				// Token: 0x04000B61 RID: 2913
				LASER_JAMMER_INTERFACE_MODE,
				// Token: 0x04000B62 RID: 2914
				LASER_JAMMING_MODE,
				// Token: 0x04000B63 RID: 2915
				LASER_TP1_SETTING_MODE,
				// Token: 0x04000B64 RID: 2916
				LASER_TP2_SETTING_MODE,
				// Token: 0x04000B65 RID: 2917
				LASER_TP3_SETTING_MODE,
				// Token: 0x04000B66 RID: 2918
				LASER_TP4_SETTING_MODE,
				// Token: 0x04000B67 RID: 2919
				LASER_TP5_SETTING_MODE,
				// Token: 0x04000B68 RID: 2920
				LASER_TP6_SETTING_MODE,
				// Token: 0x04000B69 RID: 2921
				K_POP_ENABLE,
				// Token: 0x04000B6A RID: 2922
				MRCD_ENABLE,
				// Token: 0x04000B6B RID: 2923
				GATSO_ENABLE,
				// Token: 0x04000B6C RID: 2924
				KA_POP_ENABLE,
				// Token: 0x04000B6D RID: 2925
				K_FILTER_ENABLE,
				// Token: 0x04000B6E RID: 2926
				KA_FILTER_ENABLE,
				// Token: 0x04000B6F RID: 2927
				TSF_ENABLE,
				// Token: 0x04000B70 RID: 2928
				K_BLOCK_FILTER_1_MODE,
				// Token: 0x04000B71 RID: 2929
				K_BLOCK_FILTER_2_MODE,
				// Token: 0x04000B72 RID: 2930
				K_BAND_1,
				// Token: 0x04000B73 RID: 2931
				K_BAND_2,
				// Token: 0x04000B74 RID: 2932
				KA_SEG1,
				// Token: 0x04000B75 RID: 2933
				KA_SEG2,
				// Token: 0x04000B76 RID: 2934
				KA_SEG3,
				// Token: 0x04000B77 RID: 2935
				KA_SEG4,
				// Token: 0x04000B78 RID: 2936
				KA_SEG5,
				// Token: 0x04000B79 RID: 2937
				KA_SEG6,
				// Token: 0x04000B7A RID: 2938
				KA_SEG7,
				// Token: 0x04000B7B RID: 2939
				KA_SEG8,
				// Token: 0x04000B7C RID: 2940
				KA_SEG9,
				// Token: 0x04000B7D RID: 2941
				PRIORITY_MODE,
				// Token: 0x04000B7E RID: 2942
				MUTE_MEM_BAND_OPTION,
				// Token: 0x04000B7F RID: 2943
				AUTO_MUTE_MEM_ENABLE,
				// Token: 0x04000B80 RID: 2944
				AUTO_MUTE_MEM_BAND_OPTION,
				// Token: 0x04000B81 RID: 2945
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x04000B82 RID: 2946
				BACKGROUND_COLOR,
				// Token: 0x04000B83 RID: 2947
				X_BAND_ARROW_COLOR,
				// Token: 0x04000B84 RID: 2948
				K_BAND_ARROW_COLOR,
				// Token: 0x04000B85 RID: 2949
				MRCD_ARROW_COLOR,
				// Token: 0x04000B86 RID: 2950
				GATSO_ARROW_COLOR,
				// Token: 0x04000B87 RID: 2951
				KA_BAND_ARROW_COLOR,
				// Token: 0x04000B88 RID: 2952
				X_BAND_COLOR,
				// Token: 0x04000B89 RID: 2953
				K_BAND_COLOR,
				// Token: 0x04000B8A RID: 2954
				MRCD_COLOR,
				// Token: 0x04000B8B RID: 2955
				GATSO_COLOR,
				// Token: 0x04000B8C RID: 2956
				KA_BAND_COLOR,
				// Token: 0x04000B8D RID: 2957
				MAIN_DISPLAY,
				// Token: 0x04000B8E RID: 2958
				HEARTBEAT_ICON_ENABLE,
				// Token: 0x04000B8F RID: 2959
				LEFT_DISPLAY,
				// Token: 0x04000B90 RID: 2960
				ALERT_DISPLAY,
				// Token: 0x04000B91 RID: 2961
				SPEED_UNIT,
				// Token: 0x04000B92 RID: 2962
				X_BAND_ALERT_TONE,
				// Token: 0x04000B93 RID: 2963
				K_BAND_ALERT_TONE,
				// Token: 0x04000B94 RID: 2964
				K_BAND_BOGEY_TONE,
				// Token: 0x04000B95 RID: 2965
				K_BAND_BOGEY_LEVEL,
				// Token: 0x04000B96 RID: 2966
				MRCD_ALERT_TONE,
				// Token: 0x04000B97 RID: 2967
				GATSO_ALERT_TONE,
				// Token: 0x04000B98 RID: 2968
				KA_BAND_ALERT_TONE,
				// Token: 0x04000B99 RID: 2969
				KA_BAND_BOGEY_TONE,
				// Token: 0x04000B9A RID: 2970
				LASER_ALERT_TONE,
				// Token: 0x04000B9B RID: 2971
				AUTO_MUTE_ENABLE,
				// Token: 0x04000B9C RID: 2972
				AUTO_MUTE_VOLUME,
				// Token: 0x04000B9D RID: 2973
				REAR_K_BAND_MUTE_ENABLE,
				// Token: 0x04000B9E RID: 2974
				DARK_MODE_BRIGHTNESS,
				// Token: 0x04000B9F RID: 2975
				AUTO_DIM_SET_MODE_SELECT,
				// Token: 0x04000BA0 RID: 2976
				AUTO_DIM_SET_BRIGHT_TIME,
				// Token: 0x04000BA1 RID: 2977
				AUTO_DIM_SET_BRIGHT_BRIGHTNESS,
				// Token: 0x04000BA2 RID: 2978
				AUTO_DIM_SET_DIM_TIME,
				// Token: 0x04000BA3 RID: 2979
				AUTO_DIM_SET_DIM_BRIGHTNESS,
				// Token: 0x04000BA4 RID: 2980
				BACKLIGHT_MODE,
				// Token: 0x04000BA5 RID: 2981
				QRIDE_MODE,
				// Token: 0x04000BA6 RID: 2982
				MRCD_QRIDE_ENABLE,
				// Token: 0x04000BA7 RID: 2983
				QRIDE_VOLUME,
				// Token: 0x04000BA8 RID: 2984
				LIMIT_SPEED_MODE,
				// Token: 0x04000BA9 RID: 2985
				GMT,
				// Token: 0x04000BAA RID: 2986
				DST_ENABLE,
				// Token: 0x04000BAB RID: 2987
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x04000BAC RID: 2988
				VEHICLE_BATT_SAVER_ENABLE,
				// Token: 0x04000BAD RID: 2989
				SELF_TEST_ENABLE,
				// Token: 0x04000BAE RID: 2990
				MEMORY_QUOTA,
				// Token: 0x04000BAF RID: 2991
				MAIN_DIM_SET,
				// Token: 0x04000BB0 RID: 2992
				MAIN_VOLUME,
				// Token: 0x04000BB1 RID: 2993
				BLUETOOTH_MODE
			}
		}
	}
}
