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
                    Customers.CompanyName, 
                    Employees.FirstName + ' ' + Employees.LastName AS EmployeeName
                FROM 
                    Orders
                INNER JOIN 
                    Customers ON Orders.CustomerID = Customers.CustomerID
                INNER JOIN 
                    Employees ON Orders.EmployeeID = Employees.EmployeeID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("OrderID\tCustomerID\tCompanyName\tEmployeeName");
                    Console.WriteLine("-----------------------------------------------------");
                    while (reader.Read())
                    {
                        int orderId = reader.GetInt32(0);
                        string customerId = reader.GetString(1);
                        string companyName = reader.GetString(2);
                        string employeeName = reader.GetString(3);
                        Console.WriteLine($"{orderId}\t{customerId}\t{companyName}\t{employeeName}");
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
