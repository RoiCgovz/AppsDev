using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class Cart : UserControl
    {
        private List<CartItem> cartItems = new List<CartItem>();

        public Cart()
        {
            InitializeComponent();
        }

        public void AddItem(string category, string name, int quantity, decimal price)
        {
            if (quantity <= 0) return;

            CartItem existingItem = cartItems.Find(item => item.Name == name);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                cartItems.Add(new CartItem { Category = category, Name = name, Quantity = quantity, Price = price });
            }

            UpdateCartDisplay();
        }

        private void UpdateCartDisplay()
        {
            cartListBox.Items.Clear();
            decimal subtotal = 0;

            foreach (var item in cartItems)
            {
                decimal totalItemPrice = item.Quantity * item.Price;
                subtotal += totalItemPrice;
                cartListBox.Items.Add($"{item.Name} x{item.Quantity} - ${totalItemPrice:F2}");
            }

            subtotalLabel.Text = $"Subtotal: ${subtotal:F2}";
        }

        public List<CartItem> GetCartItems()
        {
            return cartItems;
        }

        public decimal GetSubtotal()
        {
            decimal subtotal = 0;
            foreach (var item in cartItems)
            {
                subtotal += item.Quantity * item.Price;
            }
            return subtotal;
        }
    }

    public class CartItem
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
