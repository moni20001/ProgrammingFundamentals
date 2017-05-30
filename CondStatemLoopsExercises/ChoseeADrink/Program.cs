using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        string text = "";
        if (input == "Athlete")
            text = "Water";
        else if (input == "Businessman" || input =="Businesswoman")
            text = "Coffee";
        else if (input == "SoftUni Student")
            text = "Beer";
        else
            text = "Tea";
        Console.WriteLine(text);
    }
}
