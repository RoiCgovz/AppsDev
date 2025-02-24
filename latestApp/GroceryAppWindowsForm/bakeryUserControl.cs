using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class bakeryUserControl : UserControl
    {
        // Initialization
        private int breadCount = 0;
        private int croissantCount = 0;
        private int bagelCount = 0;

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

        // Cannot Input letters and symbols in the TextBox
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
            breadTxtBx.Text = breadCount.ToString();
            croissantTxtBox.Text = croissantCount.ToString();
            bagelTxtBox.Text = bagelCount.ToString();

        }
        // Update the Count
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
        private void breadInc_Click(object sender, EventArgs e) => UpdateCount(breadTxtBx, ref breadCount, true);
        private void breadDec_Click(object sender, EventArgs e) => UpdateCount(breadTxtBx, ref breadCount, false);

        
        private void croissantInc_Click(object sender, EventArgs e) => UpdateCount(croissantTxtBox, ref croissantCount, true);
        private void croissantDec_Click(object sender, EventArgs e) => UpdateCount(croissantTxtBox, ref croissantCount, false);

        
        private void bagelInc_Click(object sender, EventArgs e) => UpdateCount(bagelTxtBox, ref bagelCount, true);
        private void bagelDec_Click(object sender, EventArgs e) => UpdateCount(bagelTxtBox, ref bagelCount, false);

        private void breadAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void croissantAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void bagelAddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
