using System;
using System.Data.SqlClient;

namespace RevisedGroceryApp
{
    public static class DatabaseHelperClass
    {
        private static readonly string connectionString = "Data Source=DESKTOP-L1QSSAU\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static int GetItemStock(string itemName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Quantity FROM GroceryStock WHERE ItemName = @itemName", conn))
                {
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public static void UpdateItemStock(string itemName, int quantitySold)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE GroceryStock SET Quantity = Quantity - @quantity WHERE ItemName = @itemName", conn))
                {
                    cmd.Parameters.AddWithValue("@quantity", quantitySold);
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static decimal GetItemPrice(string itemName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Price FROM GroceryStock WHERE ItemName = @itemName", conn))
                {
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToDecimal(result) : 0;
                }
            }
        }
        public static decimal CalculateTotalPrice(string itemName, int quantity)
        {
            decimal pricePerItem = GetItemPrice(itemName);
            return pricePerItem * quantity;
        }

    }
}
