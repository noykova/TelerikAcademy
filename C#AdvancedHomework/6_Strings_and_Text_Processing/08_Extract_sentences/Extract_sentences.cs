/*Description
Write a program that extracts from a given text all sentences containing given word.
Input
•	On the first line you will receive a string - the word
•	On the second line you will receive a string - the text
Output
•	Print only the sentences containing the word on a single line
Constraints
•	Sentences are separated by . and the words – by non-letter symbols
•	Time limit: 0.1s
•	Memory limit: 16MB
*/

using System;
using System.Text.RegularExpressions;

    class Extract_sentences
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            //pattern for searching the word in the text
            //[A-z]\w+ - words, started with capital letters == beginning of the sentence 1 or more times
            //[A-Za-z–\d’\s,&-]* - letters, digits, ', white spaces, symbols ,&- - 0 or more times
            //\s - white space
            //word
            //[A-Za-z–\d’\s,&-]* - letters, digits, ', white spaces - 0 or more times
            //. ! ;: or ? at the end of the sencetnce

            string pattern = @"[A-Z]\w+[A-Za-z–\d’\s,&-]*\s" + word + @"\s[A-Za-z–\d’\s,&-]*[\.\!\?\:\;]";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }

        }
    }
