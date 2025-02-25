using System;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class dairyUserControl : UserControl
    {
        // Initialization
        private int milkCount = 0;
        private int cheeseCount = 0;
        private int yogurtCount = 0;
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
            milkTxtBx.Text = milkCount.ToString();
            cheeseTxtBox.Text = cheeseCount.ToString();
            yogurtTxtBox.Text = yogurtCount.ToString();
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
        private void milkInc_Click(object sender, EventArgs e) => UpdateCount(milkTxtBx, ref milkCount, true);
        private void milkDec_Click(object sender, EventArgs e) => UpdateCount(milkTxtBx, ref milkCount, false);

        private void cheeseInc_Click(object sender, EventArgs e) => UpdateCount(cheeseTxtBox, ref cheeseCount, true);
        private void cheeseDec_Click(object sender, EventArgs e) => UpdateCount(cheeseTxtBox, ref cheeseCount, false);

        private void yogurtInc_Click(object sender, EventArgs e) => UpdateCount(yogurtTxtBox, ref yogurtCount, true);
        private void yogurtDec_Click(object sender, EventArgs e) => UpdateCount(yogurtTxtBox, ref yogurtCount, false);

        private void milkAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void cheeseAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void yogurtAddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
