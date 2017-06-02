using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().ToLower();
        if (input == "true")
        {
            Console.WriteLine("Yes");
        }
        else if(input == "false")
        {
            Console.WriteLine("No");
        }
    }
}
