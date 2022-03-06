using LGiC5_Control.SpecialControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using Modbus.Device;
using System.Windows.Forms;
using DriveControlLibrary;

namespace LGiC5_Control
{
    public partial class FormKeyPad : Form
    {
        object locker = new object();
        static List<Register> readOnlySection;
        static List<Register> readWriteSection;       
        int updateIntervalTime = 1000;
        double[] intervalArray = { 0.5, 1, 1.5, 2, 3, 4, 5 };
        bool isKeypadActive;
        bool isReady = true;
        ushort[] dataCommAreaToSend;
        List<ushort> dataKeypadToSend;      

        public FormKeyPad(object locker)
        {
            InitializeComponent();
            
            this.locker = locker;   

            timer_UpdateSections.Interval = UpdateIntervalTime;
            cb_updateTime.DataSource = intervalArray;
            cb_updateTime.SelectedIndex = 1;
            //Initial switch view
            IsKeypadActive = false;
            DataKeypadToSend =new List<ushort>();
            //Initial knob
            knob_pot.LargeChange = 1000;
            knob_pot.Minimum = 0;
            knob_pot.Maximum = 5000;
            ResetView();
        }

        public ushort[] DataCommAreaToSend { get => dataCommAreaToSend; set => dataCommAreaToSend = value; }
        public List<ushort> DataKeypadToSend { get => dataKeypadToSend; set => dataKeypadToSend = value; }
        public int UpdateIntervalTime
        {
            get => updateIntervalTime;
            set
            {
                updateIntervalTime = value;
                timer_UpdateSections.Interval = value;
            }
        }
        public bool IsKeypadActive
        {
            get => isKeypadActive;
            set
            {
                if (value)
                {
                    isKeypadActive = true;
                    btn_off.BackColor = Color.Red;
                    btn_on.BackColor = Color.DarkGray;
                    btn_off.Enabled = true;
                    btn_on.Enabled = false;
                    btn_setComArea.Visible = false;
                }
                else
                {
                    isKeypadActive = false;
                    btn_off.BackColor = Color.DarkGray;
                    btn_on.BackColor = Color.Lime;
                    btn_on.Enabled = true;
                    btn_off.Enabled = false;
                    btn_setComArea.Visible = true;
                }
            }
        }


        private async void rBtn_stop_Click(object sender, EventArgs e)
        {
            if (!IsKeypadActive || !isReady) return;
            isReady = false;
            ushort addr = 6;
            ushort value = 1;
            await Task.Run(() => 
            {
                DriveLibMaster.GetMaster().SendSingleRegister(addr, value); 
            });
            isReady = true;
            UpdateSections();
            //if (!IsKeypadActive || DataKeypadToSend.Count != 0) return;
            //ushort addr = 6;
            //ushort value = 1;

            //DataKeypadToSend.Add(addr);
            //DataKeypadToSend.Add(value);
            //sendKeypadData();
        }

        private async void knobControl_ValueChanged(object Sender)
        {
            if (!IsKeypadActive || !isReady) return;
            isReady = false;
            ushort addr = 5;
            ushort value = (ushort)knob_pot.Value;

            await Task.Run(() =>
            {
                DriveLibMaster.GetMaster().SendSingleRegister(addr, value);
            });
            isReady = true;
            UpdateSections();
            //if (!IsKeypadActive || DataKeypadToSend.Count != 0) return;

            //ushort addr = 5;
            //ushort value = (ushort)knob_pot.Value;

            //DataKeypadToSend.Add(addr);
            //DataKeypadToSend.Add(value);
            //sendKeypadData();
            //rtb_display.Text =String.Format("{0:D2}.{1:D2}", (value / 100), value % 100);
        }

        private async void rBtn_run_Click(object sender, EventArgs e)
        {
            if (!IsKeypadActive || !isReady) return;
            isReady = false;
            ushort addr = 6;
            ushort value;
            if (cb_reverse.Checked) value = 4;
            else value = 2;
            await Task.Run(() =>
            {
                DriveLibMaster.GetMaster().SendSingleRegister(addr, value);
            });
            isReady = true;
            UpdateSections();
            //if (!IsKeypadActive || DataKeypadToSend.Count != 0) return;
            //ushort addr = 6;
            //ushort value;
            //if(cb_reverse.Checked) value = 4;
            //else value = 2;

            //DataKeypadToSend.Add(addr);
            //DataKeypadToSend.Add(value);
            //sendKeypadData();
        }
            
