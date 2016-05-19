/*Description
Write a program to check if in a given expression the ( and ) brackets are put correctly.
Input
•	On the only line you will receive an expression
Output
•	Print Correct if the brackets are correct 
*/

using System;
using System.Collections.Generic;

public class Correct_brackets
{
    public static void Main()
    {
        string s = Console.ReadLine();
        CheckCorrectParenthesisUsingCharArr(s);
        CheckCorrectParenthesisUsingStack(s);
    }

  
    public static void CheckCorrectParenthesisUsingCharArr(string s)
    {

        char[] arr = s.ToCharArray();
        int c1 = 0;
        int c2 = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == '(')
            {
                c1++;
            }

            if (arr[i] == ')')
            {
                c2++;
            }

        }

        if (c1 == c2)
        {
            Console.WriteLine("Correct");
        }

        else
        {
            Console.WriteLine("Incorrect");
        }
    }


    public static void CheckCorrectParenthesisUsingStack(string s)
    {
        Stack<char> store = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i]=='(')
            {
                store.Push(s[i]);
            }

            if (s[i] == ')'&& store.Peek() =='(')
            {
                store.Pop();
            }

            if (s[i] == ')' && store.Count!=0 && store.Peek() != '(')
            {
                store.Push(s[i]); //or:System.Console.WriteLine("Error message at index i"); break; 
            }
        }

        if (store.Count == 0)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }

    }

}

