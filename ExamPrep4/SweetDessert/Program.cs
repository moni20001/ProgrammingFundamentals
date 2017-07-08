using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double cash = double.Parse(Console.ReadLine());
        int guests = int.Parse(Console.ReadLine());
        double priceBanana = double.Parse(Console.ReadLine());
        double priceEggs = double.Parse(Console.ReadLine());
        double priceBerries = double.Parse(Console.ReadLine());
        while (guests % 6 != 0)
        {
            guests++;
        }
        int portions = guests / 6;
        double forPay = (portions * (2 * priceBanana)) + (portions * (4 * priceEggs)) +( portions * (0.2 * priceBerries));
        if (cash >= forPay)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {forPay:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(cash-forPay):f2}lv more.");
        }
    }
}
