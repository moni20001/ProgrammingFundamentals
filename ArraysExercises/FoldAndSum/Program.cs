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
        int k = array.Length / 4;
        int[] backup = array;
        int[] leftSide = TakeLeftSide(array, k);
        int[] rightSide = TakeRightSide(array, k);
        int[] middle = TakeMiddle(array, k, backup);
        var leftRight = leftSide.Concat(rightSide).ToArray();
  
        var finalArr = new int[leftRight.Length];
        for (int i = 0; i < leftRight.Length; i++)
        {
            finalArr[i] = leftRight[i] + middle[i];
        }
        Console.WriteLine(string.Join(" ",finalArr));
    }

    private static int[] TakeMiddle(int[] array, int k,int[] backup)
    {
        int[] middle = new int[k * 2];
        middle =  array.Skip(k).Take(2*k).ToArray();
        Array.Reverse(middle);
        return middle;
    }

    private static int[] TakeLeftSide(int[] array, int k)
    {
        int[] leftSide = new int[k];
        for (int i = 0; i < k; i++)
        {
            leftSide[i] = array[i];
        }
        Array.Reverse(leftSide);
        return leftSide;
    }
    private static int[] TakeRightSide(int[] array, int k)
    {
        int[] rightSide = new int[k];
        Array.Reverse(array);
        for (int i = 0; i < k; i++)
        {
            rightSide[i] = array[i];
        }
        return rightSide;
    }

}
