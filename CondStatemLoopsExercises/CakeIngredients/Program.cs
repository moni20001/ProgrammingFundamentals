using System;

class Program
{
    static void Main(string[] args)
    {
        var ingredient = Console.ReadLine();
        var count = 0;
        while(ingredient != "Bake!")
        {
            count++;
            Console.WriteLine($"Adding ingredient {ingredient}.");
            ingredient = Console.ReadLine();
            
        }
        Console.WriteLine("Preparing cake with {0} ingredients.",count);
    }
}
