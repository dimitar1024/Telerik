using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UppercaseProgram
{
    class UppercaseProgram
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int startGet = text.IndexOf("<upcase>");
            int endGet = text.IndexOf("</upcase>")+9;
            
            while ((startGet != -1) &&(endGet != -1))
            {
                int len = endGet - startGet;

                string uppercase = text.Substring(startGet, len);
                string wordForUpper = uppercase;
                uppercase = uppercase.Replace("<upcase>", "");
                uppercase = uppercase.Replace("</upcase>", "");
                uppercase = uppercase.ToUpper();


                text = text.Replace(wordForUpper, uppercase);
                startGet = text.IndexOf("<upcase>", startGet + 1);
                endGet = text.IndexOf("</upcase>", endGet + 1);
            }
            text = text.Replace("<upcase>", "");
            text = text.Replace("</upcase>", "");
            Console.WriteLine(text);
            
        }
    }
}
