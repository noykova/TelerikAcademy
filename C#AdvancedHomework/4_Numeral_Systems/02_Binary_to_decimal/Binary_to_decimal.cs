/*Description
Write a program that converts a binary number N to its decimal representation.
Input
•	On the only line you will receive a binary number - N 
o	There will not be leading zeros
Output
•	Print the decimal representation of N on a single line 
o	There should not be leading zeros
Constraints
•	1 <= N <= 1018 = 110111100000101101101011001110100111011001000000000000000000(2)
•	Time limit: 0.1s
•	Memory limit: 16MB
 * 
 * BGCoder - 100/100.
*/

using System;


    class Binary_to_decimal
    {
        static void Main()
        {
            //Console.WriteLine("Enter binary integer:");
            string binary = Console.ReadLine();
            int[] num = new int[binary.Length];
            long decimalNum = 0;
            long degree = binary.Length - 1;
            for (int i = 0; i < binary.Length; i++)
            {
                char ch = binary[i];
                num[i] = Convert.ToInt32(ch.ToString());
                decimalNum += num[i] * (long)Math.Pow(2, degree);
                degree--;
            }
            Console.WriteLine(decimalNum);


        }
    }

