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
        Console.WriteLine(Fib(n)); 
    }

    private static int Fib(int n)
    {
        int[] list = new int[n+1]; 
        if(n == 0)
        {
            return 1;
        }
        else if(n == 1)
        {
            return 1;
        }
        list[0] = 1;
        list[1] = 1;
        list[2] = 2;
        for (int i = 3; i <= n; i++)
        {
            list[i] = (list[i - 1] + list[i - 2]);
        }
        int answer = list[n];
        return answer;
    }
}
