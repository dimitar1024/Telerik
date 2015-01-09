using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DateCalculator
{
    class DateCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date in format day.month.year");
            DateTime first = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter date in format day.month.year");
            DateTime second = DateTime.Parse(Console.ReadLine());

            double diff = (second - first).TotalDays;

            Console.WriteLine(diff);
        }
    }
}
