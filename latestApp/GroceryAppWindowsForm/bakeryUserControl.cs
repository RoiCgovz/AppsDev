using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class bakeryUserControl : UserControl
    {
        private int breadCount = 0;
        private int croissantCount = 0;
        private int bagelCount = 0;

        private const decimal breadPrice = 3.50m;
        private const decimal croissantPrice = 0.25m;
        private const decimal bagelPrice = 1.50m;

        public bakeryUserControl()
        {
            InitializeComponent();
            UpdateTextBoxes();
            AttachKeyPressEvents();
        }

        private void AttachKeyPressEvents()
        {
            breadTxtBx.KeyPress += ValidateInput;
            croissantTxtBox.KeyPress += ValidateInput;
            bagelTxtBox.KeyPress += ValidateInput;
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
            breadTxtBx.Text = breadCount.ToString();
            croissantTxtBox.Text = croissantCount.ToString();
            bagelTxtBox.Text = bagelCount.ToString();
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

        private void breadInc_Click(object sender, EventArgs e) => UpdateCount(breadTxtBx, ref breadCount, true);
        private void breadDec_Click(object sender, EventArgs e) => UpdateCount(breadTxtBx, ref breadCount, false);

        private void croissantInc_Click(object sender, EventArgs e) => UpdateCount(croissantTxtBox, ref croissantCount, true);
        private void croissantDec_Click(object sender, EventArgs e) => UpdateCount(croissantTxtBox, ref croissantCount, false);

        private void bagelInc_Click(object sender, EventArgs e) => UpdateCount(bagelTxtBox, ref bagelCount, false);
        private void bagelDec_Click(object sender, EventArgs e) => UpdateCount(bagelTxtBox, ref bagelCount, true);

        private void breadAddBtn_Click(object sender, EventArgs e)
        {
            if (breadCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Bread", breadCount, breadPrice);
            }
        }

        private void croissantAddBtn_Click(object sender, EventArgs e)
        {
            if (croissantCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Croissant", croissantCount, croissantPrice);
            }
        }

        private void bagelAddBtn_Click(object sender, EventArgs e)
        {
            if (bagelCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Bagel", bagelCount, bagelPrice);
            }
        }
    }
}
