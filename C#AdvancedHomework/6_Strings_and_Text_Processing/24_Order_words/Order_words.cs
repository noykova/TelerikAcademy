/*•	Write a program that reads a list of words, 
 * separated by spaces and prints the list in an alphabetical order.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace _24_Order_words
{
    class Order_words
    {
        static void Main()
        {
            string text = Console.ReadLine();
            List<string> words = text.Split(' ').ToList();
            words.Sort();
            foreach (var w in words)
            {
                Console.WriteLine(w);
            }
        }
    }
}
