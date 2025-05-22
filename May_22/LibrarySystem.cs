using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class book
    {
        public int id { get; set; }
        public string name { get; set; }

        public string author { get; set; }
        public string IsAvailable { get; set; }

    }
    class Library
    {
        List<book> books = new List<book>();
        public void AddBook(book b)
        {
            books.Add(b);
        }
        public List<book> SearchByAuther(string author)
        {
            return books.Where(b => b.author == author).ToList();
        }
        public List<book> SearchByName(string name)
        {
            return books.Where(b => b.name == name).ToList();
        }
        public void PrintBooks(IEnumerable<book> book)
        {
            foreach (var b in books)
            {
                Console.WriteLine($"ID: {b.id}, Name: {b.name}, Author: {b.author}, IsAvailable: {b.IsAvailable}");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new book { id = 1, name = "C# Programming", author = "John Doe", IsAvailable = "Yes" });
            library.AddBook(new book { id = 2, name = "Java Programming", author = "Jane Smith", IsAvailable = "No" });
            library.AddBook(new book { id = 3, name = "Python Programming", author = "John Doe", IsAvailable = "Yes" });
            Console.WriteLine("Books by John Doe:");
            var booksByAuthor = library.SearchByAuther("John Doe");
            library.PrintBooks(booksByAuthor);
            Console.WriteLine("Books with name 'C# Programming':");
            var booksByName = library.SearchByName("C# Programming");
            library.PrintBooks(booksByName);
        }
    }
}
