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

        private void loginUserBtn_Click(object sender, EventArgs e)
        {
            string username = loginUserNameTxtBox.Text;
            string password = loginPasswordTxtBox.Text;

            if (DatabaseHelperClass.LoginAccount(username, password, out string userType, out int accountId))
            {
                MessageBox.Show($"Login successful! Type: {userType}, ID: {accountId}");
                HomePage home = new HomePage();
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid login credentials.");
            }
        }

        private void signUpAdminBtn_Click(object sender, EventArgs e)
        {
            AdminSignUp ad = new AdminSignUp();
            ad.Show();
            this.Hide();
        }
    }
}
