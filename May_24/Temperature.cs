using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class AsyncMethod
    {
        static async Task<int> GetTemperatureAsync(string city)
        {

            await Task.Delay(1000); // Simulate async work
            Random rnd = new Random();
            return rnd.Next(-10, 40);
        }
        static async Task Main()
        {
            var t1 = GetTemperatureAsync("New York");
            var t2 = GetTemperatureAsync("Los Angeles");
            var t3 = GetTemperatureAsync("Chicago");

            Console.WriteLine("Fetching temperatures...");
            Console.WriteLine($"New York: {await t1}C");
            Console.WriteLine($"Los Angeles: {await t2}C");
            Console.WriteLine($"Chicago: {await t3}C");
        }
    }

}
