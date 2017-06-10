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
        var dict = new Dictionary<int, int>();
        int max = 0;
        int number = 0;
        foreach (var item in input)
        {
            if (!dict.ContainsKey(item))
            {
                dict[item] = 0;
            }
            dict[item]++;
        }
        dict.OrderBy(x => x.Value);
        for (int i = 0; i <= input.Length - 1; i++)
        {
            if (dict[input[i]] == dict.Values.Max())
            {
                max = input[i];
                break;
                
            }
        }
        Console.WriteLine(max);
    }
}