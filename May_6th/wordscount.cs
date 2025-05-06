class Program
{
    static void Main()
    {
        string sentence = "Learning c is fun";
        int wordcount = CountWords(sentence);
        Console.WriteLine($"Output: {wordcount} words");
    }
    static int CountWords(string sentence)
    {
        if (string.IsNullOrEmpty(sentence))
            return 0;
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}