
using System;

public class helloworld
{
    static int Add(int a, int b) => a+b;
    static int Sub(int a, int b) => a-b;
    static int Mult(int a, int b) =>a*b;
    static double Divide(int a, int b) =>(b==0) ? 0:(double) a/b;
    
    static void Main()
    {
        Console.WriteLine("Addition : " + Add(3,4));
        //
        Console.WriteLine("Subtraction: "+Sub(9,4));
        //5
        Console.WriteLine("Multiply :" + Mult(3,4));
        //12
        Console.WriteLine("Divide :" + Divide(18,3));
        //6
    }
}