using System;
using System.IO;
using System.Text;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000015 RID: 21
	public class FWFileInfo
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00011624 File Offset: 0x0000F824
		public void DataClear()
		{
			this.isNewMergeFile = false;
			this.uiNuFileLength = 0;
			this.uiNuFileOffset = 0;
			this.uiNuFileVersion = -1;
			this.uiSTMFileLength = 0;
			this.uiSTMFileOffset = 0;
			this.uiSTMFileVersion = -1;
			this.uiNu2FileLength = 0;
			this.uiNu2FileOffset = 0;
			this.uiNu2FileVersion = -1;
			this.dspNuFileLength = 0;
			this.dspNuFileOffset = 0;
			this.dspNuFileVersion = -1;
			this.dspSTMFileLength = 0;
			this.dspSTMFileOffset = 0;
			this.dspSTMFileVersion = -1;
			this.dspNu2FileLength = 0;
			this.dspNu2FileOffset = 0;
			this.dspNu2FileVersion = -1;
			this.dspNu3FileLength = 0;
			this.dspNu3FileOffset = 0;
			this.dspNu3FileVersion = -1;
			this.gpsNuFileLength = 0;
			this.gpsNuFileOffset = 0;
			this.gpsNuFileVersion = -1;
			this.gpsSTMFileLength = 0;
			this.gpsSTMFileOffset = 0;
			this.gpsSTMFileVersion = -1;
			this.gpsNu2FileLength = 0;
			this.gpsNu2FileOffset = 0;
			this.gpsNu2FileVersion = -1;
			this.gpsNu3FileLength = 0;
			this.gpsNu3FileOffset = 0;
			this.gpsNu3FileVersion = -1;
			this.soundDBNuFileLength = 0;
			this.soundDBNuFileOffset = 0;
			this.soundDBNuFileVersion = -1;
			this.soundDBLa1FileLength = 0;
			this.soundDBLa1FileOffset = 0;
			this.soundDBLa1FileVersion = -1;
			this.soundDBLa2FileLength = 0;
			this.soundDBLa2FileOffset = 0;
			this.soundDBLa2FileVersion = -1;
			this.gpsDBFileLength = 0;
			this.gpsDBFileOffset = 0;
			this.gpsDBFileVersion = -1;
			this.gpsDBFileType = FWDloadFormat.GPS_DB_TYPE.UNKNOWN;
			this.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.NONE;
			this.gpsDBSecondFileLength = 0;
			this.gpsDBSecondFileOffset = 0;
			this.gpsDBSecondFileVersion = -1;
			this.gpsDBSecondFileType = FWDloadFormat.GPS_DB_TYPE.UNKNOWN;
			this.gpsDBSecondFileCountry = FWDloadFormat.GPS_DB_COUNTRY.NONE;
			this.gpsDBExistOldEncFile = false;
			this.gpsDBExistAES128File = false;
			this.bleFileLength = 0;
			this.bleFileOffset = 0;
			this.bleFileVersion = -1;
			this.keypadFileLength = 0;
			this.keypadFileOffset = 0;
			this.keypadFileVersion = -1;
			this.laserIFFileLength = 0;
			this.laserIFFileOffset = 0;
			this.laserIFFileVersion = -1;
			this.totalDownloadCnt = 0;
			this.totalSendCnt = 0;
			this.uiDownloadFlag = false;
			this.dspDownloadFlag = false;
			this.gpsDownloadFlag = false;
			this.soundDBDownloadFlag = false;
			this.gpsDBDownloadFlag = false;
			this.bleDownloadFlag = false;
			this.keypadDownloadFlag = false;
			this.laserIFDownloadFlag = false;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00011838 File Offset: 0x0000FA38
		public void DownloadFlagClear()
		{
			this.uiDownloadFlag = false;
			this.dspDownloadFlag = false;
			this.gpsDownloadFlag = false;
			this.soundDBDownloadFlag = false;
			this.gpsDBDownloadFlag = false;
			this.bleDownloadFlag = false;
			this.keypadDownloadFlag = false;
			this.laserIFDownloadFlag = false;
			this.totalDownloadCnt = 0;
			this.totalSendCnt = 0;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0001188C File Offset: 0x0000FA8C
		public static bool ReadNewFWFileInfo(FWFileInfo fileInfo)
		{
			bool flag = false;
			FileStream fileStream = null;
			fileInfo.DataClear();
			bool result;
			try
			{
				fileStream = new FileStream(fileInfo.filePath, FileMode.Open, FileAccess.Read);
				byte[] array = new byte[12];
				fileStream.Read(array, 0, array.Length);
				fileInfo.uiNuFileLength = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 3);
				if (fileInfo.uiNuFileLength != 0)
				{
					fileInfo.uiNuFileLength = (fileInfo.uiNuFileLength / 512 + 1) * 512;
				}
				if (array[3] == 1)
				{
					flag = true;
				}
				fileInfo.dspNuFileLength = ReadRDVersionInfo.ReverseLSBtoMSB(array, 4, 4);
				if (fileInfo.dspNuFileLength != 0)
				{
					fileInfo.dspNuFileLength = (fileInfo.dspNuFileLength / 512 + 1) * 512;
				}
				fileInfo.gpsNuFileLength = ReadRDVersionInfo.ReverseLSBtoMSB(array, 8, 4);
				if (fileInfo.gpsNuFileLength != 0)
				{
					fileInfo.gpsNuFileLength = (fileInfo.gpsNuFileLength / 512 + 1) * 512;
				}
				if (flag)
				{
					array = new byte[12];
					fileStream.Read(array, 0, array.Length);
					fileInfo.soundDBNuFileLength = ReadRDVersionInfo.ReverseLSBtoMSB(array, 8, 4);
				}
				if (fileInfo.uiNuFileLength != 0)
				{
					fileInfo.uiNuFileOffset = (int)fileStream.Position;
					fileStream.Position += (long)fileInfo.uiNuFileLength;
					array = new byte[9];
					fileStream.Read(array, 0, array.Length);
					fileInfo.modelName = ReadRDVersionInfo.getModelNumber(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
					fileInfo.uiNuFileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
					byte[] array2 = new byte[7];
					Array.Copy(array, 2, array2, 0, 7);
					if (!Encoding.Default.GetString(array2).Equals("DRSWMAI"))
					{
						return false;
					}
				}
				else
				{
					fileInfo.modelName = ModelName.UNKNOWN;
				}
				if (fileInfo.dspNuFileLength != 0)
				{
					fileInfo.dspNuFileOffset = (int)fileStream.Position;
					fileStream.Position += (long)fileInfo.dspNuFileLength;
					array = new byte[9];
					fileStream.Read(array, 0, array.Length);
					fileInfo.dspNuFileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
					byte[] array2 = new byte[7];
					Array.Copy(array, 2, array2, 0, 7);
					if (!Encoding.Default.GetString(array2).Equals("DRSWDSP"))
					{
						return false;
					}
				}
				if (fileInfo.gpsNuFileLength != 0)
				{
					fileInfo.gpsNuFileOffset = (int)fileStream.Position;
					fileStream.Position += (long)fileInfo.gpsNuFileLength;
					array = new byte[9];
					fileStream.Read(array, 0, array.Length);
					fileInfo.gpsNuFileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
					byte[] array2 = new byte[7];
					Array.Copy(array, 2, array2, 0, 7);
					if (!Encoding.Default.GetString(array2).Equals("DRSWSUB"))
					{
						return false;
					}
				}
				if (fileInfo.soundDBNuFileLength != 0)
				{
					fileInfo.soundDBNuFileOffset = (int)fileStream.Position;
					fileStream.Position += (long)fileInfo.soundDBNuFileLength - 12L;
					array = new byte[12];
					fileStream.Read(array, 0, array.Length);
					byte[] buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.soundDBKey, array, 0, 4);
					fileInfo.soundDBNuFileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(buffer, 0, 4));
					array = new byte[7];
					fileStream.Read(array, 0, array.Length);
					byte[] array2 = new byte[7];
					Array.Copy(array, 0, array2, 0, 7);
					if (!Encoding.Default.GetString(array2).Equals("DRSWSDB"))
					{
						return false;
					}
				}
				if (fileStream.Position == fileStream.Length)
				{
					result = true;
				}
				else
				{
					for (;;)
					{
						array = new byte[12];
						fileStream.Read(array, 0, array.Length);
						byte[] array2 = new byte[4];
						Array.Copy(array, 0, array2, 0, 4);
						string @string = Encoding.Default.GetString(array2);
						int num = ReadRDVersionInfo.ReverseLSBtoMSB(array, 8, 4);
						if (fileStream.Position > fileStream.Length)
						{
							break;
						}
						uint num2 = DecompileStringHash.ComputeStringHash(@string);
						if (num2 <= 2235141039U)
						{
							if (num2 <= 1452201659U)
							{
								if (num2 <= 465507764U)
								{
									if (num2 != 324884082U)
									{
										if (num2 != 465507764U)
										{
											goto IL_13EA;
										}
										if (!(@string == "STUI"))
										{
											goto IL_13EA;
										}
										fileInfo.uiSTMFileLength = num;
										fileInfo.uiSTMFileLength = (fileInfo.uiSTMFileLength / 512 + 1) * 512;
										fileInfo.uiSTMFileOffset = (int)fileStream.Position;
										fileStream.Position += (long)fileInfo.uiSTMFileLength;
										array = new byte[9];
										fileStream.Read(array, 0, array.Length);
										fileInfo.uiSTMFileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
										array2 = new byte[7];
										Array.Copy(array, 2, array2, 0, 7);
										if (!Encoding.Default.GetString(array2).Equals("DRSWSTU"))
										{
											goto Block_91;
										}
									}
									else
									{
										if (!(@string == "GASD"))
										{
											goto IL_13EA;
										}
										fileInfo.gpsDBSecondFileLength = num;
										fileInfo.gpsDBSecondFileOffset = (int)fileStream.Position;
										fileStream.Position += (long)fileInfo.gpsDBSecondFileLength - 12L;
										array = new byte[12];
										fileStream.Read(array, 0, array.Length);
										array2 = new byte[4];
										Array.Copy(array, 8, array2, 0, 4);
										@string = Encoding.Default.GetString(array2);
										if (@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[0]) || @string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[1]) || @string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[2]))
										{
											fileInfo.gpsDBSecondFileType = FWDloadFormat.GPS_DB_TYPE.GPS_DB_OLD_ENC;
											byte[] buffer;
											if (@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[0]))
											{
												buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.oldUSgpsDBKey, array, 0, 4);
												fileInfo.gpsDBSecondFileCountry = FWDloadFormat.GPS_DB_COUNTRY.US;
											}
											else if (@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[1]))
											{
												buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.oldNZgpsDBKey, array, 0, 4);
												fileInfo.gpsDBSecondFileCountry = FWDloadFormat.GPS_DB_COUNTRY.NZ;
											}
											else
											{
												if (!@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[2]))
												{
													goto IL_9E1;
												}
												buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.oldILgpsDBKey, array, 0, 4);
												fileInfo.gpsDBSecondFileCountry = FWDloadFormat.GPS_DB_COUNTRY.IL;
											}
											fileInfo.gpsDBExistOldEncFile = true;
											fileInfo.gpsDBSecondFilePOI = ReadRDVersionInfo.ReverseLSBtoMSB(buffer, 0, 4);
											fileInfo.gpsDBSecondFileVersion = ReadRDVersionInfo.ReverseLSBtoMSB(array, 4, 4);
										}
										else
										{
											if (!@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[0]) && !@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[1]) && !@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[2]) && !@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[3]))
											{
												goto IL_AEC;
											}
											fileInfo.gpsDBSecondFileType = FWDloadFormat.GPS_DB_TYPE.GPS_DB_AES128;
											if (@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[0]))
											{
												fileInfo.gpsDBSecondFileCountry = FWDloadFormat.GPS_DB_COUNTRY.US;
											}
											else if (@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[1]))
											{
												fileInfo.gpsDBSecondFileCountry = FWDloadFormat.GPS_DB_COUNTRY.NZ;
											}
											else if (@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[2]))
											{
												fileInfo.gpsDBSecondFileCountry = FWDloadFormat.GPS_DB_COUNTRY.IL;
											}
											else
											{
												if (!@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[3]))
												{
													goto IL_ABF;
												}
												fileInfo.gpsDBSecondFileCountry = FWDloadFormat.GPS_DB_COUNTRY.EU;
											}
											fileInfo.gpsDBExistAES128File = true;
											fileInfo.gpsDBSecondFilePOI = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 4);
											fileInfo.gpsDBSecondFileVersion = ReadRDVersionInfo.ReverseLSBtoMSB(array, 4, 4);
										}
										fileStream.Position += 2L;
										array = new byte[7];
										fileStream.Read(array, 0, array.Length);
										array2 = new byte[7];
										Array.Copy(array, 0, array2, 0, 7);
										if (!Encoding.Default.GetString(array2).Equals("DRSWGAE"))
										{
											goto Block_85;
										}
										if (fileInfo.gpsDBFileCountry != FWDloadFormat.GPS_DB_COUNTRY.NONE && fileInfo.gpsDBFileCountry != fileInfo.gpsDBSecondFileCountry)
										{
											goto Block_87;
										}
									}
								}
								else if (num2 != 1077338233U)
								{
									if (num2 != 1452201659U)
									{
										goto IL_13EA;
									}
									if (!(@string == "BLES"))
									{
										goto IL_13EA;
									}
									fileInfo.bleFileLength = num;
									fileInfo.bleFileLength = (fileInfo.bleFileLength / 1024 + 1) * 1024;
									fileInfo.bleFileOffset = (int)fileStream.Position;
									fileStream.Position += (long)fileInfo.bleFileLength;
									array = new byte[9];
									fileStream.Read(array, 0, array.Length);
									fileInfo.bleFileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
									array2 = new byte[7];
									Array.Copy(array, 2, array2, 0, 7);
									if (!Encoding.Default.GetString(array2).Equals("DRSWBLE"))
									{
										goto Block_88;
									}
								}
								else
								{
									if (!(@string == "N3GP"))
									{
										goto IL_13EA;
									}
									fileInfo.gpsNu3FileLength = num;
									fileInfo.gpsNu3FileLength = (fileInfo.gpsNu3FileLength / 512 + 1) * 512;
									fileInfo.gpsNu3FileOffset = (int)fileStream.Position;
									fileStream.Position += (long)fileInfo.gpsNu3FileLength;
									array = new byte[9];
									fileStream.Read(array, 0, array.Length);
									fileInfo.gpsNu3FileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
									array2 = new byte[7];
									Array.Copy(array, 2, array2, 0, 7);
									if (!Encoding.Default.GetString(array2).Equals("DRSWN3G"))
									{
										goto Block_100;
									}
								}
							}
							else if (num2 <= 1973399173U)
							{
								if (num2 != 1730727591U)
								{
									if (num2 != 1973399173U)
									{
										goto IL_13EA;
									}
									if (!(@string == "GPSD"))
									{
										goto IL_13EA;
									}
									fileInfo.gpsDBFileLength = num;
									fileInfo.gpsDBFileOffset = (int)fileStream.Position;
									fileStream.Position += (long)fileInfo.gpsDBFileLength - 12L;
									array = new byte[12];
									fileStream.Read(array, 0, array.Length);
									array2 = new byte[4];
									Array.Copy(array, 8, array2, 0, 4);
									@string = Encoding.Default.GetString(array2);
									if (@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[0]) || @string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[1]) || @string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[2]))
									{
										fileInfo.gpsDBFileType = FWDloadFormat.GPS_DB_TYPE.GPS_DB_OLD_ENC;
										byte[] buffer;
										if (@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[0]))
										{
											buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.oldUSgpsDBKey, array, 0, 4);
											fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.US;
										}
										else if (@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[1]))
										{
											buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.oldNZgpsDBKey, array, 0, 4);
											fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.NZ;
										}
										else
										{
											if (!@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[2]))
											{
												goto IL_754;
											}
											buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.oldILgpsDBKey, array, 0, 4);
											fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.IL;
										}
										fileInfo.gpsDBExistOldEncFile = true;
										fileInfo.gpsDBFilePOI = ReadRDVersionInfo.ReverseLSBtoMSB(buffer, 0, 4);
										fileInfo.gpsDBFileVersion = ReadRDVersionInfo.ReverseLSBtoMSB(array, 4, 4);
									}
									else
									{
										if (!@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[0]) && !@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[1]) && !@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[2]) && !@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[3]))
										{
											goto IL_85F;
										}
										fileInfo.gpsDBFileType = FWDloadFormat.GPS_DB_TYPE.GPS_DB_AES128;
										if (@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[0]))
										{
											fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.US;
										}
										else if (@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[1]))
										{
											fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.NZ;
										}
										else if (@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[2]))
										{
											fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.IL;
										}
										else
										{
											if (!@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[3]))
											{
												goto IL_832;
											}
											fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.IL;
										}
										fileInfo.gpsDBExistAES128File = true;
										fileInfo.gpsDBFilePOI = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 4);
										fileInfo.gpsDBFileVersion = ReadRDVersionInfo.ReverseLSBtoMSB(array, 4, 4);
									}
									array = new byte[7];
									fileStream.Read(array, 0, array.Length);
									array2 = new byte[7];
									Array.Copy(array, 0, array2, 0, 7);
									if (!Encoding.Default.GetString(array2).Equals("DRSWGDB"))
									{
										goto Block_70;
									}
									if (fileInfo.gpsDBSecondFileCountry != FWDloadFormat.GPS_DB_COUNTRY.NONE && fileInfo.gpsDBFileCountry != fileInfo.gpsDBSecondFileCountry)
									{
										goto Block_72;
									}
								}
								else
								{
									if (!(@string == "LSRS"))
									{
										goto IL_13EA;
									}
									fileInfo.laserIFFileLength = num;
									fileInfo.laserIFFileLength = (fileInfo.laserIFFileLength / 512 + 1) * 512;
									fileInfo.laserIFFileOffset = (int)fileStream.Position;
									fileStream.Position += (long)fileInfo.laserIFFileLength;
									array = new byte[9];
									fileStream.Read(array, 0, array.Length);
									fileInfo.laserIFFileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
									array2 = new byte[7];
									Array.Copy(array, 2, array2, 0, 7);
									if (!Encoding.Default.GetString(array2).Equals("DRSWLSR"))
									{
										goto Block_90;
									}
								}
							}
							else if (num2 != 2135671810U)
							{
								if (num2 != 2235141039U)
								{
									goto IL_13EA;
								}
								if (!(@string == "N3DS"))
								{
									goto IL_13EA;
								}
								fileInfo.dspNu3FileLength = num;
								fileInfo.dspNu3FileLength = (fileInfo.dspNu3FileLength / 512 + 1) * 512;
								fileInfo.dspNu3FileOffset = (int)fileStream.Position;
								fileStream.Position += (long)fileInfo.dspNu3FileLength;
								array = new byte[9];
								fileStream.Read(array, 0, array.Length);
								fileInfo.dspNu3FileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
								array2 = new byte[7];
								Array.Copy(array, 2, array2, 0, 7);
								if (!Encoding.Default.GetString(array2).Equals("DRSWN3D"))
								{
									goto Block_98;
								}
							}
							else
							{
								if (!(@string == "SUSD"))
								{
									goto IL_13EA;
								}
								fileInfo.soundDBLa2FileLength = num;
								fileInfo.soundDBLa2FileOffset = (int)fileStream.Position;
								fileStream.Position += (long)fileInfo.soundDBLa2FileLength - 12L;
								array = new byte[12];
								fileStream.Read(array, 0, array.Length);
								byte[] buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.soundDBKey, array, 0, 4);
								fileInfo.soundDBLa2FileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(buffer, 0, 4));
								fileStream.Position += 2L;
								array = new byte[7];
								fileStream.Read(array, 0, array.Length);
								array2 = new byte[7];
								Array.Copy(array, 0, array2, 0, 7);
								if (!Encoding.Default.GetString(array2).Equals("DRSWSUS"))
								{
									goto Block_95;
								}
							}
						}
						else if (num2 <= 3633417373U)
						{
							if (num2 <= 3031394565U)
							{
								if (num2 != 2724587085U)
								{
									if (num2 != 3031394565U)
									{
										goto IL_13EA;
									}
									if (!(@string == "STSD"))
									{
										goto IL_13EA;
									}
									fileInfo.soundDBLa1FileLength = num;
									fileInfo.soundDBLa1FileOffset = (int)fileStream.Position;
									fileStream.Position += (long)fileInfo.soundDBLa1FileLength - 12L;
									array = new byte[12];
									fileStream.Read(array, 0, array.Length);
									byte[] buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.soundDBKey, array, 0, 4);
									fileInfo.soundDBLa1FileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(buffer, 0, 4));
									array = new byte[7];
									fileStream.Read(array, 0, array.Length);
									array2 = new byte[7];
									Array.Copy(array, 0, array2, 0, 7);
									if (!Encoding.Default.GetString(array2).Equals("DRSWSTS"))
									{
										goto Block_94;
									}
								}
								else
								{
									if (!(@string == "KEYS"))
									{
										goto IL_13EA;
									}
									fileInfo.keypadFileLength = num;
									fileInfo.keypadFileLength = (fileInfo.keypadFileLength / 512 + 1) * 512;
									fileInfo.keypadFileOffset = (int)fileStream.Position;
									fileStream.Position += (long)fileInfo.keypadFileLength;
									array = new byte[9];
									fileStream.Read(array, 0, array.Length);
									fileInfo.keypadFileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
									array2 = new byte[7];
									Array.Copy(array, 2, array2, 0, 7);
									if (!Encoding.Default.GetString(array2).Equals("DRSWKEY"))
									{
										goto Block_89;
									}
								}
							}
							else if (num2 != 3161004733U)
							{
								if (num2 != 3633417373U)
								{
									goto IL_13EA;
								}
								if (!(@string == "STGP"))
								{
									goto IL_13EA;
								}
								fileInfo.gpsSTMFileLength = num;
								fileInfo.gpsSTMFileLength = (fileInfo.gpsSTMFileLength / 512 + 1) * 512;
								fileInfo.gpsSTMFileOffset = (int)fileStream.Position;
								fileStream.Position += (long)fileInfo.gpsSTMFileLength;
								array = new byte[9];
								fileStream.Read(array, 0, array.Length);
								fileInfo.gpsSTMFileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
								array2 = new byte[7];
								Array.Copy(array, 2, array2, 0, 7);
								if (!Encoding.Default.GetString(array2).Equals("DRSWSTG"))
								{
									goto Block_93;
								}
							}
							else
							{
								if (!(@string == "NMGF"))
								{
									goto IL_13EA;
								}
								goto IL_13B5;
							}
						}
						else if (num2 <= 4063498012U)
						{
							if (num2 != 3892911703U)
							{
								if (num2 != 4063498012U)
								{
									goto IL_13EA;
								}
								if (!(@string == "N2DS"))
								{
									goto IL_13EA;
								}
								fileInfo.dspNu2FileLength = num;
								fileInfo.dspNu2FileLength = (fileInfo.dspNu2FileLength / 512 + 1) * 512;
								fileInfo.dspNu2FileOffset = (int)fileStream.Position;
								fileStream.Position += (long)fileInfo.dspNu2FileLength;
								array = new byte[9];
								fileStream.Read(array, 0, array.Length);
								fileInfo.dspNu2FileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
								array2 = new byte[7];
								Array.Copy(array, 2, array2, 0, 7);
								if (!Encoding.Default.GetString(array2).Equals("DRSWN2D"))
								{
									goto Block_97;
								}
							}
							else
							{
								if (!(@string == "N2UI"))
								{
									goto IL_13EA;
								}
								fileInfo.uiNu2FileLength = num;
								fileInfo.uiNu2FileLength = (fileInfo.uiNu2FileLength / 512 + 1) * 512;
								fileInfo.uiNu2FileOffset = (int)fileStream.Position;
								fileStream.Position += (long)fileInfo.uiNu2FileLength;
								array = new byte[9];
								fileStream.Read(array, 0, array.Length);
								fileInfo.uiNu2FileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
								array2 = new byte[7];
								Array.Copy(array, 2, array2, 0, 7);
								if (!Encoding.Default.GetString(array2).Equals("DRSWN2U"))
								{
									goto Block_96;
								}
							}
						}
						else if (num2 != 4214643678U)
						{
							if (num2 != 4254336371U)
							{
								goto IL_13EA;
							}
							if (!(@string == "STDS"))
							{
								goto IL_13EA;
							}
							fileInfo.dspSTMFileLength = num;
							fileInfo.dspSTMFileLength = (fileInfo.dspSTMFileLength / 512 + 1) * 512;
							fileInfo.dspSTMFileOffset = (int)fileStream.Position;
							fileStream.Position += (long)fileInfo.dspSTMFileLength;
							array = new byte[9];
							fileStream.Read(array, 0, array.Length);
							fileInfo.dspSTMFileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
							array2 = new byte[7];
							Array.Copy(array, 2, array2, 0, 7);
							if (!Encoding.Default.GetString(array2).Equals("DRSWSTD"))
							{
								goto Block_92;
							}
						}
						else
						{
							if (!(@string == "N2GP"))
							{
								goto IL_13EA;
							}
							fileInfo.gpsNu2FileLength = num;
							fileInfo.gpsNu2FileLength = (fileInfo.gpsNu2FileLength / 512 + 1) * 512;
							fileInfo.gpsNu2FileOffset = (int)fileStream.Position;
							fileStream.Position += (long)fileInfo.gpsNu2FileLength;
							array = new byte[9];
							fileStream.Read(array, 0, array.Length);
							fileInfo.gpsNu2FileVersion = ReadRDVersionInfo.getVersion(ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 2));
							array2 = new byte[7];
							Array.Copy(array, 2, array2, 0, 7);
							if (!Encoding.Default.GetString(array2).Equals("DRSWN2G"))
							{
								goto Block_99;
							}
						}
						IL_1437:
						if (fileStream.Position == fileStream.Length)
						{
							goto Block_103;
						}
						continue;
						IL_13EA:
						if (@string.Substring(2, 2).Equals("SD"))
						{
							fileStream.Position += (long)(num + 9);
							goto IL_1437;
						}
						fileStream.Position += (long)((num / 512 + 1) * 512 + 9);
						goto IL_1437;
					}
					return false;
					IL_754:
					return false;
					IL_832:
					return false;
					IL_85F:
					return false;
					Block_70:
					return false;
					Block_72:
					return false;
					IL_9E1:
					return false;
					IL_ABF:
					return false;
					IL_AEC:
					return false;
					Block_85:
					return false;
					Block_87:
					return false;
					Block_88:
					return false;
					Block_89:
					return false;
					Block_90:
					return false;
					Block_91:
					return false;
					Block_92:
					return false;
					Block_93:
					return false;
					Block_94:
					return false;
					Block_95:
					return false;
					Block_96:
					return false;
					Block_97:
					return false;
					Block_98:
					return false;
					Block_99:
					return false;
					Block_100:
					return false;
					IL_13B5:
					if (fileStream.Position == fileStream.Length)
					{
						fileInfo.isNewMergeFile = true;
						fileInfo.fileFormatVer = ReadRDVersionInfo.ReverseLSBtoMSB(array, 8, 4);
						return true;
					}
					return false;
					Block_103:
					fileInfo.isNewMergeFile = false;
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			finally
			{
				if (fileInfo.modelName == ModelName.UNKNOWN && fileInfo.uiNuFileLength == 0 && fileInfo.dspNuFileLength == 0 && fileInfo.gpsNuFileLength == 0 && fileInfo.soundDBNuFileLength == 0 && fileInfo.soundDBLa1FileLength == 0 && fileInfo.soundDBLa2FileLength == 0 && fileInfo.bleFileLength == 0 && fileInfo.keypadFileLength == 0 && fileInfo.laserIFFileLength == 0 && (fileInfo.gpsDBFileLength > 0 || fileInfo.gpsDBSecondFileLength > 0))
				{
					switch (fileInfo.gpsDBFileCountry)
					{
					case FWDloadFormat.GPS_DB_COUNTRY.US:
						fileInfo.modelName = ModelName.DB_US;
						break;
					case FWDloadFormat.GPS_DB_COUNTRY.NZ:
						fileInfo.modelName = ModelName.DB_NZ;
						break;
					case FWDloadFormat.GPS_DB_COUNTRY.IL:
						fileInfo.modelName = ModelName.DB_IL;
						break;
					case FWDloadFormat.GPS_DB_COUNTRY.EU:
						fileInfo.modelName = ModelName.DB_EU;
						break;
					}
					switch (fileInfo.gpsDBFileCountry)
					{
					case FWDloadFormat.GPS_DB_COUNTRY.US:
						fileInfo.modelName = ModelName.DB_US;
						break;
					case FWDloadFormat.GPS_DB_COUNTRY.NZ:
						fileInfo.modelName = ModelName.DB_NZ;
						break;
					case FWDloadFormat.GPS_DB_COUNTRY.IL:
						fileInfo.modelName = ModelName.DB_IL;
						break;
					case FWDloadFormat.GPS_DB_COUNTRY.EU:
						fileInfo.modelName = ModelName.DB_EU;
						break;
					}
				}
				if (fileStream != null)
				{
					fileStream.Close();
				}
			}
			return result;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00012E74 File Offset: 0x00011074
		public static bool ReadOldGPSDBFileInfo(FWFileInfo fileInfo)
		{
			FileStream fileStream = null;
			fileInfo.DataClear();
			bool result;
			try
			{
				fileStream = new FileStream(fileInfo.filePath, FileMode.Open, FileAccess.Read);
				fileStream.Position = fileStream.Length - 12L;
				byte[] array = new byte[12];
				fileStream.Read(array, 0, array.Length);
				byte[] array2 = new byte[4];
				Array.Copy(array, 8, array2, 0, 4);
				string @string = Encoding.Default.GetString(array2);
				if (@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[0]) || @string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[1]) || @string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[2]))
				{
					fileInfo.gpsDBFileType = FWDloadFormat.GPS_DB_TYPE.GPS_DB_OLD_ENC;
					byte[] buffer;
					if (@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[0]))
					{
						buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.oldUSgpsDBKey, array, 0, 4);
						fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.US;
					}
					else if (@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[1]))
					{
						buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.oldNZgpsDBKey, array, 0, 4);
						fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.NZ;
					}
					else
					{
						if (!@string.Equals(FWDloadFormat.oldFileGPSDBIdentifyStr[2]))
						{
							return false;
						}
						buffer = FWDloadFormat.OldModelDecoder(FWDloadFormat.oldILgpsDBKey, array, 0, 4);
						fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.IL;
					}
					fileInfo.gpsDBExistOldEncFile = true;
					fileInfo.gpsDBFilePOI = ReadRDVersionInfo.ReverseLSBtoMSB(buffer, 0, 4);
					fileInfo.gpsDBFileVersion = ReadRDVersionInfo.ReverseLSBtoMSB(array, 4, 4);
				}
				else
				{
					if (!@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[0]) && !@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[1]) && !@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[2]) && !@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[3]))
					{
						return false;
					}
					fileInfo.gpsDBFileType = FWDloadFormat.GPS_DB_TYPE.GPS_DB_AES128;
					if (@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[0]))
					{
						fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.US;
					}
					else if (@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[1]))
					{
						fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.NZ;
					}
					else if (@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[2]))
					{
						fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.IL;
					}
					else
					{
						if (!@string.Equals(FWDloadFormat.newFileGPSDBIdentifyStr[3]))
						{
							return false;
						}
						fileInfo.gpsDBFileCountry = FWDloadFormat.GPS_DB_COUNTRY.EU;
					}
					fileInfo.gpsDBExistAES128File = true;
					fileInfo.gpsDBFilePOI = ReadRDVersionInfo.ReverseLSBtoMSB(array, 0, 4);
					fileInfo.gpsDBFileVersion = ReadRDVersionInfo.ReverseLSBtoMSB(array, 4, 4);
				}
				fileInfo.gpsDBFileLength = (int)fileStream.Length;
				fileInfo.gpsDBFileOffset = 0;
				switch (fileInfo.gpsDBFileCountry)
				{
				case FWDloadFormat.GPS_DB_COUNTRY.US:
					fileInfo.modelName = ModelName.DB_US;
					break;
				case FWDloadFormat.GPS_DB_COUNTRY.NZ:
					fileInfo.modelName = ModelName.DB_NZ;
					break;
				case FWDloadFormat.GPS_DB_COUNTRY.IL:
					fileInfo.modelName = ModelName.DB_IL;
					break;
				case FWDloadFormat.GPS_DB_COUNTRY.EU:
					fileInfo.modelName = ModelName.DB_EU;
					break;
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
			}
			return result;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001314C File Offset: 0x0001134C
		public static bool ReadFWFileInfo(FWFileInfo fileInfo)
		{
			if (FWFileInfo.ReadNewFWFileInfo(fileInfo))
			{
				return true;
			}
			if (FWFileInfo.ReadOldGPSDBFileInfo(fileInfo))
			{
				return true;
			}
			fileInfo.DataClear();
			return false;
		}

		// Token: 0x04000138 RID: 312
		public string filePath = "";

		// Token: 0x04000139 RID: 313
		public ModelName modelName;

		// Token: 0x0400013A RID: 314
		public bool isNewMergeFile;

		// Token: 0x0400013B RID: 315
		public int fileFormatVer;

		// Token: 0x0400013C RID: 316
		public int uiNuFileLength;

		// Token: 0x0400013D RID: 317
		public int uiNuFileOffset;

		// Token: 0x0400013E RID: 318
		public int uiNuFileVersion;

		// Token: 0x0400013F RID: 319
		public int uiSTMFileLength;

		// Token: 0x04000140 RID: 320
		public int uiSTMFileOffset;

		// Token: 0x04000141 RID: 321
		public int uiSTMFileVersion;

		// Token: 0x04000142 RID: 322
		public int uiNu2FileLength;

		// Token: 0x04000143 RID: 323
		public int uiNu2FileOffset;

		// Token: 0x04000144 RID: 324
		public int uiNu2FileVersion;

		// Token: 0x04000145 RID: 325
		public int dspNuFileLength;

		// Token: 0x04000146 RID: 326
		public int dspNuFileOffset;

		// Token: 0x04000147 RID: 327
		public int dspNuFileVersion;

		// Token: 0x04000148 RID: 328
		public int dspSTMFileLength;

		// Token: 0x04000149 RID: 329
		public int dspSTMFileOffset;

		// Token: 0x0400014A RID: 330
		public int dspSTMFileVersion;

		// Token: 0x0400014B RID: 331
		public int dspNu2FileLength;

		// Token: 0x0400014C RID: 332
		public int dspNu2FileOffset;

		// Token: 0x0400014D RID: 333
		public int dspNu2FileVersion;

		// Token: 0x0400014E RID: 334
		public int dspNu3FileLength;

		// Token: 0x0400014F RID: 335
		public int dspNu3FileOffset;

		// Token: 0x04000150 RID: 336
		public int dspNu3FileVersion;

		// Token: 0x04000151 RID: 337
		public int gpsNuFileLength;

		// Token: 0x04000152 RID: 338
		public int gpsNuFileOffset;

		// Token: 0x04000153 RID: 339
		public int gpsNuFileVersion;

		// Token: 0x04000154 RID: 340
		public int gpsSTMFileLength;

		// Token: 0x04000155 RID: 341
		public int gpsSTMFileOffset;

		// Token: 0x04000156 RID: 342
		public int gpsSTMFileVersion;

		// Token: 0x04000157 RID: 343
		public int gpsNu2FileLength;

		// Token: 0x04000158 RID: 344
		public int gpsNu2FileOffset;

		// Token: 0x04000159 RID: 345
		public int gpsNu2FileVersion;

		// Token: 0x0400015A RID: 346
		public int gpsNu3FileLength;

		// Token: 0x0400015B RID: 347
		public int gpsNu3FileOffset;

		// Token: 0x0400015C RID: 348
		public int gpsNu3FileVersion;

		// Token: 0x0400015D RID: 349
		public int soundDBNuFileLength;

		// Token: 0x0400015E RID: 350
		public int soundDBNuFileOffset;

		// Token: 0x0400015F RID: 351
		public int soundDBNuFileVersion;

		// Token: 0x04000160 RID: 352
		public int soundDBLa1FileLength;

		// Token: 0x04000161 RID: 353
		public int soundDBLa1FileOffset;

		// Token: 0x04000162 RID: 354
		public int soundDBLa1FileVersion;

		// Token: 0x04000163 RID: 355
		public int soundDBLa2FileLength;

		// Token: 0x04000164 RID: 356
		public int soundDBLa2FileOffset;

		// Token: 0x04000165 RID: 357
		public int soundDBLa2FileVersion;

		// Token: 0x04000166 RID: 358
		public int gpsDBFileLength;

		// Token: 0x04000167 RID: 359
		public int gpsDBFileOffset;

		// Token: 0x04000168 RID: 360
		public int gpsDBFileVersion;

		// Token: 0x04000169 RID: 361
		public int gpsDBFilePOI;

		// Token: 0x0400016A RID: 362
		public FWDloadFormat.GPS_DB_TYPE gpsDBFileType;

		// Token: 0x0400016B RID: 363
		public FWDloadFormat.GPS_DB_COUNTRY gpsDBFileCountry;

		// Token: 0x0400016C RID: 364
		public int gpsDBSecondFileLength;

		// Token: 0x0400016D RID: 365
		public int gpsDBSecondFileOffset;

		// Token: 0x0400016E RID: 366
		public int gpsDBSecondFileVersion;

		// Token: 0x0400016F RID: 367
		public int gpsDBSecondFilePOI;

		// Token: 0x04000170 RID: 368
		public FWDloadFormat.GPS_DB_TYPE gpsDBSecondFileType;

		// Token: 0x04000171 RID: 369
		public FWDloadFormat.GPS_DB_COUNTRY gpsDBSecondFileCountry;

		// Token: 0x04000172 RID: 370
		public bool gpsDBExistOldEncFile;

		// Token: 0x04000173 RID: 371
		public bool gpsDBExistAES128File;

		// Token: 0x04000174 RID: 372
		public int bleFileLength;

		// Token: 0x04000175 RID: 373
		public int bleFileOffset;

		// Token: 0x04000176 RID: 374
		public int bleFileVersion;

		// Token: 0x04000177 RID: 375
		public int keypadFileLength;

		// Token: 0x04000178 RID: 376
		public int keypadFileOffset;

		// Token: 0x04000179 RID: 377
		public int keypadFileVersion;

		// Token: 0x0400017A RID: 378
		public int laserIFFileLength;

		// Token: 0x0400017B RID: 379
		public int laserIFFileOffset;

		// Token: 0x0400017C RID: 380
		public int laserIFFileVersion;

		// Token: 0x0400017D RID: 381
		public bool uiDownloadFlag;

		// Token: 0x0400017E RID: 382
		public bool dspDownloadFlag;

		// Token: 0x0400017F RID: 383
		public bool gpsDownloadFlag;

		// Token: 0x04000180 RID: 384
		public bool soundDBDownloadFlag;

		// Token: 0x04000181 RID: 385
		public bool gpsDBDownloadFlag;

		// Token: 0x04000182 RID: 386
		public bool bleDownloadFlag;

		// Token: 0x04000183 RID: 387
		public bool keypadDownloadFlag;

		// Token: 0x04000184 RID: 388
		public bool laserIFDownloadFlag;

		// Token: 0x04000185 RID: 389
		public int totalDownloadCnt;

		// Token: 0x04000186 RID: 390
		public int totalSendCnt;

		// Token: 0x04000187 RID: 391
		public bool recoveryModeFlag;
	}
}
