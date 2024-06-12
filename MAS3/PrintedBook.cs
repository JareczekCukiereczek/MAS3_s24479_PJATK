namespace MAS3;

public class PrintedBook : Book
{
    public string CoverType { get; set; }

    public PrintedBook(string title, string author, int year, int pages, string isbn, string coverType)
        : base(title, author, year, pages, isbn)
    {
        CoverType = coverType;
    }

    public PrintedBook(Book prevBook, string coverType)
        : base(prevBook.Title, prevBook.Author, prevBook.Year, prevBook.Pages, prevBook.ISBN)
    {
        CoverType = coverType;
    }
}