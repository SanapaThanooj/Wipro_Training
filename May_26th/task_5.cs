using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
     class service
    {
        public static async Task<string> ServerAsync(string name, CancellationToken token)
        {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            int delay = rnd.Next(1000, 3000);
            await Task.Delay(delay, token);
            return $"{name} responded in {delay}ms";
        }

        public static async Task Main()
        {
            using CancellationTokenSource cts = new CancellationTokenSource();

            var task1 = ServerAsync("Server1", cts.Token);
            var task2 = ServerAsync("Server2", cts.Token);
            var task3 = ServerAsync("Server3", cts.Token);

            var fastest = await Task.WhenAny(task1, task2, task3);
            Console.WriteLine(await fastest);

            cts.Cancel(); 
            Console.WriteLine("Remaining servers canceled.");
        }
    }
}
