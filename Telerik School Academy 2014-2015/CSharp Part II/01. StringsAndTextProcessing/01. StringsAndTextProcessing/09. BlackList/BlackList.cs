using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _09.BlackList
{
    class BlackList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter blacklist word with \", \"");
            string inputWords = Console.ReadLine();
            string[] blacklist = Regex.Split(inputWords, ", ");

            for (int i = 0; i < blacklist.Length; i++)
            {
                int len = blacklist[i].Length;
                string replace = new string('*', len);
                text = text.Replace(blacklist[i],replace);
            }

            Console.WriteLine(text);
        }
    }
}
