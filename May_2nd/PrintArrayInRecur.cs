using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Array elements:");
        PrintArrayRecursive(arr, 0);
    }

    static void PrintArrayRecursive(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            return;
        }

        Console.WriteLine(arr[index]);
        PrintArrayRecursive(arr, index + 1);
    }
}
