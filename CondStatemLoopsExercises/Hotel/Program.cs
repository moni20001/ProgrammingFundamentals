using System;

class Program
{
    static void Main(string[] args)
    {
        var month = Console.ReadLine();
        var nights = int.Parse(Console.ReadLine());
        double studio = 0.0;
        double dvoino = 0.0;
        double suite = 0.0;
        var nightsStudio = 0;
        if (month == "May" || month == "October")
        {
            studio = 50;
            dvoino = 65;
            suite = 75;
            if (nights > 7 && (month == "September" || month == "October"))
                nightsStudio = nights - 1;
            if (nights > 7)
                studio = 0.95 * studio;
        }

        if (month == "June" || month == "September")
        {
            studio = 60;
            dvoino = 72;
            suite = 82;
            if (nights > 7 && (month == "September" || month == "October"))
                nightsStudio = nights - 1;
            if (nights > 14)
                dvoino = 0.90 * dvoino;
        }
        if (month == "July" || month == "August" || month == "December")
        {
            studio = 68;
            dvoino = 77;
            suite = 89;
            
            if (nights > 14)
            {
                suite = suite * 0.85;
            }

        }
        if(nightsStudio > 1)
        {
            Console.WriteLine($"Studio: {studio * nightsStudio:f2} lv.");
        }
        else
        {
            Console.WriteLine($"Studio: {studio * nights:f2} lv.");
        }
       
        Console.WriteLine($"Double: {dvoino * nights:f2} lv.");
        Console.WriteLine($"Suite: {suite * nights:f2} lv.");
    }
}
