using DriveControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus.Device;
using System.Threading;

namespace LGiC5_Control
{
    public delegate void RiseTrig();
    public delegate void FallTrig();
    public partial class FormSetup : Form
    {
        object locker = new object();
        public RiseTrig RiseEdgeConnState;
        public FallTrig FallEdgeConnState;
        static Parity parity;
        static int baud;
        static string com;
        static StopBits stopBits;
        static int bitData;
        static SerialPort port;
        static int slaveAddr = -1;
        LGdrive lgDrive;
        public static IModbusSerialMaster master;
        bool isConnectionCorrect;
        string[] comArray = { "COM1", "COM2", "COM3", "COM4",
                              "COM5", "COM6", "COM7", "COM8",
                              "COM9", "COM10", "COM11", "COM12",
                              "COM13", "COM14", "COM15", "COM16"};
        int[] baudArray = { 1200, 2400, 4800, 9600, 19200 };
        int[] dataBitArray = { 8 };
        string[] parityArray = { "None", "Even", "Mark", "Odd", "Space" };
        string[] stopBitsArray = { "1", "1.5", "2" };
        int[] slaveAddrArray = new int[33];

        public FormSetup()
        {
            InitializeComponent();
            initializeComboBox();
        }

        public static SerialPort Port { get => port; }
        public static int SlaveAddr { get => slaveAddr; }
        public LGdrive LgDrive { get => lgDrive; }
        public static IModbusSerialMaster Master { get => master; }
        public bool IsConnectionCorrect
        {
            get => isConnectionCorrect;
            set
            {
                if (value == true && value != isConnectionCorrect)
                {
                    isConnectionCorrect = value;
                    RiseEdgeConnState();
                }
                else if (value == false && value != isConnectionCorrect)
                {
                    isConnectionCorrect = value;
                    FallEdgeConnState();
                }
            }
        }
        public object Locker { get => locker; }

        private void initializeComboBox()
        {
            cb_commPort.DataSource = comArray;
            cb_commBaud.DataSource = baudArray;
            cb_dataBit.DataSource = dataBitArray;
            cb_parityBit.DataSource = parityArray;
            cb_stopBit.DataSource = stopBitsArray;
            for (int i = 0; i <= 32; i++) slaveAddrArray[i] = i;
            cb_slaveAddr.DataSource = slaveAddrArray;

            cb_commPort.SelectedIndex = -1;
            cb_commBaud.SelectedIndex = -1;
            cb_dataBit.SelectedIndex = -1;
            cb_parityBit.SelectedIndex = -1;
            cb_stopBit.SelectedIndex = -1;
            cb_slaveAddr.SelectedIndex = -1;
        }

        private void btn_serialPort_SET_Click(object sender, EventArgs e)
        {
            if ((cb_commPort.SelectedIndex == -1) || (cb_commBaud.SelectedIndex == -1)
                || (cb_dataBit.SelectedIndex == -1) || (cb_parityBit.SelectedIndex == -1)
                || (cb_stopBit.SelectedIndex == -1))
            {
                MessageBox.Show("Not all data has been entered.", "Attention!", MessageBoxButtons.OK);
                return;
            }
            com = comArray[cb_commPort.SelectedIndex];
            baud = baudArray[cb_commBaud.SelectedIndex];
            bitData = dataBitArray[cb_dataBit.SelectedIndex];
            parity = (Parity)Enum.Parse(typeof(Parity), parityArray[cb_parityBit.SelectedIndex]);
            switch (cb_stopBit.SelectedIndex)
            {
                case 0:
                    stopBits = StopBits.One;
                    break;
                case 1:
                    stopBits = StopBits.OnePointFive;
                    break;
                case 2:
                    stopBits = StopBits.Two;
                    break;
                default:
                    break;
            }
            portDetailsSet();
        }

        private void portDetailsSet()
        {
            port = new SerialPort(com);
            port.BaudRate = baud;
            port.DataBits = bitData;
            port.Parity = parity;
            port.StopBits = stopBits;

            lbl_port.Text = com;
            lbl_baud.Text = baud.ToString();
            lbl_dataBit.Text = bitData.ToString();
            lbl_parityBit.Text = parity.ToString();
            lbl_stopBit.Text = stopBits.ToString();
        }

