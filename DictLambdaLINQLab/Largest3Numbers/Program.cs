using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .OrderByDescending(x => x)
            .Take(3)
            ;
        foreach (var item in input)
        {
            Console.Write(item+" ");
        }
    }
}
