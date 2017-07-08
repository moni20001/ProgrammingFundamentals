using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var beehives = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();
        var hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();
        for (int i = 0; i < beehives.Count; i++)
        {
            if (hornets.Count == 0)
            {
                break;
            }
           
            var hornetPower = hornets.Sum();

            beehives[i] -= hornetPower;
            if (beehives[i] >= hornetPower)
                hornets.RemoveAt(0);
        }
        List<long> aliveBees = new List<long>();
        foreach (var bee in beehives)
        {
                if ((bee > 0))
                {
                    aliveBees.Add(bee);
                }
            
        }
        if (aliveBees.Count > 0)
            Console.WriteLine($"{string.Join(" ", aliveBees)}");
        else
        {
            Console.WriteLine($"{string.Join(" ",hornets)}");
        }
    }
}
