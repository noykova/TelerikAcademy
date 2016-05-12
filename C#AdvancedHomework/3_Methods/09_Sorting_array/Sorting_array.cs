/*Description
Write a method that returns the maximal element in a portion of array of integers starting at given index. 
 * Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.
Input
•	On the first line you will receive the number N - the size of the array
•	On the second line you will receive N numbers separated by spaces - the array
Output
•	Print the sorted array 
o	Elements must be separated by spaces
*/

using System;
using System.Collections.Generic;
using System.Linq;

 public class Sorting_array
    {
       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           List<int> arrToList = arr.ToList();

           int[] resultArr = SortedArray(arr);

           Console.WriteLine(String.Join(" ", resultArr.Reverse()));



        }

     public static int FindMax(int index, List<int> arrToList)
     {
         int max = arrToList[index];
         for (int i = arrToList.Count-1; i >= (index+1); i--)
         {
             if (max<arrToList[i])
             {
                 max = arrToList[i];
             }
         }
         return max;
     }

     public static int[] SortedArray(int[] arr)
     {
         List<int> tmp = arr.ToList();
         int [] sortedArr = new int[arr.Length];
         for (int j = 0; j < arr.Length - 2; j++)
         {
             int max = Int32.MinValue;
             sortedArr[j] = FindMax(0, tmp);

             tmp.Remove(sortedArr[j]);
         }

         if (tmp[1] > tmp[0])
         {
             sortedArr[arr.Length - 2] = tmp[1];
             sortedArr[arr.Length - 1] = tmp[0];

         }
         else
         {
             sortedArr[arr.Length - 2] = tmp[0];
             sortedArr[arr.Length - 1] = tmp[1];

         }
         return sortedArr;
     }

    }

