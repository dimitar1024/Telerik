using System;
class ListOfProblems
{
    static void Main(string[] args)
    {
        Console.WriteLine("\"Reverse number\" please enter: 1");
        Console.WriteLine("\"Average on array\" please enter: 2");
        Console.WriteLine("\"Lineal equation\" please enter: 3");
        Console.WriteLine("Pleace enter number of Problem: ");
        int problem = int.Parse(Console.ReadLine());

        switch (problem)
        {
            case 1:
                Console.WriteLine("Pleace enter number:");
                int number = int.Parse(Console.ReadLine());
                reverseNumbers(number);
                break;

            case 2:
                Console.WriteLine("Pleace enter array:");
                string input = Console.ReadLine();
                avgerageArray(input);
                break;

            case 3:
                Console.WriteLine("Enter linear equation:");
                string inp = Console.ReadLine().ToLower();
                linearEquation(inp);
                break;

            default:
                break;
        }
    }
    public static void reverseNumbers(int number)
    {
        String newNum = "";
        while (number > 0)
        {
            int digit = number % 10;
            number = number / 10;
            newNum = newNum + digit;
        }

        Console.WriteLine(newNum);
    }

    public static void avgerageArray(string str)
    {
        string[] numToStr = str.Split(new char[]{' ',',',';','.'},StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[numToStr.Length];
        int count = numToStr.Length;
        int sum = 0;
        for (int i = 0; i < numToStr.Length; i++)
        {
            numbers[i] = int.Parse(numToStr[i]);
            sum += numbers[i];
        }

        double avgOnStr = sum / count;

        Console.WriteLine(avgOnStr);
    }

    public static void linearEquation (string input)
    {
        string[] numToStr = input.Split(new char[] { ' ', ',', ';', '.','x','-','+','=','*'}, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[numToStr.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numToStr[i]);
        }

        int a = numbers[0];
        int b = numbers[1];
        int c = numbers[2];

        double result = c - b;
        result = result / a;

        Console.WriteLine(result);
    }
}
