using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculateSquareRoot
{
    class CalculateSquareRoot
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number:");
            
            try
            {
                int num = int.Parse(Console.ReadLine());
                
                if (num < 0)
                {
                    throw new Exception();
                }
                double sqrt = Math.Sqrt(num);
                Console.WriteLine("Square root is " + sqrt);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number!");
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too big to fit in Int32!");
                
            }
            catch (Exception)
            {
                Console.WriteLine("The number is negarive");

            }
            finally 
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
