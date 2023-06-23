// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;


PubContext _context = new PubContext();
//this assumes you are working with the populated
//database created in previous module


//QueryFilters();
//FindIt();
//AddSomeMoreAuthors();
//SkipAndTakeAuthors();
//SortAuthors();
// AddAuthor();
// QueryAggregate();
// UpdateAuthor();
DeleteAuthor(1);


void AddAuthor()
{
    var context = new PubContext();
    var author = new Author
    {
        FirstName = "Bruce",
        LastName = "Dickinson"
    };
    author.Books.Add(new Book()
    {
        Title = "Other book",
        PublishDate = new DateTime(2018, 5, 30)

    });
    author.Books.Add(new Book()
    {
        Title = "Programming Entity Framework",
        PublishDate = new DateTime(2010, 8, 25)
    });
    context.Authors.Add(author);
    context.SaveChanges();
}



void QueryFilters()
{
    //var name = "Josie";
    //var authors=_context.Authors.Where(s=>s.FirstName==name).ToList();
    var filter = "L%";
    var authors = _context.Authors
        .Where(a => EF.Functions.Like(a.LastName, filter)).ToList();
}

void QueryAggregate()
{
    var author = _context.Authors.OrderByDescending(a => a.FirstName)
        .FirstOrDefault(a => a.LastName == "Lerman");
    Console.WriteLine(author?.FirstName + " " + author?.LastName);
}

void SortAuthors()
{
    var authorsByLastName = _context.Authors
        .OrderBy(a => a.LastName)
        .ThenBy(a => a.FirstName).ToList();
    authorsByLastName.ForEach(a => Console.WriteLine(a.LastName + "," + a.FirstName));

    var authorsDescending = _context.Authors
    .OrderByDescending(a => a.LastName)
    .ThenByDescending(a => a.FirstName).ToList();
    Console.WriteLine("**Descending Last and First**");
    authorsDescending.ForEach(a => Console.WriteLine(a.LastName + "," + a.FirstName));
    var lermans = _context.Authors.Where(a => a.LastName == "Lerman").OrderByDescending(a => a.FirstName).ToList();
}

void FindIt()
{
    var authorIdTwo = _context.Authors.Find(2);
}

void AddSomeMoreAuthors()
{
    _context.Authors.Add(new Author { FirstName = "Rhoda", LastName = "Lerman" });
    _context.Authors.Add(new Author { FirstName = "Don", LastName = "Jones" });
    _context.Authors.Add(new Author { FirstName = "Jim", LastName = "Christopher" });
    _context.Authors.Add(new Author { FirstName = "Stephen", LastName = "Haunts" });
    _context.SaveChanges();
}

void SkipAndTakeAuthors()
{
    var groupSize = 2;
    for (int i = 0; i < 5; i++)
    {
        var authors = _context.Authors.Skip(groupSize * i).Take(groupSize).ToList();
        Console.WriteLine($"Group {i}:");
        foreach (var author in authors)
        {
            Console.WriteLine($" {author.FirstName} {author.LastName}");
        }
    }
}

void UpdateAuthor()
{
    var author = _context.Authors.FirstOrDefault(a => a.FirstName == "Julie");
    if (author != null)
    {
        author.FirstName = "Julia";
        _context.SaveChanges();
    }
}

void SaveAuthor(Author author)
{
    using (var context = new PubContext())
    {
        context.Authors.Update(author);
        context.SaveChanges();
    }
}

Author? FindAuthor(int id)
{
    using var context = new PubContext();
    return context.Authors.Find(id);
}

Author? FindAuthorNyName(string firstName)
{
    using var context = new PubContext();
    return context.Authors.FirstOrDefault(a => a.FirstName == firstName);
}

void RetrieveAndUpdateAuthor()
{
    var author = FindAuthorNyName("Julie");
    if (author?.FirstName == "Julie")
    {
        author.FirstName = "Julia";
        SaveAuthor(author);
    }
}

void DeleteAuthor(int id)
{
    var author = _context.Authors.Find(id);
    if (author != null)
    {
        _context.Authors.Remove(author);
        _context.SaveChanges();
    }
}

void InsertMultipleAuthors(IList<Author> authors)
{
    using var context = new PubContext();
    context.Authors.AddRange(authors);
    context.SaveChanges();
}

void UpdateMultipleAuthors(IList<Author> authors)
{
    using var context = new PubContext();
    context.Authors.UpdateRange(authors);
    context.SaveChanges();
}

void DeleteMultipleAuthors(IList<Author> authors)
{
    using var context = new PubContext();
    context.Authors.RemoveRange(authors);
    context.SaveChanges();
}





