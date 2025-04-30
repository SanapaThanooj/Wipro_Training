using System;

public class helloworld
{
    static int CountVowels(string input)
    {
        int count =0;
        string vowels = "aeiouAEIOU";
        foreach(char c in input)
        {
            if(vowels.Contains(c))
            {
                count++;
            }
        }
        return count;
        
    }
    
    static void Main()
    {
        string sentence ="Programming is fun";
        Console.WriteLine("no of vowels:" +CountVowels(sentence));
    }
}