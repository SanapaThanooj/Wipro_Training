using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace may_7
{
     class shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
    class Cricle : shape
    { 
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
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
            shape shape1 = new shape();
            shape1.Draw();
            Cricle circle1 = new Cricle();
            circle1.Draw();
            shape ploycr = new Cricle();
            ploycr.Draw();



        }
    }
}
