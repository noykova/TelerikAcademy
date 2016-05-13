/*Write a method that calculates the number of workdays between today and a given date, passed as parameter. 
 * Consider that workdays are all days from Monday to Friday 
 * except a fixed list of public holidays specified preliminary as array.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Workdays
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Enter the date, from which to calculate workdays in the format dd.MM.yyyy: ");
        DateTime givenDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(givenDate);

        TimeSpan difference = today - givenDate;
        int totalDays = (int)Math.Ceiling(difference.TotalDays);
        Console.WriteLine(totalDays);

        //count working days without holidays
        int workingDays = 0;
        if (totalDays > 0)
        {

            for (int i = 0; i < totalDays; i++)
            {
                if (givenDate.DayOfWeek != DayOfWeek.Saturday && givenDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    ++workingDays;
                }
                givenDate = givenDate.AddDays(1);

            }
        }

        Console.WriteLine(workingDays);

        //exclude official holidays
        DateTime[] officialHolidays = new DateTime[]
            {
                new DateTime(2000, 1, 1), //New Years Eve
                new DateTime(2000, 3, 3), //..
                new DateTime(2000, 4, 29),//Orthodox Good Friday - movable, for simplicity I take only for 2016 
                new DateTime(2000, 5, 1),
                new DateTime(2000, 5, 2),//Orthodox Easter Monday for 2016
                new DateTime(2000, 5, 6),
                new DateTime(2000, 5, 24),
                new DateTime(2000, 9, 6),
                new DateTime(2000, 9, 22),
                new DateTime(2000, 12, 24),
                new DateTime(2000, 12, 25),
                new DateTime(2000, 12, 26)
            };

        //exclude official holidays
        for (int j = 0; j < officialHolidays.Length; j++)
        {

            for (int i = 0; i < totalDays; i++)
            {
                if ((givenDate.Month == officialHolidays[j].Month) && (givenDate.Day == officialHolidays[j].Day))
                {
                    workingDays--;
                }
                givenDate = givenDate.AddDays(1);

            }
        }

        //Print the final result = ammount of all working days without weekends and official holidays: 
        Console.WriteLine(workingDays);






        //string date = test.ToString("dd.MM.yyyy");
        //Console.WriteLine(date);
        // Console.WriteLine(test.DayOfWeek);      
    }
}
