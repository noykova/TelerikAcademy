/*Modify your last program and try to make it work for any number type, 
 * not just integer (e.g. decimal, float, byte, etc.) 
 * Use generic method (read in Internet about generic methods in C#).*/

using System;
using System.Linq;


    class Number_calculations
    {
        static void Main()
        {
            //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double[] numbers1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
           // decimal[] numbers2 = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            //int
            //Console.WriteLine(MinNumbers(numbers));
            //Console.WriteLine(MaxNumbers(numbers));
            //Console.WriteLine("{0:F2}", AverageNumbers(numbers));
            //Console.WriteLine(SumNumbers(numbers));
            //Console.WriteLine(ProductNumbers(numbers));

            //double
            Console.WriteLine(MinNumbers(numbers1));
            Console.WriteLine(MaxNumbers(numbers1));
            Console.WriteLine("{0:F2}", AverageNumbers(numbers1));
            Console.WriteLine(SumNumbers(numbers1));
            Console.WriteLine(ProductNumbers(numbers1));

            ////decimal
            //Console.WriteLine(MinNumbers(numbers2));
            //Console.WriteLine(MaxNumbers(numbers2));
            //Console.WriteLine("{0:F2}", AverageNumbers(numbers2));
            //Console.WriteLine(SumNumbers(numbers2));
            //Console.WriteLine(ProductNumbers(numbers2));
        }

        //denote variable number of parameters by keyword params
        public static T MinNumbers<T>(params T[] numbers) 
        {
            return numbers.Min();
        }

        public static T MaxNumbers<T>(params T[] numbers)
        {
            return numbers.Max();
        }

        public static T AverageNumbers<T>(params T[] numbers)
        {
            dynamic sum = 0.00;
            foreach (var element in numbers)
            {
                sum += element;
            }

            return sum/numbers.Length;
            // return sum/(double)numbers.Length;
        }

        public static T SumNumbers<T>(params T[] numbers)
        {
            dynamic sum = 0;
            foreach (var element in numbers)
            {
                sum += element;
            }
           
            return sum;
        }

        public static T ProductNumbers<T>(params T[] numbers)
        {
            dynamic product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product = product * numbers[i];
            }

            return product;
        }
    }

