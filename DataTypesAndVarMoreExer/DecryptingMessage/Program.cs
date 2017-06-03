using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var key = int.Parse(Console.ReadLine());
        var n = int.Parse(Console.ReadLine());
        string word = "";
        for (int i = 0; i < n; i++)
        {
            char temp = char.Parse(Console.ReadLine());
            word += Convert.ToChar(temp + key);
        }
        Console.WriteLine(word);
    }
}
