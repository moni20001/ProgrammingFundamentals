using System;
class Program
{
    static void Main(string[] args)
    {
        var first = char.Parse(Console.ReadLine());
        var second = char.Parse(Console.ReadLine());
        var magic = char.Parse(Console.ReadLine());

        for (int i = first; i <= second; i++)
        {
            for (int j = first; j <= second; j++)
            {
                for (int m = first; m <= second; m++)
                {
                    if(i != magic && j!=magic && m!= magic)
                    {
                        Console.Write($"{Convert.ToChar(i)}{Convert.ToChar(j)}{Convert.ToChar(m)} ");
                    }
                }
            }

        }
    }
}
