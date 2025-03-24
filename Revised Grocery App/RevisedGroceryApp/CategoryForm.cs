using RevisedGroceryApp.Resources;
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
    public partial class CategoryForm : Form
    {
        public Cart cartForm;
        public Receipt receiptForm;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void daiVwMr_Click(object sender, EventArgs e)
        {

        }

        private void gnVwMr_Click(object sender, EventArgs e)
        {
            Grains grain = new Grains();
            this.Hide();
            grain.Show();
        }

        private void bkryVwMr_Click(object sender, EventArgs e)
        {

        }

        private void prodVwMr_Click(object sender, EventArgs e)
        {

        }

        private void snksVwMr_Click(object sender, EventArgs e)
        {

        }

        private void bevVwMr_Click(object sender, EventArgs e)
        {
            Beverages bev = new Beverages();
            bev.Show();
            this.Hide();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (cartForm == null || cartForm.IsDisposed)
            {
                cartForm = new Cart();
            }
            this.Hide();
            cartForm.Show();
        }
    }
}
