using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000012 RID: 18
	public class UARTCommUtils
	{
		// Token: 0x060000D9 RID: 217
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, int dwShareMode, int lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);

		// Token: 0x060000DA RID: 218
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int GetCommState(IntPtr hFile, ref UARTCommUtils.DCB lpDCB);

		// Token: 0x060000DB RID: 219
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int BuildCommDCB(string lpDef, ref UARTCommUtils.DCB lpDCB);

		// Token: 0x060000DC RID: 220
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int SetCommState(IntPtr hFile, ref UARTCommUtils.DCB lpDCB);

		// Token: 0x060000DD RID: 221
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int GetCommTimeouts(IntPtr hFile, ref UARTCommUtils.COMMTIMEOUTS lpCommTimeouts);

		// Token: 0x060000DE RID: 222
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int SetCommTimeouts(IntPtr hFile, ref UARTCommUtils.COMMTIMEOUTS lpCommTimeouts);

		// Token: 0x060000DF RID: 223
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int ReadFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfBytesToRead, ref int lpNumberOfBytesRead, IntPtr lpOverlapped);

		// Token: 0x060000E0 RID: 224
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int WriteFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfBytesToWrite, ref int lpNumberOfBytesWritten, IntPtr lpOverlapped);

		// Token: 0x060000E1 RID: 225
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int CloseHandle(IntPtr hFile);

		// Token: 0x060000E2 RID: 226
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int SetupComm(IntPtr hFile, ulong dwInQueue, ulong dwOutQueue);

		// Token: 0x060000E3 RID: 227
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int PurgeComm(IntPtr hFile, ulong dwFlags);

		// Token: 0x060000E4 RID: 228
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern uint GetLastError();

		// Token: 0x060000E5 RID: 229 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		public bool Init(string PortName, int baudRate)
		{
			UARTCommUtils.DCB structure = default(UARTCommUtils.DCB);
			UARTCommUtils.COMMTIMEOUTS commtimeouts = default(UARTCommUtils.COMMTIMEOUTS);
			this.Close();
			this.hComm = UARTCommUtils.CreateFile("\\\\.\\" + PortName, 3221225472U, 0, 0, 3, 0, 0);
			if (this.hComm == UARTCommUtils.INVALID_HANDLE_VALUE)
			{
				return false;
			}
			structure.DCBlength = (uint)Marshal.SizeOf<UARTCommUtils.DCB>(structure);
			if (UARTCommUtils.GetCommState(this.hComm, ref structure) == 0)
			{
				return false;
			}
			structure.BaudRate = (uint)baudRate;
			structure.ByteSize = 8;
			structure.Parity = 0;
			structure.StopBits = 0;
			if (UARTCommUtils.SetCommState(this.hComm, ref structure) == 0)
			{
				return false;
			}
			this.Close();
			this.hComm = UARTCommUtils.CreateFile("\\\\.\\" + PortName, 3221225472U, 0, 0, 3, 0, 0);
			if (UARTCommUtils.GetCommTimeouts(this.hComm, ref commtimeouts) == 0)
			{
				return false;
			}
			commtimeouts.ReadIntervalTimeout = 50;
			commtimeouts.ReadTotalTimeoutMultiplier = 10;
			commtimeouts.ReadTotalTimeoutConstant = 50;
			commtimeouts.WriteTotalTimeoutMultiplier = 10;
			commtimeouts.WriteTotalTimeoutConstant = 50;
			if (UARTCommUtils.SetCommTimeouts(this.hComm, ref commtimeouts) == 0)
			{
				return false;
			}
			if (UARTCommUtils.SetupComm(this.hComm, 4096UL, 4096UL) == 0)
			{
				return false;
			}
			if (UARTCommUtils.PurgeComm(this.hComm, 15UL) == 0)
			{
				return false;
			}
			this.portName = PortName;
			return true;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000FF04 File Offset: 0x0000E104
		public void Close()
		{
			if (this.hComm != UARTCommUtils.INVALID_HANDLE_VALUE)
			{
				this.StreamClear();
				UARTCommUtils.CloseHandle(this.hComm);
			}
			this.hComm = UARTCommUtils.INVALID_HANDLE_VALUE;
			this.portName = "";
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000FF40 File Offset: 0x0000E140
		public void StreamClear()
		{
			UARTCommUtils.PurgeComm(this.hComm, 10UL);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000FF51 File Offset: 0x0000E151
		public string PortName()
		{
			return this.portName;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000FF5C File Offset: 0x0000E15C
		public byte[] Read(int NumBytes)
		{
			byte[] array = new byte[NumBytes];
			if (!(this.hComm != UARTCommUtils.INVALID_HANDLE_VALUE))
			{
				throw new ApplicationException("Comm Port Not Open");
			}
			int num = 0;
			if (UARTCommUtils.ReadFile(this.hComm, array, NumBytes, ref num, IntPtr.Zero) == 0)
			{
				return null;
			}
			if (num != NumBytes)
			{
				return null;
			}
			byte[] array2 = new byte[num];
			Array.Copy(array, array2, num);
			return array2;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		public bool WriteBytes(byte[] WriteBytes)
		{
			if (this.hComm != UARTCommUtils.INVALID_HANDLE_VALUE)
			{
				int num = 0;
				return UARTCommUtils.WriteFile(this.hComm, WriteBytes, WriteBytes.Length, ref num, IntPtr.Zero) != 0 && num == WriteBytes.Length;
			}
			return false;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00010008 File Offset: 0x0000E208
		public byte[] NByteRead(int byteCnt, int timeOutmsec, bool exceptionThrowFlag)
		{
			byte[] result;
			try
			{
				int tickCount = Environment.TickCount;
				while (Environment.TickCount - tickCount < timeOutmsec)
				{
					byte[] array = this.Read(byteCnt);
					if (array != null)
					{
						return array;
					}
				}
				result = null;
			}
			catch (ApplicationException)
			{
				if (exceptionThrowFlag)
				{
					throw;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00010058 File Offset: 0x0000E258
		public bool CompareRead(byte[] srcBuffer, int timeOutmsec, bool exceptionThrowFlag)
		{
			int num = 0;
			byte[] array = new byte[srcBuffer.Length];
			bool result;
			try
			{
				int tickCount = Environment.TickCount;
				while (Environment.TickCount - tickCount < timeOutmsec)
				{
					byte[] array2 = this.Read(1);
					if (array2 != null)
					{
						array[num] = array2[0];
						if (array[num] != srcBuffer[num])
						{
							num = 0;
						}
						if (array[num] == srcBuffer[num])
						{
							num++;
							if (num == srcBuffer.Length)
							{
								return true;
							}
						}
					}
				}
				result = false;
			}
			catch (ApplicationException)
			{
				if (exceptionThrowFlag)
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000100D8 File Offset: 0x0000E2D8
		public bool CheckConnection()
		{
			if (this.hComm == UARTCommUtils.INVALID_HANDLE_VALUE)
			{
				return false;
			}
			if (!this.CompareRead(FWDloadFormat.downloadCmdBeacon, FWDloadFormat.time1sec, true))
			{
				return false;
			}
			this.StreamClear();
			return true;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0001010C File Offset: 0x0000E30C
		public bool ReceiveBeacon(int tryCnt)
		{
			for (int i = 0; i < tryCnt; i++)
			{
				byte[] array = this.NByteRead(1, FWDloadFormat.time50msec, false);
				if (array != null && array.SequenceEqual(FWDloadFormat.downloadCmdBeacon))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00010148 File Offset: 0x0000E348
		public bool BeaconComm(string serialPortName, int timeoutmsec, bool sendRspFlag)
		{
			Thread.Sleep(FWDloadFormat.time100msec);
			if (!this.Init(serialPortName, 4800))
			{
				return false;
			}
			if (!this.CompareRead(FWDloadFormat.downloadCmdBeacon, timeoutmsec, false))
			{
				return false;
			}
			if (sendRspFlag)
			{
				this.WriteBytes(FWDloadFormat.downloadCmdBeaconRsp);
				this.WriteBytes(FWDloadFormat.downloadCmdBeaconRsp);
				this.WriteBytes(FWDloadFormat.downloadCmdBeaconRsp);
				if (!this.Init(serialPortName, 115200))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400011F RID: 287
		private const uint PURGE_TXABORT = 1U;

		// Token: 0x04000120 RID: 288
		private const uint PURGE_RXABORT = 2U;

		// Token: 0x04000121 RID: 289
		private const uint PURGE_TXCLEAR = 4U;

		// Token: 0x04000122 RID: 290
		private const uint PURGE_RXCLEAR = 8U;

		// Token: 0x04000123 RID: 291
		private const uint GENERIC_READ = 2147483648U;

		// Token: 0x04000124 RID: 292
		private const uint GENERIC_WRITE = 1073741824U;

		// Token: 0x04000125 RID: 293
		private const int OPEN_EXISTING = 3;

		// Token: 0x04000126 RID: 294
		private static IntPtr INVALID_HANDLE_VALUE = (IntPtr)(-1);

		// Token: 0x04000127 RID: 295
		private IntPtr hComm = UARTCommUtils.INVALID_HANDLE_VALUE;

		// Token: 0x04000128 RID: 296
		private string portName;

		// Token: 0x02000044 RID: 68
		public struct DCB
		{
			// Token: 0x04000438 RID: 1080
			public uint DCBlength;

			// Token: 0x04000439 RID: 1081
			public uint BaudRate;

			// Token: 0x0400043A RID: 1082
			public uint uiFlagBits;

			// Token: 0x0400043B RID: 1083
			public ushort wReserved;

			// Token: 0x0400043C RID: 1084
			public ushort XonLim;

			// Token: 0x0400043D RID: 1085
			public ushort XoffLim;

			// Token: 0x0400043E RID: 1086
			public byte ByteSize;

			// Token: 0x0400043F RID: 1087
			public byte Parity;

			// Token: 0x04000440 RID: 1088
			public byte StopBits;

			// Token: 0x04000441 RID: 1089
			public char XonChar;

			// Token: 0x04000442 RID: 1090
			public char XoffChar;

			// Token: 0x04000443 RID: 1091
			public char ErrorChar;

			// Token: 0x04000444 RID: 1092
			public char EofChar;

			// Token: 0x04000445 RID: 1093
			public char EvtChar;

			// Token: 0x04000446 RID: 1094
			public ushort wReserved1;
		}

		// Token: 0x02000045 RID: 69
		private struct COMMTIMEOUTS
		{
			// Token: 0x04000447 RID: 1095
			public int ReadIntervalTimeout;

			// Token: 0x04000448 RID: 1096
			public int ReadTotalTimeoutMultiplier;

			// Token: 0x04000449 RID: 1097
			public int ReadTotalTimeoutConstant;

			// Token: 0x0400044A RID: 1098
			public int WriteTotalTimeoutMultiplier;

			// Token: 0x0400044B RID: 1099
			public int WriteTotalTimeoutConstant;
		}

		// Token: 0x02000046 RID: 70
		private struct OVERLAPPED
		{
			// Token: 0x0400044C RID: 1100
			public int Internal;

			// Token: 0x0400044D RID: 1101
			public int InternalHigh;

			// Token: 0x0400044E RID: 1102
			public int Offset;

			// Token: 0x0400044F RID: 1103
			public int OffsetHigh;

			// Token: 0x04000450 RID: 1104
			public int hEvent;
		}
	}
}
