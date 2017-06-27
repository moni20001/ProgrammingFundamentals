using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string dateFormat = "dd-MM-yyyy";
        CultureInfo provider = CultureInfo.InvariantCulture;
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), dateFormat, provider);
        DateTime finishtDate = DateTime.ParseExact(Console.ReadLine(), dateFormat, provider);
        DateTime[] holidays = new DateTime[12];
        holidays[0] = new DateTime(4, 01, 01);
        holidays[1] = new DateTime(4, 03, 03);
        holidays[2] = new DateTime(4, 05, 01);
        holidays[3] = new DateTime(4, 05, 06);
        holidays[4] = new DateTime(4, 05, 24);
        holidays[5] = new DateTime(4, 09, 06);
        holidays[6] = new DateTime(4, 09, 22);
        holidays[7] = new DateTime(4, 11, 01);
        holidays[9] = new DateTime(4, 12, 24);
        holidays[10] = new DateTime(4, 12, 25);
        holidays[11] = new DateTime(4, 12, 26);
        int workingDays = 0;
        for (DateTime i = startDate; i <= finishtDate; i=i.AddDays(1))
        {
            var day = i.DayOfWeek;
            var temp = new DateTime(4, i.Month, i.Day);
            if(day!=DayOfWeek.Saturday&&day!=DayOfWeek.Sunday&& !holidays.Contains(temp))
            {
                workingDays++;
            }
        }
        Console.WriteLine(workingDays);
    }
}
