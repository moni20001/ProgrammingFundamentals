using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Console.WriteLine("Min = "+numbers.Min());
        Console.WriteLine("Max = "+numbers.Max());
        Console.WriteLine("Sum = "+numbers.Sum());
        Console.WriteLine("Average = "+numbers.Average());
    }
}
