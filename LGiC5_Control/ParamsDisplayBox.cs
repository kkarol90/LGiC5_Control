﻿using System;
using System.Windows.Forms;

namespace LGiC5_Control
{
    public partial class ParamsDisplayBox : Form
    {
        public static EventHandler ButtonAcceptClick;
        static ParamsDisplayBox displayBox;
        static bool[] selections;

        public ParamsDisplayBox()
        {
            InitializeComponent(); 
        }

        public static bool[] Selections { get => selections; set => selections = value; }

        public static void ShowDisplaySettings(Form form)
        {
            if (displayBox != null) return;
            try
            {
                displayBox = new ParamsDisplayBox();
                for (int i = displayBox.panel_settersDisplay.Controls.Count-1; i >=0 ; i--)
                {
                    CheckBox cb = (CheckBox)displayBox.panel_settersDisplay.Controls[i];
                    cb.Checked = Selections[i];
                }

                displayBox.CenterToScreen();
                displayBox.ShowDialog(form);

            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show($"{e.Message}.Try restart aplication.");
            }
            
        }
        private void OnButtonAcceptClick(EventArgs e)
        {
            ButtonAcceptClick?.Invoke(this, e);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            displayBox.Dispose();
            displayBox = null;
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = displayBox.panel_settersDisplay.Controls.Count - 1; i >= 0; i--)
                {
                    CheckBox cb = (CheckBox)displayBox.panel_settersDisplay.Controls[i];
                    Selections[i] = cb.Checked;
                }
                OnButtonAcceptClick(EventArgs.Empty);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show($"{ex.Message}.Try restart aplication.");
            }
            finally
            {
                this.Close();
                displayBox.Dispose();
                displayBox = null;
            }            
        }
    }
}
