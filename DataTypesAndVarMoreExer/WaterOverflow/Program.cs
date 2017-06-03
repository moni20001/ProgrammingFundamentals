using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int waterCapacity = 255;
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = int.Parse(Console.ReadLine());
            if (input > waterCapacity)
            {
                Console.WriteLine("Insufficient capacity!");
                
            }
            else
            {
                waterCapacity -= input;
            }
           

        }
        Console.WriteLine(Math.Abs(255 -waterCapacity));
    }
}
