
/*•	Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
•	Display them in the standard date format for Canada.
*/

using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;


    class Dates_from_text_in_Canada
    {
        static void Main()
        {
            string text = Console.ReadLine();

            //explanation from: http://regexr.com/
            
            string pattern = @"[0-9][0-9].[0-9][0-9].[0-9][0-9][0-9][0-9]";

            var arr = Regex.Matches(text, pattern)
                     .Cast<Match>()
                     .Select(m => m.Value)
                     .ToArray();

           DateTime [] arr1 = new DateTime[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = Convert.ToDateTime(arr[i]);
            }

            CultureInfo culture = new CultureInfo("en-Ca");

            foreach (DateTime element in arr1)
            {
                Console.WriteLine(element.ToString("F", culture));
            }


        }
    }

