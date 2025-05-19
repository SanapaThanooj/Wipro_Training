using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    
    public class Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Queue<Book> borrowedBooks = new Queue<Book>();
            borrowedBooks.Enqueue(new Book("1984", "George Orwell"));
            borrowedBooks.Enqueue(new Book("To Kill a Mockingbird", "Harper Lee"));
            borrowedBooks.Enqueue(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
            borrowedBooks.Enqueue(new Book("Pride and Prejudice", "Jane Austen"));
            borrowedBooks.Enqueue(new Book("The Catcher in the Rye", "J.D. Salinger"));

            Console.WriteLine(" Borrowed Books Queue:");
            Console.WriteLine("Next book to be returned:");
            borrowedBooks.Peek().DisplayInfo(); 

            Console.WriteLine("\nReturning the book...");
            borrowedBooks.Dequeue(); 

            
            Stack<Book> newBooks = new Stack<Book>();
            newBooks.Push(new Book("Clean Code", "Robert C. Martin"));
            newBooks.Push(new Book("The Pragmatic Programmer", "Andrew Hunt"));
            newBooks.Push(new Book("Design Patterns", "Erich Gamma"));

            Console.WriteLine("\n Newly Purchased Books Stack:");
            Console.WriteLine("Last book purchased:");
            newBooks.Peek().DisplayInfo(); 

            Console.WriteLine("\nProcessing the book...");
            newBooks.Pop(); 

            
            Console.WriteLine("\n Remaining Borrowed Books:");
            foreach (Book book in borrowedBooks)
            {
                book.DisplayInfo();
            }

            Console.WriteLine("\n Remaining New Books:");
            foreach (Book book in newBooks)
            {
                book.DisplayInfo();
            }
        }
    }
}
