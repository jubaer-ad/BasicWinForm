namespace WinFormSignUp
{
    partial class SignUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.grpBoxServices = new System.Windows.Forms.GroupBox();
            this.lblTransactionReports = new System.Windows.Forms.Label();
            this.lblSMS = new System.Windows.Forms.Label();
            this.chkBoxTransactionReport = new System.Windows.Forms.CheckBox();
            this.chkBoxReports = new System.Windows.Forms.CheckBox();
            this.chkBoxSMS = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.grpBoxServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(57, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(197, 29);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(57, 85);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(197, 29);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(57, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(197, 29);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFirstName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(260, 35);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(458, 29);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(260, 85);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(458, 29);
            this.txtBoxLastName.TabIndex = 1;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmail.Location = new System.Drawing.Point(260, 135);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(458, 29);
            this.txtBoxEmail.TabIndex = 1;
            // 
            // grpBoxServices
            // 
            this.grpBoxServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxServices.Controls.Add(this.lblTransactionReports);
            this.grpBoxServices.Controls.Add(this.lblSMS);
            this.grpBoxServices.Controls.Add(this.chkBoxTransactionReport);
            this.grpBoxServices.Controls.Add(this.chkBoxReports);
            this.grpBoxServices.Controls.Add(this.chkBoxSMS);
            this.grpBoxServices.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxServices.Location = new System.Drawing.Point(57, 204);
            this.grpBoxServices.Name = "grpBoxServices";
            this.grpBoxServices.Size = new System.Drawing.Size(661, 251);
            this.grpBoxServices.TabIndex = 2;
            this.grpBoxServices.TabStop = false;
            this.grpBoxServices.Text = "Services";
            // 
            // lblTransactionReports
            // 
            this.lblTransactionReports.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionReports.Location = new System.Drawing.Point(371, 179);
            this.lblTransactionReports.Name = "lblTransactionReports";
            this.lblTransactionReports.Size = new System.Drawing.Size(284, 23);
            this.lblTransactionReports.TabIndex = 1;
            this.lblTransactionReports.Text = ".....................";
            // 
            // lblSMS
            // 
            this.lblSMS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMS.ForeColor = System.Drawing.Color.Black;
            this.lblSMS.Location = new System.Drawing.Point(368, 59);
            this.lblSMS.Name = "lblSMS";
            this.lblSMS.Size = new System.Drawing.Size(287, 23);
            this.lblSMS.TabIndex = 1;
            this.lblSMS.Text = ".....................";
            // 
            // chkBoxTransactionReport
            // 
            this.chkBoxTransactionReport.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxTransactionReport.Location = new System.Drawing.Point(92, 161);
            this.chkBoxTransactionReport.Name = "chkBoxTransactionReport";
            this.chkBoxTransactionReport.Size = new System.Drawing.Size(270, 52);
            this.chkBoxTransactionReport.TabIndex = 0;
            this.chkBoxTransactionReport.Text = "Transaction Reports";
            this.chkBoxTransactionReport.UseVisualStyleBackColor = true;
            this.chkBoxTransactionReport.CheckedChanged += new System.EventHandler(this.chkBoxTransactionReport_CheckedChanged);
            // 
            // chkBoxReports
            // 
            this.chkBoxReports.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxReports.Location = new System.Drawing.Point(92, 103);
            this.chkBoxReports.Name = "chkBoxReports";
            this.chkBoxReports.Size = new System.Drawing.Size(270, 52);
            this.chkBoxReports.TabIndex = 0;
            this.chkBoxReports.Text = "Reports";
            this.chkBoxReports.UseVisualStyleBackColor = true;
            this.chkBoxReports.CheckedChanged += new System.EventHandler(this.chkBoxReports_CheckedChanged);
            // 
            // chkBoxSMS
            // 
            this.chkBoxSMS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxSMS.Location = new System.Drawing.Point(92, 45);
            this.chkBoxSMS.Name = "chkBoxSMS";
            this.chkBoxSMS.Size = new System.Drawing.Size(270, 52);
            this.chkBoxSMS.TabIndex = 0;
            this.chkBoxSMS.Text = "SMS Notifications";
            this.chkBoxSMS.UseVisualStyleBackColor = true;
            this.chkBoxSMS.CheckedChanged += new System.EventHandler(this.chkBoxSMS_CheckedChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(721, 466);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(140, 51);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(873, 529);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.grpBoxServices);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "SignUp";
            this.grpBoxServices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSMS;
        private System.Windows.Forms.Label lblTransactionReports;
        private System.Windows.Forms.Button btnSignUp;

        private System.Windows.Forms.CheckBox chkBoxReports;
        private System.Windows.Forms.CheckBox chkBoxTransactionReport;

        private System.Windows.Forms.CheckBox chkBoxSMS;

        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.GroupBox grpBoxServices;

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxFirstName;

        private System.Windows.Forms.Label lblFirstName;

        #endregion
    }
}