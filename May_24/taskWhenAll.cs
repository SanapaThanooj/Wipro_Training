using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class Use_TaskWhenAny__
    {
        static async Task<string> TaskWithDelay(string name, int delay)
        {
            await Task.Delay(delay);
            return name;

        }
        static async Task Main()
        {
            var task1 = TaskWithDelay("Task 1", 2000);
            var task2 = TaskWithDelay("Task 2", 1000);
            var task3 = TaskWithDelay("Task 3", 3000);

            var completedTask = await Task.WhenAny(task1, task2, task3);
            Console.WriteLine($"First completed task: {completedTask.Result}");

        }
    }
}
