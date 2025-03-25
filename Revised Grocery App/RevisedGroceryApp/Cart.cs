using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class Cart : Form
    {
        private List<Items> cartItems = new List<Items>();
        private decimal grandTotal;

        public Cart(List<Items> items = null)
        {
            InitializeComponent();
            InitializeDataGridView();

            if (items != null)
            {
                cartItems.AddRange(items);
            }

            DisplayCartItems();
            CalculateGrandTotal();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Name", "NAME");
            dataGridView1.Columns.Add("Quantity", "QTY");
            dataGridView1.Columns.Add("Price", "PRICE");
            dataGridView1.Columns.Add("Total", "TOTAL");
        }

        private void DisplayCartItems()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in cartItems)
            {
                dataGridView1.Rows.Add(item.Name, item.Quantity, item.Price.ToString("C"), item.Total.ToString("C"));
            }
        }

        public void AddItems(List<Items> newItems)
        {
            foreach (var newItem in newItems)
            {
                var existingItem = cartItems.FirstOrDefault(i => i.Name == newItem.Name);
                if (existingItem != null)
                {
                    existingItem.Quantity += newItem.Quantity; // Update quantity if item exists
                }
                else
                {
                    cartItems.Add(newItem); // Otherwise, add new item
                }
            }

            DisplayCartItems();
            CalculateGrandTotal();
        }

        private void CalculateGrandTotal()
        {
            grandTotal = cartItems.Sum(item => item.Total);
            lblTotal.Text = $"Grand Total: {grandTotal:C}";
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryForm existingMainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault();
            if (existingMainForm != null)
            {
                existingMainForm.Show();
            }
            else
            {
                CategoryForm newMainForm = new CategoryForm();
                newMainForm.Show();
            }
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your final total is: {lblTotal.Text}\nThank you for shopping!", "Checkout Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cartItems.Clear();
            dataGridView1.Rows.Clear();
            lblTotal.Text = "Grand Total: $0.00";
        }
    }
}
