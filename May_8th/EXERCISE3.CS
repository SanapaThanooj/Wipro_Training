//Store Product Information
using System;
using System.Collections.Generic;

class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { ID = 1, Name = "Laptop", Price = 750.00 },
            new Product { ID = 2, Name = "Smartphone", Price = 500.00 },
            new Product { ID = 3, Name = "Tablet", Price = 300.00 },
            new Product { ID = 4, Name = "Monitor", Price = 200.00 },
            new Product { ID = 5, Name = "Keyboard", Price = 50.00 }
        };

        var sorted = products.OrderByDescending(p => p.Price).ToList();

        Console.WriteLine("Product with the highest price:");
        Console.WriteLine($"ID: {sorted[0].ID}, Name: {sorted[0].Name}, Price: {sorted[0].Price}");
    }
}

