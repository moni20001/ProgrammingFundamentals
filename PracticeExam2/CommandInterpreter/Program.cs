using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var array = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();

        while (true)
        {
            var command = Console.ReadLine();
            if (command == "end")
            {
                break;
            }

            var commandArr = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries) .ToArray();
            if (commandArr[0] == "rollRight")
            {
                var times = int.Parse(commandArr[1]);
                for (int i = 0; i < times; i++)
                {
                    RollRight(int.Parse(commandArr[1]), array);
                }
                
            }
            if (commandArr[0] == "rollLeft")
            {
                var times = int.Parse(commandArr[1]);
                for (int i = 0; i < times; i++)
                {
                   array =  RollLeft(int.Parse(commandArr[1]), array);
                }
            }
        }
        Console.WriteLine(string.Join(" ",array));
    }

    private static long[] RollRight(int parse, long[] commandArr)
    {
        try
        {
            long[] demo = new long[commandArr.Length];
            for (int i = 1; i < commandArr.Length; i++)
            {
                demo[i] = commandArr[i - 1];
            }
            demo[0] = commandArr[demo.Length - 1];
            commandArr = demo;
            return demo;
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input parameters.");
            throw;
        }
    }
    private static void RollLeft(int parse, long[] commandArr)
    {
        try
        {
            long[] demo = new long[commandArr.Length];
            for (int i = 0; i < commandArr.Length-1; i++)
            {
                demo[i] = commandArr[i + 1];
            }
            demo[demo.Length - 1] = commandArr[0];
            commandArr = demo;
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input parameters.");
            throw;
        }
    }
}
