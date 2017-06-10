using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var igredients = Console.ReadLine().Split(' ').ToArray();
        int number = int.Parse(Console.ReadLine());
        var usedIngre = new List<string>();
        int count = 0;
        foreach (var igre in igredients)
        {
            if (igre.Length == number)
            {
                Console.WriteLine($"Adding {igre}.");
                usedIngre.Add(igre);
                count++;
            }
            if (count==10)
            {
                break;
            }
        }
        Console.WriteLine($"Made pizza with total of {count} ingredients.");
        Console.WriteLine($"The ingredients are: {string.Join(", ",usedIngre)}.");
    }
}
