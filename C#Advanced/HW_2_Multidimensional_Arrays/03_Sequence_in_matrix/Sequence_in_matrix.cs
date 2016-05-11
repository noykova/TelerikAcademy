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

   class Sequence_in_matrix
    {
        static void Main()
        {
            // Read the matrix dimensions
            int[] dim = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int dimN = dim[0];
            int dimM = dim[1];
            string[] columns = new string[dimM];

            // Define the matrix
            string [,] matrix = new string[dimN, dimM];

            // Enter the matrix elements
            for (int row = 0; row < dimN; row++)
            {
                columns = Console.ReadLine().Split(' ').ToArray();
                for (int i = 0; i < dimM; i++)
                {
                    matrix[row, i] = columns[i];
                }
            }


            // Find the maximal sequence of diagonal elements  
            bool flag = false;
            //number of equal elements
            int kd = 1;
            //index of the beginning of the repeating sequence
            int id = 0;
            int maxKd = 0;
            int maxId = 0;

            int rows = matrix.GetLength(0); //dimension of rows
            int cols = matrix.GetLength(1); //dimension of cols

            int minDim = rows;
            if (minDim < rows)
            {
                minDim = cols;
            }

            for (int i = 0; i < minDim - 1; i++)
            {
                if (matrix[i, i] == matrix[i + 1, i + 1] && flag == false)
                {
                    kd = kd + 1;
                    id = i;
                    flag = true;
                    continue;
                }

                if (matrix[i, i] == matrix[i + 1, i + 1] && flag == true && (i + 1) != (minDim - 1))
                {
                    kd = kd + 1;
                    continue;
                }

                if (matrix[i, i] != matrix[i + 1, i + 1] && flag == true ||
                    (matrix[i, i] == matrix[i + 1, i + 1] && flag == true && (i + 1) == (minDim - 1)))
                {
                    kd = kd + 1;
                    flag = false;

                    if (kd > maxKd)
                    {
                        maxKd = kd;
                        maxId = id;
                    }

                    kd = 0;
                    id = 0;
                }

            }



            //find the maximal sequence in columns
            bool flag1 = false;
            int kc = 1;
            int ic = 0;
            int jc = 0;
            int maxKc = 0;
            int maxIc = 0;
            int maxJc = 0;


            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    {
                        if (matrix[i, j] == matrix[i + 1, j] && flag1 == false)
                        {
                            kc = kc + 1;
                            ic = i;
                            jc = j;
                            flag1 = true;
                            continue;
                        }

                        if (matrix[i, j] == matrix[i + 1, j] && flag1 == true && (i + 1) != (rows - 1))
                        {
                            kc = kc + 1;
                            continue;
                        }

                        if (matrix[i, j] != matrix[i + 1, j] && flag1 == true ||
                            (matrix[i, j] == matrix[i + 1, j] && flag1 == true && (i + 1) == (rows - 1)))
                        {
                            kc = kc + 1;
                            flag1 = false;

                            if (kc > maxKc)
                            {
                                maxKc = kc;
                                maxIc = ic;
                                maxJc = jc;
                            }

                            kc = 0;
                            ic = 0;
                            jc = 0;
                        }
                    }
                }
            }

            //find the maximal sequence in rows
            bool flag2 = false;
            int kr = 1;
            int ir = 0;
            int jr = 0;
            int maxKr = 0;
            int maxIr = 0;
            int maxJr = 0;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    {
                        if (matrix[i, j] == matrix[i, j + 1] && flag2 == false)
                        {
                            kr = kr + 1;
                            ir = i;
                            jr = j;
                            flag2 = true;
                            continue;
                        }

                        if (matrix[i, j] == matrix[i, j + 1] && flag2 == true && (j + 1) != (cols - 1))
                        {
                            kr = kr + 1;
                            continue;
                        }

                        if (matrix[i, j] != matrix[i, j + 1] && flag2 == true ||
                            (matrix[i, j] == matrix[i, j + 1] && flag2 == true && (j + 1) == (cols - 1)))
                        {
                            kr = kr + 1;
                            flag2 = false;

                            if (kr > maxKr)
                            {
                                maxKr = kr;
                                maxIr = ir;
                                maxJr = jr;
                            }

                            kr = 0;
                            ir = 0;
                            jr = 0;
                        }
                    }
                }
            }

            //Console.WriteLine();

            //find the maximal secuence between maximal sequence in diagonal, columns and rows

            int c = 0;

            if (maxKd > maxKc && maxKd > maxKr)
            {
                c = 1;
            }

            if (maxKc > maxKd && maxKc > maxKr)
            {
                c = 2;
            }

            if (maxKr > maxKd && maxKr > maxKc)
            {
                c = 3;
            }


            switch (c)
            {
                case 1:
                    {
                        Console.WriteLine(maxKd);
                        //string[] array = new string[maxKd];
                        //for (int i = maxId; i < maxKd; i++)
                        //{
                        //    array[i] = matrix[i, i];
                        //}
                        //Console.WriteLine(string.Join(", ", array));
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine(maxKc);
                        //string[] array = new string[maxKc];
                        //for (int i = maxIc; i < maxKc; i++)
                        //{
                        //    array[i] = matrix[i, maxJc];
                        //}
                        //Console.WriteLine(string.Join(", ", array));
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine(maxKr);
                        //string[] array = new string[maxKr];
                        //for (int j = maxJr; j < maxKr; j++)
                        //{
                        //    array[j] = matrix[maxIr, j];
                        //}
                        //Console.WriteLine(string.Join(", ", array));
                    }
                    break;
                default:
                    Console.WriteLine("There is no such a sequence.");
                    break;

            }


        }
    }

