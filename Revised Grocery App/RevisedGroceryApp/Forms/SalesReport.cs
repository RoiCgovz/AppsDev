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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace RevisedGroceryApp.Forms
{
    public partial class SalesReport : Form
    {
        private static readonly string connect = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=grocerydb;" +
                           "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                           "ApplicationIntent=ReadWrite;MultiSubnetFailover=True";

        public SalesReport()
        {
            InitializeComponent();
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grocerydbDataSet9.salesreports' table. You can move, or remove it, as needed.
            this.salesreportsTableAdapter2.Fill(this.grocerydbDataSet9.salesreports);

        }

        private void printPDFBtn_Click(object sender, EventArgs e)
        {
            if (salesRepDtaGrdVw.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF Files (*.pdf)|*.pdf";
            save.FileName = "SalesReport.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (PdfWriter writer = new PdfWriter(save.FileName))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document doc = new Document(pdf))
                    {
                        Paragraph title = new Paragraph("Sales Report")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(16);
                        doc.Add(title);

                        Table table = new Table(salesRepDtaGrdVw.ColumnCount, true);

                        foreach (DataGridViewColumn col in salesRepDtaGrdVw.Columns)
                        {
                            table.AddHeaderCell(new Cell().Add(new Paragraph(col.HeaderText)));
                        }

                        foreach (DataGridViewRow row in salesRepDtaGrdVw.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string cellText = cell.Value?.ToString() ?? "";
                                    table.AddCell(new Cell().Add(new Paragraph(cellText)));
                                }
                            }
                        }

                        doc.Add(table);
                        MessageBox.Show("PDF exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void SaveSaleAndDetails(List<Items> items, decimal totalSale)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string insertSaleQuery = "INSERT INTO Sales (saledate) OUTPUT INSERTED.saleid VALUES (GETDATE())";
                    int saleId;

                    using (SqlCommand cmdSale = new SqlCommand(insertSaleQuery, conn, transaction))
                    {
                        saleId = (int)cmdSale.ExecuteScalar();
                    }

                    int totalQuantity = items.Sum(item => item.Quantity);

                    string insertDetailsQuery = @"INSERT INTO SalesDetails 
                                                  (salesdetails_saleid, quantity, salesDetails_totalsale) 
                                                  VALUES (@SaleId, @Quantity, @TotalSale)";

                    using (SqlCommand cmdDetails = new SqlCommand(insertDetailsQuery, conn, transaction))
                    {
                        cmdDetails.Parameters.AddWithValue("@SaleId", saleId);
                        cmdDetails.Parameters.AddWithValue("@Quantity", totalQuantity);
                        cmdDetails.Parameters.AddWithValue("@TotalSale", totalSale);

                        cmdDetails.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
