/*Description
Write a program that reads a year from the console and checks whether it is a leap one.
Hint: Use System.DateTime.
Input
•	On the only line you will receive a number - the year
Output
•	Print "Leap" or "Common" on a single line depending on the year
 * 
 * almost direct copy/paste example from MSDN:
 * https://msdn.microsoft.com/en-us/library/system.datetime.isleapyear(v=vs.110).aspx
 * 
 * BGCoder: 100/100
*/

using System;


class Leap_year
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        /*for (int year = 1994; year <= 2016; year++)
        {           
        }*/

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Leap");
            //DateTime leapDay = new DateTime(year, 2, 29);
            //DateTime nextYear = leapDay.AddYears(1);
            //Console.WriteLine("   One year from {0} is {1}.",
            //                  leapDay.ToString("d"),
            //                  nextYear.ToString("d"));
        }
        else
        {
            Console.WriteLine("Common");
        }

    }
}
