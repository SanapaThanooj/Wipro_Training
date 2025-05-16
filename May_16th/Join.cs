using System;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Program rd = new Program();
            rd.SimpleReadWithJoin();
        }

        public void SimpleReadWithJoin()
        {
            SqlDataReader rdr = null;
            SqlConnection conn = null;

            try
            {

                conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");


                string query = @"
                    SELECT 
                        o.OrderID, 
                        o.OrderDate, 
                        c.CompanyName, 
                        c.ContactName
                    FROM Orders o
                    INNER JOIN Customers c ON o.CustomerID = c.CustomerID
                    ORDER BY o.OrderDate DESC";


                SqlCommand cmd = new SqlCommand(query, conn);


                conn.Open();


                rdr = cmd.ExecuteReader();

                // Print headers
                Console.WriteLine("{0,-10}{1,-15}{2,-30}{3,-25}", "OrderID", "Order Date", "Company Name", "Contact Name");
                Console.WriteLine("---------------------------------------------------------------------------------------");


                while (rdr.Read())
                {
                    int orderId = (int)rdr["OrderID"];
                    DateTime orderDate = (DateTime)rdr["OrderDate"];
                    string companyName = rdr["CompanyName"].ToString();
                    string contactName = rdr["ContactName"].ToString();

                    Console.WriteLine("{0,-10}{1,-15:d}{2,-30}{3,-25}", orderId, orderDate, companyName, contactName);
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
