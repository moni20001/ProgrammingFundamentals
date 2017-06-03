using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var word = 0;
        for (int i = 0; i < n; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            word += letter;
        }
        Console.WriteLine($"The sum equals: {word}");
    }
}

