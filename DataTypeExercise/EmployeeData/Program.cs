using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var firstName = Console.ReadLine();
        var secondName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        var personalId = long.Parse(Console.ReadLine());
        var employeeNum = int.Parse(Console.ReadLine());
        Console.WriteLine($"First name: {firstName}\nLast name: {secondName}\nAge: {age}\nGender: {gender}\nPersonal ID: {personalId}\nUnique Employee number: {employeeNum}");
    }
}
