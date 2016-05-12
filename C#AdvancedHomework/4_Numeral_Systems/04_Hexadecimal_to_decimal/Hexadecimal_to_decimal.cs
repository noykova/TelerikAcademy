/*Description
Write a program that converts a hexadecimal number N to its decimal representation.
Input
•	On the only line you will receive a hexadecimal number - N 
o	There will not be leading zeros
o	Letters will be uppercase
Output
•	Print the decimal representation of N on a single line 
o	There should not be leading zeros
 * 
 * This code is taken from Petya Kostova, GitHub. 
 * 
 * BGCoder - 100/100
*/

using System;

    class Hexadecimal_to_decimal
    {
        static void Main()
        {
            //Console.Write("Enter a hexadecimal number: "); 
            string hexNumber = Console.ReadLine();
            //from baseSystem
            int baseSystem = 16; 


            //Console.WriteLine(Convert.ToInt64(hexNumber, 16)); 

            long toBaseNumber = 0;


            for (int i = 0; i < hexNumber.Length; i++)
            {
                int multiplier;

                switch (hexNumber[hexNumber.Length - 1-i ])
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
                        multiplier = int.Parse(hexNumber[hexNumber.Length - i - 1].ToString());
                        //other way: multiplier = (int)hexNumber[hexNumber.Length - i - 1] - 48;
                        break;
                }

                toBaseNumber += multiplier * (long)Math.Pow(baseSystem, i);
            }

            Console.WriteLine(toBaseNumber);

        }
    }
