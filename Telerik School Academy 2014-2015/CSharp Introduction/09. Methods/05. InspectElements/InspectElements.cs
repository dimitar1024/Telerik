using System;
class InspectElements
{
    static void Main(string[] args)
    {

        string input = Console.ReadLine();
        int pos = int.Parse(Console.ReadLine());

        String[] numsToStr = input.Split(' ');
        int[] numbers = new int[numsToStr.Length];
        for (int i = 0; i < numsToStr.Length; i++)
        {
            numbers[i] = int.Parse(numsToStr[i]);
        }// End input

        inspectElement(numbers, pos);

    }

    public static void inspectElement(int[] arr, int pos)
    {
        if ((arr[pos - 1] > arr[pos]) && (arr[pos + 1] > arr[pos]))
        {
            Console.WriteLine("Element " + arr[pos] + " on position " + pos + " is smaller");
        }
        else if ((arr[pos - 1] < arr[pos]) && (arr[pos + 1] < arr[pos]))
        {
            Console.WriteLine("Element " + arr[pos] + " on position " + pos + " is bigger");
        }
        else
        {
            Console.WriteLine("Equl");
        }

    }
}
