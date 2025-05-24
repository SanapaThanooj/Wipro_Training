using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class MultipleThreads
    {
        static void Main()
        {
            Thread thread1 = new Thread(PrintTask);
            Thread thread2 = new Thread(ComputeTask);
            Thread thread3 = new Thread(WaitTask);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("All tasks done");

        }
        static void PrintTask()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Print Task: {i + i}");
                Thread.Sleep(200); // Simulate work
            }
        }
        static void ComputeTask()
        {
            long sum = 0;
            for (int i = 0; i < 1000000; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Compute Task: Sum = {sum}");
        }
        static void WaitTask()
        {
            Console.WriteLine($"Wait Task: Waiting for 2 seonds...");
            Thread.Sleep(2000); // Simulate work
            Console.WriteLine($"Wait Task: done waiting ");

        }
    }
}
