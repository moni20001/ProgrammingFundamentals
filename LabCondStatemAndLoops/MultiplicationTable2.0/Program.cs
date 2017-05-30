using System;
class Program
{
    static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());

        for (int i = n; i <= 10; i++)
        {
            Console.WriteLine($"{num} X {i} = {i * num}");

        }

        if (n > 10)
        {
            Console.WriteLine($"{num} X {n} = {num * n}");

        }
    }
}
