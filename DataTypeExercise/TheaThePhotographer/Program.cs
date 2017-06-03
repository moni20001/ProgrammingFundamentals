using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var n = double.Parse(Console.ReadLine());
        var timeForOne = double.Parse(Console.ReadLine());
        var goodPercentage = double.Parse(Console.ReadLine());
        var timeForUpload = double.Parse(Console.ReadLine());
        double usefullPictures = Math.Ceiling(n*goodPercentage /100);
        var time = n * timeForOne;
        double filterAndUpload = Math.Ceiling(usefullPictures * timeForUpload);
        long finalTime = Convert.ToInt64(filterAndUpload +time);
        TimeSpan t = TimeSpan.FromSeconds(finalTime);
        Console.WriteLine(t.ToString(@"d\:hh\:mm\:ss"));
    }
}
