using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var starting = int.Parse(Console.ReadLine());
        var finish = int.Parse(Console.ReadLine());
        for (int i = starting; i <= finish; i++)
        {
            Console.Write(Convert.ToChar(i)+" ");
        }
    }
}
