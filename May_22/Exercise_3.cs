using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        static void Main()
        {
            
            List<Products> products = new List<Products>
        {
            new Products { Name = "Laptop", Price = 1200 },
            new Products { Name = "Keyboard", Price = 150 },
            new Products { Name = "Smartphone", Price = 800 },
            new Products { Name = "Mouse", Price = 100 },
            new Products { Name = "Monitor", Price = 600 }
        };

            
            var expensiveProducts = products.Where(p => p.Price > 500);

           
            Console.WriteLine("Products with price > 500:");
            foreach (var product in expensiveProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
