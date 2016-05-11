/*Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
Input
•	On the first line you will receive the number N
•	On the next N lines the numbers of the array will be given
•	On the last line you will receive the number X
Output
•	Print the index where X is in the array 
o	If there is more than one occurence print the first one
o	If there are no occurences print -1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Binary_search
    {
        static void Main()
        {
            //Console.WriteLine("int n=  ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            //Enter all n elements of arr[i]
             for (int i = 0; i < n; i++)
            {
              //Console.Write("Array[{0}] = ", i);
              arr[i] = int.Parse(Console.ReadLine());

            }

            //enter the given element X
            int x = int.Parse(Console.ReadLine());
            
            //There is a Binary search in Array class:
            //int index = Array.BinarySearch(mynumbers, target);
            //if target does not exist, the method returns negative value

            /*But: Duplicate elements are allowed. 
             * If the Array contains more than one element equal to value, 
             * the method returns the index of only one of the occurrences, 
             * and not necessarily the first one.*/

            int index = Array.BinarySearch(arr, x);

            if (index < 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }

