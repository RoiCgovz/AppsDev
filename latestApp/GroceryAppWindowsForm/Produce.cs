using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class Produce : UserControl
    {
        private int cabbageCount = 0;
        private int appleCount = 0;
        private int carrotCount = 0;

        private const decimal cabbagePrice = 1.70m;
        private const decimal applePrice = 5.26m;
        private const decimal carrotPrice = 2.45m;

        public Produce()
        {
            InitializeComponent();
            UpdateTextBoxes();
            AttachKeyPressEvents();
        }

        private void AttachKeyPressEvents()
        {
            cabbageTxtBox.KeyPress += ValidateInput;
            appleTxtBox.KeyPress += ValidateInput;
            carrotsTxtBox.KeyPress += ValidateInput;
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
            cabbageTxtBox.Text = cabbageCount.ToString();
            appleTxtBox.Text = appleCount.ToString();
            carrotsTxtBox.Text = carrotCount.ToString();
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
        private void cabbageInc_Click(object sender, EventArgs e) => UpdateCount(cabbageTxtBox, ref cabbageCount, true);
        private void cabbageDec_Click(object sender, EventArgs e) => UpdateCount(cabbageTxtBox, ref cabbageCount, false);

        private void appleInc_Click(object sender, EventArgs e) => UpdateCount(appleTxtBox, ref appleCount, true);
        private void appleDec_Click(object sender, EventArgs e) => UpdateCount(appleTxtBox, ref appleCount, false);

        private void carrotsInc_Click(object sender, EventArgs e) => UpdateCount(carrotsTxtBox, ref carrotCount, true);
        private void carrotsDec_Click(object sender, EventArgs e) => UpdateCount(carrotsTxtBox, ref carrotCount, false);

        private void cabbageAddBtn_Click(object sender, EventArgs e)
        {
            if (cabbageCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Cabbage", cabbageCount, cabbagePrice);
            }
        }

        private void appleAddBtn_Click(object sender, EventArgs e)
        {
            if (appleCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Apple", appleCount, applePrice);
            }
        }

        private void carrotsAddBtn_Click(object sender, EventArgs e)
        {
            if (carrotCount > 0)
            {
                MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddItemToCart("Carrot", carrotCount, carrotPrice);
            }
        }
    }
}
