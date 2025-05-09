using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace may_7
{
     class Vehicle
    {
        public string Make;
        public string Model;

        public void DisplayVechile() 
        { 
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Model: " + Model);
        }

    }
    class Car : Vehicle
    {
        public string FuelType;
        
        public void DisplayCar()
        {
            Console.WriteLine("Color: " + FuelType);
           
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

            Car mycar = new Car { Make = "Hyundai", Model = "i20 Elite ", FuelType = " Diesel" };

            mycar.DisplayVechile();
            mycar.DisplayCar();

        }
    }
}
