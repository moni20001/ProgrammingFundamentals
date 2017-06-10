using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().ToCharArray();
        foreach (var item in input)
        {
            Console.WriteLine($"{Convert.ToChar(item)} -> {Convert.ToInt32(item)-97}");
        }
    }
}
