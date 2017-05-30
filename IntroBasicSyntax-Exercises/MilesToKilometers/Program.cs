using System;

class Program
{
    static void Main(string[] args)
    {
        var miles = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:f2}",miles* 1.60934);
    }
}
