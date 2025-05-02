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
    
    // static int Factorial(int n)
    // {
    //     if (n == 0 || n == 1)
    //         return 1;
    //     else
    //         return n * Factorial(n - 1);
    // }

    // static void CalculateFactorials(int[] arr)
    // {
    //     Array.Sort(arr); 

    //     int mx = arr[arr.Length-1];
    //     Console.WriteLine($"Factorial of {mx} is {Factorial(mx)}");
    // }

    // static void Main()
    // {
    //     int[] Num = { 3,1,5,2,10,9,8,7,6};
    //     CalculateFactorials(Num);
    // }


}