using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Customer
{
    public string Name { get; set; }
    public Dictionary<string, double> ShopList { get; set; }
    public double Bill { get; set; }
}
class Program
{
    static void Main(string[] args)
    {

        var n = int.Parse(Console.ReadLine());
        var dict = new Dictionary<string, decimal>();
        for (int i = 0; i < n; i++)
        {
            List<string> products = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (!dict.ContainsKey(products[0]))
            {
                dict[products[0]] = decimal.Parse(products[1]);
            }
            else
            {
                dict[products[0]] = decimal.Parse(products[1]);
            }

        }
        
        var command = Console.ReadLine();
        while (command != "end of clients")
        {
            Customer cust = new Customer();
            var name = command.Split('-');
            cust.Name = name[0];
            var quantity = name[1].Split(',');
            cust.ShopList = new Dictionary<string, double>();
            cust.ShopList.Add(quantity[0], double.Parse(quantity[1]));
           command = Console.ReadLine();
        }
       
    }
}