        private void portDetailsAndSlaveAddrReset()
        {

            lgDrive = null;
            port = null;
            master = null;
            slaveAddr = -1;

            lbl_port.Text = "....................";
            lbl_baud.Text = "....................";
            lbl_dataBit.Text = "....................";
            lbl_parityBit.Text = "....................";
            lbl_stopBit.Text = "....................";
            lbl_slaveID.Text = "....................";
        }

        private void btn_slaveID_SET_Click(object sender, EventArgs e)
        {
            if (cb_slaveAddr.SelectedIndex != -1)
            {
                slaveAddr = byte.Parse(cb_slaveAddr.SelectedItem.ToString());
                lbl_slaveID.Text = slaveAddr.ToString();
            }
            else
            {
                MessageBox.Show("Not slave address has been entered.", "Attention!", MessageBoxButtons.OK);
            }
        }

        private void btn_CONNECT_DISCONNECT_Click(object sender, EventArgs e)
        {
            if (port == null || slaveAddr == -1)
            {
                MessageBox.Show("Not all connection parameters have been selected.", "Attention!", MessageBoxButtons.OK);
                return;
            }
            if (!isConnectionCorrect)
            {
                lgDrive = new LGdrive();
                createMaster(200, 200);
                if (DriveLibMaster.GetMaster().ReadData(lgDrive.Memory.GetCommonAreaToDataExchange()))
                    SetConnectionState();
            }
            else SetDisconnectionState();
        }

        private void createMaster(int readTimeout, int writeTimeout)
        {
            DriveLibMaster.GetMaster().SetParameters(port, (byte)slaveAddr);
            DriveLibMaster.GetMaster().CommonAreaRead += CommonAreaReadResult;
        }

        private void CommonAreaReadResult(object sender, EventArgs arg)
        {
            ModbusEventArgs mea = (ModbusEventArgs)arg;

            if (!mea.ReadCorrectly)
            {               
                BeginInvoke((Action)(() => { SetDisconnectionState(); }));
                MessageBox.Show(mea.MasterMssg, "Attention!");
            }
        }

        public void SetDisconnectionState()
        {
            timerCheckConnection.Enabled = false;
            DriveLibMaster.GetMaster().CommonAreaRead -= CommonAreaReadResult;
            btn_setSetupPort.Visible = true;
            btn_setSlaveID.Visible = true;
            IsConnectionCorrect = false;
            pb_connectionArrow.Image = Properties.Resources.blueDoubleArrow;
            btn_driveConnect.Text = "CONNECT";
            btn_driveConnect.ForeColor = Color.Lime;
            btn_driveConnect.Image = Properties.Resources.connect;
            pb_laptop.Image = Properties.Resources.LaptopIcon;
            pb_slave.Image = Properties.Resources.questionMark;
            portDetailsAndSlaveAddrReset();
        }

        public void SetConnectionState()
        {
            btn_setSetupPort.Visible = false;
            btn_setSlaveID.Visible = false;
            timerCheckConnection.Enabled = true;
            IsConnectionCorrect = true;
            pb_connectionArrow.Image = Properties.Resources.greenDoubleArrow;
            btn_driveConnect.Text = "DISCONNECT";
            btn_driveConnect.ForeColor = Color.Red;
            btn_driveConnect.Image = Properties.Resources.disconnect;
            pb_laptop.Image = Properties.Resources.LaptopIconGreen;
            pb_slave.Image = Properties.Resources.LG_iC5;

        }

        private void btn_lastSettings_Click(object sender, EventArgs e)
        {
            cb_commPort.SelectedIndex = 14;
            cb_commBaud.SelectedIndex = 3;
            cb_dataBit.SelectedIndex = 0;
            cb_parityBit.SelectedIndex = 0;
            cb_stopBit.SelectedIndex = 0;
            cb_slaveAddr.SelectedIndex = 1;
        }

        private async void timerCheckConnection_Tick(object sender, EventArgs e)
        {
            timerCheckConnection.Enabled = false;
            await Task.Run(() =>
            {
                if (DriveLibMaster.GetMaster().ReadData(lgDrive?.Memory.GetCommonAreaToDataExchange()))
                    BeginInvoke((Action)(() => timerCheckConnection.Enabled = true));
            });
        }
    }
}
