/*Write a program that generates and prints to the console 10 random values in the range [100, 200].*/

using System;

    class Random_numbers
    {
        static void Main()
        {
            Random randomGenerator = new Random();

            //range: [100,200]
            int[] numbersArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                    //The maxValue for the upper-bound in the Next() method 
                    //is exclusive—the range includes minValue, maxValue-1, and all numbers in between.
                numbersArray[i] = randomGenerator.Next(100, 201);
                Console.Write("{0} ", numbersArray[i]);
            }
            Console.WriteLine();

        }
    }
