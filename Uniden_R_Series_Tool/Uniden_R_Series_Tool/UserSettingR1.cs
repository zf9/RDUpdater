using System;
using System.Linq;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000022 RID: 34
	internal static class UserSettingR1
	{
		// Token: 0x04000330 RID: 816
		public static UserSettingFormat[] user_setting = new UserSettingFormat[]
		{
			new UserSettingR1.v160()
		};

		// Token: 0x02000087 RID: 135
		private class v160 : UserSettingFormat
		{
			// Token: 0x06000297 RID: 663 RVA: 0x00024E34 File Offset: 0x00023034
			public int GetSupportVersion()
			{
				return this.supportVersion;
			}

			// Token: 0x06000298 RID: 664 RVA: 0x00024E3C File Offset: 0x0002303C
			public int GetMenuCnt()
			{
				return this.menuCnt;
			}

			// Token: 0x06000299 RID: 665 RVA: 0x00024E44 File Offset: 0x00023044
			public byte[] GetNVDataMask()
			{
				return this.userNVDataPos;
			}

			// Token: 0x0600029A RID: 666 RVA: 0x00024E4C File Offset: 0x0002304C
			public bool user_k_block_op_mode_is_level(int op_mode)
			{
				return false;
			}

			// Token: 0x0600029B RID: 667 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_level(int strength, int mode)
			{
				return -1;
			}

			// Token: 0x0600029C RID: 668 RVA: 0x00024E4F File Offset: 0x0002304F
			public int user_k_block_get_raw_strength(int level, int mode)
			{
				return -1;
			}

			// Token: 0x0600029D RID: 669 RVA: 0x00024E54 File Offset: 0x00023054
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
				array[4] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Voice On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns voice alert on or off under the following conditions:\nType of radar / laser Band alarms");
				array[5] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Frequency Voice", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Announces the detected Ka band frequency.");
				UserSettingMenu[] array2 = array;
				int num = 6;
				UserSettingMenu.MENU_TYPE menuType = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString = "X Band On/Off";
				int[] array3 = new int[2];
				array3[0] = 1;
				array2[num] = new UserSettingMenu(menuType, menuString, array3, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore X band frequencies.\nTurn on for X band sensitivity as follows:\nHighway: Full sensitivity\nCity: X band sensitivity reduced");
				array[7] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore K band frequencies.");
				array[8] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Band On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore Ka band frequencies.");
				array[9] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Laser On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turn off to have the detector ignore lasers.");
				UserSettingMenu[] array4 = array;
				int num2 = 10;
				UserSettingMenu.MENU_TYPE menuType2 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString2 = "K POP On/Off";
				int[] array5 = new int[2];
				array5[0] = 1;
				array4[num2] = new UserSettingMenu(menuType2, menuString2, array5, new string[]
				{
					"Off",
					"On"
				}, "Detects K POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[11] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "MRCD On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Activates MultaRadar CD/CT low - powered radar gun detection.");
				UserSettingMenu[] array6 = array;
				int num3 = 12;
				UserSettingMenu.MENU_TYPE menuType3 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString3 = "Ka POP On/Off";
				int[] array7 = new int[2];
				array7[0] = 1;
				array6[num3] = new UserSettingMenu(menuType3, menuString3, array7, new string[]
				{
					"Off",
					"On"
				}, "Detects Ka POP transmissions\n(very brief transmissions, too fast for some detectors to hear).");
				array[13] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Filter", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Filters noise from the K band to prevent false detections.");
				UserSettingMenu[] array8 = array;
				int num4 = 14;
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
				int num5 = 15;
				UserSettingMenu.MENU_TYPE menuType5 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString5 = "TSF";
				int[] array11 = new int[2];
				array11[0] = 1;
				array10[num5] = new UserSettingMenu(menuType5, menuString5, array11, new string[]
				{
					"Off",
					"On"
				}, "Traffic Sensor Filter. Prevents false alarms caused by traffic monitoring radar systems.");
				UserSettingMenu[] array12 = array;
				int num6 = 16;
				UserSettingMenu.MENU_TYPE menuType6 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString6 = "K Block1 Filter 24.199Ghz (± 0.005)";
				int[] array13 = new int[2];
				array13[0] = 1;
				array12[num6] = new UserSettingMenu(menuType6, menuString6, array13, new string[]
				{
					"Off",
					"On"
				}, "Keep K Block Filter ON to block K band monitor systems in the 24.199Ghz (± 0.005) range");
				array[17] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "K Narrow/Wide", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Narrow",
					"Wide"
				}, "K Narrow scans a narrower frequency range than K Wide.");
				array[18] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Ka Narrow/Wide/Segmentation", new int[]
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
				int num7 = 19;
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
				int num8 = 20;
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
				int num9 = 21;
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
				int num10 = 22;
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
				int num11 = 23;
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
				int num12 = 24;
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
				int num13 = 25;
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
				int num14 = 26;
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
				int num15 = 27;
				UserSettingMenu.MENU_TYPE menuType15 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString15 = "Ka Segmentation 35.613Ghz – 35.829Ghz";
				int[] array31 = new int[2];
				array31[0] = 1;
				array30[num15] = new UserSettingMenu(menuType15, menuString15, array31, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.613Ghz – 35.829Ghz (Ka Segmentation mode)");
				UserSettingMenu[] array32 = array;
				int num16 = 28;
				UserSettingMenu.MENU_TYPE menuType16 = UserSettingMenu.MENU_TYPE.BAND_SETTING;
				string menuString16 = "Ka Segmentation 35.829Ghz – 36.001Ghz";
				int[] array33 = new int[2];
				array33[0] = 1;
				array32[num16] = new UserSettingMenu(menuType16, menuString16, array33, new string[]
				{
					"Off",
					"On"
				}, "Ka band sweep 35.829Ghz – 36.001Ghz (Ka Segmentation mode)");
				array[29] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING, "Priority", new int[]
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
				UserSettingMenu[] array34 = array;
				int num17 = 30;
				UserSettingMenu.MENU_TYPE menuType17 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString17 = "All Threat Display";
				int[] array35 = new int[2];
				array35[0] = 1;
				array34[num17] = new UserSettingMenu(menuType17, menuString17, array35, new string[]
				{
					"Off",
					"On"
				}, "Displays if more than one radar signals are detected at the same time. The signal with the strongest radar signal is considered the main signal. The other signals are displayed on the left side.");
				array[31] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Background Color", new int[]
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
				UserSettingMenu[] array36 = array;
				int num18 = 32;
				UserSettingMenu.MENU_TYPE menuType18 = UserSettingMenu.MENU_TYPE.DISPLAY;
				string menuString18 = "Main Display";
				int[] array37 = new int[2];
				array37[0] = 1;
				array36[num18] = new UserSettingMenu(menuType18, menuString18, array37, new string[]
				{
					"Mode",
					"Scan"
				}, "Select what will display on the OLED, either scanning for frequencies, or the mode.");
				array[33] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "X Band Alert Tone", new int[]
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
				array[34] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "K Band Alert Tone", new int[]
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
				array[35] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "MRCD Alert Tone", new int[]
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
				array[36] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Alert Tone", new int[]
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
				array[37] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Ka Band Bogey Tone", new int[]
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
				array[38] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Laser Alert Tone", new int[]
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
				array[39] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Auto Mute On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Auto Mute reduces alarm level to 1 after 3 seconds and returns to normal operation(Auto Mute = OFF) 10 seconds after the alert ends.If the same alarm sounds within the 10 second period, Auto Mute remains at level 1.The unit returns to normal operation(Auto Mute = OFF) if a different band is detected during Auto Mute = ON mode.");
				array[40] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Auto Mute Volume", new int[]
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
				array[41] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Dark mode Brightness", new int[]
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
				array[42] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Backlight On/Off", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Turns the front key backlight on and off.");
				UserSettingMenu[] array38 = array;
				int num19 = 43;
				UserSettingMenu.MENU_TYPE menuType19 = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
				string menuString19 = "Low Battery Warning";
				int[] array39 = new int[2];
				array39[0] = 1;
				array38[num19] = new UserSettingMenu(menuType19, menuString19, array39, new string[]
				{
					"Off",
					"On"
				}, "Sounds a warning tone if the vehicle battery power drops below 11V.");
				array[44] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE, "Self Test", new int[]
				{
					0,
					1
				}, new string[]
				{
					"Off",
					"On"
				}, "Runs a self diagnostic test on the unit to check for faults.");
				array[45] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.DISPLAY, "Main Dim", new int[]
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
				}, "Set a main dim");
				array[46] = new UserSettingMenu(UserSettingMenu.MENU_TYPE.SOUND, "Main Volume", new int[]
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

			// Token: 0x0600029E RID: 670 RVA: 0x00025B68 File Offset: 0x00023D68
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
				int num = array2[0][3] >> 6 & (int)BinaryDefine.b00000001;
				array[30] = (array2[0][3] >> 5 & (int)BinaryDefine.b00000001);
				array[31] = (array2[0][3] >> 2 & (int)BinaryDefine.b00000111);
				int num2 = array2[0][3] >> 1 & (int)BinaryDefine.b00000001;
				array[15] = (int)(array2[0][3] & BinaryDefine.b00000001);
				if (array[31] > 7)
				{
					array[31] = 5;
				}
				array[14] = (array2[0][2] >> 7 & (int)BinaryDefine.b00000001);
				array[4] = (array2[0][2] >> 6 & (int)BinaryDefine.b00000001);
				array[6] = (array2[0][2] >> 5 & (int)BinaryDefine.b00000001);
				array[7] = (array2[0][2] >> 4 & (int)BinaryDefine.b00000001);
				array[8] = (array2[0][2] >> 3 & (int)BinaryDefine.b00000001);
				array[9] = (array2[0][2] >> 2 & (int)BinaryDefine.b00000001);
				array[12] = (array2[0][2] >> 1 & (int)BinaryDefine.b00000001);
				array[13] = (int)(array2[0][2] & BinaryDefine.b00000001);
				array[39] = (array2[0][1] >> 3 & (int)BinaryDefine.b00000001);
				array[42] = (array2[0][1] >> 2 & (int)BinaryDefine.b00000001);
				array[43] = (array2[0][1] >> 1 & (int)BinaryDefine.b00000001);
				array[44] = (int)(array2[0][1] & BinaryDefine.b00000001);
				array[17] = (array2[0][0] >> 7 & (int)BinaryDefine.b00000001);
				array[45] = (array2[0][0] >> 4 & (int)BinaryDefine.b00000111);
				int num3 = array2[0][0] >> 3 & (int)BinaryDefine.b00000001;
				array[46] = (int)(array2[0][0] & BinaryDefine.b00000111);
				if (array[45] > 4)
				{
					array[45] = 4;
				}
				if (array[46] > 6)
				{
					array[46] = 4;
				}
				array[10] = (array2[2][3] >> 5 & (int)BinaryDefine.b00000001);
				array[5] = (array2[4][3] >> 5 & (int)BinaryDefine.b00000001);
				bool flag = (array2[4][3] >> 4 & (int)BinaryDefine.b00000001) != 0;
				int num4 = array2[4][3] >> 3 & (int)BinaryDefine.b00000001;
				array[40] = (int)(array2[4][3] & BinaryDefine.b00000111);
				if (array[40] > 5)
				{
					array[40] = 2;
				}
				array[11] = (array2[4][2] >> 7 & (int)BinaryDefine.b00000001);
				array[32] = (array2[4][2] >> 6 & (int)BinaryDefine.b00000001);
				array[1] = (array2[4][2] >> 3 & (int)BinaryDefine.b00000111);
				array[2] = (int)(array2[4][2] & BinaryDefine.b00000111);
				int num5 = array2[4][1] >> 7 & (int)BinaryDefine.b00000001;
				array[16] = (array2[4][1] >> 5 & (int)BinaryDefine.b00000001);
				array[28] = (array2[4][1] >> 4 & (int)BinaryDefine.b00000001);
				array[27] = (array2[4][1] >> 3 & (int)BinaryDefine.b00000001);
				array[3] = (int)(array2[4][1] & BinaryDefine.b00000111);
				array[26] = (array2[4][0] >> 7 & (int)BinaryDefine.b00000001);
				array[25] = (array2[4][0] >> 6 & (int)BinaryDefine.b00000001);
				array[24] = (array2[4][0] >> 5 & (int)BinaryDefine.b00000001);
				array[23] = (array2[4][0] >> 4 & (int)BinaryDefine.b00000001);
				array[22] = (array2[4][0] >> 3 & (int)BinaryDefine.b00000001);
				array[21] = (array2[4][0] >> 2 & (int)BinaryDefine.b00000001);
				array[20] = (array2[4][0] >> 1 & (int)BinaryDefine.b00000001);
				array[19] = (int)(array2[4][0] & BinaryDefine.b00000001);
				array[33] = (array2[5][2] >> 4 & (int)BinaryDefine.b00001111);
				array[34] = (int)(array2[5][2] & BinaryDefine.b00001111);
				array[38] = (array2[5][1] >> 4 & (int)BinaryDefine.b00001111);
				array[36] = (int)(array2[5][1] & BinaryDefine.b00001111);
				array[37] = (array2[3][3] >> 4 & (int)BinaryDefine.b00001111);
				array[35] = (int)(array2[3][3] & BinaryDefine.b00001111);
				array[41] = (int)(array2[3][2] & BinaryDefine.b00000111);
				if (array[41] < 2 || array[41] > 4)
				{
					array[41] = 2;
				}
				if (array[33] > 12 || array[33] == 0)
				{
					array[33] = 1;
				}
				if (array[34] > 12 || array[34] == 0)
				{
					array[34] = 2;
				}
				if (array[35] > 12 || array[35] == 0)
				{
					array[35] = 2;
				}
				if (array[36] > 12 || array[36] == 0)
				{
					array[36] = 3;
				}
				if (array[37] > 5 || array[37] == 0)
				{
					array[37] = 1;
				}
				if (array[38] > 12 || array[38] == 0)
				{
					array[38] = 4;
				}
				if (num == 1 && num3 == 0)
				{
					array[0] = 0;
				}
				else if (num == 1 && num3 == 1)
				{
					array[0] = 1;
				}
				else if (num == 0)
				{
					array[0] = 2;
				}
				if (!flag)
				{
					if (num2 == 1)
					{
						array[18] = 1;
					}
					else
					{
						array[18] = 0;
					}
				}
				else
				{
					array[18] = 2;
				}
				if (num4 == 1)
				{
					array[29] = 0;
				}
				else if (num5 == 1)
				{
					array[29] = 2;
				}
				else
				{
					array[29] = 1;
				}
				return array;
			}

			// Token: 0x0600029F RID: 671 RVA: 0x00026008 File Offset: 0x00024208
			public byte[] GetNVDataFromUserSetting(int[] userSettingR1, byte[] receivedNVData)
			{
				if (this.menuCnt == 0)
				{
					return null;
				}
				byte[][] array = new byte[6][];
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
				if (userSettingR1[0] == 2)
				{
					b = 0;
					b2 = 0;
				}
				else if (userSettingR1[0] == 1)
				{
					b = 1;
					b2 = 1;
				}
				else
				{
					if (userSettingR1[0] != 0)
					{
						return null;
					}
					b = 1;
					b2 = 0;
				}
				byte b3;
				byte b4;
				if (userSettingR1[18] == 2)
				{
					b3 = 0;
					b4 = 1;
				}
				else if (userSettingR1[18] == 1)
				{
					b3 = 1;
					b4 = 0;
				}
				else
				{
					if (userSettingR1[18] != 0)
					{
						return null;
					}
					b3 = 0;
					b4 = 0;
				}
				byte b5;
				byte b6;
				if (userSettingR1[29] == 2)
				{
					b5 = 0;
					b6 = 1;
				}
				else if (userSettingR1[29] == 1)
				{
					b5 = 0;
					b6 = 0;
				}
				else
				{
					if (userSettingR1[29] != 0)
					{
						return null;
					}
					b5 = 1;
					b6 = 0;
				}
				byte[] array3 = array[0];
				int num = 3;
				array3[num] |= (byte)((int)b << 6 & (int)BinaryDefine.b01000000);
				byte[] array4 = array[0];
				int num2 = 3;
				array4[num2] |= (byte)(userSettingR1[30] << 5 & (int)BinaryDefine.b00100000);
				byte[] array5 = array[0];
				int num3 = 3;
				array5[num3] |= (byte)(userSettingR1[31] << 2 & (int)BinaryDefine.b00011100);
				byte[] array6 = array[0];
				int num4 = 3;
				array6[num4] |= (byte)((int)b3 << 1 & (int)BinaryDefine.b00000010);
				byte[] array7 = array[0];
				int num5 = 3;
				array7[num5] |= (byte)(userSettingR1[15] & (int)BinaryDefine.b00000001);
				byte[] array8 = array[0];
				int num6 = 2;
				array8[num6] |= (byte)(userSettingR1[14] << 7 & (int)BinaryDefine.b10000000);
				byte[] array9 = array[0];
				int num7 = 2;
				array9[num7] |= (byte)(userSettingR1[4] << 6 & (int)BinaryDefine.b01000000);
				byte[] array10 = array[0];
				int num8 = 2;
				array10[num8] |= (byte)(userSettingR1[6] << 5 & (int)BinaryDefine.b00100000);
				byte[] array11 = array[0];
				int num9 = 2;
				array11[num9] |= (byte)(userSettingR1[7] << 4 & (int)BinaryDefine.b00010000);
				byte[] array12 = array[0];
				int num10 = 2;
				array12[num10] |= (byte)(userSettingR1[8] << 3 & (int)BinaryDefine.b00001000);
				byte[] array13 = array[0];
				int num11 = 2;
				array13[num11] |= (byte)(userSettingR1[9] << 2 & (int)BinaryDefine.b00000100);
				byte[] array14 = array[0];
				int num12 = 2;
				array14[num12] |= (byte)(userSettingR1[12] << 1 & (int)BinaryDefine.b00000010);
				byte[] array15 = array[0];
				int num13 = 2;
				array15[num13] |= (byte)(userSettingR1[13] & (int)BinaryDefine.b00000001);
				byte[] array16 = array[0];
				int num14 = 1;
				array16[num14] |= (byte)(userSettingR1[39] << 3 & (int)BinaryDefine.b00001000);
				byte[] array17 = array[0];
				int num15 = 1;
				array17[num15] |= (byte)(userSettingR1[42] << 2 & (int)BinaryDefine.b00000100);
				byte[] array18 = array[0];
				int num16 = 1;
				array18[num16] |= (byte)(userSettingR1[43] << 1 & (int)BinaryDefine.b00000010);
				byte[] array19 = array[0];
				int num17 = 1;
				array19[num17] |= (byte)(userSettingR1[44] & (int)BinaryDefine.b00000001);
				byte[] array20 = array[0];
				int num18 = 0;
				array20[num18] |= (byte)(userSettingR1[17] << 7 & (int)BinaryDefine.b10000000);
				byte[] array21 = array[0];
				int num19 = 0;
				array21[num19] |= (byte)(userSettingR1[45] << 4 & (int)BinaryDefine.b01110000);
				byte[] array22 = array[0];
				int num20 = 0;
				array22[num20] |= (byte)((int)b2 << 3 & (int)BinaryDefine.b00001000);
				byte[] array23 = array[0];
				int num21 = 0;
				array23[num21] |= (byte)(userSettingR1[46] & (int)BinaryDefine.b00000111);
				byte[] array24 = array[2];
				int num22 = 3;
				array24[num22] |= (byte)(userSettingR1[10] << 5 & (int)BinaryDefine.b00100000);
				byte[] array25 = array[4];
				int num23 = 3;
				array25[num23] |= (byte)(userSettingR1[5] << 5 & (int)BinaryDefine.b00100000);
				byte[] array26 = array[4];
				int num24 = 3;
				array26[num24] |= (byte)((int)b4 << 4 & (int)BinaryDefine.b00010000);
				byte[] array27 = array[4];
				int num25 = 3;
				array27[num25] |= (byte)((int)b5 << 3 & (int)BinaryDefine.b00001000);
				byte[] array28 = array[4];
				int num26 = 3;
				array28[num26] |= (byte)(userSettingR1[40] & (int)BinaryDefine.b00000111);
				byte[] array29 = array[4];
				int num27 = 2;
				array29[num27] |= (byte)(userSettingR1[11] << 7 & (int)BinaryDefine.b10000000);
				byte[] array30 = array[4];
				int num28 = 2;
				array30[num28] |= (byte)(userSettingR1[32] << 6 & (int)BinaryDefine.b01000000);
				byte[] array31 = array[4];
				int num29 = 2;
				array31[num29] |= (byte)(userSettingR1[1] << 3 & (int)BinaryDefine.b00111000);
				byte[] array32 = array[4];
				int num30 = 2;
				array32[num30] |= (byte)(userSettingR1[2] & (int)BinaryDefine.b00000111);
				byte[] array33 = array[4];
				int num31 = 1;
				array33[num31] |= (byte)((int)b6 << 7 & (int)BinaryDefine.b10000000);
				byte[] array34 = array[4];
				int num32 = 1;
				array34[num32] |= (byte)(userSettingR1[16] << 5 & (int)BinaryDefine.b00100000);
				byte[] array35 = array[4];
				int num33 = 1;
				array35[num33] |= (byte)(userSettingR1[28] << 4 & (int)BinaryDefine.b00010000);
				byte[] array36 = array[4];
				int num34 = 1;
				array36[num34] |= (byte)(userSettingR1[27] << 3 & (int)BinaryDefine.b00001000);
				byte[] array37 = array[4];
				int num35 = 1;
				array37[num35] |= (byte)(userSettingR1[3] & (int)BinaryDefine.b00000111);
				byte[] array38 = array[4];
				int num36 = 0;
				array38[num36] |= (byte)(userSettingR1[26] << 7 & (int)BinaryDefine.b10000000);
				byte[] array39 = array[4];
				int num37 = 0;
				array39[num37] |= (byte)(userSettingR1[25] << 6 & (int)BinaryDefine.b01000000);
				byte[] array40 = array[4];
				int num38 = 0;
				array40[num38] |= (byte)(userSettingR1[24] << 5 & (int)BinaryDefine.b00100000);
				byte[] array41 = array[4];
				int num39 = 0;
				array41[num39] |= (byte)(userSettingR1[23] << 4 & (int)BinaryDefine.b00010000);
				byte[] array42 = array[4];
				int num40 = 0;
				array42[num40] |= (byte)(userSettingR1[22] << 3 & (int)BinaryDefine.b00001000);
				byte[] array43 = array[4];
				int num41 = 0;
				array43[num41] |= (byte)(userSettingR1[21] << 2 & (int)BinaryDefine.b00000100);
				byte[] array44 = array[4];
				int num42 = 0;
				array44[num42] |= (byte)(userSettingR1[20] << 1 & (int)BinaryDefine.b00000010);
				byte[] array45 = array[4];
				int num43 = 0;
				array45[num43] |= (byte)(userSettingR1[19] & (int)BinaryDefine.b00000001);
				byte[] array46 = array[5];
				int num44 = 2;
				array46[num44] |= (byte)(userSettingR1[33] << 4 & (int)BinaryDefine.b11110000);
				byte[] array47 = array[5];
				int num45 = 2;
				array47[num45] |= (byte)(userSettingR1[34] & (int)BinaryDefine.b00001111);
				byte[] array48 = array[5];
				int num46 = 1;
				array48[num46] |= (byte)(userSettingR1[38] << 4 & (int)BinaryDefine.b11110000);
				byte[] array49 = array[5];
				int num47 = 1;
				array49[num47] |= (byte)(userSettingR1[36] & (int)BinaryDefine.b00001111);
				byte[] array50 = array[3];
				int num48 = 3;
				array50[num48] |= (byte)(userSettingR1[37] << 4 & (int)BinaryDefine.b01110000);
				byte[] array51 = array[3];
				int num49 = 3;
				array51[num49] |= (byte)(userSettingR1[35] & (int)BinaryDefine.b00001111);
				byte[] array52 = array[3];
				int num50 = 2;
				array52[num50] |= (byte)(userSettingR1[41] & (int)BinaryDefine.b00000111);
				Array.Copy(receivedNVData, array2, receivedNVData.Length);
				for (int i = 0; i < array.Length; i++)
				{
					for (int j = 0; j < array[i].Length; j++)
					{
						byte[] array53 = array2;
						int num51 = i * 4 + j;
						// DECOMPILE-FIX: Restore byte narrowing for the exported bit-mask operations
						// in this file; unchecked casts preserve the original IL byte stores.
						array53[num51] &= unchecked((byte)(~this.userNVDataPos[i * 4 + j]));
						byte[] array54 = array2;
						int num52 = i * 4 + j;
						array54[num52] |= array[i][j];
					}
				}
				int num53 = 0;
				for (int i = 0; i < receivedNVData.Length; i++)
				{
					if (receivedNVData[i] == array2[i])
					{
						num53++;
					}
				}
				return array2;
			}

			// Token: 0x040004F5 RID: 1269
			private int supportVersion = 160;

			// Token: 0x040004F6 RID: 1270
			private int menuCnt = 47;

			// Token: 0x040004F7 RID: 1271
			private byte[] userNVDataPos = new byte[]
			{
				byte.MaxValue,
				15,
				byte.MaxValue,
				127,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				32,
				0,
				0,
				7,
				127,
				byte.MaxValue,
				191,
				byte.MaxValue,
				63,
				0,
				byte.MaxValue,
				byte.MaxValue,
				0,
				0,
				0,
				0,
				0
			};

			// Token: 0x040004F8 RID: 1272
			private const int RD_1 = 0;

			// Token: 0x040004F9 RID: 1273
			private const int RD_EMPTY = 1;

			// Token: 0x040004FA RID: 1274
			private const int GPS = 2;

			// Token: 0x040004FB RID: 1275
			private const int RD_4 = 3;

			// Token: 0x040004FC RID: 1276
			private const int RD_2 = 4;

			// Token: 0x040004FD RID: 1277
			private const int RD_3 = 5;

			// Token: 0x040004FE RID: 1278
			private const int ADDR_CNT = 6;

			// Token: 0x020000B2 RID: 178
			private enum MENU
			{
				// Token: 0x040006F0 RID: 1776
				DETECTION_MODE,
				// Token: 0x040006F1 RID: 1777
				X_SENSITIVE,
				// Token: 0x040006F2 RID: 1778
				K_SENSITIVE,
				// Token: 0x040006F3 RID: 1779
				KA_SENSITIVE,
				// Token: 0x040006F4 RID: 1780
				VOICE_ENABLE,
				// Token: 0x040006F5 RID: 1781
				KA_FREQ_VOICE,
				// Token: 0x040006F6 RID: 1782
				X_BAND_ENABLE,
				// Token: 0x040006F7 RID: 1783
				K_BAND_ENABLE,
				// Token: 0x040006F8 RID: 1784
				KA_BAND_ENABLE,
				// Token: 0x040006F9 RID: 1785
				LASER_ENABLE,
				// Token: 0x040006FA RID: 1786
				K_POP_ENABLE,
				// Token: 0x040006FB RID: 1787
				MRCD_ENABLE,
				// Token: 0x040006FC RID: 1788
				KA_POP_ENABLE,
				// Token: 0x040006FD RID: 1789
				K_FILTER_ENABLE,
				// Token: 0x040006FE RID: 1790
				KA_FILTER_ENABLE,
				// Token: 0x040006FF RID: 1791
				TSF_ENABLE,
				// Token: 0x04000700 RID: 1792
				K_BLOCK_FILTER_MODE,
				// Token: 0x04000701 RID: 1793
				K_NARROW,
				// Token: 0x04000702 RID: 1794
				KA_NARROW,
				// Token: 0x04000703 RID: 1795
				KA_SEG1,
				// Token: 0x04000704 RID: 1796
				KA_SEG2,
				// Token: 0x04000705 RID: 1797
				KA_SEG3,
				// Token: 0x04000706 RID: 1798
				KA_SEG4,
				// Token: 0x04000707 RID: 1799
				KA_SEG5,
				// Token: 0x04000708 RID: 1800
				KA_SEG6,
				// Token: 0x04000709 RID: 1801
				KA_SEG7,
				// Token: 0x0400070A RID: 1802
				KA_SEG8,
				// Token: 0x0400070B RID: 1803
				KA_SEG9,
				// Token: 0x0400070C RID: 1804
				KA_SEG10,
				// Token: 0x0400070D RID: 1805
				PRIORITY_MODE,
				// Token: 0x0400070E RID: 1806
				ALL_THREAT_DISPLAY_ENABLE,
				// Token: 0x0400070F RID: 1807
				BACKGROUND_COLOR,
				// Token: 0x04000710 RID: 1808
				MAIN_DISPLAY,
				// Token: 0x04000711 RID: 1809
				X_BAND_ALERT_TONE,
				// Token: 0x04000712 RID: 1810
				K_BAND_ALERT_TONE,
				// Token: 0x04000713 RID: 1811
				MRCD_ALERT_TONE,
				// Token: 0x04000714 RID: 1812
				KA_BAND_ALERT_TONE,
				// Token: 0x04000715 RID: 1813
				KA_BAND_BOGEY_TONE,
				// Token: 0x04000716 RID: 1814
				LASER_ALERT_TONE,
				// Token: 0x04000717 RID: 1815
				AUTO_MUTE_ENABLE,
				// Token: 0x04000718 RID: 1816
				AUTO_MUTE_VOLUME,
				// Token: 0x04000719 RID: 1817
				DARK_MODE_BRIGHTNESS,
				// Token: 0x0400071A RID: 1818
				BACKLIGHT_MODE,
				// Token: 0x0400071B RID: 1819
				LOW_BATT_WARNING_ENABLE,
				// Token: 0x0400071C RID: 1820
				SELF_TEST_ENABLE,
				// Token: 0x0400071D RID: 1821
				MAIN_DIM_SET,
				// Token: 0x0400071E RID: 1822
				MAIN_VOLUME
			}
		}
	}
}
