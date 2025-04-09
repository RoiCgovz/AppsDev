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
            InitializeQuantityBoxes();
        }

        private void InitializeQuantityBoxes()
        {
            wineTxtBox.Text = "0";
            juiceTxtBox.Text = "0";
            sodaTxtBox.Text = "0";
            wineTxtBox.TextChanged += QuantityChanged;
            juiceTxtBox.TextChanged += QuantityChanged;
            sodaTxtBox.TextChanged += QuantityChanged;
            itemToCart.Enabled = false;
        }

        private void QuantityChanged(object sender, EventArgs e)
        {
            itemToCart.Enabled = wineTxtBox.Text != "0" || juiceTxtBox.Text != "0" || sodaTxtBox.Text != "0";
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
            new Bakery().Show();
            this.Hide();
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            new Produce().Show();
            this.Close();
        }

        private void daiBtn_Click(object sender, EventArgs e)
        {
            new Dairy().Show();
            this.Close();
        }

        private void grnBtn_Click(object sender, EventArgs e)
        {
            new Grains().Show();
            this.Close();
        }

        private void snksBtn_Click(object sender, EventArgs e)
        {
            new Snacks().Show();
            this.Close();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault() ?? new CategoryForm();
            mainForm.Show();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            var cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault() ?? new Cart(CategoryForm.CartItems);
            cartForm.Show();
            this.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault();
            if (mainForm == null)
            {
                mainForm = new CategoryForm();
                mainForm.Show();
            }
            else
            {
                mainForm.Show();
            }

            CategoryForm.CartItems = CategoryForm.CartItems;
        }

        private void itemToCart_Click_1(object sender, EventArgs e)
        {
            AddItemsToCart();
        }

        private void AddItemsToCart()
        {
            var items = new List<(string Name, TextBox TextBox)>
            {
                ("Wine", wineTxtBox),
                ("Juice", juiceTxtBox),
                ("Soda", sodaTxtBox)
            };

            List<Items> selectedItems = new List<Items>();

            foreach (var (itemName, textBox) in items)
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

                DatabaseHelperClass.UpdateItemStock(newItem.Name, newItem.Quantity, DateTime.Now);
            }

            var cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault();
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
            ResetQuantities();
            this.Close();
        }

        private void ResetQuantities()
        {
            wineTxtBox.Text = "0";
            juiceTxtBox.Text = "0";
            sodaTxtBox.Text = "0";
        }
    }
}