        internal void UpdateSections()
        {
            dgv_readWriteSection.InvalidateColumn(dgv_readWriteSection.Columns["Value"].Index);
            dgv_readWriteSection.Update();
            dgv_readOnlySection.InvalidateColumn(dgv_readOnlySection.Columns["Value"].Index);
            dgv_readOnlySection.Update();
        }

        internal void buildKeypadParamsView(LGdrive lgDrive)
        {
            readOnlySection = new List<Register>();
            readWriteSection = new List<Register>();

            if (dgv_readWriteSection.ColumnCount != 0 && dgv_readOnlySection.ColumnCount != 0) return;
            foreach (Register reg in lgDrive.Memory.CommonArea)
            {
                if (reg.ReadOnly) readOnlySection.Add(reg);
                else readWriteSection.Add(reg);
            }
            btn_setComArea.Visible = true;
            btn_off.Visible = true;
            btn_on.Visible = true;
            buildReadOnlySection();
            buildReadWriteSection();
        }

        private void buildReadWriteSection()
        {
            dgv_readWriteSection.DataSource = readWriteSection;
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
            dgv_readWriteSection.Columns.Add(txtBoxColSetValue);
            dgv_readWriteSection.Columns.Add(checkBoxColSet);

            dgv_readWriteSection.Columns["Address"].Width = 45;
            dgv_readWriteSection.Columns["Address"].HeaderText = "Addr.";
            dgv_readWriteSection.Columns["Address"].ReadOnly = true;
            dgv_readWriteSection.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_readWriteSection.Columns["Name"].HeaderText = "Parameter";
            dgv_readWriteSection.Columns["Name"].ReadOnly = true;
            dgv_readWriteSection.Columns["Value"].Width = 50;
            dgv_readWriteSection.Columns["Value"].ReadOnly = true;

            dgv_readWriteSection.Columns["Code"].Visible = false;
            dgv_readWriteSection.Columns["FactoryDefault"].Visible = false;
            dgv_readWriteSection.Columns["DefaultVal"].Visible = false;
            dgv_readWriteSection.Columns["Unit"].Visible = false;
            dgv_readWriteSection.Columns["ReadOnly"].Visible = false;
            dgv_readWriteSection.Columns["Min"].Visible = false;
            dgv_readWriteSection.Columns["Max"].Visible = false;
            dgv_readWriteSection.Columns["ChangeableDuringWork"].Visible = false;
            dgv_readWriteSection.Columns["AvailableIn"].Visible = false;

            for (int i = 0; i < dgv_readWriteSection.RowCount; i++)
            {
                dgv_readWriteSection.Rows[i].Cells["Setter"].Value = true;
            }

            dgv_readWriteSection.CurrentCell = null;
        }

        private void buildReadOnlySection()
        {
            dgv_readOnlySection.DataSource = readOnlySection;
            dgv_readOnlySection.Columns["Code"].Visible = false;
            dgv_readOnlySection.Columns["FactoryDefault"].Visible = false;
            dgv_readOnlySection.Columns["DefaultVal"].Visible = false;
            dgv_readOnlySection.Columns["Unit"].Visible = false;
            dgv_readOnlySection.Columns["ReadOnly"].Visible = false;
            dgv_readOnlySection.Columns["Min"].Visible = false;
            dgv_readOnlySection.Columns["Max"].Visible = false;
            dgv_readOnlySection.Columns["ChangeableDuringWork"].Visible = false;
            dgv_readOnlySection.Columns["AvailableIn"].Visible = false;
            dgv_readOnlySection.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_readOnlySection.Columns["Address"].Width = 45;
            dgv_readOnlySection.Columns["Address"].HeaderText = "Addr.";
            dgv_readOnlySection.Columns["Address"].ReadOnly = true;
            dgv_readOnlySection.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_readOnlySection.Columns["Name"].HeaderText = "Parameter";
            dgv_readOnlySection.Columns["Name"].ReadOnly = true;
            dgv_readOnlySection.Columns["Value"].Width = 50;
            dgv_readOnlySection.Columns["Value"].ReadOnly = true;

            dgv_readOnlySection.CurrentCell = null;
        }

