using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Threads
{
     class CancellationTokens
    {
        static async Task DoWorkAsync(CancellationToken token)
        {
            for(int i = 0; i < 10; i++)
            {
                token.ThrowIfCancellationRequested();
                Console.WriteLine($"Working... {i}");
                await Task.Delay(500); // Simulate work
            }    
        }
        static async Task Main()
        {
            var cts = new CancellationTokenSource();
            var task = DoWorkAsync(cts.Token);
            
            Task.Delay(2000).ContinueWith(_ => cts.Cancel()); // Cancel after 2 seconds
            
            try
            {
                await task;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Work was cancelled.");
            }
        }
    }
}
