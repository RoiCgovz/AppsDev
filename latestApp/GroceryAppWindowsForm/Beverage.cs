using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class Beverage : UserControl
    {
        private int juiceCount = 0;
        private int wineCount = 0;
        private int sodaCount = 0;

        private const decimal juicePrice = 0.43m;
        private const decimal winePrice = 6.20m;
        private const decimal sodaPrice = 1.30m;

        public Beverage()
        {
            InitializeComponent();
            UpdateTextBoxes();
            AttachKeyPressEvents();
        }

        private void AttachKeyPressEvents()
        {
            jceTxtBx.KeyPress += ValidateInput;
            wineTxtBox.KeyPress += ValidateInput;
            sodaTxtBox.KeyPress += ValidateInput;
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
            jceTxtBx.Text = juiceCount.ToString();
            wineTxtBox.Text = wineCount.ToString();
            sodaTxtBox.Text = sodaCount.ToString();
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

        private void jceInc_Click(object sender, EventArgs e) => UpdateCount(jceTxtBx, ref juiceCount, true);
        private void jceDec_Click(object sender, EventArgs e) => UpdateCount(jceTxtBx, ref juiceCount, false);

        private void wineInc_Click(object sender, EventArgs e) => UpdateCount(wineTxtBox, ref wineCount, true);
        private void wineDec_Click(object sender, EventArgs e) => UpdateCount(wineTxtBox, ref wineCount, false);

        private void sodaInc_Click(object sender, EventArgs e) => UpdateCount(sodaTxtBox, ref sodaCount, true);
        private void sodaDec_Click(object sender, EventArgs e) => UpdateCount(sodaTxtBox, ref sodaCount, false);

        private void jceAddBtn_Click(object sender, EventArgs e)
        {
            if (juiceCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Juice", juiceCount, juicePrice);
            }
        }

        private void wineAddBtn_Click(object sender, EventArgs e)
        {
            if (wineCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Wine", wineCount, winePrice);
            }
        }

        private void sodaAddBtn_Click(object sender, EventArgs e)
        {
            if (sodaCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Soda", sodaCount, sodaPrice);
            }
        }
    }
}
