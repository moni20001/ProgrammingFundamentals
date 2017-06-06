using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(isPrime(n));
    }
    static bool isPrime(long n)
    {
        if (n == 0) return false;
        if (n == 1) return false;
        if (n == 2) return true;
        var boundary = (int)Math.Floor(Math.Sqrt(n));
        for (int i = 2; i <= boundary; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
