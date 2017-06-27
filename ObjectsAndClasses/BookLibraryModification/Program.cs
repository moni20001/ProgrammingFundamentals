using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ISBN { get; set; }
    public double Price { get; set; }
}
class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var dict = new SortedDictionary<string, DateTime>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Library lib = new Library();
            Book curr = new Book();
            lib.Books = new List<Book>();
            lib.Name = "Softuni";
            curr.Title = input[0];
            curr.Author = input[1];
            curr.Publisher = input[2];
            curr.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            curr.ISBN = input[4];
            curr.Price = double.Parse(input[5]);
            lib.Books.Add(curr);
            foreach (var book in lib.Books)
            {
                if (!dict.ContainsKey(book.Title))
                {
                    dict[book.Title] = book.ReleaseDate;
                }
                else
                {
                    dict[book.Title] = book.ReleaseDate;
                }
            }
        }
        DateTime afterDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
        foreach (var book in  dict.OrderBy(p=>p.Value))
        {
            if (book.Value > afterDate)
            {
                string date = book.Value.ToString("dd.MM.yyyy");
                Console.WriteLine($"{book.Key} -> {date}");
            }
        }
    }
}
