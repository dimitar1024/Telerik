using System;
class CompareArrays
{
    static void Main(string[] args)
    {

        string one = Console.ReadLine().Trim();
        string two = Console.ReadLine().Trim();

        string[] oneToArray = one.Split(' ');
        string[] twoToArray = two.Split(' ');

        int[] oneToInt = new int[oneToArray.Length];
        for (int i = 0; i < oneToInt.Length; i++)
        {
            oneToInt[i] = int.Parse(oneToArray[i]);
        }
        int[] twoToInt = new int[twoToArray.Length];
        for (int j = 0; j < twoToInt.Length; j++)
        {
            twoToInt[j] = int.Parse(twoToArray[j]);
        }

        int countToEqual = 0;
        if (oneToInt.Length != twoToInt.Length)
        {
            Console.WriteLine("false");
        }
        else
        {
            for (int i = 0; i < oneToInt.Length; i++)
            {
                if (oneToInt[i] == twoToInt[i])
                {
                    countToEqual++;
                }
            }

            if (countToEqual == oneToArray.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

    }
}
