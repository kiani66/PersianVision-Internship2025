using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L03
{
    // Partial class - بخش دوم
    public partial class Report
    {
        public DateTime Date;
        public void ShowDate() => Console.WriteLine($"Date: {Date.ToShortDateString()}");
    }
}
