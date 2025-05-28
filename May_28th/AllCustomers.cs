using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     class AllCustomers
    {
        static void Main()
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;";


            string query = "SELECT CustomerID, CompanyName, Country FROM Customers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("CustomerID\tCompanyName\t\tCountry");
                    Console.WriteLine("-----------------------------------------------------");

                    while (reader.Read())
                    {
                        string customerId = reader["CustomerID"].ToString();
                        string companyName = reader["CompanyName"].ToString();
                        string country = reader["Country"].ToString();

                        Console.WriteLine($"{customerId}\t\t{companyName,-25}\t{country}");
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

