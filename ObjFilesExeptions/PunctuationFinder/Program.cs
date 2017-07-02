using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText("sample_text.txt");
        char[] textInChars = text.ToCharArray();
        List<char> theChars = new List<char>();
        List<char> special = new List<char>()
        {
            '.'
            , ','
            , '!'
           , '?'
           , ':'
        };
        foreach (var ch in textInChars)
        {
            if (special.Contains(ch))
            {
                theChars.Add(ch);
            }
        }
        string final = string.Join(", ", theChars);
        File.WriteAllText("final_text.txt",final);
    }
}
