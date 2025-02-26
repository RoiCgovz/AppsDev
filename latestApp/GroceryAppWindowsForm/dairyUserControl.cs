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

        private void milkInc_Click(object sender, EventArgs e) => UpdateCount(milkTxtBx, ref milkCount, true);
        private void milkDec_Click(object sender, EventArgs e) => UpdateCount(milkTxtBx, ref milkCount, false);

        private void cheeseInc_Click(object sender, EventArgs e) => UpdateCount(cheeseTxtBox, ref cheeseCount, true);
        private void cheeseDec_Click(object sender, EventArgs e) => UpdateCount(cheeseTxtBox, ref cheeseCount, false);

        private void yogurtInc_Click(object sender, EventArgs e) => UpdateCount(yogurtTxtBox, ref yogurtCount, true);
        private void yogurtDec_Click(object sender, EventArgs e) => UpdateCount(yogurtTxtBox, ref yogurtCount, false);

        private void milkAddBtn_Click(object sender, EventArgs e)
        {
            if (milkCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Milk", milkCount, milkPrice);
            }
        }

        private void cheeseAddBtn_Click(object sender, EventArgs e)
        {
            if (cheeseCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Cheese", cheeseCount, cheesePrice);
            }
        }

        private void yogurtAddBtn_Click(object sender, EventArgs e)
        {
            if (yogurtCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Yogurt", yogurtCount, yogurtPrice);
            }
        }
    }
}

