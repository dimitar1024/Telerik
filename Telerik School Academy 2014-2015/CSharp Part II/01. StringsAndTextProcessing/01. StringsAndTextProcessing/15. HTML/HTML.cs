using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _15.HTML
{
    class HTML
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter HTML");
            string url = Console.ReadLine();
            
            url = Regex.Replace(url, "</a>", "[/URL]");

            url = Regex.Replace(url, "<a href=\"", "[URL=");

            url = Regex.Replace(url, "[URL=[^>]*\">", "] ");

            Console.WriteLine(url);
        }
    }
}
