/*Description
Write a program that converts a decimal number N to its binary representation.
Input
•	On the only line you will receive a decimal number - N 
o	There will not be leading zeros
Output
•	Print the binary representation of N on a single line 
o	There should not be leading zeros
 * 
 * BGCoder - 100/100
*/

using System;
using System.Collections.Generic;
using System.Text;


    class Decimal_to_binary
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            List<string> decimalNumberString = new List<string>();
            int baseSystem = 2;

            do
            {
                long remainder = n % baseSystem;
                n = n / baseSystem;

                StringBuilder letter = new StringBuilder();

                switch (remainder)
                {
                    case 10:
                        letter.Append("A");
                        break;
                    case 11:
                        letter.Append("B");
                        break;
                    case 12:
                        letter.Append("C");
                        break;
                    case 13:
                        letter.Append("D");
                        break;
                    case 14:
                        letter.Append("E");
                        break;
                    case 15:
                        letter.Append("F");
                        break;
                    default:
                        letter.Append(remainder);
                        break;
                }
                decimalNumberString.Add(letter.ToString());
            }
            while (n != 0);

            decimalNumberString.Reverse();
            string result = string.Join("", decimalNumberString);
            Console.WriteLine(result);
        }
    }

