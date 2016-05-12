/*Description
Write a method that checks if the element at given position in given array of integers 
 * is larger than its two neighbours (when such exist). 
 * Write program that reads an array of numbers and prints how many of them are larger than their neighbours.
Input
•	On the first line you will receive the number N - the size of the array
•	On the second line you will receive N numbers separated by spaces - the array
Output
•	Print how many numbers in the array are larger than their neighbours
*/

using System;
using System.Linq;
using System.Threading;

class Larger_than_neighbours
    {
        static void Main()
        {
            int dim = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                Console.WriteLine(IndexOfFirstLargerThanNeighbours(arr));
        }

        //compare the element arr[i] with its neighbours arr[i-1] and arr[i+1]
        public static int IndexOfFirstLargerThanNeighbours(int[] arr)
        {
            //counter of larger elements        
            for (int i = 1; i < arr.Length - 1; i++)
            {
                
                bool isLarger = (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]);

                if (isLarger)
                {
                    return i;
                }
            }
                return -1;
            }

        }

