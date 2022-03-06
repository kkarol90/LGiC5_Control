using LGiC5_Control.SpecialControls;

namespace LGiC5_Control
{
    partial class Form1
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_chosen = new System.Windows.Forms.Panel();
            this.btn_param = new System.Windows.Forms.Button();
            this.btn_keypad = new System.Windows.Forms.Button();
            this.btn_connection = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_programName2 = new System.Windows.Forms.Label();
            this.lbl_programName = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel_mainForm = new System.Windows.Forms.Panel();
            this.panel_title = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_mainForm.SuspendLayout();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel_menu.Controls.Add(this.panel_chosen);
            this.panel_menu.Controls.Add(this.btn_param);
            this.panel_menu.Controls.Add(this.btn_keypad);
            this.panel_menu.Controls.Add(this.btn_connection);
            this.panel_menu.Controls.Add(this.panel2);
            this.panel_menu.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(186, 577);
            this.panel_menu.TabIndex = 18;
            // 
            // panel_chosen
            // 
            this.panel_chosen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel_chosen.Location = new System.Drawing.Point(0, 189);
            this.panel_chosen.Name = "panel_chosen";
            this.panel_chosen.Size = new System.Drawing.Size(3, 42);
            this.panel_chosen.TabIndex = 4;
            // 
            // btn_param
            // 
            this.btn_param.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_param.FlatAppearance.BorderSize = 0;
            this.btn_param.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_param.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_param.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_param.Image = global::LGiC5_Control.Properties.Resources.Param;
            this.btn_param.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_param.Location = new System.Drawing.Point(0, 189);
            this.btn_param.Name = "btn_param";
            this.btn_param.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_param.Size = new System.Drawing.Size(186, 42);
            this.btn_param.TabIndex = 3;
            this.btn_param.Text = "Parameters";
            this.btn_param.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_param.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_param.UseVisualStyleBackColor = true;
            this.btn_param.Click += new System.EventHandler(this.btn_param_Click);
            // 
            // btn_keypad
            // 
            this.btn_keypad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_keypad.FlatAppearance.BorderSize = 0;
            this.btn_keypad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_keypad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_keypad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_keypad.Image = global::LGiC5_Control.Properties.Resources.LG_keypad;
            this.btn_keypad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_keypad.Location = new System.Drawing.Point(0, 147);
            this.btn_keypad.Name = "btn_keypad";
            this.btn_keypad.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_keypad.Size = new System.Drawing.Size(186, 42);
            this.btn_keypad.TabIndex = 2;
            this.btn_keypad.Text = "Keypad";
            this.btn_keypad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_keypad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_keypad.UseVisualStyleBackColor = true;
            this.btn_keypad.Click += new System.EventHandler(this.btn_keypad_Click);
            // 
            // btn_connection
            // 
            this.btn_connection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_connection.FlatAppearance.BorderSize = 0;
            this.btn_connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_connection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_connection.Image = global::LGiC5_Control.Properties.Resources.ModbusLogoBlue;
            this.btn_connection.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_connection.Location = new System.Drawing.Point(0, 105);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_connection.Size = new System.Drawing.Size(186, 42);
            this.btn_connection.TabIndex = 1;
            this.btn_connection.Text = "Connection";
            this.btn_connection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_connection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_connection.UseVisualStyleBackColor = true;
            this.btn_connection.Click += new System.EventHandler(this.btn_portSetup_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_programName2);
            this.panel2.Controls.Add(this.lbl_programName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 105);
            this.panel2.TabIndex = 0;
            // 
            // lbl_programName2
            // 
            this.lbl_programName2.AutoSize = true;
            this.lbl_programName2.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_programName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_programName2.Location = new System.Drawing.Point(43, 39);
            this.lbl_programName2.Name = "lbl_programName2";
            this.lbl_programName2.Size = new System.Drawing.Size(114, 39);
            this.lbl_programName2.TabIndex = 1;
            this.lbl_programName2.Text = "Studio";
            // 
            // lbl_programName
            // 
            this.lbl_programName.AutoSize = true;
            this.lbl_programName.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_programName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_programName.Location = new System.Drawing.Point(19, 9);
            this.lbl_programName.Name = "lbl_programName";
            this.lbl_programName.Size = new System.Drawing.Size(120, 39);
            this.lbl_programName.TabIndex = 0;
            this.lbl_programName.Text = "Drives";
            // 
            // panelContent
            // 
            this.panelContent.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(765, 577);
            this.panelContent.TabIndex = 19;
            // 
            // panel_mainForm
            // 
            this.panel_mainForm.Controls.Add(this.splitContainer1);
            this.panel_mainForm.Controls.Add(this.panel_title);
            this.panel_mainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainForm.Location = new System.Drawing.Point(0, 0);
            this.panel_mainForm.Name = "panel_mainForm";
            this.panel_mainForm.Size = new System.Drawing.Size(952, 600);
            this.panel_mainForm.TabIndex = 0;
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.panel_title.Controls.Add(this.button1);
            this.panel_title.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(952, 23);
            this.panel_title.TabIndex = 0;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            this.panel_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseMove);
            this.panel_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseUp);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 23);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel_menu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelContent);
            this.splitContainer1.Size = new System.Drawing.Size(952, 577);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(931, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 16);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(952, 600);
            this.Controls.Add(this.panel_mainForm);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Drive";
            this.panel_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_mainForm.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.Button btn_param;
        private System.Windows.Forms.Button btn_keypad;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lbl_programName;
        private System.Windows.Forms.Panel panel_chosen;
        private System.Windows.Forms.Label lbl_programName2;
        private System.Windows.Forms.Panel panel_mainForm;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
    }
}

