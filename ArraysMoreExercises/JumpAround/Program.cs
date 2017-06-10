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
        int currIndex = 0;
        int currValue = 0;
        var sum = 0;

        while (true)
        {
            currValue = numbers[currIndex];
            sum += currValue;
            if (currIndex + currValue >= numbers.Length)
            {
                currIndex -= currValue;
                if (currIndex <= 0)
                {
                    break;
                }

            }
            else
            {
                currIndex += currValue;
            }
        }
        Console.WriteLine(sum);
    }
}
