﻿using System;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void catBtn_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }
        private void shopBtn_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }
        private void xBtn_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            accActionPanel.Visible = !accActionPanel.Visible;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        { 
            this.Close();
            LogInForm log = new LogInForm();
            log.Show();
        }
    }
}
