using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Book
    {
        public string Title;
        public bool IsBorrowed = false;
        public string BorrowerBy = null;

    }
    class student
    {
        public string Name;
        
    }
    class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>
            {
                new Book { Title = "C# Programming" },
                new Book { Title = "Data Structures" },
                new Book { Title = "Algorithms" }
            };

            Console.WriteLine(" 1. Borrow Book\n 2. Return Book\n 3. View Books\n 4. Exit");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter book title");
                string title = Console.ReadLine();

                var book = books.Find(b => b.Title == title && !b.IsBorrowed);
                if (book != null)
                {
                    book.IsBorrowed = true;
                    book.BorrowerBy = name;
                    Console.WriteLine($"Book '{book.Title}' borrowed by {name}.");
                }
                else
                {
                    Console.WriteLine("Book not available or already borrowed.");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter Book Title to Return:");
                string title = Console.ReadLine();
                var book = books.Find(b => b.Title == title && b.IsBorrowed);
                if (book != null)
                {
                    book.IsBorrowed = false;
                    book.BorrowerBy = null;
                    Console.WriteLine($"Book '{book.Title}' returned successfully.");
                }
                else
                {
                    Console.WriteLine("Book not found or not borrowed.");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Available Books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} - {(book.IsBorrowed ? "Borrowed" : "Available")}");
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
