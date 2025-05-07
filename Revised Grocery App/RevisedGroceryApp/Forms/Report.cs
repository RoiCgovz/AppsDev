using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RevisedGroceryApp.Forms;

namespace RevisedGroceryApp
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LogInForm().ShowDialog();
            Close();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            new SalesReport().Show();
            Close();
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            new InvReport().Show();
            Close();
        }
    }
}
