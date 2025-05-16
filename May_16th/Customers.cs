
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection(
               "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;INtegrated Security=SSPI");

            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT * from Customers", conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[1]);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
