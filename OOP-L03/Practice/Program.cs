namespace OOP_L03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee
            {
                Name = "Ali",
                UserRole = Role.Employee,
                EmployeeId = 101
            };

            e.DisplayInfo();
            e.CheckIn();
            e.CheckOut();

            Console.WriteLine("Formatted name: " + Utility.FormatName(e.Name));

            int number = 43;
            Console.WriteLine($"{number} is even? {number.IsEven()}");

            Report r = new Report
            {
                Title = "Daily Attendance",
                Date = DateTime.Now
            };

            r.ShowTitle();
            r.ShowDate();
        }


        // Enum
        public enum Role { Admin, Employee }

        // Interface
        public interface IAttendance
        {
            void CheckIn();
            void CheckOut();
        }

        // Abstract class
        public abstract class Person
        {
            public string Name { get; set; }
            public Role UserRole { get; set; }
            public abstract void DisplayInfo();
        }

        // Employee با وراثت از Person و پیاده‌سازی IAttendance
        public class Employee : Person, IAttendance
        {
            public int EmployeeId { get; set; }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Employee: {Name}, Role: {UserRole}");
            }

            public void CheckIn()
            {
                Console.WriteLine($"{Name} checked in at {DateTime.Now.ToLongDateString()}");
            }

            public void CheckOut()
            {
                Console.WriteLine($"{Name} checked out at {DateTime.Now.ToLongDateString()}");
            }
        }

        // کلاس static
        public static class Utility
        {
            public static string FormatName(string name) => name.ToUpper();
        }
    }
}

