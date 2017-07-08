using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int daysLenght = int.Parse(Console.ReadLine());
        int runnersNumber = int.Parse(Console.ReadLine());
        double averageLaps = double.Parse(Console.ReadLine());
        double lenghtTrack = double.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());
        double moneyDonated = double.Parse(Console.ReadLine());
        int maxRunners = capacity * daysLenght;
        var totalDistance = Math.Min(runnersNumber, capacity * daysLenght) * averageLaps * lenghtTrack;
        double totalKilo = totalDistance / 1000;
        Console.WriteLine($"Money raised: {totalKilo*moneyDonated:f2}");
    }
}
