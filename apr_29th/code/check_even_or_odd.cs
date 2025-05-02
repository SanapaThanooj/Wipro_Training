//Check if a number is even or odd using if-else Use Modulo operator to check if a number is even or odd 
using System;

 public class HelloWorld
{
    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if(num%2==0)
        {
            Console.WriteLine(num + " Is Even");
        }
        else{
            Console.WriteLine(num + " Is Odd");
        }
    }
}
