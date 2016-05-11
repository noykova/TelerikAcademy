/* Description
We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several neighbour elements located on the same line, 
 * column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix and prints its length.
Input
•	On the first line you will receive the numbers N and M separated by a single space
•	On the next N lines there will be M strings separated with spaces - the strings in the matrix
Output
•	Print the length of the longest sequence of equal equal strings in the matrix
Constraints
•	3 <= N, M <= 128
•	Time limit: 0.1s
•	Memory limit: 16MB
*/

using System;
using System.Linq;

class Sequence_in_matrix_from_net
{
    // directions = 
    //d(0,0) = 0; d(0,1) = 1
    //d(1,0) = 1; d(1,1) = 1
    //d(2,0) = -1; d(2,1) = 1;
    //d(3,0) = 1; d(3,1) = 0
    static readonly int[,] directions = { { 0, 1 }, { 1, 1 }, { -1, 1 }, { 1, 0 } };

    static void Main()
    {
        // Read the matrix dimensions
        int[] dim = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = dim[0];
        int cols = dim[1];
        string[] columns = new string[cols];

        // Define the matrix
        string[,] matrix = new string[rows, cols];

        // Enter the matrix elements
        for (int row = 0; row < rows; row++)
        {
            columns = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < cols; i++)
            {
                matrix[row, i] = columns[i];
            }
        }


        // Print the matrix on the console
        //Console.WriteLine("\nThe matrix is as follows:");
        //PrintingMatrix(matrix);


        // Find the longest sequence of equal strings in the matrix
        int bestLength = 0;
        string bestElement = string.Empty;
        FindLongestSequence(matrix, ref bestElement, ref bestLength);


        // Print the result 
        //Console.WriteLine("\nThe longest sequence of equal strings in the matrix is:");
        //Console.WriteLine(string.Join(", ", Enumerable.Repeat(bestElement, bestLength)));
        Console.WriteLine(bestLength);

    }


    static void FindLongestSequence(string[,] matrix, ref string bestElement, ref int bestLength)
    {
        for (int row = 0; row < matrix.GetLongLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1); col++)
            {
                int direction = -1;

                while (++direction < 4)
                {
                    //row = row+(0,1,-1,1)
                    int currRow = row + directions[direction, 0];

                    //col = col+(1,0)
                    int currCol = col + directions[direction, 1];
                    int currentLength = 1;

                    while (IsTraversable(matrix, row, col, currRow, currCol))
                    {
                        currentLength++;

                        if (currentLength > bestLength)
                        {
                            bestLength = currentLength;
                            bestElement = matrix[row, col];
                        }

                        currRow += directions[direction, 0];
                        currCol += directions[direction, 1];
                    }
                }
            }
        }
    }
    //Дали елементът е в матрицата или индексите са извън нея

    static bool IsTraversable(string[,] matrix, int row, int col, int currRow, int currCol)
    {
        return currRow >= 0 && currRow < matrix.GetLongLength(0) &&
        currCol >= 0 && currCol < matrix.GetLongLength(1) &&
        matrix[currRow, currCol] == matrix[row, col];
    }

    // Print the matrix on the console
    //private static void PrintingMatrix(string[,] matrix)
    //{

    //for (int row = 0; row < matrix.GetLength(0); row++) // rows = matrix.GetLength(0)
    //{
    //for (int col = 0; col < matrix.GetLength(1); col++) // cols = matrix.GetLength(1)
    //{
    //Console.Write("{0,-5} ", matrix[row, col]); // left aligned
    //Console.Write("{0,5} ", matrix[row, col]); // right aligned
    //}
    //Console.WriteLine();
}

