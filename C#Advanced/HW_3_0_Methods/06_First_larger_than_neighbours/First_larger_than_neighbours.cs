/*Description
Write a method that returns the index of the first element in array that is larger than its neighbours, 
 * or -1, if there is no such element.
Input
•	On the first line you will receive the number N - the size of the array
•	On the second line you will receive N numbers sepated by spaces - the array
Output
•	Print the index of the first element that is larger than its neighbours or -1 if none are
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class First_larger_than_neighbours
    {
        static void Main()
        {
            int dim = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int result = 0;

            //check all elements without firts and the last, who do not have 2 neighbours. 
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (IsLargerThanNeighbours(arr, i))
                {
                    result++;
                    //Console.WriteLine(arr[i]);
                }
            }
            Console.WriteLine(result);

        }

        //compare the element arr[i] with its tw neighbours arr[i-1] and arr[i+1]
        static bool IsLargerThanNeighbours(int[] numbers, int i)
        {
            bool IsLarger = (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]);
            return IsLarger;

        }
    }
