﻿using System;

class Program
{
    static void Main(string[] args)
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        for (int i = Math.Min(num1,num2); i <= Math.Max(num1,num2); i++)
        {
            Console.WriteLine(i);
        }
    }
}
