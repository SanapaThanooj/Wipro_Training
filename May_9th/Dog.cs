using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace may_7
{
     class Animal
    {
        public string name;
        public string species;

        public void PrintDetails()
        {
            Console.WriteLine("Animal Name: " + name);
            Console.WriteLine("Species: " + species);
        }
    }
    class Dog : Animal
    {
        public string breed;
        public void PrintDogDetails()
        {
            Console.WriteLine("Dog Breed: " + breed);
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

            Dog mydog = new Dog { name = "Buddy", species = "Canine",breed = "Labrador" };

            mydog.PrintDetails();
            mydog.PrintDogDetails();

        }
    }
}
