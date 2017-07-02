using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText("sample_text.txt");
        List<string> special = new List<string>() { ".", ",", "!", "?", ":" };
        foreach (var ch in special)
            text = text.Replace(ch, string.Empty);
        File.WriteAllText("final_text.txt", text);
    }
}
