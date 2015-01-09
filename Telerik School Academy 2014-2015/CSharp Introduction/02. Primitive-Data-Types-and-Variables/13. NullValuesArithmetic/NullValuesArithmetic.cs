using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? number1 = 123;
        double? number2 = null;
        int? number3 = 546;
        double? number4 = 43.22344;
        int? number5 = null;
        double? number6 = null;
        int? number7 = 24;
        double? number8 = 57346.35764334;
        int? number9 = null;
        double? number10 = 744.76763;

        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", number1, number2, number3, number4, number5, number6, number7, number8, number9, number10);

    }
}

