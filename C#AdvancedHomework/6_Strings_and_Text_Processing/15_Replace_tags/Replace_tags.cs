/*Description
Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…](…/URL).
Input
•	On the only input line you will receive a string
Output
•	Print the string with replaced tags
*/

using System;
using System.Text.RegularExpressions;


    class Replace_tags
    {
        static void Main()
        {
            //Console.ReadLine() can read only one line. 
            //Therefore it is impossible to remove new lines from the text if we read the text from the concole.  
            //Otherwise: 
            //string removedLines = text.Replace(System.Environment.NewLine, " ");
           //Regex.Replace(text, @"[""""''\t\n\r]*", ""); //\r - return

            string text = Console.ReadLine();
            char[] textToChar = text.ToCharArray();

            //check if in the beginning and at the end the quotes are of the same type
            if (textToChar[0]!=textToChar[textToChar.Length-1])
            {
                Console.WriteLine("Invalid type of quotes");
            }


            //trim quotes at the beginning and the end of the string
            char[] chars = {'\"', '\''};
            string  textStart = text.TrimStart(chars);
            string textE = textStart.TrimEnd(chars);
            //Console.WriteLine(textE);

            //.+ - . - everything; +- 1 or more times
            string pattern = "<a(\\shref=.+)>(.+)<\\/a>";

            //$1 - group 1 = (\\shref=.+)
            //$2 - group 2 = (.+)
           Console.WriteLine(Regex.Replace(textE, pattern, @"[URL href=$1]$2[/URL]"));

        }
    }

