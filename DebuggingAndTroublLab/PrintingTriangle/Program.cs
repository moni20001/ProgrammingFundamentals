using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        PrintFirstHalf(n);
        PrintLine(1, n);
        PrintLast(n);
    }

    static void PrintLine(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    static void PrintFirstHalf(int end)
    {
        for (int i = 0; i < end; i++)
        {
            PrintLine(1, i);
        }
    }
    static void PrintMiddle(int end)
    {
        for (int i = 1; i <= end; i++)
        {
            Console.Write(i + " ");
        }
    }
    static void PrintLast(int n)
    {
        for (int i = n-1; i >= 0; i--)
        {
            PrintLine(1, i);
        }
    }
}
