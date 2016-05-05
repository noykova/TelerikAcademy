/* This program compares two char arrays lexicographically (letter by letter).*
 * 
 * This solution gets only 70/100 points. I suppose this is because instead many if-operators 
 * I should use for example  result = equal?"=":">" */

using System;

    class Compare_char_arrays
    {
        static void Main()
        {
            string str1 = Console.ReadLine();
            char[] array1 = str1.ToCharArray();

            string str2 = Console.ReadLine();
            char[] array2 = str2.ToCharArray();

            bool equal = true;
            int sumLetters = 0; 

            //check tha array length
            if (array1.Length > array2.Length)
            {
                Console.WriteLine(">");
            }
            else if (array1.Length < array2.Length)
            {
                Console.WriteLine("<");
            }

           //if the array length is equal, check also the sum of chars in every string
            else if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                       equal = false;
                        sumLetters += (array1[i] - array2[i]);
                        break;
                    } 
                }
            }

            //check the sum if the length is the same
            if (array1.Length == array2.Length && equal && sumLetters == 0)
            {
                Console.WriteLine("=");
            }
            else if (array1.Length == array2.Length && equal)
            {
                if (sumLetters > 0)
                {
                    Console.WriteLine(">");
                }
                if (sumLetters < 0)
                {
                    Console.WriteLine("<");
                }
            }
        }
    }
