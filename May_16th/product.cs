using System;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()

        {
            SqlConnection conn = new SqlConnection(
               "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT ContactName, City, CompanyName FROM Customers", conn);
                rdr = cmd.ExecuteReader();

                Console.WriteLine("Contact Name\t\tCity\t\tCompany Name");
                Console.WriteLine("--------------------------------------------------------");

                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr["ContactName"],-20}\t{rdr["City"],-15}\t{rdr["CompanyName"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                rdr?.Close();
                conn?.Close();
            }
        }
    }
}