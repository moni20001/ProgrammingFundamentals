using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var x1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var firstDistance = GetDistance(x1, x2);
        var secondDistance = GetDistance(y1, y2);
        if (firstDistance <= secondDistance)
        {
            Console.WriteLine($"({x1}, {x2})");
        }
        else
        {
            Console.WriteLine($"({y1}, {y2})");
        }
    }
    static double GetDistance(double firstNum, double secondNum)
    {
        double answer = Math.Sqrt(Math.Pow(firstNum,2)+Math.Pow(secondNum,2));
        return answer;
    }

}
