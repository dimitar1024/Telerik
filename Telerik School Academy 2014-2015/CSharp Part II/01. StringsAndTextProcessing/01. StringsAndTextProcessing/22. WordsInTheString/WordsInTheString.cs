using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.WordsInTheString
{
    class WordsInTheString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            
            string[] tokens = text.Split(' ', '.', ',', '-', '?', '!');

            IDictionary<string, int> words = new SortedDictionary<string, int>();

            foreach (string word in tokens)
            {

                if (string.IsNullOrEmpty(word.Trim()))
                {
                    continue;
                }

                int count;

                if (!words.TryGetValue(word, out count))
                {
                    count = 0;
                }

                words[word] = count + 1;

            }

            foreach (KeyValuePair<string, int> wordEntry

                  in words)
            {

                Console.WriteLine(

                      "Word '{0}' occurs {1} time(s) in the text",

                      wordEntry.Key, wordEntry.Value);

            }
            
        }
    }
}
