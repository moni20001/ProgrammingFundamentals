using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        var text = Console.ReadLine().ToLower().Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var dict = new SortedDictionary<string, int>();
        var list = new List<string>();
        foreach (var word in text)
        {
            if (!dict.ContainsKey(word))
            {
                dict[word] = 0;
            }
            dict[word]++;
            list.Add(word);
        }
        Console.WriteLine(string.Join(", ",list.Where(n => n.Length <5).OrderBy(n => n).Distinct()));
    }
}
