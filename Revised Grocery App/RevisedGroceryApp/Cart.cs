using System;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace RevisedGroceryApp
{
    public partial class Cart : Form
    {
        private decimal grandTotal = 0;

        public Cart()
        {
            InitializeComponent();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryForm existingMainForm = Application.OpenForms.OfType<CategoryForm>().FirstOrDefault();
            if (existingMainForm != null)
            {
                existingMainForm.Show();
            }
            else
            {
                CategoryForm newMainForm = new CategoryForm();
                newMainForm.Show();
            }
        }
        private void checkoutBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
