using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class dairyUserControl : UserControl
    {
        private int milkCount = 0;
        private int cheeseCount = 0;
        private int yogurtCount = 0;

        private const decimal milkPrice = 1.00m;
        private const decimal cheesePrice = 2.50m;
        private const decimal yogurtPrice = 1.75m;

        public dairyUserControl()
        {
            InitializeComponent();
            UpdateTextBoxes();
            AttachKeyPressEvents();
        }

        private void AttachKeyPressEvents()
        {
            milkTxtBx.KeyPress += ValidateInput;
            cheeseTxtBox.KeyPress += ValidateInput;
            yogurtTxtBox.KeyPress += ValidateInput;
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
            milkTxtBx.Text = milkCount.ToString();
            cheeseTxtBox.Text = cheeseCount.ToString();
            yogurtTxtBox.Text = yogurtCount.ToString();
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
                string totalPriceStr = total.ToString("C"); // Formats as currency

                MainForm mainForm = this.FindForm() as MainForm;
                if (mainForm != null && mainForm.cartForm != null)
                {
                    mainForm.cartForm.AddToCart(itemName, quantity, price, totalPriceStr);
                    mainForm.receipt.AddToReceipt(itemName, quantity.ToString());
                }
            }
        }

        private void milkInc_Click(object sender, EventArgs e) => UpdateCount(milkTxtBx, ref milkCount, true);
        private void milkDec_Click(object sender, EventArgs e) => UpdateCount(milkTxtBx, ref milkCount, false);

        private void cheeseInc_Click(object sender, EventArgs e) => UpdateCount(cheeseTxtBox, ref cheeseCount, true);
        private void cheeseDec_Click(object sender, EventArgs e) => UpdateCount(cheeseTxtBox, ref cheeseCount, false);

        private void yogurtInc_Click(object sender, EventArgs e) => UpdateCount(yogurtTxtBox, ref yogurtCount, true);
        private void yogurtDec_Click(object sender, EventArgs e) => UpdateCount(yogurtTxtBox, ref yogurtCount, false);

        private void milkAddBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(milkTxtBx.Text);
            if (quantity > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Milk", quantity, milkPrice);
            }
        }

        private void cheeseAddBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(cheeseTxtBox.Text);
            if (quantity > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Cheese", quantity, cheesePrice);
            }
        }

        private void yogurtAddBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(yogurtTxtBox.Text);
            if (quantity > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Yogurt", quantity, yogurtPrice);
            }
        }
    }
}