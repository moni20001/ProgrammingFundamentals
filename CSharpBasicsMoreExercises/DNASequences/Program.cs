using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var sum = int.Parse(Console.ReadLine());
        var dict = new Dictionary<int, string>();
        dict[1] = "A";
        dict[2] = "C";
        dict[3] = "G";
        dict[4] = "T";
        var counter = 0;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                for (int s = 1; s <= 4; s++)
                {
                   
                        if (i + j + s >= sum)
                        {
                            Console.Write($"O{dict[i]}{dict[j]}{dict[s]}O ");
                        }
                        else
                        {
                            Console.Write($"X{dict[i]}{dict[j]}{dict[s]}X ");
                        }
                    counter++;
                    if(counter%4 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
