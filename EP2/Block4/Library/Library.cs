namespace Library;

public class Library
{
    public readonly string Name;
    private readonly Dictionary<Book, bool> _books = [];
    private static readonly List<Library> Libraries = [];
    
    public Library(string name)
    {
        Name = name;
        Libraries.Add(this);
    }

    public void AddBook(Book b)
    {
        _books.Add(b, false);
    }

    public void RemoveBook(Book b)
    {
        _books.Remove(b);
    }

    public bool Lend(Book b)
    {
        //if (!_books.TryGetValue(b, out var isLent)) return false;
        //if (isLent) return false;
        //_books[b] = true;
        //return true;

        if (!_books.TryGetValue(b, out var isLent) || isLent) return false;
        _books[b] = true;
        return true;
    }

    public bool GiveBack(Book b)
    {
        //if (!_books.TryGetValue(b, out var isLent)) return false;
        //if (!isLent) return false;
        //_books[b] = false;
        //return true;

        if (!_books.TryGetValue(b, out var isLent) || !isLent) return false;
        _books[b] = false;
        return true;
    }

    public Book? SearchByTitle(string title)
    {
        // foreach (var book in _books.Keys)
        // {
        //     if (book?.Title == title)
        //     {
        //         return book;
        //     }
        // }
        // return null;
        
        return _books.Keys.FirstOrDefault(b => b?.Title == title, null);
    }

    public static Book? SearchAllByTitle(string title)
    {
         // foreach (var lib in Libraries)
         // {
         //     var hit = lib.SearchByTitle(title);
         //     if (hit != null) return hit;
         // }
         // return null; 
        
        return Libraries.Select(lib => lib.SearchByTitle(title)).OfType<Book>().FirstOrDefault();
    }
    
}