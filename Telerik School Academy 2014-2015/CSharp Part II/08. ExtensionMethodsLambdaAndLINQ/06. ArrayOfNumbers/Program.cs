using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ArrayOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = RandomArray(5);
            Console.WriteLine(String.Join(", ",numbers));
            Print(numbers.Where(n => n%3 == 0 && n%7==0));

            Print(from num in numbers where num % 3 == 0 && num%7==0 select num);

        }

        static void Print(IEnumerable items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
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
