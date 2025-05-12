using System;

namespace May_12th
{
    interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        int Divide(int a, int b);
        
    }
    class SimpleCalculator :   ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
    }
}

using May_12th;

class Program
{
    static void Main()
    {
        ICalculator Calculator;
        Calculator = new SimpleCalculator();
        Console.WriteLine("Addition (100,50):\n"+Calculator.Add(100, 50));
        Console.WriteLine("Subtraction (100,50):\n" + Calculator.Subtract(100, 50));
        Console.WriteLine("Multiply(100, 50) \nn" + Calculator.Multiply(100, 50));
        Console.WriteLine("Divison(100,50) \n" + Calculator.Divide(100, 50)); 
    }
}

