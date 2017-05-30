using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        var day = int.Parse(Console.ReadLine());
        var month = int.Parse(Console.ReadLine());
        var year = int.Parse(Console.ReadLine());
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var size = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        Console.WriteLine($"Name: DSC_{number:d4}.jpg");
        Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hours:d2}:{minutes:d2}");
        if (size < 1024)
        {
            Console.WriteLine($"Size: {size}B");
        }
        else if (size >= 1024 && size <= 1048576)
        {
            Console.WriteLine($"Size: {size/1000}KB");
        }
        else
        {
            Console.WriteLine($"Size: {size / 1000000}MB");
        }
        var text = "";
        if (width == height)
            text = "square";
        else if (width > height)
            text = "landscape";
        else
            text = "portrait";
        Console.WriteLine($"Resolution: {width}x{height} ({text})");
    }
}
