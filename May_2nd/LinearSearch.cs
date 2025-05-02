// Linear Search
using System;

public class HelloWorld
{
    static int LinerSearch(int[] arr,int tg){
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i] == tg){
                return i;
            }    
        }
        return -1;
    }
     static void Main()
    {
        int [] num ={10,25,30,45,60,75};
        int tg= 45;
        int res = LinerSearch(num,tg);
        if(res != -1)
        {
            Console.WriteLine ($"Element{tg} found at Index {res}");
        }
        else
        {
            Console.WriteLine ($"Element{tg} not found in the Array");
        }
            
    }
}