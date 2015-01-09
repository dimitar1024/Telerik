using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = RandomArray(5);
            Console.WriteLine(String.Join(", ",elements));
            
            Console.WriteLine("Max()");
            Console.WriteLine(elements.Max<int>());
            
            Console.WriteLine("Min()");
            Console.WriteLine(elements.Min<int>());

            Console.WriteLine("Sum()");
            Console.WriteLine(elements.Sum<int>());

            Console.WriteLine("Product()");
            Console.WriteLine(elements.Product<int>());

        }

        static int[] RandomArray(int numberOfElements) 
        {
            Random rnd = new Random();
            int[] numbers = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
			{
                numbers[i] = rnd.Next(0, 101);
			}
            return numbers;
        }
    }
}
