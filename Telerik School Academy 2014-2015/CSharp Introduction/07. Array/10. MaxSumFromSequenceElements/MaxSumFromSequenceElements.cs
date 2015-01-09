using System;
class MaxSumFromSequenceElements
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        String input = Console.ReadLine().Trim();
        String[] numsToStr = input.Split(',');
        //parse string to numbers
        int[] numbers = new int[numsToStr.Length];
        for (int i = 0; i < numsToStr.Length; i++)
        {
            numsToStr[i] = numsToStr[i].Trim();
            numbers[i] = int.Parse(numsToStr[i]);
        }
        // program
        int sumNow = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sumNow = 0;
            for (int j = i; j >= 0; j--)
            {
                sumNow += numbers[j];
                if (sumNow == sum)
                {
                    for (int start = j; start <= i; start++)
                    {
                        if (start <= (i-1))
                        {
                            Console.Write(numbers[start] + " + ");    
                        }
                        else
                        {
                            Console.WriteLine(numbers[start]);   
                        }
                    }
                    return;
                }


            }
        }
    }
}
