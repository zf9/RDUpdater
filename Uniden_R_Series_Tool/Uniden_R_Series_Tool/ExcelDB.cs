using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;

namespace Uniden_R_Series_Tool
{
	// Token: 0x0200001C RID: 28
	public class ExcelDB
	{
		// Token: 0x06000169 RID: 361 RVA: 0x0001918C File Offset: 0x0001738C
		public static int ExcelFileType(string XlsFile)
		{
			byte[,] array = new byte[,]
			{
				{
					208,
					207,
					17,
					224,
					161
				},
				{
					80,
					75,
					3,
					4,
					20
				}
			};
			int num = -1;
			FileStream fileStream = new FileInfo(XlsFile).Open(FileMode.Open);
			try
			{
				byte[] array2 = new byte[5];
				fileStream.Read(array2, 0, 5);
				for (int i = 0; i < 2; i++)
				{
					int num2 = 0;
					while (num2 < 5 && array2[num2] == array[i, num2])
					{
						if (num2 == 4)
						{
							num = i;
						}
						num2++;
					}
					if (num >= 0)
					{
						break;
					}
				}
			}
			catch
			{
				num = -2;
			}
			finally
			{
				fileStream.Close();
			}
			return num;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00019234 File Offset: 0x00017434
		private static DataSet OpenExcel(string FileName, bool UseHeader)
		{
			DataSet dataSet = null;
			string[] array = new string[]
			{
				"NO",
				"YES"
			};
			string connectionString = "";
			string arg;
			if (UseHeader)
			{
				arg = array[1];
			}
			else
			{
				arg = array[0];
			}
			switch (ExcelDB.ExcelFileType(FileName))
			{
			case -2:
				throw new Exception(FileName + "의 형식검사중 오류가 발생하였습니다.");
			case -1:
				throw new Exception(FileName + "은 엑셀 파일형식이 아닙니다.");
			case 0:
				connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Mode=ReadWrite|Share Deny None;Extended Properties='Excel 8.0; HDR={1}; IMEX={2}';Persist Security Info=False", FileName, arg, "1");
				break;
			case 1:
				connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Mode=ReadWrite|Share Deny None;Extended Properties='Excel 12.0; HDR={1}; IMEX={2}';Persist Security Info=False", FileName, arg, "1");
				break;
			}
			OleDbConnection oleDbConnection = null;
			try
			{
				oleDbConnection = new OleDbConnection(connectionString);
				oleDbConnection.Open();
				DataTable oleDbSchemaTable = oleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[]
				{
					null,
					null,
					null,
					"TABLE"
				});
				dataSet = new DataSet();
				foreach (object obj in oleDbSchemaTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(dataRow["TABLE_NAME"].ToString(), oleDbConnection);
					oleDbDataAdapter.SelectCommand.CommandType = CommandType.TableDirect;
					oleDbDataAdapter.AcceptChangesDuringFill = false;
					string srcTable = dataRow["TABLE_NAME"].ToString().Replace("$", string.Empty).Replace("'", string.Empty);
					if (dataRow["TABLE_NAME"].ToString().Contains("$"))
					{
						oleDbDataAdapter.Fill(dataSet, srcTable);
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (oleDbConnection != null)
				{
					oleDbConnection.Close();
				}
			}
			return dataSet;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00019414 File Offset: 0x00017614
		private static bool SaveExcel(string FileName, DataSet DS, bool ExistDel, bool OldExcel)
		{
			bool result = true;
			if (File.Exists(FileName))
			{
				if (!ExistDel)
				{
					return result;
				}
				File.Delete(FileName);
			}
			string text = FileName;
			OleDbConnection oleDbConnection = null;
			try
			{
				string connectionString;
				if (OldExcel)
				{
					text += ".xls";
					connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Mode=ReadWrite|Share Deny None;Extended Properties='Excel 8.0; HDR={1}; IMEX={2}';Persist Security Info=False", text, "YES", "0");
				}
				else
				{
					text += ".xlsx";
					connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Mode=ReadWrite|Share Deny None;Extended Properties='Excel 12.0; HDR={1}; IMEX={2}';Persist Security Info=False", text, "YES", "0");
				}
				oleDbConnection = new OleDbConnection(connectionString);
				oleDbConnection.Open();
				foreach (object obj in DS.Tables)
				{
					DataTable dataTable = (DataTable)obj;
					string tableName = dataTable.TableName;
					StringBuilder stringBuilder = new StringBuilder();
					StringBuilder stringBuilder2 = new StringBuilder();
					foreach (object obj2 in dataTable.Columns)
					{
						DataColumn dataColumn = (DataColumn)obj2;
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append(",");
							stringBuilder2.Append(",");
						}
						stringBuilder.Append("[" + dataColumn.ColumnName.Replace("'", "''") + "] CHAR(255)");
						stringBuilder2.Append(dataColumn.ColumnName.Replace("'", "''"));
					}
					new OleDbCommand(string.Concat(new string[]
					{
						"CREATE TABLE ",
						tableName,
						"(",
						stringBuilder.ToString(),
						")"
					}), oleDbConnection).ExecuteNonQuery();
					foreach (object obj3 in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj3;
						StringBuilder stringBuilder3 = new StringBuilder();
						foreach (object obj4 in dataTable.Columns)
						{
							DataColumn dataColumn2 = (DataColumn)obj4;
							if (stringBuilder3.Length > 0)
							{
								stringBuilder3.Append(",");
							}
							stringBuilder3.Append("'" + dataRow[dataColumn2.ColumnName].ToString().Replace("'", "''") + "'");
						}
						new OleDbCommand(string.Concat(new string[]
						{
							"INSERT INTO [",
							tableName,
							"$](",
							stringBuilder2.ToString(),
							") VALUES (",
							stringBuilder3.ToString(),
							")"
						}), oleDbConnection).ExecuteNonQuery();
					}
				}
			}
			catch (Exception)
			{
				result = false;
			}
			finally
			{
				if (oleDbConnection != null)
				{
					oleDbConnection.Close();
				}
				try
				{
					if (File.Exists(text))
					{
						File.Move(text, FileName);
					}
				}
				catch
				{
				}
			}
			return result;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000197DC File Offset: 0x000179DC
		public static DataSet OpenExcelDB(string ExcelFile)
		{
			return ExcelDB.OpenExcel(ExcelFile, true);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000197E5 File Offset: 0x000179E5
		public static bool SaveExcelDB(string ExcelFile, DataSet DS)
		{
			return ExcelDB.SaveExcel(ExcelFile, DS, true, false);
		}

		// Token: 0x0400020A RID: 522
		private const string ConnectStrFrm_Excel97_2003 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Mode=ReadWrite|Share Deny None;Extended Properties='Excel 8.0; HDR={1}; IMEX={2}';Persist Security Info=False";

		// Token: 0x0400020B RID: 523
		private const string ConnectStrFrm_Excel = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Mode=ReadWrite|Share Deny None;Extended Properties='Excel 12.0; HDR={1}; IMEX={2}';Persist Security Info=False";
	}
}
