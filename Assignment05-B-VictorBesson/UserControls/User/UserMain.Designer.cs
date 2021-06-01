namespace Assignment05_B_VictorBesson.UserControls.User
{
    partial class UserMain
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.cbRequestType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lsRequests = new System.Windows.Forms.ListBox();
            this.rtxtCurrent = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(552, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.rtxtDescription.Location = new System.Drawing.Point(19, 373);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtDescription.Size = new System.Drawing.Size(639, 159);
            this.rtxtDescription.TabIndex = 0;
            this.rtxtDescription.Text = "";
            // 
            // cbRequestType
            // 
            this.cbRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRequestType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRequestType.FormattingEnabled = true;
            this.cbRequestType.Location = new System.Drawing.Point(418, 339);
            this.cbRequestType.Name = "cbRequestType";
            this.cbRequestType.Size = new System.Drawing.Size(240, 26);
            this.cbRequestType.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(538, 538);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 46);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Create Request:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Request Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current Request(s):";
            // 
            // lsRequests
            // 
            this.lsRequests.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsRequests.FormattingEnabled = true;
            this.lsRequests.ItemHeight = 18;
            this.lsRequests.Location = new System.Drawing.Point(19, 74);
            this.lsRequests.Name = "lsRequests";
            this.lsRequests.Size = new System.Drawing.Size(155, 220);
            this.lsRequests.TabIndex = 13;
            this.lsRequests.SelectedIndexChanged += new System.EventHandler(this.lsRequests_SelectedIndexChanged);
            // 
            // rtxtCurrent
            // 
            this.rtxtCurrent.Font = new System.Drawing.Font("Arial", 10F);
            this.rtxtCurrent.Location = new System.Drawing.Point(180, 116);
            this.rtxtCurrent.Name = "rtxtCurrent";
            this.rtxtCurrent.ReadOnly = true;
            this.rtxtCurrent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtCurrent.Size = new System.Drawing.Size(478, 178);
            this.rtxtCurrent.TabIndex = 14;
            this.rtxtCurrent.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(180, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 15;
            // 
            // lblStaff
            // 
            this.lblStaff.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(609, 93);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(0, 20);
            this.lblStaff.TabIndex = 16;
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rtxtCurrent);
            this.Controls.Add(this.lsRequests);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbRequestType);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Impact", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserMain";
            this.Size = new System.Drawing.Size(677, 595);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.ComboBox cbRequestType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsRequests;
        private System.Windows.Forms.RichTextBox rtxtCurrent;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStaff;
    }
}
