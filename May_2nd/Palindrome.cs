using System;
class Palindrome
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        string reversedStr = ReverseString(str);
        
        if (str.Equals(reversedStr, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"{str} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{str} is not a palindrome.");
        }
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}