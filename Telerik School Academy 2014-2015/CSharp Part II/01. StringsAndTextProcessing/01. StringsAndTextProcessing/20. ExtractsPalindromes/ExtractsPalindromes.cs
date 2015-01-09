using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ExtractsPalindromes
{
    class ExtractsPalindromes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();

            string[] words = text.Split(new Char[] { ' ', ',', '.', ':', '\t' },StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string reverse = ReverseString(word);

                if (word == reverse)
                {
                    palindromes.Add(word);
                }
            }

            foreach (var item in palindromes)
            {
                Console.WriteLine(item + " ");
            }
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
