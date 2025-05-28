using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     class LoadProduct
    {
        static void Main()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true;";
            string query = "SELECT * FROM Products";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Products");

                foreach (DataRow row in dataSet.Tables["Products"].Rows)
                {
                    int stock = Convert.ToInt32(row["UnitsInStock"]);
                    if (stock > 20)
                    {
                        Console.WriteLine($"Product: {row["ProductName"]}, Stock: {stock}");
                    }
                }
            }
        }
    }
}
