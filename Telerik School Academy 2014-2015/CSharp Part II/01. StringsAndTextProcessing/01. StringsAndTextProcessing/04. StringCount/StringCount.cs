using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.StringCount
{
    class StringCount
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();

            int count = 0;

            int index = text.IndexOf(word);
		while (index !=-1) {
			count++;
			index = text.IndexOf(word, index+1);			
		}

        Console.WriteLine("The result is: " + count);
        }
    }
}
