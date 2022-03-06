namespace LGiC5_Control
{
    partial class FormSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_setSetupPort = new System.Windows.Forms.Button();
            this.lbl_connection = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_serialPort = new System.Windows.Forms.Label();
            this.lbl_setup_commPort = new System.Windows.Forms.Label();
            this.cb_dataBit = new System.Windows.Forms.ComboBox();
            this.cb_commPort = new System.Windows.Forms.ComboBox();
            this.cb_commBaud = new System.Windows.Forms.ComboBox();
            this.lbl_setup_parityBit = new System.Windows.Forms.Label();
            this.cb_stopBit = new System.Windows.Forms.ComboBox();
            this.lbl_setup_stopBit = new System.Windows.Forms.Label();
            this.cb_parityBit = new System.Windows.Forms.ComboBox();
            this.lbl_setup_commBaud = new System.Windows.Forms.Label();
            this.lbl_setup_dataBit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_setSlaveID = new System.Windows.Forms.Button();
            this.lbl_slave = new System.Windows.Forms.Label();
            this.lbl_slaveNum = new System.Windows.Forms.Label();
            this.cb_slaveAddr = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_infoBoard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_slaveID = new System.Windows.Forms.Label();
            this.lbl_stopBit = new System.Windows.Forms.Label();
            this.lbl_parityBit = new System.Windows.Forms.Label();
            this.lbl_dataBit = new System.Windows.Forms.Label();
            this.lbl_baud = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_driveConnect = new System.Windows.Forms.Button();
            this.pb_slave = new System.Windows.Forms.PictureBox();
            this.pb_connectionArrow = new System.Windows.Forms.PictureBox();
            this.pb_laptop = new System.Windows.Forms.PictureBox();
            this.lbl_connectedDevice = new System.Windows.Forms.Label();
            this.timerCheckConnection = new System.Windows.Forms.Timer(this.components);
            this.btn_lastSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_slave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_connectionArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_laptop)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_setSetupPort
            // 
            this.btn_setSetupPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_setSetupPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setSetupPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_setSetupPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btn_setSetupPort.Location = new System.Drawing.Point(19, 189);
            this.btn_setSetupPort.Name = "btn_setSetupPort";
            this.btn_setSetupPort.Size = new System.Drawing.Size(268, 27);
            this.btn_setSetupPort.TabIndex = 1;
            this.btn_setSetupPort.Text = "SET";
            this.btn_setSetupPort.UseVisualStyleBackColor = false;
            this.btn_setSetupPort.Click += new System.EventHandler(this.btn_serialPort_SET_Click);
            // 
            // lbl_connection
            // 
            this.lbl_connection.AutoSize = true;
            this.lbl_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_connection.Location = new System.Drawing.Point(20, 17);
            this.lbl_connection.Name = "lbl_connection";
            this.lbl_connection.Size = new System.Drawing.Size(172, 33);
            this.lbl_connection.TabIndex = 10;
            this.lbl_connection.Text = "Connection";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbl_serialPort);
            this.panel1.Controls.Add(this.lbl_setup_commPort);
            this.panel1.Controls.Add(this.cb_dataBit);
            this.panel1.Controls.Add(this.btn_setSetupPort);
            this.panel1.Controls.Add(this.cb_commPort);
            this.panel1.Controls.Add(this.cb_commBaud);
            this.panel1.Controls.Add(this.lbl_setup_parityBit);
            this.panel1.Controls.Add(this.cb_stopBit);
            this.panel1.Controls.Add(this.lbl_setup_stopBit);
            this.panel1.Controls.Add(this.cb_parityBit);
            this.panel1.Controls.Add(this.lbl_setup_commBaud);
            this.panel1.Controls.Add(this.lbl_setup_dataBit);
            this.panel1.Location = new System.Drawing.Point(26, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 230);
            this.panel1.TabIndex = 12;
            // 
            // lbl_serialPort
            // 
            this.lbl_serialPort.AutoSize = true;
            this.lbl_serialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_serialPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_serialPort.Location = new System.Drawing.Point(15, 10);
            this.lbl_serialPort.Name = "lbl_serialPort";
            this.lbl_serialPort.Size = new System.Drawing.Size(105, 24);
            this.lbl_serialPort.TabIndex = 10;
            this.lbl_serialPort.Text = "Serial port";
            // 
            // lbl_setup_commPort
            // 
            this.lbl_setup_commPort.AutoSize = true;
            this.lbl_setup_commPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_setup_commPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_setup_commPort.Location = new System.Drawing.Point(16, 45);
            this.lbl_setup_commPort.Name = "lbl_setup_commPort";
            this.lbl_setup_commPort.Size = new System.Drawing.Size(143, 16);
            this.lbl_setup_commPort.TabIndex = 0;
            this.lbl_setup_commPort.Text = "Communication port";
            // 
            // cb_dataBit
            // 
            this.cb_dataBit.AutoCompleteCustomSource.AddRange(new string[] {
            "8"});
            this.cb_dataBit.FormattingEnabled = true;
            this.cb_dataBit.Location = new System.Drawing.Point(172, 98);
            this.cb_dataBit.Name = "cb_dataBit";
            this.cb_dataBit.Size = new System.Drawing.Size(115, 21);
            this.cb_dataBit.TabIndex = 5;
            // 
            // cb_commPort
            // 
            this.cb_commPort.AutoCompleteCustomSource.AddRange(new string[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16"});
            this.cb_commPort.FormattingEnabled = true;
            this.cb_commPort.Location = new System.Drawing.Point(172, 44);
            this.cb_commPort.Name = "cb_commPort";
            this.cb_commPort.Size = new System.Drawing.Size(115, 21);
            this.cb_commPort.TabIndex = 1;
            // 
            // cb_commBaud
            // 
            this.cb_commBaud.FormattingEnabled = true;
            this.cb_commBaud.Location = new System.Drawing.Point(172, 71);
            this.cb_commBaud.Name = "cb_commBaud";
            this.cb_commBaud.Size = new System.Drawing.Size(115, 21);
            this.cb_commBaud.TabIndex = 3;
            // 
            // lbl_setup_parityBit
            // 
            this.lbl_setup_parityBit.AutoSize = true;
            this.lbl_setup_parityBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_setup_parityBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_setup_parityBit.Location = new System.Drawing.Point(16, 126);
            this.lbl_setup_parityBit.Name = "lbl_setup_parityBit";
            this.lbl_setup_parityBit.Size = new System.Drawing.Size(68, 16);
            this.lbl_setup_parityBit.TabIndex = 6;
            this.lbl_setup_parityBit.Text = "Parity bit";
            // 
            // cb_stopBit
            // 
            this.cb_stopBit.AutoCompleteCustomSource.AddRange(new string[] {
            "1"});
            this.cb_stopBit.FormattingEnabled = true;
            this.cb_stopBit.Location = new System.Drawing.Point(172, 152);
            this.cb_stopBit.Name = "cb_stopBit";
            this.cb_stopBit.Size = new System.Drawing.Size(115, 21);
            this.cb_stopBit.TabIndex = 9;
            // 
            // lbl_setup_stopBit
            // 
            this.lbl_setup_stopBit.AutoSize = true;
            this.lbl_setup_stopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_setup_stopBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_setup_stopBit.Location = new System.Drawing.Point(16, 153);
            this.lbl_setup_stopBit.Name = "lbl_setup_stopBit";
            this.lbl_setup_stopBit.Size = new System.Drawing.Size(60, 16);
            this.lbl_setup_stopBit.TabIndex = 8;
            this.lbl_setup_stopBit.Text = "Stop bit";
            // 
            // cb_parityBit
            // 
            this.cb_parityBit.AutoCompleteCustomSource.AddRange(new string[] {
            "0"});
            this.cb_parityBit.FormattingEnabled = true;
            this.cb_parityBit.Location = new System.Drawing.Point(172, 125);
            this.cb_parityBit.Name = "cb_parityBit";
            this.cb_parityBit.Size = new System.Drawing.Size(115, 21);
            this.cb_parityBit.TabIndex = 7;
            // 
            // lbl_setup_commBaud
            // 
            this.lbl_setup_commBaud.AutoSize = true;
            this.lbl_setup_commBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_setup_commBaud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_setup_commBaud.Location = new System.Drawing.Point(16, 72);
            this.lbl_setup_commBaud.Name = "lbl_setup_commBaud";
            this.lbl_setup_commBaud.Size = new System.Drawing.Size(70, 16);
            this.lbl_setup_commBaud.TabIndex = 2;
            this.lbl_setup_commBaud.Text = "Baudrate";
            // 
            // lbl_setup_dataBit
            // 
            this.lbl_setup_dataBit.AutoSize = true;
            this.lbl_setup_dataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_setup_dataBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_setup_dataBit.Location = new System.Drawing.Point(16, 99);
            this.lbl_setup_dataBit.Name = "lbl_setup_dataBit";
            this.lbl_setup_dataBit.Size = new System.Drawing.Size(61, 16);
            this.lbl_setup_dataBit.TabIndex = 4;
            this.lbl_setup_dataBit.Text = "Data bit";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_setSlaveID);
            this.panel2.Controls.Add(this.lbl_slave);
            this.panel2.Controls.Add(this.lbl_slaveNum);
            this.panel2.Controls.Add(this.cb_slaveAddr);
            this.panel2.Location = new System.Drawing.Point(26, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 124);
            this.panel2.TabIndex = 13;
            // 
            // btn_setSlaveID
            // 
            this.btn_setSlaveID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_setSlaveID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setSlaveID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_setSlaveID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btn_setSlaveID.Location = new System.Drawing.Point(19, 80);
            this.btn_setSlaveID.Name = "btn_setSlaveID";
            this.btn_setSlaveID.Size = new System.Drawing.Size(268, 27);
            this.btn_setSlaveID.TabIndex = 11;
            this.btn_setSlaveID.Text = "SET";
            this.btn_setSlaveID.UseVisualStyleBackColor = false;
            this.btn_setSlaveID.Click += new System.EventHandler(this.btn_slaveID_SET_Click);
            // 
            // lbl_slave
            // 
            this.lbl_slave.AutoSize = true;
            this.lbl_slave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_slave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_slave.Location = new System.Drawing.Point(15, 10);
            this.lbl_slave.Name = "lbl_slave";
            this.lbl_slave.Size = new System.Drawing.Size(61, 24);
            this.lbl_slave.TabIndex = 10;
            this.lbl_slave.Text = "Slave";
            // 
            // lbl_slaveNum
            // 
            this.lbl_slaveNum.AutoSize = true;
            this.lbl_slaveNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_slaveNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_slaveNum.Location = new System.Drawing.Point(16, 45);
            this.lbl_slaveNum.Name = "lbl_slaveNum";
            this.lbl_slaveNum.Size = new System.Drawing.Size(117, 16);
            this.lbl_slaveNum.TabIndex = 0;
            this.lbl_slaveNum.Text = "Device address";
            // 
            // cb_slaveAddr
            // 
            this.cb_slaveAddr.AutoCompleteCustomSource.AddRange(new string[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16"});
            this.cb_slaveAddr.FormattingEnabled = true;
            this.cb_slaveAddr.Location = new System.Drawing.Point(172, 44);
            this.cb_slaveAddr.Name = "cb_slaveAddr";
            this.cb_slaveAddr.Size = new System.Drawing.Size(117, 21);
            this.cb_slaveAddr.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lbl_infoBoard);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(26, 471);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 94);
            this.panel3.TabIndex = 14;
            // 
            // lbl_infoBoard
            // 
            this.lbl_infoBoard.AutoSize = true;
            this.lbl_infoBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_infoBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_infoBoard.Location = new System.Drawing.Point(15, 10);
            this.lbl_infoBoard.Name = "lbl_infoBoard";
            this.lbl_infoBoard.Size = new System.Drawing.Size(104, 24);
            this.lbl_infoBoard.TabIndex = 12;
            this.lbl_infoBoard.Text = "Info board";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.CausesValidation = false;
            this.panel4.Controls.Add(this.lbl_slaveID);
            this.panel4.Controls.Add(this.lbl_stopBit);
            this.panel4.Controls.Add(this.lbl_parityBit);
            this.panel4.Controls.Add(this.lbl_dataBit);
            this.panel4.Controls.Add(this.lbl_baud);
            this.panel4.Controls.Add(this.lbl_port);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btn_driveConnect);
            this.panel4.Controls.Add(this.pb_slave);
            this.panel4.Controls.Add(this.pb_connectionArrow);
            this.panel4.Controls.Add(this.pb_laptop);
            this.panel4.Controls.Add(this.lbl_connectedDevice);
            this.panel4.Location = new System.Drawing.Point(352, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 380);
            this.panel4.TabIndex = 14;
            // 
            // lbl_slaveID
            // 
            this.lbl_slaveID.AutoSize = true;
            this.lbl_slaveID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_slaveID.Location = new System.Drawing.Point(85, 270);
            this.lbl_slaveID.Name = "lbl_slaveID";
            this.lbl_slaveID.Size = new System.Drawing.Size(67, 13);
            this.lbl_slaveID.TabIndex = 25;
            this.lbl_slaveID.Text = "....................";
            // 
            // lbl_stopBit
            // 
            this.lbl_stopBit.AutoSize = true;
            this.lbl_stopBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_stopBit.Location = new System.Drawing.Point(85, 213);
            this.lbl_stopBit.Name = "lbl_stopBit";
            this.lbl_stopBit.Size = new System.Drawing.Size(67, 13);
            this.lbl_stopBit.TabIndex = 24;
            this.lbl_stopBit.Text = "....................";
            // 
            // lbl_parityBit
            // 
            this.lbl_parityBit.AutoSize = true;
            this.lbl_parityBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_parityBit.Location = new System.Drawing.Point(85, 200);
            this.lbl_parityBit.Name = "lbl_parityBit";
            this.lbl_parityBit.Size = new System.Drawing.Size(67, 13);
            this.lbl_parityBit.TabIndex = 23;
            this.lbl_parityBit.Text = "....................";
            // 
            // lbl_dataBit
            // 
            this.lbl_dataBit.AutoSize = true;
            this.lbl_dataBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_dataBit.Location = new System.Drawing.Point(85, 186);
            this.lbl_dataBit.Name = "lbl_dataBit";
            this.lbl_dataBit.Size = new System.Drawing.Size(67, 13);
            this.lbl_dataBit.TabIndex = 22;
            this.lbl_dataBit.Text = "....................";
            // 
            // lbl_baud
            // 
            this.lbl_baud.AutoSize = true;
            this.lbl_baud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_baud.Location = new System.Drawing.Point(85, 173);
            this.lbl_baud.Name = "lbl_baud";
            this.lbl_baud.Size = new System.Drawing.Size(67, 13);
            this.lbl_baud.TabIndex = 21;
            this.lbl_baud.Text = "....................";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_port.Location = new System.Drawing.Point(85, 160);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(67, 13);
            this.lbl_port.TabIndex = 20;
            this.lbl_port.Text = "....................";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(37, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Slave ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(42, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Stop bit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(38, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Parity bit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(41, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Data bit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(35, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Baudrate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(59, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Port:";
            // 
            // btn_driveConnect
            // 
            this.btn_driveConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_driveConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_driveConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_driveConnect.ForeColor = System.Drawing.Color.Lime;
            this.btn_driveConnect.Image = global::LGiC5_Control.Properties.Resources.connect;
            this.btn_driveConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_driveConnect.Location = new System.Drawing.Point(234, 175);
            this.btn_driveConnect.Name = "btn_driveConnect";
            this.btn_driveConnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_driveConnect.Size = new System.Drawing.Size(148, 34);
            this.btn_driveConnect.TabIndex = 11;
            this.btn_driveConnect.Text = "CONNECT";
            this.btn_driveConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_driveConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_driveConnect.UseVisualStyleBackColor = false;
            this.btn_driveConnect.Click += new System.EventHandler(this.btn_CONNECT_DISCONNECT_Click);
            // 
            // pb_slave
            // 
            this.pb_slave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_slave.Image = global::LGiC5_Control.Properties.Resources.questionMark;
            this.pb_slave.Location = new System.Drawing.Point(169, 253);
            this.pb_slave.Name = "pb_slave";
            this.pb_slave.Size = new System.Drawing.Size(86, 95);
            this.pb_slave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_slave.TabIndex = 13;
            this.pb_slave.TabStop = false;
            // 
            // pb_connectionArrow
            // 
            this.pb_connectionArrow.Image = global::LGiC5_Control.Properties.Resources.blueDoubleArrow;
            this.pb_connectionArrow.Location = new System.Drawing.Point(196, 143);
            this.pb_connectionArrow.Name = "pb_connectionArrow";
            this.pb_connectionArrow.Size = new System.Drawing.Size(32, 104);
            this.pb_connectionArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_connectionArrow.TabIndex = 12;
            this.pb_connectionArrow.TabStop = false;
            // 
            // pb_laptop
            // 
            this.pb_laptop.Image = global::LGiC5_Control.Properties.Resources.LaptopIcon;
            this.pb_laptop.Location = new System.Drawing.Point(148, 49);
            this.pb_laptop.Name = "pb_laptop";
            this.pb_laptop.Size = new System.Drawing.Size(128, 88);
            this.pb_laptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_laptop.TabIndex = 11;
            this.pb_laptop.TabStop = false;
            // 
            // lbl_connectedDevice
            // 
            this.lbl_connectedDevice.AutoSize = true;
            this.lbl_connectedDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_connectedDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_connectedDevice.Location = new System.Drawing.Point(15, 10);
            this.lbl_connectedDevice.Name = "lbl_connectedDevice";
            this.lbl_connectedDevice.Size = new System.Drawing.Size(180, 24);
            this.lbl_connectedDevice.TabIndex = 10;
            this.lbl_connectedDevice.Text = "Connected device";
            // 
            // timerCheckConnection
            // 
            this.timerCheckConnection.Interval = 300;
            this.timerCheckConnection.Tick += new System.EventHandler(this.timerCheckConnection_Tick);
            // 
            // btn_lastSettings
            // 
            this.btn_lastSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lastSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btn_lastSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btn_lastSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lastSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_lastSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btn_lastSettings.Location = new System.Drawing.Point(239, 27);
            this.btn_lastSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btn_lastSettings.Name = "btn_lastSettings";
            this.btn_lastSettings.Size = new System.Drawing.Size(89, 23);
            this.btn_lastSettings.TabIndex = 15;
            this.btn_lastSettings.Text = "Last settings";
            this.btn_lastSettings.UseVisualStyleBackColor = false;
            this.btn_lastSettings.Click += new System.EventHandler(this.btn_lastSettings_Click);
            // 
            // FormSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 577);
            this.Controls.Add(this.btn_lastSettings);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_connection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetup";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_slave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_connectionArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_laptop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btn_setSetupPort;
        private System.Windows.Forms.Label lbl_connection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_serialPort;
        private System.Windows.Forms.Label lbl_setup_commPort;
        private System.Windows.Forms.ComboBox cb_dataBit;
        private System.Windows.Forms.ComboBox cb_commPort;
        private System.Windows.Forms.ComboBox cb_commBaud;
        private System.Windows.Forms.Label lbl_setup_parityBit;
        private System.Windows.Forms.ComboBox cb_stopBit;
        private System.Windows.Forms.Label lbl_setup_stopBit;
        private System.Windows.Forms.ComboBox cb_parityBit;
        private System.Windows.Forms.Label lbl_setup_commBaud;
        private System.Windows.Forms.Label lbl_setup_dataBit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_setSlaveID;
        private System.Windows.Forms.Label lbl_slave;
        private System.Windows.Forms.Label lbl_slaveNum;
        private System.Windows.Forms.ComboBox cb_slaveAddr;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_infoBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_connectedDevice;
        private System.Windows.Forms.PictureBox pb_connectionArrow;
        private System.Windows.Forms.PictureBox pb_laptop;
        private System.Windows.Forms.PictureBox pb_slave;
        private System.Windows.Forms.Button btn_driveConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_slaveID;
        private System.Windows.Forms.Label lbl_stopBit;
        private System.Windows.Forms.Label lbl_parityBit;
        private System.Windows.Forms.Label lbl_dataBit;
        private System.Windows.Forms.Label lbl_baud;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Timer timerCheckConnection;
        private System.Windows.Forms.Button btn_lastSettings;
    }
}