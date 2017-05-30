using System;

class Program
{
    static void Main(string[] args)
    {


        var stringg = Console.ReadLine();
        int n;
        bool isNumeric = int.TryParse(stringg, out n);
        if (isNumeric)
        {
            Console.WriteLine("It is a number.");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

