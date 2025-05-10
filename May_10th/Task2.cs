
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace may_7
{
     class Powercal
    {
        public int add(int bas , int exponent)
        {
            return (int)Math.Pow( bas , exponent);
        }
        public double add(double bas, double exponent) 
        { 
        
            return (double) Math.Pow(bas , exponent);
        }
    }
}

//using may_7;
namespace may_7
{
    class Program
    {
        static void Main()
        {
            Powercal pc = new Powercal();
           Console.WriteLine("2^3 ="+pc.add(2,3));
            
            Console.WriteLine("5.5^2"+pc.add(5.5,2));

        }
    }
}
