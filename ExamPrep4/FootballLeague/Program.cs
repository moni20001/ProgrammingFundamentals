using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Schema;

class Score
{
    public int points { get; set; }
    public int goals { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        
        string key = Regex.Escape(Console.ReadLine());
        Regex regex = new Regex(String.Format(@"^.*(?:{0})+(?<team1>[a-zA-Z]*)(?:{0}).*(?:{0})+(?<team2>[a-zA-Z]*)(?:{0}).*(?<team1Goals>\d+):(?<team2Goals>\d+).*$", key));
        var teams = new Dictionary<string,Score>();
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "final")
            {
                break;
            }
            var match = regex.Match(input);
            var firstTeamName = new String(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
            var secondTeamName = new String(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
            var firstTeamGoals = int.Parse(match.Groups["team1Goals"].Value);
            var secondTeamGoals = int.Parse(match.Groups["team2Goals"].Value);
           
            if(!teams.ContainsKey(firstTeamName))
                teams[firstTeamName] = new Score();
            if (!teams.ContainsKey(secondTeamName))
                teams[secondTeamName] = new Score();
            teams[firstTeamName].goals += firstTeamGoals;
            teams[secondTeamName].goals += secondTeamGoals;
            if (firstTeamGoals > secondTeamGoals)
                teams[firstTeamName].points += 3;
            if (secondTeamGoals > firstTeamGoals)
                teams[secondTeamName].points += 3;
            if (secondTeamGoals == firstTeamGoals)
            {
                teams[secondTeamName].points += 1;
                teams[firstTeamName].points += 1;
            }
            
        }
        Console.WriteLine("League standings:");
        var standings = teams.OrderByDescending(a => a.Value.points).ThenBy(b => b.Key).ToArray();
        for (int i = 0; i < standings.Length; i++)
        {
            var pos = i + 1;
            Console.WriteLine($"{pos}. {standings[i].Key} {standings[i].Value.points}");
        }
        var arr = teams.OrderByDescending(a => a.Value.goals).ThenBy(a => a.Key).Take(3).ToArray();
        Console.WriteLine("Top 3 scored goals:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"- {arr[i].Key} -> {arr[i].Value.goals}");
        }
    }
    
}