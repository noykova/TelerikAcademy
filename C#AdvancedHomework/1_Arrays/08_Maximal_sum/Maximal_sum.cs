/* Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
 * 
•	Can you do it with only one loop (with single scan through the elements of the array)?
 
 */
using System;

    class Maximal_sum
    {
        static void Main()
        {
            
       // Start:

            //Console.WriteLine("int n=  ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            //Enter all n elements of arr[i]
             for (int i = 0; i < n; i++)
            {
              //Console.Write("Array[{0}] = ", i);
              arr[i] = int.Parse(Console.ReadLine());

            } 


            int count = 0;
            int sum = arr[0];
            int BegIndex = 0;

            int maxBegIndex = 0;
            int maxCount = 0;
            int maxSum = arr[0];

            for (int i=1; i<n-1; i++)
            {

                if (sum >= 0)
                {
                    sum = sum + arr[i];
                    count+=1;
                    //Console.WriteLine("in for loop: count = {0}", count);
                }
                else
                {
                     sum = arr[i];
                     BegIndex = i;
                     count=0;
                     //Console.WriteLine("in for loop: count = {0}", count);

                    }

                if (sum > maxSum || (sum==maxSum && count>maxCount))
                {
                     maxSum = sum;
                     maxCount = count;
                    // Console.WriteLine("in for loop:maxCount = {0}", maxCount);
                     maxBegIndex = BegIndex;
                }
         
                }
    

            //var returnValue = maxResult.ToArray();

            //for (int i = maxBegIndex; i <= (maxBegIndex + maxCount); i++)
            //{
            //    Console.WriteLine(arr[i]);
            //    //Console.WriteLine("maxCount = {0}", maxCount);
            //   // Console.WriteLine("Count = {0}", count);

            //}

            Console.WriteLine(maxSum);

            //Console.WriteLine("If you wish to run the program again press y");
            //if (Console.ReadLine() == "y") { goto Start; }

        }
    }

      
