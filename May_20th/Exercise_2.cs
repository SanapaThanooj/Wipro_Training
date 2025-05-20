using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // orted list of 50 integers between 1 and 200
        Random random = new Random();
        int[] sortedList = GenerateSortedList(50, 1, 200);
        Console.WriteLine("Sorted List: " + string.Join(", ", sortedList));

        // a random key to search for
        int key = random.Next(1, 201);
        Console.WriteLine($"Searching for: {key}");

        //  Linear Search
        int linearPosition = LinearSearch(sortedList, key, out int linearComparisons);
        Console.WriteLine($"Linear Search - Position: {linearPosition}, Comparisons: {linearComparisons}");

        //  Binary Search
        int binaryPosition = BinarySearch(sortedList, key, out int binaryComparisons);
        Console.WriteLine($"Binary Search - Position: {binaryPosition}, Comparisons: {binaryComparisons}");
    }

    static int[] GenerateSortedList(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        return Enumerable.Range(minValue, maxValue - minValue + 1)
                         .OrderBy(x => random.Next())
                         .Take(size)
                         .OrderBy(x => x)
                         .ToArray();
    }

    public static int LinearSearch(int[] arr, int key, out int comparisons)
    {
        comparisons = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            comparisons++;
            if (arr[i] == key)
            {
                return i; // Return the index if found
            }
        }
        return -1; // Return -1 if not found
    }

    public static int BinarySearch(int[] arr, int key, out int comparisons)
    {
        comparisons = 0;
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            comparisons++;
            int mid = left + (right - left) / 2;

            if (arr[mid] == key)
            {
                return mid; // Return the index if found
            }
            else if (arr[mid] < key)
            {
                left = mid + 1; // Search in the right half
            }
            else
            {
                right = mid - 1; // Search in the left half
            }
        }
        return -1; // Return -1 if not found
    }
}
