using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisedGroceryApp.Resources
{
    public partial class Beverages : Form
    {
        public Beverages()
        {
            InitializeComponent();
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

        private void wineMin_Click(object sender, EventArgs e)
        {
            DecrementQuantity(wineTxtBox);
        }

        private void wineAdd_Click(object sender, EventArgs e)
        {
            IncrementQuantity(wineTxtBox);
        }

        private void juiceMin_Click(object sender, EventArgs e)
        {
            DecrementQuantity(juiceTxtBox);
        }

        private void juiceAdd_Click(object sender, EventArgs e)
        {
            IncrementQuantity(juiceTxtBox);
        }

        private void sodaMin_Click(object sender, EventArgs e)
        {
            DecrementQuantity(sodaTxtBox);
        }

        private void sodaAdd_Click(object sender, EventArgs e)
        {
            IncrementQuantity(sodaTxtBox);
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            CategoryForm mainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault();
            if (mainForm != null)
            {
                this.Close();
                mainForm.Show();
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();
        }
    }
}
