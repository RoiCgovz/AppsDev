using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class Grains : Form
    {
        public Grains()
        {
            InitializeComponent();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IncrementQuantity(TextBox txtBox)
        {
            int currentValue = int.TryParse(txtBox.Text, out int value) ? value : 0;
            txtBox.Text = (currentValue + 1).ToString();
        }

        private void DecrementQuantity(TextBox textBox)
        {
            int currentValue = int.TryParse(textBox.Text, out int value) ? value : 0;
            if (currentValue > 0)
            {
                textBox.Text = (currentValue - 1).ToString();
            }
        }

        // Rice Handlers
        private void riceAdd_Click(object sender, EventArgs e)
        {
            IncrementQuantity(riceTxtBox);
        }

        private void riceMin_Click(object sender, EventArgs e)
        {
            DecrementQuantity(riceTxtBox);
        }

        // Wheat Handlers
        private void wheatAdd_Click(object sender, EventArgs e)
        {
            IncrementQuantity(wheatTxtBox);
        }

        private void wheatMin_Click(object sender, EventArgs e)
        {
            DecrementQuantity(wheatTxtBox);
        }

        // Corn Handlers
        private void cornAdd_Click(object sender, EventArgs e)
        {
            IncrementQuantity(cornTxtBox);
        }

        private void cornMin_Click(object sender, EventArgs e)
        {
            DecrementQuantity(cornTxtBox);
        }

        private void bevBtn_Click(object sender, EventArgs e)
        {

        }

        private void bakeBtn_Click(object sender, EventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Close();
        }
    }
}
