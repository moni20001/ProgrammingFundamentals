using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        string last = "";
        bool balanced = true;
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            if(input == "(")
            {
                if(last == "(")
                {
                   
                    balanced = false;
                    break;
                }
                last = "(";
            }
            if(input == ")")
            {
                if(last == "(")
                {
                    balanced = true;
                }
                else
                {
                    balanced = false;
                    break;
                }
                last = ")";
            }
        }
        if(balanced == false || last == "(")
        {
            Console.WriteLine("UNBALANCED");
        }
        else
        {
            Console.WriteLine("BALANCED");
        }
    }
}
