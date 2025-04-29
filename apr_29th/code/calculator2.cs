
using System;

 public class HelloWorld
{
    static int Add(int a,int b)
    {
        return a + b;
    }
    static int sub(int a,int b)
    {
        return a - b;
    }
    static int multi(int a, int b){
        return a*b;
    }
    static void Main()
    {
        int Num1 = 12;
        int Num2 = 10;
        
        // int res =add(Num1,Num2);  it is not efficientway add variable 
        
        Console.WriteLine("ADDITION:" + Add(Num1,Num2));
        Console.WriteLine("SUBTRACTION:" + sub(Num1,Num2));
        Console.WriteLine("MULTIPLE:" + multi(Num1,Num2));
    }
}