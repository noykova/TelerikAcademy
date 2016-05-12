/*Description
Write a method GetMax() with two parameters that returns the larger of two integers. 
 * Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
Input
•	On the first line you will receive 3 integers separated by spaces
Output
•	Print the largest of them
*/

using System;
using System.Linq;


    class Get_largest_number
    {
        static void Main()
        {
            int [] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max1 = GetMax(numbers[0], numbers[1]);
            int max = GetMax(max1, numbers[2]);
            Console.WriteLine(max);
        }

        public static int GetMax(int num1, int num2)
        {
            int max = num1;

            if (num2>num1)
            {
                max = num2;
            }

            return max;
        }
    }

