using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
     class Greedy_Algorithms
    {
        static  void Main(string[] args)
        {
            int amount = 880;

            List<int> coinsUsed = GetMinimumCoins(amount);
            Console.WriteLine("Coins used: " + string.Join(", ", coinsUsed));
            Console.WriteLine("Total coins used: " + coinsUsed.Count);
        }
        static List<int> GetMinimumCoins(int amount)
        {
           
            int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
            Array.Reverse(coins);
            List<int> coinsUsed = new List<int>();
            foreach (int coin in coins)
            {
                while (amount >= coin)
                {
                    amount -= coin;
                    coinsUsed.Add(coin);
                }
            }
            return coinsUsed;
        }
    }
}
