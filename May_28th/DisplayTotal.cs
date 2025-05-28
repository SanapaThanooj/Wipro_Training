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
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true;";
            string query = @"
            SELECT CategoryID, SUM(UnitPrice * Quantity) AS TotalSales
            FROM [Order Details]
            GROUP BY CategoryID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        int categoryId = Convert.ToInt32(row["CategoryID"]);
                        decimal totalSales = Convert.ToDecimal(row["TotalSales"]);

                        Console.WriteLine($"CategoryID: {categoryId}, Total Sales: {totalSales:C}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }


}
