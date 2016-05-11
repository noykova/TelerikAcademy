/*Description
Write a method that multiplies a number represented as an array of digits by a given integer number. 
 * Write a program to calculate N!.
Input
•	On the first line you will receive the number N
Output
•	Print N!
*/

using System;
using System.Numerics;


class N_Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(factorial(n));

    }

    public static BigInteger factorial(int n)
    {
        if (n == 0)
            return 1;
        if (n < 0)
            return 0;

        return n * factorial(n - 1);
    }
}


