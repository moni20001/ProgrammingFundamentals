using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var input = int.Parse(Console.ReadLine());
        string hexValue = input.ToString("X");
        Console.WriteLine(hexValue);
        Console.WriteLine(Convert.ToString(input, 2));
    }
}
