using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        int a;
        char b;
        if (int.TryParse(input, out a) == true)
        {
            Console.WriteLine("digit");
        }
        else if (input == "a" || input =="e" || input == "i" || input == "o" || input == "u")
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}
