using DriveControlLibrary;
using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGiC5_Control
{
    internal partial class FormSetup : Form
    {
        public Action RiseEdgeConnState;
        public Action FallEdgeConnState;
        private static Parity parity;
        private static int baud;
        private static string com;
        private static StopBits stopBits;
        private static int bitData;
        private static SerialPort port;
        private static int slaveAddr;
        private LGdrive lgDrive;
        private bool isConnectionCorrect;
        private readonly string lastSettingsPath = "LastCommSettings.txt";
        private string[] comArray = { "COM1", "COM2", "COM3", "COM4",
                                      "COM5", "COM6", "COM7", "COM8",
                                      "COM9", "COM10", "COM11", "COM12",
                                      "COM13", "COM14", "COM15", "COM16" };
        private int[] baudArray = { 1200, 2400, 4800, 9600, 19200 };
        private int[] dataBitArray = { 8 };
        private string[] parityArray = { "None", "Even", "Mark", "Odd", "Space" };
        private string[] stopBitsArray = { "1", "1.5", "2" };
        private int[] slaveAddrArray = new int[33];

        internal FormSetup()
        {
            InitializeComponent();
            initializeComboBox();
            slaveAddr = -1;
        }

        internal static SerialPort Port { get => port; }
        internal static int SlaveAddr { get => slaveAddr; }
        internal LGdrive LgDrive { get => lgDrive; }
        internal bool IsConnectionCorrect
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
                MessageBox.Show("Not slave address has been entered."
                    , "Attention!", MessageBoxButtons.OK);
            }
        }
        private void btn_CONNECT_DISCONNECT_Click(object sender, EventArgs e)
        {
            if (port == null || slaveAddr == -1)
            {
                MessageBox.Show("Not all connection parameters have been selected."
                    , "Attention!", MessageBoxButtons.OK);
                return;
            }
            if (!isConnectionCorrect)
            {
                lgDrive = new LGdrive();
                createMaster(200, 200);
                if (ModbusProvider.GetMaster().ReadData(lgDrive.Memory.GetCommonAreaToDataExchange()))
                    SetConnectionState();
            }
            else SetDisconnectionState();
        }
        private void createMaster(int readTimeout, int writeTimeout)
        {
            ModbusProvider.GetMaster().SetParameters(port, (byte)slaveAddr);
            ModbusProvider.GetMaster().SetTimeout(readTimeout, writeTimeout);
            ModbusProvider.GetMaster().DataTransferred += CommonAreaReadResult;
            
        }
        private void CommonAreaReadResult(object sender, EventArgs arg)
        {
            ModbusEventArgs mea = (ModbusEventArgs)arg;

            if (!mea.ReadCorrectly)
            {               
                BeginInvoke((Action)(() => { SetDisconnectionState(); }));
                MessageBox.Show(mea.MasterMsg, "Attention!");
            }
        }
        public void SetDisconnectionState()
        {
            timerCheckConnection.Enabled = false;
            ModbusProvider.GetMaster().DataTransferred -= CommonAreaReadResult;
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
            WriteLastSettingsToFile();
            pb_connectionArrow.Image = Properties.Resources.greenDoubleArrow;
            btn_driveConnect.Text = "DISCONNECT";
            btn_driveConnect.ForeColor = Color.Red;
            btn_driveConnect.Image = Properties.Resources.disconnect;
            pb_laptop.Image = Properties.Resources.LaptopIconGreen;
            pb_slave.Image = Properties.Resources.LG_iC5;

        }
        private void btn_lastSettings_Click(object sender, EventArgs e)
        {
            ReadLastSettingsFromFile();
        }

        private void ReadLastSettingsFromFile()
        {
            if(File.Exists(lastSettingsPath))
            {
                StreamReader reader = new StreamReader(lastSettingsPath);
                string[] tab = new string[6];
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = reader.ReadLine();
                }
                reader.Close();
                cb_commPort.SelectedIndex = int.Parse(tab[0]);
                cb_commBaud.SelectedIndex = int.Parse(tab[1]);
                cb_dataBit.SelectedIndex = int.Parse(tab[2]);
                cb_parityBit.SelectedIndex = int.Parse(tab[3]);
                cb_stopBit.SelectedIndex = int.Parse(tab[4]);
                cb_slaveAddr.SelectedIndex = int.Parse(tab[5]);
            }
            else
            {
                MessageBox.Show("The feature is currently unavailable.", "Attention!");
            }
        }

        private void WriteLastSettingsToFile()
        {
            StreamWriter writer;
            if (!File.Exists(lastSettingsPath)) 
                writer = File.CreateText(lastSettingsPath);
            else
                writer = new StreamWriter(lastSettingsPath, false);

            writer.WriteLine(cb_commPort.SelectedIndex.ToString());
            writer.WriteLine(cb_commBaud.SelectedIndex.ToString());
            writer.WriteLine(cb_dataBit.SelectedIndex.ToString());
            writer.WriteLine(cb_parityBit.SelectedIndex.ToString());
            writer.WriteLine(cb_stopBit.SelectedIndex.ToString());
            writer.WriteLine(cb_slaveAddr.SelectedIndex.ToString());
            writer.Close();
        }

        private async void timerCheckConnection_Tick(object sender, EventArgs e)
        {
            timerCheckConnection.Enabled = false;
            await Task.Run(() =>
            {
                if (ModbusProvider.GetMaster().ReadData(lgDrive?.Memory.GetCommonAreaToDataExchange()))
                    BeginInvoke((Action)(() => timerCheckConnection.Enabled = true));
            });
        }
    }
}
