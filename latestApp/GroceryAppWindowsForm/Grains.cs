using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class Grains : UserControl
    {
        private int riceCount = 0;
        private int wheatCount = 0;
        private int cornCount = 0;

        private const decimal ricePrice = 1.20m;
        private const decimal wheatPrice = 3.00m;
        private const decimal cornPrice = 1.30m;

        public Grains()
        {
            InitializeComponent();
            UpdateTextBoxes();
            AttachKeyPressEvents();
        }

        private void AttachKeyPressEvents()
        {
            riceTxtBox.KeyPress += ValidateInput;
            wheatTxtBox.KeyPress += ValidateInput;
            cornTxtBox.KeyPress += ValidateInput;
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
            riceTxtBox.Text = riceCount.ToString();
            wheatTxtBox.Text = wheatCount.ToString();
            cornTxtBox.Text = cornCount.ToString();
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
        private void riceInc_Click(object sender, EventArgs e) => UpdateCount(riceTxtBox, ref riceCount, true);
        private void riceDec_Click(object sender, EventArgs e) => UpdateCount(riceTxtBox, ref riceCount, false);

        private void wheatInc_Click(object sender, EventArgs e) => UpdateCount(wheatTxtBox, ref wheatCount, true);
        private void wheatDec_Click(object sender, EventArgs e) => UpdateCount(wheatTxtBox, ref wheatCount, false);

        private void cornInc_Click(object sender, EventArgs e) => UpdateCount(cornTxtBox, ref cornCount, true);
        private void cornDec_Click(object sender, EventArgs e) => UpdateCount(cornTxtBox, ref cornCount, false);

        private void riceAddBtn_Click(object sender, EventArgs e)
        {
            if (riceCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Rice", riceCount, ricePrice);
            }
        }

        private void wheatAddBtn_Click(object sender, EventArgs e)
        {
            if (wheatCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Wheat", wheatCount, wheatPrice);
            }
        }

        private void cornAddBtn_Click(object sender, EventArgs e)
        {
            if (cornCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Corn", cornCount, cornPrice);
            }
        }
    }
}
