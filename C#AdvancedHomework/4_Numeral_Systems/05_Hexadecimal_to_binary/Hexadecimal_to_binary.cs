/*Description
Write a program to convert hexadecimal numbers to binary numbers (directly).
Input
•	On the only line you will receive a hexadecimal number - N 
o	There will not be leading zeros
o	Letters will be uppercase
Output
•	Print the its binary representation on a single line 
o	There should not be leading zeros
 * 
 * BGCoder - 100/100
*/

using System;
using System.Collections.Generic;
using System.Text;

class Hexadecimal_to_binary
    {
        static void Main()
        {
            string hexadecimal = Console.ReadLine();
            ////the leading zeros should not be printed
            //string binary = Convert.ToString(Convert.ToInt32(hexadecimal, 16), 2);
            ////if we want to print leading zeros:
            ////string binary = Convert.ToString(Convert.ToInt32(hexadecimal, 16), 2).PadLeft(12, '0');
            //Console.WriteLine(binary);

            long decimalN = FromBaseToDecimal(16, hexadecimal);

            string binaryN = fromDecimalToBase(2, decimalN);

            Console.WriteLine(binaryN);


        }

        public static long FromBaseToDecimal(int fromBase, string n)
        {
          
            long toBaseNumber = 0;


            for (int i = 0; i < n.Length; i++)
            {
                int multiplier;

                switch (n[n.Length - 1 - i])
                {
                    case 'A':
                        multiplier = 10;
                        break;
                    case 'B':
                        multiplier = 11;
                        break;
                    case 'C':
                        multiplier = 12;
                        break;
                    case 'D':
                        multiplier = 13;
                        break;
                    case 'E':
                        multiplier = 14;
                        break;
                    case 'F':
                        multiplier = 15;
                        break;
                    default:
                        multiplier = int.Parse(n[n.Length - i - 1].ToString());
                        break;
                }

                toBaseNumber += multiplier * (long)Math.Pow(fromBase, i);
            }

            return toBaseNumber;
        }



        public static string fromDecimalToBase(int toBase, long n)
        {
            List<string> decimalNumberString = new List<string>();

            do
            {
                long remainder = n % toBase;
                n = n/toBase;

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
            return result;

        }


    }

