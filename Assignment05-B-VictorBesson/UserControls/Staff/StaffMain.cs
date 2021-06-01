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
    public partial class StaffMain : UserControl
    {
        private Form parent;
        private int staffID;
        public StaffMain(Form parent, int id)
        {
            InitializeComponent();
            this.Name = "MainControl";
            this.parent = parent;
            this.staffID = id;
            if (TestConnection())
            {
                LoadAvailableRequests();
                LoadAcceptedRequests();
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
        private void LoadAvailableRequests()
        {
            using (SuperModel sm = new SuperModel())
            {
                _IT_Member member = sm.IT_Staff.Where(x => x.StaffID == this.staffID).FirstOrDefault();
                _RequestType requestType = sm.RequestTypes.Where(x => x.SpecialtyID == member.SpecialtyID).FirstOrDefault();
                List<_Request> requests;
                if (member.SpecialtyID == 3)
                    requests = sm.Requests.Where(x => x.RequestStatusID == 1).ToList();
                else
                    requests = sm.Requests.Where(x => x.RequestStatusID == 1 && x.RequestTypeID == requestType.RequestTypeID).ToList();
                foreach (_Request request in requests)
                {
                    AvailableRequests ar = new AvailableRequests(request.RequestID,
                        pnAvailableRequests,
                        this.staffID);
                    pnAvailableRequests.Controls.Add(ar);
                }
            }
            ResizePanel(pnAvailableRequests);
        }
        private void LoadAcceptedRequests()
        {
            using (SuperModel sm = new SuperModel())
            {
                List<_Request> requests = sm.Requests.Where(x => x.StaffID == staffID && x.RequestCompleted == null).OrderByDescending(x => x.RequestStatusID).ThenBy(x => x.PriorityID).ToList();
                foreach(_Request request in requests)
                {
                    AcceptedRequests ar = new AcceptedRequests(request.RequestID,
                         pnAcceptedRequests,
                         this.staffID);
                    pnAcceptedRequests.Controls.Add(ar);
                }
            }
            ResizePanel(pnAcceptedRequests);
        }
        private void ResizePanel(Panel pn)
        {
            if (pn.Controls.Count < 4)
            {
                foreach (Control c in pn.Controls)
                {
                    int val = c.Width;
                    c.Width = pn.Width;
                    Control[] control = c.Controls.Find("rtxtDescription", true);
                    foreach (Control tmp in control)
                    {
                        tmp.Width += c.Width - val;
                    }
                }
                pn.AutoScroll = false;
                pn.VerticalScroll.Enabled = false;
                pn.HorizontalScroll.Enabled = false;
                pn.AutoScroll = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.parent.Close();
        }
    }
}
