using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrintNumberInDiffFormats
{
    class PrintNumberInDiffFormats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15:D2} | {1,15:X} | {2,15:P} | {3,15:E2} |",num,num,num,num);

        }
    }
}
