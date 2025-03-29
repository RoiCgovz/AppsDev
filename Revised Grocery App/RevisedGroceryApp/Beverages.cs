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
        private const decimal winePrice = 15.35m;
        private const decimal juicePrice = 3.00m;
        private const decimal sodaPrice = 1.50m;
        public Beverages()
        {
            InitializeComponent();
        }
        private void wineMin_Click(object sender, EventArgs e) => DecrementQuantity(wineTxtBox);
        private void wineAdd_Click(object sender, EventArgs e) => IncrementQuantity(wineTxtBox);
        private void juiceMin_Click(object sender, EventArgs e) => DecrementQuantity(juiceTxtBox);
        private void juiceAdd_Click(object sender, EventArgs e) => IncrementQuantity(juiceTxtBox);
        private void sodaMin_Click(object sender, EventArgs e) => DecrementQuantity(sodaTxtBox);
        private void sodaAdd_Click(object sender, EventArgs e) => IncrementQuantity(sodaTxtBox);

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
        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void itemToCart_Click_1(object sender, EventArgs e)
        {
            int wineQty = int.TryParse(wineTxtBox.Text, out int wQty) ? wQty : 0;
            int juiceQty = int.TryParse(juiceTxtBox.Text, out int jQty) ? jQty : 0;
            int sodaQty = int.TryParse(sodaTxtBox.Text, out int sQty) ? sQty : 0;

            if (wineQty == 0 && juiceQty == 0 && sodaQty == 0)
            {
                MessageBox.Show("Please select at least one item before adding to the cart.",
                                "No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Items> selectedItems = new List<Items>
            {
                new Items { Name = "Wine", Quantity = wineQty, Price = winePrice },
                new Items { Name = "Juice", Quantity = juiceQty, Price = juicePrice },
                new Items { Name = "Soda", Quantity = sodaQty, Price = sodaPrice }
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
            this.Hide();
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            Produce p = new Produce();
            p.Show();
            this.Close();
        }

        private void daiBtn_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            dairy.Show();
            this.Close();
        }

        private void grnBtn_Click(object sender, EventArgs e)
        {
            Grains grains = new Grains();
            grains.Show();
            this.Close();
        }

        private void snksBtn_Click(object sender, EventArgs e)
        {
            Snacks sn = new Snacks();
            sn.Show();
            this.Close();
        }
    }
}
