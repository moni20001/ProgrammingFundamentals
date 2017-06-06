﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        var firstLineLenght = lineLength(x1, y1, x2, y2);

        var secondLineLenght = lineLength(x3, y3, x4, y4);

        if (firstLineLenght >= secondLineLenght)
        {
            bool first = firstCloser(x1, y1, x2, y2);
            if (first == true)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
        else
        {
            bool first = firstCloser(x3, y3, x4, y4);
            if (first == true)
            {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
            else
            {
                Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
        }
    }
    static double GetDistance(double firstNum, double secondNum)
    {
        double answer = Math.Sqrt(Math.Pow(firstNum, 2) + Math.Pow(secondNum, 2));
        return answer;
    }
    private static double lineLength(double x1, double y1, double x2, double y2)
    {
        double lineLength = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        return lineLength;
    }
    public static bool firstCloser(double x1,double y1, double x2, double y2)
    {
        double first = Math.Sqrt(x1 * x1 + y1 * y1);
        double second = Math.Sqrt(x2 * x2 + y2 * y2);
        if (first <= second)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
