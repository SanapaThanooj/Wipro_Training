using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace may_7
{
     class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }
    class Manager : Employee 
    {
        public override void Work()
        {
            Console.WriteLine("Manager is managing the team");
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

            Employee emp = new Employee();
            emp.Work();

            Manager manage = new Manager();
            manage.Work();

            Employee ployman = new Manager();
            ployman.Work();



        }
    }
}