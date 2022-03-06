namespace LGiC5_Control
{
    partial class FormParameter
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
            this.lbl_parameter = new System.Windows.Forms.Label();
            this.panel_content = new System.Windows.Forms.Panel();
            this.paramsMenu = new LGiC5_Control.SpecialControls.ParametersMenu();
            this.panel_paramsMenu = new System.Windows.Forms.Panel();
            this.panel_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_parameter
            // 
            this.lbl_parameter.AutoSize = true;
            this.lbl_parameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parameter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_parameter.Location = new System.Drawing.Point(20, 17);
            this.lbl_parameter.Name = "lbl_parameter";
            this.lbl_parameter.Size = new System.Drawing.Size(160, 33);
            this.lbl_parameter.TabIndex = 11;
            this.lbl_parameter.Text = "Parameter";
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel_content.Controls.Add(this.paramsMenu);
            this.panel_content.Location = new System.Drawing.Point(26, 53);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(714, 512);
            this.panel_content.TabIndex = 15;
            // 
            // paramsMenu
            // 
            this.paramsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.paramsMenu.BtnsColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.paramsMenu.ContentColor = System.Drawing.Color.Empty;
            this.paramsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramsMenu.DRV_groupDataSource = null;
            this.paramsMenu.F_groupDataSource = null;
            this.paramsMenu.H_groupDataSource = null;
            this.paramsMenu.I_groupDataSource = null;
            this.paramsMenu.Location = new System.Drawing.Point(0, 0);
            this.paramsMenu.Name = "paramsMenu";
            this.paramsMenu.NumberOfActiveBtns = 5;
            this.paramsMenu.PressedBtn = null;
            this.paramsMenu.SectionName_1 = "DRV";
            this.paramsMenu.SectionName_2 = "F";
            this.paramsMenu.SectionName_3 = "H";
            this.paramsMenu.SectionName_4 = "I";
            this.paramsMenu.Size = new System.Drawing.Size(714, 512);
            this.paramsMenu.TabIndex = 0;
            this.paramsMenu.ContentSwitched += new System.EventHandler(this.paramsMenu_ContentSwitched);

            // 
            // panel_paramsMenu
            // 
            this.panel_paramsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_paramsMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_paramsMenu.Name = "panel_paramsMenu";
            this.panel_paramsMenu.Size = new System.Drawing.Size(765, 577);
            this.panel_paramsMenu.TabIndex = 16;
            // 
            // FormParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 577);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.lbl_parameter);
            this.Controls.Add(this.panel_paramsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormParameter";
            this.Text = "FormParameter";
            this.panel_content.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_parameter;
        private System.Windows.Forms.Panel panel_content;
        private SpecialControls.ParametersMenu paramsMenu;
        private System.Windows.Forms.Panel panel_paramsMenu;
    }
}