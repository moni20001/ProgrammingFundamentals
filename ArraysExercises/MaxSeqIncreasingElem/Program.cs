using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int start = 1;
        int count = 0;
        int max = 0;
        for (int i = 1; i <= arr.Length-1; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                count++;
                if (count > max)
                {
                    max = count;
                    start = i - count;
                }
            }
            else
            {
                count = 0;
            }
        }
        for (int i = start ; i <= start + max ; i++)
        {
            Console.Write((arr[i] + " "));
        }
        Console.WriteLine();
    }
}
