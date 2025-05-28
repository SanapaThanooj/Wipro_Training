using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     class iNSERToRDER
    {
        static void Main()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand insertOrder = new SqlCommand(
                        "INSERT INTO Orders (CustomerID, OrderDate) VALUES ('ALFKI', GETDATE()); SELECT SCOPE_IDENTITY();",
                        connection, transaction);

                    int orderId = Convert.ToInt32(insertOrder.ExecuteScalar());

                    SqlCommand insertDetails = new SqlCommand(
                        "INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity) VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity)",
                        connection, transaction);

                    insertDetails.Parameters.AddWithValue("@OrderID", orderId);
                    insertDetails.Parameters.AddWithValue("@ProductID", 1);
                    insertDetails.Parameters.AddWithValue("@UnitPrice", 10);
                    insertDetails.Parameters.AddWithValue("@Quantity", 5);

                    insertDetails.ExecuteNonQuery();

                    transaction.Commit();
                    Console.WriteLine("Order and details inserted successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction rolled back due to error: " + ex.Message);
                }
            }
        }

    }
}
