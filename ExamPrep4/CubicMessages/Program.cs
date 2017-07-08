using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var pattern = @"^(?<leftside>\d+)(?<msg>[A-Za-z]+)(?<rightside>[^A-Za-z]*)$";
        var regex = new Regex(pattern);
        while (true)
        {
            var input = Console.ReadLine();
            var lenght =int.Parse(Console.ReadLine());
            if (input == "Over!")
                break;
            var msgMatch = regex.Match(input);
            if (!msgMatch.Success)
            {
                continue;
            }
            
            var lengthMsg = regex.Match(input).Groups["msg"].Value;
            var msg = regex.Match(input).Groups["msg"].Value.ToCharArray();
            if (msg.Length != lenght)
            {
                continue;
            }
            
            var leftSideIndexes = regex.Match(input).Groups["leftside"].Value;
            var rightSideIndexes = regex.Match(input).Groups["rightside"].Value;
            string code = leftSideIndexes + rightSideIndexes;

            var verCode = new string(code.Where(ch => char.IsDigit(ch))
                .Select(ch => int.Parse(ch.ToString()))
                .Select(a => a >= 0 && a < lengthMsg.Length ? lengthMsg[a] : ' ').ToArray());

            Console.WriteLine(
            $"{lengthMsg} == {verCode}");

        }
       
    }
}
