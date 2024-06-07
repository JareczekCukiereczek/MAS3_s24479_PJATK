namespace MAS3;

public class Magazine : Material, IBorrowable
{
    public int IssueNumber { get; set; }
    public string Month { get; set; }
    public string CheapPaper = "CheapPaper";
    public Magazine(string title, string author, int year,int issueNumber, string month):base( title,  author,year)
    {
        IssueNumber = issueNumber;
        Month = month;
  
    }
    public void Borrow()
    {
        Console.WriteLine($"Borrow magazine: {Title}");
    }

    public void Return()
    {
        Console.WriteLine($"Return magazine: {Title}");
    }
    
    public override void getTypeOfMaterial()//implementacja metody abstrakcyjna + pokazujemy polimorfizm w ten sposób
    {
        Console.WriteLine("Magazine is made by:  "+CheapPaper);
    }
}
