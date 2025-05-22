using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class PhoneBook
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();


            phoneBook["Alice"] = "123-4567";
            phoneBook["Bob"] = "987-6543";
            phoneBook["Charlie"] = "555-1234";
            Console.WriteLine("Phone Book Contacts:");
            foreach (var contact in phoneBook)
            {
                Console.WriteLine($"{contact.Key}: {contact.Value}");
            }
            Console.WriteLine("Enter a name to search:");
            string name = Console.ReadLine();
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine($"{name}'s phone number is {phoneBook[name]}");
            }
            else
            {
                Console.WriteLine($"No contact found for {name}");
            }
        }
    }
}
