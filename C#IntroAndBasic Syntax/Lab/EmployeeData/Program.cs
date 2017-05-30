using System;
class Program
{
    static void Main(string[] args)
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var id = int.Parse(Console.ReadLine());
        var salary = double.Parse(Console.ReadLine());
        Console.WriteLine("Name: {0}",name);
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Employee ID: {id:D8}");
        Console.WriteLine($"Salary: {salary:f2}");
    }
}
