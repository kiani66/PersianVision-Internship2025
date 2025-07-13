namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLID Examples:\n");

            // SRP
            var invoice = new Invoice();
            var repository = new InvoiceRepository();
            var printer = new InvoicePrinter();
            invoice.CalculateTotal();
            repository.Save(invoice);
            printer.Print(invoice);
            Console.WriteLine("✅ SRP executed.\n");

            // OCP
            var discountCalculator = new DiscountCalculatorG();
            Console.WriteLine("Gold discount: " + discountCalculator.CalculateDiscount(new GoldCustomer()));
            Console.WriteLine("Silver discount: " + discountCalculator.CalculateDiscount(new SilverCustomer()));
            Console.WriteLine("✅ OCP executed.\n");

            // LSP
            List<IFlyable> birds = new List<IFlyable> { new Sparrow() };
            foreach (var bird in birds)
            {
                bird.Fly();
            }
            Console.WriteLine("✅ LSP executed.\n");

            // ISP
            IWorkable humanWorker = new Human();
            IEatable humanEater = new Human();
            IWorkable robotWorker = new Robot();
            humanWorker.Work();
            humanEater.Eat();
            robotWorker.Work();
            Console.WriteLine("✅ ISP executed.\n");

            // DIP
            var emailNotification = new Notification(new EmailSender());
            var smsNotification = new Notification(new SmsSender());
            emailNotification.Send("Email: Hello world!");
            smsNotification.Send("SMS: Hello world!");
            Console.WriteLine("✅ DIP executed.\n");
        }
    }
    #region Single Responsibility Principle (SRP)

    public class InvoiceB
    {
        public void CalculateTotal() { /*...*/ }

        public void SaveToDatabase() { /*...*/ }

        public void PrintInvoice() { /*...*/ }
    }

    public class Invoice
    {
        public void CalculateTotal() { /*...*/ }
    }

    public class InvoiceRepository
    {
        public void Save(Invoice invoice) { /*...*/ }
    }

    public class InvoicePrinter
    {
        public void Print(Invoice invoice) { /*...*/ }
    }
    #endregion

    #region Open/Closed Principle (OCP)
    public class DiscountCalculator
    {
        public double CalculateDiscountB(string customerType)
        {
            if (customerType == "Gold") return 0.2;
            if (customerType == "Silver") return 0.1;
            return 0;
        }
    }

    public interface IDiscount
    {
        double GetDiscount();
    }

    public class GoldCustomer : IDiscount
    {
        public double GetDiscount() => 0.2;
    }

    public class SilverCustomer : IDiscount
    {
        public double GetDiscount() => 0.1;
    }

    public class PlatniumCustomer : IDiscount
    {
        public double GetDiscount() => 0.15;
    }

    public class DiscountCalculatorG
    {
        public double CalculateDiscount(IDiscount customer)
        {
            return customer.GetDiscount();
        }
    }


    #endregion

    #region Liskov Substitution Principle (LSP)
    public class BirdB
    {
        public virtual void Fly() => Console.WriteLine("Flying");
    }

    public class OstrichB : BirdB
    {
        public override void Fly() => throw new NotSupportedException();
    }

    public abstract class BirdG { }

    public interface IFlyable
    {
        void Fly();
    }

    public class Sparrow : BirdG, IFlyable
    {
        public void Fly() => Console.WriteLine("Flying");
    }

    public class Ostrich : BirdG
    {
        // No Fly behavior
    }


    #endregion

    #region Interface Segregation Principle(ISP)
    public interface IWorker
    {
        void Work();
        void Eat();
    }

    public class RobotB : IWorker
    {
        public void Work() { }
        public void Eat() => throw new NotImplementedException();
    }

    public interface IWorkable
    {
        void Work();
    }

    public interface IEatable
    {
        void Eat();
    }

    public class Human : IWorkable, IEatable
    {
        public void Work() { }
        public void Eat() { }
    }

    public class Robot : IWorkable
    {
        public void Work() { }
    }


    #endregion

    #region Dependency Inversion Principle (DIP)

    public class EmailSenderB
    {
        public void Send(string message) { /* ... */ }
    }

    public class NotificationB
    {
        private EmailSender _emailSender = new EmailSender();

        public void Send(string message) => _emailSender.Send(message);
    }


    public interface IMessageSender
    {
        void Send(string message);
    }

    public class EmailSender : IMessageSender
    {
        public void Send(string message) { /* ... */ }
    }

    public class SmsSender : IMessageSender
    {
        public void Send(string message) { /* ... */ }
    }

    public class Notification
    {
        private readonly IMessageSender _sender;

        public Notification(IMessageSender sender)
        {
            _sender = sender;
        }

        public void Send(string message) => _sender.Send(message);
    }


    #endregion
}
