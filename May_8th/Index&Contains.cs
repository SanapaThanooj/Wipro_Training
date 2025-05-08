class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int index = numbers.IndexOf(3);
        Console.WriteLine("Index of 3: " + index);

        bool contains = numbers.Contains(2);
        // Check if the list contains the number 2
        Console.WriteLine("Contains 2: " + contains);
    }
}