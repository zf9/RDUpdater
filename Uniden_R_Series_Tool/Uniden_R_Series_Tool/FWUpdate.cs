using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000017 RID: 23
	public static class FWUpdate
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00013690 File Offset: 0x00011890
		public static bool DloadCheckAvailableModel(RDInfo modelInfo, FWFileInfo fileInfo)
		{
			if (modelInfo.modelName == ModelName.UNKNOWN)
			{
				if (fileInfo.modelName == ModelName.R1 || fileInfo.modelName == ModelName.R3 || fileInfo.modelName == ModelName.R7)
				{
					return true;
				}
			}
			else if (fileInfo.modelName == ModelName.DB_US || fileInfo.modelName == ModelName.DB_NZ || fileInfo.modelName == ModelName.DB_IL || fileInfo.modelName == ModelName.DB_EU)
			{
				if (fileInfo.modelName == ModelName.DB_US)
				{
					if (modelInfo.modelName == ModelName.R3 || modelInfo.modelName == ModelName.R3_PLUS || modelInfo.modelName == ModelName.R4 || modelInfo.modelName == ModelName.R4W || modelInfo.modelName == ModelName.R7 || modelInfo.modelName == ModelName.R8 || modelInfo.modelName == ModelName.R8W)
					{
						return true;
					}
				}
				else if (fileInfo.modelName == ModelName.DB_NZ)
				{
					if (modelInfo.modelName == ModelName.R3_NZ || modelInfo.modelName == ModelName.R3_NZK || modelInfo.modelName == ModelName.R3_NZK_PLUS || modelInfo.modelName == ModelName.R4_NZ || modelInfo.modelName == ModelName.R7_NZ || modelInfo.modelName == ModelName.R8_NZ)
					{
						return true;
					}
				}
				else if (fileInfo.modelName == ModelName.DB_IL)
				{
					if (modelInfo.modelName == ModelName.R4_IL || modelInfo.modelName == ModelName.R7_IL || modelInfo.modelName == ModelName.R8_IL)
					{
						return true;
					}
				}
				else if (fileInfo.modelName == ModelName.DB_EU && (modelInfo.modelName == ModelName.R4_EU || modelInfo.modelName == ModelName.R8_EU))
				{
					return true;
				}
			}
			else
			{
				ModelName modelName = modelInfo.modelName;
				if (modelName != ModelName.R3_PLUS)
				{
					if (modelName == ModelName.R3_NZK_PLUS)
					{
						if (fileInfo.modelName == ModelName.R3_NZK)
						{
							return true;
						}
					}
				}
				else if (fileInfo.modelName == ModelName.R3)
				{
					return true;
				}
				if (modelInfo.modelName == fileInfo.modelName)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0001382C File Offset: 0x00011A2C
		public static FWDloadFormat.DB_CHECK DloadCheckAvailableGPSDB(RDInfo modelInfo, FWFileInfo fileInfo)
		{
			if (fileInfo.gpsDBFileLength == 0 && fileInfo.gpsDBSecondFileLength == 0)
			{
				return FWDloadFormat.DB_CHECK.OKAY_DB_NOT_EXIST;
			}
			if (modelInfo.modelName == ModelName.R3 || modelInfo.modelName == ModelName.R3_NZ || modelInfo.modelName == ModelName.R3_NZK || modelInfo.modelName == ModelName.R7 || modelInfo.modelName == ModelName.R7_NZ || modelInfo.modelName == ModelName.R7_IL)
			{
				if (!fileInfo.gpsDBExistOldEncFile)
				{
					return FWDloadFormat.DB_CHECK.ERROR_IS_NOT_OLD_ENC_DB;
				}
			}
			else if ((modelInfo.modelName == ModelName.R3_PLUS || modelInfo.modelName == ModelName.R3_NZK_PLUS || modelInfo.modelName == ModelName.R4 || modelInfo.modelName == ModelName.R4_NZ || modelInfo.modelName == ModelName.R4_IL || modelInfo.modelName == ModelName.R4_EU || modelInfo.modelName == ModelName.R4W || modelInfo.modelName == ModelName.R8 || modelInfo.modelName == ModelName.R8_NZ || modelInfo.modelName == ModelName.R8_IL || modelInfo.modelName == ModelName.R8_EU || modelInfo.modelName == ModelName.R8W) && !fileInfo.gpsDBExistAES128File)
			{
				return FWDloadFormat.DB_CHECK.ERROR_IS_NOT_AES128_DB;
			}
			return FWDloadFormat.DB_CHECK.OKAY_IS_VALID_DB;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00013914 File Offset: 0x00011B14
		public static bool DloadCheckDownloadStep(RDInfo modelInfo, ref FWFileInfo fileInfo)
		{
			fileInfo.DownloadFlagClear();
			if (fileInfo.uiNuFileLength != 0)
			{
				if (fileInfo.recoveryModeFlag || modelInfo.versionUI != fileInfo.uiNuFileVersion)
				{
					fileInfo.uiDownloadFlag = true;
					if (fileInfo.uiNuFileLength >= fileInfo.uiSTMFileLength && fileInfo.uiNuFileLength >= fileInfo.uiNu2FileLength)
					{
						fileInfo.totalDownloadCnt += fileInfo.uiNuFileLength;
					}
					else if (fileInfo.uiSTMFileLength >= fileInfo.uiNuFileLength && fileInfo.uiSTMFileLength >= fileInfo.uiNu2FileLength)
					{
						fileInfo.totalDownloadCnt += fileInfo.uiSTMFileLength;
					}
					else
					{
						fileInfo.totalDownloadCnt += fileInfo.uiNu2FileLength;
					}
				}
				else if (modelInfo.versionDSP == -1 && modelInfo.versionGPS == -1 && modelInfo.versionSoundDB == -1 && modelInfo.versionGPSDB == -1)
				{
					fileInfo.uiDownloadFlag = true;
					if (fileInfo.uiNuFileLength >= fileInfo.uiSTMFileLength && fileInfo.uiNuFileLength >= fileInfo.uiNu2FileLength)
					{
						fileInfo.totalDownloadCnt += fileInfo.uiNuFileLength;
					}
					else if (fileInfo.uiSTMFileLength >= fileInfo.uiNuFileLength && fileInfo.uiSTMFileLength >= fileInfo.uiNu2FileLength)
					{
						fileInfo.totalDownloadCnt += fileInfo.uiSTMFileLength;
					}
					else
					{
						fileInfo.totalDownloadCnt += fileInfo.uiNu2FileLength;
					}
				}
				else
				{
					fileInfo.uiDownloadFlag = false;
				}
			}
			else
			{
				fileInfo.uiDownloadFlag = false;
			}
			if (fileInfo.dspNuFileLength != 0)
			{
				if (fileInfo.recoveryModeFlag || modelInfo.versionDSP != fileInfo.dspNuFileVersion)
				{
					fileInfo.dspDownloadFlag = true;
					if (fileInfo.dspNuFileLength >= fileInfo.dspSTMFileLength && fileInfo.dspNuFileLength >= fileInfo.dspNu2FileLength && fileInfo.dspNuFileLength >= fileInfo.dspNu3FileLength)
					{
						fileInfo.totalDownloadCnt += fileInfo.dspNuFileLength;
					}
					else if (fileInfo.dspSTMFileLength >= fileInfo.dspNuFileLength && fileInfo.dspSTMFileLength >= fileInfo.dspNu2FileLength && fileInfo.dspSTMFileLength >= fileInfo.dspNu3FileLength)
					{
						fileInfo.totalDownloadCnt += fileInfo.dspSTMFileLength;
					}
					else if (fileInfo.dspNu2FileLength >= fileInfo.dspNuFileLength && fileInfo.dspNu2FileLength >= fileInfo.dspSTMFileLength && fileInfo.dspNu2FileLength >= fileInfo.dspNu3FileLength)
					{
						fileInfo.totalDownloadCnt += fileInfo.dspNu2FileLength;
					}
					else
					{
						fileInfo.totalDownloadCnt += fileInfo.dspNu3FileLength;
					}
				}
				else
				{
					fileInfo.dspDownloadFlag = false;
				}
			}
			else
			{
				fileInfo.dspDownloadFlag = false;
			}
			if (fileInfo.gpsNuFileLength != 0)
			{
				if (fileInfo.recoveryModeFlag || modelInfo.versionGPS != fileInfo.gpsNuFileVersion)
				{
					fileInfo.gpsDownloadFlag = true;
					if (fileInfo.gpsNuFileLength >= fileInfo.gpsSTMFileLength && fileInfo.gpsNuFileLength >= fileInfo.gpsNu2FileLength && fileInfo.gpsNuFileLength >= fileInfo.gpsNu3FileLength)
					{
						fileInfo.totalDownloadCnt += fileInfo.gpsNuFileLength;
					}
					else if (fileInfo.gpsSTMFileLength >= fileInfo.gpsNuFileLength && fileInfo.gpsSTMFileLength >= fileInfo.gpsNu2FileLength && fileInfo.gpsSTMFileLength >= fileInfo.gpsNu2FileLength)
					{
						fileInfo.totalDownloadCnt += fileInfo.gpsSTMFileLength;
					}
					else if (fileInfo.gpsNu2FileLength >= fileInfo.gpsNuFileLength && fileInfo.gpsNu2FileLength >= fileInfo.gpsSTMFileLength && fileInfo.gpsNu2FileLength >= fileInfo.gpsNu3FileLength)
					{
						fileInfo.totalDownloadCnt += fileInfo.gpsNu2FileLength;
					}
					else
					{
						fileInfo.totalDownloadCnt += fileInfo.gpsNu3FileLength;
					}
				}
				else
				{
					fileInfo.gpsDownloadFlag = false;
				}
			}
			else
			{
				fileInfo.gpsDownloadFlag = false;
			}
			if (modelInfo.voiceICType == FWDloadFormat.VOICE_IC.NUVOTON_IC)
			{
				if (fileInfo.soundDBNuFileLength != 0)
				{
					if (fileInfo.recoveryModeFlag || modelInfo.versionSoundDB != fileInfo.soundDBNuFileVersion)
					{
						fileInfo.soundDBDownloadFlag = true;
						fileInfo.totalDownloadCnt += fileInfo.soundDBNuFileLength;
					}
					else
					{
						fileInfo.soundDBDownloadFlag = false;
					}
				}
				else
				{
					fileInfo.soundDBDownloadFlag = false;
				}
			}
			else if (modelInfo.voiceICType == FWDloadFormat.VOICE_IC.LAPIS1_IC)
			{
				if (fileInfo.soundDBLa1FileLength != 0)
				{
					if (fileInfo.recoveryModeFlag || modelInfo.versionSoundDB != fileInfo.soundDBLa1FileVersion)
					{
						fileInfo.soundDBDownloadFlag = true;
						fileInfo.totalDownloadCnt += fileInfo.soundDBLa1FileLength;
					}
					else
					{
						fileInfo.soundDBDownloadFlag = false;
					}
				}
				else
				{
					fileInfo.soundDBDownloadFlag = false;
				}
			}
			else if (modelInfo.voiceICType == FWDloadFormat.VOICE_IC.LAPIS2_IC)
			{
				if (fileInfo.soundDBLa2FileLength != 0)
				{
					if (fileInfo.recoveryModeFlag || modelInfo.versionSoundDB != fileInfo.soundDBLa2FileVersion)
					{
						fileInfo.soundDBDownloadFlag = true;
						fileInfo.totalDownloadCnt += fileInfo.soundDBLa2FileLength;
					}
					else
					{
						fileInfo.soundDBDownloadFlag = false;
					}
				}
				else
				{
					fileInfo.soundDBDownloadFlag = false;
				}
			}
			else
			{
				if (fileInfo.soundDBNuFileLength == 0 && fileInfo.soundDBLa1FileLength == 0 && fileInfo.soundDBLa2FileLength == 0)
				{
					fileInfo.soundDBDownloadFlag = false;
				}
				if (fileInfo.soundDBNuFileLength >= fileInfo.soundDBLa1FileLength && fileInfo.soundDBNuFileLength >= fileInfo.soundDBLa2FileLength)
				{
					fileInfo.soundDBDownloadFlag = true;
					fileInfo.totalDownloadCnt += fileInfo.soundDBNuFileLength;
				}
				else if (fileInfo.soundDBLa1FileLength >= fileInfo.soundDBNuFileLength && fileInfo.soundDBLa1FileLength >= fileInfo.soundDBLa2FileLength)
				{
					fileInfo.soundDBDownloadFlag = true;
					fileInfo.totalDownloadCnt += fileInfo.soundDBLa1FileLength;
				}
				else if (fileInfo.soundDBLa2FileLength >= fileInfo.soundDBNuFileLength && fileInfo.soundDBLa2FileLength >= fileInfo.soundDBLa1FileLength)
				{
					fileInfo.soundDBDownloadFlag = true;
					fileInfo.totalDownloadCnt += fileInfo.soundDBLa2FileLength;
				}
			}
			if (fileInfo.gpsDBFileLength != 0 || fileInfo.gpsDBSecondFileLength != 0)
			{
				if (fileInfo.gpsDBFileLength != 0)
				{
					if (fileInfo.recoveryModeFlag || modelInfo.versionGPSDB != fileInfo.gpsDBFileVersion)
					{
						fileInfo.gpsDBDownloadFlag = true;
						if (fileInfo.gpsDBFileLength >= fileInfo.gpsDBSecondFileLength)
						{
							fileInfo.totalDownloadCnt += fileInfo.gpsDBFileLength - 12;
						}
						else
						{
							fileInfo.totalDownloadCnt += fileInfo.gpsDBSecondFileLength - 12;
						}
					}
					else
					{
						fileInfo.gpsDBDownloadFlag = false;
					}
				}
				else if (fileInfo.recoveryModeFlag || modelInfo.versionGPSDB != fileInfo.gpsDBSecondFileVersion)
				{
					fileInfo.gpsDBDownloadFlag = true;
					if (fileInfo.gpsDBFileLength >= fileInfo.gpsDBSecondFileLength)
					{
						fileInfo.totalDownloadCnt += fileInfo.gpsDBFileLength - 12;
					}
					else
					{
						fileInfo.totalDownloadCnt += fileInfo.gpsDBSecondFileLength - 12;
					}
				}
				else
				{
					fileInfo.gpsDBDownloadFlag = false;
				}
			}
			else
			{
				fileInfo.gpsDBDownloadFlag = false;
			}
			if (modelInfo.modelName == ModelName.R4 || modelInfo.modelName == ModelName.R4_NZ || modelInfo.modelName == ModelName.R4_IL || modelInfo.modelName == ModelName.R4_EU || modelInfo.modelName == ModelName.R8 || modelInfo.modelName == ModelName.R8_NZ || modelInfo.modelName == ModelName.R8_IL || modelInfo.modelName == ModelName.R8_EU || modelInfo.modelName == ModelName.R4W || modelInfo.modelName == ModelName.R8W)
			{
				if (fileInfo.bleFileLength != 0)
				{
					if (fileInfo.recoveryModeFlag || modelInfo.versionBLE != fileInfo.bleFileVersion)
					{
						fileInfo.bleDownloadFlag = true;
						fileInfo.totalDownloadCnt += fileInfo.bleFileLength;
					}
					else
					{
						fileInfo.bleDownloadFlag = false;
					}
				}
				else
				{
					fileInfo.bleDownloadFlag = false;
				}
			}
			return fileInfo.uiDownloadFlag || fileInfo.dspDownloadFlag || fileInfo.gpsDownloadFlag || fileInfo.soundDBDownloadFlag || fileInfo.gpsDBDownloadFlag || fileInfo.bleDownloadFlag || fileInfo.keypadDownloadFlag || fileInfo.laserIFDownloadFlag;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00014134 File Offset: 0x00012334
		private static FWDloadFormat.DLOAD_RESULT DloadCheckDBType(RDInfo modelInfo, FWFileInfo fileInfo, bool checkOnly, byte[] receiveBytes, int onePageLength, ref int fileOffset, ref int totalPage, ref FWDloadFormat.GPS_DB_TYPE gpsDBType)
		{
			byte[] array = null;
			FWDloadFormat.GPS_DB_TYPE gps_DB_TYPE = FWDloadFormat.GPS_DB_TYPE.UNKNOWN;
			byte[] array2 = null;
			FWDloadFormat.GPS_DB_TYPE gps_DB_TYPE2 = FWDloadFormat.GPS_DB_TYPE.UNKNOWN;
			ModelName modelName = modelInfo.modelName;
			if (modelName <= ModelName.R3_PLUS)
			{
				switch (modelName)
				{
				case ModelName.R3:
				case ModelName.R3_NZ:
				case ModelName.R3_NZK:
					array = FWDloadFormat.downloadCmdRxDB1Ready;
					gps_DB_TYPE = FWDloadFormat.GPS_DB_TYPE.GPS_DB_OLD_ENC;
					goto IL_FC;
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
				case ModelName.R7:
				case ModelName.R7_NZ:
				case ModelName.R7_IL:
					array = FWDloadFormat.downloadCmdRxDB1Ready;
					gps_DB_TYPE = FWDloadFormat.GPS_DB_TYPE.GPS_DB_OLD_ENC;
					goto IL_FC;
				case ModelName.R4:
				case ModelName.R4_NZ:
				case ModelName.R4_IL:
				case ModelName.R4_EU:
					array = FWDloadFormat.downloadCmdRxDB1Ready;
					gps_DB_TYPE = FWDloadFormat.GPS_DB_TYPE.GPS_DB_AES128;
					goto IL_FC;
				case ModelName.R8:
				case ModelName.R8_NZ:
				case ModelName.R8_IL:
				case ModelName.R8_EU:
					array = FWDloadFormat.downloadCmdRxDB1Ready;
					gps_DB_TYPE = FWDloadFormat.GPS_DB_TYPE.GPS_DB_AES128;
					goto IL_FC;
				case ModelName.R4W:
					array = FWDloadFormat.downloadCmdRxDB1Ready;
					gps_DB_TYPE = FWDloadFormat.GPS_DB_TYPE.GPS_DB_AES128;
					goto IL_FC;
				case ModelName.R8W:
					array = FWDloadFormat.downloadCmdRxDB1Ready;
					gps_DB_TYPE = FWDloadFormat.GPS_DB_TYPE.GPS_DB_AES128;
					goto IL_FC;
				default:
					if (modelName == ModelName.R3_PLUS)
					{
						array2 = FWDloadFormat.downloadCmdRxDB2Ready;
						gps_DB_TYPE2 = FWDloadFormat.GPS_DB_TYPE.GPS_DB_AES128;
						goto IL_FC;
					}
					break;
				}
			}
			else
			{
				if (modelName == ModelName.R3_NZK_PLUS)
				{
					array2 = FWDloadFormat.downloadCmdRxDB2Ready;
					gps_DB_TYPE2 = FWDloadFormat.GPS_DB_TYPE.GPS_DB_AES128;
					goto IL_FC;
				}
				if (modelName == ModelName.UNKNOWN)
				{
					array = FWDloadFormat.downloadCmdRxDB1Ready;
					gps_DB_TYPE = FWDloadFormat.GPS_DB_TYPE.GPS_DB_OLD_ENC;
					goto IL_FC;
				}
			}
			return FWDloadFormat.DLOAD_RESULT.FAIL_DOSE_NOT_SUPPORT;
			IL_FC:
			if (array != null && receiveBytes.SequenceEqual(array))
			{
				if (fileInfo.gpsDBFileType == gps_DB_TYPE)
				{
					if (!checkOnly)
					{
						fileOffset = fileInfo.gpsDBFileOffset;
						totalPage = fileInfo.gpsDBFileLength / onePageLength;
						if (fileInfo.gpsDBFileLength <= fileInfo.gpsDBSecondFileLength)
						{
							fileInfo.totalDownloadCnt -= fileInfo.gpsDBSecondFileLength;
							fileInfo.totalDownloadCnt += fileInfo.gpsDBFileLength;
						}
					}
				}
				else
				{
					if (fileInfo.gpsDBSecondFileType != gps_DB_TYPE)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.gpsDBSecondFileOffset;
						totalPage = fileInfo.gpsDBSecondFileLength / onePageLength;
						if (fileInfo.gpsDBSecondFileLength <= fileInfo.gpsDBFileLength)
						{
							fileInfo.totalDownloadCnt -= fileInfo.gpsDBFileLength;
							fileInfo.totalDownloadCnt += fileInfo.gpsDBSecondFileLength;
						}
					}
				}
				gpsDBType = gps_DB_TYPE;
				LogClass.WriteLog("Rx: GPS DB ID (RDY)");
			}
			else
			{
				if (array2 == null || !receiveBytes.SequenceEqual(array2))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_UNKNOWN_MCU_ID;
				}
				if (fileInfo.gpsDBFileType == gps_DB_TYPE2)
				{
					if (!checkOnly)
					{
						fileOffset = fileInfo.gpsDBFileOffset;
						totalPage = fileInfo.gpsDBFileLength / onePageLength;
						if (fileInfo.gpsDBFileLength <= fileInfo.gpsDBSecondFileLength)
						{
							fileInfo.totalDownloadCnt -= fileInfo.gpsDBSecondFileLength;
							fileInfo.totalDownloadCnt += fileInfo.gpsDBFileLength;
						}
					}
				}
				else
				{
					if (fileInfo.gpsDBSecondFileType != gps_DB_TYPE2)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.gpsDBSecondFileOffset;
						totalPage = fileInfo.gpsDBSecondFileLength / onePageLength;
						if (fileInfo.gpsDBSecondFileLength <= fileInfo.gpsDBFileLength)
						{
							fileInfo.totalDownloadCnt -= fileInfo.gpsDBFileLength;
							fileInfo.totalDownloadCnt += fileInfo.gpsDBSecondFileLength;
						}
					}
				}
				gpsDBType = gps_DB_TYPE2;
				LogClass.WriteLog("Rx: GPS DB ID (RDA)");
			}
			return FWDloadFormat.DLOAD_RESULT.OKAY;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000143F4 File Offset: 0x000125F4
		private static FWDloadFormat.DLOAD_RESULT DloadCheckMCUID(FWDloadFormat.Step step, RDInfo modelInfo, FWFileInfo fileInfo, bool checkOnly, byte[] receiveBytes, int onePageLength, ref int fileOffset, ref int totalPage)
		{
			byte[] array = null;
			byte[] array2 = null;
			byte[] array3 = null;
			byte[] array4 = null;
			byte[] array5 = null;
			byte[] array6 = null;
			byte[] array7 = null;
			byte[] array8 = null;
			byte[] array9 = null;
			byte[] array10 = null;
			byte[] array11 = null;
			byte[] array12 = null;
			byte[] array13 = null;
			ModelName modelName = modelInfo.modelName;
			byte[] array14;
			byte[] array15;
			if (modelName <= ModelName.R3_PLUS)
			{
				switch (modelName)
				{
				case ModelName.R1:
					array = FWDloadFormat.downloadCmdUIMCUIDNuNu_R1;
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R1;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R1;
					array7 = FWDloadFormat.downloadCmdDSPMCUIDNuv2_R1;
					array8 = FWDloadFormat.downloadCmdDSPMCUIDNuv3_R1;
					array13 = FWDloadFormat.downloadCmdGPSMCUID_TOMS_BUG;
					goto IL_313;
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
					return FWDloadFormat.DLOAD_RESULT.FAIL_DOSE_NOT_SUPPORT;
				case ModelName.R3:
				case ModelName.R3_NZ:
				case ModelName.R3_NZK:
					break;
				case ModelName.R7:
				case ModelName.R7_NZ:
					array = FWDloadFormat.downloadCmdUIMCUIDNuNu_R7;
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R7;
					array3 = FWDloadFormat.downloadCmdUIMCUIDSTLa_R7;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R7;
					array6 = FWDloadFormat.downloadCmdDSPMCUIDSTM_R7;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R7;
					array10 = FWDloadFormat.downloadCmdGPSMCUIDSTM_R7;
					array13 = FWDloadFormat.downloadCmdGPSMCUID_TOMS_BUG;
					goto IL_313;
				case ModelName.R7_IL:
					array = FWDloadFormat.downloadCmdUIMCUIDNuNu_R7IL;
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R7IL;
					array3 = FWDloadFormat.downloadCmdUIMCUIDSTLa_R7IL;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R7;
					array6 = FWDloadFormat.downloadCmdDSPMCUIDSTM_R7;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R7;
					array10 = FWDloadFormat.downloadCmdGPSMCUIDSTM_R7;
					array13 = FWDloadFormat.downloadCmdGPSMCUID_TOMS_BUG;
					goto IL_313;
				case ModelName.R4:
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R4;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R4;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R4;
					goto IL_313;
				case ModelName.R4_NZ:
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R4NZ;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R4NZ;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R4NZ;
					goto IL_313;
				case ModelName.R4_IL:
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R4IL;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R4IL;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R4IL;
					goto IL_313;
				case ModelName.R4_EU:
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R4EU;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R4EU;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R4EU;
					goto IL_313;
				case ModelName.R8:
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R8;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R8;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R8;
					goto IL_313;
				case ModelName.R8_NZ:
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R8NZ;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R8NZ;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R8NZ;
					goto IL_313;
				case ModelName.R8_IL:
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R8IL;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R8IL;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R8IL;
					goto IL_313;
				case ModelName.R8_EU:
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R8EU;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R8EU;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R8EU;
					goto IL_313;
				case ModelName.R4W:
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R4W;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R4W;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R4W;
					goto IL_313;
				case ModelName.R8W:
					array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R8W;
					array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R8W;
					array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R8W;
					goto IL_313;
				default:
					if (modelName != ModelName.R3_PLUS)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_DOSE_NOT_SUPPORT;
					}
					break;
				}
			}
			else if (modelName != ModelName.R3_NZK_PLUS)
			{
				if (modelName != ModelName.UNKNOWN)
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_DOSE_NOT_SUPPORT;
				}
				array = Encoding.UTF8.GetBytes("REN");
				array14 = null;
				array2 = null;
				array3 = null;
				array4 = null;
				array5 = null;
				array15 = new byte[]
				{
					77,
					48,
					65
				};
				array6 = null;
				array7 = null;
				array9 = new byte[]
				{
					77,
					48,
					64
				};
				array10 = null;
				array11 = null;
				array13 = FWDloadFormat.downloadCmdGPSMCUID_TOMS_BUG;
				goto IL_313;
			}
			array = FWDloadFormat.downloadCmdUIMCUIDNuNu_R3;
			array14 = FWDloadFormat.downloadCmdUIMCUIDNuLa_R3;
			array5 = FWDloadFormat.downloadCmdUIMCUIDNu2La_R3;
			array15 = FWDloadFormat.downloadCmdDSPMCUIDNuv_R3;
			array7 = FWDloadFormat.downloadCmdDSPMCUIDNuv2_R3;
			array8 = FWDloadFormat.downloadCmdDSPMCUIDNuv3_R3;
			array9 = FWDloadFormat.downloadCmdGPSMCUIDNuv_R3;
			array10 = FWDloadFormat.downloadCmdGPSMCUIDSTM_R3;
			array11 = FWDloadFormat.downloadCmdGPSMCUIDNuv2_R3;
			array12 = FWDloadFormat.downloadCmdGPSMCUIDNuv3_R3;
			array13 = FWDloadFormat.downloadCmdGPSMCUID_TOMS_BUG;
			IL_313:
			switch (step)
			{
			case FWDloadFormat.Step.UI:
				if (array != null && receiveBytes.SequenceEqual(array))
				{
					if (!checkOnly)
					{
						fileOffset = fileInfo.uiNuFileOffset;
						totalPage = fileInfo.uiNuFileLength / onePageLength;
						if (fileInfo.uiNuFileLength <= fileInfo.uiSTMFileLength || fileInfo.uiNuFileLength <= fileInfo.uiNu2FileLength)
						{
							if (fileInfo.uiSTMFileLength >= fileInfo.uiNu2FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiSTMFileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiNu2FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.uiNuFileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (UI Nuvo Nuvo)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				if (array14 != null && receiveBytes.SequenceEqual(array14))
				{
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.uiNuFileOffset;
						totalPage = fileInfo.uiNuFileLength / onePageLength;
						if (fileInfo.uiNuFileLength <= fileInfo.uiSTMFileLength || fileInfo.uiNuFileLength <= fileInfo.uiNu2FileLength)
						{
							if (fileInfo.uiSTMFileLength >= fileInfo.uiNu2FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiSTMFileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiNu2FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.uiNuFileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (UI Nuvo Lapis)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				else if (array2 != null && receiveBytes.SequenceEqual(array2))
				{
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (fileInfo.uiSTMFileLength == 0)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.uiSTMFileOffset;
						totalPage = fileInfo.uiSTMFileLength / onePageLength;
						if (fileInfo.uiSTMFileLength <= fileInfo.uiNuFileLength || fileInfo.uiSTMFileLength <= fileInfo.uiNu2FileLength)
						{
							if (fileInfo.uiNuFileLength >= fileInfo.uiNu2FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiNuFileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiNu2FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.uiSTMFileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (UI STM Nuvo)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				else if (array3 != null && receiveBytes.SequenceEqual(array3))
				{
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (fileInfo.uiSTMFileLength == 0)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.uiSTMFileOffset;
						totalPage = fileInfo.uiSTMFileLength / onePageLength;
						if (fileInfo.uiSTMFileLength <= fileInfo.uiNuFileLength || fileInfo.uiSTMFileLength <= fileInfo.uiNu2FileLength)
						{
							if (fileInfo.uiNuFileLength >= fileInfo.uiNu2FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiNuFileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiNu2FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.uiSTMFileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (UI STM Lapis)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				else if (array4 != null && receiveBytes.SequenceEqual(array4))
				{
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (fileInfo.uiNu2FileLength == 0)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.uiNu2FileOffset;
						totalPage = fileInfo.uiNu2FileLength / onePageLength;
						if (fileInfo.uiNu2FileLength <= fileInfo.uiNuFileLength || fileInfo.uiNu2FileLength <= fileInfo.uiSTMFileLength)
						{
							if (fileInfo.uiNuFileLength >= fileInfo.uiSTMFileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiNuFileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiSTMFileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.uiNu2FileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (UI Nuvo2 Nuvo)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				else
				{
					if (array5 == null || !receiveBytes.SequenceEqual(array5))
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_UNKNOWN_MCU_ID;
					}
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (modelInfo.modelName == ModelName.R3_PLUS && fileInfo.fileFormatVer <= 104)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (modelInfo.modelName == ModelName.R3_NZK_PLUS && fileInfo.fileFormatVer <= 107)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (fileInfo.uiNu2FileLength == 0)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.uiNu2FileOffset;
						totalPage = fileInfo.uiNu2FileLength / onePageLength;
						if (fileInfo.uiNu2FileLength <= fileInfo.uiNuFileLength || fileInfo.uiNu2FileLength <= fileInfo.uiSTMFileLength)
						{
							if (fileInfo.uiNuFileLength >= fileInfo.uiSTMFileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiNuFileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.uiSTMFileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.uiNu2FileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (UI Nuvo2 Lapis)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				// DECOMPILE-FIX: Removed the unreachable break; every preceding branch returns.
			case FWDloadFormat.Step.DSP:
				if (array15 != null && receiveBytes.SequenceEqual(array15))
				{
					if (!checkOnly)
					{
						fileOffset = fileInfo.dspNuFileOffset;
						totalPage = fileInfo.dspNuFileLength / onePageLength;
						if (fileInfo.dspNuFileLength <= fileInfo.dspSTMFileLength || fileInfo.dspNuFileLength <= fileInfo.dspNu2FileLength || fileInfo.dspNuFileLength <= fileInfo.dspNu3FileLength)
						{
							if (fileInfo.dspSTMFileLength >= fileInfo.dspNu2FileLength && fileInfo.dspSTMFileLength >= fileInfo.dspNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspSTMFileLength;
							}
							else if (fileInfo.dspNu2FileLength >= fileInfo.dspSTMFileLength && fileInfo.dspNu2FileLength >= fileInfo.dspNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspNu2FileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspNu3FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.dspNuFileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (DSP Nuvo)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				if (array6 != null && receiveBytes.SequenceEqual(array6))
				{
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (fileInfo.dspSTMFileLength == 0)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.dspSTMFileOffset;
						totalPage = fileInfo.dspSTMFileLength / onePageLength;
						if (fileInfo.dspSTMFileLength <= fileInfo.dspNuFileLength || fileInfo.dspSTMFileLength <= fileInfo.dspNu2FileLength || fileInfo.dspSTMFileLength <= fileInfo.dspNu3FileLength)
						{
							if (fileInfo.dspNuFileLength >= fileInfo.dspNu2FileLength && fileInfo.dspNuFileLength >= fileInfo.dspNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspNuFileLength;
							}
							else if (fileInfo.dspNu2FileLength >= fileInfo.dspNuFileLength && fileInfo.dspNu2FileLength >= fileInfo.dspNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspNu2FileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspNu3FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.dspSTMFileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (DSP STM)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				else if (array7 != null && receiveBytes.SequenceEqual(array7))
				{
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (fileInfo.dspNu2FileLength == 0)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.dspNu2FileOffset;
						totalPage = fileInfo.dspNu2FileLength / onePageLength;
						if (fileInfo.dspNu2FileLength <= fileInfo.dspNuFileLength || fileInfo.dspNu2FileLength <= fileInfo.dspSTMFileLength || fileInfo.dspNu2FileLength <= fileInfo.dspNu3FileLength)
						{
							if (fileInfo.dspNuFileLength >= fileInfo.dspSTMFileLength && fileInfo.dspNuFileLength >= fileInfo.dspNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspNuFileLength;
							}
							else if (fileInfo.dspSTMFileLength >= fileInfo.dspNuFileLength && fileInfo.dspSTMFileLength >= fileInfo.dspNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspSTMFileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspNu3FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.dspNu2FileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (DSP Nuvo2)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				else
				{
					if (array8 == null || !receiveBytes.SequenceEqual(array8))
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_UNKNOWN_MCU_ID;
					}
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (fileInfo.dspNu3FileLength == 0)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.dspNu3FileOffset;
						totalPage = fileInfo.dspNu3FileLength / onePageLength;
						if (fileInfo.dspNu3FileLength <= fileInfo.dspNuFileLength || fileInfo.dspNu3FileLength <= fileInfo.dspSTMFileLength || fileInfo.dspNu3FileLength <= fileInfo.dspNu2FileLength)
						{
							if (fileInfo.dspNuFileLength >= fileInfo.dspSTMFileLength && fileInfo.dspNuFileLength >= fileInfo.dspNu2FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspNuFileLength;
							}
							else if (fileInfo.dspSTMFileLength >= fileInfo.dspNuFileLength && fileInfo.dspSTMFileLength >= fileInfo.dspNu2FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspSTMFileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.dspNu2FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.dspNu3FileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (DSP Nuvo3)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				// DECOMPILE-FIX: Removed the unreachable break; every preceding branch returns.
			case FWDloadFormat.Step.GPS:
				if (modelInfo.modelName == ModelName.R1)
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_DOSE_NOT_SUPPORT;
				}
				if ((array9 != null && receiveBytes.SequenceEqual(array9)) || (array13 != null && receiveBytes.SequenceEqual(array13)))
				{
					if (!checkOnly)
					{
						fileOffset = fileInfo.gpsNuFileOffset;
						totalPage = fileInfo.gpsNuFileLength / onePageLength;
						if (fileInfo.gpsNuFileLength <= fileInfo.gpsSTMFileLength || fileInfo.gpsNuFileLength <= fileInfo.gpsNu2FileLength || fileInfo.gpsNuFileLength <= fileInfo.gpsNu3FileLength)
						{
							if (fileInfo.gpsSTMFileLength >= fileInfo.gpsNu2FileLength && fileInfo.gpsSTMFileLength >= fileInfo.gpsNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsSTMFileLength;
							}
							else if (fileInfo.gpsNu2FileLength >= fileInfo.gpsSTMFileLength && fileInfo.gpsNu2FileLength >= fileInfo.gpsNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsNu2FileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsNu3FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.gpsNuFileLength;
						}
					}
					if (array13 != null && receiveBytes.SequenceEqual(array13))
					{
						LogClass.WriteLog("Rx: MCU ID { 'M', '0', 65 } (Toms bug)");
						return FWDloadFormat.DLOAD_RESULT.OKAY;
					}
					LogClass.WriteLog("Rx: MCU ID (GPS Nuvo)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				else if (array10 != null && receiveBytes.SequenceEqual(array10))
				{
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (fileInfo.gpsSTMFileLength == 0)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.gpsSTMFileOffset;
						totalPage = fileInfo.gpsSTMFileLength / onePageLength;
						if (fileInfo.gpsSTMFileLength <= fileInfo.gpsNuFileLength || fileInfo.gpsSTMFileLength <= fileInfo.gpsNu2FileLength || fileInfo.gpsSTMFileLength <= fileInfo.gpsNu3FileLength)
						{
							if (fileInfo.gpsNuFileLength >= fileInfo.gpsNu2FileLength && fileInfo.gpsNuFileLength >= fileInfo.gpsNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsNuFileLength;
							}
							else if (fileInfo.gpsNu2FileLength >= fileInfo.gpsNuFileLength && fileInfo.gpsNu2FileLength >= fileInfo.gpsNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsNu2FileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsNu3FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.gpsSTMFileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (GPS STM)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				else if (array11 != null && receiveBytes.SequenceEqual(array11))
				{
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (fileInfo.gpsNu2FileLength == 0)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.gpsNu2FileOffset;
						totalPage = fileInfo.gpsNu2FileLength / onePageLength;
						if (fileInfo.gpsNu2FileLength <= fileInfo.gpsNuFileLength || fileInfo.gpsNu2FileLength <= fileInfo.gpsSTMFileLength || fileInfo.gpsNu2FileLength <= fileInfo.gpsNu3FileLength)
						{
							if (fileInfo.gpsNuFileLength >= fileInfo.gpsSTMFileLength && fileInfo.gpsNuFileLength >= fileInfo.gpsNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsNuFileLength;
							}
							else if (fileInfo.gpsSTMFileLength >= fileInfo.gpsNuFileLength && fileInfo.gpsSTMFileLength >= fileInfo.gpsNu3FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsSTMFileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsNu3FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.gpsNu2FileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (GPS Nuvo2)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				else
				{
					if (array12 == null || !receiveBytes.SequenceEqual(array12))
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_UNKNOWN_MCU_ID;
					}
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					if (fileInfo.gpsNu3FileLength == 0)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED;
					}
					if (!checkOnly)
					{
						fileOffset = fileInfo.gpsNu3FileOffset;
						totalPage = fileInfo.gpsNu3FileLength / onePageLength;
						if (fileInfo.gpsNu3FileLength <= fileInfo.gpsNuFileLength || fileInfo.gpsNu3FileLength <= fileInfo.gpsSTMFileLength || fileInfo.gpsNu3FileLength <= fileInfo.gpsNu2FileLength)
						{
							if (fileInfo.gpsNuFileLength >= fileInfo.gpsSTMFileLength && fileInfo.gpsNuFileLength >= fileInfo.gpsNu2FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsNuFileLength;
							}
							else if (fileInfo.gpsSTMFileLength >= fileInfo.gpsNuFileLength && fileInfo.gpsSTMFileLength >= fileInfo.gpsNu2FileLength)
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsSTMFileLength;
							}
							else
							{
								fileInfo.totalDownloadCnt -= fileInfo.gpsNu2FileLength;
							}
							fileInfo.totalDownloadCnt += fileInfo.gpsNu3FileLength;
						}
					}
					LogClass.WriteLog("Rx: MCU ID (GPS Nuvo3)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				// DECOMPILE-FIX: Removed the unreachable break; every preceding branch returns.
			case FWDloadFormat.Step.BLE:
				if (modelInfo.modelName == ModelName.R1 || modelInfo.modelName == ModelName.R3 || modelInfo.modelName == ModelName.R3_NZ || modelInfo.modelName == ModelName.R3_NZK || modelInfo.modelName == ModelName.R3_PLUS || modelInfo.modelName == ModelName.R3_NZK_PLUS || modelInfo.modelName == ModelName.R7 || modelInfo.modelName == ModelName.R7_NZ || modelInfo.modelName == ModelName.R7_IL)
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_DOSE_NOT_SUPPORT;
				}
				if (receiveBytes.SequenceEqual(FWDloadFormat.downloadCmdBLEMCUID))
				{
					if (!checkOnly)
					{
						totalPage = fileInfo.bleFileLength / onePageLength;
					}
					LogClass.WriteLog("Rx: MCU ID (BLE)");
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
				return FWDloadFormat.DLOAD_RESULT.FAIL_UNKNOWN_MCU_ID;
			}
			return FWDloadFormat.DLOAD_RESULT.FAIL_DOSE_NOT_SUPPORT;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00015458 File Offset: 0x00013658
		private static FWDloadFormat.DLOAD_RESULT DloadCheckMCUID(FWDloadFormat.Step step, RDInfo modelInfo, FWFileInfo fileInfo, byte[] receiveBytes)
		{
			int num = 0;
			return FWUpdate.DloadCheckMCUID(step, modelInfo, fileInfo, true, receiveBytes, 0, ref num, ref num);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00015478 File Offset: 0x00013678
		public static FWDloadFormat.DLOAD_RESULT DloadCheckValidMCUID(UARTCommUtils uart, RDInfo modelInfo, FWFileInfo fileInfo)
		{
			FWDloadFormat.Step step = FWDloadFormat.Step.UI;
			for (;;)
			{
				byte[] mcuid = ReadRDVersionInfo.GetMCUID(uart, modelInfo, step);
				if (mcuid == null)
				{
					break;
				}
				FWDloadFormat.DLOAD_RESULT dload_RESULT = FWUpdate.DloadCheckMCUID(step, modelInfo, fileInfo, mcuid);
				if (dload_RESULT != FWDloadFormat.DLOAD_RESULT.OKAY)
				{
					return dload_RESULT;
				}
				Thread.Sleep(200);
				if (step == FWDloadFormat.Step.UI)
				{
					step = FWDloadFormat.Step.DSP;
				}
				else if (step == FWDloadFormat.Step.DSP)
				{
					if (modelInfo.modelName == ModelName.R1)
					{
						return FWDloadFormat.DLOAD_RESULT.OKAY;
					}
					step = FWDloadFormat.Step.GPS;
				}
				else if (step == FWDloadFormat.Step.GPS)
				{
					if (modelInfo.modelName != ModelName.R4 && modelInfo.modelName != ModelName.R4_NZ && modelInfo.modelName != ModelName.R4_IL && modelInfo.modelName != ModelName.R4_EU && modelInfo.modelName != ModelName.R8 && modelInfo.modelName != ModelName.R8_NZ && modelInfo.modelName != ModelName.R8_IL && modelInfo.modelName != ModelName.R8_EU && modelInfo.modelName != ModelName.R4W && modelInfo.modelName != ModelName.R8W)
					{
						return FWDloadFormat.DLOAD_RESULT.OKAY;
					}
					step = FWDloadFormat.Step.BLE;
				}
				else if (step == FWDloadFormat.Step.BLE)
				{
					return FWDloadFormat.DLOAD_RESULT.OKAY;
				}
			}
			uart.WriteBytes(FWDloadFormat.downloadCmdNACK);
			return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00015550 File Offset: 0x00013750
		private static byte GetCheckSumFromByteArray(byte[] byteArray)
		{
			byte b = 0;
			for (int i = 0; i < byteArray.Length; i++)
			{
				b ^= byteArray[i];
			}
			return b;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00015578 File Offset: 0x00013778
		private static FWDloadFormat.DLOAD_RESULT UpdateMCUSW(byte[] fileData, UARTCommUtils uart, FWDloadFormat.Step step, RDInfo modelInfo, FWFileInfo fileInfo, ProgressBarAsync progress, out int sendBytes)
		{
			byte[] array = new byte[4];
			byte[] array2 = new byte[1];
			int num = 0;
			int num2 = 0;
			sendBytes = 0;
			byte[] writeBytes;
			// DECOMPILE-FIX: All four switch arms store to the same IL local (V_2).
			// Keep that page buffer in method scope instead of separate shadowed locals.
			byte[] array3;
			int num3;
			switch (step)
			{
			case FWDloadFormat.Step.UI:
			{
				writeBytes = FWDloadFormat.downloadCmdUIDload;
				num3 = FWDloadFormat.uiOnePage;
				array3 = new byte[num3];
				goto IL_A1;
			}
			case FWDloadFormat.Step.DSP:
			{
				writeBytes = FWDloadFormat.downloadCmdDSPDload;
				num3 = FWDloadFormat.dspOnePage;
				array3 = new byte[num3];
				goto IL_A1;
			}
			case FWDloadFormat.Step.GPS:
			{
				writeBytes = FWDloadFormat.downloadCmdGPSDload;
				num3 = FWDloadFormat.gpsOnePage;
				array3 = new byte[num3];
				goto IL_A1;
			}
			case FWDloadFormat.Step.BLE:
			{
				writeBytes = FWDloadFormat.downloadCmdBLEDload;
				num = fileInfo.bleFileOffset;
				num3 = FWDloadFormat.bleOnPage;
				array3 = new byte[num3];
				goto IL_A1;
			}
			}
			return FWDloadFormat.DLOAD_RESULT.FAIL_DOSE_NOT_SUPPORT;
			IL_A1:
			if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Beacon Communication");
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Tx: SYN");
			if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Rx: SYN");
			if (!uart.WriteBytes(writeBytes))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Tx: Dload Cmd");
			if (step == FWDloadFormat.Step.GPS)
			{
				if (!uart.WriteBytes(FWDloadFormat.downloadCmdDSPDload))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Tx: Dload Cmd {'M', '0', 65} (Toms bug)");
			}
			byte[] array4 = uart.NByteRead(FWDloadFormat.downloadCmdLength, FWDloadFormat.time500msec, false);
			if (array4 == null)
			{
				uart.WriteBytes(FWDloadFormat.downloadCmdNACK);
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			FWDloadFormat.DLOAD_RESULT dload_RESULT = FWUpdate.DloadCheckMCUID(step, modelInfo, fileInfo, false, array4, num3, ref num, ref num2);
			if (dload_RESULT != FWDloadFormat.DLOAD_RESULT.OKAY)
			{
				return dload_RESULT;
			}
			progress.SetTotalCnt(fileInfo.totalDownloadCnt);
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Tx: ACK");
			if (!uart.CompareRead(FWDloadFormat.downloadCmdRxReady, FWDloadFormat.DLOAD_RDY_WAIT_TIME, false))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Rx: RDY");
			if (!uart.WriteBytes(new byte[]
			{
				0,
				0,
				(byte)(num2 & 255),
				(byte)((num2 & 65280) >> 8)
			}))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Tx: Packet cnt");
			array4 = uart.NByteRead(4, FWDloadFormat.time200msec, false);
			LogClass.WriteLog("Rx: Packet cnt");
			if (array4 == null)
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			if (ReadRDVersionInfo.ReverseLSBtoMSB(array4, 2, 2) != num2)
			{
				LogClass.WriteLog("Packet cnt invalid");
				if (!uart.WriteBytes(FWDloadFormat.downloadCmdNACK))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Tx: NACK");
				return FWDloadFormat.DLOAD_RESULT.FAIL_CONFIRM_DATA_IS_NOT_VALID;
			}
			else
			{
				LogClass.WriteLog("Packet cnt valid");
				if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Tx: ACK");
				if (step == FWDloadFormat.Step.BLE)
				{
					if (!uart.WriteBytes(FWDloadFormat.downloadCmdFlashClear))
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
					}
					LogClass.WriteLog("Tx: CLR");
					for (;;)
					{
						array4 = uart.NByteRead(FWDloadFormat.downloadCmdACK.Length, FWDloadFormat.time3sec, false);
						if (array4 == null)
						{
							break;
						}
						if (array4[0] == FWDloadFormat.downloadCmdACK[0])
						{
							goto IL_2BE;
						}
						if (array4[0] == FWDloadFormat.downloadCmdNACK[0])
						{
							LogClass.WriteLog("Rx: NACK");
						}
					}
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
					IL_2BE:
					if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
					}
					LogClass.WriteLog("Tx: ACK");
				}
				if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Rx: ACK");
				array = new byte[2];
				for (int i = 0; i < num2; i++)
				{
					int num4 = 0;
					for (;;)
					{
						array[0] = (byte)(i & 255);
						array[1] = (byte)((i & 65280) >> 8);
						LogClass.WriteLog("Tx Ready");
						if (!uart.WriteBytes(array))
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						LogClass.WriteLog("Tx: Packet Num");
						array4 = uart.NByteRead(FWDloadFormat.downloadCmdACK.Length, FWDloadFormat.time200msec, false);
						if (array4 == null)
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						if (array4[0] == FWDloadFormat.downloadCmdACK[0])
						{
							break;
						}
						num4++;
						LogClass.WriteLog("Rx: Unknown Error=" + Convert.ToString(array4[0]) + " Count:" + num4.ToString());
						if (num4 > FWDloadFormat.DLOAD_SEND_DATA_ERROR_RETRY_CNT)
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
					}
					LogClass.WriteLog("Rx: ACK");
					Array.Copy(fileData, num + i * num3, array3, 0, num3);
					array2[0] = FWUpdate.GetCheckSumFromByteArray(array3);
					num4 = 0;
					for (;;)
					{
						LogClass.WriteLog("Tx Ready");
						if (!uart.WriteBytes(array3))
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						LogClass.WriteLog(string.Concat(new string[]
						{
							"Tx: File Data ",
							num3.ToString(),
							"(",
							((i + 1) * num3).ToString(),
							" / ",
							(num2 * num3).ToString(),
							")"
						}));
						if (!uart.WriteBytes(array2))
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						LogClass.WriteLog("Tx: Check Sum Byte=" + string.Format("0x{0:X2}", array2[0]));
						array4 = uart.NByteRead(FWDloadFormat.downloadCmdACK.Length, FWDloadFormat.DLOAD_CODE_DATA_RSP_WAIT_TIME, false);
						if (array4 == null)
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						if (array4[0] == FWDloadFormat.downloadCmdACK[0])
						{
							break;
						}
						num4++;
						LogClass.WriteLog("Rx: Unknown Error=" + string.Format("0x{0:X2}", array4[0]) + "Count:" + num4.ToString());
						if (num4 > FWDloadFormat.DLOAD_SEND_DATA_ERROR_RETRY_CNT)
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
					}
					LogClass.WriteLog("Rx: ACK");
					progress.SetSendCnt(num3, true);
					fileInfo.totalSendCnt += num3;
					sendBytes += num3;
					LogClass.WriteLog("Update Progressbar");
				}
				if (!uart.WriteBytes(FWDloadFormat.downloadCmdEnd))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Tx: END");
				if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.DLOAD_END_RSP_WAIT_TIME, false))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Rx: ACK");
				Thread.Sleep(FWDloadFormat.DLOAD_MCU_REBOOT_DELAY_TIME);
				return FWDloadFormat.DLOAD_RESULT.OKAY;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00015AE4 File Offset: 0x00013CE4
		private static FWDloadFormat.DLOAD_RESULT UpdateSoundDB(byte[] fileData, UARTCommUtils uart, RDInfo modelInfo, FWFileInfo fileInfo, ProgressBarAsync progress, out int sendBytes)
		{
			byte[] array = new byte[FWDloadFormat.soundDBOnePage];
			byte[] array2 = new byte[4];
			byte[] array3 = new byte[1];
			sendBytes = 0;
			FWDloadFormat.VOICE_IC voiceICType = modelInfo.voiceICType;
			int num;
			int num2;
			if (voiceICType != FWDloadFormat.VOICE_IC.NUVOTON_IC)
			{
				if (voiceICType != FWDloadFormat.VOICE_IC.LAPIS1_IC)
				{
					if (voiceICType != FWDloadFormat.VOICE_IC.LAPIS2_IC)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_DOSE_NOT_SUPPORT;
					}
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					num = fileInfo.soundDBLa2FileOffset;
					num2 = fileInfo.soundDBLa2FileLength / FWDloadFormat.soundDBOnePage;
				}
				else
				{
					if (!fileInfo.isNewMergeFile)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE;
					}
					num = fileInfo.soundDBLa1FileOffset;
					num2 = fileInfo.soundDBLa1FileLength / FWDloadFormat.soundDBOnePage;
				}
			}
			else
			{
				num = fileInfo.soundDBNuFileOffset;
				num2 = fileInfo.soundDBNuFileLength / FWDloadFormat.soundDBOnePage;
			}
			if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Beacon Communication");
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Tx: SYN");
			if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Rx: SYN");
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdSoundDBDload))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Tx: VWU");
			if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time1sec, false))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Rx: SYN");
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Tx: SYN");
			if (!uart.CompareRead(FWDloadFormat.downloadCmdRxReady, FWDloadFormat.time200msec, false))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Rx: RDY");
			if (!uart.WriteBytes(new byte[]
			{
				(byte)(num2 & 255),
				(byte)((num2 & 65280) >> 8)
			}))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Tx: Packet cnt");
			byte[] array4 = uart.NByteRead(2, FWDloadFormat.time200msec, false);
			if (array4 == null)
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Rx: Packet cnt");
			if (ReadRDVersionInfo.ReverseLSBtoMSB(array4, 0, 2) != num2)
			{
				LogClass.WriteLog("Packet cnt invalid");
				if (!uart.WriteBytes(FWDloadFormat.downloadCmdNACK))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Tx: NACK");
				return FWDloadFormat.DLOAD_RESULT.FAIL_CONFIRM_DATA_IS_NOT_VALID;
			}
			else
			{
				LogClass.WriteLog("Packet cnt valid");
				if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Tx: ACK");
				if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Rx: NACK");
				int i = 0;
				IL_3C4:
				while (i < num2)
				{
					Array.Copy(fileData, num + i * FWDloadFormat.soundDBOnePage, array, 0, FWDloadFormat.soundDBOnePage);
					LogClass.WriteLog("File Data Old Decrypt Start");
					array = FWDloadFormat.OldModelDecoder(FWDloadFormat.soundDBKey, array, 0, array.Length);
					LogClass.WriteLog("File Data Old Decrypt End");
					array3[0] = FWUpdate.GetCheckSumFromByteArray(array);
					int num3 = 0;
					while (uart.WriteBytes(array))
					{
						LogClass.WriteLog(string.Concat(new string[]
						{
							"Tx: File Data ",
							FWDloadFormat.soundDBOnePage.ToString(),
							"(",
							((i + 1) * FWDloadFormat.soundDBOnePage).ToString(),
							" / ",
							(num2 * FWDloadFormat.soundDBOnePage).ToString(),
							")"
						}));
						if (!uart.WriteBytes(array3))
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						LogClass.WriteLog("Tx: Check Sum Byte=" + string.Format("0x{0:X2}", array3[0]));
						array4 = uart.NByteRead(FWDloadFormat.downloadCmdACK.Length, FWDloadFormat.time3sec, false);
						if (array4 == null)
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						if (array4[0] == FWDloadFormat.downloadCmdACK[0])
						{
							LogClass.WriteLog("Rx: ACK");
							progress.SetSendCnt(FWDloadFormat.soundDBOnePage, true);
							fileInfo.totalSendCnt += FWDloadFormat.soundDBOnePage;
							sendBytes += FWDloadFormat.soundDBOnePage;
							LogClass.WriteLog("Update Progressbar");
							i++;
							goto IL_3C4;
						}
						num3++;
						LogClass.WriteLog("Rx: Unknown Error=" + string.Format("0x{0:X2}", array4[0]) + "Count:" + num3.ToString());
						if (num3 > FWDloadFormat.DLOAD_SEND_DATA_ERROR_RETRY_CNT)
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
					}
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				if (!uart.WriteBytes(FWDloadFormat.downloadCmdEnd))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Tx: END");
				if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Rx: ACK");
				return FWDloadFormat.DLOAD_RESULT.OKAY;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00015EF8 File Offset: 0x000140F8
		private static FWDloadFormat.DLOAD_RESULT UpdateGPSDB(byte[] fileData, UARTCommUtils uart, RDInfo modelInfo, FWFileInfo fileInfo, ProgressBarAsync progress, out int sendBytes)
		{
			FWDloadFormat.GPS_DB_TYPE gps_DB_TYPE = FWDloadFormat.GPS_DB_TYPE.UNKNOWN;
			byte[] array = new byte[FWDloadFormat.gpsDBOnePage];
			byte[] array2 = new byte[4];
			byte[] array3 = new byte[1];
			sendBytes = 0;
			int gpsDBFileOffset = fileInfo.gpsDBFileOffset;
			int num = fileInfo.gpsDBFileLength / FWDloadFormat.gpsDBOnePage;
			if (!uart.BeaconComm(modelInfo.serialPortName, FWDloadFormat.time500msec, true))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Beacon Communication");
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdSync))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Tx: SYN");
			if (!uart.CompareRead(FWDloadFormat.downloadCmdSync, FWDloadFormat.time200msec, false))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Rx: SYN");
			if (!uart.WriteBytes(FWDloadFormat.downloadCmdGPSDBDload))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Tx: DBW");
			byte[] array4 = uart.NByteRead(FWDloadFormat.downloadCmdLength, FWDloadFormat.time500msec, false);
			if (array4 == null)
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			FWDloadFormat.DLOAD_RESULT dload_RESULT = FWUpdate.DloadCheckDBType(modelInfo, fileInfo, false, array4, FWDloadFormat.gpsDBOnePage, ref gpsDBFileOffset, ref num, ref gps_DB_TYPE);
			if (dload_RESULT != FWDloadFormat.DLOAD_RESULT.OKAY)
			{
				return dload_RESULT;
			}
			if (!uart.WriteBytes(new byte[]
			{
				(byte)(fileInfo.gpsDBFilePOI & 255),
				(byte)((fileInfo.gpsDBFilePOI & 65280) >> 8)
			}))
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Tx: GPS POI cnt");
			array4 = uart.NByteRead(2, FWDloadFormat.time200msec, false);
			if (array4 == null)
			{
				return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
			}
			LogClass.WriteLog("Rx: GPS POI cnt");
			if (ReadRDVersionInfo.ReverseLSBtoMSB(array4, 0, 2) != fileInfo.gpsDBFilePOI)
			{
				LogClass.WriteLog("GPS POI cnt invaild");
				if (!uart.WriteBytes(FWDloadFormat.downloadCmdNACK))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Tx: NACK");
				return FWDloadFormat.DLOAD_RESULT.FAIL_CONFIRM_DATA_IS_NOT_VALID;
			}
			else
			{
				LogClass.WriteLog("GPS POI cnt vaild");
				if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Tx: ACK");
				if (!uart.WriteBytes(new byte[]
				{
					(byte)(fileInfo.gpsDBFileVersion & 255),
					(byte)((fileInfo.gpsDBFileVersion & 65280) >> 8),
					(byte)((fileInfo.gpsDBFileVersion & 16711680) >> 16),
					// DECOMPILE-FIX: Allow the original unchecked conversion of the signed high-byte mask.
					unchecked((byte)(((long)fileInfo.gpsDBFileVersion & (long)((ulong)-16777216)) >> 24))
				}))
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Tx: GPS Version");
				array4 = uart.NByteRead(4, FWDloadFormat.time200msec, false);
				if (array4 == null)
				{
					return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
				}
				LogClass.WriteLog("Rx: GPS Version");
				if (ReadRDVersionInfo.ReverseLSBtoMSB(array4, 0, 4) != fileInfo.gpsDBFileVersion)
				{
					LogClass.WriteLog("GPS Version invaild");
					if (!uart.WriteBytes(FWDloadFormat.downloadCmdNACK))
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
					}
					LogClass.WriteLog("Tx: NACK");
					return FWDloadFormat.DLOAD_RESULT.FAIL_CONFIRM_DATA_IS_NOT_VALID;
				}
				else
				{
					if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
					}
					LogClass.WriteLog("Tx: ACK");
					if (!uart.WriteBytes(new byte[]
					{
						(byte)(num & 255),
						(byte)((num & 65280) >> 8)
					}))
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
					}
					LogClass.WriteLog("Tx: Packet cnt");
					array4 = uart.NByteRead(2, FWDloadFormat.time200msec, false);
					if (array4 == null)
					{
						return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
					}
					LogClass.WriteLog("Rx: Packet cnt");
					if (ReadRDVersionInfo.ReverseLSBtoMSB(array4, 0, 2) != num)
					{
						LogClass.WriteLog("Packet cnt invaild");
						if (!uart.WriteBytes(FWDloadFormat.downloadCmdNACK))
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						LogClass.WriteLog("Tx: NACK");
						return FWDloadFormat.DLOAD_RESULT.FAIL_CONFIRM_DATA_IS_NOT_VALID;
					}
					else
					{
						LogClass.WriteLog("Packet cnt vaild");
						if (!uart.WriteBytes(FWDloadFormat.downloadCmdACK))
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						LogClass.WriteLog("Tx: ACK");
						if (!uart.WriteBytes(FWDloadFormat.downloadCmdFlashClear))
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						LogClass.WriteLog("Tx: CLR");
						for (;;)
						{
							array4 = uart.NByteRead(FWDloadFormat.downloadCmdACK.Length, FWDloadFormat.time1sec, false);
							if (array4 == null)
							{
								break;
							}
							if (array4[0] == FWDloadFormat.downloadCmdACK[0])
							{
								goto IL_369;
							}
							if (array4[0] == FWDloadFormat.downloadCmdNACK[0])
							{
								LogClass.WriteLog("Rx: NACK");
							}
						}
						return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						IL_369:
						LogClass.WriteLog("Rx: ACK");
						if (!uart.WriteBytes(FWDloadFormat.downloadCmdEnd))
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						LogClass.WriteLog("Tx: END");
						if (!uart.CompareRead(FWDloadFormat.downloadCmdRxReady, FWDloadFormat.time200msec, false))
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						LogClass.WriteLog("Rx: RDY");
						int i = 0;
						IL_54D:
						while (i < num)
						{
							Array.Copy(fileData, gpsDBFileOffset + i * FWDloadFormat.gpsDBOnePage, array, 0, FWDloadFormat.gpsDBOnePage);
							if (gps_DB_TYPE == FWDloadFormat.GPS_DB_TYPE.GPS_DB_OLD_ENC)
							{
								LogClass.WriteLog("File Data Old Decrypt Start");
								array = FWDloadFormat.OldModelDecoder(modelInfo.oldgpsDBKey, array, 0, array.Length);
								LogClass.WriteLog("File Data Old Decrypt End");
							}
							array3[0] = FWUpdate.GetCheckSumFromByteArray(array);
							int num2 = 0;
							while (uart.WriteBytes(array))
							{
								LogClass.WriteLog(string.Concat(new string[]
								{
									"Tx: File Data ",
									FWDloadFormat.gpsDBOnePage.ToString(),
									"(",
									((i + 1) * FWDloadFormat.gpsDBOnePage).ToString(),
									" / ",
									(num * FWDloadFormat.gpsDBOnePage).ToString(),
									")"
								}));
								if (!uart.WriteBytes(array3))
								{
									return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
								}
								LogClass.WriteLog("Tx: Check Sum Byte=" + string.Format("0x{0:X2}", array3[0]));
								array4 = uart.NByteRead(FWDloadFormat.downloadCmdACK.Length, FWDloadFormat.time1sec, false);
								if (array4 == null)
								{
									return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
								}
								if (array4[0] == FWDloadFormat.downloadCmdACK[0])
								{
									LogClass.WriteLog("Rx: ACK");
									progress.SetSendCnt(FWDloadFormat.gpsDBOnePage, true);
									fileInfo.totalSendCnt += FWDloadFormat.gpsDBOnePage;
									sendBytes += FWDloadFormat.gpsDBOnePage;
									LogClass.WriteLog("Update Progressbar");
									i++;
									goto IL_54D;
								}
								num2++;
								LogClass.WriteLog("Rx: Unknown Error=" + string.Format("0x{0:X2}", array4[0]) + "Count:" + num2.ToString());
								if (num2 > FWDloadFormat.DLOAD_SEND_DATA_ERROR_RETRY_CNT)
								{
									return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
								}
							}
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						if (!uart.WriteBytes(FWDloadFormat.downloadCmdEnd))
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						LogClass.WriteLog("Tx: END");
						if (!uart.CompareRead(FWDloadFormat.downloadCmdACK, FWDloadFormat.time200msec, false))
						{
							return FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT;
						}
						LogClass.WriteLog("Rx: ACK");
						return FWDloadFormat.DLOAD_RESULT.OKAY;
					}
				}
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00016494 File Offset: 0x00014694
		public static FWDloadFormat.DLOAD_RESULT SoundDBVersionReadAndCheck(UARTCommUtils uart, RDInfo modelInfo, FWFileInfo fileInfo, ProgressBarAsync progress)
		{
			if (fileInfo.soundDBDownloadFlag)
			{
				if (modelInfo.voiceICType == FWDloadFormat.VOICE_IC.NUVOTON_IC)
				{
					fileInfo.totalDownloadCnt -= fileInfo.soundDBNuFileLength;
				}
				else if (modelInfo.voiceICType == FWDloadFormat.VOICE_IC.LAPIS1_IC)
				{
					fileInfo.totalDownloadCnt -= fileInfo.soundDBLa1FileLength;
				}
				else if (modelInfo.voiceICType == FWDloadFormat.VOICE_IC.LAPIS2_IC)
				{
					fileInfo.totalDownloadCnt -= fileInfo.soundDBLa2FileLength;
				}
				else if (fileInfo.soundDBNuFileLength >= fileInfo.soundDBLa1FileLength && fileInfo.soundDBNuFileLength >= fileInfo.soundDBLa2FileLength)
				{
					fileInfo.totalDownloadCnt -= fileInfo.soundDBNuFileLength;
				}
				else if (fileInfo.soundDBLa1FileLength >= fileInfo.soundDBNuFileLength && fileInfo.soundDBLa1FileLength >= fileInfo.soundDBLa2FileLength)
				{
					fileInfo.totalDownloadCnt -= fileInfo.soundDBLa1FileLength;
				}
				else
				{
					fileInfo.totalDownloadCnt -= fileInfo.soundDBLa2FileLength;
				}
				LogClass.WriteLog("Voice version read");
				int[] soundDBVersion = ReadRDVersionInfo.GetSoundDBVersion(uart, modelInfo);
				modelInfo.voiceICType = (FWDloadFormat.VOICE_IC)soundDBVersion[0];
				modelInfo.versionSoundDB = soundDBVersion[1];
				if (modelInfo.voiceICType == FWDloadFormat.VOICE_IC.NUVOTON_IC)
				{
					if (fileInfo.soundDBNuFileLength != 0)
					{
						if (fileInfo.recoveryModeFlag || modelInfo.versionSoundDB != fileInfo.soundDBNuFileVersion)
						{
							fileInfo.soundDBDownloadFlag = true;
							fileInfo.totalDownloadCnt += fileInfo.soundDBNuFileLength;
						}
						else
						{
							fileInfo.soundDBDownloadFlag = false;
						}
					}
					else
					{
						fileInfo.soundDBDownloadFlag = false;
					}
				}
				else if (modelInfo.voiceICType == FWDloadFormat.VOICE_IC.LAPIS1_IC)
				{
					if (fileInfo.soundDBLa1FileLength != 0)
					{
						if (fileInfo.recoveryModeFlag || modelInfo.versionSoundDB != fileInfo.soundDBLa1FileVersion)
						{
							fileInfo.soundDBDownloadFlag = true;
							fileInfo.totalDownloadCnt += fileInfo.soundDBLa1FileLength;
						}
						else
						{
							fileInfo.soundDBDownloadFlag = false;
						}
					}
					else
					{
						fileInfo.soundDBDownloadFlag = false;
					}
				}
				else
				{
					if (modelInfo.voiceICType != FWDloadFormat.VOICE_IC.LAPIS2_IC)
					{
						fileInfo.soundDBDownloadFlag = false;
						return FWDloadFormat.DLOAD_RESULT.FAIL_VOICE_IC_IS_UNKNOWN;
					}
					if (fileInfo.soundDBLa2FileLength != 0)
					{
						if (fileInfo.recoveryModeFlag || modelInfo.versionSoundDB != fileInfo.soundDBLa2FileVersion)
						{
							fileInfo.soundDBDownloadFlag = true;
							fileInfo.totalDownloadCnt += fileInfo.soundDBLa2FileLength;
						}
						else
						{
							fileInfo.soundDBDownloadFlag = false;
						}
					}
					else
					{
						fileInfo.soundDBDownloadFlag = false;
					}
				}
				progress.SetTotalCnt(fileInfo.totalDownloadCnt);
				return FWDloadFormat.DLOAD_RESULT.OKAY;
			}
			return FWDloadFormat.DLOAD_RESULT.OKAY;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000166D8 File Offset: 0x000148D8
		public static void resultLoging(FWDloadFormat.DLOAD_RESULT result)
		{
			switch (result)
			{
			case FWDloadFormat.DLOAD_RESULT.FAIL_TIMEOUT:
				LogClass.WriteLog("Failed (Timeout)");
				return;
			case FWDloadFormat.DLOAD_RESULT.FAIL_UNKNOWN_MCU_ID:
				LogClass.WriteLog("Failed (Unknown MCU ID)");
				return;
			case FWDloadFormat.DLOAD_RESULT.FAIL_FILE_NOT_EXISTED:
				LogClass.WriteLog("Failed (File not existed)");
				return;
			case FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE:
				LogClass.WriteLog("Failed (cannot downgrade to this file)");
				return;
			case FWDloadFormat.DLOAD_RESULT.FAIL_CONFIRM_DATA_IS_NOT_VALID:
				LogClass.WriteLog("Failed (confirm data is not vaild)");
				return;
			case FWDloadFormat.DLOAD_RESULT.FAIL_DOSE_NOT_SUPPORT:
				LogClass.WriteLog("Failed (dose not support)");
				return;
			case FWDloadFormat.DLOAD_RESULT.FAIL_VOICE_IC_IS_UNKNOWN:
				LogClass.WriteLog("Failed (voice ic is unknown)");
				return;
			case FWDloadFormat.DLOAD_RESULT.OKAY:
				LogClass.WriteLog("Successful");
				return;
			default:
				return;
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00016764 File Offset: 0x00014964
		public static FWDloadFormat.DLOAD_RESULT StartUpdate(FileStream fwFile, UARTCommUtils uart, RDInfo modelInfo, FWFileInfo fileInfo, ProgressBar progressBar, Label label, Label percentLabel)
		{
			ProgressBarAsync progressBarAsync = null;
			FWDloadFormat.DLOAD_RESULT result;
			try
			{
				LogClass.WriteLog("Update Start");
				LogClass.WriteLog("Read All File Data Start");
				byte[] array = new byte[fwFile.Length];
				fwFile.Read(array, 0, (int)fwFile.Length);
				LogClass.WriteLog("Read All File Data End");
				fwFile.Close();
				progressBarAsync = new ProgressBarAsync(progressBar, 0, 1000, fileInfo.totalDownloadCnt, percentLabel);
				progressBarAsync.Start();
				FWDloadFormat.DLOAD_RESULT dload_RESULT;
				if (fileInfo.uiDownloadFlag)
				{
					int num = 0;
					LogClass.WriteLog("UI Update Start (Retry Count: " + num.ToString() + ")");
					SafetyControl.SetText(label, "UI");
					for (;;)
					{
						int num2;
						dload_RESULT = FWUpdate.UpdateMCUSW(array, uart, FWDloadFormat.Step.UI, modelInfo, fileInfo, progressBarAsync, out num2);
						if (dload_RESULT == FWDloadFormat.DLOAD_RESULT.OKAY)
						{
							goto IL_132;
						}
						if (dload_RESULT == FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE)
						{
							break;
						}
						FWUpdate.resultLoging(dload_RESULT);
						if (++num == FWDloadFormat.DLOAD_FAIL_CURRENT_TARGET_RETRY_CNT)
						{
							goto Block_6;
						}
						fileInfo.totalSendCnt -= num2;
						progressBarAsync.SetSendCnt(-num2, false);
						LogClass.WriteLog("UI Update Failed and Retry (Retry Count:" + num.ToString() + ")");
						SafetyControl.SetText(label, "UI-retry");
						Thread.Sleep(500);
					}
					LogClass.WriteLog("Cannot Downgrade");
					return dload_RESULT;
					Block_6:
					LogClass.WriteLog("UI Update Failed");
					return dload_RESULT;
					IL_132:
					LogClass.WriteLog("UI Update Completed");
				}
				if (fileInfo.dspDownloadFlag)
				{
					int num = 0;
					LogClass.WriteLog("DSP Update Start (Retry Count: " + num.ToString() + ")");
					SafetyControl.SetText(label, "DSP");
					for (;;)
					{
						int num2;
						dload_RESULT = FWUpdate.UpdateMCUSW(array, uart, FWDloadFormat.Step.DSP, modelInfo, fileInfo, progressBarAsync, out num2);
						if (dload_RESULT == FWDloadFormat.DLOAD_RESULT.OKAY)
						{
							goto IL_1F6;
						}
						FWUpdate.resultLoging(dload_RESULT);
						if (++num == FWDloadFormat.DLOAD_FAIL_CURRENT_TARGET_RETRY_CNT)
						{
							break;
						}
						fileInfo.totalSendCnt -= num2;
						progressBarAsync.SetSendCnt(-num2, false);
						LogClass.WriteLog("DSP Update Failed and Retry (Retry Count:" + num.ToString() + ")");
						SafetyControl.SetText(label, "DSP-retry");
						Thread.Sleep(500);
					}
					LogClass.WriteLog("DSP Update Failed");
					return dload_RESULT;
					IL_1F6:
					LogClass.WriteLog("DSP Update Completed");
				}
				if (fileInfo.gpsDownloadFlag)
				{
					int num = 0;
					LogClass.WriteLog("GPS Update Start (Retry Count: " + num.ToString() + ")");
					SafetyControl.SetText(label, "GPS");
					for (;;)
					{
						int num2;
						dload_RESULT = FWUpdate.UpdateMCUSW(array, uart, FWDloadFormat.Step.GPS, modelInfo, fileInfo, progressBarAsync, out num2);
						if (dload_RESULT == FWDloadFormat.DLOAD_RESULT.OKAY)
						{
							goto IL_2BA;
						}
						FWUpdate.resultLoging(dload_RESULT);
						if (++num == FWDloadFormat.DLOAD_FAIL_CURRENT_TARGET_RETRY_CNT)
						{
							break;
						}
						fileInfo.totalSendCnt -= num2;
						progressBarAsync.SetSendCnt(-num2, false);
						LogClass.WriteLog("GPS Update Failed and Retry (Retry Count:" + num.ToString() + ")");
						SafetyControl.SetText(label, "GPS-retry");
						Thread.Sleep(500);
					}
					LogClass.WriteLog("GPS Update Failed");
					return dload_RESULT;
					IL_2BA:
					LogClass.WriteLog("GPS Update Completed");
				}
				dload_RESULT = FWUpdate.SoundDBVersionReadAndCheck(uart, modelInfo, fileInfo, progressBarAsync);
				if (dload_RESULT != FWDloadFormat.DLOAD_RESULT.OKAY)
				{
					FWUpdate.resultLoging(dload_RESULT);
					result = dload_RESULT;
				}
				else
				{
					if (fileInfo.soundDBDownloadFlag)
					{
						int num = 0;
						LogClass.WriteLog("Sound dB Update Start (Retry Count: " + num.ToString() + ")");
						SafetyControl.SetText(label, "Sound dB");
						for (;;)
						{
							int num2;
							dload_RESULT = FWUpdate.UpdateSoundDB(array, uart, modelInfo, fileInfo, progressBarAsync, out num2);
							if (dload_RESULT == FWDloadFormat.DLOAD_RESULT.OKAY)
							{
								goto IL_3B2;
							}
							if (dload_RESULT == FWDloadFormat.DLOAD_RESULT.FAIL_CANNOT_DOWNGRADE_TO_THIS_FILE)
							{
								break;
							}
							FWUpdate.resultLoging(dload_RESULT);
							if (++num == FWDloadFormat.DLOAD_FAIL_CURRENT_TARGET_RETRY_CNT)
							{
								goto Block_17;
							}
							fileInfo.totalSendCnt -= num2;
							progressBarAsync.SetSendCnt(-num2, false);
							LogClass.WriteLog("Sound dB Update Failed and Retry (Retry Count:" + num.ToString() + ")");
							SafetyControl.SetText(label, "Sound dB-retry");
							Thread.Sleep(500);
						}
						LogClass.WriteLog("Cannot Downgrade");
						return dload_RESULT;
						Block_17:
						LogClass.WriteLog("Sound dB Update Failed");
						return dload_RESULT;
						IL_3B2:
						LogClass.WriteLog("Sound dB Update Completed");
					}
					if (fileInfo.gpsDBDownloadFlag)
					{
						int num = 0;
						LogClass.WriteLog("GPS dB Update Start (Retry Count: " + num.ToString() + ")");
						SafetyControl.SetText(label, "GPS dB");
						for (;;)
						{
							int num2;
							dload_RESULT = FWUpdate.UpdateGPSDB(array, uart, modelInfo, fileInfo, progressBarAsync, out num2);
							if (dload_RESULT == FWDloadFormat.DLOAD_RESULT.OKAY)
							{
								goto IL_475;
							}
							FWUpdate.resultLoging(dload_RESULT);
							if (++num == FWDloadFormat.DLOAD_FAIL_CURRENT_TARGET_RETRY_CNT)
							{
								break;
							}
							fileInfo.totalSendCnt -= num2;
							progressBarAsync.SetSendCnt(-num2, false);
							LogClass.WriteLog("GPS dB Update Failed and Retry (Retry Count:" + num.ToString() + ")");
							SafetyControl.SetText(label, "GPS dB-retry");
							Thread.Sleep(500);
						}
						LogClass.WriteLog("GPS dB Update Failed");
						return dload_RESULT;
						IL_475:
						LogClass.WriteLog("GPS dB Update Completed");
					}
					if (fileInfo.bleDownloadFlag)
					{
						int num = 0;
						string text;
						switch (modelInfo.modelName)
						{
						default:
							text = "Unknown";
							break;
						case ModelName.R4:
						case ModelName.R4_NZ:
						case ModelName.R4_IL:
						case ModelName.R4_EU:
						case ModelName.R8:
						case ModelName.R8_NZ:
						case ModelName.R8_IL:
						case ModelName.R8_EU:
							text = "BT";
							break;
						case ModelName.R4W:
						case ModelName.R8W:
							text = "BT/WIFI";
							break;
						}
						LogClass.WriteLog(text + " Update Start (Retry Count: " + num.ToString() + ")");
						SafetyControl.SetText(label, text);
						for (;;)
						{
							int num2;
							dload_RESULT = FWUpdate.UpdateMCUSW(array, uart, FWDloadFormat.Step.BLE, modelInfo, fileInfo, progressBarAsync, out num2);
							if (dload_RESULT == FWDloadFormat.DLOAD_RESULT.OKAY)
							{
								goto IL_5EB;
							}
							FWUpdate.resultLoging(dload_RESULT);
							if (++num == FWDloadFormat.DLOAD_FAIL_CURRENT_TARGET_RETRY_CNT)
							{
								break;
							}
							fileInfo.totalSendCnt -= num2;
							progressBarAsync.SetSendCnt(-num2, false);
							LogClass.WriteLog(text + " Update Failed and Retry (Retry Count:" + num.ToString() + ")");
							SafetyControl.SetText(label, text + "-Retry");
							Thread.Sleep(500);
						}
						LogClass.WriteLog(text + " Update Failed");
						return dload_RESULT;
						IL_5EB:
						LogClass.WriteLog(text + " Update Completed");
					}
					progressBarAsync.newPercent = 1000;
					result = dload_RESULT;
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
	}
}
