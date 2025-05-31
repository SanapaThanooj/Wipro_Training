using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a Program");
            string input = Console.ReadLine();

            var words = input.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var wordCount = words.GroupBy(w => w.ToLower())
                                 .ToDictionary(g => new { Word = g.Key, Count = g.Count() });
                                 
            Console.WriteLine("Word Count:");
            foreach (var word in wordCount)
            {
                Console.WriteLine($"Word: {word.Key.Word}, Count: {word.Key.Count}");
            }

            int vowelsCount = input.Count(c => "aeiouAEIOU".Contains(c));
            int consonantsCount = input.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));

            string longestWord = words.OrderByDescending(w => w.Length).First();
            string shortestWord = words.OrderBy(w => w.Length).First();

            Console.WriteLine($"Total Vowels: {vowelsCount}, Consonants:{consonantsCount}");
            Console.WriteLine($"Longest Word: {longestWord}, Shortest Word: {shortestWord}");


        }
    }
}
