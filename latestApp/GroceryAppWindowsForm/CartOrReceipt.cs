using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryAppWindowsForm
{
    public partial class CartOrReceipt : Form
    {
        public CartOrReceipt()
        {
            InitializeComponent();
        }
        public void ShowCart()
        {
            cartPnl.Show();
            receiptPnl.Hide();
        }
        public void ShowReceipt()
        {
            cartPnl.Hide();
            receiptPnl.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bckLbl_Click(object sender, EventArgs e)
        {
            MainForm mnu = new MainForm();
            mnu.Show();
            this.Hide();
        }
    }
}
