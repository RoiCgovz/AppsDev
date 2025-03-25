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
    }
}
