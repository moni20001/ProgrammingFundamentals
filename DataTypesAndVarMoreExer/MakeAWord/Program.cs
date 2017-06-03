using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        string word = "";
        for (int i = 0; i < n; i++)
        {
            char charachter = char.Parse(Console.ReadLine());
            word += charachter;
        }
        Console.WriteLine($"The word is: {word}");
    }
}
