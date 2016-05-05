/* This program allocates array of 20 integers and initializes each element by its index multiplied by 5. 
 The obtained array is printed on the console.
 */

using System;

    class Allocate_Array
    {
        static void Main()
        {
            //0<n<20
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }
        }
    }

