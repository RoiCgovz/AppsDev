using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class Cart : Form
    {
        private List<Items> cartItems = new List<Items>();
        private decimal grandTotal = 0;

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

        private void CalculateGrandTotal()
        {
            grandTotal = cartItems.Sum(item => item.Total);
            lblTotal.Text = $"Grand Total: {grandTotal:C}";
        }

        public void AddItems(List<Items> newItems)
        {
            cartItems.AddRange(newItems);
            DisplayCartItems();
            CalculateGrandTotal();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CategoryForm mainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault();
            if (mainForm != null)
            {
                this.Hide();
                mainForm.Show();
            }
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
