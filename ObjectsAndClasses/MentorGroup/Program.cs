using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Students
{
    public string Name { get; set; }
    public List<DateTime> Dates { get; set; }
    public List<string> Comments { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Students> dict = new Dictionary<string, Students>();

        var input = Console.ReadLine();
        while (input != "end of dates")
        {
            var modified = input.Split(new char[] { '-', ' ', ',' }).ToList();
            Students std = new Students();
            std.Name = modified[0];
            List<DateTime> dates = new List<DateTime>();
            for (int i = 1; i < modified.Count; i++)
            {
                dates.Add(DateTime.ParseExact(modified[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
            }
            if (!dict.ContainsKey(modified[0]))
            {
                dict.Add(modified[0], std);
                std.Dates = dates;
            }
            else
            {
                dict[modified[0]].Dates.AddRange(dates);
            }
            input = Console.ReadLine();
        }

        var comments = Console.ReadLine();
        while (comments != "end of comments")
        {
            var inputInTheComments = comments.Split('-').ToList();
            string name = inputInTheComments[0];
            string comment = inputInTheComments[1];
            List<string> commentss = new List<string>();
            commentss.Add(comment);
            if (dict.ContainsKey(name))
            {
                if (dict[name].Comments != null)
                {
                    dict[name].Comments.AddRange(commentss);
                }
                else
                {
                    dict[name].Comments = commentss;
                }
            }
            comments = Console.ReadLine();
        }
        foreach (var student in dict)
        {
            Console.WriteLine($"{student.Key}");
            Console.WriteLine("Comments:");
            if (student.Value.Comments != null)
            {
                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
            }
            Console.WriteLine($"Dates attended:");
            if (student.Value.Dates != null)
            {
                foreach (var date in student.Value.Dates.OrderBy(p => p))
                {
                    var dattte = date.ToString("dd/MM/yyyy");
                    Console.WriteLine($"-- {dattte}");
                }
            }
        }
    }
}
