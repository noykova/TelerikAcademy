/*Description
Write a program that reads a rectangular matrix of size N x M and finds in 
 * it the square 3 x 3 that has maximal sum of its elements. Print that sum.
Input
•	On the first line you will receive the numbers N and M separated by a single space
•	On the next N lines there will be M numbers separated with spaces - the elements of the matrix
Output
•	Print the maximal sum of 3 x 3 square
Constraints
•	3 <= N, M <= 1024
•	Numbers in the matrix will be in the interval [ -1000, 1000 ]
•	Time limit: 0.1s
•	Memory limit: 16MB
*/

using System;
using System.Linq;


class Maximal_sum
{
    static void Main()
    {
    Start:
        // Read the matrix dimensions
        int[] dim = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int dimN = dim[0];
        int dimM = dim[1];
        int[] columns = new int[dimM];

        // Define the matrix
        int[,] matrix = new int[dimN, dimM];

        // Enter the matrix elements
        for (int row = 0; row < dimN; row++)
        {
            columns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < dimM; i++)
            {
                matrix[row, i] = columns[i];
            }
        }


        // Find the maximal sum platform of size 3 x 3
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // Print the result
        Console.WriteLine(bestSum);
        //Console.WriteLine("The best platform is:");
        //Console.WriteLine("  {0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        //Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        //Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);




        Console.WriteLine("If you want to run the program again, press y:");
        if (Console.ReadLine() == "y") goto Start;



    }
}
