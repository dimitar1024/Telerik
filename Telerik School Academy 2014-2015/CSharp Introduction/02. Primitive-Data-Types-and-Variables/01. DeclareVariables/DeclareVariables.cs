using System;
class DeclareVariables
{
    static void Main(string[] args)
    {
        ushort numberOne = 52130;
        sbyte numberTwo = -115;
        int numberThree = 4825932;
        byte numberFour = 97;
        short numberFive = -10000;
        short numberSix = 20000;
        byte numberSeven = 224;
        long numberEight = 970700000;
        byte numberNine = 112;
        sbyte numberTen = -44;
        int numberEleven = -1000000;
        short numberTwelve = 1990;
        ulong numberThirteen = 123456789123456789;

        Console.WriteLine("Numbers of type \" sbyte \" are: {0}, {1}", numberTwo, numberTen);
        Console.WriteLine("Numbers of type \" byte \" are: {0}, {1}, {2}", numberFour, numberSeven, numberNine);
        Console.WriteLine("Numbers of type \" short \" are: {0}, {1}, {2}", numberFive, numberSix, numberTwelve);
        Console.WriteLine("Numbers of type \" ushort \" are: {0}", numberOne);
        Console.WriteLine("Numbers of type \" int \" are: {0}, {1}", numberThree, numberEleven);
        Console.WriteLine("Numbers of type \" long \" are: {0}", numberEight);
        Console.WriteLine("Numbers of type \" ulong \" are: {0}", numberThirteen);
    }
}

