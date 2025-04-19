using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RevisedGroceryApp
{
    public static class DatabaseHelperClass
    {
        private static readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=grocerydb;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        // Method to get item stock
        public static int GetItemStock(string itemName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
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
                MessageBox.Show($"Error fetching stock: {ex.Message}");
                return 0;
            }
        }

        // Method to update item stock after sale
        public static void UpdateItemStock(string itemName, int quantitySold, DateTime date)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateItemStockAfterSale", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = itemName;
                        cmd.Parameters.Add("@SoldQuantity", SqlDbType.Int).Value = quantitySold;
                        cmd.Parameters.Add("@InventoryDate", SqlDbType.DateTime).Value = date;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating stock: {ex.Message}");
            }
        }

        // Method to get item price
        public static decimal GetItemPrice(string itemName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("GetItemPriceByName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = itemName;
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToDecimal(result) : 0m;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving price: {ex.Message}");
                return 0;
            }
        }

        
    }
}
