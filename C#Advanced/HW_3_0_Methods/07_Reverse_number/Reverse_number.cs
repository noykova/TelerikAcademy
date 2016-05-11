/*Description
Write a method that reverses the digits of a given decimal number.
Input
•	On the first line you will receive a number
Output
•	Print the given number with reversed digits
*/

using System;
using System.Globalization;
using System.Threading;

public class Reverse_number
    {
        public static void Main()
        {
            decimal num = decimal.Parse(Console.ReadLine());
            Console.WriteLine(GetReversedNumber(num));
        }
        public static decimal GetReversedNumber(decimal number)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CurrentCulture;
            string str = number.ToString();
            string strResult = "";
            char[] chars = str.ToCharArray();
            char[] chars1 = new char[chars.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                chars1[i] = chars[chars.Length - 1 - i];
                strResult = strResult + chars1[i];
            }

            decimal decimalRes = decimal.Parse(strResult);

            return decimalRes;

            //от домашните: private static double GetReversedNumber(double num)
           // {
           //     string revNum = string.Join(string.Empty, num.ToString(CultureInfo.InvariantCulture).Reverse().ToArray());
           //     return double.Parse(revNum);
            //}

        }

    }

