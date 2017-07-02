using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public double Age { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>();
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            else
            {
                var info = input.Split(' ');
                if (info.Length == 3)
                {
                    persons.Add(new Person() { Name = info[0], Age = double.Parse(info[2]), Id = info[1] });
                }
                else if (info.Length == 2)
                {
                    persons.Add(new Person() { Name = info[0], Id = info[1] });
                }
                else
                {
                    persons.Add(new Person() { Name = info[0] });
                }
            }
            
        }
        foreach (var item in persons.OrderBy(age => age.Age))
        {
            Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
        }
    }
}
