using System;

class BinarySearch
{
    static int BinarySearch(int[] arr, int tg)
    {
        int low =0;
        int high =arr.Length-1;
        while(low <=high)
        {
            int mid =(low+high)/2;
            if(mid ==tg)
            {
                return mid;
            }else if(arr[mid]<tg){
                high = mid +1;
            }
            else{
                low = mid -1;
            }
        }
        return -1;
    }
    static void Main()
    {
        int[] num = {10, 25, 30, 45, 60, 75};
        int tg = 45;
        int res = BinarySearch(num, tg);
        if (res != -1)
        {
            Console.WriteLine($"Element {tg} found at Index {res}");
        }
        else
        {
            Console.WriteLine($"Element {tg} not found in the Array");
        }
    }