namespace Assignment05_B_VictorBesson.UserControls.Staff
{
    partial class AvailableRequests
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(377, 127);
            this.lblType.Name = "lblType";
            this.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblType.Size = new System.Drawing.Size(42, 16);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "label1";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(377, 8);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Location = new System.Drawing.Point(346, 67);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(84, 31);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 130);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 17);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "label1";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rtxtDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(39, 40);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtDescription.Size = new System.Drawing.Size(277, 84);
            this.rtxtDescription.TabIndex = 7;
            this.rtxtDescription.Text = "";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(3, 21);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(42, 17);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "label1";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(3, 3);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(42, 17);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "label1";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AvailableRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblType);
            this.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Name = "AvailableRequests";
            this.Size = new System.Drawing.Size(440, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
    }
}
