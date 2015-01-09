using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReversesTheWords
{
    class ReversesTheWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter senstences");
            string text = Console.ReadLine();
            string flag = text.Substring(text.Length - 1);
            string input = text.Substring(0, text.Length - 1);
            string[] words = input.Split(' ');
            Array.Reverse(words);

            foreach (var item in words)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine(flag);

            

        }
    }
}
