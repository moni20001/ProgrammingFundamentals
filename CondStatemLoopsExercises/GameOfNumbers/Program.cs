using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        var magic = int.Parse(Console.ReadLine());
        bool ready = false;
        var counter = 0;
        for (int i = n; i <= m; i++)
        {
            for (int j = n; j <= m; j++)
            {
                
                if(i+j == magic && ready == false)
                {
                    Console.WriteLine($"Number found! {j} + {i} = {magic}");
                    ready = true;

                }else
                {
                    counter++;
                }
            }
        }
        if(ready == false)
        {
            Console.WriteLine($"{counter} combinations - neither equals {magic}");

        }
    }
}
