using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class Produce : UserControl
    {
        // Initialization
        private int cabbageCount = 0;
        private int appleCount = 0;
        private int carrotCount = 0;

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
            cabbageTxtBox.Text = cabbageCount.ToString();
            appleTxtBox.Text = appleCount.ToString();
            carrotsTxtBox.Text = carrotCount.ToString();
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
        private void cabbageInc_Click(object sender, EventArgs e) => UpdateCount(cabbageTxtBox, ref cabbageCount, true);
        private void cabbageDec_Click(object sender, EventArgs e) => UpdateCount(cabbageTxtBox, ref cabbageCount, false);

        private void appleInc_Click(object sender, EventArgs e) => UpdateCount(appleTxtBox, ref appleCount, true);
        private void appleDec_Click(object sender, EventArgs e) => UpdateCount(appleTxtBox, ref appleCount, false);

        private void carrotsInc_Click(object sender, EventArgs e) => UpdateCount(carrotsTxtBox, ref carrotCount, true);
        private void carrotsDec_Click(object sender, EventArgs e) => UpdateCount(carrotsTxtBox, ref carrotCount, false);

        private void cabbageAddBtn_Click(object sender, EventArgs e)
        {
            // Add cabbageCount to cart logic here
        }

        private void appleAddBtn_Click(object sender, EventArgs e)
        {
            // Add appleCount to cart logic here
        }

        private void carrotsAddBtn_Click(object sender, EventArgs e)
        {
            // Add carrotCount to cart logic here
        }
    }
}
