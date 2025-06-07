using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L03
{
    public static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}
