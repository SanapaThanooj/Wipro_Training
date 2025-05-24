using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        private static Thread numberThread;
        private static bool pause = false;
        private static bool stop = false;
        private static void DoWork()
        {
            for (int i = 1; i < 100; i++)
            {
                if (stop)
                {

                    break;

                }
                while (pause)
                {
                    Thread.Sleep(100);
                }
                Console.WriteLine($"Thread: {i}");
                Thread.Sleep(100);
            }

        }
        static void LogThreadState()
        {
            Console.WriteLine($"Thread State: {numberThread.ThreadState}");
        }
        static void Main(string[] args)
        {
            numberThread = new Thread(DoWork);
            numberThread.Start();


            Console.WriteLine("Main: Thread started");

            Thread.Sleep(1000);
            pause = true;
            Console.WriteLine("Main: Thread paused");
            LogThreadState();

            Thread.Sleep(2000);
            pause = false;
            Console.WriteLine("Main: Thread resumed");
            LogThreadState();

            Thread.Sleep(1000);
            stop = true;
            Console.WriteLine("Main: Thread stopped");
            LogThreadState();

            numberThread.Join();
            Console.WriteLine("Main: Thread has finished");
        }
    }
}
