using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 2; i <= number; i++)
        {
            bool isPrime = true;
            for (int s = 2; s <= Math.Sqrt(i); s++)
            {
                if (i % s == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {isPrime}");
        }

    }
}
