using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Innerjoin
    {
        static void Main()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";
            string query = @"
                SELECT 
                    Orders.OrderID, 
                    Customers.CustomerID, 
                    Customers.CompanyName 
                   
                FROM 
                    Orders
                INNER JOIN 
                    Customers ON Orders.CustomerID = Customers.CustomerID";
               
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("OrderID\tCustomerID\tCompanyName");
                    Console.WriteLine("-----------------------------------------------------");
                    while (reader.Read())
                    {
                        int orderId = reader.GetInt32(0);
                        string customerId = reader.GetString(1);
                        string companyName = reader.GetString(2);
                        
                        Console.WriteLine($"{orderId}\t{customerId}\t{companyName}");
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
