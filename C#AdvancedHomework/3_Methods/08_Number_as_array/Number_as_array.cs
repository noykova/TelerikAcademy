/*Description
Write a method that adds two positive integer numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 * Write a program that reads two arrays representing positive integers and outputs their sum.
Input
•	On the first line you will receive two numbers separated by spaces - the size of each array
•	On the second line you will receive the first array
•	On the third line you will receive the second array
Output
•	Print the sum as an array of digits (as described) 
o	Digits should be separated by spaces
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Number_as_array
{
    static void Main()
    {
        //enter the dimension of numbers
        int[] dims = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int razlikaDims = dims[0] - dims[1];
        int arrLength = Math.Max(dims[0], dims[1]);

        //enter first number as List<int> and add zeros at the end if necessary. Reverse the number. 
        List<int> arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        if (razlikaDims < 0)
        {
            for (int i = 0; i < Math.Abs(razlikaDims); i++)
            {
                arr1.Add(0);
            }
        }

        int[] arr11 = arr1.ToArray();
        Array.Reverse(arr11);

        //enter the second number as List<int> and add zeros at the end if necessary. Reverse the number. 
        List<int> arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


        if (razlikaDims > 0)
        {

            for (int i = 0; i < razlikaDims; i++)
            {
                arr2.Add(0);
            }
        }
        int[] arr12 = arr2.ToArray();

        Array.Reverse(arr12);

        //sum the reversed arrays
        int[] resultArr = (SumOfTwoReveversedIntegers(arrLength, arr11, arr12));
        //and reverse the sum
        Console.WriteLine(String.Join(" ", resultArr.Reverse()));

    }

    //first transforme the method parameters and reverse the integer. Next sum them and reverse the result
    public static int[] SumOfTwoReveversedIntegers(int arrLength, int[] arr11, int[] arr12)
    {
        bool addOne = false;
        int[] resultArr = new int[arrLength];

        //sum all digits and add 1 if necessary
        for (int i = arrLength - 1; i >= 0; i--)
        {
            int sumDigit = 0;
            if (addOne == false)
            {
                if ((arr11[i] + arr12[i]) >= 10)
                {
                    resultArr[i] = (arr11[i] + arr12[i]) % 10;
                    addOne = true;
                }
                else
                {
                    resultArr[i] = (arr11[i] + arr12[i]);
                }
                continue;
            }
            if (addOne)
            {
                if ((arr11[i] + arr12[i] + 1) >= 10)
                {
                    resultArr[i] = (arr11[i] + arr12[i] + 1) % 10;
                }
                else
                {
                    resultArr[i] = (arr11[i] + arr12[i] + 1);
                    addOne = false;
                }
                //last digit are 2 digits if sum>10
                if (addOne && i == 0 && (arr11[i] + arr12[i] + 1) >= 10)
                {
                    resultArr[i] = (arr11[i] + arr12[i] + 1);
                }
            }

        }

        return resultArr;
    }


}
