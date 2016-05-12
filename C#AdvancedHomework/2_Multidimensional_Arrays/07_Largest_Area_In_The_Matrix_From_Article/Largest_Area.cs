/*Description
Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
Input
•	On the first line you will receive the numbers N and M separated by a single space
•	On the next N lines there will be M numbers separated with spaces - the elements of the matrix
Output
•	Print the size of the lasrgest area of equal neighbour elements
Constraints
•	3 <= N, M <= 1024
•	Time limit: 0.1s
•	Memory limit: 16MB
 * Sample tests
Input	        Output
5 6
1 3 2 2 2 4
3 3 3 2 4 4
4 3 1 2 3 3
4 3 1 3 3 1
4 3 3 3 1 1	        13 - number of 3's. 
Hint: you can use the algorithm Depth-first search or Breadth-first search.

*/

/*Solution from the net: 100/100, https://blogittech.wordpress.com/2013/01/26/59/ */

using System;
using System.Linq;

    class Largest_Area
    {

    public static void Main(string[] args)
    {
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


        bool[,] isVisited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
        int bestCount = 0;
        //int indexRow = 0;
        //int indexCol = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (!isVisited[row, col])
                {
                    int count = DepthFirstSearch(matrix, row, col, isVisited);
                    if (bestCount < count)
                    {
                        bestCount = count;
                        //indexRow = row;
                        //indexCol = col;
                    }
                }
 
            }
        }
        //Console.WriteLine("The len of largest area in matrix is {0}", bestCount);
        //Console.WriteLine("The element is {2} on position {0},{1} ", indexRow, indexCol, array[indexRow, indexCol]);
        Console.WriteLine(bestCount);
    }
 
    static int DepthFirstSearch(int[,] matrix, int row, int col, bool[,] isVisited)
    {
        int result = 1;
        isVisited[row, col] = true;
        if ((row - 1 >= 0) && (matrix[row - 1, col] == matrix[row, col]) && !isVisited[row - 1, col])
        {
            result += DepthFirstSearch(matrix, row - 1, col, isVisited);
        }
        if ((row + 1 < matrix.GetLength(0)) && (matrix[row + 1, col] == matrix[row, col]) && !isVisited[row + 1, col])
        {
            result += DepthFirstSearch(matrix, row + 1, col, isVisited);
        }
        if ((col - 1 >= 0) && (matrix[row, col - 1] == matrix[row, col]) && !isVisited[row, col - 1])
        {
            result += DepthFirstSearch(matrix, row, col - 1, isVisited);
        }
        if ((col + 1 < matrix.GetLength(1)) && (matrix[row, col + 1] == matrix[row, col]) && !isVisited[row, col + 1])
        {
            result += DepthFirstSearch(matrix, row, col + 1, isVisited);
        }
        return result;
    }
}

