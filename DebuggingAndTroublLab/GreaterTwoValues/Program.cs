using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var type = Console.ReadLine();
        var firstInput = Console.ReadLine();
        var secondInput = Console.ReadLine();
        if (type == "int")
        {
            var bigger = GetBiggerInteger(int.Parse(firstInput), int.Parse(secondInput));
            Console.WriteLine(bigger);
        }
        else if(type == "string")
        {
            var bigger = GetBiggerString(firstInput, secondInput);
            Console.WriteLine(bigger);
        }
        else if(type == "char")
        {
            var bigger = GetBiggerChar(char.Parse(firstInput), char.Parse(secondInput));
            Console.WriteLine(Convert.ToChar(bigger));
        }
    }

    private static object GetBiggerChar(char v1, char v2)
    {
        return Math.Max(v1, v2);
    }

    private static object GetBiggerString(string firstInput, string secondInput)
    {
        if (firstInput.CompareTo(secondInput) >= 0)
        {
            return firstInput;
        }
        else
        {
            return secondInput;
        }
    }

    private static object GetBiggerInteger(int first,int second)
    {
        return Math.Max(first, second);
    }
}
