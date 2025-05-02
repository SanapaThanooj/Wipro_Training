using System;

public class Bubblesort
{
    static void BubbleSort(int[] arr)
    {
        for(int i=0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-1;j++){
               if(arr[j]>arr[j+1])
               {
                   int temp =arr[j];
                   arr[j] = arr[j+1];
                   arr[j + 1] = temp;
               }
            }    
        }
    }
    static void  PrintArray(int[] arr)
    {
        foreach(int num in arr)
        {
            Console.Write(num+" ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int [] num ={10,25,30,45,60,75};
        Console.WriteLine("Original array");
        PrintArray(num);
        BubbleSort(num);
        Console.WriteLine("Sorted array");
        PrintArray(num);
    }
}