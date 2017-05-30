using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var k = input.Length / 4;
        var firstRowLeft = input.Take(k).Reverse().ToArray();
        var firstRowRight = input.Reverse().Take(k).ToArray();
        var secondRow = input.Skip(k).Take(k * 2).ToArray();
        var firstRow = firstRowLeft.Concat(firstRowRight).ToArray();

        var result = firstRow.Zip(secondRow, (x, y) => x + y).ToList();
        foreach (var item in result)
        {
            Console.Write(item+" ");

        }
        
    }
}
