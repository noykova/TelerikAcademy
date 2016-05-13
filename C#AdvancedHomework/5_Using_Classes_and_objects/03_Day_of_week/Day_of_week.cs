/*Write a program that prints to the console which day of the week is today. Use System.DateTime.
 again almost direct example from MSDN: https://msdn.microsoft.com/en-us/library/bb762911(v=vs.110).aspx 
 */

using System;


    class Day_of_week
    {
        static void Main()
        {
            DateTime test = DateTime.Now;
            string date = test.ToString("dd.MM.yyy");
            Console.WriteLine(date);
            Console.WriteLine(test.DayOfWeek);      
        }
    }
