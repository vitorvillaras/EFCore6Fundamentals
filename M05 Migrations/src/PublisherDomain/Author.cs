namespace PublisherDomain;

public class Author
{
    public Author()
    {
        Books = new List<Book>();
    }

    public int AuthorId { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Address { get; set; } = default!;

    public DateTime BirthDate { get; set; }
    public List<Book> Books { get; set; }
}