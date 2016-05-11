using System;


    class Maximal_increasing_sequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }


            // integers, needed for the main program. 
            //k, bestCount - counters of indecies; bestElement - the value of repeated sequences;
            // k = current count
            int currentCount = 1;
            int currentElement = numbers[0];
            int bestCount = 0;
            int bestElement = 0;

            //foreach (int element in numbers)
            //{
            //    Console.WriteLine(element);
            //};

            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i] >= numbers[i - 1]+1)
                {
                    currentCount += 1;
                    bestCount = Math.Max(currentCount, bestCount);
                    bestElement = numbers[i];


                }
                else
                {
                    if (bestCount < currentCount)
                    {
                        bestCount = currentCount;
                    }
                    currentCount = 1;
                }

            }

            Console.WriteLine(bestCount);
        }
    }
