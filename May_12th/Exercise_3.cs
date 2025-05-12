using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May_12th
{
    abstract class Book
    {
        public void GetInfo()
        {
            Console.WriteLine("This a book");
        }
        public abstract void Read();
    }

    class Fiction : Book
    {
        public override void Read()
        {
            Console.WriteLine("Reading  a fiction book");
        }
    }
    class NonFiction : Book
    {
        public override void Read()
        {
            Console.WriteLine("Reading a non-fiction book");
        }
    }

}


using May_12th;

class Program
{
    static void Main()
    {
        Fiction fictionBook = new Fiction();
        fictionBook.GetInfo();
        fictionBook.Read();
        NonFiction nonFictionBook = new NonFiction();
        nonFictionBook.GetInfo();
        nonFictionBook.Read();

    }
}

