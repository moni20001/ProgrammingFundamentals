using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var dict = new SortedDictionary<double, int>();
        foreach (var item in input)
        {
            if (!dict.ContainsKey(item))
            {
                dict[item] = 0;
            }
            dict[item]++;
        }
        
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}