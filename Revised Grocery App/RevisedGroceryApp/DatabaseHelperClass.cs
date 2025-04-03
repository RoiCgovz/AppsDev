using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RevisedGroceryApp
{
    public static class DatabaseHelperClass
    {
        private static readonly string connectionString = "Data Source=DESKTOP-L1QSSAU\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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

        public static Dictionary<string, int> LoadInitialStock()
        {
            Dictionary<string, int> initialStock = new Dictionary<string, int>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT ItemName, Quantity FROM GroceryStock", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string itemName = reader["ItemName"].ToString();
                                int quantity = Convert.ToInt32(reader["Quantity"]);
                                initialStock[itemName] = quantity;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading initial stock: " + ex.Message);
            }

            return initialStock;
        }

        public static void ResetAllStocks()
        {
      
            var initialStock = new Dictionary<string, int>
                    {
                        // Bakery Items
                        { "Croissant", 20 },
                        { "Sliced Bread", 25 },
                        { "Bagel", 30 },

                        // Dairy Items
                        { "Butter", 30 },
                        { "Cheese", 20 },
                        { "Yogurt", 20 },

                        // Beverages Items
                        { "Wine", 30 },
                        { "Juice", 50 },
                        { "Soda", 60 },

                        // Grains Items
                        { "Rice", 1000 },
                        { "Wheat", 90 },
                        { "Corn", 70 },

                        // Produce Items
                        { "Tomato", 40 },
                        { "Cabbage", 30 },
                        { "Carrots", 30 },

                        // Snacks Items
                        { "Chips", 40 },
                        { "Nachos", 30 },
                        { "Cookies", 30 }
                    };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                foreach (var item in initialStock)
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE GroceryStock SET Quantity = @quantity WHERE ItemName = @itemName", conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int) { Value = item.Value });
                        cmd.Parameters.Add(new SqlParameter("@itemName", SqlDbType.NVarChar) { Value = item.Key });

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}
