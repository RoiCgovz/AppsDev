using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RevisedGroceryApp.Resources;

namespace RevisedGroceryApp
{
    public partial class Snacks : Form
    {
        private const decimal chipsPrice = 1.50m;
        private const decimal nachosPrice = 2.00m;
        private const decimal cookiesPrice = 1.80m;

        public Snacks()
        {
            InitializeComponent();
        }

        private void chipsMin_Click(object sender, EventArgs e) => DecrementQuantity(chipsTxtBox);
        private void chipsAdd_Click(object sender, EventArgs e) => IncrementQuantity(chipsTxtBox);
        private void nachosMin_Click(object sender, EventArgs e) => DecrementQuantity(nachosTxtBox);
        private void nachosAdd_Click(object sender, EventArgs e) => IncrementQuantity(nachosTxtBox);
        private void cookiesMin_Click(object sender, EventArgs e) => DecrementQuantity(cookiesTxtBox);
        private void cookiesAdd_Click(object sender, EventArgs e) => IncrementQuantity(cookiesTxtBox);

        private void IncrementQuantity(TextBox txtBox)
        {
            int currentValue = int.TryParse(txtBox.Text, out int value) ? value : 0;
            txtBox.Text = (currentValue + 1).ToString();
        }

        private void DecrementQuantity(TextBox txtBox)
        {
            int currentValue = int.TryParse(txtBox.Text, out int value) ? value : 0;
            if (currentValue > 0)
            {
                txtBox.Text = (currentValue - 1).ToString();
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            CategoryForm mainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault();
            if (mainForm == null)
            {
                mainForm = new CategoryForm();
                mainForm.Show();
            }
            else
            {
                mainForm.Show();
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            Cart cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault();
            if (cartForm == null)
            {
                cartForm = new Cart(CategoryForm.CartItems);
                cartForm.Show();
            }
            else
            {
                cartForm.Show();
            }
            this.Close();
        }

        private void itemToCart_Click(object sender, EventArgs e)
        {
            int chipsQty = int.TryParse(chipsTxtBox.Text, out int cQty) ? cQty : 0;
            int nachosQty = int.TryParse(nachosTxtBox.Text, out int nQty) ? nQty : 0;
            int cookiesQty = int.TryParse(cookiesTxtBox.Text, out int coQty) ? coQty : 0;

            if (chipsQty == 0 && nachosQty == 0 && cookiesQty == 0)
            {
                MessageBox.Show("Please select at least one item before adding to the cart.",
                                "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Items> selectedItems = new List<Items>
            {
                new Items { Name = "Chips", Quantity = chipsQty, Price = chipsPrice },
                new Items { Name = "Nachos", Quantity = nachosQty, Price = nachosPrice },
                new Items { Name = "Cookies", Quantity = cookiesQty, Price = cookiesPrice }
            };

            foreach (var newItem in selectedItems)
            {
                if (newItem.Quantity > 0)
                {
                    var existingItem = CategoryForm.CartItems.FirstOrDefault(i => i.Name == newItem.Name);
                    if (existingItem != null)
                    {
                        existingItem.Quantity += newItem.Quantity;
                    }
                    else
                    {
                        CategoryForm.CartItems.Add(newItem);
                    }
                }
            }

            Cart cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault();
            if (cartForm == null)
            {
                cartForm = new Cart(CategoryForm.CartItems);
                cartForm.Show();
            }
            else
            {
                cartForm.LoadCartItems(CategoryForm.CartItems);
                cartForm.Show();
            }
            this.Close();
        }

        private void bakeryBtn_Click(object sender, EventArgs e)
        {
            Bakery bake = new Bakery();
            bake.Show();
            this.Close();
        }

        private void bevBtn_Click(object sender, EventArgs e)
        {
            Beverages bev = new Beverages();
            bev.Show();
            this.Close();
        }

        private void dairyBtn_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            dairy.Show();
            this.Close();
        }

        private void grainsBtn_Click(object sender, EventArgs e)
        {
            Grains grains = new Grains();
            grains.Show();
            this.Close();
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            Produce produce = new Produce();
            produce.Show();
            this.Close();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
