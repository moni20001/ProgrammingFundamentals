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
        int n = int.Parse(Console.ReadLine());
        decimal[] arr = new decimal[n];
        for (int i = 0; i < n; i++)
        {
            var pricePerCapsule = decimal.Parse(Console.ReadLine());
            CultureInfo provider = CultureInfo.InvariantCulture;

            string datePattern = "d/M/yyyy";
            DateTime date = DateTime.ParseExact(Console.ReadLine(),datePattern,provider);
            decimal capsules = decimal.Parse(Console.ReadLine());
            var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            var price = daysInMonth * capsules * pricePerCapsule;
            arr[i] = price;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"The price for the coffee is: ${arr[i]:f2}");
        }
        decimal sum = arr.Sum();
        if (arr.Length > 0)
        {
            Console.WriteLine($"Total: ${sum:f2}");
        }
       
    }
}
