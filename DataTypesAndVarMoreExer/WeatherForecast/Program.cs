using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        sbyte a;
        int b;
        long c;

        if(sbyte.TryParse(input,out a) == true)
        {
            Console.WriteLine("Sunny");
        }
        else if(int.TryParse(input,out b) == true)
        {
            Console.WriteLine("Cloudy");
        }
        else if (long.TryParse(input, out c) == true)
        {
            Console.WriteLine("Windy");
        }
        else
        {
            Console.WriteLine("Rainy");
        }
    }
}
