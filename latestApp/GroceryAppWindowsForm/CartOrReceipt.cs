using System;
using System.Linq;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class CartOrReceipt : Form
    {
        public Receipt receipt = new Receipt();
        public CartOrReceipt()
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
        public void AddToCart(string itemName, int quantity, decimal price, string totalprice)
        {
            if (quantity > 0)
            {
                decimal totalPrice = price * quantity;
                string formattedTotal = totalPrice.ToString("C");
                bool itemExists = false;

                for (int i = 0; i < cartListBox.Items.Count; i++)
                {
                    string itemText = cartListBox.Items[i].ToString();
                    string[] parts = itemText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 4 && parts[1].Trim().Equals(itemName, StringComparison.OrdinalIgnoreCase))
                    {
                        if (int.TryParse(parts[0].Trim(), out int existingQty))
                        {
                            int updatedQty = existingQty + quantity;
                            decimal updatedTotal = updatedQty * price;
                            cartListBox.Items[i] = string.Format("{0,-16}{1,-35}{2,-40}{3,-30}",
                                updatedQty, itemName, price.ToString("C"), updatedTotal.ToString("C"));
                        }
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    cartListBox.Items.Add(string.Format("{0,-16}{1,-35}{2,-40}{3,-30}",
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
            decimal subtotal = 0;

            foreach (var item in cartListBox.Items)
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
            subtotalLabel.Text = subtotal.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Proceed to Checkout?", "Proceed", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirm == DialogResult.OK)
            {
                CartOrReceipt cartForm = this.FindForm() as CartOrReceipt;

                if (cartForm != null && cartForm.receipt != null)
                {
                    cartForm.receipt.Show();
                }
            }
            else
            {
                return;
            }
        }
    }
}
