using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    

    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeSound();

        public virtual void Feed()
        {
            Console.WriteLine($"Feeding the animal: {Name}");
        }
    }

    class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Lion roars!");
        }
    }

    class Elephant : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Elephant trumpets!");
        }
    }

    class Monkey : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Monkey chatters!");
        }
    }

    class Zoo
    {
         List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void ShowAllActions()
        {
            foreach (var animal in animals)
            {
                animal.MakeSound();
                animal.Feed();
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var zoo = new Zoo();

            zoo.AddAnimal(new Lion { Name = "Leo", Age = 5 });
            zoo.AddAnimal(new Elephant { Name = "Ella", Age = 10 });
            zoo.AddAnimal(new Monkey { Name = "Momo", Age = 3 });

            zoo.ShowAllActions();
        }
    }

}
