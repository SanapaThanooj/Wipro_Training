using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class2
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Thread thread = new Thread(() =>
            {

                Console.WriteLine($"Sum: {a + b}");
            });
            thread.Start();
        }
    }
}
