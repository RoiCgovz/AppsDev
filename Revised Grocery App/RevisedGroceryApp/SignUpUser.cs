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
    }
}
