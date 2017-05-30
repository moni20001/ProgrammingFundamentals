using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        var sum = 0;
        var counter = 0;
        var max = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= m; j++)
            {
                if (sum <= max)
                {
                    sum += 3 * (i * j);
                    counter++;
                }
               
            }
        }
        Console.WriteLine($"{counter} combinations");
        if(sum >= max)
            Console.WriteLine($"Sum: {sum} >= {max}");
        else
        {
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
