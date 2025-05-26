using System;
using System.Collections.Generic;
using System.Linq;

public class WordFrequencyAnalyzer
{
    public static void Main()
    {
        string paragraph = @"This is a simple example.";

        
        var words = paragraph
            .ToLower()
            .Split(new char[] { ' ', '.', ',', ';', ':', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

       
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (wordCounts.ContainsKey(word))
                wordCounts[word]++;
            else
                wordCounts[word] = 1;
        }

        
        var topWords = wordCounts
            .OrderByDescending(pair => pair.Value)
            .Take(5);

        Console.WriteLine("Top 5 Most Frequent Words:");
        foreach (var pair in topWords)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} times");
        }
    }
}
