//Create a program that takes a number from 1 to 7 and prints the corresponding day of the week.
using System;

public class HelloWorld
{
    static void Main()
    {
       int num =Convert.ToInt32(Console.ReadLine());
       switch (num)
       {
           case 1:
            Console.WriteLine("Sunday");
            break;
           case 2:
            Console.WriteLine("Monday");
            break;
           case 3:
            Console.WriteLine("Tuesday");
            break;
           case 4:
            Console.WriteLine("Wednesday");
            break;
           case 5:
            Console.WriteLine("Thursday");
            break;
           case 6:
            Console.WriteLine("Friday");
            break;
           case 7:
            Console.WriteLine("Satday");
            break;
       }
    }
}

