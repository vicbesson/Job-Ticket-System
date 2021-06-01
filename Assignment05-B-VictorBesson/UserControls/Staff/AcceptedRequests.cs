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
namespace Assignment05_B_VictorBesson.UserControls.Staff
{
    public partial class AcceptedRequests : UserControl
    {
        private Panel parent;
        private int requestID;
        private int staffID;
        public AcceptedRequests(int requestID, Panel parent, int staffID)
        {
            InitializeComponent();
            this.parent = parent;
            this.requestID = requestID;
            this.staffID = staffID;
            LoadRequests();
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
        private void LoadRequests()
        {
            using (SuperModel sm = new SuperModel())
            {
                _Request request = sm.Requests.Where(x => x.RequestID == this.requestID).FirstOrDefault();
                _RequestType requestType = sm.RequestTypes.Where(x => x.RequestTypeID == request.RequestTypeID).FirstOrDefault();
                _User user = sm.Users.Where(x => x.UserID == request.UserID).FirstOrDefault();
                if (request.RequestStatusID == 3)
                    btnAccept.Text = "Complete";
                lblDate.Text = $"Accepted: {request.RequestAccepted.ToString()}";
                lblID.Text = $"ID: {requestID.ToString()}";
                lblType.Text = requestType.RequestType;
                lblDate.Left = parent.Width - lblDate.Width - 20;
                lblType.Left = parent.Width - lblType.Width - 20;
                lblFirstName.Text = user.FirstName.First().ToString().ToUpper() + user.FirstName.Substring(1);
                lblLastName.Text = user.LastName.First().ToString().ToUpper() + user.LastName.Substring(1);
                rtxtDescription.Text = request.RequestDescription;
                cbPriority.DisplayMember = "Description";
                cbPriority.ValueMember = "PriorityID";
                cbPriority.DataSource = sm.Priorities.ToList();
                cbPriority.SelectedValue = request.PriorityID;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                switch (((Button)sender).Text)
                {
                    case "Begin":
                        ((Button)sender).Text = "Complete";
                        using (SuperModel sm = new SuperModel())
                        {
                            _Request request = sm.Requests.Where(x => x.RequestID == this.requestID).FirstOrDefault();
                            request.RequestStatusID = 3;
                            sm.SaveChanges();
                        }
                        break;
                    case "Complete":
                        using (SuperModel sm = new SuperModel())
                        {
                            _Request request = sm.Requests.Where(x => x.RequestID == this.requestID).FirstOrDefault();
                            request.RequestCompleted = DateTime.Now;
                            request.RequestStatusID = 4;
                            sm.SaveChanges();
                        }
                        this.parent.Controls.Remove(this);
                        this.Dispose();
                        ResizePanel();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Changes can not be made, database not found");
            }
        }

        private void ResizePanel()
        {
            if (parent.Controls.Count < 4)
            {
                foreach (Control c in parent.Controls)
                {
                    int val = c.Width;
                    c.Width = parent.Width;
                    Control[] control = c.Controls.Find("rtxtDescription", true);
                    foreach (Control tmp in control)
                    {
                        tmp.Width += c.Width - val;
                    }
                }
                parent.AutoScroll = false;
                parent.VerticalScroll.Enabled = false;
                parent.HorizontalScroll.Enabled = false;
                parent.AutoScroll = true;
            }
        }
        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                using (SuperModel sm = new SuperModel())
                {
                    _Request request = sm.Requests.Where(x => x.RequestID == this.requestID).FirstOrDefault();
                    request.PriorityID = (int)cbPriority.SelectedValue;
                    sm.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Changes can not be made, database not found");
            }
        }
    }
}
