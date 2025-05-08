// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        List<string> numbers = new List<string>() { "Apple", "Banana", "Cherry" };
        //Adding an Element
        numbers.Add("Mango");
        //Inserting an Element  
        numbers.Insert(1, "Orange");
        //Removing an Element
        numbers.Remove("Banana");
        //Removing an Element by Index  
        numbers.RemoveAt(0);

        //checking if an element exists
        if (numbers.Contains("Cherry"))
        {
            Console.WriteLine("Cherry is in the list.");
        }
        else
        {
            Console.WriteLine("Cherry is not in the list.");
        }
        numbers.Sort();
        Console.WriteLine("Sorted List:");
        foreach (string fruit in numbers)
        {
            Console.WriteLine(fruit);
        }
    }
}

