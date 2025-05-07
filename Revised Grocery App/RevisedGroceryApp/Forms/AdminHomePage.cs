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
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            accActionPanel.Visible = !accActionPanel.Visible;
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            ItemsAdmin i = new ItemsAdmin();
            i.Show();
            this.Close();
        }

        private void invAdmin_Click(object sender, EventArgs e)
        {
            InvAdmin inv = new InvAdmin();
            inv.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SalesAdmin s = new SalesAdmin();
            s.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Report r  = new Report();
            r.Show();
            this.Close();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm log = new LogInForm();
            log.Show();
        }
    }
}
