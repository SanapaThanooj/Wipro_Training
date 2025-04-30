
using System;

public class helloworld
{
    static int search(int[] arr,int tg)
    {
        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i] == tg)
            {
                return i;
            }
        }
        return -1;
    }
    
    static void Main()
    {
        int[] arr ={3,5,7,8,9,10};
        int tg =7;
        
        int res = search(arr, tg);

        if (res != -1)
        {
            Console.WriteLine(res); 
        }
        else
        {
            Console.WriteLine("Not found"); 
        }
    }
}