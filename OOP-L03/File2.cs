using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public partial class User
    {
        public string Email;
        public void ShowEmail()
        {
            Console.WriteLine($"Email: {Email}");
        }
    }
}
