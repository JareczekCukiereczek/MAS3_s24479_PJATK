namespace MAS3;

public abstract class Material
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Material(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public abstract void getTypeOfMaterial();//metoda abstrakcyjna + pokazujemy polimorfizm w ten sposób
}