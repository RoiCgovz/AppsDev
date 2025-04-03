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

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (cartForm == null || cartForm.IsDisposed)
            {
                cartForm = new Cart(CartItems);
            }
            else
            {
                cartForm.LoadCartItems(CartItems);
            }

            this.Hide();
            cartForm.Show();
        }

        private void bevVwMr_Click(object sender, EventArgs e)
        {
            Beverages bev = new Beverages();
            this.Hide();
            bev.Show();
        }

        private void daiVwMr_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            this.Hide();
            dairy.Show();
        }

        private void bkryVwMr_Click(object sender, EventArgs e)
        {
            Bakery bakery = new Bakery();
            this.Hide();
            bakery.Show();
        }

        private void prodVwMr_Click(object sender, EventArgs e)
        {
            Produce p = new Produce();
            this.Hide();
            p.Show();
        }

        private void snksVwMr_Click(object sender, EventArgs e)
        {
            Snacks s = new Snacks();
            this.Hide();
            s.Show();
        }

        private void gnVwMr_Click(object sender, EventArgs e)
        {
            Grains g = new Grains();
            this.Hide();
            g.Show();
        }

        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseHelperClass.ResetAllStocks();
        }

        
    }
}
