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
            cartCtrl.Show();
            receiptCtrl.Hide();
        }
        public void ShowReceipt()
        {
            cartCtrl.Hide();
            receiptCtrl.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bckLbl_Click(object sender, EventArgs e)
        {
            MainMenuForm mnu = new MainMenuForm();
            mnu.Show();
            this.Hide();
        }
    }
}
