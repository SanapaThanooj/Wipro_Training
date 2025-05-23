using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class3
    {
        static void DoWork(string name)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Thread{name} - step {i}");
                Thread.Sleep(500);
            }
            Console.WriteLine($"Thread {name} finished");
        }
        static void Main()
        {
            Thread t1 = new Thread(() => DoWork("A"));
            Thread t2 = new Thread(() => DoWork("B"));
            Thread t3 = new Thread(() => DoWork("C"));
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
            t3.Start();
            t3.Join();
            Console.WriteLine("All threads have finished execution.");

        }
    }
}
