using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        var num3 = int.Parse(Console.ReadLine());
        var number = GetMin(num1, num2);
        var finalNumber = GetMin(number, num3);
        Console.WriteLine(finalNumber);
    }
    static int GetMin(int firstNumber,int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}
