using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    class Demon
    {
        public double damage { get; set; }
        public int health { get; set; }
        public string name { get; set; }
    }
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<Demon> demons = new List<Demon>();
        foreach (var item in input)
        {
            var hpSum = 0;
            Regex regex = new Regex(@"[A-Za-z]");
            Regex regexNumbers = new Regex(@"[\-\d.\/]+");
            var matches = regexNumbers.Matches(item);
            double dmg = 0.0;
            Regex divide = new Regex(@"/");
            Regex multiply = new Regex(@"/*");
            var divideNumbers = divide.Matches(item);
            var multiplyNumbers = multiply.Matches(item);
            foreach (Match match in matches)
            {
                dmg += double.Parse(match.ToString());
            }
            foreach (var i in divideNumbers)
            {
                dmg /= 2;
            }
            foreach (var i in multiplyNumbers)
            {
                dmg *= 2;
            }
            foreach (var ch in item.ToCharArray())
            {
                if (char.IsLetter(ch))
                    hpSum += Convert.ToInt32(ch);
            }
            Demon dmn = new Demon();
            dmn.health = hpSum;

        }
    }
}
