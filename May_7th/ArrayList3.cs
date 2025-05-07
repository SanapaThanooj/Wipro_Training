using System.Collections;
using System;
class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList() { 4, 1, 8, 3 };
        list.Sort();
        Console.WriteLine("Sorted");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        list.Reverse();
        Console.WriteLine("Reversed");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

    }
}
