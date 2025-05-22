using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IAttendance
    {
        void MarkAttendance();
        abstract class staff
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }

            public abstract decimal Calculatesalary();
        }
        class PermanentStaff : staff, IAttendance
        {
            public decimal MonthlySalary { get; set; }
            public override decimal Calculatesalary()
            {
                return MonthlySalary;
            }
            public void MarkAttendance()
            {
                Console.WriteLine($"Attendance marked for {Name}");
            }
        }
        class ContractStaff : staff, IAttendance
        {
            public decimal HourlyRate { get; set; }
            public int HoursWorked { get; set; }
            public override decimal Calculatesalary()
            {
                return HourlyRate * HoursWorked;
            }
            public void MarkAttendance()
            {
                Console.WriteLine($"Attendance marked for {Name}");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<staff> staffList = new List<staff>();
                staffList.Add(new PermanentStaff { Id = 1, Name = "John", Department = "HR", MonthlySalary = 5000 });
                staffList.Add(new ContractStaff { Id = 2, Name = "Jane", Department = "IT", HourlyRate = 20, HoursWorked = 40 });
                foreach (var staff in staffList)
                {
                    Console.WriteLine($"Staff ID: {staff.Id}, Name: {staff.Name}, Department: {staff.Department}, Salary: {staff.Calculatesalary()}");
                    if (staff is IAttendance attendance)
                    {
                        attendance.MarkAttendance();
                    }
                }
            }
        }

    }
}
