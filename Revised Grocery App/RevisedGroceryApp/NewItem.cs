using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class NewItem : UserControl
    {
        private int quantity = 0;
        private int itemId;
        private decimal itemPrice;

        public NewItem()
        {
            InitializeComponent();
        }

        public void LoadItemData(int itemid, string name, decimal price, int stock, byte[] imageBytes)
        {
            itemId = itemid;
            itemPrice = price;
            newItemNameLbl.Text = name;
            newItmPriLbl.Text = "₱" + price.ToString("F2");
            newItemStockLbl.Text = "Stock: " + stock.ToString();

            if (imageBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    newItemPictureBox.BackgroundImage = Image.FromStream(ms);
                    newItemPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }

            qtyTextBox.Text = "0";
        }

        // === Public properties ===
        public int ItemId => itemId;
        public string ItemName => newItemNameLbl.Text;
        public int Quantity => quantity;
        public decimal Price => itemPrice;

        // === Buttons ===
        private void minusBtn_Click(object sender, EventArgs e)
        {
            int currentQty;
            if (int.TryParse(qtyTextBox.Text, out currentQty) && currentQty > 0)
            {
                currentQty--;
                qtyTextBox.Text = currentQty.ToString();
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            int currentQty;
            if (int.TryParse(qtyTextBox.Text, out currentQty))
            {
                currentQty++;
                qtyTextBox.Text = currentQty.ToString();
            }
        }

        private void NewItem_Load(object sender, EventArgs e) { }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e) { }
    }
}
