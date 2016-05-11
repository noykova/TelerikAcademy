/*This program reads two integer arrays from the console and compares them element by element.*/

using System;

class Compare_arrays
    {
        static void Main()
        {
       // Start:
            //Console.Write("Enter the dimension of both arrays n= ");
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];

            //enter first array
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("array1[{0}] = ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            //enter second array
            for (int j = 0; j < n; j++)
            {
                //Console.WriteLine("array2[{0}] =  ", j);
                array2[j] = int.Parse(Console.ReadLine());
            }


            bool equal = true;


            for (int k = 0; k < n; k++)
            {

                if (array1[k] > array2[k] || array1[k] < array2[k])
                {
                    equal = false;
                }

            }

            Console.WriteLine("{0}",equal == true? "Equal" : "Not equal");

           // Console.WriteLine("If you wish to run the program again press y");
            //if (Console.ReadLine() == "y") { goto Start; }
        }
    }
