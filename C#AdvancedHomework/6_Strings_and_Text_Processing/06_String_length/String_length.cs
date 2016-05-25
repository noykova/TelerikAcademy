/*Description
Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Input
•	On the only line you will receive a string
Output
•	Output a string with length 20
 * 
 * BGCoder - 100/100
*/

using System;
using System.Text;


    class String_length
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] charArr = str.ToCharArray();

           // С любезното съдействие на един от трейнърите се оказа, 
            //че трябва да вземем под внимание по-специалните символи, 
            //escape sequence-ите например \\, \n и тн, които биха оказали влияние върху самата дължина на въвеждания стринг 
            //и впоследствие върху резултата.              
            str = str.Replace("\\", string.Empty);

            //very simple, only one row solution: 
            Console.WriteLine(str.PadRight(20, '*')); 

            //BGCoder - 85/100 - I could not find the error
            //StringBuilder result = new StringBuilder(20);
            //if (charArr.Length == 0)
            //{
            //    Console.WriteLine(new string('*',20));
            //}
            //else
            //{
            //    for (int i = 0; i < 20; i++)
            //    {
            //        if (i < charArr.Length)
            //        {
            //            result.Append(charArr[i]);
            //        }
            //        else
            //        {
            //            result.Append('*');
            //        }
            //    }

            //    Console.WriteLine(result);
            //}
        }
    }
