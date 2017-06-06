using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var number = Console.ReadLine();
        Console.WriteLine(Reverse(number));
    }
    public static string Reverse(string number)
    {
        char[] array = number.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}
