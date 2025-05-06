using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class Produce : Form
    {
        public Produce()
        {
            InitializeComponent();
            LoadStockLabels();
            InitializeQuantityBoxes();
        }

        private void InitializeQuantityBoxes()
        {
            tomatoTxtBox.Text = "0";
            cabbageTxtBox.Text = "0";
            carrotsTxtBox.Text = "0";
            tomatoTxtBox.TextChanged += QuantityChanged;
            cabbageTxtBox.TextChanged += QuantityChanged;
            carrotsTxtBox.TextChanged += QuantityChanged;
            itemToCart.Enabled = false;
        }

        private void LoadStockLabels()
        {
            tomatoStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Tomato")}";
            cabbageStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Cabbage")}";
            carrotStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Carrots")}";
        }

        private void QuantityChanged(object sender, EventArgs e)
        {
            itemToCart.Enabled = tomatoTxtBox.Text != "0" || cabbageTxtBox.Text != "0" || carrotsTxtBox.Text != "0";
        }

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

        private void tomatoMin_Click(object sender, EventArgs e) => DecrementQuantity(tomatoTxtBox);
        private void tomatoAdd_Click(object sender, EventArgs e) => IncrementQuantity(tomatoTxtBox, "Tomato");

        private void cabbageMin_Click(object sender, EventArgs e) => DecrementQuantity(cabbageTxtBox);
        private void cabbageAdd_Click(object sender, EventArgs e) => IncrementQuantity(cabbageTxtBox, "Cabbage");

        private void carrotsMin_Click(object sender, EventArgs e) => DecrementQuantity(carrotsTxtBox);
        private void carrotsAdd_Click(object sender, EventArgs e) => IncrementQuantity(carrotsTxtBox, "Carrots");

        private void homeBtn_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault() ?? new CategoryForm();
            mainForm.Show();
        }

        private void backbtn_Click(object sender, EventArgs e)
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

        private void AddItemsToCart()
        {
            var items = new List<(string Name, TextBox TextBox)>
            {
                ("Tomato", tomatoTxtBox),
                ("Cabbage", cabbageTxtBox),
                ("Carrots", carrotsTxtBox)
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
            tomatoTxtBox.Text = "0";
            cabbageTxtBox.Text = "0";
            carrotsTxtBox.Text = "0";
        }

        private void itemToCart_Click(object sender, EventArgs e)
        {
            AddItemsToCart();
        }

        private void bakeBtn_Click(object sender, EventArgs e)
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

        private void snksBtn_Click(object sender, EventArgs e)
        {
            Snacks sn = new Snacks();
            sn.Show();
            this.Close();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
