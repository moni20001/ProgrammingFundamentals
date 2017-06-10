using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var ingredients = Console.ReadLine().Split(' ').ToArray();
        var quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        var prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        var command = Console.ReadLine().Split(' ').ToArray();
        while (!(command[0] == "done"))
        {
            long index = Array.IndexOf(ingredients, command[0]);
            if ((index >= quantity.Length) || (quantity[index] < long.Parse(command[1])))
            {
                Console.WriteLine($"We do not have enough {ingredients[index]}");
            }
            else
            {
                Console.WriteLine(
                    $"{command[0]} x {command[1]} costs {Convert.ToDecimal(command[1]) * prices[index]:f2}");

                quantity[index] -= Convert.ToInt64(command[1]);
            }

            command = Console.ReadLine().Split(' ').ToArray();
        }
    }
}