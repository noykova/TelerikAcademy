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

/*Improved solution from Petya Kostova: 80/100*/

using System;
using System.Linq;

class Largest_area_in_matrix
{
    private static int answer = 0;
    private static int absolutemax = 0;

   public static void Main()
    {
        // Read the matrix dimensions
        int[] dim = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int dimN = dim[0];
        int dimM = dim[1];
        int[] columns = new int[dimM];

        // Define the matrix
        int[,] matrix = new int[dimN, dimM];

        //According DFS algorithm (https://www.youtube.com/watch?v=iaBEKo5sM7w) 
        //we have to mark all visited elements like isVisited - define a matrix isVisited
        //all values in the beginning == false
        bool[,] isVisited = new bool[dimN, dimM];

        // Enter the matrix elements
        for (int row = 0; row < dimN; row++)
        {
            columns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < dimM; i++)
            {
                matrix[row, i] = columns[i];
            }
        }

        //apply the method FindTheArea inside the matrix, for every element [i,j]
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                answer = 0;
                FindTheArea(i, j, matrix[i, j], matrix, isVisited);

            }
        }
        Console.WriteLine(absolutemax);

    }

    private static void FindTheArea(int i, int j, int currelement, int[,] matrix, bool[,] isVisited)
    {
        //returns if we are out of the matrix 
        if (!InRange(i, j, matrix))
        {
            return;
        }

        //to avoid loop
        if (currelement == int.MinValue)
        {
            return;
        }

        //returns if we have already visited this element
        if (isVisited[i, j])
        {
            return;
        }

        //returns if the element[i,j] is not the same
        if (matrix[i, j] != currelement)
        {
            return;
        }


            // Temporary mark the current cell as visited to avoid cycles
            int store = matrix[i,j];
            matrix[i, j] = int.MinValue;

            isVisited[i,j]= true;

            answer++;

            if (absolutemax < answer)
            {
                absolutemax = answer;
            }

            //recursive call for all neighbour elements
            FindTheArea(i + 1, j, store, matrix, isVisited);//down

            FindTheArea(i - 1, j, store, matrix, isVisited);//up

            FindTheArea(i, j + 1, store, matrix, isVisited);//right

            FindTheArea(i, j - 1, store, matrix, isVisited);//left

            matrix[i, j] = store;

        }

    private static bool InRange(int row, int col, int [,] matrix)
    {
        bool rowInRange = row >= 0 && row < matrix.GetLength(0);
        bool colInRange = col >= 0 && col < matrix.GetLength(1);
        return rowInRange && colInRange;
    }


    }
   




