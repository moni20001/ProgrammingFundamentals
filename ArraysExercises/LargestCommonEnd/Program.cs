using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var firstArr = Console.ReadLine().Split(' ').ToArray();
        var secondArr = Console.ReadLine().Split(' ').ToArray();
        int leftRight = GetSeqLeft(firstArr, secondArr);
        int rightLeft = GetSeqRight(firstArr, secondArr);
        Console.WriteLine(Math.Max(leftRight,rightLeft));
    }

    private static int GetSeqLeft(string[] firstArr, string[] secondArr)
    {
        var answer = 0;
        bool stillSame = true;
        for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); i++)
        {
            if(firstArr[i] == secondArr[i] && stillSame == true)
            {
                answer++;
            }
            else
            {
                stillSame = false;
            }
        }
        return answer;
    }
    private static int GetSeqRight(string[] firstArr, string[] secondArr)
    {
        var answer = 0;
        bool stillSame = true;
        Array.Reverse(firstArr);
        Array.Reverse(secondArr);
        for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); i++)
        {
            if (firstArr[i] == secondArr[i] && stillSame == true)
            {
                answer++;
            }
            else
            {
                stillSame = false;
            }
        }
        return answer;
    }
}
