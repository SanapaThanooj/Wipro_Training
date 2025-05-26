using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    class ThreadwithDynamic
    {
        private static Queue<string> workQueue = new Queue<string>();
        private static readonly object lockObj = new object();
        private static bool done = false;
        public static void WorkerThread()
        {
            while (true)
            {
                string workItem = null;
                lock (lockObj)
                {
                    if (workQueue.Count > 0)
                    {
                        workItem = workQueue.Dequeue();
                    }
                    else if (done)
                    {
                        break;
                    }
                }
                if (workItem != null)
                {
                    Console.WriteLine($"Processing {workItem}");
                    Thread.Sleep(1000); // Simulate work
                }
                else
                {
                    Thread.Sleep(100); // Avoid busy waiting
                }
            }
            Console.WriteLine("Worker finished all tasks.");
        }
        public static void Main()
        {
            Thread worker = new Thread(WorkerThread);
            worker.Start();
            for (int i = 0; i < 5; i++)
            {
                lock (lockObj)
                {
                    workQueue.Enqueue($"Task {i}");
                }

                Thread.Sleep(300);
            }
            lock (lockObj)
            {
                done = true;
            }
            worker.Join();

        }
    }
}
