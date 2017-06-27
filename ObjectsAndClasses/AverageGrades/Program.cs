using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double AvgGrade { get { return Grades.Sum() / Grades.Count; }
}

}
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var dict = new Dictionary<string, double>();
        Student[] students = new Student[n];
        for (int i = 0; i < n; i++)
        {
            var grades = new List<double>();
            var input = Console.ReadLine().Split(' ').ToList();
            foreach (var item in input.Skip(1))
            {
                grades.Add(double.Parse(item));
            }
            students[i] = new Student { Name = input[0], Grades = grades };
        }
        foreach ( Student student in students.Where(x => x.AvgGrade>=5).OrderBy(x=> x.Name).ThenByDescending(x => x.AvgGrade))
        {
            Console.WriteLine($"{student.Name} -> {student.AvgGrade:f2}");
        }
    }
}
