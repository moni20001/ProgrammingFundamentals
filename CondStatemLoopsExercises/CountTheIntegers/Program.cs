using System;

class Program
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine();
        var count = 0;
        int myInt;
        bool isNumerical = int.TryParse(text, out myInt);
        while (isNumerical != false)
        {
            count++;
            text = Console.ReadLine();
           
            isNumerical = int.TryParse(text, out myInt);
        }
        Console.WriteLine(count);
    }
}
