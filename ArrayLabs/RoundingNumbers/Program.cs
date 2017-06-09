using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        foreach (var item in input)
        {
            Console.WriteLine($"{item} => {Math.Round(item,0,MidpointRounding.AwayFromZero)}");
        }
    }
}
