using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

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
            LoadStockLabels();
            InitializeQuantityBoxes();
        }

        private void InitializeQuantityBoxes()
        {
            cheeseTxtBox.Text = "0";
            butterTxtBox.Text = "0";
            yogurtTxtBox.Text = "0";
            cheeseTxtBox.TextChanged += QuantityChanged;
            butterTxtBox.TextChanged += QuantityChanged;
            yogurtTxtBox.TextChanged += QuantityChanged;
            itemToCart.Enabled = false;
        }

        private void QuantityChanged(object sender, EventArgs e)
        {
            itemToCart.Enabled = cheeseTxtBox.Text != "0" || butterTxtBox.Text != "0" || yogurtTxtBox.Text != "0";
        }

        private void LoadStockLabels()
        {
            cheeseStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Cheese")}";
            butterStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Butter")}";
            yogurtStockLbl.Text = $"Stock: {DatabaseHelperClass.GetItemStock("Yogurt")}";
        }

        private void cheeseMin_Click(object sender, EventArgs e) => DecrementQuantity(cheeseTxtBox);
        private void cheeseAdd_Click(object sender, EventArgs e) => IncrementQuantity(cheeseTxtBox, "Cheese");

        private void butterMin_Click(object sender, EventArgs e) => DecrementQuantity(butterTxtBox);
        private void butterAdd_Click(object sender, EventArgs e) => IncrementQuantity(butterTxtBox, "Butter");

        private void yogurtMin_Click(object sender, EventArgs e) => DecrementQuantity(yogurtTxtBox);
        private void yogurtAdd_Click(object sender, EventArgs e) => IncrementQuantity(yogurtTxtBox, "Yogurt");

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

        private void AddItemsToCart()
        {
            var items = new List<(string Name, TextBox TextBox)>
            {
                ("Cheese", cheeseTxtBox),
                ("Butter", butterTxtBox),
                ("Yogurt", yogurtTxtBox)
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
            cheeseTxtBox.Text = "0";
            butterTxtBox.Text = "0";
            yogurtTxtBox.Text = "0";
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

        private void graBtn_Click(object sender, EventArgs e)
        {
            Grains grains = new Grains();
            grains.Show();
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

        private void itemToCart_Click(object sender, EventArgs e)
        {
            AddItemsToCart();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
