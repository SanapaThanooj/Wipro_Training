//Count Unique Element
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 10, 30, 40, 20, 50, 60, 30, 70 };
        HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

        Console.WriteLine("Unique Numbers:");
        foreach (int num in uniqueNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine($"\nTotal Unique Elements: {uniqueNumbers.Count}");
    }
}
