using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var calories = 0;
        for (int i = 0; i < n; i++)
        {
            var pizza = Console.ReadLine().ToLower();
            if (pizza == "cheese")
                calories += 500;
            if (pizza == "tomato sauce")
                calories += 150;
            if (pizza == "salami")
                calories += 600;
            if (pizza == "pepper")
                calories += 50;
        }
        Console.WriteLine($"Total calories: {calories}");
    }
}
