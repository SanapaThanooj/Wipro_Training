using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May_12th
{
    interface IAnimalActions
    {
        void Eat();
        void Sleep();

    }
    class Lion : IAnimalActions
    {
        public void Eat()
        {
            Console.WriteLine("Lion is eating meat");
        }
        public void Sleep()
        {
            Console.WriteLine("Lion is sleeping");
        }
    }
    class Elephant : IAnimalActions
    {
        public void Eat()
        {
            Console.WriteLine("Elephant is eating grass");
        }
        public void Sleep()
        {
            Console.WriteLine("Elephant is sleeping");
        }
      
    }

}

using May_12th;

class Program
{
    static void Main()
    {
        IAnimalActions loin =  new Lion();
        IAnimalActions elephant = new Elephant();
        loin.Eat();
        loin.Sleep();
        elephant.Eat();
        elephant.Sleep();

    }
}


