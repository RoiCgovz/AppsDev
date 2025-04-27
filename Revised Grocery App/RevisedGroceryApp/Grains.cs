using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class Grains : Form
    {
        private const decimal ricePrice = 4.00m;
        private const decimal wheatPrice = 2.40m;
        private const decimal cornPrice = 1.50m;

        public Grains()
        {
            InitializeComponent();
            LoadStockLabels();
            InitializeQuantityBoxes();
        }

        private void InitializeQuantityBoxes()
        {
            riceTxtBox.Text = "0";
            wheatTxtBox.Text = "0";
            cornTxtBox.Text = "0";
            riceTxtBox.TextChanged += QuantityChanged;
            wheatTxtBox.TextChanged += QuantityChanged;
            cornTxtBox.TextChanged += QuantityChanged;
            itemToCart.Enabled = false;
        }

        private void QuantityChanged(object sender, EventArgs e)
        {
            itemToCart.Enabled = riceTxtBox.Text != "0" || wheatTxtBox.Text != "0" || cornTxtBox.Text != "0";
        }

        private void LoadStockLabels()
        {
            riceStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Rice")}";
            wheatStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Wheat")}";
            cornStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Corn")}";
        }

        private void riceMin_Click(object sender, EventArgs e) => DecrementQuantity(riceTxtBox);
        private void riceAdd_Click(object sender, EventArgs e) => IncrementQuantity(riceTxtBox, "Rice");

        private void wheatMin_Click(object sender, EventArgs e) => DecrementQuantity(wheatTxtBox);
        private void wheatAdd_Click(object sender, EventArgs e) => IncrementQuantity(wheatTxtBox, "Wheat");

        private void cornMin_Click(object sender, EventArgs e) => DecrementQuantity(cornTxtBox);
        private void cornAdd_Click(object sender, EventArgs e) => IncrementQuantity(cornTxtBox, "Corn");

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

        }

        private void AddItemsToCart()
        {
            var items = new List<(string Name, TextBox TextBox)>
            {
                ("Rice", riceTxtBox),
                ("Wheat", wheatTxtBox),
                ("Corn", cornTxtBox)
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
            riceTxtBox.Text = "0";
            wheatTxtBox.Text = "0";
            cornTxtBox.Text = "0";
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

        private void daiBtn_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            dairy.Show();
            this.Close();
        }

        private void bevBtn_Click(object sender, EventArgs e)
        {
            Beverages bev = new Beverages();
            bev.Show();
            this.Close();
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            Produce p = new Produce();
            p.Show();
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
