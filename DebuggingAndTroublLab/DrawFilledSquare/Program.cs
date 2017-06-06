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
        PrintLastFirst(n);
        for (int i = 0; i < n-2; i++)
        {
            PrintMiddleRow(n);
        }
        
        PrintLastFirst(n);
    }
    static void PrintLastFirst(int n)
    {
        Console.WriteLine(@"{0}",new string('-',n*2));
    }
    static void PrintMiddleRow(int n)
    {
        Console.Write('-');
        string dash = @"\/";
        for (int i = 0; i < n-1; i++)
        {
            Console.Write(dash);
        }
        Console.WriteLine('-');
    }
}

