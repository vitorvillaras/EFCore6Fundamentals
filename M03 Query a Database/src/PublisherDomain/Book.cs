﻿namespace PublisherDomain;
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime PublishDate { get; set; }
    public decimal BasePrice { get; set; }
    public Author Author { get; set; }
}
