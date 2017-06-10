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
        var quantity = Console.ReadLine().Split(' ').ToArray();
        var prices = Console.ReadLine().Split(' ').ToArray();
        var command = Console.ReadLine();
        while (!(command == "done"))
        {
            int index = Array.IndexOf(ingredients, command);
            Console.WriteLine($"{command} costs: {prices[index]}; Available quantity: {quantity[index]}");
            command = Console.ReadLine();
        }
    }
}
