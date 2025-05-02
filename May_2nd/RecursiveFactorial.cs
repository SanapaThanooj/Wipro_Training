using System;

class FactorialRecursive
{
    static int Factorial(int n)
    {
        
        if(n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n-1);
        }
    }
    static void Main()
    {
        int n = 10;
        Console.WriteLine($"Factorial of {n} is {Factorial(n)}");
    }
}