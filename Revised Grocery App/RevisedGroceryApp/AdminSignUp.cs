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
    public partial class AdminSignUp : Form
    {
        public AdminSignUp()
        {
            InitializeComponent();
        }

        private void signUpUserBtn_Click(object sender, EventArgs e)
        {
            SignUpUser sign = new SignUpUser();
            sign.Show();
            this.Hide();
        }

        private void signInUserBtn_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            this.Hide();
            login.Show();
        }

        private void signUpAdminBtn_Click(object sender, EventArgs e)
        {

        }

        private void signInLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin adLog = new AdminLogin();
            this.Hide();
            adLog.Show();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
