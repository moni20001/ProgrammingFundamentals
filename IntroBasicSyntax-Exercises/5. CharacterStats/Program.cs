using System;

class Program
{
    static void Main(string[] args)
    {
        var name = Console.ReadLine();
        var currHp = int.Parse(Console.ReadLine());
        var maxHp = int.Parse(Console.ReadLine());
        var currEne = int.Parse(Console.ReadLine());
        var maxEne = int.Parse(Console.ReadLine());
        Console.WriteLine("Name: {0}",name);
        Console.WriteLine(@"Health: |{0}{1}|", new string('|',currHp),new string('.',maxHp-currHp));
        Console.WriteLine(@"Energy: |{0}{1}|", new string('|',currEne), new string('.', maxEne-currEne));
    }
}
