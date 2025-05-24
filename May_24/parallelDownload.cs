using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class ParallelDownloads
    {
        static async Task DownloadFileAsync(string fileName, int delay)
        {
            Console.WriteLine($"Starting download from {fileName}");
            await Task.Delay(2000);
            Console.WriteLine($"Finished download from {fileName}");
        }
        static async Task Main()
        {
            var stopwath = Stopwatch.StartNew();
            Task t1 = DownloadFileAsync("file1.txt", 2000);
            Task t2 = DownloadFileAsync("file2.txt", 2000);
            Task t3 = DownloadFileAsync("file3.txt", 2000);

            await Task.WhenAll(t1, t2, t3);

            stopwath.Stop();
            Console.WriteLine($"All downloads completed in {stopwath.ElapsedMilliseconds} ms");
        }
    }
}
