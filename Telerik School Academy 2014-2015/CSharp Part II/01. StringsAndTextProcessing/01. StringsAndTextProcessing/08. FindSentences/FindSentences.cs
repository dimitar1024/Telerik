using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FindSentences
{
    class FindSentences
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            string[] sentences = text.Split('.');
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            bool isSentences = false;
            List<string> result = new List<string>();

            foreach (string item in sentences)
            {
                string[] words = item.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    
                    if (word == words[i])
                    {
                        isSentences = true;
                    }
                }
                if (isSentences)
                {
                    result.Add(item);
                    isSentences = false;
                }
                

            }

            foreach (string sen in result)
            {
                Console.WriteLine(sen);
            }

        }
    }
}
