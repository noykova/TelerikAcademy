/*Description
Write a program to convert the number N from any numeral system of given base s to any other numeral system of base d.
Input
•	On the first line you will receive the number s
•	On the second line you will receive a number in base s - N 
o	There will not be leading zeros
•	On the third line you will receive the number d
Output
•	Print N in base d 
o	There should not be leading zeros
o	Use uppercase letters
 * 
 * BGCoder - 85/100
*/

using System;
using System.Collections.Generic;
using System.Text;


    class One_system_to_any_other
    {
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            // 2<=s 
            string sNum = Console.ReadLine();
            ////the leading zeros should not be printed

            int d = int.Parse(Console.ReadLine());

            long decimalN = FromBaseToDecimal(s, sNum);

            string dN = fromDecimalToBase(d, decimalN);

            Console.WriteLine(dN);
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
                long toPowerI = 1;
                if (i > 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        //Math.Pow(fromBase, i) is not always correct
                        toPowerI = toPowerI*fromBase;
                    }
                }

                toBaseNumber += multiplier * toPowerI; 
               
            }

            return toBaseNumber;
        }



        public static string fromDecimalToBase(int toBase, long n)
        {
            List<string> decimalNumberString = new List<string>();

            do
            {
                long remainder = n % toBase;
                n = n / toBase;

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

