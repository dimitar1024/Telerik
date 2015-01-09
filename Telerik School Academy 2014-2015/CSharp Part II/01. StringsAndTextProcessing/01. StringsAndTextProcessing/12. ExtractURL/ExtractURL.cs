using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace _12.ExtractURL
{
    class ExtractURL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter URL");
            string url = Console.ReadLine();

            string pattern = "(.+)://(.+?)/(.*)";
            MatchCollection matches = Regex.Matches(url, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine("protocol: {0}", match.Groups[1].Value);
                Console.WriteLine("server: {0}", match.Groups[2].Value);
                Console.WriteLine("resource: {0}", match.Groups[3].Value);
                Console.WriteLine();
            }
        }
    }
}
