/*Write a program that reads two integer numbers N and K 
 * and an array of N elements from the console. 
 * Find the maximal sum of K elements in the array.
 
 This solution - 100/100 points in BG Coder*/

using System;


    class Maximal_K_sum
    {
        static void Main()
        {
        Start:

            //pomostna promenliwa, w kojato se sahranjawa indeksa na max element
            int index = 0;

            //declare the int sum of first k-elements
            int sum = 0;

            //Console.WriteLine("int n=  ");
            int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("int 1<k<=n, k=  ");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int[] max = new int[n];

            //Enter all n elements
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("Array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());

            }

            //Order the array elements in decreasing order. First find the maximal element max[i]. For this purpuse I use 2 for-loops, 
            //and compare the i-the value of the array with the rest i+1 to n values from another loop. 
            //remember the index of the maximal element and at the end of j - loop 
            //replace current value of the array with the value at index j. 

            for (int i = 0; i < n; i++)
            {
                max[i] = array[i];
                index = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] > max[i])
                    {
                        max[i] = array[j];
                        index = j;
                    }
                }

                array[index] = array[i];

                // Console.WriteLine("Array[{0}] = {1}, max[{0}] = {2}", i,array[i], max[i]);   

            }

            //Find the sum of first maximal k-elements 

            for (int p = 0; p < k; p++)
            {
                sum += max[p];
               // Console.Write("{0} + ", max[p]);
            }

            //Console.Write("= {0} ", sum);
            Console.WriteLine(sum);



           // Console.WriteLine("If you wish to run the program again press y");
           // if (Console.ReadLine() == "y") { goto Start; }
        }
    }

