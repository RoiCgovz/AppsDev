using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class Receipt : Form
    {
        private List<Items> receiptItems;
        private decimal grandTotal = 0;
        private decimal discount = 0;
        private decimal finalTotal = 0;

        public Receipt(List<Items> items = null)
        {
            InitializeComponent();
            InitializeDataGridView();

            receiptItems = items ?? new List<Items>();
            DisplayReceiptItems();
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

        private void DisplayReceiptItems()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in receiptItems)
            {
                decimal total = item.Quantity * item.Price;
                dataGridView1.Rows.Add(item.Name, item.Quantity, item.Price.ToString("C"), total.ToString("C"));
            }
        }

        private void CalculateTotal()
        {
            grandTotal = receiptItems.Sum(item => item.Quantity * item.Price);
            discount = CalculateDiscount(grandTotal);
            finalTotal = grandTotal - discount;

            lblTotal.Text = $"Subtotal: {grandTotal:C}\nDiscount: {discount:C}\nGrand Total: {finalTotal:C}";
        }

        private decimal CalculateDiscount(decimal total)
        {
            if (total > 500) return total * 0.20m; 
            if (total > 200) return total * 0.15m;
            if (total > 100) return total * 0.10m;
            return 0;
        }

        public void LoadReceiptItems(List<Items> items)
        {
            receiptItems = items;
            DisplayReceiptItems();
            CalculateTotal();
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

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            CategoryForm.CartItems.Clear();
            dataGridView1.Rows.Clear();
            grandTotal = 0;
            discount = 0;
            finalTotal = 0;

            lblTotal.Text = $"Subtotal: {grandTotal:C}";
            discountLbl.Text = $"Discount: {discount: C}";
            grandTotalLbl.Text = $"Grand Total: { finalTotal: C}";

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

            this.Close();
        }

        private void grandTotalLbl_Click(object sender, EventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
