using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee("Ali", "ali@example.com", 8000, 1000),
            new PartTimeEmployee("Sara", 100, 80),
            new FullTimeEmployee("Reza", "reza@example.com", 9000),
            new PartTimeEmployee("Mina", 120, 60)
        };

            foreach (var emp in employees)
            {
                emp.PrintPayslip();

                //C#7 Upper
                //if (emp is IEmailablePayslip emailable)
                //{
                //    emailable.SendPayslipByEmail();
                //}

                IEmailablePayslip emailable = emp as IEmailablePayslip;
                if (emailable != null)
                {
                    emailable.SendPayslipByEmail();
                }

                Console.WriteLine();
            }
        }
        public interface IPayable
        {
            void PrintPayslip();
        }

        public interface IEmailablePayslip
        {
            void SendPayslipByEmail();
        }


        public abstract class Employee : IPayable
        {
            private string name; // ⬅️ Encapsulation

            public Employee(string name)
            {
                this.name = name;
            }

            public string GetName()
            {
                return name;
            }

            // ⬅️ این متد باید در کلاس‌های فرزند پیاده‌سازی شود
            public abstract double CalculateSalary();

            // ⬅️ اینترفیس رو مجبور می‌کنه کلاس‌های فرزند فیش حقوقی چاپ کنند
            public abstract void PrintPayslip();
        }

        public class FullTimeEmployee : Employee, IEmailablePayslip
        {
            public double MonthlySalary { get; set; }
            public double Bonus { get; set; }

            private string email; 

            public FullTimeEmployee(string name,string email, double salary, double bonus = 0)
                : base(name)
            {
                MonthlySalary = salary;
                Bonus = bonus;
                this.email = email;
            }

            public override double CalculateSalary()
            {
                return MonthlySalary + Bonus;
            }

            public override void PrintPayslip()
            {
                Console.WriteLine($"Full-Time | {GetName()} | Base: {MonthlySalary} | Bonus: {Bonus} | Total: {CalculateSalary()}");
            }

            public void SendPayslipByEmail()
            {
                Console.WriteLine($"[EMAIL] Sent to {email} | {GetName()}'s Salary: {CalculateSalary()}");
            }
        }

        public class PartTimeEmployee : Employee
        {
            public double HourlyRate { get; set; }
            public int HoursWorked { get; set; }

            public PartTimeEmployee(string name, double rate, int hours)
                : base(name)
            {
                HourlyRate = rate;
                HoursWorked = hours;
            }

            public override double CalculateSalary()
            {
                return HourlyRate * HoursWorked;
            }

            public override void PrintPayslip()
            {
                Console.WriteLine($"Part-Time | {GetName()} | Hours: {HoursWorked} | Rate: {HourlyRate} | Total: {CalculateSalary()}");
            }
        }
    }
}
