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
        bool itsThere = false;
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i+1; j < input.Length; j++)
            {
                int number = input[i] + input[j];
                if (input.Contains(number) == true && i != j)
                {
                    Console.WriteLine($"{input[i]} + {input[j]} == {number}");
                    itsThere = true;
                }
            }
        }
        if (itsThere == false)
        {
            Console.WriteLine("No");
        }
    }
}
