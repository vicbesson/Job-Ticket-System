using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment05_B_VictorBesson.UserControls.Staff;
using Assignment05_B_VictorBesson.UserControls.User;
namespace Assignment05_B_VictorBesson
{
    public partial class MainForm : Form
    {
        bool type;
        int id;
        public MainForm(bool type, int ID)
        {
            InitializeComponent();
            this.type = type;
            this.id = ID;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Control[] controls = this.Controls.Find("MainControl", true);
            foreach (Control c in controls)
            {
                c.Left = this.Width / 2 - c.Width / 2 - 10;
                c.Top = this.Height / 2 - c.Height / 2 - 20;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (type)
            {
                this.BackColor = Color.LightSteelBlue;
                UserControl c = new StaffMain(this, id);
                c.Left = this.Width / 2 - c.Width / 2 - 10;
                c.Top = this.Height / 2 - c.Height / 2 - 20;
                this.Controls.Add(c);
            }
            else
            {
                UserControl c = new UserMain(this, id);
                c.Left = this.Width / 2 - c.Width / 2 - 10;
                c.Top = this.Height / 2 - c.Height / 2 - 20;
                this.Controls.Add(c);
            }
        }
    }
}
