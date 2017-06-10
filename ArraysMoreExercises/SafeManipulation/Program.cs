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
        var command = Console.ReadLine().Split(' ').ToArray();
        while (command[0] != "END")
        {
           
            if (command[0] == "Distinct")
            {
                var input1 = input.Distinct().ToList();
                input = input1;
            }
            else if (command[0] == "Reverse")
            {
                input.Reverse();
            }
            else if (command[0] == "Replace" )
            {
                int row = Convert.ToInt32(command[1]);
                if (row < input.Count && row >= 0)
                {
                    input[row] = command[2];
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
               
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            command = Console.ReadLine().Split(' ').ToArray();
        }
        Console.WriteLine(string.Join(", ",input));
    }
}
