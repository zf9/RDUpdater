using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000013 RID: 19
	public static class ReadRDVersionInfo
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x000101D8 File Offset: 0x0000E3D8
		public static byte[] GetMCUID(UARTCommUtils uart, RDInfo modelInfo, FWDloadFormat.Step step)
		{
			byte[] writeBytes;
			switch (step)
			{
			case FWDloadFormat.Step.UI:
				writeBytes = FWDloadFormat.downloadCmdUIDload;
				goto IL_42;
			case FWDloadFormat.Step.DSP:
				writeBytes = FWDloadFormat.downloadCmdDSPDload;
				goto IL_42;
			case FWDloadFormat.Step.GPS:
				writeBytes = FWDloadFormat.downloadCmdGPSDload;
				goto IL_42;
			case FWDloadFormat.Step.BLE:
				writeBytes = FWDloadFormat.downloadCmdBLEDload;
				goto IL_42;
			}
			return null;
			IL_42:
			if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
			{
				return null;
			}
			LogClass.WriteLog("Beacon Communication");
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
			{
				return null;
			}
			LogClass.WriteLog("Tx: SYN");
			if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
			{
				return null;
			}
			LogClass.WriteLog("Rx: SYN");
			if (!uart.WriteBytes(writeBytes))
			{
				return null;
			}
			LogClass.WriteLog("Tx: Dload Cmd");
			byte[] result = uart.NByteRead(FWDloadFormat.downloadCmdLength, FWDloadFormat.time500msec, false);
			Thread.Sleep(200);
			return result;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000102B0 File Offset: 0x0000E4B0
		public static int[] GetUIVersion(UARTCommUtils uart, RDInfo modelInfo)
		{
			int[] array = new int[2];
			int num = ReadRDVersionInfo.VersionInfoRead(uart, FWDloadFormat.Step.UI, modelInfo);
			if (num == -1)
			{
				array[0] = -1;
				array[1] = -1;
			}
			else
			{
				array[0] = (int)ReadRDVersionInfo.getModelNumber(num);
				array[1] = ReadRDVersionInfo.getVersion(num);
			}
			return array;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000102F0 File Offset: 0x0000E4F0
		public static int GetDSPVersion(UARTCommUtils uart, RDInfo modelInfo)
		{
			int num = ReadRDVersionInfo.VersionInfoRead(uart, FWDloadFormat.Step.DSP, modelInfo);
			if (num == -1)
			{
				return -1;
			}
			num = ReadRDVersionInfo.getVersion(num);
			if (num < 100 || num > 999)
			{
				return -1;
			}
			return num;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00010324 File Offset: 0x0000E524
		public static int GetGPSVersion(UARTCommUtils uart, RDInfo modelInfo)
		{
			int num = ReadRDVersionInfo.VersionInfoRead(uart, FWDloadFormat.Step.GPS, modelInfo);
			if (num == -1)
			{
				return -1;
			}
			num = ReadRDVersionInfo.getVersion(num);
			if (num < 100 || num > 999)
			{
				return -1;
			}
			return num;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00010358 File Offset: 0x0000E558
		public static int[] GetSoundDBVersion(UARTCommUtils uart, RDInfo modelInfo)
		{
			int[] array = new int[2];
			int num = ReadRDVersionInfo.VersionInfoRead(uart, FWDloadFormat.Step.SOUND_DB, modelInfo);
			if (num == -1)
			{
				array[0] = 65535;
				array[1] = -1;
			}
			else
			{
				array[0] = (int)ReadRDVersionInfo.getVoiceICModel(num);
				array[1] = ReadRDVersionInfo.getVersion(num);
				if (array[1] < 100 || array[1] > 999)
				{
					array[1] = -1;
				}
			}
			return array;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000103B0 File Offset: 0x0000E5B0
		public static int GetGPSDBVersion(UARTCommUtils uart, RDInfo modelInfo)
		{
			int num = ReadRDVersionInfo.VersionInfoRead(uart, FWDloadFormat.Step.GPS_DB, modelInfo);
			if (num == -1)
			{
				return -1;
			}
			if (num < 100 || num > 99991231)
			{
				return -1;
			}
			return num;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000103DC File Offset: 0x0000E5DC
		public static int GetBLEVersion(UARTCommUtils uart, RDInfo modelInfo)
		{
			int num = ReadRDVersionInfo.VersionInfoRead(uart, FWDloadFormat.Step.BLE, modelInfo);
			if (num == -1)
			{
				return -1;
			}
			num = ReadRDVersionInfo.getVersion(num);
			if (num < 100 || num > 999)
			{
				return -1;
			}
			return num;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00010410 File Offset: 0x0000E610
		public static byte[] GetUserSetting(UARTCommUtils uart, RDInfo modelInfo)
		{
			byte[] array = ReadRDVersionInfo.UserSettingRead(uart, modelInfo);
			if (array == null)
			{
				return null;
			}
			return array;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0001042B File Offset: 0x0000E62B
		public static bool SetUserSetting(UARTCommUtils uart, RDInfo modelInfo, byte[] userSetting)
		{
			return ReadRDVersionInfo.UserSettingWrite(uart, modelInfo, userSetting);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0001043C File Offset: 0x0000E63C
		private static int VersionInfoRead(UARTCommUtils uart, FWDloadFormat.Step step, RDInfo modelInfo)
		{
			byte[] writeBytes;
			switch (step)
			{
			case FWDloadFormat.Step.UI:
				writeBytes = FWDloadFormat.downloadCmdUIVer;
				break;
			case FWDloadFormat.Step.DSP:
				writeBytes = FWDloadFormat.downloadCmdDSPVer;
				break;
			case FWDloadFormat.Step.GPS:
				writeBytes = FWDloadFormat.downloadCmdGPSVer;
				break;
			case FWDloadFormat.Step.SOUND_DB:
				writeBytes = FWDloadFormat.downloadCmdSoundDBVer;
				break;
			case FWDloadFormat.Step.GPS_DB:
				writeBytes = FWDloadFormat.downloadCmdGPSDBVer;
				break;
			case FWDloadFormat.Step.BLE:
				writeBytes = FWDloadFormat.downloadCmdBLEVer;
				break;
			default:
				return -1;
			}
			if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
			{
				return -1;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
			{
				return -1;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
			{
				return -1;
			}
			if (!uart.WriteBytes(writeBytes))
			{
				return -1;
			}
			if (step == FWDloadFormat.Step.SOUND_DB)
			{
				if (!uart.CompareRead(FWDloadFormat.downloadCmdTxReady, FWDloadFormat.time1sec, false))
				{
					return -1;
				}
			}
			else if (!uart.CompareRead(FWDloadFormat.downloadCmdTxReady, FWDloadFormat.time300msec, false))
			{
				return -1;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
			{
				return -1;
			}
			int num;
			if (step == FWDloadFormat.Step.GPS_DB)
			{
				byte[] array = uart.NByteRead(4, FWDloadFormat.time200msec, false);
				if (array == null)
				{
					return -1;
				}
				if (!uart.WriteBytes(array))
				{
					return -1;
				}
				num = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 4);
				if (num == -1)
				{
					return -1;
				}
			}
			else
			{
				byte[] array = uart.NByteRead(2, FWDloadFormat.time200msec, false);
				if (array == null)
				{
					return -1;
				}
				if (!uart.WriteBytes(array))
				{
					return -1;
				}
				num = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2);
				if (num == -1)
				{
					return -1;
				}
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
			{
				return -1;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdEnd))
			{
				return -1;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
			{
				return -1;
			}
			return num;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000105B8 File Offset: 0x0000E7B8
		private static byte[] UserSettingRead(UARTCommUtils uart, RDInfo modelInfo)
		{
			if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
			{
				return null;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
			{
				return null;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
			{
				return null;
			}
			if (!uart.WriteBytes(FWDloadFormat.userSettingRead))
			{
				return null;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdTxReady, FWDloadFormat.time3sec, false))
			{
				return null;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
			{
				return null;
			}
			byte[] array = uart.NByteRead(2, FWDloadFormat.time200msec, false);
			if (array == null)
			{
				return null;
			}
			int byteCnt = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2);
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
			{
				return null;
			}
			array = uart.NByteRead(byteCnt, FWDloadFormat.time500msec, false);
			if (array == null)
			{
				return null;
			}
			byte[] array2 = uart.NByteRead(1, FWDloadFormat.time500msec, false);
			if (array2 == null)
			{
				return null;
			}
			if (FWDloadFormat.GetCheckSumByteFromBuffer(array) != array2[0])
			{
				return null;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
			{
				return null;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdEnd, FWDloadFormat.time200msec, false))
			{
				return null;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
			{
				return null;
			}
			return array;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000106C4 File Offset: 0x0000E8C4
		private static bool UserSettingWrite(UARTCommUtils uart, RDInfo modelInfo, byte[] userSetting)
		{
			// DECOMPILE-FIX: Preserve the original newarr/pop allocation using a legal discard statement.
			_ = new byte[2];
			byte[] array = new byte[2];
			byte[] array2 = new byte[1];
			if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
			{
				return false;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
			{
				return false;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
			{
				return false;
			}
			if (!uart.WriteBytes(FWDloadFormat.userSettingWrite))
			{
				return false;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdTxReady, FWDloadFormat.time500msec, false))
			{
				return false;
			}
			array[0] = (byte)(userSetting.Length & 255);
			array[1] = (byte)((userSetting.Length & 65280) >> 8);
			if (!uart.WriteBytes(array))
			{
				return false;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
			{
				return false;
			}
			array2[0] = FWDloadFormat.GetCheckSumByteFromBuffer(userSetting);
			return uart.WriteBytes(userSetting) && uart.WriteBytes(array2) && uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time500msec, false) && uart.WriteBytes(FWDloadFormat.downloadCmdEnd) && uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000107DC File Offset: 0x0000E9DC
		public static string GetWifiInfo(UARTCommUtils uart, RDInfo modelInfo)
		{
			string result = string.Empty;
			if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
			{
				return null;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
			{
				return null;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
			{
				return null;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdBLEGetWifiAPInfo))
			{
				return null;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdTxReady, FWDloadFormat.time3sec, false))
			{
				return null;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
			{
				return null;
			}
			byte[] array = uart.NByteRead(2, FWDloadFormat.time200msec, false);
			if (array == null)
			{
				return null;
			}
			int byteCnt = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2);
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
			{
				return null;
			}
			array = uart.NByteRead(byteCnt, FWDloadFormat.time500msec, false);
			if (array == null)
			{
				return null;
			}
			byte[] array2 = uart.NByteRead(1, FWDloadFormat.time500msec, false);
			if (array2 == null)
			{
				return null;
			}
			if (FWDloadFormat.GetCheckSumByteFromBuffer(array) != array2[0])
			{
				return null;
			}
			result = Encoding.Default.GetString(array);
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
			{
				return null;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdEnd, FWDloadFormat.time200msec, false))
			{
				return null;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000108FC File Offset: 0x0000EAFC
		public static bool SetWifiInfo(UARTCommUtils uart, RDInfo modelInfo, string wifi_ap_info, string passkey)
		{
			byte[] array = new byte[2];
			byte[] array2 = new byte[2];
			byte[] array3 = new byte[1];
			if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
			{
				return false;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
			{
				return false;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
			{
				return false;
			}
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdBLESetWifiAPInfo))
			{
				return false;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdTxReady, FWDloadFormat.time500msec, false))
			{
				return false;
			}
			byte[] bytes = Encoding.Default.GetBytes(wifi_ap_info);
			int num = bytes.Length;
			array[0] = (byte)(num & 255);
			array[1] = (byte)((num & 65280) >> 8);
			if (!uart.WriteBytes(array))
			{
				return false;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
			{
				return false;
			}
			array3[0] = FWDloadFormat.GetCheckSumByteFromBuffer(bytes);
			if (!uart.WriteBytes(bytes))
			{
				return false;
			}
			if (!uart.WriteBytes(array3))
			{
				return false;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time500msec, false))
			{
				return false;
			}
			byte[] bytes2 = Encoding.Default.GetBytes(passkey);
			int num2 = bytes2.Length;
			array2[0] = (byte)(num2 & 255);
			array2[1] = (byte)((num2 & 65280) >> 8);
			if (!uart.WriteBytes(array2))
			{
				return false;
			}
			if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
			{
				return false;
			}
			array3[0] = FWDloadFormat.GetCheckSumByteFromBuffer(bytes2);
			return uart.WriteBytes(bytes2) && uart.WriteBytes(array3) && uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time500msec, false) && uart.WriteBytes(FWDloadFormat.downloadCmdEnd) && uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00010AA8 File Offset: 0x0000ECA8
		public static MuteMemory[] MuteMemoryRead(UARTCommUtils uart, RDInfo modelInfo, ProgressBar progressBar)
		{
			ProgressBarAsync progressBarAsync = null;
			MuteMemory[] result;
			try
			{
				if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
				{
					result = null;
				}
				else if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
				{
					result = null;
				}
				else if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
				{
					result = null;
				}
				else if (!uart.WriteBytes(FWDloadFormat.muteMemoryRead))
				{
					result = null;
				}
				else if (!uart.CompareRead(FWDloadFormat.downloadCmdTxReady, FWDloadFormat.time1sec, false))
				{
					result = null;
				}
				else if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
				{
					result = null;
				}
				else
				{
					byte[] array = uart.NByteRead(4, FWDloadFormat.time200msec, false);
					if (array == null)
					{
						result = null;
					}
					else
					{
						int num = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 4);
						MuteMemory[] array2 = new MuteMemory[num];
						progressBarAsync = new ProgressBarAsync(progressBar, 0, 1000, num * 10, null);
						progressBarAsync.Start();
						if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
						{
							result = null;
						}
						else
						{
							for (int i = 0; i < num; i++)
							{
								array = uart.NByteRead(4, FWDloadFormat.time100msec, false);
								if (array == null)
								{
									return null;
								}
								float lat = BitConverter.ToSingle(array, 0);
								if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
								{
									return null;
								}
								array = uart.NByteRead(4, FWDloadFormat.time100msec, false);
								if (array == null)
								{
									return null;
								}
								float lng = BitConverter.ToSingle(array, 0);
								if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
								{
									return null;
								}
								array = uart.NByteRead(2, FWDloadFormat.time100msec, false);
								if (array == null)
								{
									return null;
								}
								int freq = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2);
								if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
								{
									return null;
								}
								array2[i] = new MuteMemory(lat, lng, freq);
								progressBarAsync.SetSendCnt(10, true);
							}
							if (!uart.WriteBytes(FWDloadFormat.downloadCmdEnd))
							{
								result = null;
							}
							else if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
							{
								result = null;
							}
							else
							{
								result = array2;
							}
						}
					}
				}
			}
			finally
			{
				if (progressBarAsync != null)
				{
					progressBarAsync.Stop();
				}
			}
			return result;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		public static UserMark[] UserMarkRead(UARTCommUtils uart, RDInfo modelInfo, ProgressBar progressBar)
		{
			ProgressBarAsync progressBarAsync = null;
			UserMark[] result;
			try
			{
				if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
				{
					result = null;
				}
				else if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
				{
					result = null;
				}
				else if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
				{
					result = null;
				}
				else if (!uart.WriteBytes(FWDloadFormat.userMarkRead))
				{
					result = null;
				}
				else if (!uart.CompareRead(FWDloadFormat.downloadCmdTxReady, FWDloadFormat.time500msec, false))
				{
					result = null;
				}
				else if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
				{
					result = null;
				}
				else
				{
					byte[] array = uart.NByteRead(4, FWDloadFormat.time200msec, false);
					if (array == null)
					{
						result = null;
					}
					else
					{
						int num = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 4);
						UserMark[] array2 = new UserMark[num];
						progressBarAsync = new ProgressBarAsync(progressBar, 0, 1000, num * 8, null);
						progressBarAsync.Start();
						if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
						{
							result = null;
						}
						else
						{
							for (int i = 0; i < num; i++)
							{
								array = uart.NByteRead(4, FWDloadFormat.time100msec, false);
								if (array == null)
								{
									return null;
								}
								float lat = BitConverter.ToSingle(array, 0);
								if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
								{
									return null;
								}
								array = uart.NByteRead(4, FWDloadFormat.time100msec, false);
								if (array == null)
								{
									return null;
								}
								float lng = BitConverter.ToSingle(array, 0);
								if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
								{
									return null;
								}
								array2[i] = new UserMark(lat, lng);
							}
							if (!uart.WriteBytes(FWDloadFormat.downloadCmdEnd))
							{
								result = null;
							}
							else if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
							{
								result = null;
							}
							else
							{
								result = array2;
							}
						}
					}
				}
			}
			finally
			{
				if (progressBarAsync != null)
				{
					progressBarAsync.Stop();
				}
			}
			return result;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00010EA0 File Offset: 0x0000F0A0
		public static MuteMemory[] AutoMuteMemoryRead(UARTCommUtils uart, RDInfo modelInfo, ProgressBar progressBar)
		{
			ProgressBarAsync progressBarAsync = null;
			MuteMemory[] result;
			try
			{
				if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
				{
					result = null;
				}
				else if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
				{
					result = null;
				}
				else if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
				{
					result = null;
				}
				else if (!uart.WriteBytes(FWDloadFormat.autoMuteMemoryRead))
				{
					result = null;
				}
				else if (!uart.CompareRead(FWDloadFormat.downloadCmdTxReady, FWDloadFormat.time500msec, false))
				{
					result = null;
				}
				else if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
				{
					result = null;
				}
				else
				{
					byte[] array = uart.NByteRead(4, FWDloadFormat.time200msec, false);
					if (array == null)
					{
						result = null;
					}
					else
					{
						int num = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 4);
						MuteMemory[] array2 = new MuteMemory[num];
						progressBarAsync = new ProgressBarAsync(progressBar, 0, 1000, num * 11, null);
						progressBarAsync.Start();
						if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
						{
							result = null;
						}
						else
						{
							for (int i = 0; i < num; i++)
							{
								array = uart.NByteRead(4, FWDloadFormat.time100msec, false);
								if (array == null)
								{
									return null;
								}
								float lat = BitConverter.ToSingle(array, 0);
								if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
								{
									return null;
								}
								array = uart.NByteRead(4, FWDloadFormat.time100msec, false);
								if (array == null)
								{
									return null;
								}
								float lng = BitConverter.ToSingle(array, 0);
								if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
								{
									return null;
								}
								array = uart.NByteRead(2, FWDloadFormat.time100msec, false);
								if (array == null)
								{
									return null;
								}
								int freq = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2);
								if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
								{
									return null;
								}
								array = uart.NByteRead(1, FWDloadFormat.time100msec, false);
								if (array == null)
								{
									return null;
								}
								int autoMuteCnt = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 1);
								if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
								{
									return null;
								}
								array2[i] = new MuteMemory(lat, lng, freq, autoMuteCnt);
								progressBarAsync.SetSendCnt(11, true);
							}
							if (!uart.WriteBytes(FWDloadFormat.downloadCmdEnd))
							{
								result = null;
							}
							else if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
							{
								result = null;
							}
							else
							{
								result = array2;
							}
						}
					}
				}
			}
			finally
			{
				if (progressBarAsync != null)
				{
					progressBarAsync.Stop();
				}
			}
			return result;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000110FC File Offset: 0x0000F2FC
		public static int ReverseLSBtoMSB(byte[] buffer, int offset, int len)
		{
			int num = 0;
			for (int i = 0; i < len; i++)
			{
				num += (int)buffer[offset + i] << 8 * i;
			}
			return num;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00011127 File Offset: 0x0000F327
		public static int getVersion(int data)
		{
			if (data == -1)
			{
				return data;
			}
			return data & 1023;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00011138 File Offset: 0x0000F338
		public static ModelName getModelNumber(int data)
		{
			ModelName modelName = (ModelName)(data >> 10 & 63);
			switch (modelName)
			{
			case ModelName.R1:
			case ModelName.R3:
			case ModelName.R3_NZ:
			case ModelName.R3_NZK:
			case ModelName.R7:
			case ModelName.R7_NZ:
			case ModelName.R7_IL:
			case ModelName.R4:
			case ModelName.R4_NZ:
			case ModelName.R4_IL:
			case ModelName.R4_EU:
			case ModelName.R8:
			case ModelName.R8_NZ:
			case ModelName.R8_IL:
			case ModelName.R8_EU:
			case ModelName.R4W:
			case ModelName.R8W:
				return modelName;
			case (ModelName)2:
			case (ModelName)6:
			case (ModelName)10:
			case (ModelName)11:
			case (ModelName)12:
			case (ModelName)13:
			case (ModelName)22:
			case (ModelName)23:
			case (ModelName)25:
			case (ModelName)26:
			case (ModelName)27:
				break;
			default:
				if (modelName == ModelName.R3_PLUS || modelName == ModelName.R3_NZK_PLUS)
				{
					return modelName;
				}
				break;
			}
			modelName = ModelName.UNKNOWN;
			return modelName;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000111D8 File Offset: 0x0000F3D8
		public static FWDloadFormat.VOICE_IC getVoiceICModel(int data)
		{
			FWDloadFormat.VOICE_IC voice_IC = (FWDloadFormat.VOICE_IC)(data & 64512);
			if (voice_IC <= FWDloadFormat.VOICE_IC.LAPIS1_IC)
			{
				if (voice_IC != FWDloadFormat.VOICE_IC.NUVOTON_IC)
				{
					if (voice_IC == FWDloadFormat.VOICE_IC.LAPIS1_IC)
					{
						return voice_IC;
					}
				}
			}
			else if (voice_IC == FWDloadFormat.VOICE_IC.LAPIS2_IC)
			{
				return voice_IC;
			}
			voice_IC = FWDloadFormat.VOICE_IC.NUVOTON_IC;
			return voice_IC;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00011215 File Offset: 0x0000F415
		public static int GetNVVersion(byte[] nvData)
		{
			return (int)nvData[1];
		}
	}
}
