/*•	Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
 * and prints the date and time after 6 hours and 30 minutes (in the same format) 
 * along with the day of week in Bulgarian.*/

using System;
using System.Globalization;

    class Date_in_Bulgarian
    {
        static void Main( )
        {
            Console.Write("Enter the date and time in the format d.MM.yyyy mm:hh:ss : ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            //timeSpan - 0 days, 6 hours, 30 min., 0 sec.
            TimeSpan t = new TimeSpan(0,6, 30, 0);

            //DateTime values are immutable. The Add method returns a new DateTime value with the TimeSpan added.
            DateTime result = date1.Add(t);

            //D - full date
            //dddd - day of week
            //F -full date/time pattern (long time).
            CultureInfo culture = new CultureInfo("bg-BG");
            Console.WriteLine("The date and time after 6 hours and 30 minutes will be: " + result.ToString("F", culture));
            Console.WriteLine("The day of week after 6 hours and 30 minutes will be: " + result.ToString("dddd",culture));
        }
    }

