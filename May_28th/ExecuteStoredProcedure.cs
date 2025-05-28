using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp6
{
     class ExecuteStoredProcedure
    {
        static void Main()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true;";
            string customerId = "ALFKI"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("CustOrderHist", connection))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Product: {reader["ProductName"]}, Quantity: {reader["Quantity"]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing stored procedure: " + ex.Message);
                }
            }
        }
    }
}
