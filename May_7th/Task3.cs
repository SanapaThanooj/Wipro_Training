// Write a method that takes a sentence as input and returns the longest word
using System;

class Longest_Word
{
    static void Main(string[] args)
    {
        string sentence = "Learning C# is fun";
        string longestWord = FindLongestWord(sentence);
        Console.WriteLine("The longest word is: " + longestWord);
    }

    static string FindLongestWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        string longest = "";

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }

        return longest;
    }
}