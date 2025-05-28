using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class NewProducts
    {
        static void Main()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true;";
            string query = "INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice) VALUES (@name, @supplier, @category, @price)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@name", "Test Product");
                command.Parameters.AddWithValue("@supplier", 1);
                command.Parameters.AddWithValue("@category", 1);
                command.Parameters.AddWithValue("@price", 25);

                try
                {
                    connection.Open();
                    int rows = command.ExecuteNonQuery();
                    Console.WriteLine($"{rows} product inserted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }

            
}
