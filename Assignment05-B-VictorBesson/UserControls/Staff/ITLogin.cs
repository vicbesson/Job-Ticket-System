using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment05_B_VictorBesson.DAL;
using Assignment05_B_VictorBesson.DataTables;
namespace Assignment05_B_VictorBesson
{
    public partial class ITLogin : UserControl
    {
        private Form Parent;
        public ITLogin(Form parent)
        {
            InitializeComponent();
            this.Parent = parent;
            this.Name = "LoginControl";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = md5hasher.GetMd5Hash(txtPass.Text);
            bool passed = false;
            int id = 0;
            try
            {
                using (SuperModel sm = new SuperModel())
                {
                    _IT_Member mem = sm.IT_Staff.Where(x => x.UserName.ToLower() == txtUser.Text.ToLower() && x.Password == password).FirstOrDefault();
                    if (mem != null)
                    {
                        passed = true;
                        id = mem.StaffID;
                    }
                }
                if (passed)
                {
                    password = "";
                    Form f = new MainForm(true, id);
                    Parent.Hide();
                    f.ShowDialog();
                    txtPass.Text = "";
                    Parent.Show();
                }
                else
                    throw new Exception("Login Failed");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtPass.Text = "";
                txtUser.Text = "";
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            UserControl c = new UserLogin(Parent);
            c.Left = Parent.Width / 2 - c.Width / 2;
            c.Top = Parent.Height / 2 - c.Height / 2;
            Parent.Controls.Add(c);
            Parent.BackColor = Color.Orange;
            this.Dispose();
        }
    }
}
