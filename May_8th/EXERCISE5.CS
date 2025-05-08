using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneDirectory = new Dictionary<string, string>();

        phoneDirectory.Add("Alice", "123-456-7890");
        phoneDirectory.Add("Bob", "234-567-8901");
        phoneDirectory.Add("Charlie", "345-678-9012");
        phoneDirectory.Add("David", "456-789-0123");
        phoneDirectory.Add("Eva", "567-890-1234");

        phoneDirectory["Charlie"] = "999-999-9999";

        string searchName = "David";
        if (phoneDirectory.ContainsKey(searchName))
        {
            Console.WriteLine($"{searchName} exists in the phone directory.");
        }

        Console.WriteLine("\nAll Contacts:");
        foreach (var contact in phoneDirectory)
        {
            Console.WriteLine($"{contact.Key}: {contact.Value}");
        }
    }
}