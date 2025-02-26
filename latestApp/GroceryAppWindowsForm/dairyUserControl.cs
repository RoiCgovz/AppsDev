using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GroceryAppWindowsForm
{
    public partial class dairyUserControl : UserControl
    {
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
        private void AddItemToCart(string itemName, TextBox textBox, string price, string totalprice)
        {
            MainForm mainForm = this.FindForm() as MainForm;

            if (mainForm != null && mainForm.cartForm != null)
            {
                string itemQty = textBox.Text;
                mainForm.cartForm.AddToCart(itemName, itemQty, price, totalprice);
                mainForm.receipt.AddToReceipt(itemName, itemQty);
                
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

            DialogResult confirm = MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (confirm == DialogResult.OK)
            {
                string milkPrice = "$1.00";
                decimal milkTotal = Convert.ToDecimal(milkTxtBx.Text);
                decimal total = 1.00m * milkTotal;
                string finTotal = Convert.ToString(total);

                AddItemToCart("Milk", milkTxtBx, milkPrice, finTotal);

            }
        }
        private void cheeseAddBtn_Click(object sender, EventArgs e)
        {
           // DialogResult confirm = MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (confirm == DialogResult.OK)
            //{
              //  AddItemToCart("Cheese", cheeseTxtBox);
           // }
        }
          
        private void yogurtAddBtn_Click(object sender, EventArgs e)
        {
           // DialogResult confirm = MessageBox.Show("Item Added to Cart", "Added to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //if (confirm == DialogResult.OK)
            //{
                //AddItemToCart("Yogurt", yogurtTxtBox);
            //}
        }
    }
}
