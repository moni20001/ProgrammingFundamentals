using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var number = double.Parse(Console.ReadLine());
        var power = int.Parse(Console.ReadLine());
        var mathPower = CalculateMathPower(number, power);
        Console.WriteLine(mathPower);
    }

    public static double CalculateMathPower(double number, int power)
    {
        var answer = Math.Pow(number, power);
        return answer;
    }
}
