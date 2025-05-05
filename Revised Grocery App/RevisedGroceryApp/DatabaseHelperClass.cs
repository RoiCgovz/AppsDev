using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Windows.Markup;

namespace RevisedGroceryApp
{
    public static class DatabaseHelperClass
    {
        private static readonly string 
        connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=grocerydb;" +
                           "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                           "ApplicationIntent=ReadWrite;MultiSubnetFailover=True";
        
        
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

        //Insert UserAcc into Database
        public static bool InsertUserAccount(string userName, string userPass)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO userAcc (userName, userPass) VALUES (@UserName, @UserPass)", conn))
            {
                cmd.Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 20) { Value = userName });
                cmd.Parameters.Add(new SqlParameter("@UserPass", SqlDbType.NVarChar, 20) { Value = userPass });

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
        // Insert Admin Acc into Database
        public static bool InsertAdminAccount(string adminUserName, string adminPass)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("insertAdminAccount", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AdminUserName", adminUserName);
                cmd.Parameters.AddWithValue("@AdminPass", adminPass);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public static bool LoginAccount(string username, string password, out string userType, out int accountId)
        {
            userType = "Invalid";
            accountId = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("accLogin", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlParameter userTypeParam = new SqlParameter("@userType", SqlDbType.NVarChar, 10)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(userTypeParam);

                SqlParameter accountIdParam = new SqlParameter("@accountId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(accountIdParam);

                conn.Open();
                cmd.ExecuteNonQuery();

                userType = userTypeParam.Value?.ToString() ?? "Invalid";
                accountId = accountIdParam.Value != DBNull.Value ? (int)accountIdParam.Value : -1;

                return userType == "User" || userType == "Admin";
            }
        }

    }
}
