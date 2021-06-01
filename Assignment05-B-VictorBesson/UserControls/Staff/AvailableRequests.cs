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
    public partial class AvailableRequests : UserControl
    {
        private Panel parent;
        private int requestID;
        private int staffID;
        public AvailableRequests(int requestID, Panel parent, int staffID)
        {
            InitializeComponent();
            this.parent = parent;
            this.staffID = staffID;
            this.requestID = requestID;
            LoadRequest();
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
        private void LoadRequest()
        {
            using (SuperModel sm = new SuperModel())
            {
                _Request request = sm.Requests.Where(x => x.RequestID == this.requestID).FirstOrDefault();
                _RequestType requestType = sm.RequestTypes.Where(x => x.RequestTypeID == request.RequestTypeID).FirstOrDefault();
                _User user = sm.Users.Where(x => x.UserID == request.UserID).FirstOrDefault();
                lblDate.Text = $"Created: {request.RequestCreated.ToString()}";
                lblID.Text = $"ID: {requestID.ToString()}";
                lblType.Text = requestType.RequestType;
                lblDate.Left = parent.Width - lblDate.Width - 20;
                lblType.Left = parent.Width - lblType.Width - 20;
                lblFirstName.Text = user.FirstName.First().ToString().ToUpper() + user.FirstName.Substring(1);
                lblLastName.Text = user.LastName.First().ToString().ToUpper() + user.LastName.Substring(1);
                rtxtDescription.Text = request.RequestDescription;
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                using (SuperModel sm = new SuperModel())
                {
                    _Request request = sm.Requests.Where(x => x.RequestID == requestID).FirstOrDefault();
                    if (request != null)
                    {
                        request.RequestStatusID = 2;
                        request.StaffID = this.staffID;
                        request.RequestAccepted = DateTime.Now;
                        sm.SaveChanges();
                        AddAccepted();
                    }
                }
                this.parent.Controls.Remove(this);
                this.Dispose();
                ResizePanel();
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
                    c.Width = parent.Width;
                parent.AutoScroll = false;
                parent.VerticalScroll.Enabled = false;
                parent.HorizontalScroll.Enabled = false;
                parent.AutoScroll = true;
            }
        }
        private void AddAccepted()
        {
            Control[] panel = this.parent.Parent.Controls.Find("pnAcceptedRequests", true);
            foreach (Control c in panel)
            {
                AcceptedRequests ar = new AcceptedRequests(this.requestID, (Panel)c, this.staffID);
                ar.Width = c.Width;
                c.Controls.Add(ar);
                if (c.Controls.Count >= 4)
                {
                    foreach (Control accepted in c.Controls)
                    {
                        int val = accepted.Width;
                        accepted.Width = 440;
                        Control[] txt = accepted.Controls.Find("rtxtDescription", true);
                        foreach (Control text in txt)
                        {
                            text.Width -= val - accepted.Width;
                        }
                    }
                    ((Panel)c).AutoScroll = false;
                    ((Panel)c).VerticalScroll.Enabled = true;
                    ((Panel)c).HorizontalScroll.Enabled = true;
                    ((Panel)c).AutoScroll = true;
                }
            }
        }
    }
}
