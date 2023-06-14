using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData;
public class PubContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

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
        // optionsBuilder.UserSqlLite(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PubDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
