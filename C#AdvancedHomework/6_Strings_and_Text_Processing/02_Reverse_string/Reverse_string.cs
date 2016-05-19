/*Description
•	Write a program that reads a string, reverses it and prints the result on the console.
Input
•	On the only line you will receive a string
Output
•	Print the string in reverse on a single line
*/
using System;
using System.Collections.Generic;
using System.Text;


    class Reverse_string
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string result = ReverseStringUsingSB(s);
            Console.WriteLine(result);

            string result1 = ReverseStringUsingStack(s);
            Console.WriteLine(result1);

        }

        //using StringBuilder
        static string ReverseStringUsingSB(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }

        //using Stack
        public static string ReverseStringUsingStack(string s)
        {

            Stack<char> store = new Stack<char>();
            string result1 = String.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                store.Push(s[i]);
        
            }

            for (int i = 0; i < s.Length; i++)
            {
                result1 += store.Pop();

            }

            return result1;

        }

    }


   

