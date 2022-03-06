namespace LGiC5_Control
{
    partial class ParamsDisplayBox
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
            this.panel_displaySettings = new System.Windows.Forms.Panel();
            this.panel_settersDisplay = new System.Windows.Forms.Panel();
            this.cb_changeable = new System.Windows.Forms.CheckBox();
            this.cb_min = new System.Windows.Forms.CheckBox();
            this.cb_max = new System.Windows.Forms.CheckBox();
            this.cb_unit = new System.Windows.Forms.CheckBox();
            this.cb_default = new System.Windows.Forms.CheckBox();
            this.cb_defaultVal = new System.Windows.Forms.CheckBox();
            this.cb_address = new System.Windows.Forms.CheckBox();
            this.lbl_displayParams = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel_displaySettings.SuspendLayout();
            this.panel_settersDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_displaySettings
            // 
            this.panel_displaySettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel_displaySettings.Controls.Add(this.panel_settersDisplay);
            this.panel_displaySettings.Controls.Add(this.lbl_displayParams);
            this.panel_displaySettings.Controls.Add(this.btn_ok);
            this.panel_displaySettings.Controls.Add(this.btn_cancel);
            this.panel_displaySettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_displaySettings.Location = new System.Drawing.Point(2, 2);
            this.panel_displaySettings.Name = "panel_displaySettings";
            this.panel_displaySettings.Size = new System.Drawing.Size(296, 281);
            this.panel_displaySettings.TabIndex = 0;
            // 
            // panel_settersDisplay
            // 
            this.panel_settersDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel_settersDisplay.Controls.Add(this.cb_changeable);
            this.panel_settersDisplay.Controls.Add(this.cb_min);
            this.panel_settersDisplay.Controls.Add(this.cb_max);
            this.panel_settersDisplay.Controls.Add(this.cb_unit);
            this.panel_settersDisplay.Controls.Add(this.cb_default);
            this.panel_settersDisplay.Controls.Add(this.cb_defaultVal);
            this.panel_settersDisplay.Controls.Add(this.cb_address);
            this.panel_settersDisplay.Location = new System.Drawing.Point(12, 48);
            this.panel_settersDisplay.Name = "panel_settersDisplay";
            this.panel_settersDisplay.Size = new System.Drawing.Size(265, 189);
            this.panel_settersDisplay.TabIndex = 4;
            // 
            // cb_changeable
            // 
            this.cb_changeable.AutoSize = true;
            this.cb_changeable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_changeable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cb_changeable.Location = new System.Drawing.Point(4, 160);
            this.cb_changeable.Name = "cb_changeable";
            this.cb_changeable.Size = new System.Drawing.Size(193, 20);
            this.cb_changeable.TabIndex = 6;
            this.cb_changeable.Text = "Changeable during work";
            this.cb_changeable.UseVisualStyleBackColor = true;
            // 
            // cb_min
            // 
            this.cb_min.AutoSize = true;
            this.cb_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cb_min.Location = new System.Drawing.Point(4, 134);
            this.cb_min.Name = "cb_min";
            this.cb_min.Size = new System.Drawing.Size(50, 20);
            this.cb_min.TabIndex = 5;
            this.cb_min.Text = "Min";
            this.cb_min.UseVisualStyleBackColor = true;
            // 
            // cb_max
            // 
            this.cb_max.AutoSize = true;
            this.cb_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cb_max.Location = new System.Drawing.Point(4, 108);
            this.cb_max.Name = "cb_max";
            this.cb_max.Size = new System.Drawing.Size(54, 20);
            this.cb_max.TabIndex = 4;
            this.cb_max.Text = "Max";
            this.cb_max.UseVisualStyleBackColor = true;
            // 
            // cb_unit
            // 
            this.cb_unit.AutoSize = true;
            this.cb_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_unit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cb_unit.Location = new System.Drawing.Point(4, 82);
            this.cb_unit.Name = "cb_unit";
            this.cb_unit.Size = new System.Drawing.Size(53, 20);
            this.cb_unit.TabIndex = 3;
            this.cb_unit.Text = "Unit";
            this.cb_unit.UseVisualStyleBackColor = true;
            // 
            // cb_default
            // 
            this.cb_default.AutoSize = true;
            this.cb_default.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cb_default.Location = new System.Drawing.Point(4, 56);
            this.cb_default.Name = "cb_default";
            this.cb_default.Size = new System.Drawing.Size(79, 20);
            this.cb_default.TabIndex = 2;
            this.cb_default.Text = "Default ";
            this.cb_default.UseVisualStyleBackColor = true;
            // 
            // cb_defaultVal
            // 
            this.cb_defaultVal.AutoSize = true;
            this.cb_defaultVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_defaultVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cb_defaultVal.Location = new System.Drawing.Point(4, 30);
            this.cb_defaultVal.Name = "cb_defaultVal";
            this.cb_defaultVal.Size = new System.Drawing.Size(117, 20);
            this.cb_defaultVal.TabIndex = 1;
            this.cb_defaultVal.Text = "Default value";
            this.cb_defaultVal.UseVisualStyleBackColor = true;
            // 
            // cb_address
            // 
            this.cb_address.AutoSize = true;
            this.cb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.cb_address.Location = new System.Drawing.Point(4, 4);
            this.cb_address.Name = "cb_address";
            this.cb_address.Size = new System.Drawing.Size(84, 20);
            this.cb_address.TabIndex = 0;
            this.cb_address.Text = "Address";
            this.cb_address.UseVisualStyleBackColor = true;
            // 
            // lbl_displayParams
            // 
            this.lbl_displayParams.AutoSize = true;
            this.lbl_displayParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_displayParams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_displayParams.Location = new System.Drawing.Point(8, 14);
            this.lbl_displayParams.Name = "lbl_displayParams";
            this.lbl_displayParams.Size = new System.Drawing.Size(269, 20);
            this.lbl_displayParams.TabIndex = 3;
            this.lbl_displayParams.Text = "Displaying additional information";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btn_ok.FlatAppearance.BorderSize = 2;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btn_ok.Location = new System.Drawing.Point(63, 244);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(70, 30);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Accept";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btn_cancel.FlatAppearance.BorderSize = 2;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.btn_cancel.Location = new System.Drawing.Point(164, 244);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 30);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ParamsDisplayBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(300, 285);
            this.Controls.Add(this.panel_displaySettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParamsDisplayBox";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.panel_displaySettings.ResumeLayout(false);
            this.panel_displaySettings.PerformLayout();
            this.panel_settersDisplay.ResumeLayout(false);
            this.panel_settersDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_displaySettings;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_displayParams;
        private System.Windows.Forms.Panel panel_settersDisplay;
        private System.Windows.Forms.CheckBox cb_max;
        private System.Windows.Forms.CheckBox cb_unit;
        private System.Windows.Forms.CheckBox cb_default;
        private System.Windows.Forms.CheckBox cb_defaultVal;
        private System.Windows.Forms.CheckBox cb_address;
        private System.Windows.Forms.CheckBox cb_changeable;
        private System.Windows.Forms.CheckBox cb_min;
    }
}