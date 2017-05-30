using System;

class Program
{
    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        bool ready = false;
        for (int i = a; i <= b; i++)
        {
            for (int j = a; j <= b; j++)
            {
                for (int m = a; m <= b; m++)
                {
                    for (int s = a; s <= b; s++)
                    {
                        for (int v = a; v <= b; v++)
                        {
                            if (i < j && j < m && m < s && s < v)
                            {
                                Console.WriteLine($"{i} {j} {m} {s} {v}");
                                ready = true;
                            }
                            
                        }
                    }
                }
            }
        }
        if(ready == false)
        {
            Console.WriteLine("No");
        }
    }
}
