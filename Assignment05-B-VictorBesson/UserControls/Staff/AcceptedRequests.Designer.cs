namespace Assignment05_B_VictorBesson.UserControls.Staff
{
    partial class AcceptedRequests
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
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(37, 39);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtDescription.Size = new System.Drawing.Size(277, 84);
            this.rtxtDescription.TabIndex = 13;
            this.rtxtDescription.Text = "";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(4, 128);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 17);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "label1";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Location = new System.Drawing.Point(325, 86);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(105, 31);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Begin";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(375, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 16);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(375, 125);
            this.lblType.Name = "lblType";
            this.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblType.Size = new System.Drawing.Size(42, 16);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "label1";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(42, 17);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "label1";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPriority
            // 
            this.cbPriority.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(326, 50);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(105, 23);
            this.cbPriority.TabIndex = 14;
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Priority";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(4, 18);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(42, 17);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "label1";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AcceptedRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Impact", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Name = "AcceptedRequests";
            this.Size = new System.Drawing.Size(440, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastName;
    }
}
