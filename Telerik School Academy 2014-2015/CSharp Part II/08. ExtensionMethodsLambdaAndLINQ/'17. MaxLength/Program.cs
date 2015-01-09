using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.MaxLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            char[] delimiterChars = { ' ', ',', '.', ':','?','!', '\t' };

            string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);


            var maxLength = words.OrderByDescending(word => word.Length).First();

            Console.WriteLine(maxLength);
        }
    }
}
