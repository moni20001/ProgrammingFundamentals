using System;

class Program
{
    static void Main(string[] args)
    {
        var country = Console.ReadLine().ToLower();
        var count = false;
        if(country=="usa" || country == "england")
        {
            Console.WriteLine("English");
            count = true;
        }
        if (country == "spain" || country == "argentina" || country == "mexico")
        {
            Console.WriteLine("Spanish");
            count = true;
        }
       if(count == false)
        {
            Console.WriteLine("unknown");
        }
    }
}
