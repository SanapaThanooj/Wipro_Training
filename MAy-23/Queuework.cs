using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class4
    {
        static void Dowork(object state)
        {
            Console.WriteLine($"Threadpool Task Started - {state}");
            Thread.Sleep(2000); // Simulate work
            Console.WriteLine($"Threadpool Task Completed - {state}");

        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(Dowork, $"Task {i}");
            }
            Console.WriteLine("Main thread Continues.");
            Thread.Sleep(3000);// Keep the main thread alive
            Console.WriteLine("Main thread finished.");
        }
    }
}
