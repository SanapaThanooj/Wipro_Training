using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        int i = 1;
        // while (i * i <= 100)
        // {
        //     Console.WriteLine("Square of " + i + " is " + (i * i));
        //     i++;
        // } 
        
        for (i = 1; i<= 10; i++)
        {
        
            Console.WriteLine("squares of "+ i +" is "+i*i);
        }
        
        
    }
}