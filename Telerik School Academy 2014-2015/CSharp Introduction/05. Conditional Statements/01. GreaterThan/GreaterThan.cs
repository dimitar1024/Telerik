using System;
class GreaterThan
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The first number \"{0}\" is greater than second number \"{1}\"", firstNumber, secondNumber);
            }
            if (secondNumber > firstNumber)
            {
                Console.WriteLine("The second number \"{0}\" is greater than first number \"{1}\"", secondNumber, firstNumber);
            }
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("The number is equal");
            }
        }
    }
