using System;
class AlfaBetaProgram
{
    static void Main()
    {
        char[] alfabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ' };
        string input = Console.ReadLine().ToLower();
        char[] word = input.ToCharArray();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alfabet.Length; j++)
            {
                if (word[i] == alfabet[j])
                {
                    if (j < 26)
                    {
                        Console.Write(j + 1 + " ");

                    }
                    else
                    {
                        Console.Write("space ");
                    }

                }
            }
        }
        Console.WriteLine();
    }
}

