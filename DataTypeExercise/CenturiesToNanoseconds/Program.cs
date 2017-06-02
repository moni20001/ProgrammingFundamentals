using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        double year = 365.2422;
        int days = Convert.ToInt32(years * year);
        long hours = days * 24;
        long minutes = hours * 60;
        long second = minutes * 60;
        long milliseconds = second * 1000;
        decimal microseconds = milliseconds * 1000;
        decimal nanoseconds = microseconds * 1000;
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {second} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

    }
}
