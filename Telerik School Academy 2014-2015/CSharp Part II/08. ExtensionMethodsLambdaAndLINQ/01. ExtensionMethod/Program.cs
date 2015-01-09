using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Extension Methods, Lambda Expressions and LINQ";

            Console.WriteLine( new StringBuilder(input).Substring(0,9));
            Console.WriteLine(new StringBuilder(input).Substring(10, 7));
            Console.WriteLine(new StringBuilder(input).Substring(19, 6));
            Console.WriteLine(new StringBuilder(input).Substring(26, 12));
            Console.WriteLine(new StringBuilder(input).Substring(38, 3));
            Console.WriteLine(new StringBuilder(input).Substring(42, 4));
        }
    }
}
