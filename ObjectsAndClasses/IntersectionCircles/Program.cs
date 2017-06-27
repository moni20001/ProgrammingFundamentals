using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circle
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Radius { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        var first = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        var second = Console.ReadLine().Split( ' ').Select(double.Parse).ToList();
        Circle firstCircle = new Circle();
        Circle secondCircle =new Circle();
        firstCircle.Radius = first[2];
        firstCircle.Y = first[1];
        firstCircle.X = first[0];

        secondCircle.Radius = second[2];
        secondCircle.Y = second[1];
        secondCircle.X = second[0];
        bool intercept= Intercept(firstCircle, secondCircle);
        if(intercept == true)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
    static bool Intercept(Circle c1,Circle c2)
    {

        double deltaX = c1.X - c2.X;
        double deltaY=c1.Y - c2.Y;

        var distance = Math.Sqrt(Math.Pow((deltaX), 2) + Math.Pow(deltaY, 2));
        if(distance> c1.Radius + c2.Radius)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
