using System;
class ArrayFromOneTo20
{
    static void Main()
    {
        int[] array = new int[20];

        for (int i = 1; i <= array.Length; i++)
        {
            int newNumber = i * 5;
            Console.WriteLine(newNumber + " ");
        }
    }
}
