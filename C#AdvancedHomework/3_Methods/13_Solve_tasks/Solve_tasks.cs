/*Description
Write a program that can solve these tasks:
•	Reverses the digits of a number
•	Calculates the average of a sequence of integers
•	Solves a linear equation a * x + b = 0
Create appropriate methods.
•	Provide a simple text-based menu for the user to choose which task to solve.
•	Validate the input data: 
o	The decimal number should be non-negative
o	The sequence should not be empty
o	a should not be equal to 0
*/

using System;
using System.Linq;

namespace _13_Solve_tasks
{
    class Solve_tasks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the task to solve:");
            Console.WriteLine("To reverse the digits of a number: press 1");
            Console.WriteLine("To calculate the average of a sequence of integers: press 2");
            Console.WriteLine("To solve a linear equation a * x + b = 0: press 3");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ReverseDigits();
                    break; 
                case 2:
                    IntsAverage();
                    break;
                case 3:
                    SolveLinearEquation();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }

        public static void ReverseDigits()
        {
            Console.WriteLine("Enter the number:");
            char []  chars = Console.ReadLine().ToCharArray();
            char[] chars1 = new char[chars.Length];
            string strResult = "";

            for (int i = 0; i < chars.Length; i++)
            {
                chars1[i] = chars[chars.Length - 1 - i];
                strResult = strResult + chars1[i];
            }

            double doubleRes = double.Parse(strResult);

            Console.WriteLine(doubleRes);
        }

        public static void IntsAverage()
        {
            Console.WriteLine("Enter all integer numbers on one line separated by space:");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("the average of all numbers is: {0:F2}",numbers.Average());
        }

        public static void SolveLinearEquation()
        {
            Console.WriteLine("Enter the coefficients of the equation a*x+b=0 on one line separated by space: a b");
            int[] coefs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("The result is x = {0:F2}", -coefs[0]/(double)coefs[1]);
        }
    }
}
