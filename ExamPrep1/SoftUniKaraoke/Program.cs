using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var users = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var winners = new Dictionary<string, List<string>>();

        var songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(a => a.Trim()).ToList();
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "dawn")
            {
                break;
            }
            var songAwardAuthor = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(a => a.Trim()).ToList();
            var songAuthor = songAwardAuthor[0];
            var song = songAwardAuthor[1];
            var award = songAwardAuthor[2];
            if (users.Contains(songAuthor) && songs.Contains(song))
            {
                if (winners.ContainsKey(songAuthor))
                {
                    winners[songAuthor].Add(award);
                }
                else
                {
                    winners.Add(songAuthor, new List<string> { award });
                }
            }
        }
        var winnersArr = winners.OrderByDescending(a => a.Value.Distinct().ToList().Count).ThenBy(a => a.Key);
        if (winnersArr.ToArray().Length == 0)
        {
            Console.WriteLine("No awards");
        }
        else
        {
            foreach (var winer in winnersArr)
            {
                Console.WriteLine($"{winer.Key}: {winer.Value.Distinct().Count()} awards");
                foreach (var award in winer.Value.Distinct().ToList().OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
