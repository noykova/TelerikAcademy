/*•	Write a program that reads a string from the console 
 * and lists all different words in the string along 
 * with information how many times each word is found.*/

using System;
using System.Collections.Generic;
using System.Linq;

  class Words_count
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            //hashSet does not hold repeated values
            HashSet<string> wordsSeparate = new HashSet<string>();
            for (int i = 0; i < words.Length; i++)
            {
                wordsSeparate.Add(words[i]);
            }

            string[] singleWords = wordsSeparate.ToArray();

            //the same logic as in ptoblem 21
            int[] counters = new int[singleWords.Length];
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < singleWords.Length; j++)
                {
                    if (words[i] == singleWords[j])
                    {
                        counters[j]++;
                    }
                }
            }

            //print the results
            for (int i = 0; i < singleWords.Length; i++)
            {
                Console.WriteLine("Letter {0} - {1} times", singleWords[i], counters[i]);
            }
        }
    }
