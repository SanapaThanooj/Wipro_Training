
using System;

public class helloworld
{
    static int FindMax(int[] arr)
    {
        int max =arr[0];
        for(int i =1;i<arr.Length;i++){
            if(arr[i]>max){
                max=arr[i];
            }
        }
        return max;
    }
    
    static void Main()
    {
        int[] scores ={1,2,1,3,2,1};
        Console.WriteLine("Max score:" +FindMax(scores));
    }
}