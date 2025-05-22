using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Fee { get; set; }
    }


    interface IEnrollable
    {
        void Enroll(Course course);
    }


    class User : IEnrollable
    {
        public string Name { get; set; }
        private List<(Course course, decimal finalFee)> enrolledCourses = new List<(Course, decimal)>();

        public void Enroll(Course course)
        {
            enrolledCourses.Add((course, course.Fee));
            Console.WriteLine($"Enrolled in {course.Title} at full fee: {course.Fee:C}");
        }

        public void Enroll(Course course, string couponCode)
        {
            decimal discount = couponCode == "SAVE10" ? 0.10m : 0;
            decimal finalFee = course.Fee * (1 - discount);
            enrolledCourses.Add((course, finalFee));
            Console.WriteLine($"Enrolled in {course.Title} with coupon '{couponCode}': {finalFee:C}");
        }

        public void PrintEnrollments()
        {
            Console.WriteLine($"\n{Name}'s Enrolled Courses:");
            foreach (var (course, fee) in enrolledCourses)
            {
                Console.WriteLine($"{course.Title} - {fee:C}");
            }
        }
    }
    class Program
    {

        static void Main()
        {
            var user = new User { Name = "Alice" };
            var c1 = new Course { Id = 1, Title = "C# Basics", Fee = 1000 };
            var c2 = new Course { Id = 2, Title = "Advanced LINQ", Fee = 1500 };

            user.Enroll(c1);
            user.Enroll(c2, "SAVE10");

            user.PrintEnrollments();
        }


    }

}
