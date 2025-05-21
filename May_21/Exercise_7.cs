using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
     class FindFirstNonRepeatingChar
    {
        static void Main(String[] args)
        {
            string input = "swiss";
            char result = FirstNonRepeatingChar(input);
            if (result != '\0')
            {
                Console.WriteLine($"The first non-repeating character is: {result}");
            }
            else
            {
                Console.WriteLine("No non-repeating character found.");
            }
        }
        static char FirstNonRepeatingChar(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            // Count occurrences of each character
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            // Find the first non-repeating character
            foreach (char c in str)
            {
                if (charCount[c] == 1)
                {
                    return c;
                }
            }
            return '\0'; // Return null character if no non-repeating character is found
        }
    }
}
