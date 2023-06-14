// See https://aka.ms/new-console-template for more information
using PublisherData;
using PublisherDomain;

Console.WriteLine("Hello, World!");

var context = new PubContext();

var authors = context.Authors.ToList();

foreach (var author in authors)
{
    Console.WriteLine($"{author.FirstName} {author.LastName}");
}