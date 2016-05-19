/*•	We are given a string containing a list of forbidden words and a text containing some of these words.
•	Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
Forbidden words: PHP, CLR, Microsoft
The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
*/

using System;


    class Forbidden_words
    {
        static void Main()
        {
            string strBan = Console.ReadLine();
            string[] bannedWords1 = strBan.Split(',');
            string[] bannedWords = new string[bannedWords1.Length];

            for (int i = 0; i < bannedWords1.Length; i++)
            {
                bannedWords[i] = bannedWords1[i].Trim();
                //Console.WriteLine(bannedWords[i]);
            }

            string text = Console.ReadLine();
            string newText = text;

            for (int j = 0; j < bannedWords.Length; j++)
            {
                newText = newText.Replace(bannedWords[j], new string('*', bannedWords[j].Length));
            }

            Console.WriteLine(newText);

        }
    }

