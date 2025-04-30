using System;
public class helloworld
{
    public static void Main(string[] args)
    {
       Console.Write("Number:");
       int num = Convert.ToInt32(Console.ReadLine());
       
       int rev = 0;
       int temp = Math.Abs(num); 
       
       while(temp > 0)
       {
            int newnum =temp%10;
            rev = rev * 10 +newnum;
            temp/=10;
       }
       if(num < 0)
       {
          rev= -rev; 
       }
       
       Console.WriteLine("Reverse a num :"+ rev); 
    }
    
}