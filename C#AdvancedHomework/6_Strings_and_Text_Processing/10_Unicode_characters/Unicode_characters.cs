/*Description
Write a program that converts a string to a sequence of C# Unicode character literals.
Input
•	On the only input line you will a string
Output
•	Print the string in C# Unicode character literals on a single line
 * 
 * BGCoder - 60/100
 * 
 * about command characters: https://msdn.microsoft.com/en-us/library/aa691087%28v=vs.71%29.aspx 
*/

using System;
using System.Text;


    class Unicode_characters
    {
        static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder newText = new StringBuilder();
            //string[] unicodeChar = new string[text.Length];
            //int[] temp = new int[text.Length];
            //string[] temp1 = new string[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                //if I check if the characters are letters, I get 30/100. 
                //if (((int)text[i] >= 32) && ((int)text[i] <= 126))
               // {
                   // temp[i] = (int)text[i];
                    //unicodeChar[i] = "\\u" + temp[i].ToString("X4");
                    newText.AppendFormat("\\u{0:X4}", (int)text[i]);
                    //newText.Append(unicodeChar[i]);
                //}
            }

            Console.WriteLine(newText);

            //or:
            //string input = Console.ReadLine();
            //foreach (var ch in input)
            //{
            //    Console.Write("\\u{0:x4}", (int)ch);
            //}
            //Console.WriteLine();

        }
    }

