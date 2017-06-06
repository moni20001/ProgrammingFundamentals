using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var baseTriangle = double.Parse(Console.ReadLine());
        var heightTriangle = double.Parse(Console.ReadLine());
        var area = CalculateTriangleArea(baseTriangle, heightTriangle);
        Console.WriteLine(area);
    }

    private static object CalculateTriangleArea(double baseTriangle, double heightTriangle)
    {
        return baseTriangle * heightTriangle / 2;
    }
}

