using System;
using System.Drawing;
using System.Windows.Forms;

namespace LGiC5_Control
{
    internal partial class Form1 : Form
    {
        private FormSetup formSetup;
        private FormKeyPad formKeypad;
        private FormParameter formParameter;
        private bool mouseDown;
        private Point offset;
        private Point[] menuPoints;

        private Color c1 = Color.FromArgb(0, 126, 249);
        private Color c2 = Color.FromArgb(46, 51, 73);
        private Color c3 = Color.FromArgb(24, 30, 54);

        internal Form1()
        {
            InitializeComponent();
            formSetup = new FormSetup() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formKeypad = new FormKeyPad() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formParameter = new FormParameter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };                   
            formSetup.RiseEdgeConnState += rTrigDriveIsConnected;
            formSetup.FallEdgeConnState += fTrigDriveIsDisconnected;
            menuPoints = new Point[] { new Point(0, 105), new Point(0, 147), new Point(0, 189), };
        }
        private void btn_portSetup_Click(object sender, EventArgs e)
        {
            formKeypad.IsUpdateTimerRun(false);
            panel_chosen.Location = menuPoints[0];
            panel_chosen.BackColor = c1;

            btn_connection.BackColor = c2;
            btn_keypad.BackColor = c3;
            btn_param.BackColor = c3;

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
            panel_chosen.Location = menuPoints[2];
            panel_chosen.BackColor = c1;

            btn_param.BackColor = c2;
            btn_connection.BackColor = c3;
            btn_keypad.BackColor = c3;

            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(formParameter);
            formParameter.Show();
        }
         private void btn_keypad_Click(object sender, EventArgs e)
        {           
            panel_chosen.Location = menuPoints[1];
            panel_chosen.BackColor = c1;

            btn_keypad.BackColor = c2;
            btn_connection.BackColor = c3;
            btn_param.BackColor = c3;

            this.panelContent.Controls.Clear();
            this.panelContent.Controls.Add(formKeypad);

            formKeypad.Show();
            //Włączanie timera aktualizacji sekcji Read/Write i ReadOnly.
            if (formSetup.IsConnectionCorrect)
            {
                formKeypad.InitializeDGV();
                formKeypad.IsUpdateTimerRun(true);
            }
        }
        private void rTrigDriveIsConnected()
        {
            formParameter.OnDriveConnect(formSetup.LgDrive);
            formParameter.SetDataSource();

            formKeypad.BuildKeypadParamsView(formSetup.LgDrive);
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
