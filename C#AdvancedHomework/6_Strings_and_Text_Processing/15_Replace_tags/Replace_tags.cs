/*Description
Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…](…/URL).
Input
•	On the only input line you will receive a string
Output
•	Print the string with replaced tags
 * 
 * using regex - 0/100 - TimeLimit. 
 * 
 * Therefore - use StringBuilder, Substring and IndexOf - use solution of Petya Kostova 
 * 
*/

using System;
using System.Text;
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

            StringBuilder result = new StringBuilder();

            string[] words = text.Split(new string[] { "<a href", "</a>" }, StringSplitOptions.None); 
            // The return value includes array elements that contain an empty string
 
            foreach (var word in words)
            {
                int indexOfLink = word.IndexOf("=\"");

                if (indexOfLink >= 0)
                {
                    int endIndex = word.IndexOf("\">");
                    result.Append("[");
                    result.Append(word.Substring(endIndex + 2, word.Length - endIndex - 2));
                    result.Append("](");
                    result.Append(word.Substring(indexOfLink + 2, endIndex - indexOfLink - 2));
                    result.Append(")");
                }
                else
                {
                    result.Append(word);
                }
            }

            if (result.Length == 0)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine(result.ToString());
            }



            //char[] textToChar = text.ToCharArray();
            //check if in the beginning and at the end the quotes are of the same type
            //if (textToChar[0]!=textToChar[textToChar.Length-1])
            //{
            //    Console.WriteLine("Invalid type of quotes");
            //}


            //trim quotes at the beginning and the end of the string
           // char[] chars = {'\"', '\''};
           // string  textStart = text.TrimStart(chars);
          //  string textE = textStart.TrimEnd(chars);
            //Console.WriteLine(textE);

            //.*? - . - everything; +- 1 or more times
            //string pattern = "<a\\shref=\"(.*?)\">(.*?)<\\/a>";

            //$1 - group 1 = (.*?)
            //$2 - group 2 = (.*?)

           // Console.WriteLine(Regex.Replace(textE, pattern, @"[$2]($1)"));           


        }
    }

