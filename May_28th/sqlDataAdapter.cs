using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp6
{
    class Disconnected
    {
        static void Main()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI";

            string query = "SELECT ProductID, ProductName, UnitsInStock FROM Products";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);


                DataSet dataSet = new DataSet();


                adapter.Fill(dataSet, "Products");


                DataTable productsTable = dataSet.Tables["Products"];


                Console.WriteLine("{0,-10} {1,-35} {2}", "ProductID", "ProductName", "UnitsInStock");
                Console.WriteLine(new string('-', 60));

                foreach (DataRow row in productsTable.Rows)
                {

                    int unitsInStock = Convert.ToInt32(row["UnitsInStock"]);

                    if (unitsInStock > 20)
                    {
                        Console.WriteLine("{0,-10} {1,-35} {2}",
                            row["ProductID"], row["ProductName"], row["UnitsInStock"]);
                    }
                }
            }
        }
    }
}
