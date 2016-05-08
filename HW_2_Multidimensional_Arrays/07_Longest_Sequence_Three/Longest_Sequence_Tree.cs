/*reshenie ot foruma na Telerik - 90/100*/

using System;

class Longest_Sequence_Tree
{
    private static int[,] matrix;
    private static bool[,] visited;

    private static int currentNumberOfConnectedEqualElements = 0;
    private static int numberOfConnectedEqualElements = 0;

    static void Main(string[] args)
    {
        matrix = ReadMatrixFromConsole();
        visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                currentNumberOfConnectedEqualElements = 0;

                if (!visited[row, col])
                {
                    CountRepetitionsOfElement(row, col, matrix[row, col]);

                    if (currentNumberOfConnectedEqualElements > numberOfConnectedEqualElements)
                    {
                        numberOfConnectedEqualElements = currentNumberOfConnectedEqualElements;
                    }
                }
            }
        }


        Console.WriteLine(numberOfConnectedEqualElements);
    }

    private static void CountRepetitionsOfElement(int row, int col, int currentValue)
    {


        if (!InRange(row, col))
        {
            // We are out of the labyrinth -> can't find a path
            return;
        }


        if (matrix[row, col] != currentValue)
        {
            return;
        }

        //avoid loop
        if (matrix[row, col] == int.MinValue)
        {
            return;
        }

        if (visited[row, col])
        {
            return;
        }

        // Temporary mark the current cell as visited and assign int.MinValue to avoid loop
        //int store = matrix[row, col];
        matrix[row, col] = int.MinValue;

        visited[row, col] = true;
        currentNumberOfConnectedEqualElements++;

        // Invoke recursion the explore all possible directions
        CountRepetitionsOfElement(row, col - 1, currentValue); // left            
        CountRepetitionsOfElement(row - 1, col, currentValue); // up
        CountRepetitionsOfElement(row, col + 1, currentValue); // right
        CountRepetitionsOfElement(row + 1, col, currentValue); // down

        // Mark back the current cell as free
       // matrix[row, col] = store;

    }

    private static int[,] ReadMatrixFromConsole()
    {
        string[] rowsAndColsAsString = Console.ReadLine().Split(' ');
        int rows = int.Parse(rowsAndColsAsString[0]);
        int cols = int.Parse(rowsAndColsAsString[1]);
        int[,] graph = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            string[] colsValues = Console.ReadLine().Split(' ');
            for (int j = 0; j < cols; j++)
            {
                int col = int.Parse(colsValues[j]);
                graph[i, j] = col;
            }
        }
        return graph;
    }

    private static bool InRange(int row, int col)
    {
        bool rowInRange = row >= 0 && row < matrix.GetLength(0);
        bool colInRange = col >= 0 && col < matrix.GetLength(1);
        return rowInRange && colInRange;
    }

}


