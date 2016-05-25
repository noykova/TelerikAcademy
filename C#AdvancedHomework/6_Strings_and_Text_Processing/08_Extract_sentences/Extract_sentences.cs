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
 * 
 * BGCoder - 0/100 - correct, but TimeLimit. regex is may be too slow. 
 * Now - 30/100
*/

using System;
using System.Linq; //need for separators - Where(x => ....)
using System.Text;
using System.Text.RegularExpressions;

class Extract_sentences
{
    static void Main()
    {
        string word = Console.ReadLine().Trim();
        string text = Console.ReadLine();
        //remove command characters
        text = text.Replace("\\", String.Empty);

        string[] sentences = text.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);

    

        StringBuilder result = new StringBuilder();

        char[] separators = text.Where(x => !char.IsLetter(x) && x != '.').Distinct().ToArray();
        foreach (var sentence in sentences)
        {
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var w in words)
            {
                if (w.Trim().Equals(word))
                {
                    result.Append(sentence + ".");
                    break;
                }
            }
        }
        Console.WriteLine(result);
        //Console.WriteLine(result);

        //the solution bellow is correctlyt working, but gets 0/100 may be because Regex is slow and all tests get TimeLimit.
        //pattern for searching the word in the text
        //[A-z]\w+ - words, started with capital letters == beginning of the sentence 1 or more times
        //[A-Za-z–\d’\s,&-]* - letters, digits, ', white spaces, symbols ,&- - 0 or more times
        //\s - white space
        //word
        //[A-Za-z–\d’\s,&-]* - letters, digits, ', white spaces - 0 or more times
        //. ! ;: or ? at the end of the sencetnce

        //string pattern = @"[A-Z\s]\w+[A-Za-z–\d’\s,&-]*\s" + word + @"\s[A-Za-z–\d’\s,&-]*[\.\!\?\:\;]";
        //Regex regex = new Regex(pattern);

        //MatchCollection matches = regex.Matches(text);

        //foreach (var match in matches)
        //{
        //    Console.Write(match);
        //}

    }
}
