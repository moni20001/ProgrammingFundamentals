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
        var items = int.Parse(Console.ReadLine());
        var price = 0.0;
        for (int i = 0; i < items; i++)
        {
            var itemName = Console.ReadLine();
            var itemPrice = double.Parse(Console.ReadLine());
            var itemAmount = int.Parse(Console.ReadLine());
            
            if (itemAmount>=2)
            {
                Console.WriteLine($"Adding {itemAmount} {itemName}s to cart.");
            }
            else
            {
                Console.WriteLine($"Adding {itemAmount} {itemName} to cart.");
            }
            price += itemAmount * itemPrice;
        }
        Console.WriteLine($"Subtotal: ${price:f2}");
        if (budget<price)
        {
            Console.WriteLine($"Not enough. We need ${Math.Abs(budget-price):f2} more.");
        }
        else
        {
            Console.WriteLine($"Money left: ${Math.Abs(budget-price):f2}");
        }
    }
}
