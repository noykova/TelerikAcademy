/*Description
•	Write a program that reads a string, reverses it and prints the result on the console.
Input
•	On the only line you will receive a string
Output
•	Print the string in reverse on a single line
 * 
 * ReverseStringUsingStack(s) - 30/100
 * ReverseStringUsingSB(s) - 40/100
 *  Array.Reverse(chars) - 30/100
 *  
 * only the first line - string.Join("",Concole.ReadLine().Reverse())); - 100/100
 * 
 * 
*/
using System;
using System.Linq;


    class Reverse_string
    {
        static void Main()
        {
            Console.WriteLine(string.Join("", Console.ReadLine().Reverse()));
        //    string s = Console.ReadLine();
        //    Console.WriteLine(ReverseStringUsingSB(s));

        //    string result1 = ReverseStringUsingStack(s);
        //    //Console.WriteLine(result1);

        //    char[] chars = s.ToCharArray();
        //    Array.Reverse(chars);
        //    //Console.WriteLine(new string(chars));
        //    //foreach (var element in chars)
        //   // {
        //   //   Console.Write(element);
        //   // }
        //   // Console.WriteLine();



        //}

        ////using StringBuilder. Second way - using foreach and insert
        //static StringBuilder ReverseStringUsingSB(string s)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    //for (int i = s.Length - 1; i >= 0; i--)
        //    //{
        //    //    sb.Append(s[i]);
        //    //}

        //    foreach (var element in s)
        //    {
        //        sb.Insert(0, element);
        //    }

        //    return sb;
        //}

        ////using Stack
        //public static string ReverseStringUsingStack(string s)
        //{

        //    Stack<char> store = new Stack<char>();
        //    string result1 = String.Empty;

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        store.Push(s[i]);
        
        //    }

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        result1 += store.Pop();

        //    }

        //    return result1;

        }

    }


   

