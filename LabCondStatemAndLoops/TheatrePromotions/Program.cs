using System;

class Program
{
    static void Main(string[] args)
    {

        var type = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var tr = false;
        if (type == "Weekday")
        {
            if (age >= 0 && age <= 18) { Console.WriteLine("12$");tr = true; }
            if (age > 18 && age <= 64) { Console.WriteLine("18$"); tr = true; }
            if (age > 64 && age <= 122) { Console.WriteLine("12$"); tr = true; }
        }
        else if(type == "Weekend")
        {
            if (age >= 0 && age <= 18) { Console.WriteLine("15$"); tr = true; }
            if (age > 18 && age <= 64) { Console.WriteLine("20$"); tr = true; }
            if (age > 64 && age <= 122) { Console.WriteLine("15$"); tr = true; }
        }
        else if(type == "Holiday")
        {
            if (age >= 0 && age <= 18) { Console.WriteLine("5$"); tr = true; }
            if (age > 18 && age <= 64) { Console.WriteLine("12$"); tr = true; }
            if (age > 64 && age <= 122) { Console.WriteLine("10$"); tr = true; }
        }
       if(tr == false)
        {
            Console.WriteLine("Error!");
        }
    }
}
