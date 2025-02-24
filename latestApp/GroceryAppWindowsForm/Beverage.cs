using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class Beverage : UserControl
    {
        // Initialization
        private int juiceCount = 0;
        private int wineCount = 0;
        private int sodaCount = 0;

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
            jceTxtBx.Text = juiceCount.ToString();
            wineTxtBox.Text = wineCount.ToString();
            sodaTxtBox.Text = sodaCount.ToString();
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
        private void jceInc_Click(object sender, EventArgs e) => UpdateCount(jceTxtBx, ref juiceCount, true);
        private void jceDec_Click(object sender, EventArgs e) => UpdateCount(jceTxtBx, ref juiceCount, false);

        private void wineInc_Click(object sender, EventArgs e) => UpdateCount(wineTxtBox, ref wineCount, true);
        private void wineDec_Click(object sender, EventArgs e) => UpdateCount(wineTxtBox, ref wineCount, false);

        private void sodaInc_Click(object sender, EventArgs e) => UpdateCount(sodaTxtBox, ref sodaCount, true);
        private void sodaDec_Click(object sender, EventArgs e) => UpdateCount(sodaTxtBox, ref sodaCount, false);

        private void jceAddBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void wineAddBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void sodaAddBtn_Click(object sender, EventArgs e)
        { 

        }
    }
}
