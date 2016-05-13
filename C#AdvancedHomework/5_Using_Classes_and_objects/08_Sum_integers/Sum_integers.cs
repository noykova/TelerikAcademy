/*Description
You are given a sequence of positive integer values written into a string, separated by spaces. 
 * Write a function that reads these values from given string and calculates their sum. 
 * Write a program that reads a string of positive integers separated by spaces and prints their sum.
Input
•	On the only line you will receive a string consisted of positive integers
Output
•	Print the sum of the integers

 * BGCoder - 100/100
 */
using System;
using System.Linq;


class Sum_integers
    {
        static void Main()
        {
            string str = Console.ReadLine();
           long result =  ReadIntsAndCalculateSum(str);
            Console.WriteLine(result);


        }

        public static long ReadIntsAndCalculateSum(string str)
        {
            int[] numbers = str.Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum+numbers[i];
            }

            return sum;
        }
    }
