namespace LGiC5_Control
{
    partial class FormKeyPad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rtb_display = new System.Windows.Forms.RichTextBox();
            this.panel_keypadReadWrite = new System.Windows.Forms.Panel();
            this.dgv_readWriteSection = new System.Windows.Forms.DataGridView();
            this.lbl_readWrite = new System.Windows.Forms.Label();
            this.btn_setComArea = new System.Windows.Forms.Button();
            this.panel_keypadReadonly = new System.Windows.Forms.Panel();
            this.dgv_readOnlySection = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_updateTime = new System.Windows.Forms.Label();
            this.cb_updateTime = new System.Windows.Forms.ComboBox();
            this.lbl_sek = new System.Windows.Forms.Label();
            this.timer_UpdateSections = new System.Windows.Forms.Timer(this.components);
            this.btn_off = new System.Windows.Forms.Button();
            this.btn_on = new System.Windows.Forms.Button();
            this.cb_reverse = new System.Windows.Forms.CheckBox();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_middle = new System.Windows.Forms.Button();
            this.pb_drive = new System.Windows.Forms.PictureBox();
            this.rBtn_stop = new LGiC5_Control.SpecialControls.RoundButton();
            this.rBtn_run = new LGiC5_Control.SpecialControls.RoundButton();
            this.knob_pot = new LGiC5_Control.SpecialControls.KnobControl();
            this.panel_keypadReadWrite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readWriteSection)).BeginInit();
            this.panel_keypadReadonly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readOnlySection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_drive)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_display
            // 
            this.rtb_display.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtb_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.rtb_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_display.Cursor = System.Windows.Forms.Cursors.No;
            this.rtb_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb_display.ForeColor = System.Drawing.Color.Red;
            this.rtb_display.Location = new System.Drawing.Point(138, 77);
            this.rtb_display.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_display.Name = "rtb_display";
            this.rtb_display.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_display.Size = new System.Drawing.Size(105, 54);
            this.rtb_display.TabIndex = 8;
            this.rtb_display.Text = "50.50";
            this.rtb_display.Visible = false;
            // 
            // panel_keypadReadWrite
            // 
            this.panel_keypadReadWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel_keypadReadWrite.Controls.Add(this.dgv_readWriteSection);
            this.panel_keypadReadWrite.Controls.Add(this.lbl_readWrite);
            this.panel_keypadReadWrite.Controls.Add(this.btn_setComArea);
            this.panel_keypadReadWrite.Location = new System.Drawing.Point(378, 39);
            this.panel_keypadReadWrite.Name = "panel_keypadReadWrite";
            this.panel_keypadReadWrite.Size = new System.Drawing.Size(375, 233);
            this.panel_keypadReadWrite.TabIndex = 21;
            // 
            // dgv_readWriteSection
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgv_readWriteSection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_readWriteSection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgv_readWriteSection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_readWriteSection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_readWriteSection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_readWriteSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_readWriteSection.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_readWriteSection.EnableHeadersVisualStyles = false;
            this.dgv_readWriteSection.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.dgv_readWriteSection.Location = new System.Drawing.Point(19, 38);
            this.dgv_readWriteSection.Name = "dgv_readWriteSection";
            this.dgv_readWriteSection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_readWriteSection.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_readWriteSection.RowHeadersVisible = false;
            this.dgv_readWriteSection.Size = new System.Drawing.Size(341, 149);
            this.dgv_readWriteSection.TabIndex = 12;
            // 
            // lbl_readWrite
            // 
            this.lbl_readWrite.AutoSize = true;
            this.lbl_readWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_readWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_readWrite.Location = new System.Drawing.Point(15, 10);
            this.lbl_readWrite.Name = "lbl_readWrite";
            this.lbl_readWrite.Size = new System.Drawing.Size(182, 24);
            this.lbl_readWrite.TabIndex = 10;
            this.lbl_readWrite.Text = "Read/write section";
            // 
            // btn_setComArea
            // 
            this.btn_setComArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_setComArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setComArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_setComArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btn_setComArea.Location = new System.Drawing.Point(19, 193);
            this.btn_setComArea.Name = "btn_setComArea";
            this.btn_setComArea.Size = new System.Drawing.Size(341, 27);
            this.btn_setComArea.TabIndex = 1;
            this.btn_setComArea.Text = "SET";
            this.btn_setComArea.UseVisualStyleBackColor = false;
            this.btn_setComArea.Click += new System.EventHandler(this.btn_setComArea_Click);
            // 
            // panel_keypadReadonly
            // 
            this.panel_keypadReadonly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel_keypadReadonly.Controls.Add(this.dgv_readOnlySection);
            this.panel_keypadReadonly.Controls.Add(this.label1);
            this.panel_keypadReadonly.Location = new System.Drawing.Point(378, 288);
            this.panel_keypadReadonly.Name = "panel_keypadReadonly";
            this.panel_keypadReadonly.Size = new System.Drawing.Size(375, 277);
            this.panel_keypadReadonly.TabIndex = 22;
            // 
            // dgv_readOnlySection
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgv_readOnlySection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_readOnlySection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgv_readOnlySection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_readOnlySection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_readOnlySection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_readOnlySection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_readOnlySection.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_readOnlySection.EnableHeadersVisualStyles = false;
            this.dgv_readOnlySection.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.dgv_readOnlySection.Location = new System.Drawing.Point(19, 43);
            this.dgv_readOnlySection.Name = "dgv_readOnlySection";
            this.dgv_readOnlySection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_readOnlySection.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_readOnlySection.RowHeadersVisible = false;
            this.dgv_readOnlySection.Size = new System.Drawing.Size(341, 216);
            this.dgv_readOnlySection.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Read only section";
            // 
            // lbl_updateTime
            // 
            this.lbl_updateTime.AutoSize = true;
            this.lbl_updateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_updateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_updateTime.Location = new System.Drawing.Point(384, 9);
            this.lbl_updateTime.Name = "lbl_updateTime";
            this.lbl_updateTime.Size = new System.Drawing.Size(103, 18);
            this.lbl_updateTime.TabIndex = 23;
            this.lbl_updateTime.Text = "Update time:";
            // 
            // cb_updateTime
            // 
            this.cb_updateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_updateTime.FormattingEnabled = true;
            this.cb_updateTime.Location = new System.Drawing.Point(489, 6);
            this.cb_updateTime.Name = "cb_updateTime";
            this.cb_updateTime.Size = new System.Drawing.Size(43, 24);
            this.cb_updateTime.TabIndex = 24;
            this.cb_updateTime.SelectedValueChanged += new System.EventHandler(this.cb_updateTime_SelectedValueChanged);
            // 
            // lbl_sek
            // 
            this.lbl_sek.AutoSize = true;
            this.lbl_sek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_sek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_sek.Location = new System.Drawing.Point(538, 9);
            this.lbl_sek.Name = "lbl_sek";
            this.lbl_sek.Size = new System.Drawing.Size(17, 18);
            this.lbl_sek.TabIndex = 25;
            this.lbl_sek.Text = "s";
            // 
            // timer_UpdateSections
            // 
            this.timer_UpdateSections.Tick += new System.EventHandler(this.timerUpdateSections_Tick);
            // 
            // btn_off
            // 
            this.btn_off.BackColor = System.Drawing.Color.DarkGray;
            this.btn_off.FlatAppearance.BorderSize = 0;
            this.btn_off.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_off.Location = new System.Drawing.Point(51, 541);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(39, 23);
            this.btn_off.TabIndex = 26;
            this.btn_off.Text = "OFF";
            this.btn_off.UseVisualStyleBackColor = false;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // btn_on
            // 
            this.btn_on.BackColor = System.Drawing.Color.DarkGray;
            this.btn_on.FlatAppearance.BorderSize = 0;
            this.btn_on.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_on.Location = new System.Drawing.Point(12, 541);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(39, 23);
            this.btn_on.TabIndex = 27;
            this.btn_on.Text = "ON";
            this.btn_on.UseVisualStyleBackColor = false;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click);
            // 
            // cb_reverse
            // 
            this.cb_reverse.AutoSize = true;
            this.cb_reverse.BackColor = System.Drawing.Color.White;
            this.cb_reverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_reverse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_reverse.Location = new System.Drawing.Point(64, 149);
            this.cb_reverse.Name = "cb_reverse";
            this.cb_reverse.Size = new System.Drawing.Size(78, 19);
            this.cb_reverse.TabIndex = 29;
            this.cb_reverse.Text = "Reverse";
            this.cb_reverse.UseVisualStyleBackColor = false;
            this.cb_reverse.Visible = false;
            // 
            // btn_left
            // 
            this.btn_left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_left.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_left.FlatAppearance.BorderSize = 0;
            this.btn_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_left.Image = global::LGiC5_Control.Properties.Resources.Left_btn;
            this.btn_left.Location = new System.Drawing.Point(167, 303);
            this.btn_left.Margin = new System.Windows.Forms.Padding(0);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(15, 15);
            this.btn_left.TabIndex = 20;
            this.btn_left.UseVisualStyleBackColor = false;
            this.btn_left.Visible = false;
            // 
            // btn_right
            // 
            this.btn_right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_right.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_right.FlatAppearance.BorderSize = 0;
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_right.Image = global::LGiC5_Control.Properties.Resources.Right_btn;
            this.btn_right.Location = new System.Drawing.Point(197, 303);
            this.btn_right.Margin = new System.Windows.Forms.Padding(0);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(15, 15);
            this.btn_right.TabIndex = 19;
            this.btn_right.UseVisualStyleBackColor = false;
            this.btn_right.Visible = false;
            // 
            // btn_up
            // 
            this.btn_up.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_up.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_up.FlatAppearance.BorderSize = 0;
            this.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_up.Image = global::LGiC5_Control.Properties.Resources.Up_btn;
            this.btn_up.Location = new System.Drawing.Point(182, 288);
            this.btn_up.Margin = new System.Windows.Forms.Padding(0);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(15, 15);
            this.btn_up.TabIndex = 18;
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Visible = false;
            // 
            // btn_down
            // 
            this.btn_down.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_down.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_down.FlatAppearance.BorderSize = 0;
            this.btn_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_down.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_down.Image = global::LGiC5_Control.Properties.Resources.Down_btn;
            this.btn_down.Location = new System.Drawing.Point(182, 318);
            this.btn_down.Margin = new System.Windows.Forms.Padding(0);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(15, 15);
            this.btn_down.TabIndex = 17;
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Visible = false;
            // 
            // btn_middle
            // 
            this.btn_middle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_middle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_middle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_middle.FlatAppearance.BorderSize = 0;
            this.btn_middle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_middle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btn_middle.Image = global::LGiC5_Control.Properties.Resources.Mid_btn;
            this.btn_middle.Location = new System.Drawing.Point(182, 303);
            this.btn_middle.Margin = new System.Windows.Forms.Padding(0);
            this.btn_middle.Name = "btn_middle";
            this.btn_middle.Size = new System.Drawing.Size(15, 15);
            this.btn_middle.TabIndex = 9;
            this.btn_middle.UseVisualStyleBackColor = false;
            this.btn_middle.Visible = false;
            // 
            // pb_drive
            // 
            this.pb_drive.Image = global::LGiC5_Control.Properties.Resources.LG_iC5_keypad;
            this.pb_drive.Location = new System.Drawing.Point(12, 12);
            this.pb_drive.Name = "pb_drive";
            this.pb_drive.Size = new System.Drawing.Size(355, 520);
            this.pb_drive.TabIndex = 14;
            this.pb_drive.TabStop = false;
            // 
            // rBtn_stop
            // 
            this.rBtn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.rBtn_stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.rBtn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtn_stop.ForeColor = System.Drawing.Color.Black;
            this.rBtn_stop.Location = new System.Drawing.Point(249, 167);
            this.rBtn_stop.Name = "rBtn_stop";
            this.rBtn_stop.Size = new System.Drawing.Size(44, 44);
            this.rBtn_stop.TabIndex = 16;
            this.rBtn_stop.UseVisualStyleBackColor = false;
            this.rBtn_stop.Visible = false;
            this.rBtn_stop.Click += new System.EventHandler(this.rBtn_stop_Click);
            // 
            // rBtn_run
            // 
            this.rBtn_run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(96)))), ((int)(((byte)(57)))));
            this.rBtn_run.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(96)))), ((int)(((byte)(57)))));
            this.rBtn_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtn_run.ForeColor = System.Drawing.Color.Black;
            this.rBtn_run.Location = new System.Drawing.Point(88, 167);
            this.rBtn_run.Name = "rBtn_run";
            this.rBtn_run.Size = new System.Drawing.Size(44, 44);
            this.rBtn_run.TabIndex = 15;
            this.rBtn_run.UseVisualStyleBackColor = false;
            this.rBtn_run.Visible = false;
            this.rBtn_run.Click += new System.EventHandler(this.rBtn_run_Click);
            // 
            // knob_pot
            // 
            this.knob_pot.BackColor = System.Drawing.Color.White;
            this.knob_pot.ImeMode = System.Windows.Forms.ImeMode.On;
            this.knob_pot.LargeChange = 5;
            this.knob_pot.Location = new System.Drawing.Point(138, 149);
            this.knob_pot.Maximum = 25;
            this.knob_pot.Minimum = 0;
            this.knob_pot.Name = "knob_pot";
            this.knob_pot.ShowLargeScale = true;
            this.knob_pot.ShowSmallScale = false;
            this.knob_pot.Size = new System.Drawing.Size(105, 102);
            this.knob_pot.SmallChange = 1;
            this.knob_pot.TabIndex = 5;
            this.knob_pot.Value = 0;
            this.knob_pot.Visible = false;
            this.knob_pot.ValueChanged += new LGiC5_Control.SpecialControls.ValueChangedEventHandler(this.knobControl_ValueChanged);
            // 
            // FormKeyPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 577);
            this.Controls.Add(this.cb_reverse);
            this.Controls.Add(this.btn_on);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.lbl_sek);
            this.Controls.Add(this.cb_updateTime);
            this.Controls.Add(this.lbl_updateTime);
            this.Controls.Add(this.panel_keypadReadonly);
            this.Controls.Add(this.panel_keypadReadWrite);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.rBtn_stop);
            this.Controls.Add(this.rBtn_run);
            this.Controls.Add(this.knob_pot);
            this.Controls.Add(this.rtb_display);
            this.Controls.Add(this.btn_middle);
            this.Controls.Add(this.pb_drive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKeyPad";
            this.ShowIcon = false;
            this.Text = "  ";
            this.panel_keypadReadWrite.ResumeLayout(false);
            this.panel_keypadReadWrite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readWriteSection)).EndInit();
            this.panel_keypadReadonly.ResumeLayout(false);
            this.panel_keypadReadonly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_readOnlySection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_drive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SpecialControls.KnobControl knob_pot;
        private System.Windows.Forms.RichTextBox rtb_display;
        private System.Windows.Forms.Button btn_middle;
        private System.Windows.Forms.PictureBox pb_drive;
        private SpecialControls.RoundButton rBtn_run;
        private SpecialControls.RoundButton rBtn_stop;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Panel panel_keypadReadWrite;
        private System.Windows.Forms.Label lbl_readWrite;
        private System.Windows.Forms.Button btn_setComArea;
        private System.Windows.Forms.Panel panel_keypadReadonly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_readOnlySection;
        private System.Windows.Forms.DataGridView dgv_readWriteSection;
        private System.Windows.Forms.Label lbl_updateTime;
        private System.Windows.Forms.ComboBox cb_updateTime;
        private System.Windows.Forms.Label lbl_sek;
        private System.Windows.Forms.Timer timer_UpdateSections;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.CheckBox cb_reverse;
    }
}