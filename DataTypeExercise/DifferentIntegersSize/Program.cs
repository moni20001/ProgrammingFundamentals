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

        sbyte num1;
        byte num2;
        short num3;
        ushort num4;
        int num5;
        uint num6;
        long num7;
        if (long.TryParse(number, out num7) == false)
        {
            Console.WriteLine($"{number} can't fit in any type");
        }
        else
        {


            Console.WriteLine($"{number} can fit in:");
            if (sbyte.TryParse(number, out num1) == true)
            {
                Console.WriteLine($"* sbyte");
            }
            if (byte.TryParse(number, out num2) == true)
            {
                Console.WriteLine($"* byte");
            }
            if (short.TryParse(number, out num3) == true)
            {
                Console.WriteLine($"* short");
            }
            if (ushort.TryParse(number, out num4) == true)
            {
                Console.WriteLine($"* ushort");
            }
            if (int.TryParse(number, out num5) == true)
            {
                Console.WriteLine($"* int");
            }
            if (uint.TryParse(number, out num6) == true)
            {
                Console.WriteLine($"* uint");
            }
            if (long.TryParse(number, out num7) == true)
            {
                Console.WriteLine($"* long");
            }
        }
    }
}
