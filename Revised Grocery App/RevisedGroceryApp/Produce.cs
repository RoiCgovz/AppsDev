using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace RevisedGroceryApp
{
    public partial class Produce : Form
    {
        private const decimal tomatoPrice = 1.00m;
        private const decimal cabbagePrice = 1.50m;
        private const decimal carrotPrice = 1.20m;

        public Produce()
        {
            InitializeComponent();
        }

        private void tomatoMin_Click(object sender, EventArgs e) => DecrementQuantity(tomatoTxtBox);
        private void tomatoAdd_Click(object sender, EventArgs e) => IncrementQuantity(tomatoTxtBox);
        private void cabbageMin_Click(object sender, EventArgs e) => DecrementQuantity(cabbageTxtBox);
        private void cabbageAdd_Click(object sender, EventArgs e) => IncrementQuantity(cabbageTxtBox);
        private void carrotsMin_Click(object sender, EventArgs e) => DecrementQuantity(carrotsTxtBox);
        private void carrotsAdd_Click(object sender, EventArgs e) => IncrementQuantity(carrotsTxtBox);

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
            if (mainForm == null)
            {
                mainForm = new CategoryForm();
                mainForm.Show();
            }
            else
            {
                mainForm.Show();
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            Cart cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault();
            if (cartForm == null)
            {
                cartForm = new Cart(CategoryForm.CartItems);
                cartForm.Show();
            }
            else
            {
                cartForm.Show();
            }
            this.Close();
        }

        private void itemToCart_Click(object sender, EventArgs e)
        {
            int tomatoQty = int.TryParse(tomatoTxtBox.Text, out int tQty) ? tQty : 0;
            int cabbageQty = int.TryParse(cabbageTxtBox.Text, out int cQty) ? cQty : 0;
            int carrotQty = int.TryParse(carrotsTxtBox.Text, out int crQty) ? crQty : 0;

            if (tomatoQty == 0 && cabbageQty == 0 && carrotQty == 0)
            {
                MessageBox.Show("Please select at least one item before adding to the cart.",
                                "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Items> selectedItems = new List<Items>
            {
                new Items { Name = "Tomato", Quantity = tomatoQty, Price = tomatoPrice },
                new Items { Name = "Cabbage", Quantity = cabbageQty, Price = cabbagePrice },
                new Items { Name = "Carrots", Quantity = carrotQty, Price = carrotPrice }
            };

            foreach (var newItem in selectedItems)
            {
                if (newItem.Quantity > 0)
                {
                    var existingItem = CategoryForm.CartItems.FirstOrDefault(i => i.Name == newItem.Name);
                    if (existingItem != null)
                    {
                        existingItem.Quantity += newItem.Quantity;
                    }
                    else
                    {
                        CategoryForm.CartItems.Add(newItem);
                    }
                }
            }

            Cart cartForm = Application.OpenForms.OfType<Cart>().FirstOrDefault();
            if (cartForm == null)
            {
                cartForm = new Cart(CategoryForm.CartItems);
                cartForm.Show();
            }
            else
            {
                cartForm.LoadCartItems(CategoryForm.CartItems);
                cartForm.Show();
            }
            this.Close();
        }

        private void bakeBtn_Click(object sender, EventArgs e)
        {
            Bakery bake = new Bakery();
            bake.Show();
            this.Close();
        }

        private void bevBtn_Click(object sender, EventArgs e)
        {
            Beverages bev = new Beverages();
            bev.Show();
            this.Close();
        }

        private void dairyBtn_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            dairy.Show();
            this.Close();
        }

        private void grainsBtn_Click(object sender, EventArgs e)
        {
            Grains grains = new Grains();
            grains.Show();
            this.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            CategoryForm mainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault();
            if (mainForm == null)
            {
                mainForm = new CategoryForm();
                mainForm.Show();
            }
            else
            {
                mainForm.Show();
            }
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void snksBtn_Click(object sender, EventArgs e)
        {
            Snacks sn = new Snacks();
            sn.Show();
            this.Close();
        }
    }
}
