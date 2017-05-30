using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var tax = int.Parse(Console.ReadLine());
        var price = 0.0;
        string text = "";
        if (input == "Athlete")
        {
            text = "Water";
            price = 0.70;
        }
        else if (input == "Businessman" || input == "Businesswoman")
        {
            text = "Coffee";
            price = 1.00;
        }
        else if (input == "SoftUni Student")
        {
            text = "Beer";
            price = 1.70;
        }

        else
        {
            text = "Tea";
            price = 1.20;
        }

        Console.WriteLine($"The {input} has to pay {price*tax:f2}.");
    }
}
