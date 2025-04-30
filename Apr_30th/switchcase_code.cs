
// C# program to demonstrate switch case statement
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int day = 4;
        switch(day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("INVALID");
                break;        
        }
        
    }
}