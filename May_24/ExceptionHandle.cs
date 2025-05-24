using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class ExceptionHandling
    {
        static async Task RiskTaskAsync(string taskName)
        {
            await Task.Delay(1000);
            if (taskName == "Task 2")
            {
                throw new Exception($"{taskName} failed.");
            }
            Console.WriteLine($"{taskName} completed successfully");
        }
        static async Task Main()
        {
            var tasks = new List<Task>
            {
                RiskTaskAsync("Task 1"),
                RiskTaskAsync("Task 2"),
                RiskTaskAsync("Task 3")
            };
            try
            {
                await Task.WhenAll(tasks);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
    }
}
