using System;

class sumofdigitsofarray
{
    static int SumOfDigits(int n)
    {
        if (n == 0)
            return 0;
        else
            return (n % 10) + SumOfDigits(n / 10);
    }

    static void Main()
    {
        int[] arr = { 1,2,3,4,5,6,7,8,9};
        int totalSum = 0;

        foreach (int num in arr)
        {
            totalSum += SumOfDigits(num);
        }

        Console.WriteLine($"Total sum of digits in the array: {totalSum}");
    }
}