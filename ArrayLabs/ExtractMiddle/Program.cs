using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        if (n.Length == 1)
        {
            Console.WriteLine($"{{ {n[0]} }}");
        }
        else if(n.Length%2 == 0)
        {
            int[] numbers = { n[n.Length / 2 - 1], n[n.Length / 2] };
            var result = string.Join(", ", numbers);
           
            Console.WriteLine($@"{{ {result} }}");
        }
        else if (n.Length % 2 == 1)
        {
            int[] numbers = { n[n.Length/2-1],n[n.Length/2],n[n.Length/2+1]};
            var result = string.Join(", ", numbers);
            Console.WriteLine($@"{{ {result} }}");
        }
    }
}
