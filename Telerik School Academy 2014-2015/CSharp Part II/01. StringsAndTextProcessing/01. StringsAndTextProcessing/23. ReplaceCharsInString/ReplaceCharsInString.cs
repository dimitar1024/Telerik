using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _23.ReplaceCharsInString
{
    class ReplaceCharsInString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();

            Console.WriteLine(Regex.Replace(text, @"(\w)\1+", "$1"));
        }
    }
}
