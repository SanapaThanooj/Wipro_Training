using System;

class DuplicateWords
{
    static void Main(string[] args)
    {
        string sentence = "Learning c# is fun and c# is great";
        string[] words = sentence.ToLower().Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            int count = 1;
            if (words[i] == "") continue;

            for (int j = i + 1; j < words.Length; j++)
            {
                if (words[i] == words[j])
                {
                    count++;
                    words[j] = ""; 
                }
            }

            if (count > 1)
            {
                Console.WriteLine(words[i] + " appears " + count + " times");
            }
        }
    }
}