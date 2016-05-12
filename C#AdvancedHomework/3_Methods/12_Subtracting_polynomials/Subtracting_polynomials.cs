/*Extend the previous program to support also subtraction and multiplication of polynomials.*/
using System;
using System.Linq;


    class Subtracting_polynomials
    {
        public static void Main()
        {
            int dim = int.Parse(Console.ReadLine());
            int[] coefPol1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] coefPol2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] result = SubstractCoeff(coefPol1, coefPol2);

            Console.WriteLine(String.Join(" ", result));
        }

        public static int[] SubstractCoeff(int[] coefPol1, int[] coefPol2)
        {
            int[] result = new int[coefPol1.Length];

            for (int i = 0; i < coefPol1.Length; i++)
            {
                result[i] = coefPol1[i] - coefPol2[i];
            }

            return result;
        }

    }
