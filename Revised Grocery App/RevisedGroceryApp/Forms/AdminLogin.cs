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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
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
            login.Show();
            this.Hide();
        }

        private void loginUserBtn_Click(object sender, EventArgs e)
        {
            string username = "Admin" + AdminloginUserNameTxtBox.Content;
            string password = AdminloginPasswordTxtBox.Content;

            if (DatabaseHelperClass.LoginAccount(username, password, out string userType, out int accountId))
            {
                MessageBox.Show($"Login successful! Type: {userType}, ID: {accountId}");
                AdminHomePage ad = new AdminHomePage();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login credentials.");
            }
           
        }

        private void signUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminSignUp signup = new AdminSignUp();
            signup.Show();
            this.Hide();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
