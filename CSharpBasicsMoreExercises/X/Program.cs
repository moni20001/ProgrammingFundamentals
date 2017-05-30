using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var startingSpaces = n - 2;
        var startLeft = 0;
        var startRight = 0;
        //top
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(@"{0}x{1}x{2}", new string(' ', startLeft), new string(' ', startingSpaces), new string(' ', startRight));
            startLeft++;
            if (startingSpaces >= 2)
            {
                startingSpaces -= 2;
            }

            if (startRight > 0)
            {
                startRight++;
            }

        }
        Console.WriteLine(@"{0}x{0}", new string(' ', (n - 1) / 2));

        //bot
        startLeft--;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(@"{0}x{1}x{2}", new string(' ', startLeft), new string(' ', startingSpaces), new string(' ', startRight));
            startLeft--;

            startingSpaces += 2;


            if (startRight > 0)
            {
                startRight--;
            }
        }
    }
}
