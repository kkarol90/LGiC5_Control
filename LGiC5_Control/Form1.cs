using LGiC5_Control.SpecialControls;
using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriveControlLibrary;

namespace LGiC5_Control
{
    public partial class Form1 : Form
    {
        //static LGdrive lgDrive;

        //static IModbusSerialMaster master;
        FormSetup formSetup;
        FormKeyPad formKeypad;
        FormParameter formParameter;
        //public static IModbusSerialMaster Master { get => master; set => master = value; }
        //public static LGdrive LgDrive { get => lgDrive; set => lgDrive = value; }
        bool mouseDown;
        Point offset;
        public Form1()
        {
            InitializeComponent();
            formSetup = new FormSetup() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formKeypad = new FormKeyPad(formSetup.Locker) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formParameter = new FormParameter(formSetup.Locker) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                   
            formSetup.RiseEdgeConnState += rTrigDriveIsConnected;
            formSetup.FallEdgeConnState += fTrigDriveIsDisconnected;
            
        }

        private void btn_portSetup_Click(object sender, EventArgs e)
        {
            formKeypad.IsUpdateTimerRun(false);
            panel_chosen.Location = new Point(0, 105);
            panel_chosen.BackColor = Color.FromArgb(0, 126, 249);

            btn_connection.BackColor = Color.FromArgb(46, 51, 73);
            btn_keypad.BackColor = Color.FromArgb(24, 30, 54);
            btn_param.BackColor = Color.FromArgb(24, 30, 54);

            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(formSetup);
            formSetup.Show();           
        }

        private void btn_param_Click(object sender, EventArgs e)
        {
            if (formSetup.IsConnectionCorrect)
            {
                formParameter.ParameterFormIsSelected();
            }
            formKeypad.IsUpdateTimerRun(false);
            panel_chosen.Location = new Point(0, 189);
            panel_chosen.BackColor = Color.FromArgb(0, 126, 249);

            btn_param.BackColor = Color.FromArgb(46, 51, 73);
            btn_connection.BackColor = Color.FromArgb(24, 30, 54);
            btn_keypad.BackColor = Color.FromArgb(24, 30, 54);

            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(formParameter);
            formParameter.Show();
        }

         private void btn_keypad_Click(object sender, EventArgs e)
        {           
            panel_chosen.Location = new Point(0, 147);
            panel_chosen.BackColor = Color.FromArgb(0, 126, 249);

            btn_keypad.BackColor = Color.FromArgb(46, 51, 73);
            btn_connection.BackColor = Color.FromArgb(24, 30, 54);
            btn_param.BackColor = Color.FromArgb(24, 30, 54);

            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(formKeypad);

            formKeypad.Show();
            //Włączanie timera aktualizacji sekcji Read/Write i ReadOnly.
            if (formSetup.IsConnectionCorrect)
            {
                formKeypad.InitializeView();
                formKeypad.IsUpdateTimerRun(true);
            }
        }

        private void rTrigDriveIsConnected()
        {
            formParameter.OnDriveConnect(formSetup.LgDrive);
            formParameter.SetDataSource();

            formKeypad.buildKeypadParamsView(formSetup.LgDrive);
        }
        private void fTrigDriveIsDisconnected()
        {
            formKeypad.IsUpdateTimerRun(false);
            formParameter.OnDriveDisconnect();
            formKeypad.ResetView();
        }

        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel_title_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X-offset.X, currentScreenPos.Y-offset.Y);
            }
        }

        private void panel_title_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
