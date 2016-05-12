/*Write a program that finds in given array of (positive) integers a sequence of given sum S (if present).*/

using System;

    class Find_sum_in_array
    {
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

            //enter the target sum
            int s = int.Parse(Console.ReadLine());


            //current elements and sum
            int count = 0;
            int sum = arr[0];
            int BegIndex = 0;


            for (int i=1; i<n; i++)
            {

                if (sum < s)
                {
                    sum = sum + arr[i];
                    count+=1;
                    //Console.WriteLine("in for loop: count = {0}", count);
                }
                else if (sum > s)
                {
                     sum = arr[i];
                     BegIndex = i-1;
                     count=0;
                     //Console.WriteLine("in for loop: count = {0}", count);

                    }

                else if (sum == s)
                {
                    break;
                }
         
                }

            //print the results
            if (sum == arr[0] && arr[0] != s)
            {
                Console.WriteLine("No such sequence exists");
            }

            else
            {
                for (int i = BegIndex; i <= BegIndex+count; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }

        }
    }
