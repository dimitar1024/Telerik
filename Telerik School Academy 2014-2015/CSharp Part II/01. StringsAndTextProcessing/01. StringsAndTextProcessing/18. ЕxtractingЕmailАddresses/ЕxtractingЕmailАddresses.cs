using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _18.ЕxtractingЕmailАddresses
{
    class ЕxtractingЕmailАddresses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();

            string pattern = "[A-Za-z0-9-+_.]+@[A-Za-z0-9-+_]+.[A-Za-z0-9-+_.]+";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine("E-mail: {0}", match.Value);
            }
        }
    }
}
