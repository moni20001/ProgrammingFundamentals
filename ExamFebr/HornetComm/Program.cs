using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Regex prvMsgPattern = new Regex(@"^(?<firstPart>[0-9]+)\s<->\s(?<secondPart>[0-9A-Za-z]+)$");
        Regex broMsgPattern = new Regex(@"(?<firstPart>[^0-9]+)\s<->\s(?<secondPart>[0-9A-Za-z]+)");
        List<string> messages = new List<string>();
        List<string> prvMessages = new List<string>();
        List<string> broMessages = new List<string>();
        while (true)
        {
            string msg = Console.ReadLine();
            if (msg == "Hornet is Green")
                break;
            messages.Add(msg);
        }
        foreach (var msg in messages)
        {
            if (prvMsgPattern.IsMatch(msg))
            {
                prvMessages.Add(msg);
            }
            if (broMsgPattern.IsMatch(msg))
            {
                broMessages.Add(msg);
            }
        }

        Console.WriteLine("Broadcasts:");
        if (broMessages.Count > 0)
        {
            foreach (var msg in broMessages)
            {
                var inMsg = broMsgPattern.Match(msg);
                var frequancy = inMsg.Groups["secondPart"].Value;
                var message = inMsg.Groups["firstPart"].Value;
                var freqChars = frequancy.ToCharArray();
                StringBuilder str = new StringBuilder();
                foreach (var ch in freqChars)
                {
                    if (char.IsUpper(ch))
                    {
                       str.Append(char.ToLower(ch));
                    }
                    else if (char.IsLower(ch))
                    {
                        str.Append(char.ToUpper(ch));
                    }
                    else
                    {
                        str.Append(ch);
                    }
                }
                Console.WriteLine($"{str} -> {message}");
            }
        }
        else
        {
            Console.WriteLine("None");
        }



        Console.WriteLine("Messages:");
        if (prvMessages.Count > 0)
        {
            foreach (var msg in prvMessages)
            {
                var inMsg = prvMsgPattern.Match(msg);
                var messeage = inMsg.Groups["secondPart"].Value;
                var code = inMsg.Groups["firstPart"].Value;
                Console.WriteLine($"{string.Join(string.Empty,code.Reverse())} -> {messeage}");
            }
        }
        else
        {
            Console.WriteLine("None");
        }
    }
}
