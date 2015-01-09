using System;
class CoeficentsOnEquation
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            linearEquation(input);
        }

        public static void linearEquation(string input)
        {
            input = input.Replace("x2", " ");
            string[] numToStr = input.Split(new char[] { ' ', ',', ';', '.', 'x', '-', '+', '=', '*'}, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[numToStr.Length];


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numToStr[i]);
            }

            int count = 1;
            for (int i = numbers.Length-1; i >=0; i--)
            {
                Console.WriteLine(numbers[i]);
                count++;

                if (count > 3)
                {
                    break;
                }
            }
        }
    }
