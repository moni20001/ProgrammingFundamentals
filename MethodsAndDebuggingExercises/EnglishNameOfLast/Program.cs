using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var number = Console.ReadLine();
        Console.WriteLine(GetLastDigit(number));
    }
    static string GetLastDigit(string number)
    {
        string answer = "";
        var lastDigit = number.Last();
        switch (lastDigit)
        {
            case '1':
                answer = "one";
                break;
            case '2':
                answer = "two";
                break;
            case '3':
                answer = "three";
                break;
            case '4':
                answer = "four";
                break;
            case '5':
                answer = "five";
                break;
            case '6':
                answer = "six";
                break;
            case '7':
                answer = "seven";
                break;
            case '8':
                answer = "eight";
                break;
            case '9':
                answer = "nine";
                break;

            default:
                answer = "zero";
                break;

        }
        return answer;
    }
}
