using System;

class Program
{
    static void Main()
    {
        // Generate a list of 20 random integers between 1 and 100
        Random random = new Random();
        int[] randomList = new int[20];
        for (int i = 0; i < randomList.Length; i++)
        {
            randomList[i] = random.Next(1, 101);
        }

        Console.WriteLine("Original list: " + string.Join(", ", randomList));

        // Bubble Sort
        int[] bubbleList = (int[])randomList.Clone();
        
        BubbleSort(bubbleList);
        stopwatch.Stop();
        Console.WriteLine("Bubble Sort Result: " + string.Join(", ", bubbleList));
        Console.WriteLine("Bubble Sort Time: {0} ms", stopwatch.ElapsedMilliseconds);

        // Selection Sort
        int[] selectionList = (int[])randomList.Clone();
       

        SelectionSort(selectionList);
        
        Console.WriteLine("Selection Sort Result: " + string.Join(", ", selectionList));
        Console.WriteLine("Selection Sort Time: {0} ms", stopwatch.ElapsedMilliseconds);

        // Insertion Sort
        int[] insertionList = (int[])randomList.Clone();
        
        InsertionSort(insertionList);
        Console.WriteLine("Insertion Sort Result: " + string.Join(", ", insertionList));
        Console.WriteLine("Insertion Sort Time: {0} ms", stopwatch.ElapsedMilliseconds);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            // Swap arr[minIndex] and arr[i]
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            // Move elements of arr[0..i-1], that are greater than key
            // to one position ahead of their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }
}