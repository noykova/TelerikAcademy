/*Description
Write a program that sorts an array of integers using the Merge sort algorithm.
Input
•	On the first line you will receive the number N
•	On the next N lines the numbers of the array will be given
Output
•	Print the sorted array 
o	Each number should be on a new line
Constraints
•	1 <= N <= 1024
•	Time limit: 0.1s
•	Memory limit: 16MB
 * 
 * recursive algorithm, 
 * taken from: http://www.java2s.com/Code/CSharp/Collections-Data-Structure/Implementstherecursivemergesortalgorithmtosortanarray.htm 
*/

using System;

class Merge_sort
{
    public static void Sort(int[] data, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            Sort(data, left, middle);
            Sort(data, middle + 1, right);
            Merge(data, left, middle, middle + 1, right);
        }
    }
    public static void Merge(int[] data, int left, int middle, int middle1, int right)
    {
        int oldPosition = left;
        int size = right - left + 1;
        int[] temp = new int[size];
        int i = 0;

        while (left <= middle && middle1 <= right)
        {
            if (data[left] <= data[middle1])
                temp[i++] = data[left++];
            else
                temp[i++] = data[middle1++];
        }
        if (left > middle)
            for (int j = middle1; j <= right; j++)
                temp[i++] = data[middle1++];
        else
            for (int j = left; j <= middle; j++)
                temp[i++] = data[left++];
        Array.Copy(temp, 0, data, oldPosition, size);
    }

    static void Main()
    {
        // Console.WriteLine("int n=  ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        //Enter all n elements of arr[i]
        for (int i = 0; i < n; i++)
        {
            //Console.Write("Array[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Sort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }

