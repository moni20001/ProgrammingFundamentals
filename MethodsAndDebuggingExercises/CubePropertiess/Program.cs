using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var side = double.Parse(Console.ReadLine());
        var parameter = Console.ReadLine();
        if(parameter == "area")
        {
            Console.WriteLine($"{6*Math.Pow(side,2):f2}");
        }
        else if(parameter=="volume")
        {
            Console.WriteLine($"{Math.Pow(side,3):f2}");
        }
        else if(parameter == "face")
        {
            Console.WriteLine($"{Math.Sqrt(2*Math.Pow(side,2)):f2}");
        }
        else if(parameter == "space")
        {
            Console.WriteLine($"{Math.Sqrt(3 * Math.Pow(side, 2)):f2}");
        }
    }
}
