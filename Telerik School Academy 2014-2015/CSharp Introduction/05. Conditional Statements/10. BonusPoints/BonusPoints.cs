using System;
class BonusPoints
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number than 1 to 9");
        int number = int.Parse(Console.ReadLine());
        int result;
        switch (number)
        {
            case 1: number = 1 * 10;
                Console.WriteLine("Your score is: " + number);
                break;
            case 2: number = 2 * 10;
                Console.WriteLine("Your score is: " + number);
                break;
            case 3: number = 3 * 10;
                Console.WriteLine("Your score is: " + number);
                break;
            case 4: number = 4 * 100;
                Console.WriteLine("Your score is: " + number);
                break;
            case 5: number = 5 * 100;
                Console.WriteLine("Your score is: " + number);
                break;
            case 6: number = 6 * 100;
                Console.WriteLine("Your score is: " + number);
                break;
            case 7: number = 7 * 1000;
                Console.WriteLine("Your score is: " + number);
                break;
            case 8: number = 8 * 1000;
                Console.WriteLine("Your score is: " + number);
                break;
            case 9: number = 9 * 1000;
                Console.WriteLine("Your score is: " + number);
                break;
            default: Console.WriteLine("ERROR! Enter number than 1 to 9 ");
                break;
        }
    }
}
