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
        var dict = new Dictionary<int, string>();
        dict[2] = "a";
        dict[22] = "b";
        dict[222] = "c";
        dict[3] = "d";
        dict[33] = "e";
        dict[333] = "f";
        dict[4] = "g";
        dict[44] = "h";
        dict[444] = "i";
        dict[5] = "j";
        dict[55] = "k";
        dict[555] = "l";
        dict[6] = "m";
        dict[66] = "n";
        dict[666] = "o";
        dict[7] = "p";
        dict[77] = "q";
        dict[777] = "r";
        dict[7777] = "s";
        dict[8] = "t";
        dict[88] = "u";
        dict[888] = "v";
        dict[9] = "w";
        dict[99] = "x";
        dict[999] = "y";
        dict[9999] = "z";
        dict[0] = " ";
        string answer = "";
        for (int i = 0; i < n; i++)
        {
            var command = int.Parse(Console.ReadLine());
            answer += $"{dict[command]}"; 
        }
        Console.WriteLine(answer);
    }
}
