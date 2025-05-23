using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class6
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Work started");
            await DoAsyncwork();
            Console.WriteLine("Work completed.");
        }
        static async Task DoAsyncwork()
        {
            Console.WriteLine("working asynronously.");
            await Task.Delay(2000); // Simulate async work
            Console.WriteLine("Async work done.");
        }
    }
}
