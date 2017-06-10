using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ').ToList();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var command = Console.ReadLine().Split().ToArray();
            if (command[0] == "Distinct")
            {
               var input1 = input.Distinct().ToList();
                input = input1;
            }
            else if (command[0] == "Reverse")
            {
                input.Reverse();
            }
            else if (command[0] == "Replace")
            {
                int row = Convert.ToInt32(command[1]);
                input[row] = command[2];
            }
        }
        Console.WriteLine(string.Join(", ",input));
    }
}
