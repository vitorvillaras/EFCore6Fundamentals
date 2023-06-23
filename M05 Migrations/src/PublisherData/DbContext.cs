using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData;
public class PubContext : DbContext
{
    public DbSet<Author> Authors { get; set; } = default!;

    public DbSet<Book> Books { get; set; } = default!;

    private static bool _created = false;

    public PubContext()
    {
        if (!_created)
        {
            _created = true;
            Database.EnsureCreated();
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=pubDb.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Author>().HasData(
        //     new Author { AuthorId = 1, FirstName = "Rhoda", LastName = "Lerman", Address = "123 Main St", BirthDate = new DateTime(1956, 3, 12) });

        // var authorList = new Author[]{
        //         new Author {AuthorId = 2, FirstName = "Ruth", LastName = "Ozeki", Address = "123 Main St", BirthDate = new DateTime(1956, 3, 12) },
        //         new Author {AuthorId = 3, FirstName = "Sofia", LastName = "Segovia" , Address = "123 Main St", BirthDate = new DateTime(1956, 3, 12)},
        //         new Author {AuthorId = 4, FirstName = "Ursula K.", LastName = "LeGuin" , Address = "123 Main St", BirthDate = new DateTime(1956, 3, 12)},
        //         new Author {AuthorId = 5, FirstName = "Hugh", LastName = "Howey" , Address = "123 Main St", BirthDate = new DateTime(1956, 3, 12)},
        //         new Author {AuthorId = 6, FirstName = "Isabelle", LastName = "Allende" , Address = "123 Main St", BirthDate = new DateTime(1956, 3, 12)}
        //     };
        // modelBuilder.Entity<Author>().HasData(authorList);
    }
}
