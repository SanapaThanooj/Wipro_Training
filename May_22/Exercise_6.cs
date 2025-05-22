using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class wordcount
    {
        static void Main(string[] args)
        {
            string text = "C# is great and C# is fun";
            var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var wordCount = words
                  .GroupBy(w => w)
                  .Select(g => new { Word = g.Key, Count = g.Count() });
            foreach (var word in wordCount)
            {
                Console.WriteLine($"Word: {word.Word}, Count: {word.Count}");
            }
        }
    }
}
