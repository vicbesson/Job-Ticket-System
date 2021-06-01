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
    public partial class UserLogin : UserControl
    {
        private Form Parent;
        public UserLogin(Form parent)
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
                    _User user = sm.Users.Where(x => x.UserName.ToLower() == txtUser.Text.ToLower() && x.Password == password).FirstOrDefault();
                    if (user != null)
                    {
                        passed = true;
                        id = user.UserID;
                    }
                }
                if (passed)
                {
                    password = "";
                    Form f = new MainForm(false, id);
                    Parent.Hide();
                    f.ShowDialog();
                    txtPass.Text = "";
                    Parent.Show();
                }
                else
                    throw new Exception("Login Failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtPass.Text = "";
                txtUser.Text = "";
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            UserControl c = new ITLogin(Parent);
            c.Left = Parent.Width / 2 - c.Width / 2;
            c.Top = Parent.Height / 2 - c.Height / 2;
            Parent.Controls.Add(c);
            Parent.BackColor = Color.SkyBlue;
            this.Dispose();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserControl c = new UserControls.User.UserRegister(Parent);
            c.Left = this.Left;
            c.Top = this.Top;
            Parent.Controls.Add(c);
            this.Dispose();
        }
    }
}
