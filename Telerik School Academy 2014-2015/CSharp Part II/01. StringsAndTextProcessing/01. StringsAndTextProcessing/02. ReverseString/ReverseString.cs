using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace _02.ReverseString
{

    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] strToArr = str.ToCharArray();
            Array.Reverse(strToArr);
            string rev = new string(strToArr);

            Console.WriteLine(rev);
        }
    }
}
