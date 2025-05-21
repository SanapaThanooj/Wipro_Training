using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
     class TowerOfHanoi
    {
        static void Main(string[] args)
        {
            int n = 3;
            TowerofHanoi(n, 'A','B','C');
        }
        static void TowerofHanoi(int n,char from,char to,char aux)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk 1 from {from} to {to}");
                return;
            }
            TowerofHanoi(n - 1, from, aux, to);
            Console.WriteLine($"Move disk {n} from {from} to {to}");
            TowerofHanoi(n - 1, aux, to, from);
        }
    }
}
