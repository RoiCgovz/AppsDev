using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public partial class InvAdmin : Form
    {
        public InvAdmin()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            Close();    
        }

        private void InvAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grocerydbDataSet7.ItemsInventory' table. You can move, or remove it, as needed.
            this.itemsInventoryTableAdapter.Fill(this.grocerydbDataSet7.ItemsInventory);


            LoadData();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            accActionPanel.Visible = !accActionPanel.Visible;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            new InvAdmin().Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            updatepnl.Hide();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            updatepnl.Show();   
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string itemName = nametxtbox.Content.Trim().ToLower();  // Assuming .Content is an incorrect reference
            if (!decimal.TryParse(pricetxtbox.Content, out decimal itemPrice) ||
                !int.TryParse(stocktxtbox.Content, out int itemStock))
            {
                MessageBox.Show("Invalid price or stock.");
                return;
            }

            string itemCategory = categorycombobox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(itemCategory))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            // Connection string
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=grocerydb;" +
                                       "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                                       "TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // MERGE SQL statement to update existing item or insert new if not found
                string query = @"
            MERGE INTO ItemsInventory AS target
            USING (SELECT @ItemName AS itemName, @ItemCategory AS itemCategory) AS source
            ON target.itemName = source.itemName AND target.itemCategory = source.itemCategory
            WHEN MATCHED THEN
                UPDATE SET target.itemPrice = @ItemPrice, target.inventoryStock = @ItemStock
            WHEN NOT MATCHED THEN
                INSERT (itemName, itemCategory, itemPrice, inventoryStock)
                VALUES (@ItemName, @ItemCategory, @ItemPrice, @ItemStock);
        ";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@ItemCategory", itemCategory);
                    cmd.Parameters.AddWithValue("@ItemPrice", itemPrice);
                    cmd.Parameters.AddWithValue("@ItemStock", itemStock);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Item price and stock updated successfully.");
                    else
                        MessageBox.Show("Item not found.");
                }
            }

            // Refresh the data after the operation
            LoadData();
            SaveStockDetails();
            updatepnl.Hide();
        }


        private void updatepnl_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=grocerydb;" +
                           "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                           "ApplicationIntent=ReadWrite;MultiSubnetFailover=True"))
            {
                string query = "SELECT * FROM ItemsInventory";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    salesRepDtaGrdVw.DataSource = table;

                    // Set custom column headers
                    if (salesRepDtaGrdVw.Columns.Contains("mergedId"))
                        salesRepDtaGrdVw.Columns["mergedId"].HeaderText = "Merged ID";
                    if (salesRepDtaGrdVw.Columns.Contains("itemid"))
                        salesRepDtaGrdVw.Columns["itemid"].HeaderText = "Item ID";
                    if (salesRepDtaGrdVw.Columns.Contains("itemname"))
                        salesRepDtaGrdVw.Columns["itemname"].HeaderText = "Item Name";
                    if (salesRepDtaGrdVw.Columns.Contains("itemcategory"))
                        salesRepDtaGrdVw.Columns["itemcategory"].HeaderText = "Category";
                    if (salesRepDtaGrdVw.Columns.Contains("itemprice"))
                        salesRepDtaGrdVw.Columns["itemprice"].HeaderText = "Price";
                    if (salesRepDtaGrdVw.Columns.Contains("inventoryid"))
                        salesRepDtaGrdVw.Columns["inventoryid"].HeaderText = "Inventory ID";
                    if (salesRepDtaGrdVw.Columns.Contains("inventorydate"))
                        salesRepDtaGrdVw.Columns["inventorydate"].HeaderText = "Date";
                    if (salesRepDtaGrdVw.Columns.Contains("inventorystock"))
                        salesRepDtaGrdVw.Columns["inventorystock"].HeaderText = "Stock";
                }
            }
        }

        private void pricetxtbox_ContentChanged(object sender, EventArgs e)
        {

        }


        private void SaveStockDetails()
        {
            // Get the selected category and stock from the UI controls
            string itemCategory = categorycombobox.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(itemCategory))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            // Get the stock quantity from the stocktxtbox
            if (!int.TryParse(stocktxtbox.Content?.ToString(), out int itemStock))
            {
                MessageBox.Show("Invalid stock value.");
                return;
            }

            // Database connection
            using (SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=grocerydb;Integrated Security=True;"))
            {
                try
                {
                    // Open the connection
                    con.Open();

                    // Get the itemId for the selected category and name
                    string getItemIdQuery = @"
                SELECT itemid FROM items 
                WHERE itemcategory = @itemCategory 
                AND itemname = @itemName"; // Assuming itemname is also selected/available in the UI
                    int itemId = 0;

                    using (SqlCommand cmd = new SqlCommand(getItemIdQuery, con))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@itemCategory", itemCategory);
                        cmd.Parameters.AddWithValue("@itemName", nametxtbox.Text); // Assuming nametxtbox is the TextBox for item name

                        // Get the itemId for the selected category and name
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            itemId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Item not found.");
                            return;
                        }
                    }

                    // Get the current stock for the item
                    string getCurrentStockQuery = @"
                SELECT inventorystock 
                FROM inventory 
                WHERE inv_itemid = @itemId
                ORDER BY inventorydate DESC 
                OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";

                    int currentStock = 0;
                    using (SqlCommand cmd = new SqlCommand(getCurrentStockQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@itemId", itemId);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            currentStock = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Item inventory not found.");
                            return;
                        }
                    }

                    // Calculate the outgoing stock
                    int initialStock = itemStock; // Assume itemStock is the initial stock input
                    int itemOut = initialStock - currentStock; // Outgoing stock: difference between initial stock and current stock

                    // Get the inventory ID from the inventory table for this item
                    string getInventoryIdQuery = @"
                SELECT inventoryid 
                FROM inventory 
                WHERE inv_itemid = @itemId 
                ORDER BY inventorydate DESC 
                OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY";

                    int inventoryId = 0;
                    using (SqlCommand cmd = new SqlCommand(getInventoryIdQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@itemId", itemId);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            inventoryId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Inventory record not found.");
                            return;
                        }
                    }

                    // Insert into invdetails table
                    string insertQuery = @"
                INSERT INTO invdetails (invDetailsItemIn, invDetailsItemOut, invDetails_inventoryid, invDetailsDate)
                VALUES (@itemIn, @itemOut, @inventoryId, @inventoryDate)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@itemIn", initialStock); // Incoming stock
                        cmd.Parameters.AddWithValue("@itemOut", itemOut); // Outgoing stock
                        cmd.Parameters.AddWithValue("@inventoryId", inventoryId); // Linked inventory record ID
                        cmd.Parameters.AddWithValue("@inventoryDate", DateTime.Now); // Current date

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stock details saved successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to save stock details.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


    }
}
