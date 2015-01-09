using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReadNumber
{
    class ReadNumber
    {
        private static int Print10Numbers(int start, int end)
        {
            
                int n = int.Parse(Console.ReadLine());
                if (n < start || n > end)
                {
                    throw new IndexOutOfRangeException();
                }

                return n;
            
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter number in range [start...end]");
                Console.Write("Enter number for start: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Enter number for end: ");
                int end = int.Parse(Console.ReadLine());
                Console.WriteLine("Please star to enter the numbers in that range:");

                int[] numbers = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = Print10Numbers(start, end);
                }

                Console.WriteLine(String.Join(", ",numbers));
                
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Your number is out of range!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your number is too big!");
            }
        }
    }
}
