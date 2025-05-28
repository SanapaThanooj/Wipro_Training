using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp6
{
    class ExecuteStoredProcedure
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Customer ID: ");
            string customerId = Console.ReadLine(); 

            ExecuteCustOrderHist(customerId);
        }

        static void ExecuteCustOrderHist(string customerId)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("CustOrderHist", connection))
            {
                command.CommandType = CommandType.StoredProcedure; 
                command.Parameters.AddWithValue("@CustomerID", customerId); 

                try
                {
                    connection.Open(); 
                    SqlDataReader reader = command.ExecuteReader(); 

                    
                    while (reader.Read())
                    {
                        string productName = reader["ProductName"].ToString();
                        int total = Convert.ToInt32(reader["Total"]);

                        Console.WriteLine($"Product Name: {productName}, Total: {total}");
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