        private async void btn_setComArea_Click(object sender, EventArgs e)
        {
            List<Register> regList = new List<Register>();
            foreach (DataGridViewRow row in dgv_readWriteSection.Rows)
            {
                Register reg = new Register(ushort.Parse(row.Cells["Address"].Value.ToString()));
                if ((bool)(row.Cells["Setter"].Value) == true
                    && (string)row.Cells["Set"].Value != null)
                {
                    reg.Value = ushort.Parse(row.Cells["Set"].Value.ToString());
                    row.Cells["Set"].Value = null;
                    row.Cells["Setter"].Value = false;
                }
                else
                {
                    reg.Value = ushort.Parse(row.Cells["Value"].Value.ToString());
                }
                regList.Add(reg);
            }

            await Task.Run(() =>
            {
                DriveLibMaster.GetMaster().SendData(regList);
                DriveLibMaster.GetMaster().ReadCommonArea();
            });
            UpdateSections();
            //dataCommAreaToSend =new ushort[5];
            //string s;
            //for (int i = 0; i < 5; i++)
            //{
            //    if ((bool)(dgv_readWriteSection.Rows[i].Cells["Setter"].Value) == true
            //        && (string)dgv_readWriteSection.Rows[i].Cells["Set"].Value != null)        
            //    {
            //            s = dgv_readWriteSection.Rows[i].Cells["Set"].Value.ToString();
            //            dataCommAreaToSend[i] = ushort.Parse(s);
            //            dgv_readWriteSection.Rows[i].Cells["Set"].Value = null;
            //            dgv_readWriteSection.Rows[i].Cells["Setter"].Value = false;
            //    }
            //    else
            //    {
            //        s = dgv_readWriteSection.Rows[i].Cells["Value"].Value.ToString();
            //        dataCommAreaToSend[i] = ushort.Parse(s);
            //    }
            //}
            //sendCommAreaData();
        }

        private void timerUpdateSections_Tick(object sender, EventArgs e)
        {
            UpdateSections();
        }

        private void cb_updateTime_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateIntervalTime = (int)(double.Parse(cb_updateTime.Items[cb_updateTime.SelectedIndex]
                                             .ToString()) * 1000);
        }       

        internal void IsUpdateTimerRun(bool isActive)
        {
            timer_UpdateSections.Enabled = isActive;
        }

        private void btn_on_Click(object sender, EventArgs e)
        {
            if (!IsKeypadActive)
            {
                IsKeypadActive = true;
            }
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            if (IsKeypadActive)
            {
                IsKeypadActive = false;
            }
        }

        internal void InitializeView()
        {          
            setKeypadVisible(true);
            dgv_readOnlySection.CurrentCell = null;
            dgv_readWriteSection.CurrentCell = null;

            for (int i = 0; i < dgv_readWriteSection.RowCount; i++)
            {
                dgv_readWriteSection.Rows[i].Cells["Setter"].Value = false;
            }
        }

        internal void ResetView()
        {           
            setKeypadVisible(false);
            btn_setComArea.Visible = false;
            btn_off.Visible = false;
            btn_on.Visible = false;
            dgv_readOnlySection.DataSource = null;
            dgv_readWriteSection.DataSource = null;
            readOnlySection = null;
            readWriteSection = null;
            dgv_readWriteSection.Columns.Clear();
            dgv_readOnlySection.Refresh();
            dgv_readWriteSection.Refresh();
        }

        internal void setKeypadVisible(bool state)
        {
            if (state) pb_drive.Image = Properties.Resources.LG_iC5_keypad;
            else pb_drive.Image = Properties.Resources.DriveQuestionMark;
            rtb_display.Visible = state;
            rBtn_run.Visible = state;
            rBtn_stop.Visible = state;
            btn_down.Visible = state;
            btn_up.Visible = state;
            btn_right.Visible = state;
            btn_left.Visible = state;
            btn_middle.Visible = state;
            knob_pot.Visible = state;
            cb_reverse.Visible = state;
        }

        private async void sendCommAreaData()
        {
            await Task.Run(() =>
            {
                if (DataCommAreaToSend != null)
                {
                    lock (locker)
                    {
                        FormSetup.Port.Open();
                        FormSetup.Master.WriteMultipleRegisters((byte)FormSetup.SlaveAddr, 3, DataCommAreaToSend);
                        FormSetup.Port.Close();
                    }
                    DataCommAreaToSend = null;
                }
            });
            UpdateSections();
        }

        //private async void sendKeypadData()
        //{
        //    await Task.Run(() =>
        //    {
        //        if (DataKeypadToSend.Count != 0)
        //        {
        //            lock (locker)
        //            {
        //                FormSetup.Port.Open();
        //                FormSetup.Master.WriteSingleRegister((byte)FormSetup.SlaveAddr, (ushort)(DataKeypadToSend[0] - 1), DataKeypadToSend[1]);
        //                FormSetup.Port.Close();
        //            }
        //            DataKeypadToSend.Clear();
        //        }
        //    });
        //    UpdateSections();
        //}
    }
}
