/*  This program finds the most frequent number in an array of N elements.*/

using System;


    class Frequent_number
    {
        static void Main()
        {
            //Console.WriteLine("int n=  ");
            ushort n = ushort.Parse(Console.ReadLine());

            ushort[] arr = new ushort[n];

            //Enter all n elements of arr[i]
            for (ushort i = 0; i < n; i++)
            {
                //Console.Write("Array[{0}] = ", i);
                arr[i] = ushort.Parse(Console.ReadLine());

            } 

            //counters of equal elements
            ushort k = 0;
            //p = array where the frequence k of every element arr[i] is stored. 
            ushort[] p = new ushort[n];

            for (ushort i = 0; i < n; i++)
            {
                for (ushort j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        k = (ushort) (k + 1);
                    }
                }
                p[i] = k;
                k = 0;
            }

            ushort max = p[0];
            ushort maxElement = arr[0];

            for (ushort i = 1; i < 12; i++)
            {
                if (max < p[i])
                {
                    max = p[i];
                    maxElement = arr[i];
                }
            }

            Console.WriteLine("{0} ({1} times)", maxElement, max);

        }
    }
