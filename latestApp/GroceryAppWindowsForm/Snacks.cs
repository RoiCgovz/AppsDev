using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class Snacks : UserControl
    {
        private int nanaCount = 0;
        private int nachoCount = 0;
        private int cookieCount = 0;

        private const decimal nanaPrice = 2.0m;
        private const decimal nachoPrice = 3.00m;
        private const decimal cookiePrice = 4.30m;

        public Snacks()
        {
            InitializeComponent();
            UpdateTextBoxes();
            AttachKeyPressEvents();
        }

        private void AttachKeyPressEvents()
        {
            nanaTxtBx.KeyPress += ValidateInput;
            nachoTxtBox.KeyPress += ValidateInput;
            cookieTxtBox.KeyPress += ValidateInput;
        }

        private void ValidateInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdateTextBoxes()
        {
            nanaTxtBx.Text = nanaCount.ToString();
            nachoTxtBox.Text = nachoCount.ToString();
            cookieTxtBox.Text = cookieCount.ToString();
        }

        private void UpdateCount(TextBox textBox, ref int count, bool increment)
        {
            if (int.TryParse(textBox.Text, out int userValue))
            {
                count = userValue;
            }

            if (increment)
                count++;
            else if (count > 0)
                count--;

            textBox.Text = count.ToString();
        }

        private void AddItemToCart(string itemName, int quantity, decimal price)
        {
            if (quantity > 0)
            {
                decimal total = quantity * price;
                string totalPriceStr = total.ToString("C");
                MainForm mainForm = this.FindForm() as MainForm;
                if (mainForm != null)
                {
                    if (mainForm.cartForm != null)
                    {
                        mainForm.cartForm.AddToCart(itemName, quantity, price, totalPriceStr);
                    }
                    CartOrReceipt cartForm = mainForm.cartForm as CartOrReceipt;
                    if (cartForm != null && cartForm.receipt != null)
                    {
                        cartForm.receipt.AddToReceipt(itemName, quantity, price, totalPriceStr);
                    }
                }
            }
        }
        private void nanaInc_Click(object sender, EventArgs e) => UpdateCount(nanaTxtBx, ref nanaCount, true);
        private void nanaDec_Click(object sender, EventArgs e) => UpdateCount(nanaTxtBx, ref nanaCount, false);

        private void nachoInc_Click(object sender, EventArgs e) => UpdateCount(nachoTxtBox, ref nachoCount, true);
        private void nachoDec_Click(object sender, EventArgs e) => UpdateCount(nachoTxtBox, ref nachoCount, false);

        private void cookieInc_Click(object sender, EventArgs e) => UpdateCount(cookieTxtBox, ref cookieCount, true);
        private void cookieDec_Click(object sender, EventArgs e) => UpdateCount(cookieTxtBox, ref cookieCount, false);

        private void nanaAddBtn_Click(object sender, EventArgs e)
        {
            if (nanaCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Banana Chips", nanaCount, nanaPrice);
            }
        }

        private void nachoAddBtn_Click(object sender, EventArgs e)
        {
            if (nachoCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Nachos", nachoCount, nachoPrice);
            }
        }

        private void cookieAddBtn_Click(object sender, EventArgs e)
        {
            if (cookieCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Cookies", cookieCount, cookiePrice);
            }
        }
    }
}
