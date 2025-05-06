using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RevisedGroceryApp
{
    public partial class AdminSignUp : Form
    {
        public AdminSignUp()
        {
            InitializeComponent();
        }

        private string ConfirmPassword()
        {
            if (adminSignUpPasswordTxtBox.Content == AdminSignUpConfirmPassTxtBox.Content)
            {
                return AdminSignUpConfirmPassTxtBox.Content;
            }
            else
            {
                MessageBox.Show("Passwords are different, please try again.");
                AdminSignUpConfirmPassTxtBox.Content = "";
                adminSignUpPasswordTxtBox.Content = "";
                return null;
            }
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
            string adminUsername = AdminSignUpUserNameTxtBox.Content;
            string adminPassword = ConfirmPassword();

            if (adminPassword == null)
                return;

            if (DatabaseHelperClass.InsertAdminAccount(adminUsername, adminPassword) == true)
            {
                MessageBox.Show("Admin account created successfully.");
                new LogInForm().Show(); 
                this.Hide();

            }
            else
            {
                MessageBox.Show("Failed to create user account.");
            }
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
