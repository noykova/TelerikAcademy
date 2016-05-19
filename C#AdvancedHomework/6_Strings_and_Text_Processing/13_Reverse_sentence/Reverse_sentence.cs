/*•	Write a program that reverses the words in given sentence.*/

using System;
using System.Collections.Generic;
using System.Linq;

    class Reverse_sentence
    {
        static void Main()
        {
            string sentence = Console.ReadLine();
            char[] splittingChars = {' '};
            //split the sentence to words
            string[] words = sentence.Split(splittingChars, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //array which contains indexes of ,.!:;
            List<int> indexes = new List<int>();
            //array which contains ,.!:;
            List<char> signs = new List<char>();

            //remove the signs .,!.... at the end of words, but remember the sign and its place in the array.
            for (int i = 0; i < words.Length; i++)
            {

                if (words[i].Contains(',') || words[i].Contains('.') || words[i].Contains('!') || words[i].Contains('?') || words[i].Contains(':') || words[i].Contains('-'))
                {
                    indexes.Add(i);
                    signs.Add(Convert.ToChar(words[i].Substring(words[i].Length - 1)));
                   words[i] = words[i].Remove(words[i].Length - 1, 1);
                }

                
            }

            //reverse the words
            Array.Reverse(words);

            int[] index = indexes.ToArray();
            char[] sign = signs.ToArray();

            //add the signs .,!?.. at the end of corresponding word at the same place as in the beginning. 
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < index.Length; j++)
                {
                    if (i==index[j])
                    {
                        words[i] += sign[j];
                    }
                }
            }

            Console.WriteLine(String.Join(" ", words));

        }
    }

