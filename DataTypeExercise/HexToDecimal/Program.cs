using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var hex = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(hex,16));
    }
}
