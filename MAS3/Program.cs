
namespace MAS3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();

            Book book = new Book("C# jest kochany ale nie masy", "Jakub Jaros", 2020, 500, "123456789");
            Magazine magazine = new Magazine("SpajderMen", "Karaluch", 2021, 5, "May");
            

            DVD dvd = new DVD(5, "Producer C", "Pietrek Kogucik - historia prawdziwa", "Pietrek Kogucik", 2024);

            library.AddMaterial(book);
            library.AddMaterial(magazine);
            library.AddMaterial(dvd);
            Console.WriteLine("Polimorfizm1");
            Console.WriteLine("_________________________________________________________");
            book.getTypeOfMaterial();
            dvd.getTypeOfMaterial();
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("Polimorfizm2");
            Console.WriteLine("_________________________________________________________");
            book.Borrow();//ta sama metod co innego sie dzieje
            magazine.Borrow();
            Console.WriteLine("_________________________________________________________");
            //LibraryItem libraryItemBook = new LibraryItem(book);
            //borrow
            //return
            Console.WriteLine("overlapping");
            Console.WriteLine("_________________________________________________________");
            //overlapping
            dvd.addDVDType(DVDenum.BluRay);
            dvd.playHighResulionVideo();
            Console.WriteLine("_________________________________________________________");
            dvd.addDVDType(DVDenum.Kaseta);
            dvd.playTurboLowResulitonVideo();
            
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("Wielodziedziczenie");
            book.Borrow();
            book.Reserve();
            Console.WriteLine(book.Title);
            Console.WriteLine("_________________________________________________________");
            
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine("Dziedziczenei dynamiczne");
            book = new EBook(book, "PDF", 1.5);//przejscie na inny obiekt z klasy Book
            Console.WriteLine("Dziedziczenie dynamiczne - po zmianie na EBook");
            Console.WriteLine(book);
            book = new PrintedBook(book,  "Hard Cover");
            Console.WriteLine("Dziedziczenie dynamiczne - po zmianie na PrintedBook");
            Console.WriteLine(book);
        }
    }
}

/*
-Klasa abstrakcyjna + polifimorfizm
Material jest klasą abstrakcyjną, która definiuje wspólne właściwości dla wszystkich materiałów w biblio Title, Author, Year.

Klasy Book, Magazine i DVD dziedziczą po klasie Material. Umożliwia to różnym typom
materiałów biblitoeki posiadanie własnych implementacji metod Borrow, Return i Reserve, pozwala nam  wywoływanie odpowiednich metod 
 + tak samo z metodą getTypeOfMaterial tez pokazanie polifmorizmu
-Overlapping - spłaszczenie hierarchii
dodanie enum  - w kazdej metodzie odpowiadajace podklasie sprawdzamy w podliscie czy jest dodana podwariant.
DVDenum - dyskryminator (specjalny atrybut)

-Wielodziedziczenie  zrealizowane przez dziedziczenie wielu interfejsów
Klasa Book implementują interfejsy IBorrowable i również IReservable. Pokazujemy wielodziedziczenie przez
implementację wielu interfejsów w klasie book oraz z klasy Material

- Dziedziczenie dynamiczne za pomocą kopiowania -  starego obiektu należącego do pierwotnej klasy nowym, który jest instancją nowej klasy
 z klasy Book dynmiacznie idziemy do ebook a potem do printedBook
W każdej z podklas tworzymy dodatkowe konstruktory. Każdy z nich przyjmuje jako parametr referencję do obiektu nadklasy
 */