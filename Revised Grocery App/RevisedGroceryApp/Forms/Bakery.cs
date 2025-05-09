using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using RevisedGroceryApp.HelperClasses;

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
        private void AddItemsToCart()
        {
            var selectedItems = new List<Items>();

            // --- Handle static items ---
            var staticItems = new[]
            {
                ("Croissant", croisTxtBox, croisStockLbl),
                ("Sliced Bread", sliBreTxtBox, sliBreStockLbl),
                ("Bagel", bagelTxtBox, bagelStockLbl)
            };

            foreach (var (name, textBox, _) in staticItems)
            {
                if (!int.TryParse(textBox.Text, out int qty) || qty <= 0)
                    continue;

                int stock = DatabaseHelperClass.GetItemStock(name);
                if (qty > stock)
                {
                    MessageBox.Show($"Not enough stock for {name}. Available: {stock}",
                                    "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                decimal price = DatabaseHelperClass.GetItemPrice(name);

                selectedItems.Add(new Items { Name = name, Quantity = qty, Price = price });

                DatabaseHelperClass.UpdateItemStock(name, -qty, DateTime.Now);
                RecordInvOut(name, qty);
            }

            // --- Handle dynamic NewItem controls ---
            foreach (Control ctrl in bakeryPnl.Controls)
            {
                if (ctrl is NewItem newItem)
                {
                    int qty = newItem.Quantity;
                    string name = newItem.ItemName;

                    if (qty <= 0)
                        continue;

                    int stock = DatabaseHelperClass.GetItemStock(name);
                    if (qty > stock)
                    {
                        MessageBox.Show($"Not enough stock for {name}. Available: {stock}",
                                        "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    selectedItems.Add(new Items
                    {
                        Name = name,
                        Quantity = qty,
                        Price = newItem.Price
                    });

                    DatabaseHelperClass.UpdateItemStock(name, -qty, DateTime.Now);
                    RecordInvOut(name, qty);
                }
            }

            if (!selectedItems.Any())
            {
                MessageBox.Show("Please select at least one item before adding to the cart.",
                                "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Add or merge selected items into global cart ---
            foreach (var item in selectedItems)
            {
                var existing = CategoryForm.CartItems.FirstOrDefault(i => i.Name == item.Name);
                if (existing != null)
                    existing.Quantity += item.Quantity;
                else
                    CategoryForm.CartItems.Add(item);
            }

            // --- Show or update cart form ---
            var cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault();
            if (cartForm == null)
            {
                cartForm = new Cart(CategoryForm.CartItems);
                cartForm.Show();
            }
            else
            {
                cartForm.LoadCartItems(CategoryForm.CartItems);
            }

            LoadStockLabels(); // Refresh stock label UI
            this.Close();      // Close the item selection form
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

        private void croisMin_Click(object sender, EventArgs e) => DecrementQuantity(croisTxtBox);
        private void croisAdd_Click(object sender, EventArgs e) => IncrementQuantity(croisTxtBox, "Croissant");

        private void sliBreMin_Click(object sender, EventArgs e) => DecrementQuantity(sliBreTxtBox);
        private void sliBreAdd_Click(object sender, EventArgs e) => IncrementQuantity(sliBreTxtBox, "Sliced Bread");

        private void bagelMin_Click(object sender, EventArgs e) => DecrementQuantity(bagelTxtBox);
        private void bagelAdd_Click(object sender, EventArgs e) => IncrementQuantity(bagelTxtBox, "Bagel");


        private void homeBtn_Click(object sender, EventArgs e)
        {
            CategoryForm mainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault() ?? new CategoryForm();
            mainForm.Show();
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
        private void itemToCart_Click(object sender, EventArgs e)
        {
            AddItemsToCart();
        }

        private void snksBtn_Click(object sender, EventArgs e)
        {
            Snacks snacks = new Snacks();
            snacks.Show();
            this.Close();
        }
        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void catLbl_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            this.Close();
            cat.Show();
        }

        private void cartPnl_Click(object sender, EventArgs e)
        {
            Cart cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault() ?? new Cart(CategoryForm.CartItems);
            cartForm.Show();
            this.Close();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
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

        // Record Inv Out
        private void RecordInvOut(string itemName, int quantityOut)
        {
            int inventoryId = DatabaseHelperClass.GetInventoryIdByItemName(itemName);

            int invDetailId = DatabaseHelperClass.InsertInvOutDetail(inventoryId, quantityOut);

            DatabaseHelperClass.InsertIntoInvReport(invDetailId, quantityOut);
        }

        private void Bakery_Load(object sender, EventArgs e)
        {
            LoadItemsByCategory("Bakery");
        }

        private void LoadItemsByCategory(string category)
        {
            
            List<ImageItem> items = DatabaseHelperClass.GetItemsByCategory(category);

            foreach (ImageItem item in items)
            {
                NewItem newItem = new NewItem();
                newItem.LoadItemData(item.ItemId, item.ItemName, item.ItemPrice, item.Stock, item.ImageBytes);
                bakeryPnl.Controls.Add(newItem);
            }
        }
    }
}
