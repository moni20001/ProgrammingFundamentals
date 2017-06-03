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
        string winner = "";
        double maxVol = 0;
        for (int i = 0; i < n; i++)
        {
            var model = Console.ReadLine();
            var radius = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var volume = Math.PI * (radius * radius) * height;
            if(volume > maxVol)
            {
                winner = "";
                winner += model;
                maxVol = volume;
            }
        }
        Console.WriteLine(winner);
    }
}
