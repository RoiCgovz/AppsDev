using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RevisedGroceryApp.Resources;

namespace RevisedGroceryApp
{
    public partial class Bakery : Form
    {
        private const decimal croisPrice = 1.20m;
        private const decimal sliBriPrice = 1.40m;
        private const decimal bagelPrice = 1.78m;

        public Bakery()
        {
            InitializeComponent();
        }

        private void croisMin_Click(object sender, EventArgs e) => DecrementQuantity(croisTxtBox);
        private void croisAdd_Click(object sender, EventArgs e) => IncrementQuantity(croisTxtBox);
        private void sliBreMin_Click(object sender, EventArgs e) => DecrementQuantity(sliBreTxtBox);
        private void sliBreAdd_Click(object sender, EventArgs e) => IncrementQuantity(sliBreTxtBox);
        private void bagelMin_Click(object sender, EventArgs e) => DecrementQuantity(bagelTxtBox);
        private void bagelAdd_Click(object sender, EventArgs e) => IncrementQuantity(bagelTxtBox);

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

        private void dairyBtn_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            dairy.Show();
            this.Close();
        }

        private void itemToCart_Click_1(object sender, EventArgs e)
        {

            int croisQty = int.TryParse(croisTxtBox.Text, out int cQty) ? cQty : 0;
            int sliBreQty = int.TryParse(sliBreTxtBox.Text, out int sbQty) ? sbQty : 0;
            int bagelQty = int.TryParse(bagelTxtBox.Text, out int bQty) ? bQty : 0;

            if (croisQty == 0 && sliBreQty == 0 && bagelQty == 0)
            {
                MessageBox.Show("Please select at least one item before adding to the cart.",
                                "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Items> selectedItems = new List<Items>
            {
                new Items { Name = "Croissant", Quantity = croisQty, Price = croisPrice },
                new Items { Name = "Sliced Bread", Quantity = sliBreQty, Price = sliBriPrice },
                new Items { Name = "Bagel", Quantity = bagelQty, Price = bagelPrice }
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

        private void prodBtn_Click(object sender, EventArgs e)
        {
            Produce p = new Produce();
            p.Show();
            this.Close();
        }

        
    }
}
