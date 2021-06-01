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
namespace Assignment05_B_VictorBesson.UserControls.User
{
    public partial class UserRegister : UserControl
    {
        Form Parent;
        public UserRegister(Form parent)
        {
            InitializeComponent();
            this.Name = "LoginControl";
            this.Parent = parent;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCUser.Text.ToLower() != txtUser.Text.ToLower())
                    throw new Exception("Usernames do not match");
                if (txtEmail.Text.ToLower() != txtCEmail.Text.ToLower())
                    throw new Exception("Emails do not match");
                if (txtPass.Text != txtCPass.Text)
                    throw new Exception("Passwords do not match");
                if(txtUser.Text.Trim() == "")
                    throw new Exception("Must have a username");
                if (txtPass.Text.Trim() == "")
                    throw new Exception("Must have a password");
                if (txtEmail.Text.Trim() == "")
                    throw new Exception("Must have an email");
                if (txtCountry.Text.Trim() == "")
                    throw new Exception("Must enter a country");
                if (txtCity.Text.Trim() == "")
                    throw new Exception("Must enter a city");
                using (SuperModel sm = new SuperModel())
                {
                    _User user = sm.Users.Where(x => x.UserName.ToLower() == txtUser.Text.ToLower() || x.Email.ToLower() == txtEmail.Text.ToLower()).FirstOrDefault();
                    if (user == null)
                    {
                        user = new _User()
                        {
                            UserName = txtUser.Text.ToLower(),
                            FirstName = txtFirst.Text.ToLower(),
                            LastName = txtLast.Text.ToLower(),
                            Country = txtCountry.Text.ToLower(),
                            City = txtCity.Text.ToLower(),
                            Email = txtEmail.Text.ToLower(),
                            Password = md5hasher.GetMd5Hash(txtPass.Text),
                            JoinDate = DateTime.Now
                        };
                        sm.Users.Add(user);
                        sm.SaveChanges();
                        Parent.Controls.Remove(this);
                        UserControl c = new UserLogin(Parent);
                        c.Left = this.Left;
                        c.Top = this.Top;
                        Parent.Controls.Add(c);
                        MessageBox.Show("User Registered!");
                        this.Dispose();
                    }
                    else
                        throw new Exception("Username or email is already taken");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            UserControl c = new UserLogin(Parent);
            c.Left = this.Left;
            c.Top = this.Top;
            Parent.Controls.Add(c);
            this.Dispose();
        }
    }
}
