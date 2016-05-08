/*You are given an array of strings. 
 * Write a method that sorts the array by the length of its elements (the number of characters composing them).*/
using System;

class Sort_by_string_length
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];

        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }

        //CompareTo should be more efficient than OrderBy 
        //words = words.OrderBy(x => x.Length);
        //because CompareTo will sort the elements of the array in place 
        //rather than creating a new collection to enumerate.

        Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));


        //print the resulted ordered string

        foreach (string s in words)
        {
            Console.WriteLine(s);
        }


    }
}
