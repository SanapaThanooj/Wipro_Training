using System;
using System.Threading;

class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
    static void Main(string[] args)
    {
        Thread myThread = new Thread(PrintNumbers);
        myThread.Start();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Main Thread: " + i);
            Thread.Sleep(500);
        }

    }
}