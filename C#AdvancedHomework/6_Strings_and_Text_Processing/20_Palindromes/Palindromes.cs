/*•	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.*/

using System;
using System.Collections.Generic;

    class Palindromes
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] words1 = input.Split(',', '?', ' ', '!', '.');
            string[] words = new string[words1.Length];

            //remove white space in the beginning and at the end of the words
            for (int i = 0; i < words1.Length; i++)
            {
                words[i] = words1[i].Trim();
            }

            //initial values 
            string reversed = "";
            List<string> result = new List<string>();

            //check over all words. For every word: .ToCharArray(), construct reversed, 
            //compare both arrays and save the word if it is palindrom. 
            for (int i = 0; i < words.Length; i++)
            {
                char[] arr = words[i].ToCharArray();
                char[] reversedArr = new char[arr.Length];


                for (int j = 0; j < arr.Length; j++)
                {
                    reversedArr[j] = arr[arr.Length - 1 - j];
                    reversed = reversed + reversedArr[j];
                }

                if ((reversed == words[i]) && (words[i] != ""))
                {
                    result.Add(words[i]);
                }
                reversed = "";
            }


            result.Sort();

            Console.WriteLine(string.Join(",", result));

        }
    }
