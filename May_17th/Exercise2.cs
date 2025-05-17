using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface Ivehicle_maintenace 
    {
        public void Service();
        public void Repair();
    }

    class car_maintenace : Ivehicle_maintenace
    {
        public void Service()
        {
            Console.WriteLine("Car is being serviced");
        }
        public void Repair()
        {
            Console.WriteLine("Car is being repaired");
        }
    }
    class bike_maintenace : Ivehicle_maintenace
    {
        public void Service()
        {
            Console.WriteLine("Bike is being serviced");
        }
        public void Repair()
        {
            Console.WriteLine("Bike is being repaired");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Ivehicle_maintenace car = new car_maintenace();
            car.Service();
            car.Repair();
            Ivehicle_maintenace bike = new bike_maintenace();
            bike.Service();
            bike.Repair();
        }
    }
}
