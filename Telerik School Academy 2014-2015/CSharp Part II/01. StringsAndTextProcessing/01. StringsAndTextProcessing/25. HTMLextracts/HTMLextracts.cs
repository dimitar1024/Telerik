using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _25.HTMLextracts
{
    class HTMLextracts
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string html = Console.ReadLine();

            string pattern = "<.+?>";

            string[] substrings = Regex.Split(html, pattern);
            foreach (string match in substrings)
            {
                if (match == "")
                {
                    continue;
                }
                Console.WriteLine("'{0}'", match);
            }
        }
    }
}
