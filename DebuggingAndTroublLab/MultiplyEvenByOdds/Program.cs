using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMultiple(Math.Abs(number)));
    }
    private static int GetMultiple(int n)
    {
        int sumEvens = GetSumOfEvenDigits(n);
        int sumOdds = GetSumOfOddsDigits(n);
        return sumEvens * sumOdds;
    }

    private static int GetSumOfEvenDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int lastDigit = n % 10;
            if (lastDigit % 2 == 0)
            {
                sum += lastDigit;
            }
            n /= 10;
        }
        return sum;
    }

    private static int GetSumOfOddsDigits(int n)
    {
        int sum = 0;
        while (n>0)
        {
            int lastDigit = n % 10;
            if(lastDigit%2 != 0)
            {
                sum += lastDigit;
            }
            n /= 10;
        }
        return sum;
    }
}
