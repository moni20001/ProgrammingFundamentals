using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var quantity = double.Parse(Console.ReadLine());
        if(input == "miles")
        {
            Console.WriteLine($"{quantity} miles = {quantity*1.6:f2} kilometers");
        }
        else if (input == "inches")
        {
            Console.WriteLine($"{quantity} inches = {quantity * 2.54:f2} centimeters");
        }
        else if (input == "feet")
        {
            Console.WriteLine($"{quantity} feet = {quantity * 30:f2} centimeters");
        }
        else if(input == "yards")
        {
            Console.WriteLine($"{quantity} yards = {quantity*0.91:f2} meters");
        }
        else if(input == "gallons")
        {
            Console.WriteLine($"{quantity} gallons = {quantity * 3.8:f2} liters");
        }
    }
}
