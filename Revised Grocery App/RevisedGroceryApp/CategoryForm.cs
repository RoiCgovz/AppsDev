using RevisedGroceryApp.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class CategoryForm : Form
    {
        private static Cart cartForm;
        public static List<Items> CartItems = new List<Items>(); // Global cart list

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gnVwMr_Click(object sender, EventArgs e)
        {
            Grains grain = new Grains();
            this.Hide();
            grain.Show();
        }

        private void bevVwMr_Click(object sender, EventArgs e)
        {
            Beverages bev = new Beverages();
            bev.Show();
            this.Hide();
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

        private void daiVwMr_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            dairy.Show();
            this.Hide();
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
            p.Show();
            this.Hide();
        }

        private void snksVwMr_Click(object sender, EventArgs e)
        {
            Snacks s = new Snacks();
            s.Show();
            this.Hide();
        }
    }
}
