using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        char firstBoat = char.Parse(Console.ReadLine());
        char secondBoat = char.Parse(Console.ReadLine());
        int firstBoatAsInt = Convert.ToInt32(firstBoat);
        int secondBoatAsInt = Convert.ToInt32(secondBoat);
        var n = int.Parse(Console.ReadLine());
        int firstBoatMoves = 0;
        int secondBoatMoves = 0;
        for (int i = 1; i <= n; i++)
        {
            var command = Console.ReadLine();
            if(command == "UPGRADE")
            {
                firstBoatAsInt += 3;
                secondBoatAsInt += 3;

            }
            else
            {
                if(i%2 == 0)
                {
                    firstBoatMoves += command.Length;
                }
                else if(i%2 ==1)
                {
                    secondBoatMoves += command.Length;
                }
            }
            if(firstBoatMoves >= 50 || secondBoatMoves >= 50)
            {
                
                break;
            } 
        }
      
        if (secondBoatMoves > firstBoatMoves)
        {
            Console.WriteLine(Convert.ToChar(firstBoatAsInt));
        }
        else
        {
            Console.WriteLine(Convert.ToChar(secondBoatAsInt));
        }
    }
}
