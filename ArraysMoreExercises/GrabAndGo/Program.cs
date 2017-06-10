using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long num = long.Parse(Console.ReadLine());
        long sum = 0;
        bool found = false;
        for (long i = numbers.Length-1; i > 0; i--)
        {
            if (numbers[i] == num)
            {
                found = true;
            }
            if (found == true)
            {
                sum += numbers[i-1];
            }
        }
        if (found == false)
        {
            Console.WriteLine("No occurrences were found!");
        }
        else
        {
            Console.WriteLine(sum);
        }
       
    }
}
