
using System;

public class helloworld
{
    static void PrintArray(int[] arr)
    {
        for(int i = arr.Length-1;i>=0;i--)
        {
            Console.WriteLine($"Element {arr.Length-i}:{arr[i]*arr[i]}");
        }
    }
    
    static void Main()
    {
        int[] num ={10,30,50,70,90};
        PrintArray(num);
    }
}