using System;

class Program
{
    static void Main(string[] args)
    {
        var product = Console.ReadLine();
        var volume = double.Parse(Console.ReadLine());
        var energy = double.Parse(Console.ReadLine());
        var sugar = double.Parse(Console.ReadLine());
        Console.WriteLine($"{volume}ml {product}:");
        Console.WriteLine($"{energy*volume/100}kcal, {sugar*volume/100}g sugars");
    }
}
