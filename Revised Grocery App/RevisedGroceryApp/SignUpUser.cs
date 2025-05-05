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
    public partial class SignUpUser : Form
    {
        public SignUpUser()
        {
            InitializeComponent();
        }

        private void signInLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Hide();
        }

        private void SignUpUser_Load(object sender, EventArgs e)
        {

        }

        private void signInAdminBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adLog = new AdminLogin();
            adLog.Show();
            this.Hide();
        }

        private void signUpAdminBtn_Click(object sender, EventArgs e)
        {
            AdminSignUp signup = new AdminSignUp();
            signup.Show();
            this.Hide();
        }

        private void signUpUserBtn_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = ConfirmPassword();

            if (password == null)
                return;     

            if (DatabaseHelperClass.InsertUserAccount(userName, password) == true)
            {
                MessageBox.Show("User account created successfully.");
            }
            else
            {
                MessageBox.Show("Failed to create user account.");
            }
        }
        private string ConfirmPassword()
        {
            if (signUpPasswordTxtBox.Text == signUpConfirmPassTxtBox.Text)
            {
                return signUpConfirmPassTxtBox.Text;
            }
            else
            {
                MessageBox.Show("Passwords are different, please try again.");
                signUpConfirmPassTxtBox.Text = "";
                signUpPasswordTxtBox.Text = "";
                return null;
            }
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
