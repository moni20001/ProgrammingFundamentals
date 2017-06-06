using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var figure = Console.ReadLine().ToLower();
        if (figure == "triangle")
        {
            Triangle();
        }
        else if (figure == "square")
        {
            Square();
        }
        else if(figure == "rectangle")
        {
            Rectangle();
        }
        else if(figure == "circle")
        {
            Circle();
        }
    }
    public static void Triangle()
    {
        var side = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        Console.WriteLine($"{side*height/2:f2}");
    }
    public static void Square()
    {
        var side = double.Parse(Console.ReadLine());
        Console.WriteLine($"{side*side:f2}");
    }
    public static void Rectangle()
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        Console.WriteLine($"{(width)*(height):f2}");
    }
    public static void Circle()
    {
        var radius = double.Parse(Console.ReadLine());
        Console.WriteLine($"{radius*radius*Math.PI:f2}");
    }
}
