using System;
class PrintFullNameOnLastDigitOnNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int digit = getLastDigit(n);
        printDigitToString(digit);
    }

    public static int getLastDigit(int number)
    {
        int n = number % 10;
        return n;
    }

    public static void printDigitToString(int number)
    {
        switch (number)
        {
            case 0:
                Console.WriteLine("zero");
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;
        }
    }

}
