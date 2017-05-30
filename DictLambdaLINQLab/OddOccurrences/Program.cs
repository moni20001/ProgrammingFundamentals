using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine().ToLower().Split(' ');
        var dict = new Dictionary<string, int>();
        foreach (var item in text)
        {
            if (!dict.ContainsKey(item))
            {
                dict[item] = 0;
            }
            dict[item]++;
        }
        var result = new List<string>();
        foreach (var item in dict)
        {
            if(item.Value % 2 == 1)
            {
                result.Add(item.Key);
            }
        }

        Console.WriteLine(string.Join(", ", result));
    }
}
