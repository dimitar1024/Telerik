using System;
class NumberAsWords
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number from interval [0..999]");
            int number = int.Parse(Console.ReadLine());
            String[] onesStr = new String[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            String[] tensStr = new String[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            String[] specialStr = new String[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            int hunds = number / 100;
            int tens = (number / 10) % 10;
            int ones = number % 10;

            if ((hunds == 0) && (tens == 0))
            {
                Console.WriteLine(onesStr[ones]);
            }
            if ((hunds == 0) && (tens == 1))
            {
                Console.WriteLine(specialStr[ones]);
            }
            if ((hunds == 0) && (ones == 0))
            {
                Console.WriteLine("{0}", tensStr[tens]);
            }
            if ((hunds == 0) && (tens != 1))
            {
                Console.WriteLine("{0}-{1}", tensStr[tens], onesStr[ones]);
            }
            if ((hunds != 0) && (tens == 0) && (ones != 0))
            {
                Console.WriteLine("{0} hundred and{1}", onesStr[hunds], onesStr[ones]);
            }
            if ((hunds != 0) && (tens != 0) && (ones == 0))
            {
                Console.WriteLine("{0} hundred and {1}", onesStr[hunds], tensStr[tens]);
            }
            if ((hunds != 0) && (tens != 0) && (ones != 0))
            {
                Console.WriteLine("{0} hundred and {1}-{2}", onesStr[hunds], tensStr[tens], onesStr[ones]);
            }
            if ((tens == 0) && (ones == 0))
            {
                Console.WriteLine("{0} hundred", onesStr[hunds]);
            }
        }
    }
