using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var budget = double.Parse(Console.ReadLine());
        var dict = new Dictionary<string, double>();
        dict["OutFall 4"] = 39.99;
        dict["CS: OG"] = 15.99;
        dict["Zplinter Zell"] = 19.99;
        dict["Honored 2"] = 59.99;
        dict["RoverWatch"] = 29.99;
        dict["RoverWatch Origins Edition"] = 39.99;
        var price = 0.0;
        double balance = budget;
        var command = Console.ReadLine();
        while (command != "Game Time")
        {
            if (!dict.ContainsKey(command))
            {
                Console.WriteLine("Not Found");
            }
            else if (dict[command] <= balance)
            {
                Console.WriteLine($"Bought {command}");
                balance -= dict[command];
                price += dict[command];
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            command = Console.ReadLine();
        }
        if (budget - price > 0)
            Console.WriteLine($"Total spent: ${price:f2}. Remaining: ${budget - price:f2}");
        else
            Console.WriteLine("Out of money!");

    }
}
