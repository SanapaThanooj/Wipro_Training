using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     class Parameterized
    {
        static void Main()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";
            string query  = "SELECT OrderID, CustomerID, EmployeeID FROM Orders WHERE CustomerID = @CustomerId";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

               
                command.Parameters.AddWithValue("@CustomerId", "ALFKI");
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                      Console.WriteLine($"OrderID: {reader["OrderID"]}, CustomerID: {reader["CustomerID"]}, EmployeeID: {reader["EmployeeID"]}");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
