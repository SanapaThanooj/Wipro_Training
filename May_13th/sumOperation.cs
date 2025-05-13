using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practices
{
    class SimpleDelegate
    {

        public delegate int  SomeOperation(int x,int y);

        class Program
        {
            static int Sum(int x, int y)
            {
                return x + y;
            }
            static void Main(string[] args)
            {
                SomeOperation add = Sum;
                int result = add(5, 10);
                Console.WriteLine($"The sum is: {result}");
            }
        }


    }
}
