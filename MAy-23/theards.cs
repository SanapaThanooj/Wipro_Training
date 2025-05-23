using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class1
    {
        static void PrintMessage(object message)
        {
            string msg = (string)message;
            Console.WriteLine("Message:" + msg);
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
            thread.Start("Hello from the thread!");
            //Console.WriteLine("Main thread is running.");
            //thread.Join(); // Wait for the thread to finish
            //Console.WriteLine("Thread has finished execution.");
        }
    }
}
