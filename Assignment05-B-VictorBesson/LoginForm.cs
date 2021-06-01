using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment05_B_VictorBesson
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserControl login = new UserLogin(this);
            login.Top = this.Height / 2 - login.Height / 2;
            login.Left = this.Width / 2 - login.Width / 2;
            this.Controls.Add(login);
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            Control[] controls = this.Controls.Find("LoginControl", true);
            foreach(Control c in controls)
            {
                c.Left = this.Width / 2 - c.Width / 2;
                c.Top = this.Height / 2 - c.Height / 2;
            }
        }
    }
}
