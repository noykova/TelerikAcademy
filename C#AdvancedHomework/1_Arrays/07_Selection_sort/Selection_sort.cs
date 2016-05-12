/* This program sort an array. 
 * First find the smallest element, 
 * move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.*/

using System;


    class Selection_sort
    {
        static void Main()
        {
        Start:

            //pomostna promenliwa, w kojato se sahranjawa indeksa na min element
            int index = 0;

            //Console.WriteLine("int n=  ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int[] min = new int[n];

            //Enter all n elements
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("Array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());

            }

            //Order the array elements in increasing order. First find the min element min[i]. For this purpuse I use 2 for-loops, 
            //and compare the i-the value of the array with the rest i+1 to n values from another loop. 
            //remember the index of the min element and at the end of j - loop 
            //replace current value of the array with the value at index j. 

            for (int i = 0; i < n; i++)
            {
                min[i] = array[i];
                index = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < min[i])
                    {
                        min[i] = array[j];
                        index = j;
                    }
                }

                array[index] = array[i];
            }

            //Print the sorted array 

            for (int p = 0; p < n; p++)
            {
                Console.WriteLine(min[p]);
            }

           // Console.WriteLine();

          //  Console.WriteLine("If you wish to run the program again press y");
          //  if (Console.ReadLine() == "y") { goto Start; }
        }
    }

