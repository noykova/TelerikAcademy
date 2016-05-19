/*You are given a text. Write a program that changes the text 
 * in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
Input
•	On the only line you will receive a string - the text
Output
•	Print the changed string on one line
*/

using System;
using System.Text.RegularExpressions;


    class Parse_tags
    {
        static void Main()
        {
            //use Regex
            string text = Console.ReadLine();
            //(?<=<upcase>) - grouping construct - positive lookbehind - everything after <upcase>
            // .*? - matches any character (except newline)
            //(?=<\/upcase>) - grouping construct - positive lookahead - everything before </upcase>
            //more explanations - https://regex101.com/ 
            string pattern = @"(?<=<upcase>).*?(?=<\/upcase>)";
            Regex regex = new Regex(pattern);           
            MatchCollection matches = regex.Matches(text);

            //convert MatchCollection to string array 
            //var arr = Regex.Matches(text, pattern)
            //               .Cast<Match>()
            //               .Select(m => m.Value.ToUpper())
            //               .ToArray();

            //replace the chosen substring in pattern by UpperCase. Use delegate to transform the matches toUppercase.
            //it dores not wok without delegate, using directly match.ToString().ToUpper(). 
            //Regex.Replace(string input, string pattern, string replacement)
            string result = Regex.Replace(text, pattern, delegate(Match match)
            {
                string v = match.ToString().ToUpper();
                return v;
            });

           // Console.WriteLine(result);

            //split text result using <upcase> and</upcase> as separators. First define the separator array. 
            string[] stringSeparators = new string[] { "<upcase>", "</upcase>" };
            //split the text result
            string[] words = result.Split(stringSeparators, StringSplitOptions.None);
            //join the text, so in the final result both  <upcase> and</upcase> do not present: 
            Console.WriteLine(string.Join("",words));



            //remove <upcase> and </upcase> from the string result using string.Remove(), which could be slower. 
            //while (true)
            //{
            //    if (result.IndexOf("<upcase>")>=0)
            //    {
            //        result = result.Remove(result.IndexOf("<upcase>"), 8);
            //    }
            //    if (result.IndexOf("</upcase>") >= 0)
            //    {
            //        result = result.Remove(result.IndexOf("</upcase>"), 9);
            //    }

            //    if (result.IndexOf("<upcase>") < 0 && result.IndexOf("</upcase>") < 0)
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine(result);
        }
    }
