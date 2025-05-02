using System;
using System.Collections.Generic;
using System.Linq;
//finf pairs with a given sum in an array using brute force method
class FindPairsWithSum
{
    static void FindPairs(int[] arr, int targetSum)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == targetSum)
                {
                    Console.WriteLine($"Pair found: {arr[i]} + {arr[j]} = {targetSum}");
                }
            }
        }
    }
    static void Main()
    {
        int[] arr = { 2, 4, 3, 5 ,7 };
        int targetSum = 5;
        FindPairs(arr, targetSum);
    }
}