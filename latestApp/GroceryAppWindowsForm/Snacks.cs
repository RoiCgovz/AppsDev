using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class Snacks : UserControl
    {
        // Initialization
        private int nanaCount = 0;
        private int nachoCount = 0;
        private int cookieCount = 0;

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

        // Prevent letters and symbols in the TextBox
        private void ValidateInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Method to update textboxes
        private void UpdateTextBoxes()
        {
            nanaTxtBx.Text = nanaCount.ToString();
            nachoTxtBox.Text = nachoCount.ToString();
            cookieTxtBox.Text = cookieCount.ToString();
        }

        // Update the count
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

        // Buttons
        private void nanaInc_Click(object sender, EventArgs e) => UpdateCount(nanaTxtBx, ref nanaCount, true);
        private void nanaDec_Click(object sender, EventArgs e) => UpdateCount(nanaTxtBx, ref nanaCount, false);

        private void nachoInc_Click(object sender, EventArgs e) => UpdateCount(nachoTxtBox, ref nachoCount, true);
        private void nachoDec_Click(object sender, EventArgs e) => UpdateCount(nachoTxtBox, ref nachoCount, false);

        private void cookieInc_Click(object sender, EventArgs e) => UpdateCount(cookieTxtBox, ref cookieCount, true);
        private void cookieDec_Click(object sender, EventArgs e) => UpdateCount(cookieTxtBox, ref cookieCount, false);

        private void nanaAddBtn_Click(object sender, EventArgs e)
        {
            // Add nanaCount to cart logic here
        }

        private void nachoAddBtn_Click(object sender, EventArgs e)
        {
            // Add nachoCount to cart logic here
        }

        private void cookieAddBtn_Click(object sender, EventArgs e)
        {
            // Add cookieCount to cart logic here
        }

       
    }
}
