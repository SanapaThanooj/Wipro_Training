using System;

class CountNoOfZeros
{
    static void Main()
    {
        long num = 102030;  
        
        int zeroCount = CountZeros(num);
        Console.WriteLine($"Number of zeros in {num}: {zeroCount}");
    }

    static int CountZeros(long number)
    {
        int count = 0;

        
        string numStr = number.ToString();

        foreach (char c in numStr)
        {
            if (c == '0')
            {
                count++;
            }
        }

        return count;
    }
}