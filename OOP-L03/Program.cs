using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region Class & Object

            //Car myCar = new Car();
            //myCar.Brand = "BMW";
            //myCar.Speed = 180;
            //myCar.Drive();

            //#endregion

            //#region Constructor
            //Book myBook = new Book("C# in Depth");
            //Console.WriteLine(myBook.Title);
            //#endregion

            //#region Field & Property
            //Person p = new Person();
            //p.Age = 30;
            //Console.WriteLine(p.Age);
            //#endregion

            //#region Method & Overloading
            //Calculator c = new Calculator();
            //Console.WriteLine(c.Add(5, 3));
            //Console.WriteLine(c.Add(2.5, 4.5));
            //#endregion

            //#region Encapsulation - Modifier
            //BankAccount account = new BankAccount();
            //account.Deposit(500);
            //Console.WriteLine($"Balance: {account.GetBalance()}");
            //#endregion

            //#region Inheritance
            //Car2 c2 = new Car2("Toyota");
            //c2.ShowBrand();
            //#endregion

            //#region Polymorphism
            ////1.
            //Animal a1 = new Cat();
            //Animal a2 = new Dog();
            //a1.Speak(); // Meow
            //a2.Speak(); // Woof
            ////2.
            //IShape s1 = new Rectangle();
            //IShape s2 = new Circle();
            //Console.WriteLine(s1.Area());
            //Console.WriteLine(s2.Area());
            //#endregion

            //#region Interface

            //#endregion

            //#region Abstract class vs Interface

            //#endregion

            //#region Static class
            //Console.WriteLine(MathUtil.Square(5));
            //#endregion

            //#region Partial class
            //User user = new User();
            //user.Name = "Ali";
            //user.Email = "ali@example.com";

            //user.ShowName();    // Name: Ali
            //user.ShowEmail();   // Email: ali@example.com
            //#endregion

            //#region Nested class
            //Car3.Engine engine = new Car3.Engine();
            //engine.Start();
            //#endregion

            //#region Sealed class
            ////OnlyClass
            //#endregion

            #region Extension Method
            string sentence = "Object oriented programming in C# is powerful";
            Console.WriteLine(sentence.WordCount());
            #endregion

            Console.ReadLine();

        }
        public class Car
        {
            public string Brand;
            public int Speed;

            public void Drive()
            {
                Console.WriteLine($"{Brand} is driving at {Speed} km/h");
            }
        }

        public class Book
        {
            public string Title;
            public Book(string title)
            {
                Title = title;
            }
        }
        public class Person
        {
            private int age;

            public int Age
            {
                get { return age; }
                set
                {
                    if (value > 0)
                        age = value;
                }
            }
        }

        public class Calculator
        {
            public int Add(int a, int b) => a + b;
            public double Add(double a, double b) => a + b;
        }

        public class BankAccount
        {
            private decimal balance; // فقط درون کلاس قابل دسترسی است

            public void Deposit(decimal amount) // از همه جا قابل دسترسی است
            {
                balance += amount;
            }

            protected void Audit() // فقط در کلاس فعلی و فرزندها قابل دسترسی است
            {
                Console.WriteLine("Auditing transaction");
            }

            internal void InternalReport() // فقط در همان اسمبلی قابل دسترسی است
            {
                Console.WriteLine("Internal report generated");
            }

            public decimal GetBalance() => balance;
        }

        public class Vehicle
        {
            public string Brand;
            public Vehicle(string brand)
            {
                Brand = brand;
            }
        }

        public class Car2 : Vehicle
        {
            public Car2(string brand) : base(brand) { }
            public void ShowBrand() => Console.WriteLine($"Brand: {Brand}");
        }

        public class Animal
        {
            public virtual void Speak() => Console.WriteLine("Animal speaks");
        }

        public class Cat : Animal
        {
            public override void Speak() => Console.WriteLine("Meow");
        }

        public class Dog : Animal
        {
            public override void Speak() => Console.WriteLine("Woof");
        }


        public interface IShape
        {
            double Area();
        }
        public class Rectangle : IShape
        {
            public double Width = 5;
            public double Height = 4;
            public double Area() => Width * Height;
        }
        public class Circle : IShape
        {
            public double Radius = 3;
            public double Area() => Math.PI * Radius * Radius;
        }
        public static class MathUtil
        {
            public static int Square(int x) => x * x;
        }
        public class Car3
        {
            public class Engine
            {
                public void Start() => Console.WriteLine("Engine Started");
            }
        }
        public sealed class Logger
        {
            public void Log(string message) => Console.WriteLine(message);
        }



    }
}
