using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class5
    {
        static bool pause = false;
        static bool stop = false;
        static void Dowork()
        {
            while (!stop)
            {
                if (pause)
                {
                    Console.WriteLine("Thread is paused.");
                    Thread.Sleep(1000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Thread is working.");
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Thread is stopped.");
        }
        static void Main()
        {
            Thread worker = new Thread(Dowork);
            Console.WriteLine("Initial Thread State :" + worker.ThreadState);
            worker.Start();

            Thread.Sleep(3000); // Let the thread work for a while
            pause = true; // Pause the thread
            Console.WriteLine("Thread State after pausing: " + worker.ThreadState);

            Thread.Sleep(3000); // Let the thread be paused for a while
            pause = false; // Resume the thread
            Console.WriteLine("Thread State after resuming: " + worker.ThreadState);

            Thread.Sleep(3000); // Let the thread work for a while
            stop = true; // Stop the thread
            Console.WriteLine("Thread State after stopping: " + worker.ThreadState);

            worker.Join(); // Wait for the thread to finish
            Console.WriteLine("Main thread finished." + worker.ThreadState);
        }

    }
}
