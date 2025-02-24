using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class Grains : UserControl
    {
        // Initialization
        private int riceCount = 0;
        private int wheatCount = 0;
        private int cornCount = 0;

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
            riceTxtBox.Text = riceCount.ToString();
            wheatTxtBox.Text = wheatCount.ToString();
            cornTxtBox.Text = cornCount.ToString();
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
        private void riceInc_Click(object sender, EventArgs e) => UpdateCount(riceTxtBox, ref riceCount, true);
        private void riceDec_Click(object sender, EventArgs e) => UpdateCount(riceTxtBox, ref riceCount, false);

        private void wheatInc_Click(object sender, EventArgs e) => UpdateCount(wheatTxtBox, ref wheatCount, true);
        private void wheatDec_Click(object sender, EventArgs e) => UpdateCount(wheatTxtBox, ref wheatCount, false);

        private void cornDec_Click(object sender, EventArgs e) => UpdateCount(cornTxtBox, ref cornCount, false);
        private void cornInc_Click(object sender, EventArgs e) => UpdateCount(cornTxtBox, ref cornCount, true);

        private void cornAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void wheatAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void riceAddBtn_Click(object sender, EventArgs e)
        {

        }

       
    }
}
