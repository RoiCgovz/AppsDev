using System;
using System.Linq;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bckLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form existingMainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();

            if (existingMainForm != null)
            {
                existingMainForm.Show();
            }
            else
            {
                MainForm mn = new MainForm();
                mn.Show();
            }
        }
        public void AddToReceipt(string itemName, int quantity, decimal price ,string totalprice)
        {
            if (quantity > 0)
            {
                decimal totalPrice = price * quantity;
                string formattedTotal = totalPrice.ToString("C");
                bool itemExists = false;

                for (int i = 0; i < receiptListBox.Items.Count; i++)
                {
                    string itemText = receiptListBox.Items[i].ToString();
                    string[] parts = itemText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 4 && parts[1].Trim().Equals(itemName, StringComparison.OrdinalIgnoreCase))
                    {
                        if (int.TryParse(parts[0].Trim(), out int existingQty))
                        {
                            int updatedQty = existingQty + quantity;
                            decimal updatedTotal = updatedQty * price;
                            receiptListBox.Items[i] = string.Format("{0,-16}{1,-35}{2,-40}{3,-30}",
                                updatedQty, itemName, price.ToString("C"), updatedTotal.ToString("C"));
                        }
                        itemExists = true;
                        break;
                    }
                }
                if (!itemExists)
                {
                    receiptListBox.Items.Add(string.Format("{0,-16}{1,-35}{2,-40}{3,-30}",
                        quantity, itemName, price.ToString("C"), formattedTotal));
                }
                UpdateSubtotal();
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateSubtotal()
        {
            decimal discountRate = 0;
            decimal subtotal = 0;
            decimal discountAmount, finalTotal;
            foreach (var item in receiptListBox.Items)
            {
                string itemText = item.ToString();
                string[] parts = itemText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 4)
                {
                    string totalPriceStr = parts[3];
                    if (decimal.TryParse(totalPriceStr, System.Globalization.NumberStyles.Currency, null, out decimal itemTotal))
                    {
                        subtotal += itemTotal;
                    }
                }
            }
            if (subtotal >= 300)
            {
                discountRate = 0.20m;
            }
            else if (subtotal >= 200)
            {
                discountRate = 0.15m; 
            }
            else if (subtotal >= 100)
            {
                discountRate = 0.10m; 
            }

            discountAmount = subtotal * discountRate;
            finalTotal = subtotal - discountAmount;

            subtotalLabel.Text = subtotal.ToString("C");
            dis.Text = discountAmount.ToString("C");
            totalLabel.Text = finalTotal.ToString("C");
        }

        private void anotherBtn_Click(object sender, EventArgs e)
        {
            receiptListBox.Items.Clear();
            MainForm mn = new MainForm();
            mn.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            receiptListBox.Items.Clear();
            MainForm mn = new MainForm();
            DialogResult confirm = MessageBox.Show("Make Another Purchase?", "Proceed", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                mn.Show();
               
                this.Hide();
            }
            else
            {
                return;
            }
        }
    }
}
