using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class ItemsAdmin : Form
    {
        private static readonly string
        connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=grocerydb;" +
                           "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                           "ApplicationIntent=ReadWrite;MultiSubnetFailover=True";
        public ItemsAdmin()
        {
            InitializeComponent();
        }

        private void ItemsAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grocerydbDataSet13.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter3.Fill(this.grocerydbDataSet13.items);

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

        private void addBtn_Click(object sender, EventArgs e)
        {
            addpnl.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            addpnl.Hide();

        }

        private void pickPicBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a picture";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    additmPicBox.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                    additmPicBox.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(nametxtbox.Content) ||
                additmPicBox.BackgroundImage == null ||
                categoryComboBox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(additmStkTxtBx.Content) ||
                string.IsNullOrWhiteSpace(additmPriTxtBx.Content))
            {
                MessageBox.Show("Please fill in all required fields and select an image.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Convert image to byte array
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    additmPicBox.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }

                // Read and convert other values
                string name = nametxtbox.Content.Trim();
                string category = categoryComboBox.SelectedItem.ToString();
                decimal price = decimal.Parse(additmPriTxtBx.Content.Trim());
                int stock = int.Parse(additmStkTxtBx.Content.Trim());

                // Insert into items table first
                int newItemId;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert into items
                    string insertItemQuery = "INSERT INTO items (itemname, itemcategory, itemprice) OUTPUT INSERTED.itemid VALUES (@name, @category, @price)";
                    using (SqlCommand cmd = new SqlCommand(insertItemQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@price", price);
                        newItemId = (int)cmd.ExecuteScalar();
                    }

                    // Insert into inventory
                    string insertInventoryQuery = "INSERT INTO inventory (inv_itemid, inventorydate, inventorystock) VALUES (@itemid, @date, @stock)";
                    using (SqlCommand cmd = new SqlCommand(insertInventoryQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@itemid", newItemId);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.ExecuteNonQuery();
                    }

                    // Insert image into ItemImages table
                    string insertImageQuery = "INSERT INTO ItemImages (itemid, imagename, imagedata) VALUES (@itemid, @name, @data)";
                    using (SqlCommand cmd = new SqlCommand(insertImageQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@itemid", newItemId);
                        cmd.Parameters.AddWithValue("@name", $"{name}_image");
                        cmd.Parameters.AddWithValue("@data", imageBytes);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Item saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
