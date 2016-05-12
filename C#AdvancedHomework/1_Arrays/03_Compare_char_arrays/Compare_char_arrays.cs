/* This program compares two char arrays lexicographically (letter by letter).*
 * 
 * This solution gets only 70/100 points. I suppose this is because instead many if-operators 
 * I should use for example  result = equal?"=":">" 
 
 corrected solution after reading def of lexicographical comparision of strings: 
 * http://www.inf.unibz.it/~calvanese/teaching/ip/lecture-notes/uni05/node19.html 
 * 
 * The word with capital letter is before the word with the same, but small letter. 
 * 
 * The solution is ready copied from Telerik forum Velislav Nikolov
 */

using System;

class Compare_char_arrays
{
    static void Main()
    {
        var firstArr = Console.ReadLine().ToCharArray();
        var secondArr = Console.ReadLine().ToCharArray();

        bool areEqual = true;

        if (firstArr.Length < secondArr.Length)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] < secondArr[i])
                {
                    areEqual = false;
                    Console.WriteLine("<");
                    break;
                }
                else if (firstArr[i] > secondArr[i])
                {
                    areEqual = false;
                    Console.WriteLine(">");
                    break;
                }
            }

            if (areEqual)
            {
                Console.WriteLine("<");
            }
        }
        else if (firstArr.Length > secondArr.Length)
        {
            for (int i = 0; i < secondArr.Length; i++)
            {
                if (firstArr[i] < secondArr[i])
                {
                    areEqual = false;
                    Console.WriteLine("<");
                    break;
                }
                else if (firstArr[i] > secondArr[i])
                {
                    areEqual = false;
                    Console.WriteLine(">");
                    break;
                }
            }

            if (areEqual)
            {
                Console.WriteLine(">");
            }
        }
        else
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] < secondArr[i])
                {
                    areEqual = false;
                    Console.WriteLine("<");
                    break;
                }
                else if (firstArr[i] > secondArr[i])
                {
                    areEqual = false;
                    Console.WriteLine(">");
                    break;
                }
            }

            if (areEqual)
            {
                Console.WriteLine("=");
            }
        }
    }

}

