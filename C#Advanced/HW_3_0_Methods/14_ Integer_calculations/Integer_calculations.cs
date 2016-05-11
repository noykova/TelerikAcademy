/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
 * Use variable number of arguments. 
 * Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.
Input
•	On the first line you will receive 5 numbers separated by spaces
Output
•	Print their minimum, maximum, average, sum and product 
o	Each on a new line
o	The average value should be printed with two digits of precision
 */


using System;
using System.Linq;
using System.Numerics;

    class Integer_calculations
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(MinNumbers(numbers));
            Console.WriteLine(MaxNumbers(numbers));
            Console.WriteLine("{0:F2}",AverageNumbers(numbers));
            Console.WriteLine(SumNumbers(numbers));
            Console.WriteLine(ProductNumbers(numbers));
        }

        //denote variable number of parameters by keyword params
        public static int MinNumbers(params int[] numbers)
        {
            return numbers.Min();
        }

        public static int MaxNumbers(params int[] numbers)
        {
            return numbers.Max();
        }

        public static double AverageNumbers(params int[] numbers)
        {
            return numbers.Average();
        }

        public static int SumNumbers(params int[] numbers)
        {
            return numbers.Sum();
        }

        public static BigInteger ProductNumbers(params int[] numbers)
        {
            BigInteger product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {           
                product = product * numbers[i];
            }

            return product;        
        }

    }
