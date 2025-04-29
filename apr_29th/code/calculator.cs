
using System;

 public class HelloWorld
{
    static int Add(int a,int b)
    {
        return a + b;
    }
    static void Main()
    {
        int Num1 = 12;
        int Num2 = 10;
        
        // int res =add(a,b);  it is a 
        Console.WriteLine("ADDITION:" + Add(Num1,Num2));
    }
}