using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp6
{
    public class SalesByCategoryDisplay
    {
        public static void Main()
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

            SqlDataReader rdr = null;

            try
            {

                connection.Open();

                string query = @"
                SELECT P.CategoryID, SUM(od.UnitPrice * od.Quantity) AS TotalSales
                FROM [Order Details] od
                JOIN Products P ON od.ProductID = P.ProductID
                GROUP BY P.CategoryID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                Console.WriteLine("CategoryID\tTotalSales");
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine($"{row["CategoryID"]}\t\t{row["TotalSales"]}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
        }
    }


}
