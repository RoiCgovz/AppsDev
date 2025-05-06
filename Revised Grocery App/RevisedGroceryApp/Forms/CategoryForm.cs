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
        
        private void bakeBtn_Click(object sender, EventArgs e)
        {
            Bakery bakery = new Bakery();
            this.Close();
            bakery.Show();
        }

        private void bevBtn_Click(object sender, EventArgs e)
        {
            Beverages bev = new Beverages();
            this.Close();
            bev.Show();
        }

        private void dairyBtn_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            this.Close();
            dairy.Show();
        }

        private void grainsBtn_Click(object sender, EventArgs e)
        {
            Grains g = new Grains();
            this.Close();
            g.Show();
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            Produce p = new Produce();
            this.Close();
            p.Show();
        }

        private void snkBtn_Click(object sender, EventArgs e)
        {
            Snacks s = new Snacks();
            this.Close();
            s.Show();
        }

        private void cartPnl_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }

        private void homePnl_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void catPnl_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Close();
        }

        private void homelbl_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void catLbl_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Close();
        }

        private void cartLbl_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }
        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
