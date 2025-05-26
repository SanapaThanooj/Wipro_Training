using System;
using System.Collections.Generic;
using System.Linq;

public class Item
{
    public string Name { get; set; }
    public string Type { get; set; } 
    public int Stock { get; set; }
    public decimal Price { get; set; }
}

public class InventorySystem
{
    public static void Main()
    {
        List<Item> items = new List<Item>
        {
            new Item { Name = "Laptop", Type = "Electronics", Stock = 3, Price = 60000 },
            new Item { Name = "Monitor", Type = "Electronics", Stock = 8, Price = 15000 },
            new Item { Name = "Mouse", Type = "Electronics", Stock = 50, Price = 500 },
            new Item { Name = "Apples", Type = "Grocery", Stock = 4, Price = 200 },
            new Item { Name = "Bananas", Type = "Grocery", Stock = 15, Price = 100 },
            new Item { Name = "Rice", Type = "Grocery", Stock = 0, Price = 2500 },
            new Item { Name = "Shampoo", Type = "Personal Care", Stock = 12, Price = 150 },
            new Item { Name = "Toothpaste", Type = "Personal Care", Stock = 2, Price = 90 },
            new Item { Name = "Soap", Type = "Personal Care", Stock = 25, Price = 50 },
            new Item { Name = "Chair", Type = "Furniture", Stock = 7, Price = 2500 },
            new Item { Name = "Table", Type = "Furniture", Stock = 1, Price = 7000 },
            new Item { Name = "Notebook", Type = "Stationery", Stock = 60, Price = 30 },
            new Item { Name = "Pen", Type = "Stationery", Stock = 3, Price = 10 },
            new Item { Name = "Backpack", Type = "Stationery", Stock = 4, Price = 900 },
            new Item { Name = "Printer", Type = "Electronics", Stock = 1, Price = 8000 }
        };

      
        var lowStock = items.Where(i => i.Stock < 5);
        Console.WriteLine("Low Stock Items:");
        foreach (var i in lowStock)
            Console.WriteLine($"{i.Name} - {i.Stock}");

        
        var grouped = items.GroupBy(i => i.Type);

       
        Console.WriteLine("\nHighest Priced Items by Type:");
        foreach (var group in grouped)
        {
            var highest = group.OrderByDescending(i => i.Price).First();
            Console.WriteLine($"{group.Key}: {highest.Name} - ₹{highest.Price}");
        }
    }
}
