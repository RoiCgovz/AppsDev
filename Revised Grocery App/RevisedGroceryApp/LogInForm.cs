using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void signUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpUser signUp = new SignUpUser();
            signUp.Show();
            this.Hide();
        }

        private void signInAdminBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adLog = new AdminLogin();
            adLog.Show();
            this.Hide();
        }
    }
}
