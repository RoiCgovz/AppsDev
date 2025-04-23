using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class CategoryForm : Form
    {
        private static Cart cartForm;
        public static List<Items> CartItems = new List<Items>();
      
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bakeBtn_Click(object sender, EventArgs e)
        {
            Bakery bakery = new Bakery();
            this.Hide();
            bakery.Show();
        }

        private void bevBtn_Click(object sender, EventArgs e)
        {
            Beverages bev = new Beverages();
            this.Hide();
            bev.Show();
        }

        private void dairyBtn_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            this.Hide();
            dairy.Show();
        }

        private void grainsBtn_Click(object sender, EventArgs e)
        {
            Grains g = new Grains();
            this.Hide();
            g.Show();
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            Produce p = new Produce();
            this.Hide();
            p.Show();
        }

        private void snkBtn_Click(object sender, EventArgs e)
        {
            Snacks s = new Snacks();
            this.Hide();
            s.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
