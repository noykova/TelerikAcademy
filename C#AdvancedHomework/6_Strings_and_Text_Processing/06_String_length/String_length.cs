/*Description
Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Input
•	On the only line you will receive a string
Output
•	Output a string with length 20
*/

using System;
using System.Text;


    class String_length
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] charArr = str.ToCharArray();

            StringBuilder result = new StringBuilder(20);
            for (int i = 0; i < 20; i++)
            {
                if (i < charArr.Length)
                {
                    result.Append(charArr[i]);
                }
                else
                {
                    result.Append('*');
                }
            }

            Console.WriteLine(result);
        }
    }
