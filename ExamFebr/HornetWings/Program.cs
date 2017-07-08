using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        var distance = (n / 1000) * m;
        Console.WriteLine($"{distance:f2} m.");
        var breaks = (int)(n / p) * 5;
        var seconds = n / 100;
        decimal sec = (int)breaks + (int)seconds;
        Console.WriteLine($"{(int)(seconds+breaks)} s.");
         

    }
}
