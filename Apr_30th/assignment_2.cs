
using System;

public class helloworld
{
    public static void Main(string[] args)
    {
       Console.Write("Number:");
       int num = Convert.ToInt32(Console.ReadLine());
       
       int sum = 0;
       int temp = Math.Abs(num); 
       
       while(temp > 0)
       {
            sum+=temp%10;
            temp/=10;
       }
       Console.WriteLine("Sum of Digit"+ sum); 
    }
    
}