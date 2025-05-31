using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     class Async
    {
        static async Task<string> FetchWeather(string city)
        {
            await Task.Delay(2000);
            return $"Weather data for {city}: Sunny, 25°C";
        }
        static async Task Main()
        {
            var sw = Stopwatch.StartNew();

            var tasks = new[] 
            {
                FetchWeather("New York"),
                FetchWeather("Los Angeles"),
                FetchWeather("Chicago"),
            };

            var results = await Task.WhenAll(tasks);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            sw.Stop();
            Console.WriteLine($"Time taken: {sw.ElapsedMilliseconds} ms");

        }
    }
}
