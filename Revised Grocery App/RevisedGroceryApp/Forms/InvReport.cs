using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Borders;
using iText.Kernel.Font;
using iText.Kernel.Colors;
namespace RevisedGroceryApp.Forms
{
    public partial class InvReport : Form
    {

        private static readonly string
        connect = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=grocerydb;" +
                           "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                           "ApplicationIntent=ReadWrite;MultiSubnetFailover=True";

        public InvReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LogInForm().ShowDialog();
            this.Close();
        }

        private void InvReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grocerydbDataSet11.InvReportsView' table. You can move, or remove it, as needed.
            this.invReportsViewTableAdapter.Fill(this.grocerydbDataSet11.InvReportsView);
           
            // Load inventory data and bind it to the DataGridView
            DataSet dataSet = LoadInventoryReportGrid();
            salesRepDtaGrdVw.DataSource = dataSet.Tables[0]; // Bind the first table from the dataset to DataGridView

          
            salesRepDtaGrdVw.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            List<string> allItems = GetAllItemNames();
            foreach (var item in allItems)
            {
                InsertInventoryDetails(item);
            }
        }

        private void printPDFBtn_Click(object sender, EventArgs e)
        {
            var dataSet = LoadInventoryReportGrid();
            string filePath = "C://Users//deths//Documents//PDF";
            ExportToPdf(dataSet, filePath);
            MessageBox.Show("PDF exported successfully!");
        }


        private void InsertInventoryDetails(string itemName)
        {
            int initialStock = GetInitialStock(itemName);
            int currentStock = GetItemStock(itemName);
            int invOut = initialStock - currentStock;
            int inventoryId = GetLatestInventoryId(itemName);

            if (inventoryId == 0)
            {
                MessageBox.Show("Inventory ID not found for item: " + itemName);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO invdetails 
                (invDetailsItemIn, invDetailsItemOut, invDetails_inventoryid, invDetailsDate)
                VALUES (@in, @out, @invId, @date)", conn))
                    {
                        cmd.Parameters.AddWithValue("@in", initialStock);
                        cmd.Parameters.AddWithValue("@out", invOut);
                        cmd.Parameters.AddWithValue("@invId", inventoryId);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting inventory details: " + ex.Message);
            }
        }

        private int GetInitialStock(string itemName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 inventoryStock FROM ItemsInventory WHERE itemName = @name ORDER BY inventoryDate ASC", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", itemName);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching initial stock: " + ex.Message);
                return 0;
            }
        }

        private int GetItemStock(string itemName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetItemStock", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = itemName;
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching current stock: {ex.Message}");
                return 0;
            }
        }

        private int GetLatestInventoryId(string itemName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    string query = @"
                                    SELECT TOP 1 i.inventoryid FROM inventory i
                                    INNER JOIN items it ON i.inv_itemid = it.itemid
                                    WHERE it.itemName = @name
                                    ORDER BY i.inventorydate DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", itemName);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching inventory ID: " + ex.Message);
                return 0;
            }
        }
        private List<string> GetAllItemNames()
        {
            List<string> itemNames = new List<string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT itemName FROM Items", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                itemNames.Add(reader.GetString(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching item names: " + ex.Message);
            }
            return itemNames;
        }

        private DataSet LoadInventoryReportGrid()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string query = @"
            SELECT 
                i.itemName AS [Item Name],
                i.itemCategory AS [Category],
                d.invDetailsItemIn AS [Stock In],
                d.invDetailsItemOut AS [Stock Out],
                d.invDetailsDate AS [Date]
            FROM invdetails d
            INNER JOIN inventory inv ON d.invDetails_inventoryid = inv.inventoryid
            INNER JOIN items i ON inv.inv_itemid = i.itemid
            ORDER BY d.invDetailsDate DESC";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }

        private void ExportToPdf(DataSet dataSet, string filePath)
        {
            // Create a SaveFileDialog to let the user select the save location
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"; // Filter to show only PDF files
                saveFileDialog.DefaultExt = "pdf"; // Set default file extension
                saveFileDialog.AddExtension = true; // Automatically add the .pdf extension if omitted

                // Show the SaveFileDialog and check if the user selected a file
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path selected by the user
                    string file_Path = saveFileDialog.FileName;

                    // Create the PdfWriter and PdfDocument instances
                    using (var writer = new PdfWriter(file_Path))
                    using (var pdf = new PdfDocument(writer))
                    using (var document = new Document(pdf))
                    {
                        // Iterate through all DataTables in the DataSet
                        foreach (DataTable table in dataSet.Tables)
                        {
                            // Create a new table for the current DataTable
                            var pdfTable = new Table(table.Columns.Count, true);

                            // Add header cells (column names) to the PDF table
                            foreach (DataColumn column in table.Columns)
                            {
                                pdfTable.AddHeaderCell(new Cell().Add(new Paragraph(column.ColumnName))
                                    .SetTextAlignment(TextAlignment.CENTER)
                                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                            }

                            // Add rows of data from the DataTable to the PDF table
                            foreach (DataRow row in table.Rows)
                            {
                                foreach (var item in row.ItemArray)
                                {
                                    pdfTable.AddCell(new Cell().Add(new Paragraph(item.ToString()))
                                        .SetTextAlignment(TextAlignment.CENTER));
                                }
                            }

                            // Add the table to the document
                            document.Add(pdfTable);
                        }
                    }

                    // Inform the user that the PDF has been saved
                    MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
