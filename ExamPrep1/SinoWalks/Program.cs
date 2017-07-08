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
        string format = @"HH:mm:ss";
        var time = DateTime.ParseExact(Console.ReadLine(), format,CultureInfo.InvariantCulture);
        double steps = double.Parse(Console.ReadLine()) % 86400;
        double timeInSteps = double.Parse(Console.ReadLine()) % 86400;
        double timeToAdd = timeInSteps * steps;
        var ans = time.AddSeconds(timeToAdd);
        Console.WriteLine($"Time Arrival: {ans.ToString(format)}");
    }
}
