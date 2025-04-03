using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RevisedGroceryApp
{
    public partial class Bakery : Form
    {
        public Bakery()
        {
            InitializeComponent();
            LoadStockLabels();
        }

        private void LoadStockLabels()
        {
            croisStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Croissant")}";
            sliBreStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Sliced Bread")}";
            bagelStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Bagel")}";
        }

        private void croisMin_Click(object sender, EventArgs e) => DecrementQuantity(croisTxtBox);
        private void croisAdd_Click(object sender, EventArgs e) => IncrementQuantity(croisTxtBox, "Croissant");

        private void sliBreMin_Click(object sender, EventArgs e) => DecrementQuantity(sliBreTxtBox);
        private void sliBreAdd_Click(object sender, EventArgs e) => IncrementQuantity(sliBreTxtBox, "Sliced Bread");

        private void bagelMin_Click(object sender, EventArgs e) => DecrementQuantity(bagelTxtBox);
        private void bagelAdd_Click(object sender, EventArgs e) => IncrementQuantity(bagelTxtBox, "Bagel");

        private void IncrementQuantity(TextBox txtBox, string itemName)
        {
            int stock = DatabaseHelperClass.GetItemStock(itemName);
            int currentValue = int.TryParse(txtBox.Text, out int value) ? value : 0;

            if (currentValue < stock)
            {
                txtBox.Text = (currentValue + 1).ToString();
            }
            else
            {
                MessageBox.Show($"Only {stock} {itemName} left in stock.", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            CategoryForm mainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault() ?? new CategoryForm();
            mainForm.Show();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            Cart cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault() ?? new Cart(CategoryForm.CartItems);
            cartForm.Show();
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

        private void prodBtn_Click(object sender, EventArgs e)
        {
            Produce produce = new Produce();
            produce.Show();
            this.Close();
        }

       
        private void AddItemsToCart()
        {
            var items = new List<(string Name, TextBox TextBox, Label StockLabel)>
            {
                ("Croissant", croisTxtBox, croisStockLbl),
                ("Sliced Bread", sliBreTxtBox, sliBreStockLbl),
                ("Bagel", bagelTxtBox, bagelStockLbl)
            };

            List<Items> selectedItems = new List<Items>();

            foreach (var (itemName, textBox, stockLabel) in items)
            {
                int quantity = int.TryParse(textBox.Text, out int q) ? q : 0;
                if (quantity > 0)
                {
                    int stock = DatabaseHelperClass.GetItemStock(itemName);
                    if (stock < quantity)
                    {
                        MessageBox.Show($"Not enough stock for {itemName}. Available: {stock}",
                                        "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    decimal price = DatabaseHelperClass.GetItemPrice(itemName);
                    selectedItems.Add(new Items { Name = itemName, Quantity = quantity, Price = price });

                    DatabaseHelperClass.UpdateItemStock(itemName, quantity);
                }
            }

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one item before adding to the cart.",
                                "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var newItem in selectedItems)
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

            LoadStockLabels();
            this.Close();
        }

        private void itemToCart_Click(object sender, EventArgs e)
        {
            AddItemsToCart();
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

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
