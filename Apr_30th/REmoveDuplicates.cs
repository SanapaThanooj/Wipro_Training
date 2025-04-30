using System;

public class HelloWorld
{
    // Function to remove duplicates and print unique elements
    static void RemoveDuplicates(int[] arr)
    {
        int n = arr.Length;
        int[] unique = new int[n];
        int uniqueCount = 0;

        for (int i = 0; i < n; i++)
        {
            bool isDuplicate = false;

            // Check if arr[i] is already in unique[]
            for (int j = 0; j < uniqueCount; j++)
            {
                if (arr[i] == unique[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            // If not a duplicate, add to unique[]
            if (!isDuplicate)
            {
                unique[uniqueCount] = arr[i];
                uniqueCount++;
            }
        }

        // Print unique elements
        for (int i = 0; i < uniqueCount; i++)
        {
            Console.Write(unique[i] + " ");
        }
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 1 };
        RemoveDuplicates(arr); // Call the function
    }
}
