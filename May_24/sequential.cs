using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class Sequential
    {
        static async Task SimulateWorkAsync(string taskName, int delay)
        {

            await Task.Delay(delay);
            Console.WriteLine($"{taskName} completed");
        }
        static async Task Main()
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Starting sequential tasks...");
            await SimulateWorkAsync("Task 1", 2000);
            await SimulateWorkAsync("Task 2", 1500);
            await SimulateWorkAsync("Task 3", 1000);
            sw.Stop();
            Console.WriteLine($"sequential time:{sw.ElapsedMilliseconds}ms");
            sw.Restart();

            var t1 = SimulateWorkAsync("Task 1", 2000);
            var t2 = SimulateWorkAsync("Task 2", 1500);
            var t3 = SimulateWorkAsync("Task 3", 1000);
            await Task.WhenAll(t1, t2, t3);

            sw.Stop();
            Console.WriteLine($"parallel time:{sw.ElapsedMilliseconds}ms");
        }
    }
}
