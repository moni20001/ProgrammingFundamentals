using System;

class Program
{
    static void Main(string[] args)
    {
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        minutes = minutes + 30;
        if (minutes >= 59)
        {
            hours++;
            minutes = 60 - minutes;
        }
        if (hours >= 24)
        {
            hours = 0 + (hours - 24);
        }

        minutes = Math.Abs(minutes);
         Console.WriteLine($"{hours}:{minutes:D2}");
        
    }
}
