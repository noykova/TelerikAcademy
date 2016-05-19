/*•	Write a program that reads a string from the console 
 * and replaces all series of consecutive identical letters with a single one.*/

using System;
using System.Text.RegularExpressions;

    class Series_of_letters
    {
        static void Main()
        {
            /*I use goto - loop in order to check easily if the program works correctly*/
   Start:

            string text = Console.ReadLine();
            //from regexr.com: . - matches any characters except line breaks. (.) - group them. 
            // \ - backreference: matches group after \. 
            // 1 - matches group number 1. 
            // + - matches 1 or more of preceeding token. 
            string pattern = @"(.)\1+";

            Regex regex = new Regex(pattern);

            // $ - at the end ; 1 - first subpatern
     //So, The regex will match any character (.) and \\1+ will match whatever was captured //in the first group.
            Console.WriteLine(regex.Replace(text, "$1")); 

            Console.WriteLine("If you want to run the program again, press y:");
            if (Console.ReadLine() == "y") goto Start;

        }
    }
