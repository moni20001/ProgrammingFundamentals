﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        Console.WriteLine(string.Join(" ",input.Reverse()));
    }
}
