/*Description
Write a method that counts how many times given number appears in a given array. Write a test program to check if the method is working correctly.
Input
•	On the first line you will receive a number N - the size of the array
•	On the second line you will receive N numbers separated by spaces - the numbers in the array
•	On the third line you will receive a number X
Output
•	Print how many times the number X appears in the array
*/

using System;
using System.Linq;


    class Appearance_count
    {
        static void Main()
        {
            int dim = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(HowManyTimes(x, arr));
           // Console.WriteLine(TestTheMethod(HowManyTimes(x, arr), x, arr));

        }

        public static int HowManyTimes(int x, int [] arr)
        {
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (x==arr[i])
                {
                    k++;
                }
            }
            return k;
        }

        //calculate k using other approach - count from last element to the first. If both results are the same - true.
        public static bool TestTheMethod(int k, int x, int[] arr)
        {

            int count = 0;

            for (int i = arr.Length-1; i >=0; i--)
            {
                if (x == arr[i])
                {
                    count++;
                }
            }
            return (count == k);
        }
    }
