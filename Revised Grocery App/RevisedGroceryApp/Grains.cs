using System;
using System.Collections.Generic;
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

        private void riceAdd_Click(object sender, EventArgs e) => IncrementQuantity(riceTxtBox);
        private void riceMin_Click(object sender, EventArgs e) => DecrementQuantity(riceTxtBox);
        private void wheatAdd_Click(object sender, EventArgs e) => IncrementQuantity(wheatTxtBox);
        private void wheatMin_Click(object sender, EventArgs e) => DecrementQuantity(wheatTxtBox);
        private void cornAdd_Click(object sender, EventArgs e) => IncrementQuantity(cornTxtBox);
        private void cornMin_Click(object sender, EventArgs e) => DecrementQuantity(cornTxtBox);
        private void xBtn_Click(object sender, EventArgs e) => Application.Exit();

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

        private void homeBtn_Click(object sender, EventArgs e)
        {
            CategoryForm mainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault();
            if (mainForm != null)
            {
                this.Hide();
                mainForm.Show();
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            Cart cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault();
            if (cartForm == null)
            {
                cartForm = new Cart();
                cartForm.Show();
            }
            else
            {
                cartForm.BringToFront();
            }
            this.Hide();
        }

        private void itemToCart_Click(object sender, EventArgs e)
        {
            int riceQty = int.TryParse(riceTxtBox.Text, out int rQty) ? rQty : 0;
            int wheatQty = int.TryParse(wheatTxtBox.Text, out int wQty) ? wQty : 0;
            int cornQty = int.TryParse(cornTxtBox.Text, out int cQty) ? cQty : 0;

            List<Items> selectedItems = new List<Items>();

            if (riceQty > 0)
                selectedItems.Add(new Items { Name = "Rice", Quantity = riceQty, Price = ricePrice });

            if (wheatQty > 0)
                selectedItems.Add(new Items { Name = "Wheat", Quantity = wheatQty, Price = wheatPrice });

            if (cornQty > 0)
                selectedItems.Add(new Items { Name = "Corn", Quantity = cornQty, Price = cornPrice });

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one item before adding to the cart.",
                                "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cart cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault();
            if (cartForm == null)
            {
                cartForm = new Cart(selectedItems);
                cartForm.Show();
            }
            else
            {
                cartForm.AddItems(selectedItems);
                cartForm.BringToFront();
            }

            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CategoryForm mainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault();
            if (mainForm != null)
            {
                this.Hide();
                mainForm.Show();
            }
        }
    }
}
