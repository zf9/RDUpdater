using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CustomControls;

namespace Uniden_R_Series_Tool
{
	// Token: 0x02000029 RID: 41
	public class UserSettingController
	{
		// Token: 0x060001AE RID: 430 RVA: 0x000204F8 File Offset: 0x0001E6F8
		public UserSettingController(RDInfo modelInfo, DataGridView settingGridView, CustomScrollbar dataGridScrollBar, Label menuNameLabel, Label menuDecriptionLabel, Panel hwRevisionPanel, Label hwRevisionLabel, bool darkMode)
		{
			this.setting = new UserSettingConfig(modelInfo);
			this.modelInfo = modelInfo;
			this.menuCnt = this.setting.menuCnt;
			this.settingGridView = settingGridView;
			this.dataGridScrollBar = dataGridScrollBar;
			this.menuNameLabel = menuNameLabel;
			this.menuDescriptionLabel = menuDecriptionLabel;
			this.hwRevisionPanel = hwRevisionPanel;
			this.hwRevisionLabel = hwRevisionLabel;
			this.loadItemString = new string[this.menuCnt];
			this.loadItemValue = new int[this.menuCnt];
			this.isDarkMode = darkMode;
			if (this.isDarkMode)
			{
				settingGridView.GridColor = Color.FromArgb(120, 120, 120);
				settingGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
			}
			settingGridView.Scroll += this.SettingGridView_Scroll;
			settingGridView.MouseWheel += this.SettingGridView_MouseWheel;
			dataGridScrollBar.Scroll += this.ScrollBar_Scroll;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000205E8 File Offset: 0x0001E7E8
		private void SettingGridView_Scroll(object sender, ScrollEventArgs e)
		{
			int num = 0;
			for (int i = 0; i < this.setting.menuCnt; i++)
			{
				if (this.setting.menu[i].menuType == this.currentMenu)
				{
					if (i == this.settingGridView.FirstDisplayedScrollingRowIndex)
					{
						break;
					}
					num++;
				}
			}
			this.dataGridScrollBar.Value = num * 24;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00020648 File Offset: 0x0001E848
		private void SettingGridView_MouseWheel(object sender, MouseEventArgs e)
		{
			this.settingGridView.Scroll -= this.SettingGridView_Scroll;
			if (e.Delta < 0)
			{
				if (this.dataGridScrollBar.Value / 24 + 17 + Math.Abs(e.Delta) / 120 <= this.dataGridScrollBar.Maximum / 24)
				{
					this.dataGridScrollBar.Value += Math.Abs(e.Delta) / 120 * 24;
				}
			}
			else if (this.dataGridScrollBar.Value - Math.Abs(e.Delta) / 120 * 24 >= this.dataGridScrollBar.Minimum)
			{
				this.dataGridScrollBar.Value -= Math.Abs(e.Delta) / 120 * 24;
			}
			this.ScrollBar_Scroll(null, null);
			this.settingGridView.Scroll += this.SettingGridView_Scroll;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00020738 File Offset: 0x0001E938
		private void ScrollBar_Scroll(object sender, EventArgs e)
		{
			int num = 0;
			int num2 = this.dataGridScrollBar.Value / 24;
			this.dataGridScrollBar.Value = num2 * 24;
			for (int i = 0; i < this.setting.menuCnt; i++)
			{
				if (this.setting.menu[i].menuType == this.currentMenu && num++ == num2)
				{
					this.settingGridView.FirstDisplayedScrollingRowIndex = i;
					break;
				}
			}
			this.dataGridScrollBar.Invalidate();
			Application.DoEvents();
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000207BC File Offset: 0x0001E9BC
		private void ShowMenu(UserSettingMenu.MENU_TYPE type)
		{
			int num = -1;
			int num2 = 0;
			this.settingGridView.Scroll -= this.SettingGridView_Scroll;
			for (int i = 0; i < this.menuCnt; i++)
			{
				if (this.setting.menu[i].menuType == type)
				{
					if (num == -1)
					{
						num = i;
					}
					this.settingGridView.Rows[i].Visible = true;
					this.settingGridView.Rows[i].Cells[0].Value = num2 + 1;
					if (num2 % 2 == 1)
					{
						if (this.isDarkMode)
						{
							this.settingGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
						}
						else
						{
							this.settingGridView.Rows[i].DefaultCellStyle.BackColor = SystemColors.Control;
						}
					}
					else if (this.isDarkMode)
					{
						this.settingGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
					}
					num2++;
				}
				else
				{
					this.settingGridView.Rows[i].Visible = false;
				}
			}
			if (num2 <= 17)
			{
				this.dataGridScrollBar.Visible = false;
				this.settingGridView.Columns[2].Width = 197;
			}
			else
			{
				this.dataGridScrollBar.Minimum = 0;
				this.dataGridScrollBar.Maximum = num2 * 24;
				this.dataGridScrollBar.LargeChange = this.dataGridScrollBar.Maximum - (num2 - 17) * 24;
				this.dataGridScrollBar.SmallChange = 24;
				this.dataGridScrollBar.Value = Math.Abs(this.settingGridView.AutoScrollOffset.Y);
				this.dataGridScrollBar.Visible = true;
				this.settingGridView.Columns[2].Width = 180;
			}
			this.settingGridView.ClearSelection();
			if (num >= 0)
			{
				this.settingGridView.Rows[num].Cells[1].Selected = true;
			}
			this.SettingGridView_SelectionChanged(null, null);
			this.currentMenu = type;
			this.dataGridScrollBar.Value = 0;
			this.settingGridView.Scroll += this.SettingGridView_Scroll;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00020A20 File Offset: 0x0001EC20
		public void ShowUserPreMenu()
		{
			this.ShowMenu(UserSettingMenu.MENU_TYPE.USER_PREFERENCE);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00020A29 File Offset: 0x0001EC29
		public void ShowBandSettingMenu()
		{
			this.ShowMenu(UserSettingMenu.MENU_TYPE.BAND_SETTING);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00020A32 File Offset: 0x0001EC32
		public void ShowGPSMenu()
		{
			this.ShowMenu(UserSettingMenu.MENU_TYPE.GPS);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00020A3B File Offset: 0x0001EC3B
		public void ShowVoiceMenu()
		{
			this.ShowMenu(UserSettingMenu.MENU_TYPE.SOUND);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00020A44 File Offset: 0x0001EC44
		public void ShowDisplayMenu()
		{
			this.ShowMenu(UserSettingMenu.MENU_TYPE.DISPLAY);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00020A50 File Offset: 0x0001EC50
		public bool SetDataGridViewFromNVData(byte[] nvData, bool readFromRDFlag)
		{
			int[] userSettingFromNVData = this.setting.GetUserSettingFromNVData(nvData);
			int num = this.setting.GetMenuCnt();
			if (this.setting.hwRevisionVersion != -1)
			{
				SafetyControl.SetText(this.hwRevisionLabel, this.setting.hwRevisionVersion.ToString());
				SafetyControl.SetVisible(this.hwRevisionPanel, true);
			}
			else
			{
				SafetyControl.SetText(this.hwRevisionLabel, "");
				SafetyControl.SetVisible(this.hwRevisionPanel, false);
			}
			int i;
			int j;
			int num3;
			for (i = 0; i < num; i = num3 + 1)
			{
				if (this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.NORMAL_ATT || this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT)
				{
					j = 0;
					while (j < this.setting.menu[i].itemValue.Length)
					{
						if (this.setting.menu[i].itemValue[j] == userSettingFromNVData[i])
						{
							if (this.setting.menu[i].isUnitMenuFlag)
							{
								this.currentUnit = this.setting.menu[i].itemString[j];
								this.unitMenuNum = i;
							}
							if (this.setting.menu[i].isDetectionMode)
							{
								this.currentDetection = this.setting.menu[i].itemString[j];
								this.detectionMenuNum = i;
							}
							if (readFromRDFlag)
							{
								this.loadItemString[i] = this.setting.menu[i].itemString[j];
								this.loadItemValue[i] = userSettingFromNVData[i];
							}
							if (this.settingGridView.InvokeRequired)
							{
								this.settingGridView.Invoke(new MethodInvoker(delegate()
								{
									this.settingGridView.Rows[i].Cells[2].Value = this.setting.menu[i].itemString[j];
								}));
								break;
							}
							this.settingGridView.Rows[i].Cells[2].Value = this.setting.menu[i].itemString[j];
							break;
						}
						else
						{
							int l = j;
							int num2 = this.setting.menu[i].itemValue.Length - 1;
							num3 = j;
							j = num3 + 1;
						}
					}
				}
				else if (this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT)
				{
					this.setting.menu[i].rawValue = userSettingFromNVData[i];
					if (readFromRDFlag)
					{
						this.loadItemValue[i] = userSettingFromNVData[i];
					}
				}
				num3 = i;
			}
			int k;
			for (i = 0; i < num; i = num3 + 1)
			{
				if (this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT || this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.UNIT_MATCHING_VALUE_MULTI_ITEM_ATT)
				{
					for (j = 0; j < this.setting.menu[i].multipleSourceString.Length; j = num3 + 1)
					{
						if (this.setting.menu[i].multipleSourceString[j].Equals(this.currentUnit))
						{
							if (this.settingGridView.InvokeRequired)
							{
								this.settingGridView.Invoke(new MethodInvoker(delegate()
								{
									DataGridViewComboBoxCell dataGridViewComboBoxCell2 = new DataGridViewComboBoxCell();
									dataGridViewComboBoxCell2.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
									dataGridViewComboBoxCell2.Items.AddRange(this.setting.menu[i].multipleItemString[j]);
									this.settingGridView.Rows[i].Cells[2] = dataGridViewComboBoxCell2;
								}));
							}
							else
							{
								DataGridViewComboBoxCell dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
								dataGridViewComboBoxCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
								dataGridViewComboBoxCell.Items.AddRange(this.setting.menu[i].multipleItemString[j]);
								this.settingGridView.Rows[i].Cells[2] = dataGridViewComboBoxCell;
							}
							k = 0;
							while (k < this.setting.menu[i].multipleItemValue[j].Length)
							{
								if (this.setting.menu[i].multipleItemValue[j][k] == userSettingFromNVData[i])
								{
									if (readFromRDFlag)
									{
										this.loadItemString[i] = this.setting.menu[i].multipleItemString[j][k];
										this.loadItemValue[i] = userSettingFromNVData[i];
									}
									if (this.settingGridView.InvokeRequired)
									{
										this.settingGridView.Invoke(new MethodInvoker(delegate()
										{
											this.settingGridView.Rows[i].Cells[2].Value = this.setting.menu[i].multipleItemString[j][k];
										}));
										break;
									}
									this.settingGridView.Rows[i].Cells[2].Value = this.setting.menu[i].multipleItemString[j][k];
									break;
								}
								else
								{
									num3 = k;
									k = num3 + 1;
								}
							}
						}
						int j2 = j;
						int num4 = this.setting.menu[i].multipleSourceString.Length - 1;
						num3 = j;
					}
				}
				num3 = i;
			}
			return true;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0002100C File Offset: 0x0001F20C
		public byte[] GetNVDataFromDataGridView()
		{
			int[] array = new int[this.menuCnt];
			string item = null;
			if (this.menuCnt == 0)
			{
				return null;
			}
			int i;
			int i2;
			for (i = 0; i < array.Length; i = i2 + 1)
			{
				if (this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.NORMAL_ATT || this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT)
				{
					if (this.settingGridView.InvokeRequired)
					{
						this.settingGridView.Invoke(new MethodInvoker(delegate()
						{
							item = (string)this.settingGridView.Rows[i].Cells[2].Value;
						}));
					}
					else
					{
						item = (string)this.settingGridView.Rows[i].Cells[2].Value;
					}
					for (int k = 0; k < this.setting.menu[i].itemValue.Length; k++)
					{
						if (this.setting.menu[i].itemString[k].Equals(item))
						{
							array[i] = this.setting.menu[i].itemValue[k];
							break;
						}
						if (k == this.setting.menu[i].itemValue.Length - 1)
						{
							return null;
						}
					}
				}
				else if (this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT)
				{
					array[i] = this.setting.menu[i].rawValue;
				}
				i2 = i;
			}
			for (i = 0; i < array.Length; i = i2 + 1)
			{
				if (this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT || this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.UNIT_MATCHING_VALUE_MULTI_ITEM_ATT)
				{
					if (this.settingGridView.InvokeRequired)
					{
						this.settingGridView.Invoke(new MethodInvoker(delegate()
						{
							item = (string)this.settingGridView.Rows[i].Cells[2].Value;
						}));
					}
					else
					{
						item = (string)this.settingGridView.Rows[i].Cells[2].Value;
					}
					for (int k = 0; k < this.setting.menu[i].multipleSourceString.Length; k++)
					{
						if (this.setting.menu[i].multipleSourceString[k].Equals(this.currentUnit))
						{
							for (int j = 0; j < this.setting.menu[i].multipleItemString[k].Length; j++)
							{
								if (this.setting.menu[i].multipleItemString[k][j].Equals(item))
								{
									array[i] = this.setting.menu[i].multipleItemValue[k][j];
									break;
								}
								if (j == this.setting.menu[i].multipleItemString[k].Length - 1)
								{
									return null;
								}
							}
							break;
						}
						if (k == this.setting.menu[i].multipleSourceString.Length - 1)
						{
							return null;
						}
					}
				}
				i2 = i;
			}
			return this.setting.GetNVDataFromUserSetting(array);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000213A0 File Offset: 0x0001F5A0
		public bool ReadUserSetting(UARTCommUtils uart, RDInfo modelInfo)
		{
			bool flag = this.isDraw;
			Font font = this.settingGridView.DefaultCellStyle.Font;
			byte[] userSetting = ReadRDVersionInfo.GetUserSetting(uart, modelInfo);
			if (userSetting == null)
			{
				return false;
			}
			if (!flag)
			{
				this.DrawSettingData();
				this.settingGridView.CellValueChanged -= this.ComboBox_SelectedIndexChanged;
			}
			int i;
			int j;
			for (i = 0; i < this.menuCnt; i = j + 1)
			{
				if (this.settingGridView.InvokeRequired)
				{
					this.settingGridView.Invoke(new MethodInvoker(delegate()
					{
						this.settingGridView.Rows[i].Cells[2].Style.Font = new Font(font.FontFamily, 9f, FontStyle.Regular);
					}));
				}
				else
				{
					this.settingGridView.Rows[i].Cells[2].Style.Font = new Font(font.FontFamily, 9f, FontStyle.Regular);
				}
				j = i;
			}
			this.setting.receivedNVData = userSetting;
			if (!this.SetDataGridViewFromNVData(userSetting, true))
			{
				return false;
			}
			if (!flag)
			{
				this.settingGridView.CellValueChanged += this.ComboBox_SelectedIndexChanged;
			}
			return true;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000214CC File Offset: 0x0001F6CC
		public bool WriteUserSetting(UARTCommUtils uart, RDInfo modelInfo)
		{
			byte[] nvdataFromDataGridView = this.GetNVDataFromDataGridView();
			return nvdataFromDataGridView != null && ReadRDVersionInfo.SetUserSetting(uart, modelInfo, nvdataFromDataGridView);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000214F4 File Offset: 0x0001F6F4
		private void DrawSettingData()
		{
			int firstPos = -1;
			if (this.setting == null)
			{
				return;
			}
			int i;
			int userPreCnt;
			this.settingGridView.Invoke(new MethodInvoker(delegate()
			{
				this.settingGridView.RowHeadersVisible = false;
				this.settingGridView.ColumnCount = 3;
				this.settingGridView.Columns[0].Name = "";
				this.settingGridView.Columns[0].Width = 40;
				this.settingGridView.Columns[0].Resizable = DataGridViewTriState.False;
				this.settingGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				this.settingGridView.Columns[0].ReadOnly = true;
				this.settingGridView.Columns[1].Name = "Item";
				this.settingGridView.Columns[1].Width = 340;
				this.settingGridView.Columns[1].Resizable = DataGridViewTriState.False;
				this.settingGridView.Columns[1].ReadOnly = true;
				this.settingGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				this.settingGridView.Columns[2].Name = "Value";
				this.settingGridView.Columns[2].Width = 180;
				this.settingGridView.Columns[2].Resizable = DataGridViewTriState.False;
				this.settingGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				if (this.isDarkMode)
				{
					this.settingGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
					this.settingGridView.RowsDefaultCellStyle.ForeColor = SystemColors.ButtonFace;
				}
				else
				{
					this.settingGridView.RowsDefaultCellStyle.ForeColor = Color.Black;
				}
				this.settingGridView.RowCount = this.menuCnt;
				i = 0;
				userPreCnt = 0;
				while (i < this.menuCnt)
				{
					if (firstPos == -1)
					{
						firstPos = i;
					}
					int num;
					if (this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.NORMAL_ATT || this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT || this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.RAW_VALUE_ATT)
					{
						DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
						dataGridViewTextBoxCell.Value = this.setting.menu[i].menuString;
						DataGridViewComboBoxCell dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
						dataGridViewComboBoxCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
						dataGridViewComboBoxCell.Items.AddRange(this.setting.menu[i].itemString);
						if (this.setting.menu[i].menuType == UserSettingMenu.MENU_TYPE.USER_PREFERENCE)
						{
							this.settingGridView.Rows[i].Cells[0].Value = userPreCnt + 1;
							if (userPreCnt % 2 != 0)
							{
								if (this.isDarkMode)
								{
									this.settingGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
								}
								else
								{
									this.settingGridView.Rows[i].DefaultCellStyle.BackColor = SystemColors.Control;
								}
							}
							else if (this.isDarkMode)
							{
								this.settingGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
							}
							num = userPreCnt;
							userPreCnt = num + 1;
						}
						else
						{
							this.settingGridView.Rows[i].Visible = false;
						}
						this.settingGridView.Rows[i].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
						this.settingGridView.Rows[i].Cells[1] = dataGridViewTextBoxCell;
						this.settingGridView.Rows[i].Cells[2] = dataGridViewComboBoxCell;
						this.settingGridView.Rows[i].Resizable = DataGridViewTriState.False;
					}
					else if (this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT || this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.UNIT_MATCHING_VALUE_MULTI_ITEM_ATT)
					{
						DataGridViewTextBoxCell dataGridViewTextBoxCell2 = new DataGridViewTextBoxCell();
						dataGridViewTextBoxCell2.Value = this.setting.menu[i].menuString;
						DataGridViewComboBoxCell dataGridViewComboBoxCell2 = new DataGridViewComboBoxCell();
						dataGridViewComboBoxCell2.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
						dataGridViewComboBoxCell2.Items.AddRange(this.setting.menu[i].multipleItemString[0]);
						if (this.setting.menu[i].menuType == UserSettingMenu.MENU_TYPE.USER_PREFERENCE)
						{
							this.settingGridView.Rows[i].Cells[0].Value = userPreCnt + 1;
							if (userPreCnt % 2 != 0)
							{
								if (this.isDarkMode)
								{
									this.settingGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
								}
								else
								{
									this.settingGridView.Rows[i].DefaultCellStyle.BackColor = SystemColors.Control;
								}
							}
							else if (this.isDarkMode)
							{
								this.settingGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
							}
							num = userPreCnt;
							userPreCnt = num + 1;
						}
						else
						{
							this.settingGridView.Rows[i].Visible = false;
						}
						this.settingGridView.Rows[i].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
						this.settingGridView.Rows[i].Cells[1] = dataGridViewTextBoxCell2;
						this.settingGridView.Rows[i].Cells[2] = dataGridViewComboBoxCell2;
						this.settingGridView.Rows[i].Resizable = DataGridViewTriState.False;
					}
					num = i;
					i = num + 1;
				}
				if (userPreCnt <= 17)
				{
					this.dataGridScrollBar.Visible = false;
					this.settingGridView.Columns[2].Width = 197;
				}
				else
				{
					this.dataGridScrollBar.Minimum = 0;
					this.dataGridScrollBar.Maximum = userPreCnt * 24;
					this.dataGridScrollBar.LargeChange = this.dataGridScrollBar.Maximum - (userPreCnt - 17) * 24;
					this.dataGridScrollBar.SmallChange = 24;
					this.dataGridScrollBar.Value = Math.Abs(this.settingGridView.AutoScrollOffset.Y);
					this.dataGridScrollBar.Visible = true;
					this.settingGridView.Columns[2].Width = 180;
				}
				this.settingGridView.ClearSelection();
				if (firstPos >= 0)
				{
					this.settingGridView.Rows[firstPos].Cells[1].Selected = true;
				}
				this.SettingGridView_SelectionChanged(null, null);
				this.settingGridView.SelectionChanged += this.SettingGridView_SelectionChanged;
				this.settingGridView.CellClick += this.DataGrid_CellCick;
				this.currentMenu = UserSettingMenu.MENU_TYPE.USER_PREFERENCE;
			}));
			this.isDraw = true;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00021540 File Offset: 0x0001F740
		private void SettingGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (this.settingGridView.CurrentRow == null)
			{
				return;
			}
			this.menuNameLabel.Text = this.setting.menu[this.settingGridView.CurrentRow.Index].menuString;
			this.menuDescriptionLabel.Text = this.setting.menu[this.settingGridView.CurrentRow.Index].menuDecription;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000215B4 File Offset: 0x0001F7B4
		private void DataGrid_CellCick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = sender as DataGridView;
			if (this.setting.menuCnt < e.RowIndex || e.RowIndex < 0)
			{
				return;
			}
			if (e.ColumnIndex == 2 && e.RowIndex >= 0)
			{
				dataGridView.BeginEdit(true);
				((ComboBox)dataGridView.EditingControl).DroppedDown = true;
				((ComboBox)dataGridView.EditingControl).DropDownClosed -= this.ComboBox_DropDownClosed;
				((ComboBox)dataGridView.EditingControl).DropDownClosed += this.ComboBox_DropDownClosed;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00021648 File Offset: 0x0001F848
		private void ComboBox_DropDownClosed(object sender, EventArgs e)
		{
			SendKeys.Send("{LEFT}");
			SendKeys.Send("{RIGHT}");
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00021660 File Offset: 0x0001F860
		private void ComboBox_SelectedIndexChanged(object sender, DataGridViewCellEventArgs e)
		{
			Font font = this.settingGridView.RowsDefaultCellStyle.Font;
			if (e.ColumnIndex != 2)
			{
				return;
			}
			if (e.RowIndex == this.unitMenuNum)
			{
				int num = 65535;
				string text = (string)this.settingGridView.Rows[e.RowIndex].Cells[2].Value;
				for (int i = 0; i < this.menuCnt; i++)
				{
					if (this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.UNIT_MATCHING_VALUE_MULTI_ITEM_ATT || this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT)
					{
						for (int j = 0; j < this.setting.menu[i].multipleSourceString.Length; j++)
						{
							if (this.setting.menu[i].multipleSourceString[j].Equals(this.currentUnit))
							{
								for (int k = 0; k < this.setting.menu[i].multipleItemString[j].Length; k++)
								{
									if (this.settingGridView.Rows[i].Cells[2].Value != null && this.settingGridView.Rows[i].Cells[2].Value.Equals(this.setting.menu[i].multipleItemString[j][k]))
									{
										if (this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.UNIT_RAW_VALUE_MULTI_ITEM_ATT)
										{
											if (this.currentUnit.Equals("mph") && text.Equals("km/h"))
											{
												num = this.ConvertMphToKmph(this.setting.menu[i].multipleItemValue[j][k]);
											}
											else if (this.currentUnit.Equals("km/h") && text.Equals("mph"))
											{
												num = this.ConvertKmphToMph(this.setting.menu[i].multipleItemValue[j][k]);
											}
										}
										else
										{
											for (int l = 0; l < this.setting.menu[i].multipleSourceString.Length; l++)
											{
												if (this.setting.menu[i].multipleSourceString[l].Equals(text))
												{
													num = this.setting.menu[i].multipleItemValue[l][k];
												}
											}
										}
									}
								}
							}
						}
						for (int j = 0; j < this.setting.menu[i].multipleSourceString.Length; j++)
						{
							if (this.setting.menu[i].multipleSourceString[j].Equals(text))
							{
								DataGridViewComboBoxCell dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
								dataGridViewComboBoxCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
								dataGridViewComboBoxCell.Items.AddRange(this.setting.menu[i].multipleItemString[j]);
								this.settingGridView.Rows[i].Cells[2] = dataGridViewComboBoxCell;
								this.settingGridView.Rows[i].Resizable = DataGridViewTriState.False;
								for (int k = 0; k < this.setting.menu[i].multipleItemValue[j].Length; k++)
								{
									if (num != 65535 && this.setting.menu[i].multipleItemValue[j][k] == num)
									{
										this.settingGridView.Rows[i].Cells[2].Value = this.setting.menu[i].multipleItemString[j][k];
									}
								}
							}
						}
					}
				}
				this.currentUnit = text;
			}
			if (e.RowIndex == this.detectionMenuNum)
			{
				string value = (string)this.settingGridView.Rows[e.RowIndex].Cells[2].Value;
				int num2 = -1;
				int num3 = -1;
				this.settingGridView.CellValueChanged -= this.ComboBox_SelectedIndexChanged;
				for (int i = 0; i < this.setting.menu[e.RowIndex].itemString.Length; i++)
				{
					if (this.setting.menu[e.RowIndex].itemString[i].Equals(value))
					{
						num3 = this.setting.menu[e.RowIndex].itemValue[i];
					}
					if (this.setting.menu[e.RowIndex].itemString[i].Equals(this.currentDetection))
					{
						num2 = this.setting.menu[e.RowIndex].itemValue[i];
					}
				}
				for (int i = 0; i < this.menuCnt; i++)
				{
					if (this.setting.menu[i].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT)
					{
						int num4 = -1;
						int num5 = -1;
						int num6 = -1;
						bool flag = false;
						for (int j = 0; j < this.setting.menu[i].itemString.Length; j++)
						{
							if (this.settingGridView.Rows[i].Cells[2].Value.Equals(this.setting.menu[i].itemString[j]))
							{
								num4 = this.setting.menu[i].itemValue[j];
							}
						}
						if (num4 != -1 && num3 != -1 && num2 != -1 && this.setting.user_k_block_op_mode_is_level(num4))
						{
							num5 = this.setting.user_k_block_get_level(this.setting.menu[i + 1].rawValue, num3);
							num6 = this.setting.user_k_block_get_level(this.loadItemValue[i + 1], num3);
							flag = true;
						}
						if (flag && num5 != -1)
						{
							for (int j = 0; j < this.setting.menu[i].itemValue.Length; j++)
							{
								if (this.setting.menu[i].itemValue[j] == num5)
								{
									this.settingGridView.Rows[i].Cells[2].Value = this.setting.menu[i].itemString[j];
								}
								if (this.setting.menu[i].itemValue[j] == num6)
								{
									this.loadItemString[i] = this.setting.menu[i].itemString[j];
								}
							}
						}
					}
				}
				this.currentDetection = value;
				this.settingGridView.CellValueChanged += this.ComboBox_SelectedIndexChanged;
			}
			if (this.setting.menu[e.RowIndex].menuAtt == UserSettingMenu.MENU_ATTRIBUTE.K_BLOCK_LEVEL_ATT)
			{
				string value2 = string.Empty;
				int level = -1;
				int mode = -1;
				for (int i = 0; i < this.setting.menu.Length; i++)
				{
					if (this.setting.menu[i].isDetectionMode)
					{
						value2 = (string)this.settingGridView.Rows[i].Cells[2].Value;
						for (int j = 0; j < this.setting.menu[i].itemString.Length; j++)
						{
							if (this.setting.menu[i].itemString[j].Equals(value2))
							{
								mode = this.setting.menu[i].itemValue[j];
							}
						}
						break;
					}
				}
				for (int j = 0; j < this.setting.menu[e.RowIndex].itemString.Length; j++)
				{
					if (this.settingGridView.Rows[e.RowIndex].Cells[2].Value.Equals(this.setting.menu[e.RowIndex].itemString[j]))
					{
						level = this.setting.menu[e.RowIndex].itemValue[j];
					}
				}
				if (this.setting.user_k_block_op_mode_is_level(level))
				{
					this.setting.menu[e.RowIndex + 1].rawValue = this.setting.user_k_block_get_raw_strength(level, mode);
				}
			}
			if (this.loadItemString[e.RowIndex] != null && this.loadItemString[e.RowIndex].Equals(this.settingGridView.Rows[e.RowIndex].Cells[2].Value))
			{
				this.settingGridView.Rows[e.RowIndex].Cells[2].Style.Font = new Font(font.FontFamily, 9f, FontStyle.Regular);
				return;
			}
			this.settingGridView.Rows[e.RowIndex].Cells[2].Style.Font = new Font(font.FontFamily, 9.75f, FontStyle.Bold);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00021F42 File Offset: 0x00020142
		public int ConvertKmphToMph(int value)
		{
			return ((int)((float)value * 0.621371f) + 2) / 5 * 5;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00021F53 File Offset: 0x00020153
		public int ConvertMphToKmph(int value)
		{
			return ((int)((float)value * 1.609344f) + 5) / 10 * 10;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00021F68 File Offset: 0x00020168
		public bool SaveUserSettingFile(string filePath)
		{
			ushort num = 0;
			FileStream fileStream = null;
			bool result;
			try
			{
				fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
				byte[] nvdataFromDataGridView = this.GetNVDataFromDataGridView();
				if (nvdataFromDataGridView == null)
				{
					result = false;
				}
				else
				{
					fileStream.Write(Encoding.UTF8.GetBytes("USET"), 0, 4);
					fileStream.Write(BitConverter.GetBytes(12), 0, 4);
					fileStream.Write(BitConverter.GetBytes(nvdataFromDataGridView.Length), 0, 4);
					fileStream.Write(nvdataFromDataGridView, 0, nvdataFromDataGridView.Length);
					// DECOMPILE-FIX: Shift the enum's integer value, matching the original IL settings header.
					num |= (ushort)((int)this.setting.modelInfo.modelName << 10);
					num |= (ushort)this.setting.modelInfo.versionUI;
					fileStream.Write(BitConverter.GetBytes(num), 0, 2);
					fileStream.Write(Encoding.UTF8.GetBytes("USERSET"), 0, 7);
					if (fileStream.Length == (long)(12 + nvdataFromDataGridView.Length + 9))
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
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

		// Token: 0x060001C4 RID: 452 RVA: 0x0002206C File Offset: 0x0002026C
		public UserSettingController.FILE_OPEN_RESULT LoadUserSettingFile(string filePath, RDInfo model)
		{
			FileStream fileStream = null;
			UserSettingController.FILE_OPEN_RESULT result;
			try
			{
				fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
				byte[] array = new byte[12];
				if (fileStream.Read(array, 0, 12) != 12)
				{
					result = UserSettingController.FILE_OPEN_RESULT.UNKNOWN_FILE;
				}
				else if (!Encoding.Default.GetString(array, 0, 4).Equals("USET"))
				{
					result = UserSettingController.FILE_OPEN_RESULT.UNKNOWN_FILE;
				}
				else
				{
					int num = ReadRDVersionInfo.ReverseLSBtoMSB(array, 8, 4);
					byte[] array2 = new byte[num];
					if (fileStream.Read(array2, 0, num) != num)
					{
						result = UserSettingController.FILE_OPEN_RESULT.UNKNOWN_FILE;
					}
					else
					{
						byte[] array3 = new byte[9];
						if (fileStream.Read(array3, 0, 9) != 9)
						{
							result = UserSettingController.FILE_OPEN_RESULT.UNKNOWN_FILE;
						}
						else if (fileStream.Position != fileStream.Length)
						{
							result = UserSettingController.FILE_OPEN_RESULT.UNKNOWN_FILE;
						}
						else
						{
							int data = ReadRDVersionInfo.ReverseLSBtoMSB(array3, 0, 2);
							ModelName modelNumber = ReadRDVersionInfo.getModelNumber(data);
							int version = ReadRDVersionInfo.getVersion(data);
							if (!Encoding.Default.GetString(array3, 2, 7).Equals("USERSET"))
							{
								result = UserSettingController.FILE_OPEN_RESULT.UNKNOWN_FILE;
							}
							else if (this.setting.modelInfo.modelName != modelNumber)
							{
								result = UserSettingController.FILE_OPEN_RESULT.UNKNOWN_FILE;
							}
							else
							{
								byte[] nvdataFromDataGridView = this.GetNVDataFromDataGridView();
								for (int i = 0; i < nvdataFromDataGridView.Length; i++)
								{
									if (i < array2.Length)
									{
										nvdataFromDataGridView[i] = array2[i];
									}
									else
									{
										nvdataFromDataGridView[i] = byte.MaxValue;
									}
								}
								if (!this.SetDataGridViewFromNVData(nvdataFromDataGridView, false))
								{
									result = UserSettingController.FILE_OPEN_RESULT.UNKNOWN_FILE;
								}
								else
								{
									result = (this.setting.CheckCompatibility(version) ? UserSettingController.FILE_OPEN_RESULT.SUCCESS : UserSettingController.FILE_OPEN_RESULT.SUCCESS_SOME_SETTING_ARE_NOT_SET);
								}
							}
						}
					}
				}
			}
			catch
			{
				result = UserSettingController.FILE_OPEN_RESULT.UNKNOWN_FILE;
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

		// Token: 0x04000379 RID: 889
		public UserSettingConfig setting;

		// Token: 0x0400037A RID: 890
		private RDInfo modelInfo;

		// Token: 0x0400037B RID: 891
		private Panel hwRevisionPanel;

		// Token: 0x0400037C RID: 892
		private Label hwRevisionLabel;

		// Token: 0x0400037D RID: 893
		private CustomScrollbar dataGridScrollBar;

		// Token: 0x0400037E RID: 894
		private DataGridView settingGridView;

		// Token: 0x0400037F RID: 895
		private Label menuNameLabel;

		// Token: 0x04000380 RID: 896
		private Label menuDescriptionLabel;

		// Token: 0x04000381 RID: 897
		public bool isDraw;

		// Token: 0x04000382 RID: 898
		public int menuCnt;

		// Token: 0x04000383 RID: 899
		public string[] loadItemString;

		// Token: 0x04000384 RID: 900
		public int[] loadItemValue;

		// Token: 0x04000385 RID: 901
		public int detectionMenuNum;

		// Token: 0x04000386 RID: 902
		public int unitMenuNum;

		// Token: 0x04000387 RID: 903
		public string currentUnit;

		// Token: 0x04000388 RID: 904
		public string currentDetection;

		// Token: 0x04000389 RID: 905
		public UserSettingMenu.MENU_TYPE currentMenu;

		// Token: 0x0400038A RID: 906
		private bool isDarkMode;

		// Token: 0x02000091 RID: 145
		public enum FILE_OPEN_RESULT
		{
			// Token: 0x0400062A RID: 1578
			SUCCESS,
			// Token: 0x0400062B RID: 1579
			SUCCESS_SOME_SETTING_ARE_NOT_SET,
			// Token: 0x0400062C RID: 1580
			UNKNOWN_FILE
		}
	}
}
