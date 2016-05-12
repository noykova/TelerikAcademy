/*Description
Write a method that adds two polynomials. 
 * Represent them as arrays of their coefficients. 
 * Write a program that reads two polynomials and prints their sum (of polynomial coeffisients)).
Input
•	On the first line you will receive the number N
•	On the second line you will receive the first polynomial as coefficients separated by spaces
•	On the third line you will receive the second polynomial as coefficients separated by spaces
Output
•	Print the sum of the polynomials
*/

using System;
using System.Linq;


 public class Adding_polynomials
    {
       public static void Main()
        {
            int dim = int.Parse(Console.ReadLine());
            int[] coefPol1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] coefPol2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] result = SumCoeff(coefPol1, coefPol2);
     
            Console.WriteLine(String.Join(" ", result));
        }

     public static int[] SumCoeff(int[] coefPol1, int[] coefPol2)
     {
         int[] result = new int[coefPol1.Length];

         for (int i = 0; i < coefPol1.Length; i++)
         {
             result[i] = coefPol1[i] + coefPol2[i];
         }

         return result;
     }

    }

