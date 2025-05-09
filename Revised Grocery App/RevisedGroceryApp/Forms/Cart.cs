using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class Cart : Form
    {
        private List<Items> cartItems;
        private decimal grandTotal = 0;

        public Cart(List<Items> items = null)
        {
            InitializeComponent();
            InitializeDataGridView();

            cartItems = items ?? new List<Items>();
            DisplayCartItems();
            CalculateTotal();
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Name", "NAME");
            dataGridView1.Columns.Add("Quantity", "QTY");
            dataGridView1.Columns.Add("Price", "PRICE");
            dataGridView1.Columns.Add("Total", "TOTAL");
        }

        public void LoadCartItems(List<Items> items)
        {
            cartItems = items;
            DisplayCartItems();
            CalculateTotal();
        }

        private void DisplayCartItems()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in cartItems)
            {
                decimal total = item.Quantity * item.Price;
                dataGridView1.Rows.Add(item.Name, item.Quantity, item.Price.ToString("C"), total.ToString("C"));
            }
        }

        private void CalculateTotal()
        {
            grandTotal = cartItems.Sum(item => item.Quantity * item.Price);
            lblTotal.Text = $"Total: {grandTotal:C}";
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
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
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items before checking out.",
                                "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Receipt receiptForm = new Receipt(cartItems);
            receiptForm.Show();
            this.Close();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }
    }
}
