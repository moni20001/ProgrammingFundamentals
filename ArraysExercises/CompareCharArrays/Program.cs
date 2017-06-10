using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        var second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        string[] array = { string.Join("", first), string.Join("", second) };
        Array.Sort(array);
        Console.WriteLine(string.Join("\n",array));
    }
}
