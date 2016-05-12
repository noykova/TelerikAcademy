/*Quicksort algorithm: https://en.wikipedia.org/wiki/Quicksort 
 * Write a program that sorts an array of integers using the Quick sort algorithm.
Input
•	On the first line you will receive the number N
•	On the next N lines the numbers of the array will be given
Output
•	Print the sorted array 
o	Each number should be on a new line

 * I took the impmelentation from here: http://snipd.net/quicksort-in-c
 * 
 */

using System;

class Quick_sort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] unsorted = new int[n];

        // enter the unsorted array of int elements
        for (int i = 0; i < n; i++)
        {
            unsorted[i] = int.Parse(Console.ReadLine());
        }


        // Sort the array
        Quicksort(unsorted, 0, unsorted.Length - 1);

        // Print the sorted array
        foreach (int t in unsorted)
        {
            Console.WriteLine(t);
        }

    }

    public static void Quicksort(int[] elements, int left, int right)
    {
        int i = left, j = right;
        int pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                // Swap
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        // Recursive calls
        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }

}
