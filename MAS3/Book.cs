namespace MAS3;

public class Book : Material, IBorrowable, IReservable
{
    public int Pages { get; set; }
    public string ISBN { get; set; }
    public string HighQualityPaper = "HighQualityPaper";

    public Book(string title, string author, int year,int pages, string isbn):base( title,  author,year)
    {
        Pages = pages;
        ISBN = isbn;
  
    }
    public void Borrow()
    {
        Console.WriteLine($"Borrow book: {Title}");
    }

    public void Return()
    {
        Console.WriteLine($"Return book: {Title}");
    }

    public void Reserve()
    {
        Console.WriteLine($"Reserve book: {Title}");
    }

    public override void getTypeOfMaterial()//impelementacja metody abstrakcyjnej + pokazujemy polimorfizm w ten sposób
    {
        Console.WriteLine("Book is made by:  "+HighQualityPaper);
    }
    
}