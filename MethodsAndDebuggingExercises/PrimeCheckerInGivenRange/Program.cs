using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    
    static void Main(string[] args)
    {
        long n1 = long.Parse(Console.ReadLine());
        long n2 = long.Parse((Console.ReadLine()));
        var list = FindPrimes(n1, n2);
        Console.WriteLine(string.Join(", ",list));
        
    }
    static List<long> FindPrimes(long startNum, long endNum)
    {
        var list = new List<long>();
        for (long i = startNum; i <= endNum; i++)
        {
            if (isPrime(i) == true)
            {
                list.Add(i);
            }
        }
        return list;
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
