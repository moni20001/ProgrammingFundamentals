using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        var theByte = Math.Min(a, b);
        var theInt = Math.Max(a, b);
        decimal price =theByte*4 + (theInt*10);
        Console.WriteLine(price);
    }
}
