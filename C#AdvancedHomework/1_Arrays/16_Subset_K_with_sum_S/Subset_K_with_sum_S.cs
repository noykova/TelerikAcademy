/*Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
•	Find in the array a subset of K elements that have sum S or indicate about its absence.
*/

using System;

    class Subset_K_with_sum_S
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

            //enter the sum S
            int s = int.Parse(Console.ReadLine());

            //enter count K
            int k = int.Parse(Console.ReadLine());


            //integers, indicating the begining and length of subsets
            int count = 0;
            int sum = arr[0];
            int BegIndex = 0;

            int targetBegIndex = 0;
            int targetCount = 0;

            //bool indicating is such subset exists
            bool exists = false;


            for (int i = 1; i < n - 1; i++)
            {

                if (sum < s)
                {
                    sum = sum + arr[i];
                    count += 1;
                    //Console.WriteLine("in for loop: count = {0}", count);
                }
                else if (sum > s)
                {
                    sum = arr[i];
                    BegIndex = i;
                    count = 0;
                    //Console.WriteLine("in for loop: count = {0}", count);

                }

                else
                {

                    targetCount = count+1;

                    targetBegIndex = BegIndex;
                    exists = true;
                    if (exists == true && targetCount == k)
                    {
                        Console.WriteLine("yes");
                    }
                    break;
                }
            }

            if (exists == false || targetCount!=k)

        {
                Console.WriteLine("no");
                //Console.WriteLine("k={0}, count ={1}",k, count);
            }

        }
    }

