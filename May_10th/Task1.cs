using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace may_7
{
     class Washingmachine
    {
        public virtual  void  Operate()
        {
            Console.WriteLine(" Washing machine is started ");
        }
    }
    class FrontLoadWashingMachine : Washingmachine
    {
        public override void Operate()
        {
            Console.WriteLine("Washing clothes");
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
            Washingmachine wm = new Washingmachine();
            wm.Operate();
            FrontLoadWashingMachine flm = new FrontLoadWashingMachine();
            flm.Operate();
            Washingmachine ploycr = new FrontLoadWashingMachine();
            ploycr.Operate();



        }
    }
}
