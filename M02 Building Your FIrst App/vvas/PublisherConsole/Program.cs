using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;

using (PubContext pubContext = new PubContext())
{
    pubContext.Database.EnsureCreated();
}

GetAuthorsWithBooks();
AddAuthor();
GetAuthorsWithBooks();

void AddAuthor()
{
    var context = new PubContext();
    var author = new Author
    {
        FirstName = "Julie",
        LastName = "Lerman"
    };
    author.Books.Add(new Book()
    {
        Title = "EF Core in Action",
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



void GetAuthorsWithBooks()
{
    using var context = new PubContext();
    var authors = context.Authors.Include(a => a.Books).ToList();
    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
        Console.WriteLine("Books:");
        foreach (var book in author.Books)
        {
            Console.WriteLine("\t" + book.Title);
        }
    }
}