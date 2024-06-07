namespace MAS3;

public class DVD : Material, IBorrowable


{
    public int Duration { get; set; }
    public String PlasticFiber = "plasticFiber";
    public string Format { get; set; }
    public HashSet<DVDenum> DvDenum = new HashSet<DVDenum>();

    public DVD(int duration,string format,string title, string author, int year): base( title,  author,  year)
    {
        Duration = duration;
        Format = format;
    }
    
    public void playHighResulionVideo()
    {
        if (!DvDenum.Contains(DVDenum.BluRay))
        {
            throw new Exception("Play high resoltion video BLURAY");
        }
        Console.WriteLine("Play high resultion video");
    }
    public void playLowResulitonVideo()
    {
        if (!DvDenum.Contains(DVDenum.CD))
        {
            throw new Exception("Play high resoltion video CD");
        }
        Console.WriteLine("Play low resultion video");
    }
    public void playTurboLowResulitonVideo()
    {
        if (!DvDenum.Contains(DVDenum.Kaseta))
        {
            throw new Exception("Play turbo low resoltion video ");
        }
        Console.WriteLine("Play turbo low resultion video");
    }

    public void addDVDType(DVDenum dvDenum)
    {
        DvDenum.Add(dvDenum);
    }
    public void Borrow()
    {
        Console.WriteLine($"Borrow DVD: {Title}");
    }

    public void Return()
    {
        Console.WriteLine($"Return DVD: {Title}");
    }

    public override void getTypeOfMaterial()//implementacja metody abstrakcyjna + pokazujemy polimorfizm w ten sposób
    {
        Console.WriteLine("DVD is made by:  "+PlasticFiber);
    }
}