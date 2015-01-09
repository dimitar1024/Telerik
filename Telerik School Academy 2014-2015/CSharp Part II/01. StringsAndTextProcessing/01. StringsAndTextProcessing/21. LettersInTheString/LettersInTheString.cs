using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.LettersInTheString
{
    class LettersInTheString
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            text = text.Replace(" ", "");
            text = text.Replace(".", "");
            text = text.Replace("?", "");
            text = text.Replace("!", "");
            text = text.Replace(",", "");
            Dictionary<char, int> countLatters = new Dictionary<char, int>();

            char[] letters = text.ToCharArray();

            foreach (char chr in letters)
            {

                
                int count;

                if (!countLatters.TryGetValue(chr, out count))
                {
                    count = 0;

                }
                countLatters[chr] = count + 1;

            }


            foreach (KeyValuePair<char, int> pair in countLatters)

            {

                  Console.WriteLine(

                        "char '{0}' occurs {1} time(s) in the text",

                        pair.Key, pair.Value);

            }
        }
    }
}
