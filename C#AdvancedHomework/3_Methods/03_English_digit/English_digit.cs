/*Description
Write a method that returns the last digit of given integer as an English word. 
 * Write a program that reads a number and prints the result of the method.
Input
•	On the first line you will receive a number
Output
•	Print the last digit of the number as an English word
*/

using System;

namespace _03_English_digit
{
    class English_digit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitAsWord(number));
        }

        static string GetLastDigitAsWord(int number)
        {
            string str = number.ToString();
            char[] chars = str.ToCharArray();
            int lastCharToInt = int.Parse(chars[chars.Length - 1].ToString());

            //last digit =   int lastDigit = num%10;
            //оr: int num = Convert.ToInt32(number.ToString().AsEnumerable().Last().ToString());


            switch (lastCharToInt)
            {
                case 0:
                    return "zero";
                    break;
                case 1:
                    return "one";
                    break;
                case 2:
                    return "two";
                    break;
                case 3:
                    return "three";
                    break;
                case 4:
                    return "four";
                    break;
                case 5:
                    return "five";
                    break;
                case 6:
                    return "six";
                    break;
                case 7:
                    return "seven";
                    break;
                case 8:
                    return "eight";
                    break;
                case 9:
                    return "nine";
                    break;
                default:
                    return "Not a valid number";
                    break;
            }
        }

    }
}
