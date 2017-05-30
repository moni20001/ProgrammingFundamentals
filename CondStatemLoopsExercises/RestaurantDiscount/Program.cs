using System;

class Program
{
    static void Main(string[] args)
    {
        var size = int.Parse(Console.ReadLine());
        var type = Console.ReadLine();
        var discount = 0.0;
        var price1 = 0.0;
        var price2 = 0.0;
        bool have = false;
        string text = "";
        ///////////////////////////////////////////////
        if(type == "Normal")
        {
            price2 = 500;
            discount = 0.95;
        }
        else if(type == "Gold")
        {
            price2 = 750;
            discount = 0.90;
        }
        else if(type == "Platinum")
        {
            price2 = 1000;
            discount = 0.85;
        }
        ///////////////////////////////////
        if (size <= 50)
        {
            text = "Small Hall";
            price1 = 2500;
        }
        else if(size <=100 && size <= 119)
        {
            text = "Terrace";
            price1 = 5000;
        }
        else if(size <= 120 && size >= 101)
        {
            text = "Great Hall";
            price1 = 7500;
        }
        else
        {
            have = true;
            Console.WriteLine("We do not have an appropriate hall.");
        }
        if(have == false)
        {
            Console.WriteLine($"We can offer you the {text}");
            var pricePerPerson = (price1 + price2) * discount;
            Console.WriteLine($"The price per person is {pricePerPerson / size:F2}$");
        }
        
    }
}
