using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine().ToUpper();
        Regex regex = new Regex( @"([(!-\-)(:-})]+)(\d)");
        var matches = regex.Matches(text);
        StringBuilder build = new StringBuilder();
        foreach (Match match in matches)
        {
            var str = match.Groups[0].Value;
            for (int i = 0; i < int.Parse(match.Groups[2].Value); i++)
            {
                build.Append(str);
            }
        }
        Console.WriteLine($"Unique symbols used: {build.ToString().Distinct().ToArray().Sum()}");
        Console.WriteLine(build);
    }
}
