/*•	Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.*/
using System;

    class Date_difference
    {
        static void Main()
        {
            Console.Write("Enter the first date in the format d.MM.yyyy: ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the second date in the format d.MM.yyyy: ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());
   

            TimeSpan difference = date1 - date2;
            int totalDays = (int) difference.TotalDays;
            Console.WriteLine("Distance: {0} days", Math.Abs(totalDays));

        }
    }
