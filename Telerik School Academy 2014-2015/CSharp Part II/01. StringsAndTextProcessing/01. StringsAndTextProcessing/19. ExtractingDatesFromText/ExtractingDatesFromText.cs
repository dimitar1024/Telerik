using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace _19.ExtractingDatesFromText
{
    class ExtractingDatesFromText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            string pattern = @"\d{2}\.\d{2}\.\d{4}";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                var provider = new CultureInfo("en-CA", false);
                var date = match.Value.ToString(provider);
                Console.WriteLine(date);
            }
        }
    }
}
