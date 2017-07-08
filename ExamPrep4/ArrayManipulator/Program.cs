using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();
        while (true)
        {
            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (command[0] == "end")
            {
                Console.WriteLine($"[{string.Join(", ", numbers)}]");
                break;
            }

            if (command[0] == "first")
            {
                FirstEvenOdd(command, numbers);
            }
            if (command[0] == "last")
            {
                LastEvenOdd(command, numbers);
            }
            if (command[0] == "exchange")
            {
                Exchange(Convert.ToInt32(command[1]), numbers);
            }
            if (command[0] == "max" || command[0] == "min")
            {
                MaxMin(numbers, command);
            }
        }
    }

    private static void MaxMin(List<int> numbers, List<string> command)
    {
        
        List<int> result = new List<int>();
        bool indexOut = true;
        if (command[0] == "max")
        {

            if (command[1] == "even")
            {
                try
                {
                    result.Add(numbers.LastIndexOf(numbers.Where(a => a % 2 == 0).Max()));
                }
                catch
                {
                    indexOut = false;
                }

            }
            if (command[1] == "odd")
            {
                try
                {
                    result.Add(numbers.LastIndexOf(numbers.Where(a => a % 2 == 1).Max()));
                }
                catch (Exception e)
                {
                    indexOut = false;
                }
            }
        }
        if (command[0] == "min")
        {

            if (command[1] == "even")
            {
                try
                {
                    result.Add(numbers.LastIndexOf(numbers.Where(a => a % 2 == 0).Min()));
                }
                catch
                {
                    indexOut = false;
                }

            }
            if (command[1] == "odd")
            {
                try
                {
                    result.Add(numbers.LastIndexOf(numbers.Where(a => a % 2 == 1).Min()));
                }
                catch (Exception e)
                {
                    indexOut = false;
                }
            }
        }
        if (indexOut = false || result.Count == 0)
        {
            Console.WriteLine("No matches");
        }
        else
            Console.WriteLine(String.Join(string.Empty,result));

    }

    private static void Exchange(int index, List<int> numbers)
    {
        var newInts = new List<int>(numbers.Count);
        if (index < numbers.Count)
        {
            for (int i = index+1; i <= numbers.Count - 1; i++)
            {
                newInts.Add(numbers[i]);
            }
            for (int i = 0; i <= index; i++)
            {
                newInts.Add(numbers[i]);
            }
            for (int i = 0; i < newInts.Count; i++)
            {
                numbers[i] = newInts[i];
            }
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }


    private static void LastEvenOdd(List<string> command, List<int> numbers)
    {
        int count = Convert.ToInt32(command[1]);
        bool done = false;
        if (count > numbers.Count)
        {
            Console.WriteLine("Invalid count");
            done = true;
        }
        if (done == false)
        {
            if (command[2] == "even")
            {
                numbers.Reverse();
                var arr = numbers.Where(a => a % 2 == 0).Take(count).ToArray();
                
                Console.WriteLine($"[{string.Join(", ", arr.Reverse())}]");
                numbers.Reverse();
            }
        }
        if (command[2] == "odd")
        {
            numbers.Reverse();
            var arr = numbers.Where(a => a % 2 == 1).Take(count).ToArray();
            
            Console.WriteLine($"[{string.Join(", ", arr.Reverse())}]");
            numbers.Reverse();
        }
    }


    private static void FirstEvenOdd(List<string> command, List<int> numbers)
    {
        int count = Convert.ToInt32(command[1]);
        bool done = false;
        if (count > numbers.Count)
        {
            Console.WriteLine("Invalid count");
            done = true;
        }
        if (done == false)
        {
            if (command[2] == "even")
            {
                var arr = numbers.Where(a => a % 2 == 0).Take(count).ToArray();

                Console.WriteLine($"[{string.Join(", ", arr)}]");

            }
            if (command[2] == "odd")
            {
                var arr = numbers.Where(a => a % 2 == 1).Take(count).ToArray();

                Console.WriteLine($"[{string.Join(", ", arr)}]");

            }
        }

    }
}
