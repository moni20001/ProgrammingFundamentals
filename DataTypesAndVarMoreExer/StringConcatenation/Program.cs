using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        char delimiter = char.Parse(Console.ReadLine());
        string word = "";
        var OddOrEven = Console.ReadLine();
        var n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            var input = Console.ReadLine();
            if(OddOrEven == "odd")
            {
                if(i%2 == 1)
                {
                    word += input;
                    word += delimiter;
                }
            }
            else if(OddOrEven == "even")
            {
                if (i % 2 == 0)
                {
                    word += input;
                    word += delimiter;
                }
            }
          
        }
        word = word.Remove(word.Length-1);
        Console.WriteLine(word);
    }
}
