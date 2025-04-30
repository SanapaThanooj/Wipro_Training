
using System;

public class helloworld
{
    
    static int Sub(int a,int b)
    {
        return a-b;
    }
    static double Sub(double a,double b)
    {
        return a-b;
    }
    static  double Mult(double a,double b)
    {
        return a*b;
    }
    static  int Mult(int a,int b)
    {
        return a*b;
    }
    static void Main()
    {
        Console.WriteLine("Int Sub " + Sub(3,4));
        //-1
        Console.WriteLine("Double sub "+Sub(9.5,4.2));
        //5.3
        Console.WriteLine("Int Multi " + Mult(3,4));
        //12
        Console.WriteLine("double Multi " + Mult(9.2,4.4));
        //40.48
    }
    
}