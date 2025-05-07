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
    public partial class SalesAdmin : Form
    {
        public SalesAdmin()
        {
            InitializeComponent();
        }

        private void SalesAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grocerydbDataSet8.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.grocerydbDataSet8.sales);
            // TODO: This line of code loads data into the 'grocerydbDataSet5.salesdetails' table. You can move, or remove it, as needed.
            this.salesdetailsTableAdapter.Fill(this.grocerydbDataSet5.salesdetails);

        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
