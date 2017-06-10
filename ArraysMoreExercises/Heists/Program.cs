using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var goldJewels = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var inputLine = Console.ReadLine().Split(' ').ToArray();
        int expences = 0;
        int earning = 0;
        while (!(inputLine[0] == "Jail" && inputLine[1] == "Time"))
        {
            var stringArr = inputLine[0].ToCharArray();
            foreach (var item in stringArr)
            {
                if (item == '%')
                {
                    earning += goldJewels[0];
                }
                if (item == '$')
                {
                    earning += goldJewels[1];
                }
            }
            expences += Convert.ToInt32(inputLine[1]);
            inputLine = Console.ReadLine().Split(' ').ToArray();
        }
        if (earning >= expences)
        {
            Console.WriteLine($"Heists will continue. Total earnings: {Math.Abs(expences - earning)}.");
        }
        else
        {
            Console.WriteLine($"Have to find another job. Lost: {expences-earning}.");
        }
    }
}
