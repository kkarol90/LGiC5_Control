using DriveControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LGiC5_Control.SpecialControls
{
    public partial class ParametersMenu : UserControl
    {
        public event EventHandler ContentSwitched;
        private int numberOfActiveBtns = 10;
        List<Button> actionButtons;
        public ParametersMenu()
        {
            InitializeComponent();
            actionButtons = new List<Button>();
        }
        public List<Button> ActionButtons
        {
            get => actionButtons;
            private set => actionButtons = value;
        }
        public List<Register> DRV_groupDataSource { get; set; }
        public List<Register> F_groupDataSource { get; set; }
        public List<Register> H_groupDataSource { get; set; }
        public List<Register> I_groupDataSource { get; set; }
        public Button PressedBtn { get; set; }
        public Color ContentColor { get; set; }
        public Color BtnsColor { get; set; }
        public string SectionName_1 { get => btn_drvGroup.Text; set => btn_drvGroup.Text = value; }
        public string SectionName_2 { get => btn_fGroup.Text; set => btn_fGroup.Text = value; }
        public string SectionName_3 { get => btn_hGroup.Text; set => btn_hGroup.Text = value; }
        public string SectionName_4 { get => btn_iGroup.Text; set => btn_iGroup.Text = value; }
        public int NumberOfActiveBtns 
        { 
            get => numberOfActiveBtns; 
            set 
            { 
                if(0 < value && value <= 10)
                {
                    numberOfActiveBtns = value;
                    ActionButtons.Clear();
                    foreach (var item in panel_actions.Controls)
                    {
                        Button btn = (Button)item;
                        if (btn.TabIndex <= value)
                        {
                            btn.Visible = true;
                            btn.Width = panel_actions.Width / value;
                            btn.Enabled = true;
                            //ActionButtons.Add(btn);
                            ActionButtons.Insert(0, btn);
                        }
                        else
                        {
                            btn.Visible = false;
                            btn.Width = 0;
                            btn.Enabled = false;
                        }
                    }
                    numberOfActiveBtns = value;                   
                }               
            } 
        }

        protected virtual void OnContentSwitched(EventArgs e)
        {
            ContentSwitched?.Invoke(this, e);
        }
        private void panel_buttons_SizeChanged(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            int width = pnl.Width / 4;
            btn_drvGroup.Width = width;
            btn_fGroup.Width = width;
            btn_hGroup.Width = width;
            btn_iGroup.Width = pnl.Width - (3 * width);   
        }
        private void panel_actions_SizeChanged(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            int width = pnl.Width / NumberOfActiveBtns;
            foreach (var item in panel_actions.Controls)
            {
                Button btn = (Button)item;
                btn.Width = width;
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!btn.Equals(PressedBtn))
            {
                if (PressedBtn != null) PressedBtn.BackColor = BtnsColor;
                btn.BackColor = ContentColor;
                PressedBtn = btn;           
                switch(btn.Name)
                {
                    case "btn_drvGroup":
                        this.dgv_content.DataSource = DRV_groupDataSource;
                        break;
                    case "btn_fGroup":
                        this.dgv_content.DataSource = F_groupDataSource;
                        break;
                    case "btn_hGroup":
                        this.dgv_content.DataSource = H_groupDataSource;
                        break;
                    case "btn_iGroup":
                        this.dgv_content.DataSource = I_groupDataSource;
                        break;
                }
                OnContentSwitched(EventArgs.Empty);
                
                //RefreshValue();
            }
        }
        
        public void DataSource(List<Register> drv, List<Register> f, List<Register> h, List<Register> i)
        {
            DRV_groupDataSource = drv;
            F_groupDataSource = f;
            H_groupDataSource = h;
            I_groupDataSource = i;        
        }

        public void RefreshValue()
        {
            if (dgv_content.DataSource == null) return;
            dgv_content.InvalidateColumn(dgv_content.Columns["Value"].Index);
            dgv_content.Update();
        }
        
        public DataGridView GetDGV()
        {
            return dgv_content;
        }
        
    }
}
