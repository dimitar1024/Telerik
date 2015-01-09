using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PadWithStars
{
    class PadWithStars
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (text.Length <= 20)
            {
                Console.WriteLine(text.PadRight(20, '*'));
            }
        }
    }
}
