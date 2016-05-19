/*•	Write a program that reads a string from the console 
 * and prints all different letters in the string along 
 * with information how many times each letter is found. */

using System;
using System.Text.RegularExpressions;

   class Letters_count
    {
        static void Main()
        {
            //first use Porblem 23 to select different letters

        string text = Console.ReadLine();
            //from regexr.com: . - matches any characters except line breaks. (.) - group them. 
            // \ - backreference: matches group after \. 
            // 1 - matches group number 1. 
            // + - matches 1 or more of preceeding token. 
            string pattern = @"(.)\1+";

            Regex regex = new Regex(pattern);

            // $ - at the end ; 1 - first subpatern
     //So, The regex will match any character (.) and \\1+ will match whatever was captured //in the first group.
            
            //char array with different letters
            char[] separateLetters = regex.Replace(text, "$1").ToCharArray();

            char[] textToChar = text.ToCharArray();

            int[] counters = new int[separateLetters.Length];

            //compare letters in the text with the array of different letters 
            //and count how many times every different letter appear in the text
            for (int i = 0; i < textToChar.Length; i++)
            {
                for (int j = 0; j < separateLetters.Length; j++)
                {
                    if (textToChar[i] == separateLetters[j])
                    {
                        counters[j]++;
                    }
                }
            }

            //print the results
            for (int i = 0; i < separateLetters.Length; i++)
            {
                Console.WriteLine("Letter {0} - {1} times",separateLetters[i],counters[i]);
            }
        }
    }

