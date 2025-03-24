using System;
using System.Linq;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class Grains : Form
    {
        private const decimal ricePrice = 4.00m;
        private const decimal wheatPrice = 2.40m;
        private const decimal cornPrice = 1.50m;

        public Grains()
        {
            InitializeComponent();
        }
        private void IncrementQuantity(TextBox txtBox)
        {
            int currentValue = int.TryParse(txtBox.Text, out int value) ? value : 0;
            txtBox.Text = (currentValue + 1).ToString();
        }

        private void DecrementQuantity(TextBox txtBox)
        {
            int currentValue = int.TryParse(txtBox.Text, out int value) ? value : 0;
            if (currentValue > 0)
            {
                txtBox.Text = (currentValue - 1).ToString();
            }
        }
        private void riceAdd_Click(object sender, EventArgs e) => IncrementQuantity(riceTxtBox);
        private void riceMin_Click(object sender, EventArgs e) => DecrementQuantity(riceTxtBox);
        private void wheatAdd_Click(object sender, EventArgs e) => IncrementQuantity(wheatTxtBox);
        private void wheatMin_Click(object sender, EventArgs e) => DecrementQuantity(wheatTxtBox);
        private void cornAdd_Click(object sender, EventArgs e) => IncrementQuantity(cornTxtBox);
        private void cornMin_Click(object sender, EventArgs e) => DecrementQuantity(cornTxtBox);

        private void itemToCart_Click(object sender, EventArgs e)
        {
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

        private void xBtn_Click(object sender, EventArgs e) => Application.Exit();

        private void cartBtn_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }
    }
}
