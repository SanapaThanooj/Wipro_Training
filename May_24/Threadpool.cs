using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class ThreadPoolExcercise
    {
        static void ProcessItem(object item)
        {
            Thread.Sleep(500);
            Console.WriteLine($"Processed item: {item} on thread {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Main()
        {

            for (int i = 1; i <= 5; i++)
            {
                ThreadPool.QueueUserWorkItem(ProcessItem, $"item {i}");
            }

            Thread.Sleep(2000);
        }
    }
}
