/*Description
Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Input
•	On the first line you will receive a string - the pattern
•	On the second line you will receive a string - the text
Output
•	Print a number on a single line 
o	The number of occurrences
 * 
 * Регулярните изрази са по-бавни от IndexOf.
 * 
 * Result - 100/100
 * 
 * 
*/

using System;
using System.Linq;


    class Sub_string_in_text
    {
        static void Main()
        {
            int count = 0;//result
            int k = 0;//check if chars are equal

            string subStr = Console.ReadLine();
           // string subStr = subStrI.ToLower();

            string str = Console.ReadLine();
          //  string str = strI.ToLower();

            char[] charStr = str.ToCharArray();
            char[] charSubstr = subStr.ToCharArray();

            if (charStr.Length < charSubstr.Length)
            {
                Console.WriteLine("Error: The substring is bigger than the input string.");
            }

            for (int i = 0; i < str.Length-subStr.Length+1; i++)
            {
                //string temp = str.Substring(i, subStr.Length);
                //overlapping should be allowed
                if (str.Substring(i, subStr.Length).Equals(subStr, StringComparison.OrdinalIgnoreCase))

                {
                    count++;
                }
            }

            //for (int i = 0; i < charStr.Length - charSubstr.Length + 1; i++)
            //{
            //    for (int j = 0; j < charSubstr.Length; j++)
            //    {
            //        if (charStr[i + j] != charSubstr[j])
            //        {
            //            k = k + 1;
            //        }
            //    }
            //    if (k == 0)
            //    {
            //        count++;
            //    }
            //    k = 0;
            //}

            Console.WriteLine(count);

            //second shorter way using lambda expressions and Linq: 
            // count = str.Select((c, i) => str.Substring(i))
                //       .Count(x => x.StartsWith(subStr, StringComparison.CurrentCultureIgnoreCase));

        }
    }

