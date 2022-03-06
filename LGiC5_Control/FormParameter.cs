﻿using ClosedXML.Report;
using DriveControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGiC5_Control
{
    public partial class FormParameter : Form
    {
        object locker;
        public enum ParameterArea { GroupDRV, GroupF, GroupH, GroupI};
        ParameterArea selectedArea;
        LGdrive currentDrive;
        DataGridView dgv;
        private bool firstCall;

        public FormParameter(object locker)
        {
            InitializeComponent();
            this.locker = locker;
            firstCall = true;
            menuInit();
            ParamsDisplayBox.ButtonAcceptClick += new EventHandler(this.DisplaySettingsAcceptClick);
            ParamsDisplayBox.Selections = new bool[] {false, false,false,false,false,false, false};
        }

        public bool NeedRefresh { get; set; }
        public ParameterArea SelectedArea { get => selectedArea; set => selectedArea = value; }
        public LGdrive CurrentDrive { get => currentDrive; set => currentDrive = value; }

        private void DisplaySettingsAcceptClick(object sender, EventArgs e)
        {
            if (currentDrive == null || dgv.DataSource == null) return;
            //if(dgv == null) dgv = paramsMenu.GetDGV();
            dgv.Columns["Address"].Visible = ParamsDisplayBox.Selections[6];
            dgv.Columns["FactoryDefault"].Visible = ParamsDisplayBox.Selections[5];
            dgv.Columns["DefaultVal"].Visible = ParamsDisplayBox.Selections[4];
            dgv.Columns["Unit"].Visible = ParamsDisplayBox.Selections[3];
            dgv.Columns["Max"].Visible = ParamsDisplayBox.Selections[2];
            dgv.Columns["Min"].Visible = ParamsDisplayBox.Selections[1];
            dgv.Columns["ChangeableDuringWork"].Visible = ParamsDisplayBox.Selections[0];
        }

        internal async void ParameterFormIsSelected()
        {
            if (currentDrive == null) return;
            //readParams(CurrentDrive.Memory.GroupedAllParamsToDataExchange(8));
            await Task.Run(() =>
            {
                DriveLibMaster.GetMaster().ReadData(CurrentDrive.Memory.AllParams);
            });
            RefreshValue();
        }

        private void menuInit()
        {
            paramsMenu.ActionButtons[0].Text = "Refresh";
            paramsMenu.ActionButtons[0].Click += new System.EventHandler(this.btn_1_Click);
            paramsMenu.ActionButtons[1].Text = "Set selected";
            paramsMenu.ActionButtons[1].Click += new System.EventHandler(this.btn_2_Click);
            paramsMenu.ActionButtons[2].Text = "Display settings";
            paramsMenu.ActionButtons[2].Click += new System.EventHandler(this.btn_3_Click);
            paramsMenu.ActionButtons[3].Text = "Cyclic read";
            paramsMenu.ActionButtons[4].Text = "Generate raport";
            paramsMenu.ActionButtons[4].Click += new System.EventHandler(this.btn_5_Click);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (currentDrive == null) return;
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dgv.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                if (c.Name == "Set" || c.Name == "Setter") continue;
                if(c.Visible == true) c.Selected = true;
            }

            DataObject data = dgv.GetClipboardContent();
            if(data != null) Clipboard.SetDataObject(data);
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            object misedData = System.Reflection.Missing.Value;
            xlWorkbook = xlApp.Workbooks.Add(misedData);

            xlWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.Worksheets.Item[1];
            xlWorksheet.Cells.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[1, 1];
            
            xlr.Select();
            xlWorksheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        private async void btn_2_Click(object sender, EventArgs e)
        {
            if (currentDrive == null || dgv.DataSource == null) return;
            List<Register> dataToSend = new List<Register>();
            List<Register> dataToRead = new List<Register>();
            string s;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells["Setter"].Value == null) continue;
                if ((bool)(dgv.Rows[i].Cells["Setter"].Value) == true
                    && (string)dgv.Rows[i].Cells["Set"].Value != null)
                {
                    s = dgv.Rows[i].Cells["Set"].Value.ToString();
                    ushort result;
                    if (ushort.TryParse(s, out result))
                    {
                        Register reg = dgv.Rows[i].DataBoundItem as Register;
                        dataToRead.Add(reg);
                        dataToSend.Add(new Register((ushort)dgv.Rows[i].Cells["Address"].Value) { Value = result});
                        dgv.Rows[i].Cells["Set"].Value = null;
                        dgv.Rows[i].Cells["Setter"].Value = false;
                    }
                }
            }
            if (dataToSend.Count > 0) await Task.Run(() =>
            {
                DriveLibMaster.GetMaster().SendData(dataToSend);
                DriveLibMaster.GetMaster().ReadData(dataToRead);
            });
            RefreshValue();
            /*if (currentDrive == null || dgv.DataSource == null) return;
            dataToSend = new Dictionary<ushort, ushort>();
            string s;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells["Setter"].Value == null) continue;
                if ((bool)(dgv.Rows[i].Cells["Setter"].Value) == true
                    && (string)dgv.Rows[i].Cells["Set"].Value != null)
                {
                    s = dgv.Rows[i].Cells["Set"].Value.ToString();
                    ushort result;
                    if (ushort.TryParse(s, out result))
                    {
                        dataToSend.Add((ushort)dgv.Rows[i].Cells["Address"].Value, result);
                        dgv.Rows[i].Cells["Set"].Value = null;
                        dgv.Rows[i].Cells["Setter"].Value = false;
                    }
                }
            }
            if (dataToSend.Count > 0) writeParams(dataToSend, true);*/
        }

        internal void OnDriveConnect(LGdrive drive)
        {
            currentDrive = drive;
            dgv = paramsMenu.GetDGV();
        }

        internal void OnDriveDisconnect()
        {
            currentDrive = null;
            firstCall = true;
            paramsMenu.DataSource(null, null, null, null);
            dgv.Columns.Clear();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            ParameterFormIsSelected();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (currentDrive == null) return;
            ParamsDisplayBox.ShowDisplaySettings(this);
        }

        internal void SetDataSource()
        {
            paramsMenu.DataSource(CurrentDrive.Memory.GroupDRV, CurrentDrive.Memory.GroupF
                                  , CurrentDrive.Memory.GroupH, CurrentDrive.Memory.GroupI);
        }

        internal void RefreshValue()
        {
            paramsMenu.RefreshValue();
        }

        private void paramsMenu_ContentSwitched(object sender, EventArgs e)
        {
            if (currentDrive == null) return;
            if (firstCall)
            {
                addSetterFields();
                setColumnsProperties();
                firstCall = false;
            }
            DisplaySettingsAcceptClick(this, EventArgs.Empty);
            dgv.Columns["AvailableIn"].Visible = false;
            dgv.Columns["ReadOnly"].Visible = false;
        }

        private void addSetterFields()
        {
            DataGridViewTextBoxColumn txtBoxColSetValue = new DataGridViewTextBoxColumn();
            txtBoxColSetValue.ReadOnly = false;
            txtBoxColSetValue.HeaderText = "Set";
            txtBoxColSetValue.Name = "Set";
            txtBoxColSetValue.Width = 50;
            DataGridViewCheckBoxColumn checkBoxColSet = new DataGridViewCheckBoxColumn();
            checkBoxColSet.ReadOnly = false;
            checkBoxColSet.HeaderText = "";
            checkBoxColSet.Name = "Setter";
            checkBoxColSet.Width = 25;
            checkBoxColSet.ValueType = typeof(Boolean);
            dgv.Columns.Add(txtBoxColSetValue);
            dgv.Columns.Add(checkBoxColSet);
        }

        private void setColumnsProperties()
        {
            dgv.Columns["Address"].ReadOnly = true;
            dgv.Columns["Address"].Width = 60;
            dgv.Columns["Code"].ReadOnly = true;
            dgv.Columns["Code"].Width = 45;
            dgv.Columns["Name"].ReadOnly = true;
            dgv.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Name"].ReadOnly = true;
            dgv.Columns["Value"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Value"].ReadOnly = true;
            dgv.Columns["FactoryDefault"].ReadOnly = true;
            dgv.Columns["FactoryDefault"].Width = 80;
            dgv.Columns["DefaultVal"].ReadOnly = true;
            dgv.Columns["DefaultVal"].Width = 80;
            dgv.Columns["Unit"].ReadOnly = true;
            dgv.Columns["Unit"].Width = 50;
            dgv.Columns["Max"].ReadOnly = true;
            dgv.Columns["Max"].Width = 50;
            dgv.Columns["Min"].ReadOnly = true;
            dgv.Columns["Min"].Width = 50;
            dgv.Columns["ChangeableDuringWork"].ReadOnly = true;
            dgv.Columns["ChangeableDuringWork"].Width = 55;

            dgv.Columns["Set"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //private async void writeParams(Dictionary<ushort, ushort> data, bool refreshData)
        //{
        //    await Task.Run(() =>
        //    {
        //        lock (locker)
        //        {
        //            FormSetup.Port.Open();
        //            foreach (var d in data)
        //            {
        //                FormSetup.Master.WriteSingleRegister((byte)FormSetup.SlaveAddr, (ushort)(d.Key - 1), d.Value);
        //            }
        //            FormSetup.Port.Close();
        //        }
        //    });
        //    if (refreshData) readParams(CurrentDrive.Memory.GroupedAllParamsToDataExchange(8));
        //}
        //private async void readParams(List<List<Register>> regList)
        //{
        //    await Task.Run(() =>
        //    {
        //        lock (locker)
        //        {
        //            FormSetup.Port.Open();
        //            foreach (var list in regList)
        //            {
        //                ushort[] tempArray = new ushort[list.Count];
        //                ushort startFrom = (ushort)(list.First().Address - 1);
        //                ushort length = (ushort)list.Count;
        //                FormSetup.Master.ReadHoldingRegisters((byte)FormSetup.SlaveAddr, startFrom, length).CopyTo(tempArray, 0);
        //                for (int i = 0; i < list.Count; i++)
        //                {
        //                    list[i].Value = tempArray[i];
        //                }
        //            }
        //            FormSetup.Port.Close();
        //        }
        //    });
        //    RefreshValue();
        //}

    }
}