using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var k = int.Parse(Console.ReadLine());

        int[] sum = new int[array.Length];
        for (int i = 0; i < k; i++)
        {
            RotateArr(array);
            for (int j = 0; j < array.Length; j++)
            {
                sum[j] += array[j];
            }
        }
        Console.WriteLine(string.Join(" ",sum));
    }

    private static void RotateArr(int[] array)
    {
        var lastDigit = array[array.Length - 1];
        for (int i = array.Length-1; i >= 1 ; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = lastDigit;
    }
}
