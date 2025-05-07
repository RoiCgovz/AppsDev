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
    public partial class ItemsAdmin : Form
    {
        public ItemsAdmin()
        {
            InitializeComponent();
        }

        private void ItemsAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grocerydbDataSet3.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter2.Fill(this.grocerydbDataSet3.items);
            // TODO: This line of code loads data into the 'dataSet2.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter1.Fill(this.dataSet2.items);
            // TODO: This line of code loads data into the 'dataSet1.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.dataSet1.items);
            AddDeleteButtonToGrid();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (itemsDtaGrdVw.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                DataGridViewRow row = itemsDtaGrdVw.Rows[e.RowIndex];
                int itemId = Convert.ToInt32(row.Cells["itemid"].Value);
                string itemName = row.Cells["itemname"].Value.ToString();

                DialogResult result = MessageBox.Show($"Delete item '{itemName}' (ID: {itemId})?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DatabaseHelperClass dbHelper = new DatabaseHelperClass();
                    bool success = dbHelper.DeleteItemById(itemId);

                    if (success)
                    {
                        itemsDtaGrdVw.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Item and inventory deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete item.");
                    }
                }
            }
        }

        private void AddDeleteButtonToGrid()
        {
            if (!itemsDtaGrdVw.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.UseColumnTextForButtonValue = true;
                itemsDtaGrdVw.Columns.Add(btnDelete);
            }
        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            accActionPanel.Visible = !accActionPanel.Visible ;
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0 );   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm log = new LogInForm();
            log.ShowDialog();
        }
    }
}
