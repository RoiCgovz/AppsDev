using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Windows.Markup;
using RevisedGroceryApp.HelperClasses;


namespace RevisedGroceryApp
{
    public class DatabaseHelperClass
    {
        private static readonly string 
        connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=grocerydb;" +
                           "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                           "ApplicationIntent=ReadWrite;MultiSubnetFailover=True";
        
        // Method to get Item Stockz
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
            string prefixedUserName = "Admin" + adminUserName;

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO adminAcc (adminUserName, adminPass) VALUES (@AdminUserName, @AdminPass)", conn))
            {
                cmd.Parameters.AddWithValue("@AdminUserName", prefixedUserName);
                cmd.Parameters.AddWithValue("@AdminPass", adminPass);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        // Login Method
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

        // Delete item in Items Table based on itemId
        public bool DeleteItemById(int itemId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Items WHERE ItemId = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", itemId);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // Save SalesDetails into SalesDetails and Sales Table in the Database
        public void SaveSaleAndDetails(List<Items> receiptItems, decimal finalTotal)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    SqlCommand insertSaleCmd = new SqlCommand(
                        "INSERT INTO sales (saledate) OUTPUT INSERTED.saleid VALUES (@date)", conn, transaction);
                    insertSaleCmd.Parameters.AddWithValue("@date", DateTime.Now);

                    int saleId = (int)insertSaleCmd.ExecuteScalar();

                    foreach (var item in receiptItems)
                    {
                        decimal itemTotal = item.Quantity * item.Price;

                        SqlCommand insertDetailCmd = new SqlCommand(
                            "INSERT INTO salesdetails (salesdetails_saleid, quantity, salesDetails_totalsale) " +
                            "VALUES (@saleid, @qty, @total)", conn, transaction);

                        insertDetailCmd.Parameters.AddWithValue("@saleid", saleId);
                        insertDetailCmd.Parameters.AddWithValue("@qty", item.Quantity);
                        insertDetailCmd.Parameters.AddWithValue("@total", itemTotal);

                        insertDetailCmd.ExecuteNonQuery();
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

        // Get Inventory ID by Item Name
        public static int GetInventoryIdByItemName(string itemName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT inventoryid FROM inventory WHERE inv_itemid = (SELECT itemid FROM items WHERE itemName = @itemName)", conn))
            {
                cmd.Parameters.AddWithValue("@itemName", itemName);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        // Insert Inv Out Details
        public static int InsertInvOutDetail(int inventoryId, int quantityOut)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@" INSERT INTO invdetails (invDetails_inventoryid, invdetail_qtyout, invDetailsDate)
                                                      VALUES (@invId, @qtyOut, GETDATE());
                                                      SELECT SCOPE_IDENTITY();", conn))
            {
                cmd.Parameters.AddWithValue("@invId", inventoryId);
                cmd.Parameters.AddWithValue("@qtyOut", quantityOut);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }


        // Insert into Inv Reports
        public static void InsertIntoInvReport(int invDetailsId, int outQty)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"INSERT INTO invreports (invreport_invDetailsId, invDetailsItemIn, invDetailsItemOut, invreport_invDetailsDate) 
                                                     VALUES (@id, 0, @outQty, GETDATE())", conn))
            {
                cmd.Parameters.AddWithValue("@id", invDetailsId);
                cmd.Parameters.AddWithValue("@outQty", outQty);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public static List<ImageItem> GetItemsByCategory(string category)
        {
            List<ImageItem> items = new List<ImageItem>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                                    SELECT 
                                        i.itemid, i.itemname, i.itemprice,
                                        inv.inventorystock,
                                        img.imagedata
                                    FROM items i
                                    INNER JOIN inventory inv ON inv.inv_itemid = i.itemid
                                    LEFT JOIN ItemImages img ON img.itemid = i.itemid
                                    WHERE i.itemcategory = @category
                                    ORDER BY inv.inventorydate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@category", category);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ImageItem item = new ImageItem
                                {
                                    ItemId = (int)reader["itemid"],
                                    ItemName = reader["itemname"].ToString(),
                                    ItemPrice = (decimal)reader["itemprice"],
                                    Stock = (int)reader["inventorystock"],
                                    ImageBytes = reader["imagedata"] != DBNull.Value
                                        ? (byte[])reader["imagedata"]
                                        : null
                                };
                                items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return items;
        }

    }
}
