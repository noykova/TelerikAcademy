/*Description
Write a program that creates an array containing all letters from the alphabet (a-z). 
 * Read a word from the console and print the index of each of its letters in the array.
Input
•	On the first line you will receive the word
Output
•	Print the index of each of the word's letters in the array 
o	Each index should be on a new line
Constraints
•	1 <= word length <= 128
•	Word is consisted of lowercase english letters
•	Time limit: 0.1s
•	Memory limit: 16MB
*/

using System;

    class Index_of_letters
    {
        static void Main()
        {
            char[] letters =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            string word = Console.ReadLine();

            char[] wordInLetters = word.ToCharArray();

                            
            //Array.IndexOf(arr, item) - finds an item in array
            foreach (char t in wordInLetters)
            {
                Console.WriteLine(Array.IndexOf(letters,t));
            }
        }
    }
