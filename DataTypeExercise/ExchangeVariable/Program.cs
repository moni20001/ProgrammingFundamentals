using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var firstNum = int.Parse(Console.ReadLine());
        var secondNum = int.Parse(Console.ReadLine());
        int thirdNum;
        Console.WriteLine($"Before:\na = {firstNum}\nb = {secondNum} ");
        thirdNum = firstNum;
        firstNum = secondNum;
        secondNum = thirdNum;
        Console.WriteLine($"After:\na = {firstNum}\nb = {secondNum} ");
    }
}

