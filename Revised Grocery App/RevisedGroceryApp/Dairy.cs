using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RevisedGroceryApp.Resources;

namespace RevisedGroceryApp
{
    public partial class Dairy : Form
    {
        private const decimal cheesePrice = 2.30m;
        private const decimal butterPrice = 1.20m;
        private const decimal yogurtPrice = 2.50m;

        public Dairy()
        {
            InitializeComponent();
        }

        private void cheeseMin_Click(object sender, EventArgs e) => DecrementQuantity(cheeseTxtBox);
        private void cheeseAdd_Click(object sender, EventArgs e) => IncrementQuantity(cheeseTxtBox);
        private void butterMin_Click(object sender, EventArgs e) => DecrementQuantity(butterTxtBox);
        private void butterAdd_Click(object sender, EventArgs e) => IncrementQuantity(butterTxtBox);
        private void yogurtMin_Click(object sender, EventArgs e) => DecrementQuantity(yogurtTxtBox);
        private void yogurtAdd_Click(object sender, EventArgs e) => IncrementQuantity(yogurtTxtBox);

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
        private void backbtn_Click(object sender, EventArgs e)
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
            int cheeseQty = int.TryParse(cheeseTxtBox.Text, out int rQty) ? rQty : 0;
            int butterQty = int.TryParse(butterTxtBox.Text, out int wQty) ? wQty : 0;
            int yogurtQty = int.TryParse(yogurtTxtBox.Text, out int cQty) ? cQty : 0;

            if (cheeseQty == 0 && butterQty == 0 && yogurtQty == 0)
            {
                MessageBox.Show("Please select at least one item before adding to the cart.",
                                "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Items> selectedItems = new List<Items>
            {
                new Items { Name = "Cheese", Quantity = cheeseQty, Price = cheesePrice },
                new Items { Name = "Butter", Quantity = butterQty, Price = butterPrice },
                new Items { Name = "Yogurt", Quantity = yogurtQty, Price = yogurtPrice }
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

        private void bevBtn_Click(object sender, EventArgs e)
        {
            Beverages bev = new Beverages();
            bev.Show();
            this.Close();
        }

        private void grainsBtn_Click(object sender, EventArgs e)
        {
            Grains grains = new Grains();
            grains.Show();
            this.Close();
        }

        private void bakeBtn_Click(object sender, EventArgs e)
        {
            Bakery bake = new Bakery();
            bake.Show();
            this.Close();
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            Produce p = new Produce();
            p.Show();
            this.Close();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void snksBtn_Click(object sender, EventArgs e)
        {
            Snacks sn = new Snacks();
            sn.Show();
            this.Close();
        }
    }
}
