using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RevisedGroceryApp
{
    public partial class Beverages : Form
    {
        private const decimal winePrice = 15.35m;
        private const decimal juicePrice = 3.00m;
        private const decimal sodaPrice = 1.50m;

        public Beverages()
        {
            InitializeComponent();
            LoadStockLabels();
        }

        private void LoadStockLabels()
        {
            wineStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Wine")}";
            juiceStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Juice")}";
            sodaStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Soda")}";
        }

        private void wineMin_Click(object sender, EventArgs e) => DecrementQuantity(wineTxtBox);
        private void wineAdd_Click(object sender, EventArgs e) => IncrementQuantity(wineTxtBox, "Wine");

        private void juiceMin_Click(object sender, EventArgs e) => DecrementQuantity(juiceTxtBox);
        private void juiceAdd_Click(object sender, EventArgs e) => IncrementQuantity(juiceTxtBox, "Juice");

        private void sodaMin_Click(object sender, EventArgs e) => DecrementQuantity(sodaTxtBox);
        private void sodaAdd_Click(object sender, EventArgs e) => IncrementQuantity(sodaTxtBox, "Soda");

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
        private void bakeBtn_Click(object sender, EventArgs e)
        {
            Bakery bake = new Bakery();
            bake.Show();
            this.Hide();
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            Produce p = new Produce();
            p.Show();
            this.Close();
        }

        private void daiBtn_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            dairy.Show();
            this.Close();
        }

        private void grnBtn_Click(object sender, EventArgs e)
        {
            Grains grains = new Grains();
            grains.Show();
            this.Close();
        }

        private void snksBtn_Click(object sender, EventArgs e)
        {
            Snacks sn = new Snacks();
            sn.Show();
            this.Close();
        }
        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void backbtn_Click(object sender, EventArgs e)
        {
            // When going back, ensure the updated cart items are retained
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

            // Retain the CartItems
            CategoryForm.CartItems = CategoryForm.CartItems; // Ensure the CartItems list persists
        }

        private void itemToCart_Click_1(object sender, EventArgs e)
        {
            AddItemsToCart();
        }

        private void AddItemsToCart()
        {
            var items = new List<(string Name, TextBox TextBox, Label StockLabel)>
            {
                ("Wine", wineTxtBox, wineStockLbl),
                ("Juice", juiceTxtBox, juiceStockLbl),
                ("Soda", sodaTxtBox, sodaStockLbl)
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

            // Update the global cart (CartItems) based on selected items
            foreach (var newItem in selectedItems)
            {
                var existingItem = CategoryForm.CartItems.FirstOrDefault(i => i.Name == newItem.Name);
                if (existingItem != null)
                {
                    existingItem.Quantity += newItem.Quantity; // Update the quantity if item already exists in cart
                }
                else
                {
                    CategoryForm.CartItems.Add(newItem); // Add new item to cart
                }
            }

            // Show the updated cart
            Cart cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault();
            if (cartForm == null)
            {
                cartForm = new Cart(CategoryForm.CartItems);
                cartForm.Show();
            }
            else
            {
                cartForm.LoadCartItems(CategoryForm.CartItems); // Reload the updated cart items
                cartForm.Show();
            }

            LoadStockLabels(); // Refresh stock labels
            this.Close(); // Close the current form after adding items
        }
    }
}
