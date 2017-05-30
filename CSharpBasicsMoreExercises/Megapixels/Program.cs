using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        double megaPixels = (width * height) / 1000000;
        Console.WriteLine($"{width}x{height} => {Math.Round((width * height) / 1000000, 1,MidpointRounding.AwayFromZero)}MP");
    }
}
