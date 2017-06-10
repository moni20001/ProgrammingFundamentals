using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var len = 1;
        int start = 0;
        int count = 0;
        int max = 0;
        for (int i = 0; i < input.Length-1; i++)
        {
            if (input[i] == input[i + 1])
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
        for (int i = start+1; i <= start+max+1; i++)
        {
                Console.Write((input[i]+" "));
        }
        Console.WriteLine(  );
    }
}
