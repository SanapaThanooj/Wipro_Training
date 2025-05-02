using System;
using System.Linq;
class Palindrome
{static bool IsPalindrome()
    {
        string cleanedStr = string.Concat(str.where(char.IsLetterOrDigit)).ToLower();
        int Left =0;
        int Right = cleanedStr.Length -1;
        while(Left<right)
        {
            if(cleanedStr[Left]!= cleanedStr[Right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
    public static void Main()
    {
        string input = Console.ReadLine();
        if(IsPalindrome(input))
        {
            Console.WriteLine($"{input} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} is not a palindrome.");
        }
    }
}