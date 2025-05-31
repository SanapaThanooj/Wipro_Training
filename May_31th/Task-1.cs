using System;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    interface IRentable
    {
        void Rent(int days);
    }
    abstract class Vehicle : IRentable
    {
        public string Name { get; set; }
        public double RentPerDay { get; set; }
        public  Vehicle(string name , double RentPerDay)
        {
            Name = name;
            this.RentPerDay = RentPerDay;
        }
        public virtual void Rent(int days)
        {
            Console.WriteLine($"Renting {Name} for {days} days at {RentPerDay} per day.");
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Name: {Name}, Rent Per Day: {RentPerDay}");
        }

    }
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public Car(string name, double rentPerDay, int numberOfDoors) : base(name, rentPerDay)
        {
            NumberOfDoors = numberOfDoors;
        }
        public override void Rent(int days)
        {
            double totalRent = RentPerDay * days;
            base.Rent(days);
            Console.WriteLine($"This car has {NumberOfDoors} doors and Total cost is Rs.{totalRent}");
        }
    }
    class Bike : Vehicle
    {
        public bool HasCarrier { get; set; }
        public Bike(string name, double rentPerDay, bool hasCarrier) : base(name, rentPerDay)
        {
            HasCarrier = hasCarrier;
        }
        public override void Rent(int days)
        {
            double totalRent = RentPerDay * days;
            base.Rent(days);
            Console.WriteLine($"This bike has a carrier: {HasCarrier} and Total cost is Rs.{totalRent}");
        }
    }
    class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }
        public Truck(string name, double rentPerDay, double loadCapacity) : base(name, rentPerDay)
        {
            LoadCapacity = loadCapacity;
        }
        public override void Rent(int days)
        {
            double totalRent = RentPerDay * days;
            base.Rent(days);
            Console.WriteLine($"This truck has a load capacity of {LoadCapacity} tons. and Total cost is Rs.{totalRent}");
        }
    }   

    class Program
    {
        static void Main()
        {
           List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("Hyundi i20", 50, 4),
                new Bike("Duck RC350", 15, true),
                new Truck("TATA ACE", 80, 2.5)
            };
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                vehicle.Rent(3);
                Console.WriteLine();
            }
        }
    }
}