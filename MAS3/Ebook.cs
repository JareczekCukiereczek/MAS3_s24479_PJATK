namespace MAS3;

public class EBook : Book
{
    public string Format { get; set; }
    public double FileSize { get; set; }

    public EBook(string title, string author, int year, int pages, string isbn, string format, double fileSize)
        : base(title, author, year, pages, isbn)
    {
        Format = format;
        FileSize = fileSize;
    }

    public EBook(Book prevBook, string format, double fileSize)
        : base(prevBook.Title, prevBook.Author, prevBook.Year, prevBook.Pages, prevBook.ISBN)
    {
        Format = format;
        FileSize = fileSize;
    }
}
