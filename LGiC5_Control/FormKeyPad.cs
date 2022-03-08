using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriveControlLibrary;

namespace LGiC5_Control
{
    public partial class FormKeyPad : Form
    {
        private static List<Register> readOnlySection;
        private static List<Register> readWriteSection;       
        private int updateIntervalTime;
        private double[] intervalArray;
        private bool isKeypadActive;
        private bool isKeypadReady;   

        internal FormKeyPad()
        {
            InitializeComponent();
            isKeypadReady = true;
            updateIntervalTime = 1000;
            intervalArray = new double[] { 0.5, 1, 1.5, 2, 3, 4, 5 };
            timer_UpdateSections.Interval = UpdateIntervalTime;
            cb_updateTime.DataSource = intervalArray;
            cb_updateTime.SelectedIndex = 1;
            IsKeypadActive = false;
            knob_pot.LargeChange = 1000;
            knob_pot.Minimum = 0;
            knob_pot.Maximum = 5000;
            ResetView();
        }

        internal int UpdateIntervalTime
        {
            get => updateIntervalTime;
            set
            {
                updateIntervalTime = value;
                timer_UpdateSections.Interval = value;
            }
        }
        internal bool IsKeypadActive
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
        
        internal void UpdateSections()
        {
            dgv_readWriteSection.InvalidateColumn(dgv_readWriteSection.Columns["Value"].Index);
            dgv_readWriteSection.Update();
            dgv_readOnlySection.InvalidateColumn(dgv_readOnlySection.Columns["Value"].Index);
            dgv_readOnlySection.Update();
        }
        internal void BuildKeypadParamsView(LGdrive lgDrive)
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
        internal void IsUpdateTimerRun(bool isActive)
        {
            timer_UpdateSections.Enabled = isActive;
        }
        internal void InitializeDGV()
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
        private async void keypadCommand(ushort addr, ushort value)
        {
            if (!IsKeypadActive || !isKeypadReady) return;
            isKeypadReady = false;
            await Task.Run(() =>
            {
                ModbusProvider.GetMaster().SendSingleRegister(addr, value);
            });
            isKeypadReady = true;
            UpdateSections();
        }
        private void rBtn_run_Click(object sender, EventArgs e)
        {
            ushort addr = 6;
            ushort value;
            if (cb_reverse.Checked) value = 4;
            else value = 2;
            keypadCommand(addr, value);
        }
        private void rBtn_stop_Click(object sender, EventArgs e)
        {
            ushort addr = 6;
            ushort value = 1;
            keypadCommand(addr, value);
        }
        private void knobControl_ValueChanged(object Sender)
        {
            ushort addr = 5;
            ushort value = (ushort)knob_pot.Value;
            rtb_display.Text = String.Format("{0:D2}.{1:D2}", (value / 100), (value % 100));
            keypadCommand(addr, value);
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
                ModbusProvider.GetMaster().SendData(ModbusMemory.GroupedRegistersToDataExchange(regList, 8));
                ModbusProvider.GetMaster().ReadData(ModbusMemory.GroupedRegistersToDataExchange(regList, 8));
            });
            UpdateSections();
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
    }
}
