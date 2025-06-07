using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L03
{
    // Partial class - بخش اول
    public partial class Report
    {
        public string Title;
        public void ShowTitle() => Console.WriteLine($"Report: {Title}");
    }
}
