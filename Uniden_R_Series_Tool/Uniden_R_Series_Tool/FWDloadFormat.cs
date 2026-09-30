using System;
using System.Text;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000019 RID: 25
	public static class FWDloadFormat
	{
		// Token: 0x0600012E RID: 302 RVA: 0x0001726C File Offset: 0x0001546C
		public static byte[] OldModelDecoder(byte[] key, byte[] data, int offset, int len)
		{
			byte[] array = new byte[len];
			if (key.Length != 1)
			{
				return null;
			}
			for (int i = 0; i < len; i += 4)
			{
				// DECOMPILE-FIX: Restore byte narrowing for the exported bit-mask operations
				// in this file; unchecked casts preserve the original IL byte stores.
				array[i] = unchecked((byte)(data[i + offset] & 3));
				byte[] array2 = array;
				int num = i;
				array2[num] += (byte)((data[i + 1 + offset] & 3) << 2);
				byte[] array3 = array;
				int num2 = i;
				array3[num2] += (byte)((data[i + 2 + offset] & 3) << 4);
				byte[] array4 = array;
				int num3 = i;
				array4[num3] += (byte)((data[i + 3 + offset] & 3) << 6);
				array[i + 1] = (byte)((data[i + offset] & 12) >> 2);
				byte[] array5 = array;
				int num4 = i + 1;
				array5[num4] += unchecked((byte)(data[i + 1 + offset] & 12));
				byte[] array6 = array;
				int num5 = i + 1;
				array6[num5] += (byte)((data[i + 2 + offset] & 12) << 2);
				byte[] array7 = array;
				int num6 = i + 1;
				array7[num6] += (byte)((data[i + 3 + offset] & 12) << 4);
				array[i + 2] = (byte)((data[i + offset] & 48) >> 4);
				byte[] array8 = array;
				int num7 = i + 2;
				array8[num7] += (byte)((data[i + 1 + offset] & 48) >> 2);
				byte[] array9 = array;
				int num8 = i + 2;
				array9[num8] += unchecked((byte)(data[i + 2 + offset] & 48));
				byte[] array10 = array;
				int num9 = i + 2;
				array10[num9] += (byte)((data[i + 3 + offset] & 48) << 2);
				array[i + 3] = (byte)((data[i + offset] & 192) >> 6);
				byte[] array11 = array;
				int num10 = i + 3;
				array11[num10] += (byte)((data[i + 1 + offset] & 192) >> 4);
				byte[] array12 = array;
				int num11 = i + 3;
				array12[num11] += (byte)((data[i + 2 + offset] & 192) >> 2);
				byte[] array13 = array;
				int num12 = i + 3;
				array13[num12] += unchecked((byte)(data[i + 3 + offset] & 192));
				byte[] array14 = array;
				int num13 = i;
				array14[num13] -= key[0];
				byte[] array15 = array;
				int num14 = i + 1;
				array15[num14] -= key[0];
				byte[] array16 = array;
				int num15 = i + 2;
				array16[num15] -= key[0];
				byte[] array17 = array;
				int num16 = i + 3;
				array17[num16] -= key[0];
			}
			return array;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0001745C File Offset: 0x0001565C
		public static byte GetCheckSumByteFromBuffer(byte[] b)
		{
			byte b2 = 0;
			for (int i = 0; i < b.Length; i++)
			{
				b2 ^= b[i];
			}
			return b2;
		}

		// Token: 0x04000192 RID: 402
		public static int DLOAD_SEND_DATA_ERROR_RETRY_CNT = 3;

		// Token: 0x04000193 RID: 403
		public static int DLOAD_FAIL_CURRENT_TARGET_RETRY_CNT = 3;

		// Token: 0x04000194 RID: 404
		public static string[] oldFileGPSDBIdentifyStr = new string[]
		{
			"LRDB",
			"DFDB",
			"IRDB"
		};

		// Token: 0x04000195 RID: 405
		public static string[] newFileGPSDBIdentifyStr = new string[]
		{
			"AEUS",
			"AENZ",
			"AEIL",
			"AEEU"
		};

		// Token: 0x04000196 RID: 406
		public static int time50msec = 50;

		// Token: 0x04000197 RID: 407
		public static int time100msec = 100;

		// Token: 0x04000198 RID: 408
		public static int time200msec = 200;

		// Token: 0x04000199 RID: 409
		public static int time300msec = 300;

		// Token: 0x0400019A RID: 410
		public static int time500msec = 500;

		// Token: 0x0400019B RID: 411
		public static int time800msec = 800;

		// Token: 0x0400019C RID: 412
		public static int time1sec = 1000;

		// Token: 0x0400019D RID: 413
		public static int time2sec = 2000;

		// Token: 0x0400019E RID: 414
		public static int time3sec = 3000;

		// Token: 0x0400019F RID: 415
		public static int time5sec = 5000;

		// Token: 0x040001A0 RID: 416
		public static int DLOAD_RDY_WAIT_TIME = 1200;

		// Token: 0x040001A1 RID: 417
		public static int DLOAD_CODE_DATA_RSP_WAIT_TIME = 2500;

		// Token: 0x040001A2 RID: 418
		public static int DLOAD_END_RSP_WAIT_TIME = 1000;

		// Token: 0x040001A3 RID: 419
		public static int DLOAD_MCU_REBOOT_DELAY_TIME = 500;

		// Token: 0x040001A4 RID: 420
		public static int downloadCmdLength = 3;

		// Token: 0x040001A5 RID: 421
		public static byte[] downloadCmdBeacon = new byte[]
		{
			253
		};

		// Token: 0x040001A6 RID: 422
		public static byte[] downloadCmdBeaconRsp = new byte[]
		{
			254
		};

		// Token: 0x040001A7 RID: 423
		public static byte[] downloadCmdACK = new byte[]
		{
			6
		};

		// Token: 0x040001A8 RID: 424
		public static byte[] downloadCmdNACK = new byte[]
		{
			21
		};

		// Token: 0x040001A9 RID: 425
		public static byte[] downloadCmdSync = Encoding.UTF8.GetBytes("SYN");

		// Token: 0x040001AA RID: 426
		public static byte[] downloadCmdTxReady = Encoding.UTF8.GetBytes("DAT");

		// Token: 0x040001AB RID: 427
		public static byte[] downloadCmdRxReady = Encoding.UTF8.GetBytes("RDY");

		// Token: 0x040001AC RID: 428
		public static byte[] downloadCmdEnd = Encoding.UTF8.GetBytes("END");

		// Token: 0x040001AD RID: 429
		public static byte[] downloadCmdRxDB1Ready = Encoding.UTF8.GetBytes("RDY");

		// Token: 0x040001AE RID: 430
		public static byte[] downloadCmdRxDB2Ready = Encoding.UTF8.GetBytes("RDA");

		// Token: 0x040001AF RID: 431
		public static byte[] downloadCmdUIDload = Encoding.UTF8.GetBytes("UWS");

		// Token: 0x040001B0 RID: 432
		public static byte[] downloadCmdUIVer = Encoding.UTF8.GetBytes("SWV");

		// Token: 0x040001B1 RID: 433
		public static byte[] downloadCmdDSPDload = Encoding.UTF8.GetBytes("DSW");

		// Token: 0x040001B2 RID: 434
		public static byte[] downloadCmdDSPVer = Encoding.UTF8.GetBytes("VDF");

		// Token: 0x040001B3 RID: 435
		public static byte[] downloadCmdGPSDload = Encoding.UTF8.GetBytes("FSW");

		// Token: 0x040001B4 RID: 436
		public static byte[] downloadCmdGPSVer = Encoding.UTF8.GetBytes("VSF");

		// Token: 0x040001B5 RID: 437
		public static byte[] downloadCmdSoundDBDload = Encoding.UTF8.GetBytes("VWU");

		// Token: 0x040001B6 RID: 438
		public static byte[] downloadCmdSoundDBVer = Encoding.UTF8.GetBytes("VVR");

		// Token: 0x040001B7 RID: 439
		public static byte[] downloadCmdGPSDBDload = Encoding.UTF8.GetBytes("DBW");

		// Token: 0x040001B8 RID: 440
		public static byte[] downloadCmdGPSDBVer = Encoding.UTF8.GetBytes("VBD");

		// Token: 0x040001B9 RID: 441
		public static byte[] downloadCmdFlashClear = Encoding.UTF8.GetBytes("CLR");

		// Token: 0x040001BA RID: 442
		public static byte[] downloadCmdBLEDload = Encoding.UTF8.GetBytes("LEW");

		// Token: 0x040001BB RID: 443
		public static byte[] downloadCmdBLEVer = Encoding.UTF8.GetBytes("VLE");

		// Token: 0x040001BC RID: 444
		public static byte[] downloadCmdBLEGetWifiAPInfo = Encoding.UTF8.GetBytes("LEG");

		// Token: 0x040001BD RID: 445
		public static byte[] downloadCmdBLESetWifiAPInfo = Encoding.UTF8.GetBytes("LES");

		// Token: 0x040001BE RID: 446
		public static byte[] userSettingRead = Encoding.UTF8.GetBytes("USR");

		// Token: 0x040001BF RID: 447
		public static byte[] userSettingWrite = Encoding.UTF8.GetBytes("USW");

		// Token: 0x040001C0 RID: 448
		public static byte[] userMarkRead = Encoding.UTF8.GetBytes("UMR");

		// Token: 0x040001C1 RID: 449
		public static byte[] muteMemoryRead = Encoding.UTF8.GetBytes("MMR");

		// Token: 0x040001C2 RID: 450
		public static byte[] autoMuteMemoryRead = Encoding.UTF8.GetBytes("AMR");

		// Token: 0x040001C3 RID: 451
		public static byte[] downloadCmdUIMCUIDNuNu_R1 = Encoding.UTF8.GetBytes("REN");

		// Token: 0x040001C4 RID: 452
		public static byte[] downloadCmdUIMCUIDNuLa_R1 = Encoding.UTF8.GetBytes("REL");

		// Token: 0x040001C5 RID: 453
		public static byte[] downloadCmdDSPMCUIDNuv_R1 = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001C6 RID: 454
		public static byte[] downloadCmdDSPMCUIDNuv2_R1 = new byte[]
		{
			77,
			50,
			65
		};

		// Token: 0x040001C7 RID: 455
		public static byte[] downloadCmdDSPMCUIDNuv3_R1 = new byte[]
		{
			77,
			51,
			65
		};

		// Token: 0x040001C8 RID: 456
		public static byte[] downloadCmdUIMCUIDNuNu_R3 = Encoding.UTF8.GetBytes("REN");

		// Token: 0x040001C9 RID: 457
		public static byte[] downloadCmdUIMCUIDNuLa_R3 = Encoding.UTF8.GetBytes("REL");

		// Token: 0x040001CA RID: 458
		public static byte[] downloadCmdUIMCUIDNu2La_R3 = Encoding.UTF8.GetBytes("RES");

		// Token: 0x040001CB RID: 459
		public static byte[] downloadCmdDSPMCUIDNuv_R3 = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001CC RID: 460
		public static byte[] downloadCmdDSPMCUIDNuv2_R3 = new byte[]
		{
			77,
			50,
			65
		};

		// Token: 0x040001CD RID: 461
		public static byte[] downloadCmdDSPMCUIDNuv3_R3 = new byte[]
		{
			77,
			51,
			65
		};

		// Token: 0x040001CE RID: 462
		public static byte[] downloadCmdGPSMCUIDNuv_R3 = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001CF RID: 463
		public static byte[] downloadCmdGPSMCUIDSTM_R3 = new byte[]
		{
			77,
			49,
			64
		};

		// Token: 0x040001D0 RID: 464
		public static byte[] downloadCmdGPSMCUIDNuv2_R3 = new byte[]
		{
			77,
			50,
			64
		};

		// Token: 0x040001D1 RID: 465
		public static byte[] downloadCmdGPSMCUIDNuv3_R3 = new byte[]
		{
			77,
			51,
			64
		};

		// Token: 0x040001D2 RID: 466
		public static byte[] downloadCmdUIMCUIDNuNu_R7 = Encoding.UTF8.GetBytes("REN");

		// Token: 0x040001D3 RID: 467
		public static byte[] downloadCmdUIMCUIDNuLa_R7 = Encoding.UTF8.GetBytes("REL");

		// Token: 0x040001D4 RID: 468
		public static byte[] downloadCmdUIMCUIDSTLa_R7 = Encoding.UTF8.GetBytes("RES");

		// Token: 0x040001D5 RID: 469
		public static byte[] downloadCmdUIMCUIDNuNu_R7IL = Encoding.UTF8.GetBytes("REO");

		// Token: 0x040001D6 RID: 470
		public static byte[] downloadCmdUIMCUIDNuLa_R7IL = Encoding.UTF8.GetBytes("REP");

		// Token: 0x040001D7 RID: 471
		public static byte[] downloadCmdUIMCUIDSTLa_R7IL = Encoding.UTF8.GetBytes("REQ");

		// Token: 0x040001D8 RID: 472
		public static byte[] downloadCmdDSPMCUIDNuv_R7 = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001D9 RID: 473
		public static byte[] downloadCmdDSPMCUIDSTM_R7 = new byte[]
		{
			77,
			49,
			65
		};

		// Token: 0x040001DA RID: 474
		public static byte[] downloadCmdGPSMCUIDNuv_R7 = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001DB RID: 475
		public static byte[] downloadCmdGPSMCUIDSTM_R7 = new byte[]
		{
			77,
			49,
			64
		};

		// Token: 0x040001DC RID: 476
		public static byte[] downloadCmdUIMCUIDNuLa_R4 = Encoding.UTF8.GetBytes("REN");

		// Token: 0x040001DD RID: 477
		public static byte[] downloadCmdUIMCUIDNuLa_R4NZ = Encoding.UTF8.GetBytes("REP");

		// Token: 0x040001DE RID: 478
		public static byte[] downloadCmdUIMCUIDNuLa_R4IL = Encoding.UTF8.GetBytes("REO");

		// Token: 0x040001DF RID: 479
		public static byte[] downloadCmdUIMCUIDNuLa_R4EU = Encoding.UTF8.GetBytes("REQ");

		// Token: 0x040001E0 RID: 480
		public static byte[] downloadCmdDSPMCUIDNuv_R4 = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001E1 RID: 481
		public static byte[] downloadCmdDSPMCUIDNuv_R4NZ = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001E2 RID: 482
		public static byte[] downloadCmdDSPMCUIDNuv_R4IL = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001E3 RID: 483
		public static byte[] downloadCmdDSPMCUIDNuv_R4EU = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001E4 RID: 484
		public static byte[] downloadCmdGPSMCUIDNuv_R4 = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001E5 RID: 485
		public static byte[] downloadCmdGPSMCUIDNuv_R4NZ = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001E6 RID: 486
		public static byte[] downloadCmdGPSMCUIDNuv_R4IL = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001E7 RID: 487
		public static byte[] downloadCmdGPSMCUIDNuv_R4EU = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001E8 RID: 488
		public static byte[] downloadCmdUIMCUIDNuLa_R8 = Encoding.UTF8.GetBytes("REN");

		// Token: 0x040001E9 RID: 489
		public static byte[] downloadCmdUIMCUIDNuLa_R8NZ = Encoding.UTF8.GetBytes("REP");

		// Token: 0x040001EA RID: 490
		public static byte[] downloadCmdUIMCUIDNuLa_R8IL = Encoding.UTF8.GetBytes("REO");

		// Token: 0x040001EB RID: 491
		public static byte[] downloadCmdUIMCUIDNuLa_R8EU = Encoding.UTF8.GetBytes("REQ");

		// Token: 0x040001EC RID: 492
		public static byte[] downloadCmdDSPMCUIDNuv_R8 = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001ED RID: 493
		public static byte[] downloadCmdDSPMCUIDNuv_R8NZ = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001EE RID: 494
		public static byte[] downloadCmdDSPMCUIDNuv_R8IL = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001EF RID: 495
		public static byte[] downloadCmdDSPMCUIDNuv_R8EU = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001F0 RID: 496
		public static byte[] downloadCmdGPSMCUIDNuv_R8 = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001F1 RID: 497
		public static byte[] downloadCmdGPSMCUIDNuv_R8NZ = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001F2 RID: 498
		public static byte[] downloadCmdGPSMCUIDNuv_R8IL = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001F3 RID: 499
		public static byte[] downloadCmdGPSMCUIDNuv_R8EU = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001F4 RID: 500
		public static byte[] downloadCmdUIMCUIDNuLa_R4W = Encoding.UTF8.GetBytes("REN");

		// Token: 0x040001F5 RID: 501
		public static byte[] downloadCmdDSPMCUIDNuv_R4W = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001F6 RID: 502
		public static byte[] downloadCmdGPSMCUIDNuv_R4W = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001F7 RID: 503
		public static byte[] downloadCmdUIMCUIDNuLa_R8W = Encoding.UTF8.GetBytes("REN");

		// Token: 0x040001F8 RID: 504
		public static byte[] downloadCmdDSPMCUIDNuv_R8W = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001F9 RID: 505
		public static byte[] downloadCmdGPSMCUIDNuv_R8W = new byte[]
		{
			77,
			48,
			64
		};

		// Token: 0x040001FA RID: 506
		public static byte[] downloadCmdBLEMCUID = new byte[]
		{
			77,
			48,
			66
		};

		// Token: 0x040001FB RID: 507
		public static byte[] downloadCmdGPSMCUID_TOMS_BUG = new byte[]
		{
			77,
			48,
			65
		};

		// Token: 0x040001FC RID: 508
		public static int uiOnePage = 512;

		// Token: 0x040001FD RID: 509
		public static int dspOnePage = 512;

		// Token: 0x040001FE RID: 510
		public static int gpsOnePage = 512;

		// Token: 0x040001FF RID: 511
		public static int soundDBOnePage = 1024;

		// Token: 0x04000200 RID: 512
		public static int gpsDBOnePage = 128;

		// Token: 0x04000201 RID: 513
		public static int bleOnPage = 1024;

		// Token: 0x04000202 RID: 514
		public static int keypadOnPage = 1024;

		// Token: 0x04000203 RID: 515
		public static int laserIFOnPage = 1024;

		// Token: 0x04000204 RID: 516
		public static byte[] soundDBKey = new byte[]
		{
			225
		};

		// Token: 0x04000205 RID: 517
		public static byte[] oldUSgpsDBKey = new byte[]
		{
			210
		};

		// Token: 0x04000206 RID: 518
		public static byte[] oldNZgpsDBKey = new byte[]
		{
			194
		};

		// Token: 0x04000207 RID: 519
		public static byte[] oldILgpsDBKey = new byte[]
		{
			226
		};

		// Token: 0x02000049 RID: 73
		public enum DLOAD_RESULT
		{
			// Token: 0x0400045A RID: 1114
			FAIL_TIMEOUT,
			// Token: 0x0400045B RID: 1115
			FAIL_UNKNOWN_MCU_ID,
			// Token: 0x0400045C RID: 1116
			FAIL_FILE_NOT_EXISTED,
			// Token: 0x0400045D RID: 1117
			FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE,
			// Token: 0x0400045E RID: 1118
			FAIL_CONFIRM_DATA_IS_NOT_VALID,
			// Token: 0x0400045F RID: 1119
			FAIL_DOSE_NOT_SUPPORT,
			// Token: 0x04000460 RID: 1120
			FAIL_VOICE_IC_IS_UNKNOWN,
			// Token: 0x04000461 RID: 1121
			OKAY
		}

		// Token: 0x0200004A RID: 74
		public enum DB_CHECK
		{
			// Token: 0x04000463 RID: 1123
			ERROR_IS_NOT_OLD_ENC_DB,
			// Token: 0x04000464 RID: 1124
			ERROR_IS_NOT_AES128_DB,
			// Token: 0x04000465 RID: 1125
			OKAY_IS_VALID_DB,
			// Token: 0x04000466 RID: 1126
			OKAY_DB_NOT_EXIST
		}

		// Token: 0x0200004B RID: 75
		public enum Step
		{
			// Token: 0x04000468 RID: 1128
			UI,
			// Token: 0x04000469 RID: 1129
			DSP,
			// Token: 0x0400046A RID: 1130
			GPS,
			// Token: 0x0400046B RID: 1131
			SOUND_DB,
			// Token: 0x0400046C RID: 1132
			GPS_DB,
			// Token: 0x0400046D RID: 1133
			BLE,
			// Token: 0x0400046E RID: 1134
			StepNum
		}

		// Token: 0x0200004C RID: 76
		public enum VOICE_IC
		{
			// Token: 0x04000470 RID: 1136
			NUVOTON_IC,
			// Token: 0x04000471 RID: 1137
			LAPIS1_IC = 21504,
			// Token: 0x04000472 RID: 1138
			LAPIS2_IC = 43008,
			// Token: 0x04000473 RID: 1139
			UNKNOWN = 65535
		}

		// Token: 0x0200004D RID: 77
		public enum GPS_DB_COUNTRY
		{
			// Token: 0x04000475 RID: 1141
			US,
			// Token: 0x04000476 RID: 1142
			NZ,
			// Token: 0x04000477 RID: 1143
			IL,
			// Token: 0x04000478 RID: 1144
			EU,
			// Token: 0x04000479 RID: 1145
			NONE
		}

		// Token: 0x0200004E RID: 78
		public enum GPS_DB_TYPE
		{
			// Token: 0x0400047B RID: 1147
			GPS_DB_OLD_ENC,
			// Token: 0x0400047C RID: 1148
			GPS_DB_AES128,
			// Token: 0x0400047D RID: 1149
			UNKNOWN
		}
	}
}
