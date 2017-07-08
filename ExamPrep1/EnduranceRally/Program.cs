using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var names = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
        var row = Console.ReadLine().Split(' ').Where(a => a.Length > 0).Select(p => (double.Parse(p) * -1)).ToArray();
        var positiveIndexes = Console.ReadLine().Split(' ').Where(a => a.Length>0).Select(int.Parse).ToArray();
        var dict = new Dictionary<string,double>();
        foreach (var name in names)
        {
            var nameChar = name.ToCharArray();
         dict.Add(name ,Convert.ToInt32(nameChar[0]));
        }

        foreach (var index in positiveIndexes)
        {
            if(index>=0 && index <= row.Length)
                row[index] *= -1;
        }
        foreach (var name in names)
        {
            var fuel = (double)name[0];
            var index = 0;
            foreach (var r in row)
            {
                fuel += r;
                if (fuel < 0)
                {
                    Console.WriteLine($"{name} - reached {index}");
                    break;
                }
                index++;
            }
            if (fuel >= 0)
            {
                Console.WriteLine($"{name} - fuel left {fuel:f2}");
            }
            
        }
    }
}

