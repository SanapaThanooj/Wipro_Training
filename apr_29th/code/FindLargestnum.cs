//Find the Largest of Three Numbers
using System;

public class HelloWorld
{
    static void Main()
    {
        // int a = 100;
        // int b = 231;
        // int c = 867;

        // if (a > b && a > c)
        // {
        //     Console.WriteLine(a + " (A is Largest)");
        // }
        // else if (b > a && b > c)
        // {
        //     Console.WriteLine(b + " (B is Largest)");
        // }
        // else
        // {
        //     Console.WriteLine(c + " (C is Largest)");
        // }
        Console.WriteLine("Enter A:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter B:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter C:");
        int c = Convert.ToInt32(Console.ReadLine());
        int largest;
        
        if (a > b && a > c)
        {
            largest = a;
        }
        else if (b > a && b > c)
        {
            largest = b;
        }
        else
        {
            largest = c;
        }
        Console.WriteLine("the Largest  Number is :" + largest);
    }
}

