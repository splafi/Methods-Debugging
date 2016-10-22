using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidays = 0;
        var delnik = 0;
        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                holidays=holidays+1;
            }
            else if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidays = holidays + 1;
            }
            else
            {
                delnik = delnik + 1;
            }
        }

        Console.WriteLine(holidays);
    }
}
