namespace Assignment05_B_VictorBesson.UserControls.Staff
{
    partial class StaffMain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnAvailableRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.pnAcceptedRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnAvailableRequests
            // 
            this.pnAvailableRequests.AutoScroll = true;
            this.pnAvailableRequests.BackColor = System.Drawing.Color.SteelBlue;
            this.pnAvailableRequests.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnAvailableRequests.Location = new System.Drawing.Point(18, 74);
            this.pnAvailableRequests.MaximumSize = new System.Drawing.Size(460, 618);
            this.pnAvailableRequests.Name = "pnAvailableRequests";
            this.pnAvailableRequests.Size = new System.Drawing.Size(460, 536);
            this.pnAvailableRequests.TabIndex = 0;
            this.pnAvailableRequests.WrapContents = false;
            // 
            // pnAcceptedRequests
            // 
            this.pnAcceptedRequests.AutoScroll = true;
            this.pnAcceptedRequests.BackColor = System.Drawing.Color.LightBlue;
            this.pnAcceptedRequests.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnAcceptedRequests.Location = new System.Drawing.Point(486, 74);
            this.pnAcceptedRequests.MaximumSize = new System.Drawing.Size(460, 618);
            this.pnAcceptedRequests.Name = "pnAcceptedRequests";
            this.pnAcceptedRequests.Size = new System.Drawing.Size(460, 536);
            this.pnAcceptedRequests.TabIndex = 1;
            this.pnAcceptedRequests.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Accepted Requests";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(850, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // StaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnAcceptedRequests);
            this.Controls.Add(this.pnAvailableRequests);
            this.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StaffMain";
            this.Size = new System.Drawing.Size(970, 622);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnAvailableRequests;
        private System.Windows.Forms.FlowLayoutPanel pnAcceptedRequests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
    }
}
