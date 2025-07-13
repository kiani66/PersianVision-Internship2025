using System.Text;

namespace DataStructureExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Array - Work Hours
            Console.WriteLine("Array - Work Hours");
            string[] workHours = { "08:00", "10:00", "14:00", "16:00" };
            Console.WriteLine("Work hours:");
            foreach (var hour in workHours)
                Console.WriteLine(hour);
            Console.WriteLine();
            #endregion

            #region List - Shopping Cart
            Console.WriteLine("List - Shopping Cart");
            List<string> cart = new List<string>();
            cart.Add("Shirt");
            cart.Add("Shoes");
            cart.Add("Hat");
            cart.Remove("Shoes");

            Console.WriteLine("Shopping Cart:");
            foreach (var item in cart)
                Console.WriteLine(item);
            Console.WriteLine();
            #endregion

            #region Dictionary - Employee IDs
            Console.WriteLine("Dictionary - Employee IDs");
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees[1001] = "Ali";
            employees[1002] = "Tarnam";
            employees[1003] = "Mahsa";

            Console.WriteLine("Employee 1002: " + employees[1002]);
            Console.WriteLine();
            #endregion

            #region Stack - Page History
            Console.WriteLine("Stack - Page History");
            Stack<string> pageHistory = new Stack<string>();
            pageHistory.Push("Home");
            pageHistory.Push("Profile");
            pageHistory.Push("Settings");

            Console.WriteLine("Back to previous page: " + pageHistory.Pop());
            Console.WriteLine();
            #endregion

            #region Queue - Support Queue
            Console.WriteLine("Queue - Support Queue");
            Queue<string> supportQueue = new Queue<string>();
            supportQueue.Enqueue("Ali");
            supportQueue.Enqueue("Tarnam");

            Console.WriteLine("First user in support queue: " + supportQueue.Dequeue());
            Console.WriteLine();
            #endregion

            #region HashSet - Emails
            Console.WriteLine("HashSet - Emails");
            HashSet<string> emails = new HashSet<string>();
            emails.Add("ali@gmail.com");
            emails.Add("tarnam@gmail.com");
            emails.Add("ali@gmail.com"); // duplicate is ignored

            Console.WriteLine("Unique email count: " + emails.Count);
            Console.WriteLine();
            #endregion

            #region SortedSet - Scores
            Console.WriteLine("SortedSet - Scores");
            SortedSet<int> scores = new SortedSet<int> { 85, 92, 78, 92 };
            Console.WriteLine("Sorted scores:");
            foreach (var score in scores)
                Console.WriteLine(score);
            Console.WriteLine();
            #endregion

            #region Tuple - Product Info
            Console.WriteLine("Tuple - Product Info");
            var product = GetProductInfo();
            Console.WriteLine($"Product: {product.name}, Price: {product.price}, In Stock: {product.inStock}");
            #endregion

            #region نمرین کلاس

            //int[] temps = { 30, 32, 29, 35, 33, 31, 28 };
            //int maxTemp = temps.Max();

            //string[] names = { "Ali", "Sara", "Reza", "Nima" };

            //for (int i = names.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //string[] namesRevers = names.Reverse().ToArray();
            //List<string> namesReversList = names.Reverse().ToList();

            //for (int i = 0; i < namesRevers.Length; i++) 
            //{
            //    Console.WriteLine(names[i]);
            //}


            //List<string> names = new List<string> { "Ali", "Sara", "Nima" };
            //names.Add("test");
            //names.Remove("Ali");
            //names.Add("test1");
            //names.Add("test2");
            //names.Add("test3");
            //names.Add("test4");

            //Console.WriteLine(string.Join(", ", names));
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine(names.Count);

            //names.Clear();

            //Dictionary<int, string> users = new Dictionary<int, string>
            //{
            //{1, "Ali"},
            //{2, "Tarnam"},
            //{3, "Mahsa"}
            //    };

            //Console.WriteLine(users[1]);
            //Console.WriteLine(users.Values);
            //Console.WriteLine(users.Keys);

            //users.Add(4, "test");

            //if (users.ContainsKey(4) == false) 
            //{
            //    Console.WriteLine("user exists");
            //}
            //if (users.ContainsValue("Mahsa") == false)
            //{
            //    Console.WriteLine("user exists");
            //}
            //users.ContainsKey(4);


            //if (users.TryGetValue(1, out string userName))
            //    Console.WriteLine(userName);
            //else
            //    Console.WriteLine("Not found");

            //users.Remove(1);
            //users.Clear();

            //foreach (var item in users.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in users.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in users)
            //{
            //    Console.WriteLine($"Id: {item.Key}, Name: {item.Value}");
            //}

            //Stack<string> pages = new Stack<string>();

            //// مرحله 1: افزودن صفحات
            //pages.Push("Home");
            //pages.Push("Profile");
            //pages.Push("Settings");

            //// مرحله 2: دیدن صفحه فعلی
            //Console.WriteLine("صفحه فعلی: " + pages.Peek());

            //// مرحله 3: بازگشت به صفحه قبلی
            //string backPage = pages.Pop();
            //Console.WriteLine("بازگشت به: " + backPage);

            //// مرحله 4: نمایش صفحات باقی‌مانده
            //Console.WriteLine("صفحات باقی‌مانده:");
            //foreach (var page in pages)
            //{
            //    Console.WriteLine(page);
            //}

            //// 1. Create a queue and add users
            //Queue<string> supportQueue = new Queue<string>();
            //supportQueue.Enqueue("Ali");
            //supportQueue.Enqueue("Tarnam");
            //supportQueue.Enqueue("Mahya");

            //// 2. Show the first user in the queue (without removing)
            //Console.WriteLine("First user in the queue (before dequeue): " + supportQueue.Peek());

            //// 3. Dequeue the first user (simulate serving them)
            //string servedUser = supportQueue.Dequeue();
            //Console.WriteLine("User served and removed from queue: " + servedUser);

            //// 4. Show remaining users in the queue
            //Console.WriteLine("Remaining users in the queue:");
            //foreach (var user in supportQueue)
            //{
            //    Console.WriteLine(user);
            //}
            //-------------------------------
            //Step 1: Create HashSet for storing unique emails

            //   HashSet<string> emails = new HashSet<string>();

            //// Step 2: Simulate user registration
            //string[] newRegistrations = {
            //    "ali@gmail.com",
            //    "tarnam@gmail.com",
            //    "ali@gmail.com",  // duplicate
            //    "mahya@gmail.com"
            //};

            //// Step 3: Process registrations
            //foreach (var email in newRegistrations)
            //{
            //    if (emails.Add(email))
            //        Console.WriteLine($"Added: {email}");
            //    else
            //        Console.WriteLine($"Duplicate – Ignored: {email}");
            //}

            //// Step 4: Print all unique registered emails
            //Console.WriteLine("\nAll registered emails:");
            //foreach (var email in emails)
            //    Console.WriteLine(email);
            //-------------------------------

            SortedSet<int> scores = new SortedSet<int>();

            int[] inputScores = { 85, 92, 78, 92, 100, 60, 85 };

            foreach (var score in inputScores)
            {
                if (scores.Add(score))
                    Console.WriteLine($"Added: {score}");
                else
                    Console.WriteLine($"Duplicate – Ignored: {score}");
            }

            Console.WriteLine("\nAll unique scores (sorted):");
            foreach (var score in scores)
                Console.WriteLine(score);

            Console.WriteLine($"\nLowest score: {scores.Min}");
            Console.WriteLine($"Highest score: {scores.Max}");





            #endregion

            Console.ReadLine();
        }
        static (string name, double price, bool inStock) GetProductInfo()
        {
            return ("Monitor", 3_500_000, true);
        }
    }
}
