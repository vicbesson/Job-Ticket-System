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
    public partial class UserMain : UserControl
    {
        private Form parent;
        private int userID;
        public UserMain(Form parent, int userID)
        {
            InitializeComponent();
            this.Name = "MainControl";
            this.parent = parent;
            this.userID = userID;
            LoadRequests();
        }

        private void LoadRequests()
        {
            using (SuperModel sm = new SuperModel())
            {
                cbRequestType.ValueMember = "RequestTypeID";
                cbRequestType.DisplayMember = "RequestType";
                cbRequestType.DataSource = sm.RequestTypes.ToList();
                lsRequests.DisplayMember = "RequestID";
                lsRequests.ValueMember = "RequestID";
                lsRequests.DataSource = sm.Requests.Where(x => x.UserID == this.userID && x.RequestStatusID != 4).ToList();
            }
        }

        private bool TestConnection()
        {
            using (SuperModel sm = new SuperModel())
            {
                if (sm.Database.Exists())
                    return true;
                else
                    return false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.parent.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbRequestType.SelectedIndex < 0)
                    throw new Exception("Must choose request type");
                using (SuperModel sm = new SuperModel())
                {
                    _Request request = new _Request()
                    {
                        UserID = this.userID,
                        RequestTypeID = (int)cbRequestType.SelectedValue,
                        RequestDescription = rtxtDescription.Text,
                        RequestCreated = DateTime.Now,
                        PriorityID = 3,
                        RequestStatusID = 1
                    };
                    sm.Requests.Add(request);
                    sm.SaveChanges();
                    rtxtDescription.Text = "";
                    cbRequestType.SelectedIndex = 0;
                    LoadRequests();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lsRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                using (SuperModel sm = new SuperModel())
                {
                    _Request request = sm.Requests.Where(x => x.RequestID == (int)lsRequests.SelectedValue).FirstOrDefault();
                    _RequestStatus requestStatus = sm.RequestStatuses.Where(x => x.RequestStatusID == request.RequestStatusID).FirstOrDefault();
                    _IT_Member member = sm.IT_Staff.Where(x => x.StaffID == request.StaffID).FirstOrDefault();
                    rtxtCurrent.Text = request.RequestDescription;
                    if (requestStatus.RequestStatus == "Available")
                        lblStatus.Text = "Open";
                    else
                        lblStatus.Text = requestStatus.RequestStatus;
                    if (request.StaffID != null)
                    {
                        lblStaff.Text = $"{member.FirstName.First().ToString().ToUpper() + member.FirstName.Substring(1)} {member.LastName.First().ToString().ToUpper() + member.LastName.Substring(1)}";
                        lblStaff.Left = this.Width - lblStaff.Width - 30;
                    }
                }
            }
            else
                MessageBox.Show("Cannot connect to database");
        }
    }
}
