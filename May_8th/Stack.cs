using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Stack<string> books = new Stack<string>();

        books.Push("C# Programming");
        books.Push("Data Scinece");
        books.Push("Machine Learning");

        Console.WriteLine("Books in Stack:");

        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
        // Popping the top book
        Console.WriteLine($"\n Popped: {books.Pop()}");
        // peeking the top book 
        Console.WriteLine($"\n Peek: {books.Peek()}");

    }
}