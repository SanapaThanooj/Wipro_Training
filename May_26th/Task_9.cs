using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Threads
{
    public class ParallelErrorHandling
    {
        public static async Task Main()
        {
            var tasks = new List<Task>
            {
                Task.Run(() => Console.WriteLine("Task 1 OK")),
                Task.Run(() => throw new InvalidOperationException("Task 2 failed")),
                Task.Run(() => Console.WriteLine("Task 3 OK")),
                Task.Run(() => throw new ArgumentException("Task 4 failed")),
                Task.Run(() => Console.WriteLine("Task 5 OK"))
            };

            try
            {
                await Task.WhenAll(tasks);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Some tasks failed:");
                foreach (var inner in ex.InnerExceptions)
                {
                    Console.WriteLine($" - {inner.GetType().Name}: {inner.Message}");
                }
            }
            finally
            {
                Console.WriteLine("All tasks completed (some may have failed).");
            }
        }
    }
}