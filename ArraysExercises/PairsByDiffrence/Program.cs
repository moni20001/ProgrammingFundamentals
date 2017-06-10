using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var diff = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i <= numbers.Length-1; i++)
        {
            for (int j = i+1; j <= numbers.Length-1; j++)
            {
                if (numbers[i] - numbers[j] == diff || numbers[j] - numbers[i] == diff)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }
}
