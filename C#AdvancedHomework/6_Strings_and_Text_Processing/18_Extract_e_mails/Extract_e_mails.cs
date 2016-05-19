/*•	Write a program for extracting all email addresses from given text.
•	All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/

using System;
using System.Text.RegularExpressions;


    class Extract_e_mails
    {
        static void Main()
        {
            string text = Console.ReadLine();
            //string removedLines = Regex.Replace(text, @"\t|\n|\r", "");

            //explanation from: http://regexr.com/
            //[\w-\d] - character set - word, -, digit. Match any character in the set. 
            //+ - match 1 or more time preceeding []
            //[\.] - match .
            //? - optional, 0 or 1 times; [\.]? - match . 0 times or ones.

            string pattern = @"[\w-\d]+[\.]?[\w-\d]+@[\w-\d]+[\.]?\.[a-zA-Z]+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }

        }
    }

