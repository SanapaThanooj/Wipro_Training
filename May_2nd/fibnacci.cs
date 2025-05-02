using System;
class FibonacciRecursive
{
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        int count = 40;

        Console.WriteLine("Fibonacci series (first 40 num):");

        for (int i = 0; i < count; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }

        Console.WriteLine(); 
    }
}
