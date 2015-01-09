using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ConvertStringInUniArray
{
    class ConvertStringInUniArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            char[] text = Console.ReadLine().ToCharArray();
            string result = "";
            foreach (var ch in text)
            {
                int uni = Convert.ToInt16(ch);
                string uniToStr = Convert.ToString(uni);
                string uniCode = "\\" + uniToStr.PadLeft(4, '0');
                result += uniCode;
            }

            Console.WriteLine(result);
        }
    }
}
