using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var numeric = Console.ReadLine();
        var n = int.Parse(Console.ReadLine());
        long winner = long.MinValue;
        long max = 0;
        if (numeric == "sbyte")
        {
            max = sbyte.MaxValue;
        }
        else if (numeric == "int")
        {
            max = int.MaxValue;
        }
        else if (numeric == "long")
        {
            max = long.MaxValue;
        }
        //////
        for (int i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            if (number > winner && number <= max)
            {
                winner = number;
            }
        }

        double num = 0;
        if(winner < 0)
        {
            num = sbyte.MinValue;
        }
        else
        {
            num = sbyte.MaxValue;
        }
        var sentence = Math.Ceiling(winner / num);
        if (sentence > 1)
        {
            Console.WriteLine($"Prisoner with id {winner} is sentenced to {sentence} years");
        }
       else
        {
            Console.WriteLine($"Prisoner with id {winner} is sentenced to 1 year");
        }
    }
}
