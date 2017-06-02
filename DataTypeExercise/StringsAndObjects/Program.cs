using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var first = Console.ReadLine();
        var second = Console.ReadLine();
        object concatentaion = first + " " + second;
        Console.WriteLine(concatentaion.ToString());
    }
}

