using System;
class SequenceOfMaximalSumInGivenArray
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numToStr = input.Split(new []{',', ' ', ';'}, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[numToStr.Length];
            for (int i = 0; i < numToStr.Length; i++)
			{
                array[i] = int.Parse(numToStr[i]);
			}
            

            int max = array[0];
            int maxEnd = array[0];
            int longSequence = 1;
            int currentSequence = 1;
            int start = 0;
            int startTemp = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] + maxEnd > array[i])
                {
                    maxEnd = array[i] + maxEnd;
                    currentSequence++;
                }

                else
                {
                    maxEnd = array[i];
                    startTemp = i;
                    currentSequence = 1;
                }

                if (maxEnd > max)
                {
                    max = maxEnd;
                    longSequence = currentSequence;
                    start = startTemp;
                }
            }

            Console.WriteLine(max);

            for (int i = start; i < start + longSequence; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
