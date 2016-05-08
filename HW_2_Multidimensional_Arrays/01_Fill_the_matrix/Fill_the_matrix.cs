/*Description
Write a program that fills and prints a matrix of size (n, n) as shown below.
Input
•	On the first line you will receive the number N
•	On the second line you will receive a character (a, b, c, d*) which determines how to fill the matrix
Output
•	Print the matrix 
o	Numbers on a row must be separated by a single spacebar
o	Each row must be on a new line
Constraints
•	1 <= N <= 128
•	Time limit: 0.1s
•	Memory limit: 16MB
*/

using System;

    class Fill_the_matrix
    {
        static void Main()
        {
            // Start:
            //I have used mainly demo code during the lecture

            // Read the matrix dimensions
            //Console.Write("Number of rows and columns of m(NxN), N = ");
            int dimN = int.Parse(Console.ReadLine());

            // Allocate the matrix
            int[,] matrix = new int[dimN, dimN];

            //choose the pattern
            char letter = char.Parse(Console.ReadLine());

            if (letter == 'a')
            {

                //set the first element of the matrix = 1
                int sum = 0;

                // Enter the matrix elements
                for (int col = 0; col < dimN; col++)
                {
                    for (int row = 0; row < dimN; row++)
                    {
                        matrix[row, col] = sum + 1;
                        sum = sum + 1;
                    }
                }

                // Print the matrix on the console
                for (int row = 0; row < dimN; row++)
                {
                    for (int col = 0; col < dimN; col++)
                    {
                        if (col != dimN - 1)
                        {
                            Console.Write("{0} ", String.Join(" ", matrix[row, col].ToString()));
                        }
                        else
                        {
                            Console.Write("{0}", String.Join(" ", matrix[row, col].ToString()));

                        }
                    }
                    Console.WriteLine();
                }
            }

            if (letter == 'b')
            {

                //set the first element of the matrix = 1
                int sum = 0;

                // Enter the matrix elements
                for (int col = 0; col < dimN; col++)
                {

                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < dimN; row++)
                        {
                            matrix[row, col] = sum + 1;
                            sum = sum + 1;
                        }

                    }

                    else
                    {
                        for (int row = dimN - 1; row >= 0; row--)
                        {
                            matrix[row, col] = sum + 1;
                            sum++;
                        }
                    }
                }

                // Print the matrix on the console
                for (int row = 0; row < dimN; row++)
                {
                    for (int col = 0; col < dimN; col++)
                    {
                        if (col != dimN - 1)
                        {
                            Console.Write("{0} ", String.Join(" ", matrix[row, col].ToString()));
                        }
                        else
                        {
                            Console.Write("{0}", String.Join(" ", matrix[row, col].ToString()));

                        }
                    }
                    Console.WriteLine();
                }

            }

            if (letter == 'c')
            {

                //set the first element of the matrix = 1
                int sum = 0;

                // Enter the matrix elements
                for (int k = 1; k <= dimN; k++)
                {
                    for (int col = 0; col < k; col++)
                    {
                        int row = dimN - (k - col);
                        matrix[row, col] = sum + 1;
                        sum++;
                    }
                }

                for (int k = dimN - 1; k > 0; k--)
                {
                    for (int col = 0; col < k; col++)
                    {
                        int row = dimN - (k - col);
                        matrix[col, row] = sum + 1;
                        sum++;
                    }
                }

                // Print the matrix on the console
                for (int row = 0; row < dimN; row++)
                {
                    for (int col = 0; col < dimN; col++)
                    {
                        if (col != dimN - 1)
                        {
                            Console.Write("{0} ", String.Join(" ", matrix[row, col].ToString()));
                        }
                        else
                        {
                            Console.Write("{0}", String.Join(" ", matrix[row, col].ToString()));

                        }
                    }
                    Console.WriteLine();
                }

            }


            if (letter == 'd')
            {
                //spiral matrix (SoftUni - C#_1_HW_7_Spiral_Matrix
                // I have used the code of Petya Kostova
                //set the first element of the matrix = 1
                int maxValue = dimN * dimN;

                int row = 0;
                int col = 0;
                string direction = "down";

                for (int i = 1; i <= maxValue; i++)
                {

                    // fill the current element

                    matrix[row, col] = i;


                    // go to the next element in this direction

                    if (direction == "right")
                    {
                        col++;
                    }

                    if (direction == "down")
                    {
                        row++;
                    }

                    if (direction == "left")
                    {
                        col--;
                    }

                    if (direction == "up")
                    {
                        row--;
                    }


                    // check for changing the direction

                    if (direction == "right" && (col > (dimN - 1) || matrix[row, col] != 0))
                    {
                        direction = "up";
                        row--;
                        col--;
                    }

                    if (direction == "down" && (row > (dimN - 1) || matrix[row, col] != 0))
                    {
                        direction = "right";
                        row--;
                        col++;
                    }

                    if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                    {
                        direction = "down";
                        row++;
                        col++;
                    }

                    if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                    {
                        direction = "left";
                        row++;
                        col--;
                    }

                }

                // Print the matrix on the console
                for (int r = 0; r < dimN; r++)
                {
                    for (int c = 0; c < dimN; c++)
                    {
                        if (c != dimN - 1)
                        {
                            Console.Write("{0} ", String.Join(" ", matrix[r, c].ToString()));
                        }
                        else
                        {
                            Console.Write("{0}", String.Join(" ", matrix[r, c].ToString()));

                        }
                    }
                    Console.WriteLine();
                }
            }

            //  Console.WriteLine("If you want to run the program again, press y:");
            //  if (Console.ReadLine() == "y") goto Start;



        }
    }

