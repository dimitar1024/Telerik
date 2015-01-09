using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BracketsIsCorrectly
{
    class BracketsIsCorrectly
    {
        static void Main(string[] args)
        {
            string expr = Console.ReadLine();
            char[] chars = expr.ToCharArray();
            int bracketsCount = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                

                if (chars[i] == '(')
                {
                    bracketsCount++;
                }
                if (chars[i] == ')')
                {
                    bracketsCount--;
                }
            }

            if (bracketsCount == 0)
	        {
		        Console.WriteLine("correct expression");
	        }
            else
	        {
                Console.WriteLine("incorrect expression");
	        }
            
	

        }
    }
}
