namespace Library;

public class Book
{
    public readonly string Title;
    public readonly string Author;
    
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
    
    public override string ToString()
    {
        return $"{Title} by {Author}";
    }
}