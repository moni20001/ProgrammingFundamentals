using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (DateTime counter = startDate; counter <= endDate; counter = counter.AddDays(1))
        {
            if (counter.DayOfWeek == DayOfWeek.Saturday || counter.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }

        }
           
        Console.WriteLine(holidaysCount);
    }
}
