﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var bpm = double.Parse(Console.ReadLine());
        var num = double.Parse(Console.ReadLine());
        var bars = num / 4;
        
        var seconds = num *60.0 / bpm;
        var minutes = (int)seconds/60;
        seconds -= minutes * 60;
        Console.WriteLine($"{Math.Round(bars,1)} bars - {minutes}m {Math.Floor(seconds)}s");
    }
}
