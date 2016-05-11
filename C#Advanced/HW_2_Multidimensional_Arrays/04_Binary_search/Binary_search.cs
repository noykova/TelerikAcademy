/*Write a program, that reads from the console an array of N integers 
 * and an integer K, 
 * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. */

using System;

    class Binary_search
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int k = int.Parse(Console.ReadLine());

            Array.Sort(arr);

            // Array.BinarySearch(arr, element) - gets the index of element k in arr
            int index = Array.BinarySearch(arr, k);
            
            //find the largest number in the array which is ≤ K.
            if (index >= 0)
            {
                Console.WriteLine(arr[k - 1]);
            }
            else
            {
                int result = arr[0];
                for (int i = 1; i < n; i++)
                {
                    if (arr[i-1] < k && arr[i]>k)
                    {
                        Console.WriteLine(arr[i-1]);
                        break;
                    }
                }
            }

        }
    }

