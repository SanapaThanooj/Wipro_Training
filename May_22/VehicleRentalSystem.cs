using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp4
{
    public abstract class Vehicle
    {
        public string VehicleNumber { get; set; }

        public string Brand { get; set; }
        public string RatePerDay { get; set; }

        public abstract void CalculateRent(int days);
    }
    class Car : Vehicle
    {
        public override void CalculateRent(int days)
        {
            Console.WriteLine($"The rent for {days} days for the car {Brand} is {days * Convert.ToInt32(RatePerDay)}");
        }
    }
    class Bike : Vehicle
    {
        public override void CalculateRent(int days)
        {
            Console.WriteLine($"The rent for {days} days for the bike {Brand} is {days * Convert.ToInt32(RatePerDay)}");
        }
    }
    class Truck : Vehicle
    {
        public override void CalculateRent(int days)
        {
            Console.WriteLine($"The rent for {days} days for the truck {Brand} is {days * Convert.ToInt32(RatePerDay)}");
        }
    
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car { VehicleNumber = "C123", Brand = "Toyota", RatePerDay = "100" });
            vehicles.Add(new Bike { VehicleNumber = "B456", Brand = "Yamaha", RatePerDay = "50" });
            vehicles.Add(new Truck { VehicleNumber = "T789", Brand = "Ford", RatePerDay = "200" });
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle Number: {vehicle.VehicleNumber}, Brand: {vehicle.Brand}, Rate Per Day: {vehicle.RatePerDay}");
                vehicle.CalculateRent(5);
            }
        }
    }
   
}
