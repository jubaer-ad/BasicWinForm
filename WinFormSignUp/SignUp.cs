using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSignUp
{
    public partial class SignUp : Form
    {
        public static string fName;
        public static string lName;
        public static string email;

        public static bool isSMS;
        public static bool isReports;
        public static bool isTransactionReports;
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            fName = txtBoxFirstName.Text;
            lName = txtBoxLastName.Text;
            email = txtBoxEmail.Text;
        }

        private void chkBoxSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxSMS.Checked)
            {
                isSMS = true;

                lblSMS.Text = "Service Charge may apply.";
            }
            else
            {
                isSMS = false;
                lblSMS.Text = ".....................";
            }
        }

        private void chkBoxTransactionReport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxTransactionReport.Checked)
            {
                isTransactionReports = true;

                lblTransactionReports.Text = "Service Charge may apply.";
            }
            else
            {
                isTransactionReports = false;
                lblTransactionReports.Text = ".....................";
            }
        }

        private void chkBoxReports_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxReports.Checked)
            {
                isReports = true;
            }
            else
            {
                isReports = false;
            }
        }
    }
}