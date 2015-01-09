using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("Enter word");
                string word = Console.ReadLine();
                Console.WriteLine("Enter translates");
                string translates = Console.ReadLine();

                

                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, translates);
                }

                Console.WriteLine(new string('*',80));
                Console.WriteLine("Dictionary");
                Console.WriteLine(new string('*', 80));
                foreach (var pair in dictionary)
                {
                    Console.WriteLine("{0} - {1}",
                    pair.Key,
                    pair.Value);
                }
                Console.WriteLine(new string('*', 80));
            }
            
        }
    }
}
